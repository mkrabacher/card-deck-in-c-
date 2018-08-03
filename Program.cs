using System;

namespace CardDeck
{
    class Program
    {
        public static Deck playDeck = new Deck();
        public static void showHand(Player current_player)
        {
            
        }

        public static void makeChoice()
        {            
            Console.WriteLine("Commands:");
            Console.WriteLine("[D]isplay the cards in the deck");
            Console.WriteLine("[S]huffle the cards in the deck.");
            Console.WriteLine("[So]rt the cards in the deck.");
            Console.WriteLine("[Q]uit.");
            string choice = Console.ReadLine().ToLower();

            if (choice == "d") 
            {
                playDeck.showCards();
                makeChoice();
            } 
            else if (choice == "s") 
            {
                playDeck.shuffle();
                playDeck.showCards();
                makeChoice();
            } 
            else if (choice == "so") 
            {
                playDeck.buildDeck();
                playDeck.showCards();
                makeChoice();
            }
            else if (choice == "q") 
            {
                Console.WriteLine("Bye.");
            }
            else 
            {
                Console.WriteLine("Uh so you seem to be having some trouble interpreting the instructions.");
                Console.WriteLine("Just press the 'D', 'S', 'So' or 'Q' and hit enter.");
                makeChoice();
            }
        }

        public static void gameLoop(Player current_player, Player other_player)
        {

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Here's a fresh deck of cards. What do you want to do with it?");

            playDeck.buildDeck();

            makeChoice();


            

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
