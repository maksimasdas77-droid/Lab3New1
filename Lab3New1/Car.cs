using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3New1
{
    internal class Car
    {
        string? name;
        string? model;
        int tankvol;
        int gasvol;
        int speed;
        int fuelconsumption;
        int[] pressureWheel = new int[4];

        public Car():this("рахич", "ракета", 50, 30, 10, 4)
        {
        }

        public Car(string? name, string? model, int tankvol, int gasvol, int speed, int fuelconsumption)
        {
            Name = name;
            Model = model;
            Tankvol = tankvol;
            Gasvol = gasvol;
            Speed = speed;
            Fuelconsumption = fuelconsumption;
        }

        public Car(string? name, string? model, int tankvol, int gasvol, int speed, int fuelconsumption, params int[] pressureWheel) 
            : this(name, model, tankvol, gasvol, speed, fuelconsumption)
        {
            PressureWheel = pressureWheel;
        }

        public string? Name { get => name; set => name = value; }
        public string? Model { get => model; set => model = value; }
        public int Tankvol
        {
            get => tankvol;
            set
            {
                if (value > 0)
                tankvol = value;
            }
        }
        public int Gasvol
        {
            get => gasvol;
            set
            {
                if (value > 0 && value<=Tankvol)
                gasvol = value;
            }
        }
        public int Speed
        {
            get => speed;
            set
            {
                if (value >= 0 && value <300)
                speed = value;
            }
        }
        public int Fuelconsumption
        {
            get => fuelconsumption;
            set
            {
                if (value > 0)
                fuelconsumption = value;
            }
        }
        public int[] PressureWheel
        {
            get => pressureWheel;
            set
            {
                for(int i = 0; i < value.Length && i < pressureWheel.Length; i++)
                {
                    if(value[i] >= 0 && value[i] <= 5)
                        pressureWheel[i] = value[i];
                }
            }
        }

        public double Lost()
        {
            return (gasvol / fuelconsumption * 100);
        }

        public void Hole()
        {
            for(int i = 0; i < pressureWheel.Length; i++)
            {
                if (pressureWheel[i] < 1) Speed = 0;
            }

        }

        public bool Faster(Car other)
        {
            return this.Speed > other.Speed;
        }
            public static Car? TheFstest(Car car1, Car car2, Car car3)
            {
                if (car1.speed > car2.speed && car1.speed > car3.speed) return car1;
                if (car2.speed > car3.speed) return car2;
                else return car3;
            }
        
        public override string? ToString()
        {
            return $"{name} {model} {tankvol} {gasvol} {speed} {fuelconsumption} " + $"{pressureWheel[0]}-{pressureWheel[1]}-{pressureWheel[2]}-{pressureWheel[3]}";
        }
    }
}
