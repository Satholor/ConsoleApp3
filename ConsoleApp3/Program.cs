using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring variable
            int x;
            //int 1x; // never do that
            //name with two words
            int bigBonus;
            //int x-1; // not allowed
                       //C# is case sensitive
                       //rate, Rate , RATE are three diffrent var.

            //Data Types 
            //byte      1       0 to 255
            //short     2       -32.768 to 32,767
            //int       4       -2,147,483,648 to 2,147,483,647
            //long      8       -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            //sbyte     1       - 128 to + 127
            //ushort    2       0 to 65,535
            //uint      4       0 to 4,294,967,295
            //ulong     8       0 to 18,446,744,073,709,551,615
            //char      2       U + 0000 to U=ffff(All Unicode characters)
            //float     4       7 digits    
            //double    8       15-16
            //decimal   16      28-29
            //bool      true , false 

            //short test = 32768; you are off by one 
            char favoriteLetter = 'c';
            favoriteLetter = '&';
            Console.WriteLine(favoriteLetter);
            //Assignment Statements
            int area;// 0
            int length = 5;
            area = length * length
            area = length * 8;
            //int y = 2.99; //; can not do that

            //Constants

            Console.ReadLine();
        }
    }
}
