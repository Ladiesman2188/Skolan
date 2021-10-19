using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    
        
        

    class Program
    {
        static void Main(string[] args)
        {
            Random slump = new Random();

            Console.WriteLine("Välkommen till lyckohjulet!");
            Console.WriteLine("Välj ett tal från 1 - 100");
            int användarensTal = int.Parse(Console.ReadLine());
            int hjuletsTal = slump.Next(1, 100);

            Console.WriteLine($"Hjulet stannade på {hjuletsTal}");
            if (användarensTal == hjuletsTal)
            {
                Console.WriteLine("Du vann!");
            }
            
            {
                if (användarensTal < hjuletsTal)
                Console.WriteLine("Talet är för lågt");

                if(användarensTal > hjuletsTal)
                Console.WriteLine("talet är för högt"); 

            }

            Console.ReadKey();

        }
    
    }
    }
        