using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCard
{
    class Deck
    {
        private List<Card> deck;
        private int currentCard;

        public Deck()
        {
            deck = new List<Card>();
            currentCard = 0;
            Card a;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 2; j <= 14; j++)
                {
                    deck.Add(a = new Card(j, i));
                }
            }
        }

        public Card NextCard()
        {
            Card toReturn = deck[currentCard];
            if (currentCard == deck.Count - 1)
            {
                currentCard = 0;
            }
            else
            {
                currentCard++;
            }
            return toReturn;
        }

        internal void Shuffle()
        {
            Random rnd = new Random();
            List<Card> shuffledDeck = new List<Card>();
            for (int i = deck.Count - 1; i >= 0; i--)
            {
                int j = rnd.Next(i);
                Card aux = deck[i];
                deck[i] = deck[j];
                deck[j] = aux;
            }
        }
    }
}
