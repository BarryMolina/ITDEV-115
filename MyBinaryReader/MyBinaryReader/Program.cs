using System;
using System.IO;
using static System.Console;

namespace MyBinaryReader
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream;
            BinaryReader binaryReader;

            Write("Enter name of the file: ");
            string fileName = ReadLine();

            try
            {
                fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                binaryReader = new BinaryReader(fileStream);

                RetrieveAndDisplayData(binaryReader);

                binaryReader.Close();
                fileStream.Close();
            }
            catch (FileNotFoundException e)
            {
                Error.WriteLine(e.Message);
            }
            catch (InvalidDataException e)
            {
                Error.WriteLine(e.Message);
            }
            catch (EndOfStreamException e)
            {
                Error.WriteLine(e.Message);
            }
            catch (IOException e)
            {
                Error.WriteLine(e.Message);
            }
            ReadKey();
        }

        public static void RetrieveAndDisplayData(BinaryReader binaryReader)
        {
            WriteLine(binaryReader.ReadString());

            for (int i = 0; i < 11; i++)
            {
                WriteLine(binaryReader.ReadInt32());
            }

            WriteLine(binaryReader.ReadDecimal());
        }
    }
}
