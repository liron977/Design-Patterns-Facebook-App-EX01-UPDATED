
namespace BasicFacebookFeatures
{
    partial class UserProfileForm
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
            this.posts = new System.Windows.Forms.ListBox();
            this.PostStatusbutton = new System.Windows.Forms.Button();
            this.PostStatusTextBox = new System.Windows.Forms.TextBox();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.friendsListBox = new System.Windows.Forms.ListBox();
            this.FriendsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.upcomingBirthdaysListBox = new System.Windows.Forms.ListBox();
            this.UpcomingBirthdaysLabel = new System.Windows.Forms.Label();
            this.albumListBox = new System.Windows.Forms.ListBox();
            this.AlbumsLabel = new System.Windows.Forms.Label();
            this.AlbumCoverPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumCoverPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // posts
            // 
            this.posts.FormattingEnabled = true;
            this.posts.ItemHeight = 20;
            this.posts.Location = new System.Drawing.Point(303, 242);
            this.posts.Name = "posts";
            this.posts.Size = new System.Drawing.Size(279, 264);
            this.posts.TabIndex = 1;
            // 
            // PostStatusbutton
            // 
            this.PostStatusbutton.Location = new System.Drawing.Point(507, 179);
            this.PostStatusbutton.Name = "PostStatusbutton";
            this.PostStatusbutton.Size = new System.Drawing.Size(75, 33);
            this.PostStatusbutton.TabIndex = 2;
            this.PostStatusbutton.Text = "Post!";
            this.PostStatusbutton.UseVisualStyleBackColor = true;
            this.PostStatusbutton.Click += new System.EventHandler(this.postStatusButton_Click_1);
            // 
            // PostStatusTextBox
            // 
            this.PostStatusTextBox.Location = new System.Drawing.Point(303, 186);
            this.PostStatusTextBox.Name = "PostStatusTextBox";
            this.PostStatusTextBox.Size = new System.Drawing.Size(163, 26);
            this.PostStatusTextBox.TabIndex = 3;
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.Location = new System.Drawing.Point(375, 7);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(123, 101);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePicture.TabIndex = 0;
            this.ProfilePicture.TabStop = false;
            // 
            // friendsListBox
            // 
            this.friendsListBox.FormattingEnabled = true;
            this.friendsListBox.ItemHeight = 20;
            this.friendsListBox.Location = new System.Drawing.Point(43, 152);
            this.friendsListBox.Name = "friendsListBox";
            this.friendsListBox.Size = new System.Drawing.Size(174, 204);
            this.friendsListBox.TabIndex = 4;
            this.friendsListBox.SelectedIndexChanged += new System.EventHandler(this.friendsListBox_SelectedIndexChanged);
            // 
            // FriendsLabel
            // 
            this.FriendsLabel.AutoSize = true;
            this.FriendsLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.FriendsLabel.Font = new System.Drawing.Font("Aharoni", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendsLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.FriendsLabel.Location = new System.Drawing.Point(86, 111);
            this.FriendsLabel.Name = "FriendsLabel";
            this.FriendsLabel.Size = new System.Drawing.Size(108, 28);
            this.FriendsLabel.TabIndex = 5;
            this.FriendsLabel.Text = "Friends";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Aharoni", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(298, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Whats in your mind?";
            // 
            // upcomingBirthdaysListBox
            // 
            this.upcomingBirthdaysListBox.FormattingEnabled = true;
            this.upcomingBirthdaysListBox.ItemHeight = 20;
            this.upcomingBirthdaysListBox.Location = new System.Drawing.Point(23, 422);
            this.upcomingBirthdaysListBox.Name = "upcomingBirthdaysListBox";
            this.upcomingBirthdaysListBox.Size = new System.Drawing.Size(242, 84);
            this.upcomingBirthdaysListBox.TabIndex = 8;
            // 
            // UpcomingBirthdaysLabel
            // 
            this.UpcomingBirthdaysLabel.AutoSize = true;
            this.UpcomingBirthdaysLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.UpcomingBirthdaysLabel.Font = new System.Drawing.Font("Aharoni", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.UpcomingBirthdaysLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.UpcomingBirthdaysLabel.Location = new System.Drawing.Point(18, 380);
            this.UpcomingBirthdaysLabel.Name = "UpcomingBirthdaysLabel";
            this.UpcomingBirthdaysLabel.Size = new System.Drawing.Size(278, 28);
            this.UpcomingBirthdaysLabel.TabIndex = 9;
            this.UpcomingBirthdaysLabel.Text = "Upcoming Birthdays";
            // 
            // albumListBox
            // 
            this.albumListBox.FormattingEnabled = true;
            this.albumListBox.ItemHeight = 20;
            this.albumListBox.Location = new System.Drawing.Point(607, 289);
            this.albumListBox.Name = "albumListBox";
            this.albumListBox.Size = new System.Drawing.Size(276, 204);
            this.albumListBox.TabIndex = 10;
            this.albumListBox.SelectedIndexChanged += new System.EventHandler(this.albumListBox_SelectedIndexChanged);
            // 
            // AlbumsLabel
            // 
            this.AlbumsLabel.AutoSize = true;
            this.AlbumsLabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.AlbumsLabel.Font = new System.Drawing.Font("Aharoni", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AlbumsLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.AlbumsLabel.Location = new System.Drawing.Point(677, 242);
            this.AlbumsLabel.Name = "AlbumsLabel";
            this.AlbumsLabel.Size = new System.Drawing.Size(112, 28);
            this.AlbumsLabel.TabIndex = 11;
            this.AlbumsLabel.Text = "Albums";
            // 
            // AlbumCoverPictureBox
            // 
            this.AlbumCoverPictureBox.Location = new System.Drawing.Point(773, 358);
            this.AlbumCoverPictureBox.Name = "AlbumCoverPictureBox";
            this.AlbumCoverPictureBox.Size = new System.Drawing.Size(150, 135);
            this.AlbumCoverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AlbumCoverPictureBox.TabIndex = 12;
            this.AlbumCoverPictureBox.TabStop = false;
            // 
            // UserProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(924, 527);
            this.Controls.Add(this.AlbumCoverPictureBox);
            this.Controls.Add(this.AlbumsLabel);
            this.Controls.Add(this.albumListBox);
            this.Controls.Add(this.UpcomingBirthdaysLabel);
            this.Controls.Add(this.upcomingBirthdaysListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FriendsLabel);
            this.Controls.Add(this.friendsListBox);
            this.Controls.Add(this.PostStatusTextBox);
            this.Controls.Add(this.PostStatusbutton);
            this.Controls.Add(this.posts);
            this.Controls.Add(this.ProfilePicture);
            this.Name = "UserProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserProfileForm";
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlbumCoverPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ProfilePicture;
        private System.Windows.Forms.ListBox posts;
        private System.Windows.Forms.Button PostStatusbutton;
        private System.Windows.Forms.TextBox PostStatusTextBox;
        private System.Windows.Forms.ListBox friendsListBox;
        private System.Windows.Forms.Label FriendsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox upcomingBirthdaysListBox;
        private System.Windows.Forms.Label UpcomingBirthdaysLabel;
        private System.Windows.Forms.ListBox albumListBox;
        private System.Windows.Forms.Label AlbumsLabel;
        private System.Windows.Forms.PictureBox AlbumCoverPictureBox;
    }
}