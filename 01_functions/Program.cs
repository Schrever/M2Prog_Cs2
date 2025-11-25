namespace _01_functions;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    void Run()
    //hier komt je function
    {
        Console.WriteLine();
        Vraag1();
        Vraag2();
        Vraag3();
        Vraag4();
        Vraag5();
    }

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        void Vraag1()
    {
        Console.WriteLine("How long do you think you would survive in a zombie apocalypse?");
        string antwoord = Console.ReadLine();
        Console.WriteLine(antwoord);
    }
    void Vraag2()
    {
        Console.WriteLine("What secret conspiracy would you like to actually start letting other people know?");
        string antwoord = Console.ReadLine();
        Console.WriteLine(antwoord);
    }
    void Vraag3()
    {
        Console.WriteLine("If you can still remember, what are your funniest childhood memories?");
        string antwoord = Console.ReadLine();
        Console.WriteLine(antwoord);
    }
    void Vraag4()
    {
        Console.WriteLine("What would you do if you won a million dollars?");
        string antwoord = Console.ReadLine();
        Console.WriteLine(antwoord);
    }
    void Vraag5()
    {
        Console.WriteLine("What is the worst game you played but that you liked anyway?");
        string antwoord = Console.ReadLine();
        Console.WriteLine(antwoord);
    }
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

}
