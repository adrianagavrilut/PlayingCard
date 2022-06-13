namespace PlayingCard
{
    internal class Card
    {
        private int rank;
        private int suit;

        public Card(int rank, int suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public int Rank { get; set; }

        public int Suit { get; set; }

        public string FileName
        { 
            get
            {
                return $@"..\..\cards\{rank}.{suit}.png";
            }
        }



    }
}