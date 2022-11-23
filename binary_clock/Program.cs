using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace binary_clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;
            
            string ora = Processing(hour);                         
            string minut = Processing(minute);                                      
            string secunda = Processing(second);                                     
            
            for (int i=0;i<6;i++)
            {
                Console.WriteLine($" {ora[i]}  {minut[i]}  {secunda[i]}   {(Math.Pow(2, i))}");
            }
            Console.WriteLine(" *  *  *");
            Console.WriteLine(" O  M  S");
            Console.WriteLine(" r  i  e");
            Console.WriteLine(" a  n  c");
        }

        private static string Processing(int n)
        {
            List<string> myList = new List<string>();
            if (n == 0)
                myList.Add("O");

            while (n > 0)
            {
                int r = n % 2;
                string h = r.ToString();
                myList.Add(h);
                n /= 2;

            }
            for (int i = 0; i < myList.Count; i++)
            {
                if (myList[i].Contains("1"))
                    myList[i] = "X";
                if (myList[i].Contains("0"))
                    myList[i] = "O";
            }
            string x = String.Join("", myList);
            
            while(x.Length < 6)
            {
                x = x + "O";
            }
            return x;
        }
    }
}
