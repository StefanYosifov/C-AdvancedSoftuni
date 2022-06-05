using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Car_Salesman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int loops=int.Parse(Console.ReadLine());
            List<Engine> listEngine = new List<Engine>();
            Engine engines = new Engine();



            for(int i = 0; i < loops; i++)
            {
                string[] information=Console.ReadLine().Split(' ').ToArray();
                string engine=information[0];
                int horsePower=int.Parse(information[1]);
                if(information.Length == 2)
                {
                    engines=new Engine(engine,horsePower);
                }

                int displacement;
                string efficiency;
                if (information.Length == 3)
                {
                    
                    int.TryParse(information[2], out displacement);
                    if(displacement > 0)
                    {
                        engines = new Engine(engine, horsePower, displacement);
                    }
                    else
                    {
                        efficiency =information[2];
                        engines = new Engine(engine, horsePower, efficiency);
                    }
                   
                }
                if(information.Length == 4)
                {
                    displacement = int.Parse(information[2]);
                    efficiency=information[3];
                    engines = new Engine(engine, horsePower, displacement, efficiency);
                }

                listEngine.Add(engines);
            }

            Car car = new Car();
            List<Car> cars=new List<Car>();
            int secondLoops = int.Parse(Console.ReadLine());


            for(int i=0; i < loops; i++)
            {
                string[] carInformation=Console.ReadLine().Split(' ').ToArray();
                string carModel=carInformation[0];
                string carEngine=carInformation[1];
                Engine addCarEngine= listEngine.Where(x => x.Model == carModel).FirstOrDefault();

                
                if(carInformation.Length == 2)
                {
                    car = new Car(carModel, addCarEngine);
                }

                int weight;
                string color;

                if (carInformation.Length == 3)
                {
                    int.TryParse(carInformation[2], out weight);
                    if(weight > 0)
                    {
                        car=new Car(carModel, addCarEngine,weight);
                    }
                    else
                    {
                        color=carInformation[2];
                        car=new Car(carModel,addCarEngine,color);
                    }
                }

                if (carInformation.Length == 4)
                {
                    weight = int.Parse(carInformation[2]);
                    color = carInformation[3];
                    car = new Car(carModel, addCarEngine, weight, color);
                }
                cars.Add(car);
            }

            string output=cars.ToString();
            Console.WriteLine(output);

        }
    }
}
