﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RORZE
{
    class Program
    {
        static void Main(string[] args)
        {
            ITest  aaa = new ImpITest();
            Console.WriteLine(aaa.testing());
            Console.ReadLine();
        }
    }
}
