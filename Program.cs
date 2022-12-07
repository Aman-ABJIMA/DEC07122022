using System;
namespace ArrayProgram
{
    class A
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Name:");
            string a = Console.ReadLine();
       
           string str=null;
     
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
