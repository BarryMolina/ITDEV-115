using System;
using static System.Console;

namespace Properties
{
    class PropertiesApp
    {
        static void Main(string[] args)
        {
            Properties property = new Properties();

            property.Num2 = 42;
            WriteLine(property.Num2);

            property.Number = 15;
            WriteLine(property.Number);

            property.Word = "pandas";
            WriteLine(property.Word);

            WriteLine(property.getNumWord());


        }
    }
}
