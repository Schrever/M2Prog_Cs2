namespace _01_functions;

class Program
{
    string[] vragen = new string[]
        {
            "What 1997 N64 video game features James Bond and is named after the 1995 film?",
            "What arcade game was called Puckman in Japan?",
            "How long do you think you would survive in a zombie apocalypse?",
            "What secret conspiracy would you like to actually start letting other people know?",
            "If you can still remember, what are your funniest childhood memories?",
            "What would you do if you won a million dollars?",
            "What is the worst game you played but that you liked anyway?"
        };

    static void Main(string[] args)
    {
        Program program = new Program();
        program.Run();
    }

    void Run()
    {
        Console.WriteLine();
        Vraag1();
        Vraag2();
        Vraag3();
        Vraag4();
        Vraag5();
        string antwoord7 = Vraag7();
        Console.WriteLine(antwoord7);

        string vraag = GetVraag(0);
        Console.WriteLine("Extra vraag: " + vraag);
    }


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

    string Vraag7()
    {
        Console.WriteLine("What is the worst game you played but that you liked anyway?");
        string antwoord = Console.ReadLine();
        return antwoord;

    }


    string GetVraag(int vraagIndex)
    {
        return vragen[vraagIndex];
    }



}
