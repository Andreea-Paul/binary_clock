using System;
using System.Collections.Generic;
using System.Linq;
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
            
            int r;
            string h;
            
            List<string> ora_s = new List<string>();
            List<string> minut_s = new List<string>();
            List<string> secunda_s = new List<string>();

            if (hour == 0)
                ora_s.Add("O");

            while (hour > 0)
            {
                r = hour % 2;
                h=r.ToString();
                ora_s.Add(h);
                hour /= 2;
                
            }
            ora_s.Reverse();

            if (minute == 0)
                minut_s.Add("O");

            while (minute > 0)
            {
                r = minute % 2;
                h = r.ToString();
                minut_s.Add(h);
                minute /= 2;
                
            }
            minut_s.Reverse();

            if(second == 0)
                secunda_s.Add("O");

            while (second > 0)
            {
                r = second % 2;
                h = r.ToString();
                secunda_s.Add(h);
                second /= 2;
                
            }
            secunda_s.Reverse();

            
            for (int i = 0; i < ora_s.Count; i++)
            {
                if (ora_s[i].Contains("1"))
                    ora_s[i] = "X";
                if (ora_s[i].Contains("0"))
                    ora_s[i] = "O";
            }

            for (int i = 0; i < minut_s.Count; i++)
            {
                if (minut_s[i].Contains("1"))
                    minut_s[i] = "X";
                if (minut_s[i].Contains("0"))
                    minut_s[i] = "O";
            }

            for (int i = 0; i < secunda_s.Count; i++)
            {
                if (secunda_s[i].Contains("1"))
                    secunda_s[i] = "X";
                if (secunda_s[i].Contains("0"))
                    secunda_s[i] = "O";
            }
            
            if (ora_s.Count == 5)
                ora_s.Insert(0, "O");

            if (ora_s.Count == 4)
            {
                ora_s.Insert(0, "OO");
            }

            if(ora_s.Count == 3)
            {
                ora_s.Insert(0, "OOO");
            }

            if(ora_s.Count == 2)
            {
                ora_s.Insert(0, "OOOO");
            }

            if (ora_s.Count == 1)
            {
                ora_s.Insert(0, "OOOOO");
            }

            if (minut_s.Count == 5)
                minut_s.Insert(0, "O");

            if (minut_s.Count == 4)
            {
                minut_s.Insert(0, "OO");
            }

            if (minut_s.Count == 3)
            {
                minut_s.Insert(0, "OOO");
            }

            if (minut_s.Count == 2)
            {
                minut_s.Insert(0, "OOOO");
            }

            if (minut_s.Count == 1)
            {
                minut_s.Insert(0, "OOOOO");
            }

            if (secunda_s.Count == 5)
                secunda_s.Insert(0, "O");

            if (secunda_s.Count == 4)
            {
                secunda_s.Insert(0, "OO");
            }

            if (ora_s.Count == 3)
            {
                secunda_s.Insert(0, "OOO");
            }

            if (secunda_s.Count == 2)
            {
                secunda_s.Insert(0, "OOOO");
            }

            if (secunda_s.Count == 1)
            {
                secunda_s.Insert(0, "OOOOO");
            }

            Console.WriteLine(String.Join("", ora_s) + " Hour");
            Console.WriteLine(String.Join("", minut_s) + " Minute");
            Console.WriteLine(String.Join("", secunda_s) + " Second");
             

        }
    }
}
