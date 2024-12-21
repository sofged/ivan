
    static double Sine(out double angle)
    {
        Console.WriteLine("Введите угол в градусах:");
        angle = Convert.ToDouble(Console.ReadLine());
        return Math.Sin(DegreeToRadian(angle));
    }
