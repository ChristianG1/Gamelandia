string nameUser = "";
int coints = 0;
string chooise = "menu";
string answerUser = "";
int numberRandomUser = 0;
int numberRandomDealer = 0;
int counter21User = 0;
string message21 = "";

// ROCK
int userRockWin = 0;
int localRockWin = 0;
string[] options = { "rock", "paper", "scisor" };
int indexRandomRock = 0;
string optionRandom = "";
string optionUserRock = "";

Random random = new Random();

Console.WriteLine("Welcome to G A M E L A N D I A");
Console.WriteLine("Write the user name: ");
nameUser = Console.ReadLine();

Console.WriteLine("------------------------------------------------------------");
Console.WriteLine($"Hello {nameUser}, we have different games");

do {
    Console.WriteLine($"{nameUser} please, writes how much points do you need, remember, 1 point \n" +
        $"is equal 1 round game");
    coints = int.Parse(Console.ReadLine());
    if(coints != 0)
    {
        for(int i = 0; i<coints; i++)
        {
           

            switch (chooise)
            {
                case "menu":
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("Which game do you play? \n" +
                      "21 = Blackjack \n" +
                      "Rock = Rock, paper, scisor");
                    chooise = Console.ReadLine().ToLower();
                    i--;
                    break;

                case "21":
                    numberRandomDealer = random.Next(14, 23);
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("Blackjack it's a card game where you have to asking a new card \n" +
                        "but the limit of points card is 21, if you pass of limit you lost \n" +
                        "and you if not pass of limit and you pass limit dealer, you win. Let's go.");
                    Console.WriteLine("------------------------------------------------------------");
                    do {
                        Console.WriteLine("The dealer is handing out playing cards...");
                        numberRandomUser = random.Next(1, 12);

                        counter21User = counter21User + numberRandomUser;
                        Console.WriteLine($"You card is: {numberRandomUser}");

                        Console.WriteLine("Do you have a new card?");
                        answerUser = Console.ReadLine().ToLower();

                        if(counter21User > 21)
                        {
                            break;
                        }

                        if(answerUser == "no")
                        {
                            break;
                        }


                    } while (answerUser == "si" || answerUser == "yes");

                    if (counter21User > numberRandomDealer && counter21User <= 21)
                    {
                        message21 = $"Congratulations, you win, your cards: {counter21User} and dealer cards: {numberRandomDealer}";
                        chooise = "menu";
                    }
                    else if (counter21User < numberRandomDealer)
                        
                    {
                        message21 = $"Sorry, this game you lost, your cards: {counter21User} and dealer cards: {numberRandomDealer}";
                    }
                    else if (counter21User > 21)
                    {
                        message21 = $"Sorry, you pass of limit 21, you cards: {counter21User}";
                    }

                    Console.WriteLine(message21);
                    counter21User = 0;
                    numberRandomDealer = 0;
                    break;

                case "rock":
                    Console.WriteLine("-------------------------------------------------------------");
                    Console.WriteLine("Rock, paper and scisor is a game about 3 random options, in this game \n" +
                        "you can try tree times for the win, rules:\n" +
                        "1. Paper wins vs Rock\n" +
                        "2. Scisors wins vs Paper\n" +
                        "3. Rock wins vs Scisors");

                    do
                    {
                        indexRandomRock = random.Next(options.Length);
                        optionRandom = options[indexRandomRock];
                     
                        Console.WriteLine("What option do you want?");
                        optionUserRock = Console.ReadLine().ToLower();

                        if (optionUserRock == "rock" || optionUserRock == "scisor" || optionUserRock == "paper")
                        {
                            if ((optionUserRock == "rock" && optionRandom == "rock") || (optionUserRock == "paper" && optionRandom == "paper") || (optionUserRock == "scisor" && optionRandom == "scisor"))
                            {
                                Console.WriteLine("-------------------------------------------------------------");
                                Console.WriteLine($"Tie, try again, your chooise is: {optionUserRock} and local chooise is: {optionRandom}");
                            }
                            else if (optionUserRock == "rock" && optionRandom == "scisor")
                            {
                                Console.WriteLine("-------------------------------------------------------------");
                                Console.WriteLine($"You win, your chooise is: {optionUserRock} and local chooise is: {optionRandom}");
                                userRockWin = userRockWin + 1;

                            }
                            else if (optionUserRock == "rock" && optionRandom == "paper")
                            {
                                Console.WriteLine("-------------------------------------------------------------");
                                Console.WriteLine($"You lost, your chooise is: {optionUserRock} and local chooise is: {optionRandom}");
                                localRockWin = localRockWin + 1;
                            } else if(optionUserRock == "paper" && optionRandom == "scisor")
                            {
                                Console.WriteLine("-------------------------------------------------------------");
                                Console.WriteLine($"You lost, your chooise is: {optionUserRock} and local chooise is {optionRandom}");
                                localRockWin = localRockWin + 1;

                            }
                            else
                            {
                                Console.WriteLine("-------------------------------------------------------------");
                                Console.WriteLine($"You win, your chooise is: {optionUserRock} and local chooise is: {optionRandom}");
                                userRockWin = userRockWin + 1;
                            }

                            Console.WriteLine($"Your wins: {userRockWin}");
                            Console.WriteLine($"Local wins: {localRockWin}");
                        }
                        else
                        {
                            Console.WriteLine("-------------------------------------------------------------");
                            Console.WriteLine("Please, your chooise is should good option like: rock, scisor or paper");
                        }
                    } while (userRockWin < 3 && localRockWin < 3);

                    if(userRockWin == 3)
                    {
                        Console.WriteLine("Congratulations, you win!");
                        Console.WriteLine("-------------------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, today you aren't luck");
                        Console.WriteLine("-------------------------------------------------------------");
                    }


                    userRockWin = 0;
                    localRockWin = 0;
                    chooise = "menu";
                    break;

                default:
                    Console.WriteLine("You don't select valid option, please select a correct option");
                    chooise = "menu";
                    break;
            }

        }

    } else
    {
        Console.WriteLine("Sorry, you need writes 1 coin or plus");
    }

} while (true);
