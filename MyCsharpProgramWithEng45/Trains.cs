using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainStationSystem
{
    public class TrainStation
    {
        private int numberOfDrivers;
        private List<string> driversNames = new List<string>();
        private string stationName;

        public TrainStation()
        {
            numberOfDrivers = 0;
            stationName = "NO STATION NAME";
        }

        public TrainStation(string enteredStationName)
        {
            stationName = enteredStationName;
            SetNumberOfDrivers();
            SetDriversNames();
        }
       
        public string GetStationName()
        {
            return stationName;
        }

        /// <summary>
        /// A function to see how many drivers are assigned to the station
        /// </summary>
        /// <returns>returns an int that is the number of assigned people at object creation</returns>
        public int GetNumberOfdrivers()
        {
            return numberOfDrivers;
        }

        /// <summary>
        /// returns the drivers name based on their position in the array of drivers names
        /// </summary>
        /// <param name="whichDriver"></param>
        /// <returns>a string of just a single drivers name</returns>
        public string DiversName(int whichDriver)
        {
            try
            {
                return driversNames[whichDriver];
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
                return DiversName(Convert.ToInt32(Console.ReadLine()));
            }
        }

        /// <summary>
        /// sets the number of drivers, part of the constructor
        /// </summary>
        private void SetNumberOfDrivers()
        {
            Console.WriteLine("Enter how many drivers are there at this station?");
            try
            {
                numberOfDrivers = Convert.ToInt32(Console.ReadLine());
            }
            catch(System.FormatException e)
            {
                Console.WriteLine(e.Message);
                SetNumberOfDrivers();
            }
        }

        /// <summary>
        /// sets the drivers names in ascending order, part of the consutrctor
        /// </summary>
        private void SetDriversNames()
        {
            for (int i = 1; numberOfDrivers >= i; i++)
            {
                string tokenName = "";
                Console.WriteLine($"Enter drivers number {i} name");
                tokenName = Console.ReadLine();
                while (tokenName == "" || tokenName.Any(c => char.IsDigit(c)))
                {
                    Console.WriteLine("Please enter a valid name");
                    tokenName = Console.ReadLine();
                }
                driversNames.Add(tokenName);
            }
        }
    }

    public class StationRota : TrainStation
    {
        //int numberOfCarrages;
        //int totalSeats;
        //int freeSeats;
        //int standingSpace;
        //int peopleOnBoard;
    }




}
