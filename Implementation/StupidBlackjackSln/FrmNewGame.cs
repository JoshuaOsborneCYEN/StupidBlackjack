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

namespace StupidBlackjackSln {
  public partial class FrmNewGame : Form {
    private Deck deck;
    private BlackjackPlayer player1;
    private PictureBox[] picPlayerCards;

    public event EventHandler quitGame;

    public FrmNewGame() {
      InitializeComponent();
      picPlayerCards = new PictureBox[5];
      for (int i = 0; i < 5; i++) {
        picPlayerCards[i] = Controls.Find("picPlayerCard" + (i + 1).ToString(), true)[0] as PictureBox;
      }
    }

    private void FrmNewGame_Load(object sender, EventArgs e) {
      deck = new Deck(FindBitmap);
      player1 = new BlackjackPlayer();
      // add listener
      player1.scoreUpdated += p_ScoreUpdated;
      
      player1.giveHand(new List<Card>() { deck.dealCard(), deck.dealCard() });
      showHand();
    }

    private void showHand() {
      for (int i = 0; i < player1.Hand.Count(); i++) {
        picPlayerCards[i].BackgroundImage = player1.Hand[i].Bitmap;
      }
      // redundant, I added code in an event that accomplishes this.
      lblPlayerScore.Text = player1.Score.ToString();
    }

    private void FrmNewGame_FormClosed(object sender, FormClosedEventArgs e) {
      //
    }

    private void btnHit_Click(object sender, EventArgs e) {
      player1.giveCard(deck.dealCard());
      showHand();
    }

    private Bitmap FindBitmap(string value, string suit) {
      string textName = "";
      int valueAsNum;
      if (int.TryParse(value, out valueAsNum)) {
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

    private void p_ScoreUpdated(object sender, EventArgs e)
    {
      if (player1.Score <= 21) {
        lblHandValue.Text = "Hand Value: " + player1.Score.ToString();
      }
      else {
        lblHandValue.Text = "Bust!";
        DialogResult result = MessageBox.Show("Do you want to play again?", "New game?", MessageBoxButtons.YesNo, MessageBoxIcon.None);
        if (result == DialogResult.Yes)
          ResetGame();
        else
        {
          quitGame?.Invoke(this, EventArgs.Empty);
          this.Close();
        }
      }
    }

    private void ResetGame()
    {
      throw new NotImplementedException();
    }
  }
}
