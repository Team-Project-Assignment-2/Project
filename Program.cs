using System;

namespace Team_software_project
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int a = 0;
            Console.WriteLine("Welcome to the animal house!");
            Console.WriteLine("What do you want to do? [list, quit]");
            string[] animals = { "bear", "cat", "dog", "bird", "wolf", "tiger", "elephant", "sloth" };
            string answer = Console.ReadLine();
            while (true)
            {
                while (!string.IsNullOrEmpty(answer))
                {
                    if (answer == "quit")
                    {
                        return;
                    }
                    if (answer == "list")
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Here they are:");
                        foreach (string all in animals)
                        {
                            Console.WriteLine(all);
                        }
                        Console.WriteLine("");
                        Console.WriteLine("Which animal do you want to see? Choose animal by typing its name");
                        string animal = Console.ReadLine();
                        try
                        {
                            if (animal == "bear")
                            {
                                int weight = 0;
                                string name = "bear";
                                while (true)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("What do you want to do? [Eat, MakeSound, ComeHere, GiveName, back, quit]");
                                    string action = Console.ReadLine();
                                    try
                                    {
                                        if (action == "back")
                                        {
                                            break;
                                        }
                                        if (action == "quit")
                                        {
                                            Environment.Exit(0);
                                        }
                                        if (action == "Hunt")
                                        {
                                            a = rand.Next(0, 10);
                                            if (a < 6)
                                            {
                                                weight++;
                                                Console.WriteLine("Hunt was successful, " + name + " gains 1 kg and weighs now " + weight + " kg");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Hunt failed, " + name + " still weights " + weight + " kg");
                                            }
                                        }
                                        if (action == "Eat")
                                        {
                                            weight++;
                                            Console.WriteLine(name + " eats, gains 1 kg and weighs now " + weight + " kg");
                                        }
                                        if (action == "MakeSound")
                                        {
                                            Console.WriteLine("Growl");
                                        }
                                        if (action == "ComeHere")
                                        {
                                            Console.WriteLine(name + " walks to you");
                                        }
                                        if (action == "GiveName")
                                        {
                                            Console.WriteLine("Give a name:");
                                            name = Console.ReadLine();
                                            Console.WriteLine("bear is now called " + name);
                                        }
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("Invalid input");
                                    }
                                }

                            }
                            if (animal == "cat")
                            {
                                int weight = 0;
                                string name = "cat";
                                while (true)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("What do you want to do? [Eat, MakeSound, ComeHere, GiveName, back, quit]");
                                    string action = Console.ReadLine();
                                    try
                                    {
                                        if (action == "back")
                                        {
                                            break;
                                        }
                                        if (action == "quit")
                                        {
                                            Environment.Exit(0);
                                        }
                                        if (action == "Eat")
                                        {
                                            weight++;
                                            Console.WriteLine(name + " eats, gains 1 kg and weighs now " + weight + " kg");
                                        }
                                        if (action == "MakeSound")
                                        {
                                            Console.WriteLine("Meow");
                                        }
                                        if (action == "ComeHere")
                                        {
                                            Console.WriteLine(name + " walks to you");
                                        }
                                        if (action == "GiveName")
                                        {
                                            Console.WriteLine("Give a name:");
                                            name = Console.ReadLine();
                                            Console.WriteLine("cat is now called " + name);
                                        }
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("Invalid input");
                                    }
                                }
                            }
                            if (animal == "dog")
                            {
                                int weight = 0;
                                string name = "dog";
                                while (true)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("What do you want to do? [Eat, MakeSound, ComeHere, GiveName, back, quit]");
                                    string action = Console.ReadLine();
                                    try
                                    {
                                        if (action == "back")
                                        {
                                            break;
                                        }
                                        if (action == "quit")
                                        {
                                            Environment.Exit(0);
                                        }
                                        if (action == "Eat")
                                        {
                                            weight++;
                                            Console.WriteLine(name + " eats, gains 1 kg and weighs now " + weight + " kg");
                                        }
                                        if (action == "MakeSound")
                                        {
                                            Console.WriteLine("Woof");
                                        }
                                        if (action == "ComeHere")
                                        {
                                            Console.WriteLine(name + " walks to you");
                                        }
                                        if (action == "GiveName")
                                        {
                                            Console.WriteLine("Give a name:");
                                            name = Console.ReadLine();
                                            Console.WriteLine("dog is now called " + name);
                                        }
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("Invalid input");
                                    }
                                }
                            }
                            if (animal == "bird")
                            {
                                int weight = 0;
                                string name = "bird";
                                while (true)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("What do you want to do? [Eat, MakeSound, ComeHere, GiveName, back, quit]");
                                    string action = Console.ReadLine();
                                    try
                                    {
                                        if (action == "back")
                                        {
                                            break;
                                        }
                                        if (action == "quit")
                                        {
                                            Environment.Exit(0);
                                        }
                                        if (action == "Hunt")
                                        {
                                            a = rand.Next(0, 10);
                                            if (a < 6)
                                            {
                                                weight++;
                                                Console.WriteLine("Hunt was successful, " + name + " gains 1 kg and weighs now " + weight + " kg");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Hunt failed, " + name + " still weights " + weight + " kg");
                                            }
                                        }
                                        if (action == "Eat")
                                        {
                                            weight++;
                                            Console.WriteLine(name + " eats, gains 1 kg and weighs now " + weight + " kg");
                                        }
                                        if (action == "MakeSound")
                                        {
                                            Console.WriteLine("Chirp");
                                        }
                                        if (action == "ComeHere")
                                        {
                                            Console.WriteLine(name + " flies to you");
                                        }
                                        if (action == "GiveName")
                                        {
                                            Console.WriteLine("Give a name:");
                                            name = Console.ReadLine();
                                            Console.WriteLine("bird is now called " + name);
                                        }
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("Invalid input");
                                    }
                                }
                            }

                            if (animal == "wolf")
                            {
                                int weight = 0;
                                string name = "wolf";
                                while (true)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("What do you want to do? [Hunt, MakeSound, ComeHere, GiveName, back, quit]");
                                    string action = Console.ReadLine();
                                    try
                                    {
                                        if (action == "back")
                                        {
                                            break;
                                        }
                                        if (action == "quit")
                                        {
                                            Environment.Exit(0);
                                        }
                                        if (action == "Hunt")
                                        {
                                            a = rand.Next(0, 10);
                                            if (a < 6)
                                            {
                                                weight++;
                                                Console.WriteLine("Hunt was successful, " + name + " gains 1 kg and weighs now " + weight + " kg");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Hunt failed, " + name + " still weights " + weight + " kg");
                                            }

                                        }
                                        if (action == "MakeSound")
                                        {
                                            Console.WriteLine("Howl");
                                        }
                                        if (action == "ComeHere")
                                        {
                                            Console.WriteLine(name + " walks to you");
                                        }
                                        if (action == "GiveName")
                                        {
                                            Console.WriteLine("Give a name:");
                                            name = Console.ReadLine();
                                            Console.WriteLine("wolf is now called " + name);
                                        }
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("Invalid input");
                                    }
                                }
                            }
                            if (animal == "tiger")
                            {
                                int weight = 0;
                                string name = "tiger";
                                while (true)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("What do you want to do? [Hunt, MakeSound, ComeHere, GiveName, back, quit]");
                                    string action = Console.ReadLine();
                                    try
                                    {
                                        if (action == "back")
                                        {
                                            break;
                                        }
                                        if (action == "quit")
                                        {
                                            Environment.Exit(0);
                                        }
                                        if (action == "Hunt")
                                        {
                                            a = rand.Next(0, 10);
                                            if (a < 6)
                                            {
                                                weight++;
                                                Console.WriteLine("Hunt was successful, " + name + " gains 1 kg and weighs now " + weight + " kg");
                                            }
                                            else
                                            {
                                                Console.WriteLine("Hunt failed, " + name + " still weights " + weight + " kg");
                                            }

                                        }
                                        if (action == "MakeSound")
                                        {
                                            Console.WriteLine("Roar");
                                        }
                                        if (action == "ComeHere")
                                        {
                                            Console.WriteLine(name + " walks to you");
                                        }
                                        if (action == "GiveName")
                                        {
                                            Console.WriteLine("Give a name:");
                                            name = Console.ReadLine();
                                            Console.WriteLine("tiger is now called " + name);
                                        }
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("Invalid input");
                                    }
                                }
                            }

                            if (animal == "elephant")
                            {
                                int weight = 0;
                                string name = "elephant";
                                while (true)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("What do you want to do? [Eat, MakeSound, ComeHere, GiveName, back, quit]");
                                    string action = Console.ReadLine();
                                    try
                                    {
                                        if (action == "back")
                                        {
                                            break;
                                        }
                                        if (action == "quit")
                                        {
                                            Environment.Exit(0);
                                        }
                                        if (action == "Eat")
                                        {
                                            weight++;
                                            Console.WriteLine(name + " eats, leaf 1 kg and weighs now " + weight + " kg");
                                        }
                                        if (action == "MakeSound")
                                        {
                                            Console.WriteLine("Trumpet");
                                        }
                                        if (action == "ComeHere")
                                        {
                                            Console.WriteLine(name + " Comes to you");
                                        }
                                        if (action == "GiveName")
                                        {
                                            Console.WriteLine("Give a name:");
                                            name = Console.ReadLine();
                                            Console.WriteLine("Elephant is now called " + name);
                                        }
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("Invalid input");
                                    }
                                }
                            }

                            if (animal == "sloth")
                            {
                                int weight = 0;
                                string name = "sloth";
                                while (true)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("What do you want to do? [Eat, MakeSound, ComeHere, GiveName, back, quit]");
                                    string action = Console.ReadLine();
                                    try
                                    {
                                        if (action == "back")
                                        {
                                            break;
                                        }
                                        if (action == "quit")
                                        {
                                            Environment.Exit(0);
                                        }
                                        if (action == "Eat")
                                        {
                                            weight++;
                                            Console.WriteLine(name + " eats, gains 1 kg and weighs now " + weight + " kg");
                                        }
                                        if (action == "MakeSound")
                                        {
                                            Console.WriteLine("Baaaah");
                                        }
                                        if (action == "ComeHere")
                                        {
                                            Console.WriteLine(name + " slowly crawls to you - it actually does take a lot of time and you get a little bit frustrated");
                                        }
                                        if (action == "GiveName")
                                        {
                                            Console.WriteLine("Give a name:");
                                            name = Console.ReadLine();
                                            Console.WriteLine("sloth is now called " + name);
                                        }
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("");
                                    }

                                }
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid input, please try again");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, please try again");
                        answer = Console.ReadLine();
                    }
                }

            }

        }
    }
}

