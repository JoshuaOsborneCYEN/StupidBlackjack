namespace StupidBlackjackSln {
  partial class frmTitle {
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnRulebook = new System.Windows.Forms.Button();
            this.btnExitGame = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.llblHotline = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblTitle.Location = new System.Drawing.Point(292, 70);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(635, 91);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Stupid Blackjack";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(16, 418);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(263, 74);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnRulebook
            // 
            this.btnRulebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRulebook.Location = new System.Drawing.Point(328, 418);
            this.btnRulebook.Margin = new System.Windows.Forms.Padding(4);
            this.btnRulebook.Name = "btnRulebook";
            this.btnRulebook.Size = new System.Drawing.Size(303, 74);
            this.btnRulebook.TabIndex = 2;
            this.btnRulebook.Text = "View Rulebook";
            this.btnRulebook.UseVisualStyleBackColor = true;
            this.btnRulebook.Click += new System.EventHandler(this.btnRulebook_Click);
            // 
            // btnExitGame
            // 
            this.btnExitGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitGame.Location = new System.Drawing.Point(992, 418);
            this.btnExitGame.Margin = new System.Windows.Forms.Padding(4);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(263, 74);
            this.btnExitGame.TabIndex = 3;
            this.btnExitGame.Text = "Exit Game";
            this.btnExitGame.UseVisualStyleBackColor = true;
            this.btnExitGame.Click += new System.EventHandler(this.btnExitGame_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.Location = new System.Drawing.Point(680, 418);
            this.btnOptions.Margin = new System.Windows.Forms.Padding(4);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(263, 74);
            this.btnOptions.TabIndex = 4;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            // 
            // llblHotline
            // 
            this.llblHotline.AutoSize = true;
            this.llblHotline.BackColor = System.Drawing.Color.Transparent;
            this.llblHotline.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.llblHotline.Location = new System.Drawing.Point(843, 516);
            this.llblHotline.Name = "llblHotline";
            this.llblHotline.Size = new System.Drawing.Size(402, 17);
            this.llblHotline.TabIndex = 5;
            this.llblHotline.TabStop = true;
            this.llblHotline.Text = "Gambling problem? Click here or call 1-800-522-4700 for help.";
            this.llblHotline.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblHotline_LinkClicked);
            // 
            // frmTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::StupidBlackjackSln.Properties.Resources.table_texture;
            this.ClientSize = new System.Drawing.Size(1271, 554);
            this.Controls.Add(this.llblHotline);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnExitGame);
            this.Controls.Add(this.btnRulebook);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTitle";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Button btnNewGame;
    private System.Windows.Forms.Button btnRulebook;
    private System.Windows.Forms.Button btnExitGame;
    private System.Windows.Forms.Button btnOptions;
    private System.Windows.Forms.LinkLabel llblHotline;
    }
}

