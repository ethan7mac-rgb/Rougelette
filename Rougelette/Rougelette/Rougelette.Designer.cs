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
            lblMoney = new Label();
            lblRound = new Label();
            btnReset = new Button();
            btnMainMenu = new Button();
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
            // lblMoney
            // 
            lblMoney.AutoSize = true;
            lblMoney.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMoney.ForeColor = SystemColors.ButtonHighlight;
            lblMoney.Location = new Point(31, 62);
            lblMoney.Name = "lblMoney";
            lblMoney.Size = new Size(187, 30);
            lblMoney.TabIndex = 6;
            lblMoney.Text = "Coins: 000000000";
            // 
            // lblRound
            // 
            lblRound.AutoSize = true;
            lblRound.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRound.ForeColor = SystemColors.ButtonHighlight;
            lblRound.Location = new Point(31, 12);
            lblRound.Name = "lblRound";
            lblRound.Size = new Size(90, 30);
            lblRound.TabIndex = 7;
            lblRound.Text = "Round: ";
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
            // frmRougelette
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(797, 833);
            Controls.Add(btnMainMenu);
            Controls.Add(btnReset);
            Controls.Add(lblRound);
            Controls.Add(lblMoney);
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
        private Label lblMoney;
        private Label lblRound;
        private Button btnReset;
        private Button btnMainMenu;
    }
}
