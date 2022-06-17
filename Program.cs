using System;
using System.Linq;
using System.IO;
using System.Collections;
using System.Collections.Generic;

namespace ChusovLeonid_4_variant
{
    class Program
    {
      /*  class Player
        {
            public string Name { get; set; }
            public int number1 { get; set; }

        }
        class Team
        {
            public string Name { get; set; }

            public char set { get; set; }
        }*/


        static void Main(string[] args)
        {
           

            StreamReader sr = File.OpenText("set.txt");
            StreamReader sr1 = File.OpenText("num.txt");
            StreamReader sr2 = File.OpenText("col.txt");
            StreamWriter fil = File.CreateText("file.txt");
            string temp = sr.ReadLine();
            string temp1 = sr1.ReadLine();
            string temp2 = sr2.ReadLine();
            string[] txt = temp.Split(' ');
            string[] txt1 = temp1.Split(' ');
            string[] txt2 = temp2.Split(' ');
            Console.WriteLine("генерации декартового произведения из трех наборов");
            var generacia = from simvoli in txt
                            from number in txt1
                            from colors in txt2
                            select new {simvoli, number, colors };
            foreach (var n in generacia)
            {
            Console.WriteLine(n);
            fil.WriteLine(n);  
            }
            fil.Close();
            sr.Close();
            sr1.Close();
            sr2.Close();





        }
    }
}
