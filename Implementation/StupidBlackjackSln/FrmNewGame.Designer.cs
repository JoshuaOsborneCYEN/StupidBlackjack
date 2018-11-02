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
            this.picPlayerCard1 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard2 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard3 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard4 = new System.Windows.Forms.PictureBox();
            this.picPlayerCard5 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard5)).BeginInit();
            this.SuspendLayout();
            // 
            // picPlayerCard1
            // 
            this.picPlayerCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayerCard1.Location = new System.Drawing.Point(112, 242);
            this.picPlayerCard1.Name = "picPlayerCard1";
            this.picPlayerCard1.Size = new System.Drawing.Size(106, 144);
            this.picPlayerCard1.TabIndex = 0;
            this.picPlayerCard1.TabStop = false;
            // 
            // picPlayerCard2
            // 
            this.picPlayerCard2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayerCard2.Location = new System.Drawing.Point(254, 242);
            this.picPlayerCard2.Name = "picPlayerCard2";
            this.picPlayerCard2.Size = new System.Drawing.Size(106, 144);
            this.picPlayerCard2.TabIndex = 1;
            this.picPlayerCard2.TabStop = false;
            // 
            // picPlayerCard3
            // 
            this.picPlayerCard3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayerCard3.Location = new System.Drawing.Point(396, 242);
            this.picPlayerCard3.Name = "picPlayerCard3";
            this.picPlayerCard3.Size = new System.Drawing.Size(106, 144);
            this.picPlayerCard3.TabIndex = 2;
            this.picPlayerCard3.TabStop = false;
            // 
            // picPlayerCard4
            // 
            this.picPlayerCard4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayerCard4.Location = new System.Drawing.Point(538, 242);
            this.picPlayerCard4.Name = "picPlayerCard4";
            this.picPlayerCard4.Size = new System.Drawing.Size(106, 144);
            this.picPlayerCard4.TabIndex = 3;
            this.picPlayerCard4.TabStop = false;
            // 
            // picPlayerCard5
            // 
            this.picPlayerCard5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayerCard5.Location = new System.Drawing.Point(680, 242);
            this.picPlayerCard5.Name = "picPlayerCard5";
            this.picPlayerCard5.Size = new System.Drawing.Size(106, 144);
            this.picPlayerCard5.TabIndex = 4;
            this.picPlayerCard5.TabStop = false;
            // 
            // btnHit
            // 
            this.btnHit.AutoSize = true;
            this.btnHit.Location = new System.Drawing.Point(112, 185);
            this.btnHit.Name = "btnHit";
            this.btnHit.Size = new System.Drawing.Size(46, 23);
            this.btnHit.TabIndex = 5;
            this.btnHit.Text = "Hit";
            this.btnHit.UseVisualStyleBackColor = true;
            this.btnHit.Click += new System.EventHandler(this.btnHit_Click);
            // 
            // btnStand
            // 
            this.btnStand.AutoSize = true;
            this.btnStand.Location = new System.Drawing.Point(164, 185);
            this.btnStand.Name = "btnStand";
            this.btnStand.Size = new System.Drawing.Size(53, 23);
            this.btnStand.TabIndex = 6;
            this.btnStand.Text = "Stand";
            this.btnStand.UseVisualStyleBackColor = true;
            // 
            // lblHandValue
            // 
            this.lblHandValue.AutoSize = true;
            this.lblHandValue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblHandValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHandValue.Location = new System.Drawing.Point(6, 62);
            this.lblHandValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHandValue.Name = "lblHandValue";
            this.lblHandValue.Size = new System.Drawing.Size(198, 31);
            this.lblHandValue.TabIndex = 9;
            this.lblHandValue.Text = "Hand Value: 0";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.Location = new System.Drawing.Point(435, 7);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(106, 37);
            this.lblPlayerScore.TabIndex = 7;
            this.lblPlayerScore.Text = "label1";
            // 
            // llblHotline
            // 
            this.llblHotline.AutoSize = true;
            this.llblHotline.BackColor = System.Drawing.Color.Transparent;
            this.llblHotline.LinkColor = System.Drawing.Color.Red;
            this.llblHotline.Location = new System.Drawing.Point(484, 429);
            this.llblHotline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llblHotline.Name = "llblHotline";
            this.llblHotline.Size = new System.Drawing.Size(297, 13);
            this.llblHotline.TabIndex = 8;
            this.llblHotline.TabStop = true;
            this.llblHotline.Text = "Gambling problem? Click here or call 1-800-522-4700 for help.";
            this.llblHotline.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblHotline_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(20, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Current Money:";
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMoney.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblMoney.Location = new System.Drawing.Point(118, 7);
            this.lblMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(46, 17);
            this.lblMoney.TabIndex = 10;
            this.lblMoney.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(9, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Current Bet Pool:";
            // 
            // lblBetPool
            // 
            this.lblBetPool.AutoSize = true;
            this.lblBetPool.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBetPool.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBetPool.Location = new System.Drawing.Point(118, 31);
            this.lblBetPool.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBetPool.Name = "lblBetPool";
            this.lblBetPool.Size = new System.Drawing.Size(71, 17);
            this.lblBetPool.TabIndex = 12;
            this.lblBetPool.Text = "lblBetPool";
            // 
            // txtbxBetAmount
            // 
            this.txtbxBetAmount.Location = new System.Drawing.Point(434, 109);
            this.txtbxBetAmount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbxBetAmount.Name = "txtbxBetAmount";
            this.txtbxBetAmount.Size = new System.Drawing.Size(76, 20);
            this.txtbxBetAmount.TabIndex = 13;
            // 
            // btnMakeBet
            // 
            this.btnMakeBet.Location = new System.Drawing.Point(458, 132);
            this.btnMakeBet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMakeBet.Name = "btnMakeBet";
            this.btnMakeBet.Size = new System.Drawing.Size(37, 19);
            this.btnMakeBet.TabIndex = 14;
            this.btnMakeBet.Text = "Bet";
            this.btnMakeBet.UseVisualStyleBackColor = true;
            this.btnMakeBet.Click += new System.EventHandler(this.btnMakeBet_Click);
            // 
            // FrmNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "FrmNewGame";
            this.Text = "FrmNewGame";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmNewGame_FormClosed);
            this.Load += new System.EventHandler(this.FrmNewGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayerCard5)).EndInit();
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

    }
}
