using System;
namespace MaoriQuiz
{
    public class Program
    {
        public static void Main()
        {
            //string is used here to represent the answer of the questions asked
            string answer1 = "";
            string answer2 = "";
            string answer3 = "";
            string answer4 = "";
            string answer5 = "";
            string answer6 = "";
            string answer7 = "";
            string answer8 = "";
            string answer9 = "";
            string answer10 = "";
            string answer11 = "";
            string answer12 = "";
            string answer13 = "";
            string answer14 = "";
            string answer15 = "";

            /* This is an array to repreent a fixed length ordered collection of values with the same type to indicate that this is a three leveled quiz.
             * I used the array so it makes it easier to organize and operate on large amounts of data. So instead of creating mulitple variables, I can just create one array that stores it all. */
            string[] test = { "1", "2", "3" };

            //introduction
            Console.WriteLine("Welcome to my quiz user!(please type your answers in lower case letters)\n\nWhat is your name?\n");

            //string is used here to store the name of the user in 'name' and Console.ReadLine() is used to take an inout from the user 
            string name = Console.ReadLine(); 

            //
            play();
            void play()

            {
                int score = 0;
                Console.Clear();

                //introduction

                Console.WriteLine("Welcome " + name + " this program is a 45 question Teo Reo Maori quiz.\n\n");


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
                        Console.WriteLine("Question 6\nWhat does 'love' mean in Maori " + name + "?\na.te aroha\nb.pai\nc.aroha\n");
                        answer6 = Console.ReadLine();
                        Console.Clear();
                        if (answer6 == "c")
                        {
                            score = score + 1;
                            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");

                        }
                        Console.WriteLine("Question 7\nWhat does 'tribe' mean in Maori " + name + "?\na.ropu matawaka\nb.iwi\nc.whare rangatira\n");
                        answer7 = Console.ReadLine();
                        Console.Clear();
                        if (answer7 == "b")
                        {
                            score = score + 1;
                            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");

                        }
                        Console.WriteLine("Question 8\nWhat does 'see you later' mean in Maori " + name + "?\na.ka kite ano\nb.poroporoaki\nc.kia roa\n");
                        answer8 = Console.ReadLine();
                        Console.Clear();
                        if (answer8 == "a")
                        {
                            score = score + 1;
                            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");

                        }
                        Console.WriteLine("Question 9\nWhat does 'sit' mean in Maori " + name + "?\na.nohoanga\nb.okiokinga\nc.e noho\n");
                        answer9 = Console.ReadLine();
                        Console.Clear();
                        if (answer9 == "c")
                        {
                            score = score + 1;
                            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");

                        }
                        Console.WriteLine("Question 10\nWhat does 'welcome' mean in Maori " + name + "?\na.nau mai\nb.tena koutou\nc.whakaaetanga\n");
                        answer10 = Console.ReadLine();
                        Console.Clear();
                        if (answer10 == "a")
                        {
                            score = score + 1;
                            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");

                        }
                        Console.WriteLine("Question 11\nWhat does 'food' mean in Maori " + name + "?\na.kai\nb.whangai\nc.tunu kai\n");
                        answer11 = Console.ReadLine();
                        Console.Clear();
                        if (answer11 == "a")
                        {
                            score = score + 1;
                            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");

                        }
                        Console.WriteLine("Question 12\nWhat does 'canoe' mean in Maori " + name + "?\na.waka\nb.poti\nc.waka waka\n");
                        answer12 = Console.ReadLine();
                        Console.Clear();
                        if (answer12 == "a")
                        {
                            score = score + 1;
                            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");

                        }
                        Console.WriteLine("Question 13\nWhat does 'mountain' mean in Maori " + name + "?\na.teitei\nb.tihi\nc.maunga\n");
                        answer13 = Console.ReadLine();
                        Console.Clear();
                        if (answer13 == "c")
                        {
                            score = score + 1;
                            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");

                        }
                        Console.WriteLine("Question 14\nWhat does 'good morning' mean in Maori " + name + "?\na.ata\nb.morena\nc.awatea\n");
                        answer14 = Console.ReadLine();
                        Console.Clear();
                        if (answer14 == "b")
                        {
                            score = score + 1;
                            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");

                        }
                        Console.WriteLine("Question 15\nWhat does 'ten' mean in Maori " + name + "?\na.tekau\nb.whakatekau\nc.hekaono\n");
                        answer15 = Console.ReadLine();
                        Console.Clear();
                        if (answer15 == "a")
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


                    else if (userLevel == "2")
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
                        if (answer2 == "b")
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


                        }  Console.WriteLine("Question 6\nWhat does 'children' mean in Maori " + name + "?\na.uri\nb.tamariki\nc.iti\n");
                        answer6 = Console.ReadLine();
                        Console.Clear();
                        if (answer6 == "b")
                        {
                            score = score + 1;
                            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");


                        }
                        Console.WriteLine("Question 7\nWhat does 'elder' mean in Maori " + name + "?\na.kaumatua\nb.tangata pakeke\nc.tupuna\n");
                        answer7 = Console.ReadLine();
                        Console.Clear();
                        if (answer7 == "a")
                        {
                            score = score + 1;
                            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");


                        }
                        Console.WriteLine("Question 8\nWhat does 'prayer' mean in Maori " + name + "?\na.wawao\nb.inoi\nc.karakia\n");
                        answer8 = Console.ReadLine();
                        Console.Clear();
                        if (answer8 == "c")
                        {
                            score = score + 1;
                            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");


                        }
                        Console.WriteLine("Question 9\nWhat does 'work' mean in Maori " + name + "?\na.mahi\nb.ratonga\nc.taumahi\n");
                        answer9 = Console.ReadLine();
                        Console.Clear();
                        if (answer9 == "a")
                        {
                            score = score + 1;
                            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");


                        }
                        Console.WriteLine("Question 10\nWhat does 'stomach' mean in Maori " + name + "?\na.whekau\nb.puku\nc.puku puku\n");
                        answer10 = Console.ReadLine();
                        Console.Clear();
                        if (answer10 == "b")
                        {
                            score = score + 1;
                            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");


                        }
                        Console.WriteLine("Question 11\nWhat does 'water' mean in Maori " + name + "?\na.maku\nb.inu\nc.wai\n");
                        answer11 = Console.ReadLine();
                        Console.Clear();
                        if (answer11 == "c")
                        {
                            score = score + 1;
                            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");


                        }
                        Console.WriteLine("Question 12\nWhat does 'saturday' mean in Maori " + name + "?\na.okiokinga\nb.wiki\nc.rahoroi\n");
                        answer12 = Console.ReadLine();
                        Console.Clear();
                        if (answer12 == "c")
                        {
                            score = score + 1;
                            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");


                        }
                        Console.WriteLine("Question 13\nWhat does 'listen' mean in Maori " + name + "?\na.whakarongo\nb.rongo\nc.aro mai\n");
                        answer14 = Console.ReadLine();
                        Console.Clear();
                        if (answer15 == "a")
                        {
                            score = score + 1;
                            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");


                        }
                        Console.WriteLine("Question 14\nWhat does 'thank you' mean in Maori " + name + "?\na.whakaae\nb.mihi\nc.maioha\n");
                        answer14 = Console.ReadLine();
                        Console.Clear();
                        if (answer14 == "b")
                        {
                            score = score + 1;
                            Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");


                        }
                        Console.WriteLine("Question 15\nWhat does 'talk' mean in Maori " + name + "?\na.korerorero\nb.kohukohu\nc.korero\n");
                        answer15 = Console.ReadLine();
                        Console.Clear();
                        if (answer15 == "c")
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
                   else
                    
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

                    Console.WriteLine("Question 3\nWhat does 'birthday' mean in Maori " + name + "?\na.whanautanga\nb.huritau\nc.whakanui\n");
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
                    Console.WriteLine("Question 4\nWhat does 'thunderstorm' mean in Maori " + name + "?\na.whatitiri\nb.awha\nc.ua\n");
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
                    Console.WriteLine("Question 5\nWhat does 'sincerity' mean in Maori " + name + "?\na.ngakau nui\nb.pono\nc.whakapono pai\n");
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






