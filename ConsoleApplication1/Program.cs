﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.AutoFlush = true;

            Console.WriteLine();
            
        
            //Debug.Fail("adsfadsf");
            TextWriterTraceListener tr2 = new TextWriterTraceListener(File.CreateText("Out.txt"));
            Debug.Listeners.Add(tr2);
            Debug.WriteLine("dab");


        }
    }
}
