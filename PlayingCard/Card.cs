namespace PlayingCard
{
    internal class Card
    {
        private int rank;
        private int suit;

        public Card()
        {

        }

        public Card(int rank, int suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public int Rank { get; set; }

        public int Suit { get; set; }

        public int Image { get; set; }

    }
}