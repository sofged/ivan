}
    static void ShowHistory()
    {
        Console.WriteLine("\nИстория вычислений:");
        foreach (var entry in history)
        {
            Console.WriteLine(entry);
        }
    }
    //main
}
