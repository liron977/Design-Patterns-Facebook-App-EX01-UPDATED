
namespace BasicFacebookFeatures
{
    partial class FindMyMatchForm
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
            this.RecommendedMatchesLabel = new System.Windows.Forms.Label();
            this.recommendedMatchesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FriendWhoLoveMeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FriendWhoLoveMePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendWhoLoveMePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // RecommendedMatchesLabel
            // 
            this.RecommendedMatchesLabel.AutoSize = true;
            this.RecommendedMatchesLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.RecommendedMatchesLabel.Font = new System.Drawing.Font("Aharoni", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecommendedMatchesLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RecommendedMatchesLabel.Location = new System.Drawing.Point(51, 181);
            this.RecommendedMatchesLabel.Name = "RecommendedMatchesLabel";
            this.RecommendedMatchesLabel.Size = new System.Drawing.Size(299, 22);
            this.RecommendedMatchesLabel.TabIndex = 12;
            this.RecommendedMatchesLabel.Text = "Recommended Just For You";
            // 
            // recommendedMatchesListBox
            // 
            this.recommendedMatchesListBox.FormattingEnabled = true;
            this.recommendedMatchesListBox.ItemHeight = 20;
            this.recommendedMatchesListBox.Location = new System.Drawing.Point(22, 218);
            this.recommendedMatchesListBox.Name = "recommendedMatchesListBox";
            this.recommendedMatchesListBox.Size = new System.Drawing.Size(373, 184);
            this.recommendedMatchesListBox.TabIndex = 13;
            this.recommendedMatchesListBox.SelectedIndexChanged += new System.EventHandler(this.recommendedMatchesListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Aharoni", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(422, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 22);
            this.label1.TabIndex = 14;
            this.label1.Text = "The friend who loved me the most";
            // 
            // FriendWhoLoveMeLabel
            // 
            this.FriendWhoLoveMeLabel.AutoSize = true;
            this.FriendWhoLoveMeLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.FriendWhoLoveMeLabel.Font = new System.Drawing.Font("Aharoni", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendWhoLoveMeLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FriendWhoLoveMeLabel.Location = new System.Drawing.Point(549, 408);
            this.FriendWhoLoveMeLabel.Name = "FriendWhoLoveMeLabel";
            this.FriendWhoLoveMeLabel.Size = new System.Drawing.Size(0, 22);
            this.FriendWhoLoveMeLabel.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BasicFacebookFeatures.Properties.Resources.blue_little_hearts1;
            this.pictureBox1.Location = new System.Drawing.Point(-84, -581);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1075, 727);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // FriendWhoLoveMePictureBox
            // 
            this.FriendWhoLoveMePictureBox.Location = new System.Drawing.Point(497, 218);
            this.FriendWhoLoveMePictureBox.Name = "FriendWhoLoveMePictureBox";
            this.FriendWhoLoveMePictureBox.Size = new System.Drawing.Size(230, 175);
            this.FriendWhoLoveMePictureBox.TabIndex = 15;
            this.FriendWhoLoveMePictureBox.TabStop = false;
            // 
            // FindMyMatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FriendWhoLoveMeLabel);
            this.Controls.Add(this.FriendWhoLoveMePictureBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recommendedMatchesListBox);
            this.Controls.Add(this.RecommendedMatchesLabel);
            this.Name = "FindMyMatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FindMyMatchForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FriendWhoLoveMePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RecommendedMatchesLabel;
        private System.Windows.Forms.ListBox recommendedMatchesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox FriendWhoLoveMePictureBox;
        private System.Windows.Forms.Label FriendWhoLoveMeLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}