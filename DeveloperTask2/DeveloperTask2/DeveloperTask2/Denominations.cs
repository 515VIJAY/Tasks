using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Denominations
    {

        public static void Denomination(int given_Amt, int remain_Amt, int num, int[] denomination)
        {

            Console.WriteLine("Denominations to match the total with the remaining amount :");
            int highest_quotient = remain_Amt / denomination[0];
            Console.WriteLine(denomination[0] + " " + highest_quotient); 

            int rem_val1 = given_Amt - (highest_quotient * denomination[0]);
            int high_quotient2 = rem_val1 / denomination[1];
            Console.WriteLine(denomination[1] + " " + high_quotient2);

            int rem_val2 = rem_val1 - (high_quotient2 * denomination[1]);
            int high_quotient3 = rem_val2 / denomination[2];
            Console.WriteLine(denomination[2] + " " + high_quotient3);
            Console.ReadKey();

        }
        static void Main(string[] args)
        {
            try
            {
                int[] denomination = new int[3];
                Console.WriteLine("Enter the how many denominations : ");
                int n = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Enter the Values of denominations : ");
                for (int i = 0; i < n; i++)
                {
                    denomination[i] = Convert.ToInt16(Console.ReadLine());
                }
                Array.Sort(denomination);
                Array.Reverse(denomination);

                Console.WriteLine("Enter the Amount Given to Shopkeeper :");
                int Amount_given = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the remaining amount/change :");
                int rem_Value = Convert.ToInt32(Console.ReadLine());

                Denomination(Amount_given, rem_Value, n, denomination);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}



