using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Molina_TriviaGame
{
    class FileIO
    {
        private string fileName;
        private StreamReader infile;

        public FileIO(string fileName)
        {
            this.fileName = fileName;
            try
            {
                infile = new StreamReader(fileName);
            }
            catch
            {

            }
        }
        public StreamReader InFile
        {
            get { return infile; }
        }
    }
}
