﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal animal = null;
            AnimalFactory animalfactory = null;
            string soundreturn = null;

            //create respective factory class objects
            animalfactory = AnimalFactory.CreateAnimalFactory("cea");
           
            Console.WriteLine("Animal Factory type chosen is :" + " "+ animalfactory.GetType().Name);
            Console.WriteLine();

            //get a sea animal object
            animal = animalfactory.GetAnimal("Shark");
            Console.WriteLine("Animal chosen is :" + " " + animal.GetType().Name);
            soundreturn = animal.speak();
            Console.WriteLine(soundreturn);
            
            Console.WriteLine("-------------------------------");
            animalfactory = AnimalFactory.CreateAnimalFactory("Land");
            Console.WriteLine("Animal Factory type chosen is :" + " " + animalfactory.GetType().Name);
           
            //get a land animal object
            animal = animalfactory.GetAnimal("Dog");
            Console.WriteLine("Animal chosen is :" + " " + animal.GetType().Name);
            soundreturn = animal.speak();
            Console.WriteLine(soundreturn);
            Console.Read();
        }
    }
}
