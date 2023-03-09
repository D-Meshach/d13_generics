﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d13_generic_up
{
    
    internal class Program
    {
        static void Main(string[] args)
        {

            String exit = "n";
            while (exit == "n") {
                Console.WriteLine("Enter \n 1)Maximum among three Non Generic \n 2) Maximum among three using generic \n 3)Maximum among Multiple Inputs \n 4) Print Max output");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option) 
                {

                    case 1://Maximum Among Three without Generics
                           NonGenerics nonGenerics = new NonGenerics();
                           break;
                    case 2://Maximum among three using Generics
                        WithGenerics withGenerics = new WithGenerics();
                        break;
                    case 3://Maximum among more than three using generics
                        MultipleInputs multipleInputs = new MultipleInputs();
                        break;
                    case 4://Printmax with output added
                        GenericPrintMax<double> printMax = new GenericPrintMax<double>();
                        break;
                    default: Console.WriteLine("Enter Valid option");break;

                }
                
                Console.WriteLine("Do you want to quit (y/n)?");
                exit = Convert.ToString(Console.ReadLine());

            }
            

            

            
           
            


        }
    }
}
