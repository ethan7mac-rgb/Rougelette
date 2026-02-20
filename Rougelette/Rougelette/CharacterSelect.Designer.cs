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
            ((System.ComponentModel.ISupportInitialize)picChar1).BeginInit();
            SuspendLayout();
            // 
            // picChar1
            // 
            picChar1.Image = (Image)resources.GetObject("picChar1.Image");
            picChar1.Location = new Point(12, 12);
            picChar1.Name = "picChar1";
            picChar1.Size = new Size(135, 77);
            picChar1.SizeMode = PictureBoxSizeMode.StretchImage;
            picChar1.TabIndex = 3;
            picChar1.TabStop = false;
            // 
            // lblCharDesc1
            // 
            lblCharDesc1.ForeColor = SystemColors.ButtonHighlight;
            lblCharDesc1.Location = new Point(12, 92);
            lblCharDesc1.Name = "lblCharDesc1";
            lblCharDesc1.Size = new Size(135, 50);
            lblCharDesc1.TabIndex = 1;
            lblCharDesc1.Text = "Its Lunch Time";
            lblCharDesc1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCowBoySelect
            // 
            btnCowBoySelect.Location = new Point(12, 145);
            btnCowBoySelect.Name = "btnCowBoySelect";
            btnCowBoySelect.Size = new Size(135, 26);
            btnCowBoySelect.TabIndex = 2;
            btnCowBoySelect.Text = "Select the Cowboy";
            btnCowBoySelect.UseVisualStyleBackColor = true;
            btnCowBoySelect.Click += btnCowBoySelect_Click;
            // 
            // frmCharacterSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btnCowBoySelect);
            Controls.Add(lblCharDesc1);
            Controls.Add(picChar1);
            Name = "frmCharacterSelect";
            Text = "CharacterSelect";
            ((System.ComponentModel.ISupportInitialize)picChar1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picChar1;
        private Label lblCharDesc1;
        private Button btnCowBoySelect;
    }
}