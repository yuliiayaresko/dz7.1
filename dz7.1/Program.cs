﻿using System;

namespace AbstractFactory
{
    public class AbstractFactory
    {
        // AbstractProductA
        abstract class Car
        {
            public abstract void Info();
        }

        // ConcreteProductA1
        class Ford : Car
        {
            public override void Info()
            {
                Console.WriteLine("Ford");
            }
        }

        // ConcreteProductA2
        class Toyota : Car
        {
            public override void Info()
            {
                Console.WriteLine("Toyota");
            }
        }

        // ConcreteProductA3 (Mersedes)
        class Mersedes : Car
        {
            public override void Info()
            {
                Console.WriteLine("Mersedes");
            }
        }

        // AbstractProductB
        abstract class Engine
        {
            public virtual void GetPower()
            {
            }
        }

        // ConcreteProductB1
        class FordEngine : Engine
        {
            public override void GetPower()
            {
                Console.WriteLine("Ford Engine 4.4");
            }
        }

        // ConcreteProductB2
        class ToyotaEngine : Engine
        {
            public override void GetPower()
            {
                Console.WriteLine("Toyota Engine 3.2");
            }
        }

        // ConcreteProductB3 (MersedesEngine)
        class MersedesEngine : Engine
        {
            public override void GetPower()
            {
                Console.WriteLine("Mersedes Engine 5.0");
            }
        }

        // AbstractFactory
        interface ICarFactory
        {
            Car CreateCar();
            Engine CreateEngine();
        }

        // ConcreteFactory1
        class FordFactory : ICarFactory
        {
            public Car CreateCar()
            {
                return new Ford();
            }

            public Engine CreateEngine()
            {
                return new FordEngine();
            }
        }

        // ConcreteFactory2
        class ToyotaFactory : ICarFactory
        {
            public Car CreateCar()
            {
                return new Toyota();
            }

            public Engine CreateEngine()
            {
                return new ToyotaEngine();
            }
        }

        // ConcreteFactory3 (MersedesFactory)
        class MersedesFactory : ICarFactory
        {
            public Car CreateCar()
            {
                return new Mersedes();
            }

            public Engine CreateEngine()
            {
                return new MersedesEngine();
            }
        }

        static void Main(string[] args)
        {
            ICarFactory carFactory = new ToyotaFactory();
            Car myCar = carFactory.CreateCar();
            myCar.Info();
            Engine myEngine = carFactory.CreateEngine();
            myEngine.GetPower();

            carFactory = new FordFactory();
            myCar = carFactory.CreateCar();
            myCar.Info();
            myEngine = carFactory.CreateEngine();
            myEngine.GetPower();

            carFactory = new MersedesFactory(); // Використання нової фабрики Mersedes
            myCar = carFactory.CreateCar();
            myCar.Info();
            myEngine = carFactory.CreateEngine();
            myEngine.GetPower();

            Console.ReadKey();
        }
    }
}
