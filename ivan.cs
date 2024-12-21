
    static double Add(out string expression)
    {
        Console.WriteLine("Введите два числа, разделенные пробелом:");
        string[] inputs = Console.ReadLine().Split(' ');
        double a = Convert.ToDouble(inputs[0]);
        double b = Convert.ToDouble(inputs[1]);
        expression = $"{a} + {b}";
        return a + b;
    }

    static double Subtract(out string expression)
    {
        Console.WriteLine("Введите два числа, разделенные пробелом:");
        string[] inputs = Console.ReadLine().Split(' ');
        double a = Convert.ToDouble(inputs[0]);
        double b = Convert.ToDouble(inputs[1]);
        expression = $"{a} - {b}";
        return a - b;
    }

    static double Multiply(out string expression)
    {
        Console.WriteLine("Введите два числа, разделенные пробелом:");
        string[] inputs = Console.ReadLine().Split(' ');
        double a = Convert.ToDouble(inputs[0]);
        double b = Convert.ToDouble(inputs[1]);
        expression = $"{a} * {b}";
        return a * b;
    }

    static double Divide(out string expression)
    {
        Console.WriteLine("Введите два числа, разделенные пробелом:");
        string[] inputs = Console.ReadLine().Split(' ');
        double a = Convert.ToDouble(inputs[0]);
        double b = Convert.ToDouble(inputs[1]);
        if (b == 0)
        {
            throw new DivideByZeroException("Деление на ноль невозможно.");
        }
        expression = $"{a} / {b}";
        return a / b;
    }

    static double Power(out string expression)
    {
        Console.WriteLine("Введите число и степень, разделенные пробелом:");
        string[] inputs = Console.ReadLine().Split(' ');
        double baseNum = Convert.ToDouble(inputs[0]);
        double exponent = Convert.ToDouble(inputs[1]);
        expression = $"{baseNum} ^ {exponent}";
        return Math.Pow(baseNum, exponent);
    }

    static double Logarithm(out double input)
    {
        Console.WriteLine("Введите число для вычисления логарифма (по основанию 10):");
        input = Convert.ToDouble(Console.ReadLine());
        return Math.Log10(input);
    }

    static double Sine(out double angle)
    {
        Console.WriteLine("Введите угол в градусах:");
        angle = Convert.ToDouble(Console.ReadLine());
        return Math.Sin(DegreeToRadian(angle));
    }

    static double Cosine(out double angle)
    {
        Console.WriteLine("Введите угол в градусах:");
        angle = Convert.ToDouble(Console.ReadLine());
        return Math.Cos(DegreeToRadian(angle));
    }

    static double Tangent(out double angle)
    {
        Console.WriteLine("Введите угол в градусах:");
        angle = Convert.ToDouble(Console.ReadLine());

      
        if (Math.Abs(angle % 180) == 90)
        {
            throw new InvalidOperationException("Тангенс не определен.");
        }

        return Math.Tan(DegreeToRadian(angle));
    }


    static double SquareRoot(out double input)
    {
        Console.WriteLine("Введите число для вычисления квадратного корня:");
        input = Convert.ToDouble(Console.ReadLine());
        if (input < 0)
        {
            throw new InvalidOperationException("Невозможно вычислить квадратный корень из отрицательного числа.");
        }
        return Math.Sqrt(input);
    }

    static double DegreeToRadian(double degree)
    {
        return degree * (Math.PI / 180);
    }

    static void ShowHistory()
    {
        Console.WriteLine("\nИстория вычислений:");
        foreach (var entry in history)
        {
            Console.WriteLine(entry);
        }
    }

    static void ExportHistory()
    {
        Console.WriteLine("Введите имя файла для экспорта (без расширения):");
        string fileName = Console.ReadLine();
        string filePath = $"{fileName}.txt";

        File.WriteAllLines(filePath, history);
        Console.WriteLine($"История вычислений экспортирована в файл: {filePath}");
    }
}