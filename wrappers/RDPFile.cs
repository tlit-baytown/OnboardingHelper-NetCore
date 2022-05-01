using OnboardingHelper_NetCore.settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OnboardingHelper_NetCore.wrappers
{
    [XmlType("rdp-file")]
    public class RDPFile
    {
        [XmlElement("path")]
        public string FilePath { get; set; } = string.Empty;

        [XmlElement("file-text")]
        public string RDPFileText { get; set; } = string.Empty;

        [XmlAttribute("computer-name")]
        public string ComputerName { get; set; } = string.Empty;

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

        public RDPFile(string filePath)
        {
            FilePath = filePath;
            ReadFile();
        }

        public RDPFile(string filePath, string fileText)
        {
            FilePath = filePath;
            RDPFileText = fileText;

            //Computer name should be the first entry in the file.
            ComputerName = RDPFileText.Split("\n")[0];
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

                //Computer name should be the entry that starts with 'full address' in the file.
                string[] lines = RDPFileText.Split("\n");
                int addressLine = lines.ToList().FindIndex(s => s.StartsWith("full address"));
                string line = lines[addressLine];
                ComputerName = line[(line.LastIndexOf("s:") + 2)..];

                return true;
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
