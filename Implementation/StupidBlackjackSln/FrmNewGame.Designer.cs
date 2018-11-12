namespace StupidBlackjackSln {
  partial class FrmNewGame {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
			this.btnHit = new System.Windows.Forms.Button();
			this.btnStand = new System.Windows.Forms.Button();
			this.lblHandValue = new System.Windows.Forms.Label();
			this.lblPlayerScore = new System.Windows.Forms.Label();
			this.llblHotline = new System.Windows.Forms.LinkLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.lblMoney = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblBetPool = new System.Windows.Forms.Label();
			this.txtbxBetAmount = new System.Windows.Forms.TextBox();
			this.btnMakeBet = new System.Windows.Forms.Button();
			this.lblDealerScore = new System.Windows.Forms.Label();
			this.lblWinstreak = new System.Windows.Forms.Label();
			this.btnBlackJack = new System.Windows.Forms.Button();
			this.btnSurrender = new System.Windows.Forms.Button();
			this.btnBuyInsurance = new System.Windows.Forms.Button();
			this.btnSkipInsurance = new System.Windows.Forms.Button();
			this.lblInsurance = new System.Windows.Forms.Label();
			this.btnDoubleDown = new System.Windows.Forms.Button();
			this.picPlayerCard7 = new System.Windows.Forms.PictureBox();
			this.picPlayerCard6 = new System.Windows.Forms.PictureBox();
			this.picDealerCard7 = new System.Windows.Forms.PictureBox();
			this.picDealerCard6 = new System.Windows.Forms.PictureBox();
			this.picDealerCard5 = new System.Windows.Forms.PictureBox();
			this.picDealerCard4 = new System.Windows.Forms.PictureBox();
			this.picDealerCard3 = new System.Windows.Forms.PictureBox();
			this.picDealerCard2 = new System.Windows.Forms.PictureBox();
			this.picDealerCard1 = new System.Windows.Forms.PictureBox();
			this.picPlayerCard5 = new System.Windows.Forms.PictureBox();
			this.picPlayerCard4 = new System.Windows.Forms.PictureBox();
			this.picPlayerCard3 = new System.Windows.Forms.PictureBox();
			this.picPlayerCard2 = new System.Windows.Forms.PictureBox();
			this.picPlayerCard1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picPlayerCard7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picPlayerCard6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picDealerCard7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picDealerCard6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picDealerCard5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picDealerCard4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picDealerCard3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picDealerCard2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picDealerCard1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picPlayerCard5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picPlayerCard4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picPlayerCard3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picPlayerCard2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picPlayerCard1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnHit
			// 
			this.btnHit.AutoSize = true;
			this.btnHit.Location = new System.Drawing.Point(24, 186);
			this.btnHit.Margin = new System.Windows.Forms.Padding(4);
			this.btnHit.Name = "btnHit";
			this.btnHit.Size = new System.Drawing.Size(61, 28);
			this.btnHit.TabIndex = 5;
			this.btnHit.Text = "Hit";
			this.btnHit.UseVisualStyleBackColor = true;
			this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
			// 
			// btnStand
			// 
			this.btnStand.AutoSize = true;
			this.btnStand.Location = new System.Drawing.Point(93, 186);
			this.btnStand.Margin = new System.Windows.Forms.Padding(4);
			this.btnStand.Name = "btnStand";
			this.btnStand.Size = new System.Drawing.Size(71, 28);
			this.btnStand.TabIndex = 6;
			this.btnStand.Text = "Stand";
			this.btnStand.UseVisualStyleBackColor = true;
			this.btnStand.Click += new System.EventHandler(this.btnStand_Click);
			// 
			// lblHandValue
			// 
			this.lblHandValue.AutoSize = true;
			this.lblHandValue.BackColor = System.Drawing.Color.Transparent;
			this.lblHandValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblHandValue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblHandValue.Location = new System.Drawing.Point(8, 76);
			this.lblHandValue.Name = "lblHandValue";
			this.lblHandValue.Size = new System.Drawing.Size(246, 39);
			this.lblHandValue.TabIndex = 9;
			this.lblHandValue.Text = "Hand Value: 0";
			// 
			// lblPlayerScore
			// 
			this.lblPlayerScore.AutoSize = true;
			this.lblPlayerScore.BackColor = System.Drawing.Color.Transparent;
			this.lblPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblPlayerScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblPlayerScore.Location = new System.Drawing.Point(331, 228);
			this.lblPlayerScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblPlayerScore.Name = "lblPlayerScore";
			this.lblPlayerScore.Size = new System.Drawing.Size(132, 46);
			this.lblPlayerScore.TabIndex = 7;
			this.lblPlayerScore.Text = "label1";
			// 
			// llblHotline
			// 
			this.llblHotline.AutoSize = true;
			this.llblHotline.BackColor = System.Drawing.Color.Transparent;
			this.llblHotline.LinkColor = System.Drawing.Color.Red;
			this.llblHotline.Location = new System.Drawing.Point(645, 528);
			this.llblHotline.Name = "llblHotline";
			this.llblHotline.Size = new System.Drawing.Size(402, 17);
			this.llblHotline.TabIndex = 8;
			this.llblHotline.TabStop = true;
			this.llblHotline.Text = "Gambling problem? Click here or call 1-800-522-4700 for help.";
			this.llblHotline.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblHotline_LinkClicked);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(27, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 20);
			this.label1.TabIndex = 9;
			this.label1.Text = "Current Money:";
			// 
			// lblMoney
			// 
			this.lblMoney.AutoSize = true;
			this.lblMoney.BackColor = System.Drawing.Color.Transparent;
			this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblMoney.ForeColor = System.Drawing.Color.Chartreuse;
			this.lblMoney.Location = new System.Drawing.Point(157, 9);
			this.lblMoney.Name = "lblMoney";
			this.lblMoney.Size = new System.Drawing.Size(53, 20);
			this.lblMoney.TabIndex = 10;
			this.lblMoney.Text = "label2";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label2.Location = new System.Drawing.Point(12, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(139, 20);
			this.label2.TabIndex = 11;
			this.label2.Text = "Current Bet Pool:";
			// 
			// lblBetPool
			// 
			this.lblBetPool.AutoSize = true;
			this.lblBetPool.BackColor = System.Drawing.Color.Transparent;
			this.lblBetPool.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
			this.lblBetPool.ForeColor = System.Drawing.Color.Red;
			this.lblBetPool.Location = new System.Drawing.Point(157, 38);
			this.lblBetPool.Name = "lblBetPool";
			this.lblBetPool.Size = new System.Drawing.Size(85, 20);
			this.lblBetPool.TabIndex = 12;
			this.lblBetPool.Text = "lblBetPool";
			// 
			// txtbxBetAmount
			// 
			this.txtbxBetAmount.Location = new System.Drawing.Point(279, 7);
			this.txtbxBetAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtbxBetAmount.Name = "txtbxBetAmount";
			this.txtbxBetAmount.Size = new System.Drawing.Size(100, 22);
			this.txtbxBetAmount.TabIndex = 13;
			// 
			// btnMakeBet
			// 
			this.btnMakeBet.Location = new System.Drawing.Point(304, 38);
			this.btnMakeBet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnMakeBet.Name = "btnMakeBet";
			this.btnMakeBet.Size = new System.Drawing.Size(49, 23);
			this.btnMakeBet.TabIndex = 14;
			this.btnMakeBet.Text = "Bet";
			this.btnMakeBet.UseVisualStyleBackColor = true;
			this.btnMakeBet.Click += new System.EventHandler(this.btnMakeBet_Click);
			// 
			// lblDealerScore
			// 
			this.lblDealerScore.AutoSize = true;
			this.lblDealerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDealerScore.Location = new System.Drawing.Point(783, 38);
			this.lblDealerScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblDealerScore.Name = "lblDealerScore";
			this.lblDealerScore.Size = new System.Drawing.Size(0, 46);
			this.lblDealerScore.TabIndex = 19;
			// 
			// lblWinstreak
			// 
			this.lblWinstreak.AutoSize = true;
			this.lblWinstreak.BackColor = System.Drawing.Color.Transparent;
			this.lblWinstreak.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
			this.lblWinstreak.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lblWinstreak.Location = new System.Drawing.Point(8, 130);
			this.lblWinstreak.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblWinstreak.Name = "lblWinstreak";
			this.lblWinstreak.Size = new System.Drawing.Size(217, 39);
			this.lblWinstreak.TabIndex = 21;
			this.lblWinstreak.Text = "Winstreak: 0";
			// 
			// btnBlackJack
			// 
			this.btnBlackJack.AutoSize = true;
			this.btnBlackJack.Enabled = false;
			this.btnBlackJack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBlackJack.Location = new System.Drawing.Point(9, 354);
			this.btnBlackJack.Margin = new System.Windows.Forms.Padding(4);
			this.btnBlackJack.Name = "btnBlackJack";
			this.btnBlackJack.Size = new System.Drawing.Size(156, 42);
			this.btnBlackJack.TabIndex = 22;
			this.btnBlackJack.Text = "BLACKJACK!";
			this.btnBlackJack.UseVisualStyleBackColor = true;
			this.btnBlackJack.Visible = false;
			this.btnBlackJack.Click += new System.EventHandler(this.btnBlackJack_Click);
			// 
			// btnSurrender
			// 
			this.btnSurrender.AutoSize = true;
			this.btnSurrender.Location = new System.Drawing.Point(24, 257);
			this.btnSurrender.Margin = new System.Windows.Forms.Padding(4);
			this.btnSurrender.Name = "btnSurrender";
			this.btnSurrender.Size = new System.Drawing.Size(141, 28);
			this.btnSurrender.TabIndex = 23;
			this.btnSurrender.Text = "Surrender";
			this.btnSurrender.UseVisualStyleBackColor = true;
			this.btnSurrender.Click += new System.EventHandler(this.btnSurrender_Click);
			// 
			// btnBuyInsurance
			// 
			this.btnBuyInsurance.Enabled = false;
			this.btnBuyInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBuyInsurance.Location = new System.Drawing.Point(347, 159);
			this.btnBuyInsurance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnBuyInsurance.Name = "btnBuyInsurance";
			this.btnBuyInsurance.Size = new System.Drawing.Size(116, 43);
			this.btnBuyInsurance.TabIndex = 24;
			this.btnBuyInsurance.Text = "Buy";
			this.btnBuyInsurance.UseVisualStyleBackColor = true;
			this.btnBuyInsurance.Visible = false;
			this.btnBuyInsurance.Click += new System.EventHandler(this.btnBuyInsurance_Click);
			// 
			// btnSkipInsurance
			// 
			this.btnSkipInsurance.Enabled = false;
			this.btnSkipInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSkipInsurance.Location = new System.Drawing.Point(469, 159);
			this.btnSkipInsurance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSkipInsurance.Name = "btnSkipInsurance";
			this.btnSkipInsurance.Size = new System.Drawing.Size(116, 43);
			this.btnSkipInsurance.TabIndex = 25;
			this.btnSkipInsurance.Text = "Skip";
			this.btnSkipInsurance.UseVisualStyleBackColor = true;
			this.btnSkipInsurance.Visible = false;
			this.btnSkipInsurance.Click += new System.EventHandler(this.btnSkipInsurance_Click);
			// 
			// lblInsurance
			// 
			this.lblInsurance.AutoSize = true;
			this.lblInsurance.BackColor = System.Drawing.Color.Transparent;
			this.lblInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInsurance.ForeColor = System.Drawing.Color.Yellow;
			this.lblInsurance.Location = new System.Drawing.Point(389, 121);
			this.lblInsurance.Name = "lblInsurance";
			this.lblInsurance.Size = new System.Drawing.Size(155, 32);
			this.lblInsurance.TabIndex = 26;
			this.lblInsurance.Text = "Insurance?";
			this.lblInsurance.Visible = false;
			// 
			// btnDoubleDown
			// 
			this.btnDoubleDown.AutoSize = true;
			this.btnDoubleDown.Location = new System.Drawing.Point(24, 222);
			this.btnDoubleDown.Margin = new System.Windows.Forms.Padding(4);
			this.btnDoubleDown.Name = "btnDoubleDown";
			this.btnDoubleDown.Size = new System.Drawing.Size(141, 28);
			this.btnDoubleDown.TabIndex = 27;
			this.btnDoubleDown.Text = "Double Down";
			this.btnDoubleDown.UseVisualStyleBackColor = true;
			this.btnDoubleDown.Click += new System.EventHandler(this.btnDoubleDown_Click);
			// 
			// picPlayerCard7
			// 
			this.picPlayerCard7.BackColor = System.Drawing.Color.Transparent;
			this.picPlayerCard7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picPlayerCard7.Location = new System.Drawing.Point(920, 292);
			this.picPlayerCard7.Margin = new System.Windows.Forms.Padding(4);
			this.picPlayerCard7.Name = "picPlayerCard7";
			this.picPlayerCard7.Size = new System.Drawing.Size(141, 177);
			this.picPlayerCard7.TabIndex = 31;
			this.picPlayerCard7.TabStop = false;
			// 
			// picPlayerCard6
			// 
			this.picPlayerCard6.BackColor = System.Drawing.Color.Transparent;
			this.picPlayerCard6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picPlayerCard6.Location = new System.Drawing.Point(771, 292);
			this.picPlayerCard6.Margin = new System.Windows.Forms.Padding(4);
			this.picPlayerCard6.Name = "picPlayerCard6";
			this.picPlayerCard6.Size = new System.Drawing.Size(141, 177);
			this.picPlayerCard6.TabIndex = 30;
			this.picPlayerCard6.TabStop = false;
			// 
			// picDealerCard7
			// 
			this.picDealerCard7.BackColor = System.Drawing.Color.Transparent;
			this.picDealerCard7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picDealerCard7.Location = new System.Drawing.Point(805, 186);
			this.picDealerCard7.Margin = new System.Windows.Forms.Padding(4);
			this.picDealerCard7.Name = "picDealerCard7";
			this.picDealerCard7.Size = new System.Drawing.Size(95, 126);
			this.picDealerCard7.TabIndex = 29;
			this.picDealerCard7.TabStop = false;
			// 
			// picDealerCard6
			// 
			this.picDealerCard6.BackColor = System.Drawing.Color.Transparent;
			this.picDealerCard6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picDealerCard6.Location = new System.Drawing.Point(783, 159);
			this.picDealerCard6.Margin = new System.Windows.Forms.Padding(4);
			this.picDealerCard6.Name = "picDealerCard6";
			this.picDealerCard6.Size = new System.Drawing.Size(95, 126);
			this.picDealerCard6.TabIndex = 28;
			this.picDealerCard6.TabStop = false;
			// 
			// picDealerCard5
			// 
			this.picDealerCard5.BackColor = System.Drawing.Color.Transparent;
			this.picDealerCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picDealerCard5.Location = new System.Drawing.Point(751, 130);
			this.picDealerCard5.Margin = new System.Windows.Forms.Padding(4);
			this.picDealerCard5.Name = "picDealerCard5";
			this.picDealerCard5.Size = new System.Drawing.Size(95, 126);
			this.picDealerCard5.TabIndex = 20;
			this.picDealerCard5.TabStop = false;
			// 
			// picDealerCard4
			// 
			this.picDealerCard4.BackColor = System.Drawing.Color.Transparent;
			this.picDealerCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picDealerCard4.Location = new System.Drawing.Point(717, 100);
			this.picDealerCard4.Margin = new System.Windows.Forms.Padding(4);
			this.picDealerCard4.Name = "picDealerCard4";
			this.picDealerCard4.Size = new System.Drawing.Size(95, 126);
			this.picDealerCard4.TabIndex = 18;
			this.picDealerCard4.TabStop = false;
			// 
			// picDealerCard3
			// 
			this.picDealerCard3.BackColor = System.Drawing.Color.Transparent;
			this.picDealerCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picDealerCard3.Location = new System.Drawing.Point(680, 76);
			this.picDealerCard3.Margin = new System.Windows.Forms.Padding(4);
			this.picDealerCard3.Name = "picDealerCard3";
			this.picDealerCard3.Size = new System.Drawing.Size(95, 126);
			this.picDealerCard3.TabIndex = 17;
			this.picDealerCard3.TabStop = false;
			// 
			// picDealerCard2
			// 
			this.picDealerCard2.BackColor = System.Drawing.Color.Transparent;
			this.picDealerCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picDealerCard2.Location = new System.Drawing.Point(648, 50);
			this.picDealerCard2.Margin = new System.Windows.Forms.Padding(4);
			this.picDealerCard2.Name = "picDealerCard2";
			this.picDealerCard2.Size = new System.Drawing.Size(95, 126);
			this.picDealerCard2.TabIndex = 16;
			this.picDealerCard2.TabStop = false;
			// 
			// picDealerCard1
			// 
			this.picDealerCard1.BackColor = System.Drawing.Color.Transparent;
			this.picDealerCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picDealerCard1.Location = new System.Drawing.Point(613, 26);
			this.picDealerCard1.Margin = new System.Windows.Forms.Padding(4);
			this.picDealerCard1.Name = "picDealerCard1";
			this.picDealerCard1.Size = new System.Drawing.Size(95, 126);
			this.picDealerCard1.TabIndex = 15;
			this.picDealerCard1.TabStop = false;
			// 
			// picPlayerCard5
			// 
			this.picPlayerCard5.BackColor = System.Drawing.Color.Transparent;
			this.picPlayerCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picPlayerCard5.Location = new System.Drawing.Point(621, 292);
			this.picPlayerCard5.Margin = new System.Windows.Forms.Padding(4);
			this.picPlayerCard5.Name = "picPlayerCard5";
			this.picPlayerCard5.Size = new System.Drawing.Size(141, 177);
			this.picPlayerCard5.TabIndex = 4;
			this.picPlayerCard5.TabStop = false;
			// 
			// picPlayerCard4
			// 
			this.picPlayerCard4.BackColor = System.Drawing.Color.Transparent;
			this.picPlayerCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picPlayerCard4.Location = new System.Drawing.Point(472, 292);
			this.picPlayerCard4.Margin = new System.Windows.Forms.Padding(4);
			this.picPlayerCard4.Name = "picPlayerCard4";
			this.picPlayerCard4.Size = new System.Drawing.Size(141, 177);
			this.picPlayerCard4.TabIndex = 3;
			this.picPlayerCard4.TabStop = false;
			// 
			// picPlayerCard3
			// 
			this.picPlayerCard3.BackColor = System.Drawing.Color.Transparent;
			this.picPlayerCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picPlayerCard3.Location = new System.Drawing.Point(323, 292);
			this.picPlayerCard3.Margin = new System.Windows.Forms.Padding(4);
			this.picPlayerCard3.Name = "picPlayerCard3";
			this.picPlayerCard3.Size = new System.Drawing.Size(141, 177);
			this.picPlayerCard3.TabIndex = 2;
			this.picPlayerCard3.TabStop = false;
			// 
			// picPlayerCard2
			// 
			this.picPlayerCard2.BackColor = System.Drawing.Color.Transparent;
			this.picPlayerCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picPlayerCard2.Location = new System.Drawing.Point(173, 292);
			this.picPlayerCard2.Margin = new System.Windows.Forms.Padding(4);
			this.picPlayerCard2.Name = "picPlayerCard2";
			this.picPlayerCard2.Size = new System.Drawing.Size(141, 177);
			this.picPlayerCard2.TabIndex = 1;
			this.picPlayerCard2.TabStop = false;
			// 
			// picPlayerCard1
			// 
			this.picPlayerCard1.BackColor = System.Drawing.Color.Transparent;
			this.picPlayerCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.picPlayerCard1.Location = new System.Drawing.Point(24, 292);
			this.picPlayerCard1.Margin = new System.Windows.Forms.Padding(4);
			this.picPlayerCard1.Name = "picPlayerCard1";
			this.picPlayerCard1.Size = new System.Drawing.Size(141, 177);
			this.picPlayerCard1.TabIndex = 0;
			this.picPlayerCard1.TabStop = false;
			// 
			// FrmNewGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Green;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.picPlayerCard7);
			this.Controls.Add(this.picPlayerCard6);
			this.Controls.Add(this.picDealerCard7);
			this.Controls.Add(this.picDealerCard6);
			this.Controls.Add(this.btnDoubleDown);
			this.Controls.Add(this.lblInsurance);
			this.Controls.Add(this.btnSkipInsurance);
			this.Controls.Add(this.btnBuyInsurance);
			this.Controls.Add(this.btnSurrender);
			this.Controls.Add(this.btnBlackJack);
			this.Controls.Add(this.lblWinstreak);
			this.Controls.Add(this.picDealerCard5);
			this.Controls.Add(this.lblDealerScore);
			this.Controls.Add(this.picDealerCard4);
			this.Controls.Add(this.picDealerCard3);
			this.Controls.Add(this.picDealerCard2);
			this.Controls.Add(this.picDealerCard1);
			this.Controls.Add(this.btnMakeBet);
			this.Controls.Add(this.txtbxBetAmount);
			this.Controls.Add(this.lblBetPool);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblMoney);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblHandValue);
			this.Controls.Add(this.llblHotline);
			this.Controls.Add(this.lblPlayerScore);
			this.Controls.Add(this.btnStand);
			this.Controls.Add(this.btnHit);
			this.Controls.Add(this.picPlayerCard5);
			this.Controls.Add(this.picPlayerCard4);
			this.Controls.Add(this.picPlayerCard3);
			this.Controls.Add(this.picPlayerCard2);
			this.Controls.Add(this.picPlayerCard1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "FrmNewGame";
			this.Text = "FrmNewGame";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmNewGame_FormClosed);
			this.Load += new System.EventHandler(this.FrmNewGame_Load);
			((System.ComponentModel.ISupportInitialize)(this.picPlayerCard7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picPlayerCard6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picDealerCard7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picDealerCard6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picDealerCard5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picDealerCard4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picDealerCard3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picDealerCard2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picDealerCard1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picPlayerCard5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picPlayerCard4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picPlayerCard3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picPlayerCard2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picPlayerCard1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox picPlayerCard1;
    private System.Windows.Forms.PictureBox picPlayerCard2;
    private System.Windows.Forms.PictureBox picPlayerCard3;
    private System.Windows.Forms.PictureBox picPlayerCard4;
    private System.Windows.Forms.PictureBox picPlayerCard5;
    private System.Windows.Forms.Button btnHit;
    private System.Windows.Forms.Button btnStand;
    private System.Windows.Forms.Label lblPlayerScore;
    private System.Windows.Forms.LinkLabel llblHotline;

        private System.Windows.Forms.Label lblHandValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBetPool;
        private System.Windows.Forms.TextBox txtbxBetAmount;
        private System.Windows.Forms.Button btnMakeBet;
        private System.Windows.Forms.PictureBox picDealerCard1;
        private System.Windows.Forms.PictureBox picDealerCard2;
        private System.Windows.Forms.PictureBox picDealerCard3;
        private System.Windows.Forms.PictureBox picDealerCard4;
        private System.Windows.Forms.Label lblDealerScore;
        private System.Windows.Forms.PictureBox picDealerCard5;
        private System.Windows.Forms.Label lblWinstreak;
        private System.Windows.Forms.Button btnBlackJack;
        private System.Windows.Forms.Button btnSurrender;
        private System.Windows.Forms.Button btnBuyInsurance;
        private System.Windows.Forms.Button btnSkipInsurance;
        private System.Windows.Forms.Label lblInsurance;
        private System.Windows.Forms.Button btnDoubleDown;
        private System.Windows.Forms.PictureBox picDealerCard6;
        private System.Windows.Forms.PictureBox picDealerCard7;
        private System.Windows.Forms.PictureBox picPlayerCard6;
        private System.Windows.Forms.PictureBox picPlayerCard7;
    }
}
