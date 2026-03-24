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
            label = new Label();
            btnReset = new Button();
            btnMainMenu = new Button();
            lblRound = new Label();
            lblRoundCount = new Label();
            ((System.ComponentModel.ISupportInitialize)picChar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picWheel).BeginInit();
            SuspendLayout();
            // 
            // picChar
            // 
            picChar.Image = (Image)resources.GetObject("picChar.Image");
            picChar.Location = new Point(686, 16);
            picChar.Margin = new Padding(3, 4, 3, 4);
            picChar.Name = "picChar";
            picChar.Size = new Size(211, 223);
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
            lblCharName.Location = new Point(686, 261);
            lblCharName.Name = "lblCharName";
            lblCharName.Size = new Size(228, 46);
            lblCharName.TabIndex = 1;
            lblCharName.Text = "lblCharName";
            // 
            // picWheel
            // 
            picWheel.Image = (Image)resources.GetObject("picWheel.Image");
            picWheel.Location = new Point(35, 142);
            picWheel.Margin = new Padding(3, 4, 3, 4);
            picWheel.Name = "picWheel";
            picWheel.Size = new Size(585, 684);
            picWheel.SizeMode = PictureBoxSizeMode.StretchImage;
            picWheel.TabIndex = 3;
            picWheel.TabStop = false;
            // 
            // btnSpin
            // 
            btnSpin.Location = new Point(35, 848);
            btnSpin.Margin = new Padding(3, 4, 3, 4);
            btnSpin.Name = "btnSpin";
            btnSpin.Size = new Size(143, 68);
            btnSpin.TabIndex = 4;
            btnSpin.Text = "Spin Da Weel";
            btnSpin.UseVisualStyleBackColor = true;
            btnSpin.Click += btnSpin_Click;
            // 
            // lstItemDisplay
            // 
            lstItemDisplay.FormattingEnabled = true;
            lstItemDisplay.Items.AddRange(new object[] { "Items:" });
            lstItemDisplay.Location = new Point(686, 316);
            lstItemDisplay.Margin = new Padding(3, 4, 3, 4);
            lstItemDisplay.Name = "lstItemDisplay";
            lstItemDisplay.Size = new Size(211, 604);
            lstItemDisplay.TabIndex = 5;
            // 
            // lblMoney
            // 
            lblMoney.AutoSize = true;
            lblMoney.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMoney.ForeColor = SystemColors.ButtonHighlight;
            lblMoney.Location = new Point(35, 83);
            lblMoney.Name = "lblMoney";
            lblMoney.Size = new Size(245, 37);
            lblMoney.TabIndex = 6;
            lblMoney.Text = "Coins: 000000000";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.ForeColor = SystemColors.ButtonHighlight;
            label.Location = new Point(35, 16);
            label.Name = "label";
            label.Size = new Size(114, 37);
            label.TabIndex = 7;
            label.Text = "Round: ";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(477, 848);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(143, 68);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset Game";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Location = new Point(251, 848);
            btnMainMenu.Margin = new Padding(3, 4, 3, 4);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(143, 68);
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
            lblRound.Location = new Point(131, 16);
            lblRound.Name = "lblRound";
            lblRound.Size = new Size(0, 37);
            lblRound.TabIndex = 10;
            // 
            // lblRoundCount
            // 
            lblRoundCount.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoundCount.ForeColor = SystemColors.ButtonHighlight;
            lblRoundCount.Location = new Point(138, 16);
            lblRoundCount.Name = "lblRoundCount";
            lblRoundCount.Size = new Size(114, 37);
            lblRoundCount.TabIndex = 11;
            // 
            // frmRougelette
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(911, 934);
            Controls.Add(lblRoundCount);
            Controls.Add(lblRound);
            Controls.Add(btnMainMenu);
            Controls.Add(btnReset);
            Controls.Add(label);
            Controls.Add(lblMoney);
            Controls.Add(lstItemDisplay);
            Controls.Add(btnSpin);
            Controls.Add(picWheel);
            Controls.Add(lblCharName);
            Controls.Add(picChar);
            Margin = new Padding(3, 4, 3, 4);
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
        private Label label;
        private Button btnReset;
        private Button btnMainMenu;
        private Label lblRound;
        private Label lblRoundCount;
    }
}
