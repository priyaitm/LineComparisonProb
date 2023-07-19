using System;

namespace LineCoparisonObj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Length  lengthObj = new Length();
            Double length1 = lengthObj.FindLength(2, 9, 6, 7);
            Double length2 = lengthObj.FindLength(2, 4, 6, 7);
            Console.WriteLine("Line1: "+length1+ "  Line2:  "+ length2);

            //bool result = length1.Equals(length2);
            //if(result == true) {
            //    Console.WriteLine("Lines are equals");
            //}
            //else
            //{
            //    Console.WriteLine("Lines are not equals");
            //}

            int result1 = length1.CompareTo(length2);

            if(result1 == 0)
            {
                Console.WriteLine("Lines are equals");
            }else if(result1 > 0)
            {
                Console.WriteLine("Length1 is greater than length2");
            }else { Console.WriteLine("Length2 is greater than length1"); }


            Console.ReadLine();


        }
    }
}
