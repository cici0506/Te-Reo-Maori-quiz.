using System;
namespace MaoriQuiz
{
    public class Program
    {
        public static void Main()
        {
            //declare variable answer1 to answer15 type string
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

            /* this is an array to represent a fixed length ordered collection of values with the same type to indicate that this is a three leveled quiz.
             * I used the array, so it makes it easier to organize and operate on large amounts of data. So instead of creating multiple variables, I can just create one array that stores it all.
             */
            string[] test = { "1", "2", "3" };

            // display intro
            Console.WriteLine("Welcome to my quiz user!(please type your answer in lower case letters)\n\nWhat is your name?\n");

            //prompt user for name
            string name = Console.ReadLine(); 

            //declare void play() so that the method returns no value
            play();
            void play()

            {
                int score = 0;

                Console.Clear();

                // display introduction with user's name displayed
                Console.WriteLine("Welcome " + name + " this program is a 45 question Teo Reo Maori quiz.\n\n");
                //prompt user to enter a level
                Console.WriteLine("There are three levels, please enter the number you wish to do\n1. Basic\n2. Intermediate\n3. Advanced\n");
                //read userLevel
                string userLevel = Console.ReadLine();
               
                Console.WriteLine(userLevel);
                //if test contains userLevel then start the quiz
                if (test.Contains(userLevel))
                {
                    quiz();
                }
                // if user enters an invalid number, display option not found
                else Console.WriteLine("Sorry, this option is not found.\nPlease enter a valid number\n");
                Environment.Exit(0);
                // use Console.Clear() to clear when user types enter to go next, so it does not pile up 
                Console.Clear();
                // begin quiz
                void quiz()
                {
                    Console.Clear();

                    /* check if userLevel is equal to 1 then display questions 1 to 15
                     * if answer is correct then add 1 to user's score
                     * if answer is incorrect then display wrong and user's score remains the same
                     */
                    if (userLevel == "1")
                    {
                        Console.WriteLine("Question 1\nWhat is the color of an apple in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.kowhai\nb.kikorangi\nc.whero\n");
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
                        Console.WriteLine("Question 2\nWhat does 'hello' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.kia ora\nb.ka pai\nc.morena\n");
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

                        Console.WriteLine("Question 3\nWhat does 'New Zealand' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.kiwi\nb.aotearoa\nc.maunga\n");
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
                        Console.WriteLine("Question 4\nWhat does 'sea' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.moana\nb.wai\nc.kirikiri\n");
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
                        Console.WriteLine("Question 5\nWhat does 'family' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.tuahine\nb.whanau\nc.teina\n");
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
                        Console.WriteLine("Question 6\nWhat does 'love' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.te aroha\nb.pai\nc.aroha\n");
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
                        Console.WriteLine("Question 7\nWhat does 'tribe' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.ropu matawaka\nb.iwi\nc.whare rangatira\n");
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
                        Console.WriteLine("Question 8\nWhat does 'see you later' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.ka kite ano\nb.poroporoaki\nc.kia roa\n");
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
                        Console.WriteLine("Question 9\nWhat does 'sit' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.nohoanga\nb.okiokinga\nc.e noho\n");
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
                        Console.WriteLine("Question 10\nWhat does 'welcome' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.nau mai\nb.tena koutou\nc.whakaaetanga\n");
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
                        Console.WriteLine("Question 11\nWhat does 'food' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.kai\nb.whangai\nc.tunu kai\n");
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
                        Console.WriteLine("Question 12\nWhat does 'canoe' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.waka\nb.poti\nc.waka waka\n");
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
                        Console.WriteLine("Question 13\nWhat does 'mountain' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.teitei\nb.tihi\nc.maunga\n");
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
                        Console.WriteLine("Question 14\nWhat does 'good morning' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.ata\nb.morena\nc.awatea\n");
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
                        Console.WriteLine("Question 15\nWhat does 'ten' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.tekau\nb.whakatekau\nc.hekaono\n");
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

                    /* check if userLevel is equal to 2 then display questions 1 to 15
                     * if answer is correct then add 1 to user's score
                     * if answer is incorrect then display wrong and user's score remains the same
                     */
                    else if (userLevel == "2")
                    {

                        Console.WriteLine("Question 1\nWhat does 'chief' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.tumuaki\nb.rangatira\nc.kapene\n");
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
                        Console.WriteLine("Question 2\nWhat does 'sacred' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.manaakitia\nb.tapu\nc.arohaina\n");
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

                        Console.WriteLine("Question 3\nWhat does 'land' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.rohe\nb.whenua\nc.eka\n");
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
                        Console.WriteLine("Question 4\nWhat does 'greenstone' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.kakariki\nb.kohatu\nc.pounamu\n");
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
                        Console.WriteLine("Question 5\nWhat does 'ancestor' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.tupuna\nb.kaiwhakarewa\nc.kaihanga\n");
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


                        }  Console.WriteLine("Question 6\nWhat does 'children' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.uri\nb.tamariki\nc.iti\n");
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
                        Console.WriteLine("Question 7\nWhat does 'elder' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.kaumatua\nb.tangata pakeke\nc.tupuna\n");
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
                        Console.WriteLine("Question 8\nWhat does 'prayer' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.wawao\nb.inoi\nc.karakia\n");
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
                        Console.WriteLine("Question 9\nWhat does 'work' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.mahi\nb.ratonga\nc.taumahi\n");
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
                        Console.WriteLine("Question 10\nWhat does 'stomach' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.whekau\nb.puku\nc.puku puku\n");
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
                        Console.WriteLine("Question 11\nWhat does 'water' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.maku\nb.inu\nc.wai\n");
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
                        Console.WriteLine("Question 12\nWhat does 'saturday' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.okiokinga\nb.wiki\nc.rahoroi\n");
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
                        Console.WriteLine("Question 13\nWhat does 'listen' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.whakarongo\nb.rongo\nc.aro mai\n");
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
                        Console.WriteLine("Question 14\nWhat does 'thank you' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.whakaae\nb.mihi\nc.maioha\n");
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
                        Console.WriteLine("Question 15\nWhat does 'talk' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.korerorero\nb.kohukohu\nc.korero\n");
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

                    /* check if userLevel is equal to 2 then display questions 1 to 15
                     * if answer is correct then add 1 to user's score
                     * if answer is incorrect then display wrong and user's score remains the same
                     */
                    else

                        Console.WriteLine("Question 1\nWhat does 'genealogy' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.takenga\nb.iranga\nc.whakapapa\n");
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
                    Console.WriteLine("Question 2\nWhat does 'aeroplane' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.rereangi\nb.hau\nc.tere\n");
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

                    Console.WriteLine("Question 3\nWhat does 'birthday' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.whanautanga\nb.huritau\nc.whakanui\n");
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
                    Console.WriteLine("Question 4\nWhat does 'thunderstorm' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.whatitiri\nb.awha\nc.ua\n");
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
                    Console.WriteLine("Question 5\nWhat does 'sincerity' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.ngakau nui\nb.pono\nc.whakapono pai\n");
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
                    Console.WriteLine("Question 6\nWhat does 'november' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.maramataka\nb.marama\nc.whiri-a-rangi\n");
                    answer6 = Console.ReadLine();
                    Console.Clear();
                    if (answer6  == "c")
                    {
                        score = score + 1;
                        Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                    }
                    else
                    {
                        Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");
                    }
                    Console.WriteLine("Question 7\nWhat does 'west' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.tohutohu\nb.uru\nc.kapehu\n");
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
                    Console.WriteLine("Question 8\nWhat does 'earth' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.papa\nb.aorangi\nc.ao\n");
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
                    Console.WriteLine("Question 10\nWhat does 'star' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.whetu\nb.ra\nc.maramara\n");
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
                    Console.WriteLine("Question 11\nWhat does 'dance' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.takahurihuri\nb.peruperu\nc.parani\n");
                    answer11 = Console.ReadLine();
                    Console.Clear();
                    if (answer11 == "b")
                    {
                        score = score + 1;
                        Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                    }
                    else
                    {
                        Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");
                    }
                    Console.WriteLine("Question 12\nWhat does 'authority' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.arahitanga\nb.whakahaere\nc.mana\n");
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
                    Console.WriteLine("Question 13\nWhat does 'treasure' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.taonga\nb.kohatu\nc.utu nui\n");
                    answer13 = Console.ReadLine();
                    Console.Clear();
                    if (answer13 == "a")
                    {
                        score = score + 1;
                        Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                    }
                    else
                    {
                        Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");
                    }
                    Console.WriteLine("Question 14\nWhat does 'confiscate' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.tango\nb.hopukina\nc.raupatu\n");
                    answer14 = Console.ReadLine();
                    Console.Clear();
                    if (answer14 == "c")
                    {
                        score = score + 1;
                        Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                    }
                    else
                    {
                        Console.WriteLine("Wrong!\n" + name + "'s score:" + score + "\n");
                    }
                    Console.WriteLine("Question 15\nWhat does 'guests' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.kaihoko\nb.manuhiri\nc.kiritaki\n");
                    answer15 = Console.ReadLine();
                    Console.Clear();
                    if (answer15 == "b")
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
                        // display end text + score and ask user if they wish to play again, if so, press y, if not press any other key
                        Console.WriteLine("Well done! You made it to the end of the quiz\n\n" + name + " your score: " + score + "\n\nDo you wish to play again?\nPlease press 'y' to restart or any other key to exit\n");
                        // read restart
                        string restart = Console.ReadLine();
                        // if restart is equal to y then play
                        if (restart == "y")
                        {
                            play();
                        }
                        // if user press any other keys, then end quiz
                        else
                        {
                            // thank the user for playing
                            Console.Write("Thanks for playing!");
                            // use Environment.Exit(0) to return to the operating system. Use 0 to indicate that the process completed successfully
                            Environment.Exit(0);

                        }
                    }

                }
            }
        }

    }
}






