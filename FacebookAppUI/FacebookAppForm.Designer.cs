
namespace BasicFacebookFeatures
{
    partial class FacebookAppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacebookAppForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.profilePageButton = new System.Windows.Forms.Button();
            this.findMyMatchButton = new System.Windows.Forms.Button();
            this.postStatistics = new System.Windows.Forms.Button();
            this.logOutbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Image = global::BasicFacebookFeatures.Properties.Resources.פייסבוק;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(912, 156);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.Location = new System.Drawing.Point(373, 214);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(126, 126);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePicture.TabIndex = 2;
            this.ProfilePicture.TabStop = false;
            // 
            // profilePageButton
            // 
            this.profilePageButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.profilePageButton.Font = new System.Drawing.Font("Aharoni", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilePageButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.profilePageButton.Location = new System.Drawing.Point(297, 365);
            this.profilePageButton.Name = "profilePageButton";
            this.profilePageButton.Size = new System.Drawing.Size(271, 86);
            this.profilePageButton.TabIndex = 3;
            this.profilePageButton.Text = "My profile page";
            this.profilePageButton.UseVisualStyleBackColor = false;
            this.profilePageButton.Click += new System.EventHandler(this.profilePageButton_Click);
            // 
            // findMyMatchButton
            // 
            this.findMyMatchButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.findMyMatchButton.Font = new System.Drawing.Font("Aharoni", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findMyMatchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.findMyMatchButton.Location = new System.Drawing.Point(297, 481);
            this.findMyMatchButton.Name = "findMyMatchButton";
            this.findMyMatchButton.Size = new System.Drawing.Size(271, 86);
            this.findMyMatchButton.TabIndex = 5;
            this.findMyMatchButton.Text = "Find my match";
            this.findMyMatchButton.UseVisualStyleBackColor = false;
            this.findMyMatchButton.Click += new System.EventHandler(this.findMyMatchButton_Click);
            // 
            // postStatistics
            // 
            this.postStatistics.BackColor = System.Drawing.Color.CornflowerBlue;
            this.postStatistics.Font = new System.Drawing.Font("Aharoni", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postStatistics.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.postStatistics.Location = new System.Drawing.Point(297, 602);
            this.postStatistics.Name = "postStatistics";
            this.postStatistics.Size = new System.Drawing.Size(271, 86);
            this.postStatistics.TabIndex = 6;
            this.postStatistics.Text = "Posts statistics";
            this.postStatistics.UseVisualStyleBackColor = false;
            this.postStatistics.Click += new System.EventHandler(this.postStatistics_Click);
            // 
            // logOutbutton
            // 
            this.logOutbutton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.logOutbutton.Font = new System.Drawing.Font("Aharoni", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logOutbutton.Location = new System.Drawing.Point(748, 636);
            this.logOutbutton.Name = "logOutbutton";
            this.logOutbutton.Size = new System.Drawing.Size(164, 52);
            this.logOutbutton.TabIndex = 8;
            this.logOutbutton.Text = "Log out";
            this.logOutbutton.UseVisualStyleBackColor = false;
            this.logOutbutton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // FacebookAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(930, 724);
            this.Controls.Add(this.logOutbutton);
            this.Controls.Add(this.postStatistics);
            this.Controls.Add(this.findMyMatchButton);
            this.Controls.Add(this.profilePageButton);
            this.Controls.Add(this.ProfilePicture);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FacebookAppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook";
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ProfilePicture;
        private System.Windows.Forms.Button profilePageButton;
        private System.Windows.Forms.Button findMyMatchButton;
        private System.Windows.Forms.Button postStatistics;
        private System.Windows.Forms.Button logOutbutton;
    }
}