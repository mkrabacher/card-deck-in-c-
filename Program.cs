﻿using System;

namespace CardDeck
{
    class Program
    {
        // public static void showHand(Player current_player)
        // {
        //     Console.WriteLine($"+++++++++++++++ {current_player.name}'s Hand ++++++++++++++");
        //     for(int i = 0; i < current_player.hand.Count; i++)
        //     {
        //         if(current_player.hand[i] is Minion){
        //             Minion card = current_player.hand[i] as Minion;
        //             Console.WriteLine($"Card {i}: Name: {card.name} --- Attack: {card.atk} --- HP: {card.hp} --- Cost: {card.cost}");
        //         }
        //         //add spell display here as else if
        //     }
        //     Console.WriteLine($"++++++++++++++++++++++++++++++++++++++++++++++++++++++");
        // }

        // public static void playCard(Player current_player, Player other_player)
        // {
        //     Render.DrawGame(current_player, other_player);
        //     Console.WriteLine("Please input the slot # of the card you want to play:");
        //     string card_string = Console.ReadLine();
        //     if(int.TryParse(card_string, out int card_num))
        //     {
        //         if (card_num < current_player.hand.Count && card_num >= 0)
        //         {
        //             Console.WriteLine($"Select the slot in the field you wish to play {current_player.hand[card_num].name} in:");
        //             int slot = GetInput.GetInt();
        //             if(current_player.field[slot] == null)
        //             {
        //                 turn_mana -= current_player.hand[card_num].cost;
        //                 current_player.field[slot] = current_player.hand[card_num] as Minion;
        //                 current_player.hand.RemoveAt(card_num);
        //                 showInfo(current_player, other_player);
        //             }
        //             else
        //             {
        //                 Console.WriteLine("There's already a card in that slot.");
        //             }

        //         }
        //         else
        //         {
        //             Console.WriteLine("That number is outside the bounds of your hand");
        //         }
        //     }
        //     else
        //     {
        //         Console.WriteLine("That wasn't a number");
        //     }
        // }

        // public static bool makeChoice(Player current_player, Player other_player)
        // {
        //     Console.WriteLine($"Mana: {turn_mana}");            
        //     Console.WriteLine("Do you want to [P]lay a card, [A]ttack with a creature or [E]nd your turn.");
        //     string choice = Console.ReadLine().ToLower();
        //     if(choice != "p" && choice != "a" && choice != "e")
        //     {
        //         Console.WriteLine("I guess you had an issue with the instructions");
        //         Console.WriteLine("Enter 'P', 'A' or 'E' since that wasn't clear");
        //     }
        //     else if (choice == "p")
        //     {
        //         playCard(current_player, other_player);
        //     }
        //     else if (choice == "a")
        //     {
        //         AttackClass.Attack(current_player, other_player);
        //     }
        //     else if (choice == "e")
        //     {
        //         Console.WriteLine($"End of {current_player.name}'s turn.");
        //         return false;
        //     }
            

        //     return true;
        // }

        // public static void gameLoop(Player current_player, Player other_player)
        // {
        //     current_player.draw();
        //     showInfo(current_player, other_player);
        //     while(makeChoice(current_player, other_player)){}

        //     for(int i = 0; i < 7; i++)
        //     {
        //         if(current_player.field[i] != null)
        //         {
        //             current_player.field[i].canAtk = true;
        //         }
        //     }
        //     //sets up next player's turn
        //     Player temp = current_player;
        //     current_player = other_player;
        //     other_player = temp;
        // }

