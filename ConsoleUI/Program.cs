﻿using ExceptionsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            DemoCode demo = new DemoCode();

            try
            {
                int result = demo.GrandParentMethod(4);
                Console.WriteLine($"The value at the givent position is { result }");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("You gave us bad information.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                var inner = ex.InnerException;

                while(inner != null)
                {
                    Console.WriteLine(inner.StackTrace);
                    inner = inner.InnerException;
                }
            }


            Console.ReadLine();
        }
    }
}
