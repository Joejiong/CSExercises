using System;

namespace CSExercises
{
    ///Write a C# program that would keep prompting you to enter an integer number over and over again until you enter the number 88. If you enter 88 the computer should say: 
  	//	“Lucky you…” 
    //and exit the program.


    public class ExD1
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            int num = 0; ////
            bool con = true;
            do
            {
                Console.WriteLine("please write in number(0~100)");
               num = Convert.ToInt16(Console.ReadLine ());
                if (num == 88)
                {
                    con = false;
                }
            } while (con);
            Console.WriteLine("lucky you....");

            
            

        }
    }
}