        static void Main(string[] args)
        {
            Console.WriteLine($"Welcome to game time, you are Player");

            Deck playDeck = new Deck();

            playDeck.buildDeck();

            Console.WriteLine(playDeck.showCards());
                        //   height, width
            Render.CreateGrid(129, 76);
            Render.DrawGame(playDeck);

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Player player1 = GameStart.makePlayer();
            // Console.WriteLine($"Greetings {player1.name}, you are now playing as Player 1");
            // Player player2 = GameStart.makePlayer();
            // Console.WriteLine($"Greetings {player2.name}, you are now playing as Player 2");

            // Player current_player = player1;
            // Player other_player = player2;
            // Player tempPlayer;
            
            // Game Loop


            // while(player1.health > 0 && player2.health > 0)
            // {
            //     Render.CreateGrid(114, 32);

            //     // showInfo(current_player, other_player);
            //     gameLoop(current_player, other_player);
            //     tempPlayer = current_player;
            //     current_player = other_player;
            //     other_player = tempPlayer;
            // }
            // Player loser;
            // Player winner;
            // if(player1.health <= 0)
            // {
            //     loser = player1;
            //     winner = player2;
            // }
            // else 
            // {
            //     loser = player2;                
            //     winner = player1;                
            // }

            // Console.WriteLine($"{loser.name} Loses!");            
            // Console.ReadLine();
            // for(int i = 0; i < 99; i++)
            // {
            //     Console.WriteLine($"{winner.name} Wins!");
            // }          
            // Console.ReadLine();
            // Console.WriteLine("++++++++++++++++++++  ++++++++++++++++++++");
            // Console.WriteLine("++++++++++++++++++++  ++++++++++++++++++++");
            // Console.WriteLine("++++                  ++++            ++++");
            // Console.WriteLine("++++                  ++++            ++++");
            // Console.WriteLine("++++    ++++++++++++  ++++            ++++");
            // Console.WriteLine("++++    ++++++++++++  ++++            ++++");
            // Console.WriteLine("++++            ++++  ++++            ++++");
            // Console.WriteLine("++++            ++++  ++++            ++++");
            // Console.WriteLine("++++++++++++++++++++  ++++++++++++++++++++");
            // Console.WriteLine("++++++++++++++++++++  ++++++++++++++++++++");
            // Console.WriteLine("                                          ");
            // Console.WriteLine("++++++++++++++++++++  ++++            ++++");
            // Console.WriteLine("++++++++++++++++++++   ++++          ++++ ");
            // Console.WriteLine("++++            ++++    ++++        ++++  ");
            // Console.WriteLine("++++            ++++     ++++      ++++   ");
            // Console.WriteLine("++++++++++++++++++++      ++++    ++++    ");
            // Console.WriteLine("++++++++++++++++++++       ++++  ++++     ");
            // Console.WriteLine("++++            ++++        ++++++++      ");
            // Console.WriteLine("++++            ++++         ++++++       ");
            // Console.WriteLine("++++            ++++          ++++        ");
            // Console.WriteLine("++++            ++++           ++         ");
            // Console.WriteLine("                                          ");
            // Console.WriteLine("++++            ++++  ++++++++++++++++++++");
            // Console.WriteLine("++++            ++++  ++++++++++++++++++++");
            // Console.WriteLine("++++++        ++++++  ++++                ");
            // Console.WriteLine("++++++++    ++++++++  ++++                ");
            // Console.WriteLine("++++  ++++++++  ++++  ++++++++++++++++++++");
            // Console.WriteLine("++++   ++++++   ++++  ++++++++++++++++++++");
            // Console.WriteLine("++++            ++++  ++++                ");
            // Console.WriteLine("++++            ++++  ++++                ");
            // Console.WriteLine("++++            ++++  ++++++++++++++++++++");
            // Console.WriteLine("++++            ++++  ++++++++++++++++++++");
            // Console.WriteLine("                                          ");
            // Console.WriteLine("++++++++++++++++++++  ++++++++++++++++++++");
            // Console.WriteLine("++++++++++++++++++++  ++++++++++++++++++++");
            // Console.WriteLine("++++                  ++++            ++++");
            // Console.WriteLine("++++                  ++++            ++++");
            // Console.WriteLine("++++++++++++++++++++  ++++++++++++++++++++");
            // Console.WriteLine("++++++++++++++++++++  ++++++++++++++++++++");
            // Console.WriteLine("++++                  ++++      ++++      ");
            // Console.WriteLine("++++                  ++++        ++++    ");
            // Console.WriteLine("++++++++++++++++++++  ++++          ++++  ");
            // Console.WriteLine("++++++++++++++++++++  ++++            ++++");
        }
    }
}
