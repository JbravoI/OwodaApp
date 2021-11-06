using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwodaApp
{
    class process
    {
        public int MID { get; set; } = 0;
        public int DID { get; set; } = 0;
        public int Daily { get; set; } = 100;
        public int Monthly { get; set; } = 1500;

        public int ChooseOption { get; set; } = 1;
        
        public long TagID()
        {
            Random _random = new Random();
            long randomNum = _random.Next(0, 50000000);
            
            return randomNum;
        }


        public double Ticketing ()
        {
            Console.WriteLine("NURTW Payment platform \n kindly input the function to perform Press 1 to continue 2 to exit");
            int chooseOpt = Int32.Parse(Console.ReadLine());
            if (chooseOpt == 1)
            {
                while (ChooseOption == 1)
                {
                    Console.WriteLine("kindly input the mode of payment below \n \n  (1=> Daily payment, 2 => montly, 3 => Calculate summary & exit \n ");
                    int money = Int32.Parse(Console.ReadLine());
                    if (money == 1)
                    {
                        DID++;
                        DateTime recieptTime = DateTime.Now;
                        Console.WriteLine($"You just paid in # { Daily } only for daily duration\n");
                        Console.WriteLine($"Your reciept number is {TagID()} registered at {recieptTime} \n");

                    }
                    else if (money == 2)
                    {
                        MID++;
                        DateTime recieptTime = DateTime.Now;
                        Console.WriteLine($"You just paid in # { Monthly } only for daily duration\n");
                        Console.WriteLine($"Your reciept number is {TagID()} registered at {recieptTime} \n");
                       
                    }

                    else
                    {
                        Console.WriteLine();
                        int returns = (MID * 1500) + (DID * 1500);
                        Console.WriteLine($"Your income for today is {returns}\n");

                        double Chairman, agbero;
                        Chairman = 0.65 * returns;
                        Console.WriteLine($"Chairman`s pay for today is {Chairman}\n");

                        agbero = 0.35 * returns;
                        Console.WriteLine($"Your pay for today is {agbero}\n");

                        process stop = new process();
                        Console.WriteLine($"Thanks for using Owoda App \n Press any to exit{stop.Ticketing()}");
                        ChooseOption++;


                        Console.ReadKey();
                    }
                }
            }
            return 0;
        }


    }
}
