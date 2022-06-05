using System;
using System.Collections.Generic;
using System.Linq;

namespace _9._Pokemon_Trainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            List<Trainer> trainers = new List<Trainer>();
            while (input != "Tournament")
            {
                string[] information=input.Split(' ').ToArray();
                string trainerName=information[0];
                string pokemonName=information[1];
                string pokemonElement=information[2];
                int pokemonHealth=int.Parse(information[3]);
                Trainer trainer=trainers.First(x=>x.Name==trainerName);
                if (trainer != null)
                {
                    Pokemon pokemon=new Pokemon(pokemonName,pokemonElement,pokemonHealth);
                    trainer.Collection.Add(pokemon);
                }
                else
                {
                    Trainer newTrainer = new Trainer(trainerName);
                    Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                    newTrainer.Collection.Add(pokemon);
                }

                input = Console.ReadLine();
            }

            input=Console.ReadLine();
            while (input != "End")
            {
                for (int i = 0; i < trainers.Count; i++)
                {
                    if (!trainers[i].Collection.Any(x => x.Element == input))
                    {
                        foreach (var item in trainers[i].Collection)
                        {
                            item.ReduceHealth();

                        }
                    }
                    else
                    {
                        trainers[i].IncreaceNumberOfBadges();
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var item in trainers)
            {
                item.Collection.RemoveAll(x => x.Health <= 0);
            }
            trainers.OrderByDescending(x => x.NumberOfBadgets).ToList().ForEach(x => Console.WriteLine($"{x.Name} {x.NumberOfBadgets} {x.Collection.Count}"));

        }
    }
}
