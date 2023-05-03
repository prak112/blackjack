using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Deck
    {
        // Properties
        public List<Card> Cards = new List<Card>();
    

        // Method
        public void GenerateCards()
        {
            const int deckSize = 13;

            // generate all values
            for (int i = 1; i <= deckSize; i++)
            {
                // generate all symbols for each value
                foreach (Card.Symbols symbol in Enum.GetValues(typeof(Card.Symbols)))
                {
                    Cards.Add(new Card(i, symbol));
                }
            }
        }

        public Card Draw()
        {            
            Card drawCard = Cards[0];           // To-Do : Draw a random card from deck
            Cards.Remove(drawCard);

            return drawCard;
        }

        public void Shuffle()
        {
            // Fisher-Yates shuffle algorithm
            Random rand = new Random();
            int n = Cards.Count;
            while (n > 1)
            {
                n--;
                int randCard = rand.Next(n + 1);
                Card tempCard = Cards[n];
                Cards[n] = Cards[randCard];
                Cards[randCard] = tempCard;
            }

        }



    }
}

    
