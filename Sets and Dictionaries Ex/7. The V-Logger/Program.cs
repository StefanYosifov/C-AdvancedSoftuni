using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._The_V_Logger
{
  class Vlogger
    {
        public Vlogger()
        {

        }
        public int MyProperty { get; set; }
        public int Followers { get; set; }
        public int Followings { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var vloggers = new Dictionary<string, Vlogger>();

            while (input!= "Statistics")
            {
                string[] receive=Console.ReadLine().Split(' ').ToArray();
                string name=receive[0];
                string action=receive[1];
                string receiver=receive[2];
                if (name == receiver)
                {
                    continue;
                }
                if (action == "followed")
                {
                    
                    if (!vloggers.ContainsKey(name))
                    {
                        vloggers.Add(name, new Vlogger());
                        vloggers[name].Followings = 1;
                    }
                    if(!vloggers.ContainsKey(receiver))
                    {
                        vloggers.Add(name, new Vlogger());
                        vloggers[receiver].Followings = 1;
                    }
                    vloggers[name].Followings += 1;
                    vloggers[receiver].Followers += 1;
                }
                
                input = Console.ReadLine();
            }

            foreach(var v in vloggers)
            {
                Console.WriteLine(v.Key);
                foreach(var follows in vloggers.Keys)
                {
                    Console.WriteLine($"{v.Value.Followings} {v.Value.Followers}");
                }
            }
        }
    }
}
