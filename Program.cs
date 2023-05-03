namespace CardGame
{
    class CardGame
    {
        public static void Main(string[] args)
        {
            // Game rules :
            // Greater card value wins
            // Ace = 1, J = 11, Q = 12, K = 13
            // Hearts = 4 > Diamonds = 3 > Clubs = 2 > Spades = 1 (Hearts-highest, Spades-lowest)

            Deck deck = new Deck();
            Deck player1Deck = new Deck();
            Deck player2Deck = new Deck();

            deck.GenerateCards();
            deck.Shuffle();

            /*
            int drawLimit = 13;
            while(drawLimit <= 13)
            {


            }
            */

            player1Deck.Cards.Add(deck.Draw());

            deck.Shuffle();

            player2Deck.Cards.Add(deck.Draw());

            int player1Total = 0;
            int player2Total = 0;

            //Deck[] playerDecks = { player1Deck, player2Deck };
            //int[] playerTotals = { player1Total, player2Total };


            //for (int i = 0; i < playerDecks.Length; i++)
            
                //for (int j = 0; j < playerTotals.Length; j++)
            
            // Player 2 calculation
            foreach (Card card in player1Deck.Cards)
            {
                player1Total += card.Value;

                foreach (Card.Symbols symbol in Enum.GetValues(typeof(Card.Symbols)))
                {
                    switch (symbol)
                    {
                        case Card.Symbols.Hearts:
                            player1Total += 4;
                            break;
                        case Card.Symbols.Diamonds:
                            player1Total += 3;
                            break;
                        case Card.Symbols.Clubs:
                            player1Total += 2;
                            break;
                        case Card.Symbols.Spades:
                            player1Total += 1;
                            break;
                        default:
                            break;
                    }
                }
            }

            // Player 2 calculation
            foreach (Card card in player2Deck.Cards)
            {
                player2Total += card.Value;

                foreach (Card.Symbols symbol in Enum.GetValues(typeof(Card.Symbols)))
                {
                    switch (symbol)
                    {
                        case Card.Symbols.Hearts:
                            player1Total += 4;
                            break;
                        case Card.Symbols.Diamonds:
                            player1Total += 3;
                            break;
                        case Card.Symbols.Clubs:
                            player1Total += 2;
                            break;
                        case Card.Symbols.Spades:
                            player1Total += 1;
                            break;
                        default:
                            break;
                    }
                }
            }


            if (player1Total > player2Total) { Console.WriteLine($"Players Totals :\nPlayer 1: {player1Total}\nPlayer 2: {player2Total}\n--Player 1 Wins!--\n"); }
            else if (player1Total < player2Total) { Console.WriteLine($"Players Totals :\nPlayer 1: {player1Total}\nPlayer 2: {player2Total}\n--Player 2 Wins!--\n"); }
            else { Console.WriteLine($"Players Totals :\nPlayer 1: {player1Total}\nPlayer 2: {player2Total}\n--It's a DRAW!--\n"); }

        }
    }
}
