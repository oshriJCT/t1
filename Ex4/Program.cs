using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ex4
{
    class MyException : Exception
    {
        public MyException(string message) : base(message)
        {
        }
    }
    class Program
    {
        static int getAge()
        {
            try
            {
                
                throw new MyException("ABCD");
            }
            catch (Exception e)
            {
                Console.WriteLine("Source: " + e.Source);
                Console.WriteLine("Message: " + e.Message);
                Console.WriteLine("HelpLink: " + e.HelpLink);
                return 0;
            }
            finally
            {
                Console.WriteLine("after catch Block I'm still working");
            }
            Console.WriteLine("after catch Block I'm not working");
        }


        // <summary>
        // הפונקציה מחברת שני מספרים
        // </summary>
        // <param name="x">המספר הראשון</param>
        // <param name="y">המספר השני</param>
        // <returns>חיבור המספרים</returns>
        public static int Sum(int x,int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            getAge();
            //int z = Sum(2, 3);

            int x = 4;
            int? y = (int?)x;
            int z = (int)y;

           
        }
    }

}
