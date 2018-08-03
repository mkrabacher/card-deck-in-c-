using System;
using System.Collections.Generic;

namespace CardDeck {
    public class Deck {
        public List<Card> cards;
        List<string> suits = new List<string>();

        public Deck buildDeck() {
            suits.Add("Hearts");
            suits.Add("Spades");
            suits.Add("Clubs");
            suits.Add("Diamonds");
            
            cards = new List<Card>();
            for(int suit = 0; suit < 4; suit++) {
                for(int i = 1; i < 14; i++) {
                    string stringVal = i.ToString();
                    if(i == 1) {
                        stringVal = "Ace";
                    }
                    else if(i == 11) {
                        stringVal = "Jack";
                    }
                    else if(i == 12) {
                        stringVal = "Queen";
                    }
                    else if(i == 13) {
                        stringVal = "King";
                    }
                    Card newCard = new Card(i,stringVal, suits[suit]);
                    cards.Add(newCard);
                }
            }
            return this;
        }

        public string showCards() {
            string returnString = "";
            for (int i = 0; i < this.cards.Count; i++)
            {
                returnString += this.cards[i].name + " of " + this.cards[i].suit + "\n";
            }
            return returnString;
        }
    }
}
