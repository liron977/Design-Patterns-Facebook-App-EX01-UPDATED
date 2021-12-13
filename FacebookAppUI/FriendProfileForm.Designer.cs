
namespace BasicFacebookFeatures
{
    partial class FriendProfileForm
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
            this.BirthDay = new System.Windows.Forms.Label();
            this.userFriendName = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.FriendGender = new System.Windows.Forms.Label();
            this.FriendName = new System.Windows.Forms.Label();
            this.userBirthDay = new System.Windows.Forms.Label();
            this.FriendPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FriendPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // BirthDay
            // 
            this.BirthDay.AutoSize = true;
            this.BirthDay.BackColor = System.Drawing.Color.RoyalBlue;
            this.BirthDay.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthDay.Location = new System.Drawing.Point(144, 278);
            this.BirthDay.Name = "BirthDay";
            this.BirthDay.Size = new System.Drawing.Size(97, 20);
            this.BirthDay.TabIndex = 2;
            this.BirthDay.Text = "BirthDay:";
            // 
            // userFriendName
            // 
            this.userFriendName.AutoSize = true;
            this.userFriendName.Location = new System.Drawing.Point(291, 42);
            this.userFriendName.Name = "userFriendName";
            this.userFriendName.Size = new System.Drawing.Size(0, 20);
            this.userFriendName.TabIndex = 3;
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(273, 317);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(18, 20);
            this.Gender.TabIndex = 5;
            this.Gender.Text = "g";
            // 
            // FriendGender
            // 
            this.FriendGender.AutoSize = true;
            this.FriendGender.BackColor = System.Drawing.Color.RoyalBlue;
            this.FriendGender.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendGender.Location = new System.Drawing.Point(144, 317);
            this.FriendGender.Name = "FriendGender";
            this.FriendGender.Size = new System.Drawing.Size(85, 20);
            this.FriendGender.TabIndex = 6;
            this.FriendGender.Text = "Gender:";
            // 
            // FriendName
            // 
            this.FriendName.AutoSize = true;
            this.FriendName.Location = new System.Drawing.Point(178, 42);
            this.FriendName.Name = "FriendName";
            this.FriendName.Size = new System.Drawing.Size(51, 20);
            this.FriendName.TabIndex = 7;
            this.FriendName.Text = "Name";
            // 
            // userBirthDay
            // 
            this.userBirthDay.AutoSize = true;
            this.userBirthDay.Location = new System.Drawing.Point(273, 278);
            this.userBirthDay.Name = "userBirthDay";
            this.userBirthDay.Size = new System.Drawing.Size(18, 20);
            this.userBirthDay.TabIndex = 8;
            this.userBirthDay.Text = "1";

            // 
            // FriendPicture
            // 
            this.FriendPicture.Location = new System.Drawing.Point(132, 94);
            this.FriendPicture.Name = "FriendPicture";
            this.FriendPicture.Size = new System.Drawing.Size(140, 140);
            this.FriendPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FriendPicture.TabIndex = 1;
            this.FriendPicture.TabStop = false;
            // 
            // FriendProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(423, 389);
            this.Controls.Add(this.userBirthDay);
            this.Controls.Add(this.FriendName);
            this.Controls.Add(this.FriendGender);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.userFriendName);
            this.Controls.Add(this.BirthDay);
            this.Controls.Add(this.FriendPicture);
            this.Name = "FriendProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FriendProfileForm";
            ((System.ComponentModel.ISupportInitialize)(this.FriendPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox FriendPicture;
        private System.Windows.Forms.Label BirthDay;
        private System.Windows.Forms.Label userFriendName;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label FriendGender;
        private System.Windows.Forms.Label FriendName;
        private System.Windows.Forms.Label userBirthDay;
    }
}