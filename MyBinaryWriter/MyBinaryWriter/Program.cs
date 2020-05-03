using System;
using System.IO;
using static System.Console;

namespace MyBinaryWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream;
            BinaryWriter binWriter;
            Write("Enter name of the file: ");
            string filename = ReadLine();

            if (File.Exists(filename))
            {
                WriteLine("File = {0} already exists!", filename);
            }
            else
            {
                fileStream = new FileStream(filename, FileMode.CreateNew);
                binWriter = new BinaryWriter(fileStream);

                decimal aValue = 2.16M;

                binWriter.Write("Sample Run");

                for (int i = 0; i < 11; i++)
                {
                    binWriter.Write(i);
                }

                binWriter.Write(aValue);

                binWriter.Close();
                fileStream.Close();

                WriteLine("File created successfully");
            }
            ReadKey();
                
        }
    }
}
