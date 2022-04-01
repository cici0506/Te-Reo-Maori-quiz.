using System;
namespace MaoriQuiz
{
    class Program
    {
        static void Main(string[] args)
        {


            // declare method to store the levels 
            int[] test = { 1, 2, 3 };

            // display intro


            //declare void play() so that the method returns no value
                      
            play();


        }
        static void play()
        {//declare variable answer1 to answer15 type string
            string answer;
           
            int score = 0;

            Console.Clear();
            Console.WriteLine("Welcome to my quiz user!(please type your answer in lower case letters)\n\nWhat is your name?\n");

            //prompt user for name
            string name = Console.ReadLine();
            // display introduction with user's name displayed
            Console.WriteLine("Welcome " + name + " this program is a 45 question Teo Reo Maori quiz.\n\n");
            //prompt user to enter a level
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

            /* check if userLevel is equal to 2 then display questions 1 to 15
             * if answer is correct then add 1 to user's score
             * if answer is incorrect then display wrong and user's score remains the same
             */
            else if (selection == 2)
            {
                level2();
               
            }

            /* check if userLevel is equal to 2 then display questions 1 to 15
             * if answer is correct then add 1 to user's score
             * if answer is incorrect then display wrong and user's score remains the same
             */
            else
            {
                level3();
            }

            void end()
            {
                Console.Clear();
                // display end text + score and ask user if they wish to play again, if so, press y or any other key to exit
                Console.WriteLine("Well done! You made it to the end of the quiz\n\n" + name + " your score: " + score + "\n\nDo you wish to play again?\nPlease press y to restart or any other key to end\n");
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
                    Console.Write("Thanks for using this program!\nPress enter to exit");
                    // use Environment.Exit(0) to return to the operating system. Use 0 to indicate that the process completed successfully
                    Environment.Exit(0);

                }
            }
             void level1()
                
            {
                do
                {
                    Console.WriteLine("Question 1\nWhat is the color of an apple in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.kowhai\nb.kikorangi\nc.whero\n");
                    answer = Console.ReadLine();
                    Console.Clear();
                } while (answer != "c");
                if (answer == "c")
                {
                    Console.WriteLine("Correct!\n" + name);
                }
                do
                {
                    Console.WriteLine("Question 2\nWhat does 'hello' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.kia ora\nb.ka pai\nc.morena\n");
                    answer = Console.ReadLine();
                    Console.Clear();
                } while (answer != "a");
                if (answer == "a")
                {
                    Console.WriteLine("Correct!\n" + name);
                }

                do
                {
                    Console.WriteLine("Question 3\nWhat does 'New Zealand' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.kiwi\nb.aotearoa\nc.maunga\n");
                    answer = Console.ReadLine();
                    Console.Clear();
                } while (answer != "b");
                if (answer == "b")
                {
                    Console.WriteLine("Correct!\n" + name);
                }

                do
                {
                    Console.WriteLine("Question 4\nWhat does 'sea' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.moana\nb.wai\nc.kirikiri\n");
                    answer = Console.ReadLine();
                    Console.Clear();
                } while (answer != "a");
                if (answer == "a")
                {
                    Console.WriteLine("Correct!\n" + name);
                }

                do
                {
                    Console.WriteLine("Question 5\nWhat does 'family' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.tuahine\nb.whanau\nc.teina\n");
                    answer = Console.ReadLine();
                    Console.Clear();
                } while (answer != "b");
                if (answer == "b")
                {
                    Console.WriteLine("Correct!\n" + name);
                }

                do
                {
                    Console.WriteLine("Question 6\nWhat does 'love' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.te aroha\nb.pai\nc.aroha\n");
                    answer = Console.ReadLine();
                    Console.Clear();
                } while (answer != "c");
                if (answer == "c")
                {
                    Console.WriteLine("Correct!\n" + name);
                }

                do
                {
                    Console.WriteLine("Question 7\nWhat does 'tribe' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.ropu matawaka\nb.iwi\nc.whare rangatira\n");
                    answer = Console.ReadLine();
                    Console.Clear();
                } while (answer != "b");
                if (answer == "b")
                {
                    Console.WriteLine("Correct!\n" + name);
                }

                do
                {
                    Console.WriteLine("Question 8\nWhat does 'see you later' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.ka kite ano\nb.poroporoaki\nc.kia roa\n");
                    answer = Console.ReadLine();
                    Console.Clear();
                } while (answer != "a");
                if (answer == "a")
                {
                    Console.WriteLine("Correct!\n" + name);
                }

                do
                {
                    Console.WriteLine("Question 9\nWhat does 'sit' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.nohoanga\nb.okiokinga\nc.e noho\n");
                    answer = Console.ReadLine();
                    Console.Clear();
                } while (answer != "c");
                if (answer == "c")
                {
                    Console.WriteLine("Correct!\n" + name);
                }

                do
                {
                    Console.WriteLine("Question 10\nWhat does 'welcome' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.nau mai\nb.tena koutou\nc.whakaaetanga\n");
                    answer = Console.ReadLine();
                    Console.Clear();
                } while (answer != "a");
                if (answer == "a")
                {
                    Console.WriteLine("Correct!\n" + name);
                }

                do
                {
                    Console.WriteLine("Question 11\nWhat does 'food' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.kai\nb.whangai\nc.tunu kai\n");
                    answer = Console.ReadLine();
                    Console.Clear();
                } while (answer != "a");
                if (answer == "a")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name);
                }

                do
                {
                    Console.WriteLine("Question 12\nWhat does 'canoe' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.waka\nb.poti\nc.waka waka\n");
                    answer = Console.ReadLine();
                    Console.Clear();
                } while (answer != "a");
                if (answer == "a")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name);
                }

                do
                {
                    Console.WriteLine("Question 13\nWhat does 'mountain' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.teitei\nb.tihi\nc.maunga\n");
                    answer = Console.ReadLine();
                    Console.Clear();
                } while (answer != "c");
                if (answer == "c")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name);
                }

                do
                {
                    Console.WriteLine("Question 14\nWhat does 'good morning' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.ata\nb.morena\nc.awatea\n");
                    answer = Console.ReadLine();
                    Console.Clear();
                } while (answer != "b");
                if (answer == "b")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name);
                }

                do
                {
                    Console.WriteLine("Question 15\nWhat does 'ten' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.tekau\nb.whakatekau\nc.hekaono\n");
                    answer = Console.ReadLine();
                    Console.Clear();
                } while (answer != "a");
                if (answer == "a")
                {
                    score = score + 1;
                    Console.WriteLine("Correct!\n" + name);
                }

                end();
            }
             void level2()
            {
                Console.WriteLine("Question 1\nWhat does 'chief' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.tumuaki\nb.rangatira\nc.kapene\n");
                answer = Console.ReadLine();
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
                Console.WriteLine("Question 2\nWhat does 'sacred' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.manaakitia\nb.tapu\nc.arohaina\n");
                answer = Console.ReadLine();
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
            void level3()
            {

                Console.WriteLine("Question 1\nWhat does 'genealogy' mean in Maori " + name + "?\n\n(please type the answer a, b or c)\n\na.takenga\nb.iranga\nc.whakapapa\n");
                answer = Console.ReadLine();
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






