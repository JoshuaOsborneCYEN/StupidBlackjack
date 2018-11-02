using StupidBlackjackSln.Code;
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
        private Player player1;
        private PictureBox[] picPlayerCards;

        public FrmNewGame()
        {
            InitializeComponent();
            picPlayerCards = new PictureBox[5];
            for (int i = 0; i < 5; i++)
            {
                picPlayerCards[i] = Controls.Find("picPlayerCard" + (i + 1).ToString(), true)[0] as PictureBox;
            }
        }

        private void FrmNewGame_Load(object sender, EventArgs e)
        {
            deck = new Deck(FindBitmap);
            player1 = new BlackjackPlayer();
            player1.giveMoney(1000);
            updateGUI();
            startBetting();
        }

        private void startBetting()
        {
            btnMakeBet.Enabled = true;
            btnMakeBet.Visible = true;
            txtbxBetAmount.Enabled = true;
            txtbxBetAmount.Visible = true;
        }

        private void finishBetting()
        {
            int betAmount;
            if(int.TryParse(txtbxBetAmount.Text, out betAmount))
            {
                if(player1.makeBet(betAmount))
                {
                    btnMakeBet.Enabled = false;
                    btnMakeBet.Visible = false;
                    txtbxBetAmount.Enabled = false;
                    txtbxBetAmount.Visible = false;
                    player1.giveHand(new List<Card>() { deck.dealCard(), deck.dealCard() });
                    updateGUI();
                }
            }
        }

        private void updateGUI()
        {
            for (int i = 0; i < player1.Hand.Count(); i++)
            {
                picPlayerCards[i].BackgroundImage = player1.Hand[i].Bitmap;
            }
            lblPlayerScore.Text = player1.Score.ToString();
            lblMoney.Text = player1.Money.ToString();
            lblBetPool.Text = player1.Bet.ToString();
            
        }

        private void FrmNewGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                f.Close();
            }
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
    }
}
