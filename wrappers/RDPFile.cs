using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnboardingHelper_NetCore.wrappers
{
    public class RDPFile
    {
        public string FilePath { get; set; } = string.Empty;

        public string RDPFileText { get; private set; } = string.Empty;

        public string ComputerName { get; set; } = string.Empty;

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
