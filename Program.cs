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
            //deck.Shuffle();

            /*
            // total set of cards
            int drawLimit = 10;
            while(drawLimit <= 10)
            {
                drawLimit--;

                player1Deck.Cards.Add(deck.Draw());
                player2Deck.Cards.Add(deck.Draw());

                deck.Shuffle();


            }
            */
            
            // single card setup
            player1Deck.Cards.Add(deck.Draw());
            deck.Shuffle();
            player2Deck.Cards.Add(deck.Draw());

            // Calculate scores using PlayerTotal method
            int player1Total = PlayerTotal(player1Deck);
            int player2Total = PlayerTotal(player2Deck);

            // display scores and winner
            if (player1Total > player2Total) { Console.WriteLine($"Players Totals :\nPlayer 1: {player1Total}\nPlayer 2: {player2Total}\n--Player 1 Wins!--\n"); }
            else if (player1Total < player2Total) { Console.WriteLine($"Players Totals :\nPlayer 1: {player1Total}\nPlayer 2: {player2Total}\n--Player 2 Wins!--\n"); }
            else { Console.WriteLine($"Players Totals :\nPlayer 1: {player1Total}\nPlayer 2: {player2Total}\n--It's a DRAW!--\n"); }

        }


        // Internal Method - Player score calculation
        public static int PlayerTotal(Deck playerDeck)
        {
            int playerTotal = 0;
            foreach (Card card in playerDeck.Cards)
            {
                playerTotal += card.Value;

                foreach (Card.Symbols symbol in Enum.GetValues(typeof(Card.Symbols)))
                {
                    switch (symbol)
                    {
                        case Card.Symbols.Hearts:
                            playerTotal += 4;
                            break;
                        case Card.Symbols.Diamonds:
                            playerTotal += 3;
                            break;
                        case Card.Symbols.Clubs:
                            playerTotal += 2;
                            break;
                        case Card.Symbols.Spades:
                            playerTotal += 1;
                            break;
                        default:
                            break;
                    }
                }
            }
            return playerTotal;

        }
    }
}
