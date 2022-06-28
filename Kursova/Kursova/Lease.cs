using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursova
{
    public class Lease
    {
        //Constructor - създава по-лесно обект
        public Lease(string id,string adress, string name, DateTime date, double price, int dateDiff)
        {
            ID = id;
            Adress = adress;
            Name = name;
            Date = date;
            Price = price;
            DateDiff = dateDiff;
        }

        //Property
        public string ID { get; set; }
        public string Adress { get;set; }

        public string Name { get; set; }

        public DateTime Date { get; set; }

        public double Price { get; set; }

        public int DateDiff { get; set; }
    }
}
