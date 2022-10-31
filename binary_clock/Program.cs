﻿using System;
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
            List<int> ora = new List<int>();
            List<int> minut = new List<int>();
            List<int> secunda = new List<int>();
            List<string> ora_s = new List<string>();
            List<string> minut_s = new List<string>();
            List<string> secunda_s = new List<string>();

            if (hour == 0)
                ora.Add(0);

            while (hour > 0)
            {
                r = hour % 2;
                hour /= 2;
                ora.Add(r);
            }
            ora.Reverse();

            if (minute == 0)
                minut.Add(0);

            while (minute > 0)
            {
                r = minute % 2;
                minute /= 2;
                minut.Add(r);
            }
            minut.Reverse();

            if(second == 0)
                secunda.Add(0);

            while (second > 0)
            {
                r = second % 2;
                second /= 2;
                secunda.Add(r);
            }
            secunda.Reverse();

            foreach (int i in ora)
            {
                h = i.ToString();
                ora_s.Add(h);
            }

            foreach (int i in minut)
            {
                h = i.ToString();
                minut_s.Add(h);
            }

            foreach (int i in secunda)
            {
                h = i.ToString();
                secunda_s.Add(h);

            }
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
                ora_s.Insert(0, "O");
                ora_s.Insert(0, "O");
            }

            if(ora_s.Count == 3)
            {
                ora_s.Insert(0, "O");
                ora_s.Insert(0, "O");
                ora_s.Insert(0, "O");
            }

            if(ora_s.Count == 2)
            {
                ora_s.Insert(0, "O");
                ora_s.Insert(0, "O");
                ora_s.Insert(0, "O");
                ora_s.Insert(0, "O");
            }

            if (ora_s.Count == 1)
            {
                ora_s.Insert(0, "O");
                ora_s.Insert(0, "O");
                ora_s.Insert(0, "O");
                ora_s.Insert(0, "O");
                ora_s.Insert(0, "O");
            }

            if (minut_s.Count == 5)
                minut_s.Insert(0, "O");

            if (minut_s.Count == 4)
            {
                minut_s.Insert(0, "O");
                minut_s.Insert(0, "O");
            }

            if (minut_s.Count == 3)
            {
                minut_s.Insert(0, "O");
                minut_s.Insert(0, "O");
                minut_s.Insert(0, "O");
            }

            if (minut_s.Count == 2)
            {
                minut_s.Insert(0, "O");
                minut_s.Insert(0, "O");
                minut_s.Insert(0, "O");
                minut_s.Insert(0, "O");
            }

            if (minut_s.Count == 1)
            {
                minut_s.Insert(0, "O");
                minut_s.Insert(0, "O");
                minut_s.Insert(0, "O");
                minut_s.Insert(0, "O");
                minut_s.Insert(0, "O");
            }

            if (secunda_s.Count == 5)
                secunda_s.Insert(0, "O");

            if (secunda_s.Count == 4)
            {
                secunda_s.Insert(0, "O");
                secunda_s.Insert(0, "O");
            }

            if (ora_s.Count == 3)
            {
                secunda_s.Insert(0, "O");
                secunda_s.Insert(0, "O");
                secunda_s.Insert(0, "O");
            }

            if (secunda_s.Count == 2)
            {
                secunda_s.Insert(0, "O");
                secunda_s.Insert(0, "O");
                secunda_s.Insert(0, "O");
                secunda_s.Insert(0, "O");
            }

            if (secunda_s.Count == 1)
            {
                secunda_s.Insert(0, "O");
                secunda_s.Insert(0, "O");
                secunda_s.Insert(0, "O");
                secunda_s.Insert(0, "O");
                secunda_s.Insert(0, "O");
            }

            Console.WriteLine(String.Join("", ora_s) + " Hour");
            Console.WriteLine(String.Join("", minut_s) + " Minute");
            Console.WriteLine(String.Join("", secunda_s) + " Second");
             

        }
    }
}