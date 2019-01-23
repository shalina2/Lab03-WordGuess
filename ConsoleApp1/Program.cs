using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string Path = "../../../Phrases.txt";
            CreateFile(path);
            bool run = true;
            while (run)
            {
                HomePage();
                try
                {
                    string input = Console.ReadLine();
                    switch (input)
                    {
                        case "1":
                            Console.Clear();
                            string randomword = RandomlyGetOneWord(path);
                            UserGuessWord(randomword);

                            Console.WriteLine("New Game? y/n");
                            string input2 = Console.ReadLine();
                            String ans = input2.ToLower();
                            if (ans == "y")
                            {
                                goto case "1";
                            }
                            else
                            {
                                Console.Clear();
                                run = true;
                            }
                            break;

                        case "2":
                            Console.Clear();
                            Admin();
                            string input3 = Console.ReadLine();
                            if (input3 == "1")
                            {
                                bool read = ViewFile(path);
                                if (read)
                                {
                                    Console.WriteLine("xxxxxxx");
                                    goto case "2";
                                }
                            }
                            else if (input3 = "2")
                            {
                                Console.Clear();
                                Console.WriteLine("what phrase you would like to add?");
                                string word = Console.ReadLine();
                                bool NewPhrase = AddWord(Path, word);
                                if (NewPhrase == true)
                                {
                                    Console.WriteLine("xxxxxxx");
                                    Console.WriteLine($"Added");
                                    Console.ReadLine();
                                    goto case "2";

                                }
                            }
                            else
                            {
                                Console.WriteLine("nothing added");
                                goto case "2";
                            }
                    
                    else if (input3 == "4")
                            {
                                Console.Clear();
                                run = true;
                            }
                            else
                            {
                                goto case "2";
                            }
                            break;

                        case "3":
                            Enviroment.Exit(0);
                            break;

                        default:
                            throw new Exception("Please choose one phrase");
                    }


                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

    }
}