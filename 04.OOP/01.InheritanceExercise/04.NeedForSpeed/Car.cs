﻿namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }

        public override void Drive(double kilometers)
        {
            Fuel -= kilometers * 3;
        }
    }
}