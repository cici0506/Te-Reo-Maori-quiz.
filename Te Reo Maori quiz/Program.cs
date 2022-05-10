using System;
namespace MaoriQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            /* declare play() so that the method returns no value 
             * prompt user for name
             * display introduction with user's name displayed           
             * prompt user to enter a level
             * if user scores less than or equal to 3, then display message
             * if user scores less than or equal to 7, then display message
             * if user displays less than or equal to 9, then display message
             * if user scores 10, then display message
             * display end text + score and ask user if they wish to play again, if so, press y or any other key to end
             * if restart is equal to y then play
             * read restart
             * if user press any other keys, then end quiz
             * thank the user for playing
             */
           
            play();
        }
        static void play()
        {           
            string answer = "";
           
            int score = 0;

            Console.Clear();
            Console.WriteLine("Welcome to my quiz user!(please type your answer in lower case letters)\n\nWhat is your name?\n");

            string name = Console.ReadLine();

            Console.WriteLine("\nWelcome " + name + " this program is a 45 question Teo Reo Maori quiz.\n\n");
            menu();

            void end()
            {
                Console.Clear();

                if (score <= 3)
                {
                    Console.WriteLine(name + " your score: " + score + "\n\nBetter luck next time!");
                }
                else if (score <= 7)
                {
                    Console.WriteLine(name + " your score: " + score + "\n\nGOOD TRY! Keep practicing!");
                }
                else if (score <= 14)
                {
                    Console.WriteLine(name + " your score: " + score + "\n\nSO CLOSE! Don't give up!");
                }
                else
                {
                    Console.WriteLine(name + " your score: " + score + "\n\nWELL DONE! You got a perfect score!");
                }

                Console.WriteLine("\n\nWell done! You made it to the end of the quiz\n\nTo choose a new level please press m or any other key to end\n");
          
                string restart = Console.ReadLine();
               
                if (restart == "m")
                {
                    Console.Clear();
                    menu();
                }
                else
                {
                    Console.Write("Thanks for using this program!...Goodbye\nPress enter to exit\n\n");
                    // use Environment.Exit(0) to return to the operating system. Use 0 to indicate that the process completed successfully
                    Environment.Exit(0);
                }
            }
            void menu()
            {
                score = 0;

                Console.WriteLine("There are three levels, please enter the number you wish to do\n1. Basic\n2. Intermediate\n3. Advanced\n");

                int selection;
                while (!int.TryParse(Console.ReadLine(), out selection) || selection <= 0 || selection >= 4)
                {
                    Console.WriteLine("Please enter a valid number");
                }
                Console.WriteLine(selection);
                Console.Clear();

                if (selection == 1)
                {
                    level1();
                }

               else if (selection == 2)
                {
                    level2();
                }

                else if (selection == 3)
                {
                    level3();
                }
                else
                {
                    Console.WriteLine("Please enter a valid option");
                    menu();

                }
            }

                /* if user selects lvl 1, then play
                 * display questions 1 to 15
                 * if user enters an invalid option, then enter error message and allow user to enter again
                 * if user enters correct answer, then display correct and add 1 to score
                 * if answer is incorrect, then display incorrect and score remains the same
                 * clear everything before so page looks clean
                 */
                void level1()
                
                {
                    Console.WriteLine("Question 1\nWhat is the color of an apple in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.kowhai\nb.kikorangi\nc.whero\n");
                    answer = Console.ReadLine();
                while(answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                    Console.Clear();

                if (answer == "c")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }
                
                    Console.WriteLine("Question 2\nWhat does 'hello' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.kia ora\nb.ka pai\nc.morena\n");
                    answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                 
                if (answer == "a")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 3\nWhat does 'New Zealand' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.kiwi\nb.aotearoa\nc.maunga\n");
                    answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                
                if (answer == "b")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 4\nWhat does 'sea' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.moana\nb.wai\nc.kirikiri\n");
                    answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                 
                if (answer == "a")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 5\nWhat does 'family' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.tuahine\nb.whanau\nc.teina\n");
                    answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                 
                if (answer == "b")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 6\nWhat does 'love' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.te aroha\nb.pai\nc.aroha\n");
                    answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
               
                if (answer == "c")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 7\nWhat does 'tribe' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.ropu matawaka\nb.iwi\nc.whare rangatira\n");
                    answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {

                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                
                if (answer == "b")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 8\nWhat does 'see you later' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.ka kite ano\nb.poroporoaki\nc.kia roa\n");
                    answer = Console.ReadLine();
                    Console.Clear();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                if (answer == "a")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 9\nWhat does 'sit' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.nohoanga\nb.okiokinga\nc.e noho\n");
                    answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                 
                if (answer == "c")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 10\nWhat does 'welcome' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.nau mai\nb.tena koutou\nc.whakaaetanga\n");
                    answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                 
                if (answer == "a")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 11\nWhat does 'food' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.kai\nb.whangai\nc.tunu kai\n");
                    answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                 
                if (answer == "a")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 12\nWhat does 'canoe' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.waka\nb.poti\nc.waka waka\n");
                    answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                
                if (answer == "a")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 13\nWhat does 'mountain' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.teitei\nb.tihi\nc.maunga\n");
                    answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
               
                if (answer == "c")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 14\nWhat does 'good morning' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.ata\nb.morena\nc.awatea\n");
                    answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                 
                if (answer == "b")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 15\nWhat does 'ten' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.tekau\nb.whakatekau\nc.hekaono\n");
                    answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                
                if (answer == "a")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }
                end();
            }

            /* if user selects lvl 2, then play
            * display questions 1 to 15
            * if user enters an invalid option, then enter error message and allow user to enter again
            * if user enters correct answer, then display correct and add 1 to score
            * if answer is incorrect, then display incorrect and score remains the same
            * clear everything before so page looks clean
            */
            void level2()
            {
                Console.WriteLine("Question 1\nWhat does 'chief' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.tumuaki\nb.rangatira\nc.kapene\n");
                answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                if (answer == "b")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 2\nWhat does 'reptile' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.kararehe\nb.ngarara\nc.tuatara\n");
                answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                if (answer == "b")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 3\nWhat does 'land' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.rohe\nb.whenua\nc.eka\n");
                answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                if (answer == "b")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 4\nWhat does 'greenstone' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.kakariki\nb.kohatu\nc.pounamu\n");
                answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                if (answer == "c")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 5\nWhat does 'ancestor' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.tupuna\nb.kaiwhakarewa\nc.kaihanga\n");
                answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                if (answer == "a")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 6\nWhat does 'children' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.uri\nb.tamariki\nc.iti\n");
                answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                if (answer == "b")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 7\nWhat does 'elder' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.kaumatua\nb.tangata pakeke\nc.tupuna\n");
                answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                if (answer == "a")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 8\nWhat does 'prayer' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.wawao\nb.inoi\nc.karakia\n");
                answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                if (answer == "c")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 9\nWhat does 'work' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.mahi\nb.ratonga\nc.taumahi\n");
                answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                if (answer == "a")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 10\nWhat does 'stomach' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.whekau\nb.puku\nc.puku puku\n");
                answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                if (answer == "b")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 11\nWhat does 'water' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.maku\nb.inu\nc.wai\n");
                answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                if (answer == "c")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 12\nWhat does 'saturday' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.okiokinga\nb.wiki\nc.rahoroi\n");
                answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                if (answer == "c")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");


                }

                Console.WriteLine("Question 13\nWhat does 'listen' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.whakarongo\nb.rongo\nc.aro mai\n");
                answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                if (answer == "a")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");


                }

                Console.WriteLine("Question 14\nWhat does 'thank you' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.whakaae\nb.mihi\nc.maioha\n");
                answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                if (answer == "b")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");


                }

                Console.WriteLine("Question 15\nWhat does 'talk' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.korerorero\nb.kohukohu\nc.korero\n");
                answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                if (answer == "c")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");


                }
                end();
            }

            /* if user selects lvl 3, then play
            * display questions 1 to 15
            * if user enters an invalid option, then enter error message and allow user to enter again
            * if user enters correct answer, then display correct and add 1 to score
            * if answer is incorrect, then display incorrect and score remains the same
            * clear everything before so page looks clean
            */
            void level3()
            {

                Console.WriteLine("Question 1\nWhat does 'genealogy' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.takenga\nb.iranga\nc.whakapapa\n");
                answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                if (answer == "c")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 2\nWhat does 'aeroplane' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.rereangi\nb.hau\nc.tere\n");
                answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                if (answer == "a")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 3\nWhat does 'birthday' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.whanautanga\nb.huritau\nc.whakanui\n");
                answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                if (answer == "b")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 4\nWhat does 'thunderstorm' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.whatitiri\nb.awha\nc.ua\n");
                answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                if (answer == "a")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");

                }

                Console.WriteLine("Question 5\nWhat does 'sincerity' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.ngakau nui\nb.pono\nc.whakapono pai\n");
                answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                if (answer == "b")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 6\nWhat does 'november' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.maramataka\nb.marama\nc.whiri-a-rangi\n");
                answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                if (answer == "c")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 7\nWhat does 'west' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.tohutohu\nb.uru\nc.kapehu\n");
                answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                if (answer == "b")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 8\nWhat does 'earth' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.papa\nb.aorangi\nc.ao\n");
                answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                if (answer == "a")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 10\nWhat does 'star' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.whetu\nb.ra\nc.maramara\n");
                answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                if (answer == "a")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 11\nWhat does 'dance' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.takahurihuri\nb.peruperu\nc.parani\n");
                answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                if (answer == "b")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 12\nWhat does 'authority' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.arahitanga\nb.whakahaere\nc.mana\n");
                answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                if (answer == "c")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 13\nWhat does 'treasure' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.taonga\nb.kohatu\nc.utu nui\n");
                answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                if (answer == "a")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 14\nWhat does 'confiscate' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.tango\nb.hopukina\nc.raupatu\n");
                answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                if (answer == "c")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }

                Console.WriteLine("Question 15\nWhat does 'guests' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.kaihoko\nb.manuhiri\nc.kiritaki\n");
                answer = Console.ReadLine();
                while (answer != "a" && answer != "b" && answer != "c")
                {
                    Console.WriteLine("Please enter a valid option");
                    answer = Console.ReadLine();
                }
                Console.Clear();
                if (answer == "b")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name + "'s score:" + score + "\n");
                }
                else
                {
                    Console.WriteLine("Incorrect!\n" + name + "'s score:" + score + "\n");
                }
                end();
            }
        }

    }
}