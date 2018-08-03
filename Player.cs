using System;
using System.Collections.Generic;

namespace CardDeck
{
    public class Player
    {
        public Deck deck;
        public List<Card> hand = new List<Card>();
        public Card[] field = new Card[7];
        public string name;
        public Player(Deck inputDeck, string inputName)
        {
            deck = inputDeck;
            name = inputName;
        }
        public void draw()
        {
            if (deck.cards.Count > 0 && hand.Count < 7)
            {
                Card drawCard = deck.cards[0] as Card;
                deck.cards.RemoveAt(0);
                hand.Add(drawCard);
            }
        }

    }
}