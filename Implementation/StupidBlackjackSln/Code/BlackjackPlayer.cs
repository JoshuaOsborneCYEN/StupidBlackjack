using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidBlackjackSln.Code
{
    class BlackjackPlayer : Player
    {

        public event EventHandler scoreUpdated;
        public int winstreak
        {
            get;
            set;
        }

        public int InsuranceBet
        {
            get;
            protected set;
        }


        protected override void calcScore()
        {
            this.Score = 0;
            int numAces = 0;
            foreach (Card card in Hand)
            {
                int value;
                string cardValue = card.getValue();
                // 2 - 10
                if (int.TryParse(cardValue, out value))
                {
                    Score += value;
                }
                // jack, queen, king
                else if (!cardValue.ToLower().Equals("ace"))
                {
                    Score += 10;
                }
                // ace
                else
                {
                    numAces++;
                    Score += 11;
                }
            }

            if (this.Score > 21)
            {
                while (numAces > 0)
                {
                    Score -= 10;
                    if (this.Score > 21)
                    {
                        numAces--;
                        continue;
                    }
                    break;
                }
            }
            // invoke event that form can listen for
            scoreUpdated?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Returns half of the player's bet to their money, and forfeits the rest.
        /// </summary>
        public void Surrender()
        {
            int toReturn = Bet / 2;
            Money = Money + toReturn;
            Bet = 0;
        }

        public bool canMakeInsuranceBet()
        {
            int insuranceBet = Bet / 2;
            return canMakeBet(insuranceBet);
        }

        public void makeInsuranceBet()
        {
            InsuranceBet = Bet / 2;
            Money = Money - InsuranceBet;
        }

        public void winInsuranceBet()
        {
            Money = Money + InsuranceBet * 2;
            InsuranceBet = 0;
        }

        public void loseInsuranceBet()
        {
            InsuranceBet = 0;
        }

    }
}
