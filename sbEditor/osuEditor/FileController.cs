using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace osuEditor
{
    class FileController
    {
        public string FilePath { get; set; }
        public bool Saved { get; set; }

        public FileController()
        {
            Saved = false;
            FilePath = "";
        }

        public string[] ReadFile()
        {
            TextReader tr = new StreamReader(FilePath);
            string line = tr.ReadLine();
            List<String> lines = new List<string>();

            while ( line != null )
            {
                lines.Add(line);
                line = tr.ReadLine();
            }
            tr.Close();

            return lines.ToArray();
        }

        public void SaveFile(string lines)
        {
            StreamWriter file = new StreamWriter(FilePath);
            file.WriteLine(lines);

            file.Close();
        }
    }
}
