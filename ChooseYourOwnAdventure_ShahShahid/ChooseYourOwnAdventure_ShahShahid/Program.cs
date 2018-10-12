using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourOwnAdventure_ShahShahid
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            while (cont == true)
            {
                Console.WriteLine("You seem to be having an unlucky day...");
                Console.WriteLine("You're trying to enjoy your hike but a dragon has cornered you! It hasnt attacked yet but seems angry.");
                Console.WriteLine("What will you do? (press any key)");
                Console.ReadLine();
                
                //Path one
                int escLoop = 0;
                int escLoop2 = 1;
                int escLoop3 = 2;
                int escLoop4 = 3;
                int escLoop5 = 4;
                while (escLoop < 1)
                {
                    Console.WriteLine("A. Charge the dragon!\nB. Play dead.\nC. Ask the dragon how it's doing.");
                    string firstChoice = Console.ReadLine().ToLower();

                    switch (firstChoice)
                    {
                        case "a":
                            Console.WriteLine("The dragon ate you before you finished your third step...that was pretty dumb.");
                            escLoop++;
                            escLoop2++;
                            break;
                        case "b":
                            Console.WriteLine("The dragon sniffs you and likes the smell of your new deoderant and eats you. Here's a hint, don't hike in dragon country with things that smell good.");
                            escLoop++;
                            escLoop2++;
                            break;
                        case "c":
                            Console.WriteLine("The dragon looks perplexed and says, \"No one has ever asked me that before. I usually just eat humans. do you really mean that?\"");
                            escLoop++;
                            
                            break;
                        default:
                            Console.WriteLine("That is not a valid response! Try Again");
                            continue;
                    }
                                        
                }
                

                

                //Path 2
                Console.WriteLine("What say you?");
                while (escLoop2 < 2)
                {
                    Console.WriteLine("A. \"I was clearly joking. IDGAF about you!\"\nB. \"Woah didn't know you spoke English, but of course I mean it! I've never met, let alone spoken, to a dragon!\"\nC. Kick the dragon and run for it!");
                    string secondChoice = Console.ReadLine().ToLower();

                    switch (secondChoice)
                    {
                        case "a":
                            Console.WriteLine("You hurt the dragons feelings. It buns you alive...ouch.");
                            escLoop2++;
                            escLoop3++;
                            break;
                        case "b":
                            Console.WriteLine("Ofcourse I speak English. Thats why I went to school.");
                            escLoop2++;
                            
                            break;
                        case "c":
                            Console.WriteLine("Your kick connects!...Unfortunately its skin is tougher than a tank. The dragon whips its mighty tail and spilts you in two. You can see it eat your lower torso as you fade out...that was dumb");
                            escLoop2++;
                            escLoop3++;
                            break;
                        default:
                            Console.WriteLine("That is not a valid response! Try Again");
                            continue;
                    }
                }

                //Path 3
                Console.WriteLine("You respond to the dragon.");
                while (escLoop3 < 3)
                {
                    Console.WriteLine("A. \"Wait dragons go to school?!\"\nB. \"Well your English is trash.\"\nC. That's cool.");
                    string thirdChoice = Console.ReadLine().ToLower();

                    switch (thirdChoice)
                    {
                        case "a":
                            Console.WriteLine("Yeah, I studied finance, but I regret it. I hear these computers are all the rage these days.");
                            escLoop3++;
                            
                            break;
                        case "b":
                            Console.WriteLine("\"Oh yeah?! Well can you understand this?...YOUR DEAD!\" and the dragon gulps you down!");
                            escLoop3++;
                            escLoop4++;
                            break;
                        case "c":
                            Console.WriteLine("\"You find out that dragons can talk and go to school and all you say is 'Thats cool'?...You're the worst!\" The dragon flies away tired of your human nonsense.");
                            escLoop3++;
                            escLoop4++;
                            break;
                        default:
                            Console.WriteLine("That is not a valid response! Try Again");
                            continue;
                    }
                }

                //Path 4
                Console.WriteLine("What do you say?");
                while (escLoop4 < 4)
                {
                    Console.WriteLine("A. \"Do you have instagram?\"\nB. \"Hey I'm a programmer! I can train you!\"\nC. \"The internet sucks!\"");
                    string fourthChoice = Console.ReadLine().ToLower();

                    switch (fourthChoice)
                    {
                        case "a":
                            Console.WriteLine("\"Whats instagram? I have myspace.\" You keel over and die from such an old sentence.");
                            escLoop4++;
                            escLoop5++;
                            break;
                        case "b":
                            Console.WriteLine("\"Holy shit really? Yeah! but do you want to play Skyrim first?\"");
                            escLoop4++;
                            
                            break;
                        case "c":
                            Console.WriteLine("The dragon eats you where you stand!");
                            escLoop4++;
                            escLoop5++;
                            break;
                        default:
                            Console.WriteLine("That is not a valid response! Try Again");
                            continue;
                    }
                }

                //Path 5
                Console.WriteLine("What say you?");
                while (escLoop < 5)
                {
                    Console.WriteLine("A. \"Nah. Skyrim sucks!\"\nB. \"Isn't That game about killing dragons though?\"\nC. \"Hell yeah!\"");
                    string fifthChoice = Console.ReadLine().ToLower();

                    switch (fifthChoice)
                    {
                        case "a":
                            Console.WriteLine("You hurt the dragons feelings. It burns you alive...ouch.");
                            escLoop5++;
                            break;
                        case "b":
                            Console.WriteLine("\"Ugh!\" You annoy the dragon so it flies away.");
                            escLoop5++;
                            break;
                        case "c":
                            Console.WriteLine("You both high five and go back the the dragons place to play Skyrim and code. Lifes good. \nTHE END");
                            escLoop5++;
                            break;
                        default:
                            Console.WriteLine("That is not a valid response! Try Again");
                            continue;
                    }
                }
                if (cont == true)
                {
                    Console.WriteLine("Do you want to try again? (y/n)");
                    var answer = Console.ReadLine().ToLower();
                    if (answer == "y" || answer == "yes")
                    {
                        continue;
                    }
                    else if (answer == "n" || answer == "no")
                    {
                        cont = false; 
                    }
                }
                
            }
        }
    }
}
