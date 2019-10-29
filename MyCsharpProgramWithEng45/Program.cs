using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrainStationSystem;

namespace TrainLines
{
    class Program
    {
        static void Main(string[] args)
        {
            bool programExit = false;
            int caseSwitch = 0;
            TrainStation globalStation = new TrainStation();

            while (!programExit)
            { 
                Console.WriteLine("Please select an option for " + globalStation.GetStationName() + ": " +
                    "\n 1: create a train station " +
                    "\n 2: search for a specific drivers name in the station" +
                    "\n 3: Out of Service" +
                    "\n 4: Out of Service" +
                    "\n 5: Out of Service" +
                    "\n 6: Out of Service" +
                    "\n 7: Out of Service" +
                    "\n 8: Out of Service" +
                    "\n 9: Exit");
                try
                {
                    caseSwitch = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.Write("invalid entry");
                    break;
                }
                switch (caseSwitch)
                {
                    case 0:
                        Console.Write("\nThis wasn't even an option! \n \n");
                        break;
                    case 1:
                        Console.WriteLine("\n Please enter the stations name!");
                        globalStation = new TrainStation(Console.ReadLine());
                            break;
                    case 2:
                        CheckDriverByNumber(globalStation);
                        break;
                    case 3:
                        Console.Write("\nNothing to see, going back! \n \n");
                        break;
                    case 4:
                        Console.Write("\nNothing to see, going back! \n \n");
                        break;
                    case 5:
                        Console.Write("\nSeriously Nothing to see, going back! \n \n");
                        break;
                    case 6:
                        Console.Write("\nYou don't believe me do you? \n \n");
                        break;
                    case 7:
                        Console.Write("\nEven here? really! \n \n");
                        break;
                    case 8:
                        Console.Write("\nOkay you got me, do 9 and hit y for the good stuff \n \n");
                        break;
                    case 9:
                        Console.WriteLine("Would you like to exit? y/n");
                        if (Console.ReadLine().ToLower() == "y")
                            programExit = !programExit;
                        break;
                }


            }
        }


        static void CheckDriverByNumber(TrainStation trainObject)
        {
            bool looper = true;
            while (looper)
            {
                if(trainObject.GetNumberOfdrivers() == 0)
                {
                    Console.WriteLine("To do this you need to first create a station!");
                    break;
                }
                int driverNumber = 0;
                Console.WriteLine("Which drivers name do you want to see?");
                try
                {
                    driverNumber = Convert.ToInt32(Console.ReadLine());
                }
                catch (System.FormatException e)
                {
                    Console.WriteLine(e.Message);
                    continue;
                }
                Console.WriteLine(trainObject.DiversName(driverNumber - 1) + " Is this the correct dirvers name? Y/N");
                if (Console.ReadLine().ToLower() == "y")
                    looper = false;
            }
        }
    }
}
