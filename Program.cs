using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


        
            namespace _Terning_
    {
        class Program
        {
            static void Main(string[] args)
            {
                Random value = new Random();
                int terning = 0, seksere = 0, kast = 0;




                terning = value.Next(1, 7);

                Console.WriteLine("Terningen slår = {0} ", terning);



                Console.ReadLine();






            }
        }
    }

    

