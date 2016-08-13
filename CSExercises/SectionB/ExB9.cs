using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company problem above, 
    //calculate the fare so that the fare is always 
    //rounded upwards to the nearest 10 cents. 
    //This is harder than the previous problem 
    //and requires your ingenuity

    public class ExB9
    {
        public static void Main(string[] args)
        {
            //YOUR CODE HERE
            Console.Write("input how many miles you have driven !");
            double d = Convert.ToDouble(Console.ReadLine());
            double fare = CalculateFare(d);
            Console.Write("the total fare is {0:$0.00}", fare);
        }

        public static double CalculateFare(double distance)
        {
            //YOUR CODE HERE

            return  (2.40 + distance * 0.4);

        }
    }
}
