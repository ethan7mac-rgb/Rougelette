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
            btnSpin = new Button();
            lstItemDisplay = new ListBox();
            label = new Label();
            btnMainMenu = new Button();
            lblRound = new Label();
            lblRoundCount = new Label();
            lblCoins = new Label();
            label2 = new Label();
            btnShop = new Button();
            labelSpin = new Label();
            lblSpinRes = new Label();
            ((System.ComponentModel.ISupportInitialize)picChar).BeginInit();
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
            // btnSpin
            // 
            btnSpin.Location = new Point(27, 637);
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
            lstItemDisplay.Size = new Size(185, 454);
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
            // btnMainMenu
            // 
            btnMainMenu.Location = new Point(215, 637);
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
            lblRoundCount.Location = new Point(121, 12);
            lblRoundCount.Name = "lblRoundCount";
            lblRoundCount.Size = new Size(100, 30);
            lblRoundCount.TabIndex = 11;
            // 
            // lblCoins
            // 
            lblCoins.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCoins.ForeColor = SystemColors.ButtonHighlight;
            lblCoins.Location = new Point(102, 53);
            lblCoins.Name = "lblCoins";
            lblCoins.Size = new Size(100, 30);
            lblCoins.TabIndex = 13;
            lblCoins.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(31, 53);
            label2.Name = "label2";
            label2.Size = new Size(79, 30);
            label2.TabIndex = 12;
            label2.Text = "Coins: ";
            // 
            // btnShop
            // 
            btnShop.Location = new Point(420, 637);
            btnShop.Name = "btnShop";
            btnShop.Size = new Size(125, 51);
            btnShop.TabIndex = 14;
            btnShop.Text = "Shop";
            btnShop.UseVisualStyleBackColor = true;
            btnShop.Click += btnShop_Click;
            // 
            // labelSpin
            // 
            labelSpin.BackColor = SystemColors.ActiveCaptionText;
            labelSpin.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSpin.ForeColor = SystemColors.ButtonHighlight;
            labelSpin.Location = new Point(31, 96);
            labelSpin.Name = "labelSpin";
            labelSpin.Size = new Size(171, 37);
            labelSpin.TabIndex = 15;
            labelSpin.Text = "Spin Result:";
            // 
            // lblSpinRes
            // 
            lblSpinRes.BackColor = SystemColors.ActiveCaptionText;
            lblSpinRes.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSpinRes.ForeColor = SystemColors.ButtonHighlight;
            lblSpinRes.Location = new Point(189, 96);
            lblSpinRes.Name = "lblSpinRes";
            lblSpinRes.Size = new Size(72, 37);
            lblSpinRes.TabIndex = 16;
            // 
            // frmRougelette
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(797, 700);
            Controls.Add(lblSpinRes);
            Controls.Add(labelSpin);
            Controls.Add(btnShop);
            Controls.Add(lblCoins);
            Controls.Add(label2);
            Controls.Add(lblRoundCount);
            Controls.Add(lblRound);
            Controls.Add(btnMainMenu);
            Controls.Add(label);
            Controls.Add(lstItemDisplay);
            Controls.Add(btnSpin);
            Controls.Add(lblCharName);
            Controls.Add(picChar);
            Name = "frmRougelette";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picChar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picChar;
        private Label lblCharName;
        private Button btnSpin;
        private ListBox lstItemDisplay;
        private Label label;
        private Button btnMainMenu;
        private Label lblRound;
        private Label lblRoundCount;
        private Label lblCoins;
        private Label label2;
        private Button btnShop;
        private Label labelSpin;
        private Label lblSpinRes;
    }
}
