using System;
namespace ArrayProgram
{
    class A
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name:");
            string a = Console.ReadLine();
          //  Console.WriteLine("Enter Length of Array:");
          //  int size = Convert.ToInt16(Console.ReadLine());
         //   char[] a = new char[size];
           string str=null;
           // Console.WriteLine("Enter {0} elements into an array:",size);
          //  for(int i=0; i<size; i++)
          //  {
           //     a[i]=Convert.ToChar(Console.ReadLine());
          //  }
            for(int i=0; i<a.Length;i++)
            {
                for(int j=0;j<=i;j++)
                {
                    str = str + a[j];
                }
                str = str + ",";
            }
            Console.WriteLine("\n"+str+"\b ");

        }
    }
}