﻿using System;

namespace Interfaces
{

    interface IMovable
    {


        void Move();
    }


    class Car : IMovable
    {

        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }


    class Bicycle : IMovable
    {

        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Movable
    {
        static void Main(string[] args)
        {

            IMovable car = new Car();
            IMovable bicycle = new Bicycle();


            car.Move(); // outputs: Car is moving
            bicycle.Move(); // outputs: Bicycle is moving
        }
    }
}