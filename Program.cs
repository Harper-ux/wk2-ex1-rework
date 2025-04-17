using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace wk2_ex1_rework
{
    internal class Program
    {
        static void Main(string[] args)


        { 
            //Declare variables

            int principle = 0; // principle amount in integer
            double interestRate = 0; // interest rate in double 
            int time = 0;
            //title
            Console.WriteLine("Welcome to interest calculator Program "); //title

            Console.WriteLine("Please enter the principle amount in dollars : ");//get user input for the principle amount
            principle = Convert.ToInt32(Console.ReadLine()); //user input stored as a varible
            Console.WriteLine("Please enter the interest rate in percentage : "); //get user input for the interest rate
            interestRate = Convert.ToDouble(Console.ReadLine());//user input stored as a varible
            Console.WriteLine("please enter the time in years : "); //get user input for the time
            time = Convert.ToInt32(Console.ReadLine());//user input stored as a varible
            double interest = (principle * interestRate * time) / 100; //calulate the interest

            Console.WriteLine("The total interest for the loan is : " + interest); //display the interest
        }
    }
}
