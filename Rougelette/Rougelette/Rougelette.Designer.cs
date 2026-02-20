namespace Rougelette
{
    partial class frmRougelette
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRougelette));
            picChar = new PictureBox();
            lblCharName = new Label();
            picWheel = new PictureBox();
            btnSpin = new Button();
            lstItemDisplay = new ListBox();
            label = new Label();
            btnReset = new Button();
            btnMainMenu = new Button();
            lblRound = new Label();
            lblRoundCount = new Label();
            lblCoins = new Label();
            labelCoinRead = new Label();
            ((System.ComponentModel.ISupportInitialize)picChar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWheel).BeginInit();
            SuspendLayout();
            // 
            // picChar
            // 
            picChar.Image = (Image)resources.GetObject("picChar.Image");
            picChar.Location = new Point(600, 12);
            picChar.Name = "picChar";
            picChar.Size = new Size(185, 167);
            picChar.SizeMode = PictureBoxSizeMode.StretchImage;
            picChar.TabIndex = 0;
            picChar.TabStop = false;
            // 
            // lblCharName
            // 
            lblCharName.AutoSize = true;
            lblCharName.BackColor = SystemColors.ActiveCaptionText;
            lblCharName.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCharName.ForeColor = SystemColors.ButtonHighlight;
            lblCharName.Location = new Point(600, 196);
            lblCharName.Name = "lblCharName";
            lblCharName.Size = new Size(185, 37);
            lblCharName.TabIndex = 1;
            lblCharName.Text = "lblCharName";
            // 
            // picWheel
            // 
            picWheel.Image = (Image)resources.GetObject("picWheel.Image");
            picWheel.Location = new Point(31, 237);
            picWheel.Name = "picWheel";
            picWheel.Size = new Size(512, 513);
            picWheel.SizeMode = PictureBoxSizeMode.StretchImage;
            picWheel.TabIndex = 3;
            picWheel.TabStop = false;
            // 
            // btnSpin
            // 
            btnSpin.Location = new Point(31, 767);
            btnSpin.Name = "btnSpin";
            btnSpin.Size = new Size(125, 51);
            btnSpin.TabIndex = 4;
            btnSpin.Text = "Spin Da Weel";
            btnSpin.UseVisualStyleBackColor = true;
            btnSpin.Click += btnSpin_Click;
            // 
            // lstItemDisplay
            // 
            lstItemDisplay.FormattingEnabled = true;
            lstItemDisplay.ItemHeight = 15;
            lstItemDisplay.Items.AddRange(new object[] { "Items:" });
            lstItemDisplay.Location = new Point(600, 237);
            lstItemDisplay.Name = "lstItemDisplay";
            lstItemDisplay.Size = new Size(185, 559);
            lstItemDisplay.TabIndex = 5;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = SystemColors.ButtonHighlight;
            label.Location = new Point(31, 12);
            label.Name = "label";
            label.Size = new Size(90, 30);
            label.TabIndex = 7;
            label.Text = "Round: ";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(418, 767);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(125, 51);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset Game";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Location = new Point(225, 767);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(125, 51);
            btnMainMenu.TabIndex = 9;
            btnMainMenu.Text = "Main Menu";
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // lblRound
            // 
            lblRound.AutoSize = true;
            lblRound.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRound.ForeColor = SystemColors.ButtonHighlight;
            lblRound.Location = new Point(115, 12);
            lblRound.Name = "lblRound";
            lblRound.Size = new Size(0, 30);
            lblRound.TabIndex = 10;
            // 
            // lblRoundCount
            // 
            lblRoundCount.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoundCount.ForeColor = SystemColors.ButtonHighlight;
            lblRoundCount.Location = new Point(106, 12);
            lblRoundCount.Name = "lblRoundCount";
            lblRoundCount.Size = new Size(160, 30);
            lblRoundCount.TabIndex = 11;
            // 
            // lblCoins
            // 
            lblCoins.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCoins.ForeColor = SystemColors.ButtonHighlight;
            lblCoins.Location = new Point(101, 63);
            lblCoins.Name = "lblCoins";
            lblCoins.Size = new Size(165, 30);
            lblCoins.TabIndex = 13;
            // 
            // labelCoinRead
            // 
            labelCoinRead.AutoSize = true;
            labelCoinRead.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelCoinRead.ForeColor = SystemColors.ButtonHighlight;
            labelCoinRead.Location = new Point(31, 63);
            labelCoinRead.Name = "labelCoinRead";
            labelCoinRead.Size = new Size(85, 30);
            labelCoinRead.TabIndex = 12;
            labelCoinRead.Text = "Coins:  ";
            // 
            // frmRougelette
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(797, 833);
            Controls.Add(lblCoins);
            Controls.Add(labelCoinRead);
            Controls.Add(lblRoundCount);
            Controls.Add(lblRound);
            Controls.Add(btnMainMenu);
            Controls.Add(btnReset);
            Controls.Add(label);
            Controls.Add(lstItemDisplay);
            Controls.Add(btnSpin);
            Controls.Add(picWheel);
            Controls.Add(lblCharName);
            Controls.Add(picChar);
            Name = "frmRougelette";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picChar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picWheel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picChar;
        private Label lblCharName;
        private PictureBox picWheel;
        private Button btnSpin;
        private ListBox lstItemDisplay;
        private Label label;
        private Button btnReset;
        private Button btnMainMenu;
        private Label lblRound;
        private Label lblRoundCount;
        private Label lblCoins;
        private Label labelCoinRead;
    }
}
