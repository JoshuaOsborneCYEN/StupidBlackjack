using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidBlackjackSln.Code
{
    public abstract class Player
    {
        public int Score
        {
            get;
            protected set;
        }

        public int Money
        {
            get;
            protected set;
        }

        public int Bet
        {
            get;
            protected set;
        }

        public List<Card> Hand
        {
            get;
            protected set;
        }

        public Player()
        {
            Score = 0;
            Money = 0;
            Bet = 0;
            Hand = new List<Card>();
        }

        public void giveHand(List<Card> initHand)
        {
            Hand = initHand;
            calcScore();
        }

        public void giveCard(Card card)
        {
            Hand.Add(card);
            calcScore();
        }

        public void giveMoney(int initMoney)
        {
            Money = initMoney;
        }

        public bool makeBet(int bet)
        {
            if (Money - bet >= 0 && bet >= 0)
            {
                Money = Money - bet;
                Bet = bet;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void winBet()
        {
            Money = Money + 2*Bet;
            Bet = 0;
        }
        public void tieBet()
        {
            Money = Money + Bet;
            Bet = 0;
        }
        public void loseBet()
        {
            Bet = 0;
        }

        protected abstract void calcScore();
    }
}
