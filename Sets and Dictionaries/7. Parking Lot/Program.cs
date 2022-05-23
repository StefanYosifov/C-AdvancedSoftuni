using System;
using System.Collections.Generic;

namespace _7._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command=Console.ReadLine();
            HashSet<string> carNumber=new HashSet<string>();
            while(command!= "END")
            {
                string[] commandArray=command.Split(", ",StringSplitOptions.RemoveEmptyEntries);
                string InOrOut=commandArray[0];
                string carPlate=commandArray[1];
                if (InOrOut == "IN")
                {
                    carNumber.Add(carPlate);
                }
                else if(InOrOut == "OUT")
                {
                    carNumber.Remove(carPlate);
                }

                command = Console.ReadLine();
            }

            if (carNumber.Count == 0)
            {
                Console.WriteLine($"Parking Lot is Empty");
                return;
            }
            foreach(var carPlate in carNumber)
            {
                Console.WriteLine(carPlate);    
            }
        }
    }
}
