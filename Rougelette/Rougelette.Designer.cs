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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            cboColour = new ComboBox();
            grpNumBet = new GroupBox();
            label3 = new Label();
            cboNum = new ComboBox();
            nudBet = new NumericUpDown();
            label1 = new Label();
            lblSpinResColour = new Label();
            lblFee = new Label();
            label6 = new Label();
            lblHS = new Label();
            label7 = new Label();
            btnSaveScore = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            grpNumBet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudBet).BeginInit();
            SuspendLayout();
            // 
            // lblCharName
            // 
            lblCharName.AutoSize = true;
            lblCharName.BackColor = SystemColors.ActiveCaptionText;
            lblCharName.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCharName.ForeColor = SystemColors.ButtonHighlight;
            lblCharName.Location = new Point(686, 12);
            lblCharName.Name = "lblCharName";
            lblCharName.Size = new Size(228, 46);
            lblCharName.TabIndex = 1;
            lblCharName.Text = "lblCharName";
            // 
            // btnSpin
            // 
            btnSpin.Location = new Point(35, 608);
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
            lstItemDisplay.Location = new Point(686, 71);
            lstItemDisplay.Margin = new Padding(3, 4, 3, 4);
            lstItemDisplay.Name = "lstItemDisplay";
            lstItemDisplay.Size = new Size(211, 604);
            lstItemDisplay.TabIndex = 5;
            lstItemDisplay.SelectedIndexChanged += lstItemDisplay_SelectedIndexChanged;
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
            // btnMainMenu
            // 
            btnMainMenu.Location = new Point(279, 608);
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
            lblRoundCount.Size = new Size(160, 37);
            lblRoundCount.TabIndex = 11;
            // 
            // lblCoins
            // 
            lblCoins.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCoins.ForeColor = SystemColors.ButtonHighlight;
            lblCoins.Location = new Point(131, 71);
            lblCoins.Name = "lblCoins";
            lblCoins.Size = new Size(182, 37);
            lblCoins.TabIndex = 13;
            lblCoins.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(35, 71);
            label2.Name = "label2";
            label2.Size = new Size(101, 37);
            label2.TabIndex = 12;
            label2.Text = "Coins: ";
            // 
            // btnShop
            // 
            btnShop.Location = new Point(521, 608);
            btnShop.Margin = new Padding(3, 4, 3, 4);
            btnShop.Name = "btnShop";
            btnShop.Size = new Size(143, 68);
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
            labelSpin.Location = new Point(35, 128);
            labelSpin.Name = "labelSpin";
            labelSpin.Size = new Size(195, 49);
            labelSpin.TabIndex = 15;
            labelSpin.Text = "Spin Result:";
            // 
            // lblSpinRes
            // 
            lblSpinRes.BackColor = SystemColors.ActiveCaptionText;
            lblSpinRes.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSpinRes.ForeColor = SystemColors.ButtonHighlight;
            lblSpinRes.Location = new Point(216, 128);
            lblSpinRes.Name = "lblSpinRes";
            lblSpinRes.Size = new Size(82, 49);
            lblSpinRes.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(grpNumBet);
            groupBox1.Controls.Add(nudBet);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(35, 203);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(486, 261);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cboColour);
            groupBox2.Location = new Point(243, 119);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(230, 123);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(7, 25);
            label4.Name = "label4";
            label4.Size = new Size(222, 37);
            label4.TabIndex = 19;
            label4.Text = "Bet On A Colour";
            // 
            // cboColour
            // 
            cboColour.DropDownStyle = ComboBoxStyle.DropDownList;
            cboColour.FormattingEnabled = true;
            cboColour.Items.AddRange(new object[] { "None" });
            cboColour.Location = new Point(7, 69);
            cboColour.Margin = new Padding(3, 4, 3, 4);
            cboColour.MaxDropDownItems = 100;
            cboColour.Name = "cboColour";
            cboColour.Size = new Size(214, 28);
            cboColour.TabIndex = 0;
            // 
            // grpNumBet
            // 
            grpNumBet.Controls.Add(label3);
            grpNumBet.Controls.Add(cboNum);
            grpNumBet.Location = new Point(7, 119);
            grpNumBet.Margin = new Padding(3, 4, 3, 4);
            grpNumBet.Name = "grpNumBet";
            grpNumBet.Padding = new Padding(3, 4, 3, 4);
            grpNumBet.Size = new Size(230, 123);
            grpNumBet.TabIndex = 20;
            grpNumBet.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(7, 25);
            label3.Name = "label3";
            label3.Size = new Size(241, 37);
            label3.TabIndex = 19;
            label3.Text = "Bet On A Number";
            // 
            // cboNum
            // 
            cboNum.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNum.FormattingEnabled = true;
            cboNum.Items.AddRange(new object[] { "None" });
            cboNum.Location = new Point(7, 69);
            cboNum.Margin = new Padding(3, 4, 3, 4);
            cboNum.MaxDropDownItems = 100;
            cboNum.Name = "cboNum";
            cboNum.Size = new Size(214, 28);
            cboNum.TabIndex = 0;
            // 
            // nudBet
            // 
            nudBet.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudBet.Location = new Point(7, 75);
            nudBet.Margin = new Padding(3, 4, 3, 4);
            nudBet.Name = "nudBet";
            nudBet.Size = new Size(178, 32);
            nudBet.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(7, 25);
            label1.Name = "label1";
            label1.Size = new Size(203, 37);
            label1.TabIndex = 18;
            label1.Text = "Make Your Bet";
            // 
            // lblSpinResColour
            // 
            lblSpinResColour.BackColor = SystemColors.ActiveCaptionText;
            lblSpinResColour.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSpinResColour.ForeColor = SystemColors.ButtonHighlight;
            lblSpinResColour.Location = new Point(263, 128);
            lblSpinResColour.Name = "lblSpinResColour";
            lblSpinResColour.Size = new Size(105, 49);
            lblSpinResColour.TabIndex = 18;
            // 
            // lblFee
            // 
            lblFee.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFee.ForeColor = SystemColors.ButtonHighlight;
            lblFee.Location = new Point(602, 203);
            lblFee.Name = "lblFee";
            lblFee.Size = new Size(64, 37);
            lblFee.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(539, 203);
            label6.Name = "label6";
            label6.Size = new Size(68, 37);
            label6.TabIndex = 19;
            label6.Text = "Fee:";
            // 
            // lblHS
            // 
            lblHS.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHS.ForeColor = SystemColors.ButtonHighlight;
            lblHS.Location = new Point(602, 16);
            lblHS.Name = "lblHS";
            lblHS.Size = new Size(62, 37);
            lblHS.TabIndex = 22;
            lblHS.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(450, 16);
            label7.Name = "label7";
            label7.Size = new Size(157, 37);
            label7.TabIndex = 21;
            label7.Text = "HighScore:";
            // 
            // btnSaveScore
            // 
            btnSaveScore.Location = new Point(521, 63);
            btnSaveScore.Margin = new Padding(3, 4, 3, 4);
            btnSaveScore.Name = "btnSaveScore";
            btnSaveScore.Size = new Size(143, 68);
            btnSaveScore.TabIndex = 23;
            btnSaveScore.Text = "Save Score";
            btnSaveScore.UseVisualStyleBackColor = true;
            btnSaveScore.Click += btnSaveScore_Click;
            // 
            // frmRougelette
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(911, 703);
            Controls.Add(btnSaveScore);
            Controls.Add(lblHS);
            Controls.Add(label7);
            Controls.Add(lblFee);
            Controls.Add(label6);
            Controls.Add(lblSpinResColour);
            Controls.Add(groupBox1);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmRougelette";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            grpNumBet.ResumeLayout(false);
            grpNumBet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudBet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private GroupBox groupBox1;
        private NumericUpDown nudBet;
        private Label label1;
        private GroupBox groupBox2;
        private Label label4;
        private ComboBox cboColour;
        private GroupBox grpNumBet;
        private Label label3;
        private ComboBox cboNum;
        private Label lblSpinResColour;
        private Label lblFee;
        private Label label6;
        private Label lblHS;
        private Label label7;
        private Button btnSaveScore;
    }
}
