using Microsoft.VisualBasic;
using System;
namespace ArrayProgram
{
    class A
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name:");
            string a = Console.ReadLine();
            
            string str = null;
        
            string vl = "";
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j <= a.Length; j++)
                {
                    vl = (vl + a.Substring(i, j - i)) + " ,";
                }
            }
            Console.Write(vl);

        }
    }
}
