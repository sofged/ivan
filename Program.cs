using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<string> history = new List<string>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nВыберите операцию:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Возведение в степень");
            Console.WriteLine("6. Логарифм (основание 10)");
            Console.WriteLine("7. Синус");
            Console.WriteLine("8. Косинус");
            Console.WriteLine("9. Тангенс");
            Console.WriteLine("10. Квадратный корень");
            Console.WriteLine("11. Показать историю");
            Console.WriteLine("12. Экспортировать историю в TXT");
            Console.WriteLine("13. Выход");

            string choice = Console.ReadLine();

            if (choice == "13")
            {
                Console.WriteLine("Выход из программы.");
                break;
            }

            double result = 0;

            try
            {
                switch (choice)
                {
                    case "1":
                        result = Add(out string addExpression);
                        history.Add($"Сложение: {addExpression} = {result}");
                        break;
                    case "2":
                        result = Subtract(out string subtractExpression);
                        history.Add($"Вычитание: {subtractExpression} = {result}");
                        break;
                    case "3":
                        result = Multiply(out string multiplyExpression);
                        history.Add($"Умножение: {multiplyExpression} = {result}");
                        break;
                    case "4":
                        result = Divide(out string divideExpression);
                        history.Add($"Деление: {divideExpression} = {result}");
                        break;
                    case "5":
                        result = Power(out string powerExpression);
                        history.Add($"Возведение в степень: {powerExpression} = {result}");
                        break;
                    case "6":
                        result = Logarithm(out double logInput);
                        history.Add($"Логарифм (по основанию 10): log({logInput}) = {result}");
                        break;
                    case "7":
                        result = Sine(out double sineInput);
                        history.Add($"Синус: sin({sineInput}) = {result}");
                        break;
                    case "8":
                        result = Cosine(out double cosineInput);
                        history.Add($"Косинус: cos({cosineInput}) = {result}");
                        break;
                    case "9":
                        result = Tangent(out double tangentInput);
                        history.Add($"Тангенс: tan({tangentInput}) = {result}");
                        break;
                    case "10":
                        result = SquareRoot(out double sqrtInput);
                        history.Add($"Квадратный корень: sqrt({sqrtInput}) = {result}");
                        break;
                    case "11":
                        ShowHistory();
                        continue;
                    case "12":
                        ExportHistory();
                        continue;
                    default:
                        Console.WriteLine("Неверный выбор. Пожалуйста, выберите действие из списка.");
                        continue;
                }

                Console.WriteLine($"Результат: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }

    static double Sine(out double angle)
    {
        Console.WriteLine("Введите угол в градусах:");
        angle = Convert.ToDouble(Console.ReadLine());
        return Math.Sin(DegreeToRadian(angle));
    }
}
