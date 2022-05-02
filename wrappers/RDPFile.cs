using System.ComponentModel;
using System.Xml.Serialization;

namespace Zest_Script.wrappers
{
    /// <summary>
    /// Represents an RDP (remote desktop protocol) file.
    /// </summary>
    [XmlType("rdp-file")]
    public class RDPFile
    {
        /// <summary>
        /// The path to the RDP file.
        /// </summary>
        [XmlElement("path")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The path to the RDP file to include.")]
        [DisplayName("Path")]
        [Category("RDP Information")]
        public string FilePath { get; set; } = string.Empty;

        /// <summary>
        /// The full text of the RDP file read from <see cref="FilePath"/>.
        /// </summary>
        [XmlElement("file-text")]
        [Browsable(false)]
        public string RDPFileText { get; set; } = string.Empty;

        /// <summary>
        /// The name of the computer this RDP file connects to. Parsed from <see cref="RDPFileText"/>.
        /// </summary>
        [XmlAttribute("computer-name")]
        [Browsable(true)]
        [ReadOnly(true)]
        [Description("The computer name this RDP file connects to. This is automatically set from the file's text.")]
        [DisplayName("Computer Name")]
        [Category("RDP Information")]
        public string ComputerName { get; set; } = string.Empty;

        /// <summary>
        /// Create an empty RDPFile.
        /// </summary>
        public RDPFile() { }

        /// <summary>
        /// Creates an RDP file with the contents present in <see cref="RDPFileText"/>, if possible.
        /// This method attempts creation at <see cref="FilePath"/>.
        /// </summary>
        /// <returns><c>True</c> if the file was created. <c>False</c> otherwise.</returns>
        /// <exception cref="FormatException">Thrown if <see cref="RDPFileText"/> is empty.</exception>
        public bool CreateIfNotExists()
        {
            if (!File.Exists(FilePath))
            {
                if (!RDPFileText.Equals(string.Empty))
                {
                    File.WriteAllText(FilePath, RDPFileText);
                    return true;
                }
                else
                    throw new FormatException("RDPFileText was empty! No text to create file with.");
            }
            return false;
        }

        /// <summary>
        /// Create an RDP file from the specified path and read its contents into <see cref="RDPFileText"/> if valid. 
        /// The <see cref="ComputerName"/> is automatically set from <see cref="RDPFileText"/>.
        /// </summary>
        /// <param name="filePath"></param>
        public RDPFile(string filePath)
        {
            FilePath = filePath;
            ReadFile();
        }

        /// <summary>
        /// Create an RDP file with the specified path and file text. 
        /// The <see cref="ComputerName"/> is automatically set from the <paramref name="fileText"/>.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="fileText"></param>
        public RDPFile(string filePath, string fileText)
        {
            FilePath = filePath;
            RDPFileText = fileText;

            FindComputerName();
        }

        private bool ReadFile()
        {
            if (!File.Exists(FilePath))
                return false; //File does not exist.

            if (!FilePath.EndsWith(".rdp"))
                return false; //File is not an RDP file.

            try
            {
                RDPFileText = File.ReadAllText(FilePath);
                return FindComputerName();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        private bool FindComputerName()
        {
            try
            {
                string[] lines = RDPFileText.Split("\n");

                //Computer name should be the entry that starts with 'full address' in the file.
                int addressLine = lines.ToList().FindIndex(s => s.StartsWith("full address"));
                string line = lines[addressLine];
                ComputerName = line[(line.LastIndexOf("s:") + 2)..];
                return true;
            }
            catch (Exception)
            { return false; }
        }
    }
}
