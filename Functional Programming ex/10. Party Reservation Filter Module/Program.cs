using System;
using System.Linq;

namespace _10._Party_Reservation_Filter_Module
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names=Console.ReadLine().Split(' ').ToArray();
            string token=Console.ReadLine();
            while (token != "Print")
            {
                string[] commands=token.Split(';');
                string command=commands[0];
                if(command=="Add filter")
                {
                    string action=commands[1];
                    string letter=commands[2];


                }
                if(command=="Remove filter")
                {

                }

                token = Console.ReadLine();
            }
        }
    }
}
