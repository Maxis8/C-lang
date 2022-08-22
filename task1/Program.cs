        Console.Write("Введите первое число: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int b = int.Parse(Console.ReadLine());
        int sqr_b = Convert.ToInt32(Math.Pow(b, 2));     
        if (a ==  sqr_b)
        {
            Console.WriteLine("Yes");
        }
        else
        { 
            Console.WriteLine("No");
        } 
