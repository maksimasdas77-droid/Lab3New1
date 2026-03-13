using Lab3New1;

internal class Program
{
    private static void Main(string[] args)
    {
        Car car1 = new Car();
        car1.Name = "Рахич";
        car1.Model = "Ракета";
        car1.Tankvol = 50;
        car1.Gasvol = 40;
        car1.Speed = 200;
        car1.Fuelconsumption = 4;
        car1.PressureWheel = new int[] { 5, 2, 2, 4 };
        Console.WriteLine(car1.ToString());
        Console.Write("Еще сможет проехать ");
        Console.WriteLine(car1.Lost());
        car1.Hole();
        if (car1.Speed == 0) Console.WriteLine("Автомобиль остановлен");

        Car car2 = new Car("дракон", "рыгалет", 10, 10, 10, 4, 1, 1, 1, 1);
        Console.WriteLine(car2.ToString());
        Console.Write("Еще сможет проехать ");
        Console.WriteLine(car2.Lost());
        car2.Hole();
        if (car2.Speed == 0) Console.WriteLine("Автомобиль остановлен");

        Car car3 = new Car("метла", "конвеер", 100, 40, 90, 10, new int[] { 1, 0, 5, 5 });
        Console.WriteLine(car3.ToString());

        Console.Write("Еще сможет проехать ");
        Console.WriteLine(car3.Lost());
        car3.Hole();
        if (car3.Speed == 0) Console.WriteLine("Автомобиль остановлен");

        Car car4 = new Car("тачила", "атлас", 200, 40, 90, 10, 2, 2, 2, 5);
        Console.WriteLine(car4.ToString());
        Console.Write("Еще сможет проехать ");
        Console.WriteLine(car4.Lost());
        car4.Hole();
        if (car4.Speed == 0) Console.WriteLine("Автомобиль остановлен");

        if (car1.Faster(car2))
        {
            Console.WriteLine($"автомобиль {car1.Name} быстрее {car2.Name}");
        }
        else
        { 
            Console.WriteLine($"автомобиль {car2.Name} быстрее {car1.Name}");
        }
        if (car2.Faster(car3))
        {
            Console.WriteLine($"автомобиль {car2.Name} быстрее {car3.Name}");
        }
        else
        {
            Console.WriteLine($"автомобиль {car3.Name} быстрее {car2.Name}");
        }
        Car fastest = Car.TheFstest(car1, car2, car3);
        Console.Write("Самый быстрый автомобиль: " + fastest.Name);
      

        Console.ReadLine();
    }
}