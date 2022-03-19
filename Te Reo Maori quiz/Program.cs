using System;
namespace MaoriQuiz
{
    public class Program
    {
        public static void Main()
        {

            string answer1 = "";
            string answer2 = "";
            string answer3 = "";
            string answer4 = "";
            string answer5 = "";
            string[] test = { "1", "2", "3" };
            Console.WriteLine("Welcome to my quiz user!(please type your answers in lower case letters)\nWhat is your name?\n");
            string name = Console.ReadLine();


            play();
            void play()

            {
                int score = 0;
                Console.Clear();

                // INTRODUCTION 


                Console.WriteLine("Welcome, this program is a 15 question Teo Reo Maori quiz.\n\n");



                Console.WriteLine("There are three levels, please enter the number you wish to do\n1. Basic\n2. Intermediate\n3. Advanced\n");
                string userLevel = Console.ReadLine();

                Console.WriteLine(userLevel);

                if (test.Contains(userLevel))
                {
                    quiz();
                }
                else Console.WriteLine("Sorry, this option is not found.\nPlease enter a valid number\n");
                Environment.Exit(0);
                Console.Clear();
                void quiz()
                {
                    Console.Clear();
                    if (userLevel == "1")
                    {
                        Console.WriteLine("Question 1\nWhat is the color of an apple in Maori " + name + "?\na.kowhai\nb.kikorangi\nc.whero\n");
                        answer1 = Console.ReadLine();
                        Console.Clear();
                        if (answer1 == "c")
                        {
                            score = score + 1;
                            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");
                        }
                        Console.WriteLine("Question 2\nWhat does 'hello' mean in Maori " + name + "?\na.kia ora\nb.ka pai\nc.morena\n");
                        answer2 = Console.ReadLine();
                        Console.Clear();
                        if (answer2 == "a")
                        {
                            score = score + 1;
                            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");
                        }

                        Console.WriteLine("Question 3\nWhat does 'New Zealand' mean in Maori " + name + "?\na.kiwi\nb.aotearoa\nc.maunga\n");
                        answer3 = Console.ReadLine();
                        Console.Clear();
                        if (answer3 == "b")
                        {
                            score = score + 1;
                            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");
                        }
                        Console.WriteLine("Question 4\nWhat does 'sea' mean in Maori " + name + "?\na.moana\nb.wai\nc.kirikiri\n");
                        answer4 = Console.ReadLine();
                        Console.Clear();
                        if (answer4 == "a")
                        {
                            score = score + 1;
                            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");

                        }
                        Console.WriteLine("Question 5\nWhat does 'family' mean in Maori " + name + "?\na.tuahine\nb.whanau\nc.teina\n");
                        answer5 = Console.ReadLine();
                        Console.Clear();
                        if (answer5 == "b")
                        {
                            score = score + 1;
                            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");

                        }
                        end();
                    }


                    if (userLevel == "2")
                    {

                        Console.WriteLine("Question 1\nWhat does 'chief' mean in Maori " + name + "?\na.tumuaki\nb.rangatira\nc.kapene\n");
                        answer1 = Console.ReadLine();
                        Console.Clear();
                        if (answer1 == "b")
                        {
                            score = score + 1;
                            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");
                        }
                        Console.WriteLine("Question 2\nWhat does 'sacred' mean in Maori " + name + "?\na.manaakitia\nb.tapu\nc.arohaina\n");
                        answer2 = Console.ReadLine();
                        Console.Clear();
                        if (answer2 == "a")
                        {
                            score = score + 1;
                            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");
                        }

                        Console.WriteLine("Question 3\nWhat does 'land' mean in Maori " + name + "?\na.rohe\nb.whenua\nc.eka\n");
                        answer3 = Console.ReadLine();
                        Console.Clear();
                        if (answer3 == "b")
                        {
                            score = score + 1;
                            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");
                        }
                        Console.WriteLine("Question 4\nWhat does 'greenstone' mean in Maori " + name + "?\na.kakariki\nb.kohatu\nc.pounamu\n");
                        answer4 = Console.ReadLine();
                        Console.Clear();
                        if (answer4 == "c")
                        {
                            score = score + 1;
                            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");

                        }
                        Console.WriteLine("Question 5\nWhat does 'ancestor' mean in Maori " + name + "?\na.tupuna\nb.kaiwhakarewa\nc.kaihanga\n");
                        answer5 = Console.ReadLine();
                        Console.Clear();
                        if (answer5 == "a")
                        {
                            score = score + 1;
                            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");


                        }
                        end();
                    }
                    if (userLevel == "3")


                        Console.WriteLine("Question 1\nWhat does 'genealogy' mean in Maori " + name + "?\na.takenga\nb.iranga\nc.whakapapa\n");
                    answer1 = Console.ReadLine();
                    Console.Clear();
                    if (answer1 == "c")
                    {
                        score = score + 1;
                        Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                    }
                    else
                    {
                        Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");
                    }
                    Console.WriteLine("Question 2\nWhat does 'aeroplane' mean in Maori " + name + "?\na.rereangi\nb.hau\nc.tere\n");
                    answer2 = Console.ReadLine();
                    Console.Clear();
                    if (answer2 == "a")
                    {
                        score = score + 1;
                        Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                    }
                    else
                    {
                        Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");
                    }

                    Console.WriteLine("Question 3\nWhat does 'birthday' mean in Maori " + name + "?\na.whanautanga\nb.huritau\nc.\n");
                    answer3 = Console.ReadLine();
                    Console.Clear();
                    if (answer3 == "b")
                    {
                        score = score + 1;
                        Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                    }
                    else
                    {
                        Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");
                    }
                    Console.WriteLine("Question 4\nWhat  " + name + "?\na.\nb.\nc.\n");
                    answer4 = Console.ReadLine();
                    Console.Clear();
                    if (answer4 == "a")
                    {
                        score = score + 1;
                        Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                    }
                    else
                    {
                        Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");

                    }
                    Console.WriteLine("Question 5\nWhat  " + name + "?\na.\nb.\nc.\n");
                    answer5 = Console.ReadLine();
                    Console.Clear();
                    if (answer5 == "b")
                    {
                        score = score + 1;
                        Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                    }
                    else
                    {
                        Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");
                    }
                    end();

                    void end()
                    {
                        Console.Clear();
                        Console.WriteLine("Well done! You made it to the end of the quiz\n" + name + " your score: " + score + "\nDo you wish to play again?\nPlease press 'y' to restart or any other key to exit\n");
                        string restart = Console.ReadLine();
                        if (restart == "y")
                        {
                            play();
                        }
                        else
                        {
                            Console.Write("Thanks for playing!");

                            Environment.Exit(0);

                        }
                    }

                }
            }
        }

    }
}






