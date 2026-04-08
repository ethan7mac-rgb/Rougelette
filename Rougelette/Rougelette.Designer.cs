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
            lblCharName.Location = new Point(600, 9);
            lblCharName.Name = "lblCharName";
            lblCharName.Size = new Size(185, 37);
            lblCharName.TabIndex = 1;
            lblCharName.Text = "lblCharName";
            // 
            // btnSpin
            // 
            btnSpin.Location = new Point(31, 456);
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
            lstItemDisplay.Location = new Point(600, 53);
            lstItemDisplay.Name = "lstItemDisplay";
            lstItemDisplay.Size = new Size(185, 454);
            lstItemDisplay.TabIndex = 5;
            lstItemDisplay.SelectedIndexChanged += lstItemDisplay_SelectedIndexChanged;
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
            btnMainMenu.Location = new Point(244, 456);
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
            lblRoundCount.Size = new Size(140, 30);
            lblRoundCount.TabIndex = 11;
            // 
            // lblCoins
            // 
            lblCoins.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCoins.ForeColor = SystemColors.ButtonHighlight;
            lblCoins.Location = new Point(102, 53);
            lblCoins.Name = "lblCoins";
            lblCoins.Size = new Size(159, 30);
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
            btnShop.Location = new Point(456, 456);
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
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(grpNumBet);
            groupBox1.Controls.Add(nudBet);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(31, 152);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(425, 196);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(cboColour);
            groupBox2.Location = new Point(213, 89);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(201, 92);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.Size = new Size(173, 30);
            label4.TabIndex = 19;
            label4.Text = "Bet On A Colour";
            // 
            // cboColour
            // 
            cboColour.DropDownStyle = ComboBoxStyle.DropDownList;
            cboColour.FormattingEnabled = true;
            cboColour.Items.AddRange(new object[] { "None" });
            cboColour.Location = new Point(6, 52);
            cboColour.MaxDropDownItems = 100;
            cboColour.Name = "cboColour";
            cboColour.Size = new Size(188, 23);
            cboColour.TabIndex = 0;
            // 
            // grpNumBet
            // 
            grpNumBet.Controls.Add(label3);
            grpNumBet.Controls.Add(cboNum);
            grpNumBet.Location = new Point(6, 89);
            grpNumBet.Name = "grpNumBet";
            grpNumBet.Size = new Size(201, 92);
            grpNumBet.TabIndex = 20;
            grpNumBet.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(188, 30);
            label3.TabIndex = 19;
            label3.Text = "Bet On A Number";
            // 
            // cboNum
            // 
            cboNum.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNum.FormattingEnabled = true;
            cboNum.Items.AddRange(new object[] { "None" });
            cboNum.Location = new Point(6, 52);
            cboNum.MaxDropDownItems = 100;
            cboNum.Name = "cboNum";
            cboNum.Size = new Size(188, 23);
            cboNum.TabIndex = 0;
            // 
            // nudBet
            // 
            nudBet.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudBet.Location = new Point(6, 56);
            nudBet.Name = "nudBet";
            nudBet.Size = new Size(156, 27);
            nudBet.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(156, 30);
            label1.TabIndex = 18;
            label1.Text = "Make Your Bet";
            // 
            // lblSpinResColour
            // 
            lblSpinResColour.BackColor = SystemColors.ActiveCaptionText;
            lblSpinResColour.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSpinResColour.ForeColor = SystemColors.ButtonHighlight;
            lblSpinResColour.Location = new Point(230, 96);
            lblSpinResColour.Name = "lblSpinResColour";
            lblSpinResColour.Size = new Size(92, 37);
            lblSpinResColour.TabIndex = 18;
            // 
            // lblFee
            // 
            lblFee.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFee.ForeColor = SystemColors.ButtonHighlight;
            lblFee.Location = new Point(510, 152);
            lblFee.Name = "lblFee";
            lblFee.Size = new Size(73, 30);
            lblFee.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(462, 152);
            label6.Name = "label6";
            label6.Size = new Size(52, 30);
            label6.TabIndex = 19;
            label6.Text = "Fee:";
            // 
            // lblHS
            // 
            lblHS.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHS.ForeColor = SystemColors.ButtonHighlight;
            lblHS.Location = new Point(508, 9);
            lblHS.Name = "lblHS";
            lblHS.Size = new Size(73, 30);
            lblHS.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(393, 9);
            label7.Name = "label7";
            label7.Size = new Size(121, 30);
            label7.TabIndex = 21;
            label7.Text = "HighScore:";
            // 
            // btnSaveScore
            // 
            btnSaveScore.Location = new Point(456, 47);
            btnSaveScore.Name = "btnSaveScore";
            btnSaveScore.Size = new Size(125, 51);
            btnSaveScore.TabIndex = 23;
            btnSaveScore.Text = "Save Score";
            btnSaveScore.UseVisualStyleBackColor = true;
            btnSaveScore.Click += btnSaveScore_Click;
            // 
            // frmRougelette
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(797, 527);
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
