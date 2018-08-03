using System;

namespace CardDeck
{
    static class Render
    {
        //                         Foreground    Background
        public static Tuple<char, ConsoleColor, ConsoleColor>[,] Grid;
        public static int Width;
        public static int Height;

        public static int CardWidth = 14;
        public static int CardHeight = 10;
        public static int CardsPerRow = 8;

        private static int CardsDrawn = 0;
        private static int CurrentRow = 0;

        public static void CreateGrid(int width, int height)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Grid = new Tuple<char, ConsoleColor, ConsoleColor>[width, height];
            Width = width;
            Height = height;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Grid[x, y] = new Tuple<char, ConsoleColor, ConsoleColor>(' ', ConsoleColor.White, ConsoleColor.Black);
                }
            }
        }

        public static void Finish()
        {
            // Console.Clear();

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    Tuple<char, ConsoleColor, ConsoleColor> toPut = Grid[x, y];
                    Console.ForegroundColor = toPut.Item2;
                    Console.BackgroundColor = toPut.Item3;
                    Console.Write(toPut.Item1);
                }

                Console.WriteLine();
            }

            CardsDrawn = 0;
            CurrentRow = 0;
        }

        //                                      (background color)
        public static void DrawBackgroundRect(ConsoleColor color)
        {
            for (int x = 0; x < Width; x++)
            {   
                for (int y = 0; y < Height; y++)
                {
                    Tuple<char, ConsoleColor, ConsoleColor> oldChar = Grid[x, y];
                    Grid[x, y] = new Tuple<char, ConsoleColor, ConsoleColor>(oldChar.Item1, oldChar.Item2, color);
                }
            }
        }

        public static void DrawOutlinedRect(int xPos, int yPos, int width, int height, ConsoleColor color)
        {
            for (int x = xPos; x < xPos + width; x++)
            {   
                for (int y = yPos; y < yPos + height; y++)
                {
                    bool left = x == xPos;
                    bool right = x == xPos + width - 1;
                    bool top = y == yPos;
                    bool bottom = y == yPos + height - 1;

                    char toPut = ' ';

                    if (top && left)
                    {
                        toPut = '┏';
                    }
                    else if (top && right)
                    {
                        toPut = '┓';
                    }
                    else if (bottom && left)
                    {
                        toPut = '┗';
                    }
                    else if (bottom && right)
                    {
                        toPut = '┛';
                    }
                    else if (top || bottom)
                    {
                        toPut = '━';
                    }
                    else if (left || right)
                    {
                        toPut = '┃';
                    }

                    // Grid[x, y] = new Tuple<char, ConsoleColor, ConsoleColor>(toPut, color, ConsoleColor.Black);
                    Tuple<char, ConsoleColor, ConsoleColor > oldChar = Grid[x, y];
                    Grid[x, y] = new Tuple<char, ConsoleColor, ConsoleColor>(toPut, color, oldChar.Item3);
                }
            }
        }

        public static void SetCharAt(int xPos, int yPos, char toPut, ConsoleColor color)
        {
            Tuple<char, ConsoleColor, ConsoleColor> oldChar = Grid[xPos, yPos];
            Grid[xPos, yPos] = new Tuple<char, ConsoleColor, ConsoleColor>(toPut, color, oldChar.Item3);
        }

        public static void DrawString(int xPos, int yPos, string toPut, ConsoleColor color)
        {
            for (int i = 0; i < toPut.Length; i++)
            {
                SetCharAt(xPos + i, yPos, toPut[i], color);
            }
        }

        public static void DrawCard(string name, string desc, char upperLeftTop, char upperLeftBottom, char lowerRightTop, char lowerRightBottom, ConsoleColor color)
        {
            int x = CardsDrawn * (CardWidth + 2) + 1;
            int y = CurrentRow * (CardHeight + 1);

            //DrawBackgroundRect(x, y, CardWidth, CardHeight, ConsoleColor.Red);
            DrawOutlinedRect(x, y, CardWidth, CardHeight, color);
            SetCharAt(x + 1, y + 1, upperLeftTop, color);
            SetCharAt(x + 1, y + 2, upperLeftBottom, color);
            SetCharAt(x + CardWidth - 2, y + CardHeight - 3, lowerRightTop, color);
            SetCharAt(x + CardWidth - 2, y + CardHeight - 2, lowerRightBottom, color);

            DrawString(x + 2, y + CardHeight - 3, desc, color);
            DrawString(x + 2, y + CardHeight - 4, name  + " of", color);

            // if (pic != "")
            // {
            //     DrawString(x + 2, y + CardHeight - 2, "VAL " + lowerLeft + "|", color);
            //     DrawString(x + CardWidth - 6, y + CardHeight - 2, "name " + lowerRight, color);

            //     DrawOutlinedRect(x + 4, y + 2, 6, 3, color);
            //     DrawString(x + 5, y + 3, pic, color);
            // }

            CardsDrawn++;

            if (CardsDrawn == CardsPerRow)
            {
                CardsDrawn = 0;
                CurrentRow++;
            }
        }

        public static void DrawEmptyCard()
        {
            DrawCard("", "", ' ', ' ', ' ', ' ', ConsoleColor.Red);
        }

        public static void DrawBlankSlot()
        {
            DrawCard("", "", ' ', ' ', ' ', ' ', ConsoleColor.Black);
        }

        public static char ToChar(string str)
        {
            return str.ToCharArray()[0];
        }

        public static void DrawGame(Deck playDeck, Player current_player = null, Player other_player = null)
        {
            Console.WriteLine();

            // Render.DrawBackgroundRect(0, 0, 112, 10, ConsoleColor.DarkRed);
            Render.DrawBackgroundRect(ConsoleColor.DarkGreen);
            // Render.DrawBackgroundRect(0, 11, 112, 10, ConsoleColor.DarkGreen);
            
            int currCardIdx = 0;


            while(currCardIdx < 49) {
                for (int i = 0; i < CardsPerRow; i++)
                {
                    if (currCardIdx > 51) {
                        break;
                    }
                    else if (playDeck.cards[currCardIdx] != null) {
                        Card curr = playDeck.cards[currCardIdx] as Card;
                        char val = ToChar(curr.val.ToString());
                        char name = curr.name.ToCharArray()[0];
                        char suit = suitToUnicodeSymbol(curr.suit);
                        Render.DrawCard(curr.name, curr.suit, name, suit, suit, name, ConsoleColor.White);
                        currCardIdx++;
                    }
                }
            }

            // for (int i = 0; i < 7; i++)
            // {
            //     if (i < current_player.hand.Count) {
            //         Card curr = current_player.hand[i] as Card;
            //         char val = ToChar(curr.val);
            //         char name = curr.name.ToCharArray()[0];
            //         char suit = curr.suit.ToCharArray()[0];
            //         Render.DrawCard(curr.name, "12345678", "----", ToChar(i), suit, val, name, ConsoleColor.White);
            //     }
            //     else
            //     {
            //         Render.DrawBlankSlot();
            //     }
            // }

            // string toPut = "+++++++++++++++ greb's creatures +++++++++++++++";
            // Render.DrawString(0, 10, toPut, ConsoleColor.White);

            // toPut = "+++++++++++++++ suzie's hand +++++++++++++++";
            // Render.DrawString(0, 21, toPut, ConsoleColor.White);

            Render.Finish();
        }

        private static char suitToUnicodeSymbol(string suit)
        {
            string unicode = "";

            if (suit == "Clubs") {
                unicode = "\u2663";
            }
            else if (suit == "Diamonds") {
                unicode = "\u2666";
            }
            else if (suit == "Spades") {
                unicode = "\u2660";
            }
            else if (suit == "Hearts") {
                unicode = "\u2660";
            }

            return unicode.ToCharArray()[0];
        }
    }
}