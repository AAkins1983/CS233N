namespace BlackJack
{
    partial class BlackJackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlackJackForm));
            this.newHandButton = new System.Windows.Forms.Button();
            this.standButton = new System.Windows.Forms.Button();
            this.hitButton = new System.Windows.Forms.Button();
            this.pCard0 = new System.Windows.Forms.PictureBox();
            this.pCard1 = new System.Windows.Forms.PictureBox();
            this.pCard2 = new System.Windows.Forms.PictureBox();
            this.pCard3 = new System.Windows.Forms.PictureBox();
            this.pCard4 = new System.Windows.Forms.PictureBox();
            this.dCard0 = new System.Windows.Forms.PictureBox();
            this.dCard1 = new System.Windows.Forms.PictureBox();
            this.dCard2 = new System.Windows.Forms.PictureBox();
            this.dCard3 = new System.Windows.Forms.PictureBox();
            this.dCard4 = new System.Windows.Forms.PictureBox();
            this.pScoreLabel = new System.Windows.Forms.Label();
            this.dScoreLabel = new System.Windows.Forms.Label();
            this.pScoreTextBox = new System.Windows.Forms.TextBox();
            this.dScoreTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pCard0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCard4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dCard0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dCard4)).BeginInit();
            this.SuspendLayout();
            // 
            // newHandButton
            // 
            this.newHandButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newHandButton.Location = new System.Drawing.Point(567, 359);
            this.newHandButton.Name = "newHandButton";
            this.newHandButton.Size = new System.Drawing.Size(75, 58);
            this.newHandButton.TabIndex = 0;
            this.newHandButton.Text = "New Hand";
            this.newHandButton.UseVisualStyleBackColor = true;
            this.newHandButton.Click += new System.EventHandler(this.newHandButton_Click);
            // 
            // standButton
            // 
            this.standButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standButton.Location = new System.Drawing.Point(567, 180);
            this.standButton.Name = "standButton";
            this.standButton.Size = new System.Drawing.Size(75, 60);
            this.standButton.TabIndex = 1;
            this.standButton.Text = "Stand";
            this.standButton.UseVisualStyleBackColor = true;
            this.standButton.Click += new System.EventHandler(this.standButton_Click);
            // 
            // hitButton
            // 
            this.hitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitButton.Location = new System.Drawing.Point(567, 12);
            this.hitButton.Name = "hitButton";
            this.hitButton.Size = new System.Drawing.Size(75, 55);
            this.hitButton.TabIndex = 2;
            this.hitButton.Text = "Hit";
            this.hitButton.UseVisualStyleBackColor = true;
            this.hitButton.Click += new System.EventHandler(this.hitButton_Click);
            // 
            // pCard0
            // 
            this.pCard0.Image = ((System.Drawing.Image)(resources.GetObject("pCard0.Image")));
            this.pCard0.Location = new System.Drawing.Point(23, 11);
            this.pCard0.Margin = new System.Windows.Forms.Padding(2);
            this.pCard0.Name = "pCard0";
            this.pCard0.Size = new System.Drawing.Size(80, 124);
            this.pCard0.TabIndex = 3;
            this.pCard0.TabStop = false;
            // 
            // pCard1
            // 
            this.pCard1.Image = ((System.Drawing.Image)(resources.GetObject("pCard1.Image")));
            this.pCard1.Location = new System.Drawing.Point(127, 11);
            this.pCard1.Margin = new System.Windows.Forms.Padding(2);
            this.pCard1.Name = "pCard1";
            this.pCard1.Size = new System.Drawing.Size(80, 124);
            this.pCard1.TabIndex = 4;
            this.pCard1.TabStop = false;
            // 
            // pCard2
            // 
            this.pCard2.Image = ((System.Drawing.Image)(resources.GetObject("pCard2.Image")));
            this.pCard2.Location = new System.Drawing.Point(237, 11);
            this.pCard2.Margin = new System.Windows.Forms.Padding(2);
            this.pCard2.Name = "pCard2";
            this.pCard2.Size = new System.Drawing.Size(80, 124);
            this.pCard2.TabIndex = 5;
            this.pCard2.TabStop = false;
            // 
            // pCard3
            // 
            this.pCard3.Image = ((System.Drawing.Image)(resources.GetObject("pCard3.Image")));
            this.pCard3.Location = new System.Drawing.Point(344, 11);
            this.pCard3.Margin = new System.Windows.Forms.Padding(2);
            this.pCard3.Name = "pCard3";
            this.pCard3.Size = new System.Drawing.Size(80, 124);
            this.pCard3.TabIndex = 6;
            this.pCard3.TabStop = false;
            // 
            // pCard4
            // 
            this.pCard4.Image = ((System.Drawing.Image)(resources.GetObject("pCard4.Image")));
            this.pCard4.Location = new System.Drawing.Point(455, 11);
            this.pCard4.Margin = new System.Windows.Forms.Padding(2);
            this.pCard4.Name = "pCard4";
            this.pCard4.Size = new System.Drawing.Size(80, 124);
            this.pCard4.TabIndex = 7;
            this.pCard4.TabStop = false;
            // 
            // dCard0
            // 
            this.dCard0.Image = ((System.Drawing.Image)(resources.GetObject("dCard0.Image")));
            this.dCard0.Location = new System.Drawing.Point(23, 303);
            this.dCard0.Margin = new System.Windows.Forms.Padding(2);
            this.dCard0.Name = "dCard0";
            this.dCard0.Size = new System.Drawing.Size(80, 124);
            this.dCard0.TabIndex = 8;
            this.dCard0.TabStop = false;
            // 
            // dCard1
            // 
            this.dCard1.Image = ((System.Drawing.Image)(resources.GetObject("dCard1.Image")));
            this.dCard1.Location = new System.Drawing.Point(127, 303);
            this.dCard1.Margin = new System.Windows.Forms.Padding(2);
            this.dCard1.Name = "dCard1";
            this.dCard1.Size = new System.Drawing.Size(80, 124);
            this.dCard1.TabIndex = 9;
            this.dCard1.TabStop = false;
            // 
            // dCard2
            // 
            this.dCard2.Image = ((System.Drawing.Image)(resources.GetObject("dCard2.Image")));
            this.dCard2.Location = new System.Drawing.Point(237, 303);
            this.dCard2.Margin = new System.Windows.Forms.Padding(2);
            this.dCard2.Name = "dCard2";
            this.dCard2.Size = new System.Drawing.Size(80, 124);
            this.dCard2.TabIndex = 10;
            this.dCard2.TabStop = false;
            // 
            // dCard3
            // 
            this.dCard3.Image = ((System.Drawing.Image)(resources.GetObject("dCard3.Image")));
            this.dCard3.Location = new System.Drawing.Point(344, 303);
            this.dCard3.Margin = new System.Windows.Forms.Padding(2);
            this.dCard3.Name = "dCard3";
            this.dCard3.Size = new System.Drawing.Size(80, 124);
            this.dCard3.TabIndex = 11;
            this.dCard3.TabStop = false;
            // 
            // dCard4
            // 
            this.dCard4.Image = ((System.Drawing.Image)(resources.GetObject("dCard4.Image")));
            this.dCard4.Location = new System.Drawing.Point(455, 303);
            this.dCard4.Margin = new System.Windows.Forms.Padding(2);
            this.dCard4.Name = "dCard4";
            this.dCard4.Size = new System.Drawing.Size(80, 124);
            this.dCard4.TabIndex = 12;
            this.dCard4.TabStop = false;
            // 
            // pScoreLabel
            // 
            this.pScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pScoreLabel.Location = new System.Drawing.Point(435, 157);
            this.pScoreLabel.Name = "pScoreLabel";
            this.pScoreLabel.Size = new System.Drawing.Size(100, 23);
            this.pScoreLabel.TabIndex = 13;
            this.pScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pScoreLabel.Click += new System.EventHandler(this.pScoreLabel_Click);
            // 
            // dScoreLabel
            // 
            this.dScoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dScoreLabel.Location = new System.Drawing.Point(435, 248);
            this.dScoreLabel.Name = "dScoreLabel";
            this.dScoreLabel.Size = new System.Drawing.Size(100, 23);
            this.dScoreLabel.TabIndex = 14;
            this.dScoreLabel.Click += new System.EventHandler(this.dScoreLabel_Click);
            // 
            // pScoreTextBox
            // 
            this.pScoreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pScoreTextBox.Location = new System.Drawing.Point(303, 161);
            this.pScoreTextBox.Name = "pScoreTextBox";
            this.pScoreTextBox.Size = new System.Drawing.Size(100, 19);
            this.pScoreTextBox.TabIndex = 15;
            this.pScoreTextBox.Text = "Player Score:";
            this.pScoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dScoreTextBox
            // 
            this.dScoreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dScoreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dScoreTextBox.Location = new System.Drawing.Point(303, 252);
            this.dScoreTextBox.Name = "dScoreTextBox";
            this.dScoreTextBox.Size = new System.Drawing.Size(100, 19);
            this.dScoreTextBox.TabIndex = 16;
            this.dScoreTextBox.Text = "Dealer Score:";
            this.dScoreTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BlackJackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 429);
            this.Controls.Add(this.dScoreTextBox);
            this.Controls.Add(this.pScoreTextBox);
            this.Controls.Add(this.dScoreLabel);
            this.Controls.Add(this.pScoreLabel);
            this.Controls.Add(this.dCard4);
            this.Controls.Add(this.dCard3);
            this.Controls.Add(this.dCard2);
            this.Controls.Add(this.dCard1);
            this.Controls.Add(this.dCard0);
            this.Controls.Add(this.pCard4);
            this.Controls.Add(this.pCard3);
            this.Controls.Add(this.pCard2);
            this.Controls.Add(this.pCard1);
            this.Controls.Add(this.pCard0);
            this.Controls.Add(this.hitButton);
            this.Controls.Add(this.standButton);
            this.Controls.Add(this.newHandButton);
            this.Name = "BlackJackForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BlackJackForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pCard0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCard4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dCard0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dCard4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newHandButton;
        private System.Windows.Forms.Button standButton;
        private System.Windows.Forms.Button hitButton;
        private System.Windows.Forms.PictureBox pCard0;
        private System.Windows.Forms.PictureBox pCard1;
        private System.Windows.Forms.PictureBox pCard2;
        private System.Windows.Forms.PictureBox pCard3;
        private System.Windows.Forms.PictureBox pCard4;
        private System.Windows.Forms.PictureBox dCard0;
        private System.Windows.Forms.PictureBox dCard1;
        private System.Windows.Forms.PictureBox dCard2;
        private System.Windows.Forms.PictureBox dCard3;
        private System.Windows.Forms.PictureBox dCard4;
        private System.Windows.Forms.Label pScoreLabel;
        private System.Windows.Forms.Label dScoreLabel;
        private System.Windows.Forms.TextBox pScoreTextBox;
        private System.Windows.Forms.TextBox dScoreTextBox;
    }
}

