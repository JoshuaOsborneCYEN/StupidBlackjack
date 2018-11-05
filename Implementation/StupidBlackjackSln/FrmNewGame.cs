﻿using StupidBlackjackSln.Code;
using StupidBlackjackSln.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StupidBlackjackSln
{
    public partial class FrmNewGame : Form
    {
        private Deck deck;
        private BlackjackPlayer player1;
        private BlackjackPlayer dealer;
        private PictureBox[] picPlayerCards;
        private PictureBox[] picDealerCards;
        
        public event EventHandler quitGame;

        public FrmNewGame()
        {
            InitializeComponent();
            picPlayerCards = new PictureBox[5];
            picDealerCards = new PictureBox[5];
            for (int i = 0; i < 5; i++)
            {
                picPlayerCards[i] = Controls.Find("picPlayerCard" + (i + 1).ToString(), true)[0] as PictureBox;
                picDealerCards[i] = Controls.Find("picDealerCard" + (i + 1).ToString(), true)[0] as PictureBox;
            }
        }

        private void FrmNewGame_Load(object sender, EventArgs e)
        {
            // initialize stuff
            deck = new Deck(FindBitmap);
            player1 = new BlackjackPlayer();
            dealer = new BlackjackPlayer();
            // add listener
            player1.scoreUpdated += p_ScoreUpdated;
            // add betting money
            player1.giveMoney(1000);
            updateGUI();
            startBetting();
        }

        /// <summary>
        /// Get everything ready to start betting, disable hit and stand buttons
        /// </summary>
        private void startBetting()
        {
            btnMakeBet.Enabled = true;
            btnMakeBet.Visible = true;
            txtbxBetAmount.Enabled = true;
            txtbxBetAmount.Visible = true;
            txtbxBetAmount.Select();

            btnHit.Enabled = false;
            btnStand.Enabled = false;
        }

        /// <summary>
        /// After player has input a valid bet, begin the game
        /// </summary>
        private void finishBetting()
        {
            int betAmount;
            if(int.TryParse(txtbxBetAmount.Text, out betAmount))
            {
                if(player1.makeBet(betAmount))
                {
                    //basic setup
                    btnMakeBet.Enabled = false;
                    btnMakeBet.Visible = false;
                    txtbxBetAmount.Enabled = false;
                    txtbxBetAmount.Visible = false;
                    player1.giveHand(new List<Card>() { deck.dealCard(), deck.dealCard() });
                    dealer.giveHand(new List<Card>() { deck.dealCard(), deck.dealCard() });
                    updateGUI();
                    updateDealerGUI(false);

                    //check BlackJacks
                    if (checkBlackjack(player1))
                    {
                        //give player oppurtunity to declare own blackjack
                        btnBlackJack.Visible = true;
                        btnBlackJack.Enabled = true;
                    }
                    else
                    {
                        btnHit.Enabled = true;
                        btnStand.Enabled = true;
                        if(checkBlackjack(dealer))
                        {
                            updateDealerGUI(true);
                            lblDealerScore.Text = "BLACKJACK!";
                            GameOver(2);
                        }
                    }
                }
            }
        }

        private bool checkBlackjack(BlackjackPlayer p)
        {
            if (p.Score == 21)
                return true;
            else
                return false;
        }

        /// <summary>
        /// updates GUI for player hand/score as well as betting information
        /// could consider moving betting information to its own method for efficiency
        /// </summary>
        private void updateGUI()
        {
            for (int i = 0; i < player1.Hand.Count(); i++)
            {
                picPlayerCards[i].BackgroundImage = player1.Hand[i].Bitmap;
            }
            for (int i = player1.Hand.Count(); i < picPlayerCards.Length; i++)
            {
                picPlayerCards[i].BackgroundImage = null;
            }
            lblPlayerScore.Text = player1.Score.ToString();
            lblMoney.Text = player1.Money.ToString();
            lblBetPool.Text = player1.Bet.ToString();
            
        }

        private void FrmNewGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            quitGame?.Invoke(this, EventArgs.Empty);
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            player1.giveCard(deck.dealCard());
            updateGUI();
        }


        private Bitmap FindBitmap(string value, string suit)
        {
            string textName = "";
            int valueAsNum;
            if (int.TryParse(value, out valueAsNum))
            {
                textName += "_";
            }

            textName += value;
            textName += "_of_";
            textName += suit;

            return (Bitmap)Resources.ResourceManager.GetObject(textName);
        }

        private void llblHotline_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", "https://www.ncpgambling.org/help-treatment/help-by-state/");
        }

        private void btnMakeBet_Click(object sender, EventArgs e)
        {
            finishBetting();
        }
        
        /// <summary>
        /// resets the game, starting betting over
        /// give player and dealer an empty hand to start
        /// </summary>
        private void ResetGame()
        {
            deck = new Deck(FindBitmap);
            startBetting();

            player1.giveHand(new List<Card> { });
            dealer.giveHand(new List<Card> { });

            btnBlackJack.Visible = false;
            btnBlackJack.Enabled = false;
            updateGUI();
            updateDealerGUI(false);
        }
        
        private void p_ScoreUpdated(object sender, EventArgs e)
        {
            if (player1.Score <= 21)
            {
                lblHandValue.Text = "Hand Value: " + player1.Score.ToString();
            }
            else 
            {
                lblHandValue.Text = "Bust!";
                updateGUI();
                GameOver(2);
            }
        }

        //Dealer stuff below here

        private void btnStand_Click(object sender, EventArgs e)
        {
            btnHit.Enabled = false; // temporarily disable buttons during dealer's turn
            btnStand.Enabled = false;
            dealerTurn();
        }

        /// <summary>
        /// Goes through dealer's turn, the dealer stands on 17 and higher
        /// random delays are added in between hits with a soft delay before the initial flip
        /// </summary>
        private async void dealerTurn()
        {
            Random rnd = new Random();

            await PutTaskDelay(500);
            updateDealerGUI(true);
            
            //hit when score below 17
            while (dealer.Score < 17)
            {
                await PutTaskDelay(rnd.Next(1000, 3000));
                dealer.giveCard(deck.dealCard());
                updateDealerGUI(true);
            }
            //decide how game ends based on final scores
            if (dealer.Score > 21)
            {
                lblDealerScore.Text = "BUSTED";
                lblPlayerScore.Text = "YOU WIN";
                GameOver(0);
            }
            else if (dealer.Score == player1.Score)
            {
                lblDealerScore.Text = "It's a tie";
                lblPlayerScore.Text = "It's a tie";
                GameOver(1);
            }
            else if(dealer.Score < player1.Score)
            {
                lblPlayerScore.Text = "YOU WIN";
                GameOver(0);
            }
            else
            {
                lblPlayerScore.Text = "YOU LOSE";
                GameOver(2);
            }
        }

        /// <summary>
        /// updates dealer GUI, this includes card pictures and score value
        /// special logic for when it isnt the dealers turn and
        /// when his hand is empty
        /// </summary>
        /// <param name="dealerTurn"></param>
        private void updateDealerGUI(bool dealerTurn)
        {
            if (dealerTurn)
            {
                for (int i = 0; i < dealer.Hand.Count(); i++)
                {
                    picDealerCards[i].BackgroundImage = dealer.Hand[i].Bitmap;
                    picDealerCards[i].Visible = true;
                }
                for (int i = dealer.Hand.Count(); i < picDealerCards.Length; i++)
                {
                    picDealerCards[i].BackgroundImage = null;
                }
                lblDealerScore.Text = dealer.Score.ToString();
            }
            else
            {
                if (dealer.Hand.Count() > 0)
                {
                    picDealerCards[0].BackgroundImage = dealer.Hand[0].Bitmap;
                    for (int i = 1; i < picDealerCards.Length; i++)
                    {
                        picDealerCards[i].Visible = false;
                    }
                    lblDealerScore.Text = "?";
                }
                else
                {
                    for (int i = 0; i < picDealerCards.Length; i++)
                        picDealerCards[i].BackgroundImage = null;
                    lblDealerScore.Text = "";
                }
            }
        }

        /// <summary>
        /// Asks the player if he wants to start a new game, also handles the conclusion of betting
        /// win = 0 means a win, win = 1 means a tie, win = anything else means a loss
        /// </summary>
        /// <param name="win"></param>
        private void GameOver(int win)
        {
            if (win == 0)
            {
                player1.winBet();
                player1.winstreak += 1;
                lblHandValue.Text = "WINNER";
            }
            else if (win == 1)
            {
                player1.tieBet();
                player1.winstreak = 0;
                lblHandValue.Text = "Tie";
            }
            else
            {
                player1.loseBet();
                player1.winstreak = 0;
                lblHandValue.Text = "Loser";
            }
            lblWinstreak.Text = "Winstreak: " + player1.winstreak.ToString();
            updateGUI();

            DialogResult result = MessageBox.Show("Do you want to play again?", "New game?", MessageBoxButtons.YesNo, MessageBoxIcon.None);
            if (result == DialogResult.Yes)
                ResetGame();
            else
            {
                quitGame?.Invoke(this, EventArgs.Empty);
                this.Close();
            }
        }

        async Task PutTaskDelay(int ms)
        {
            await Task.Delay(ms);
        }

        private void btnBlackJack_Click(object sender, EventArgs e)
        {
            lblPlayerScore.Text = "BLACKJACK!";
            if(checkBlackjack(dealer))
            {
                updateDealerGUI(true);
                lblDealerScore.Text = "BLACKJACK!";
                GameOver(1);
            }
            else
            {
                updateDealerGUI(true);
                GameOver(0);
            }
        }
    }
}

