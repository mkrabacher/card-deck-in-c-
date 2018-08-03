using System;
using System.Collections.Generic;
namespace CardDeck
{
    public class Card{
        public int val;
        public string name;
        public string suit;

        public Card(int newVal, string newName, string newSuit)
        {
            val = newVal;
            name = newName;
            suit = newSuit;
        }
    }
}