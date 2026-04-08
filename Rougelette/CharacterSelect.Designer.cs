namespace Rougelette
{
    partial class frmCharacterSelect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCharacterSelect));
            picChar1 = new PictureBox();
            lblCharDesc1 = new Label();
            btnCowBoySelect = new Button();
            lblCharDesc2 = new Label();
            btnPirateSelect = new Button();
            picChar2 = new PictureBox();
            picChar3 = new PictureBox();
            lblCharDesc3 = new Label();
            btnMonkeySelect = new Button();
            ((System.ComponentModel.ISupportInitialize)picChar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picChar3).BeginInit();
            SuspendLayout();
            // 
            // picChar1
            // 
            picChar1.Image = Properties.Resources.tempCowboy;
            picChar1.Location = new Point(14, 16);
            picChar1.Margin = new Padding(3, 4, 3, 4);
            picChar1.Name = "picChar1";
            picChar1.Size = new Size(154, 103);
            picChar1.SizeMode = PictureBoxSizeMode.StretchImage;
            picChar1.TabIndex = 3;
            picChar1.TabStop = false;
            // 
            // lblCharDesc1
            // 
            lblCharDesc1.ForeColor = SystemColors.ButtonHighlight;
            lblCharDesc1.Location = new Point(14, 123);
            lblCharDesc1.Name = "lblCharDesc1";
            lblCharDesc1.Size = new Size(154, 67);
            lblCharDesc1.TabIndex = 1;
            lblCharDesc1.Text = "Its Lunch Time";
            lblCharDesc1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCowBoySelect
            // 
            btnCowBoySelect.Location = new Point(14, 193);
            btnCowBoySelect.Margin = new Padding(3, 4, 3, 4);
            btnCowBoySelect.Name = "btnCowBoySelect";
            btnCowBoySelect.Size = new Size(154, 35);
            btnCowBoySelect.TabIndex = 2;
            btnCowBoySelect.Text = "Select the Cowboy";
            btnCowBoySelect.UseVisualStyleBackColor = true;
            btnCowBoySelect.Click += btnCowBoySelect_Click;
            // 
            // lblCharDesc2
            // 
            lblCharDesc2.ForeColor = SystemColors.ButtonHighlight;
            lblCharDesc2.Location = new Point(209, 123);
            lblCharDesc2.Name = "lblCharDesc2";
            lblCharDesc2.Size = new Size(154, 67);
            lblCharDesc2.TabIndex = 4;
            lblCharDesc2.Text = "Claim the Bounty";
            lblCharDesc2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnPirateSelect
            // 
            btnPirateSelect.Location = new Point(209, 194);
            btnPirateSelect.Margin = new Padding(3, 4, 3, 4);
            btnPirateSelect.Name = "btnPirateSelect";
            btnPirateSelect.Size = new Size(154, 35);
            btnPirateSelect.TabIndex = 5;
            btnPirateSelect.Text = "Select the Pirate";
            btnPirateSelect.UseVisualStyleBackColor = true;
            btnPirateSelect.Click += btnPirateSelect_Click;
            // 
            // picChar2
            // 
            picChar2.Image = (Image)resources.GetObject("picChar2.Image");
            picChar2.Location = new Point(209, 16);
            picChar2.Margin = new Padding(3, 4, 3, 4);
            picChar2.Name = "picChar2";
            picChar2.Size = new Size(154, 103);
            picChar2.SizeMode = PictureBoxSizeMode.StretchImage;
            picChar2.TabIndex = 6;
            picChar2.TabStop = false;
            // 
            // picChar3
            // 
            picChar3.Image = (Image)resources.GetObject("picChar3.Image");
            picChar3.Location = new Point(398, 16);
            picChar3.Margin = new Padding(3, 4, 3, 4);
            picChar3.Name = "picChar3";
            picChar3.Size = new Size(154, 103);
            picChar3.SizeMode = PictureBoxSizeMode.StretchImage;
            picChar3.TabIndex = 7;
            picChar3.TabStop = false;
            // 
            // lblCharDesc3
            // 
            lblCharDesc3.ForeColor = SystemColors.ButtonHighlight;
            lblCharDesc3.Location = new Point(398, 123);
            lblCharDesc3.Name = "lblCharDesc3";
            lblCharDesc3.Size = new Size(154, 67);
            lblCharDesc3.TabIndex = 8;
            lblCharDesc3.Text = "Monkey Time";
            lblCharDesc3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMonkeySelect
            // 
            btnMonkeySelect.Location = new Point(398, 193);
            btnMonkeySelect.Margin = new Padding(3, 4, 3, 4);
            btnMonkeySelect.Name = "btnMonkeySelect";
            btnMonkeySelect.Size = new Size(154, 35);
            btnMonkeySelect.TabIndex = 9;
            btnMonkeySelect.Text = "Select the Monkey";
            btnMonkeySelect.UseVisualStyleBackColor = true;
            btnMonkeySelect.Click += btnMonkeySelect_Click;
            // 
            // frmCharacterSelect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(914, 600);
            Controls.Add(btnMonkeySelect);
            Controls.Add(lblCharDesc3);
            Controls.Add(picChar3);
            Controls.Add(picChar2);
            Controls.Add(btnPirateSelect);
            Controls.Add(lblCharDesc2);
            Controls.Add(btnCowBoySelect);
            Controls.Add(lblCharDesc1);
            Controls.Add(picChar1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCharacterSelect";
            Text = "CharacterSelect";
            ((System.ComponentModel.ISupportInitialize)picChar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)picChar3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picChar1;
        private Label lblCharDesc1;
        private Button btnCowBoySelect;
        private Label lblCharDesc2;
        private Button btnPirateSelect;
        private PictureBox picChar2;
        private PictureBox picChar3;
        private Label lblCharDesc3;
        private Button btnMonkeySelect;
    }
}