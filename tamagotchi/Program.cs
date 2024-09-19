Tamagotchi tama = new();

Console.WriteLine("Vad ska din Tamagotchi heta?");
tama.Name = Console.ReadLine();

while(tama.GetAlive() == true)
{
    Console.WriteLine($"Just nu är {tama.Name}'s stats på:");
    tama.PrintStats();
    

    Console.WriteLine("Vad vill du göra?:");
    Console.WriteLine("""
    1. Lära ord
    2. Mata
    3. Prata
    """);

    string choice = Console.ReadLine();
    if (choice == "1")
    {
        Console.WriteLine("Vilket ord vill du lära?");
        string w = Console.ReadLine();
        tama.Teach(w);
    }

    else if (choice == "2")
    {
        tama.Feed();
        Console.WriteLine($"Du matade {tama.Name} hamburger");
    }

    else if (choice == "3")
    {
        Console.WriteLine($"{tama.Name} säger;");
        tama.Hi();
    }

    tama.Tick();
}


// tama.Teach("hej");
// tama.Teach("heja");
// tama.Teach("hejdå");
// tama.Hi();
tama.PrintStats();

Console.ReadLine();