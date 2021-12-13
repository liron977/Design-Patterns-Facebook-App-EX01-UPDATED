
namespace BasicFacebookFeatures
{
    partial class PostInformationForm
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
            System.Windows.Forms.Button shareYouPostButton;
            this.TimeCreated = new System.Windows.Forms.Label();
            this.labelTaggedFriends = new System.Windows.Forms.Label();
            this.timeCreate = new System.Windows.Forms.Label();
            this.Comments = new System.Windows.Forms.Label();
            this.TaggedFriends = new System.Windows.Forms.Label();
            this.NumberofComments = new System.Windows.Forms.Label();
            this.postTextBox = new System.Windows.Forms.TextBox();
            shareYouPostButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shareYouPostButton
            // 
            shareYouPostButton.BackColor = System.Drawing.Color.CornflowerBlue;
            shareYouPostButton.Font = new System.Drawing.Font("Aharoni", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            shareYouPostButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            shareYouPostButton.Location = new System.Drawing.Point(576, 210);
            shareYouPostButton.Name = "shareYouPostButton";
            shareYouPostButton.Size = new System.Drawing.Size(269, 59);
            shareYouPostButton.TabIndex = 22;
            shareYouPostButton.Text = "Share your post !";
            shareYouPostButton.UseVisualStyleBackColor = false;
            shareYouPostButton.Click += new System.EventHandler(this.shareYouPostButton_Click);
            // 
            // TimeCreated
            // 
            this.TimeCreated.AutoSize = true;
            this.TimeCreated.BackColor = System.Drawing.Color.RoyalBlue;
            this.TimeCreated.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeCreated.Location = new System.Drawing.Point(12, 154);
            this.TimeCreated.Name = "TimeCreated";
            this.TimeCreated.Size = new System.Drawing.Size(134, 20);
            this.TimeCreated.TabIndex = 3;
            this.TimeCreated.Text = "Time created:";
            // 
            // labelTaggedFriends
            // 
            this.labelTaggedFriends.AutoSize = true;
            this.labelTaggedFriends.Location = new System.Drawing.Point(324, 89);
            this.labelTaggedFriends.Name = "labelTaggedFriends";
            this.labelTaggedFriends.Size = new System.Drawing.Size(51, 20);
            this.labelTaggedFriends.TabIndex = 11;
            this.labelTaggedFriends.Text = "label2";
            // 
            // timeCreate
            // 
            this.timeCreate.AutoSize = true;
            this.timeCreate.Location = new System.Drawing.Point(324, 166);
            this.timeCreate.Name = "timeCreate";
            this.timeCreate.Size = new System.Drawing.Size(51, 20);
            this.timeCreate.TabIndex = 12;
            this.timeCreate.Text = "label3";
            // 
            // Comments
            // 
            this.Comments.AutoSize = true;
            this.Comments.Location = new System.Drawing.Point(324, 23);
            this.Comments.Name = "Comments";
            this.Comments.Size = new System.Drawing.Size(51, 20);
            this.Comments.TabIndex = 13;
            this.Comments.Text = "label4";
            // 
            // TaggedFriends
            // 
            this.TaggedFriends.AutoSize = true;
            this.TaggedFriends.BackColor = System.Drawing.Color.RoyalBlue;
            this.TaggedFriends.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaggedFriends.Location = new System.Drawing.Point(12, 89);
            this.TaggedFriends.Name = "TaggedFriends";
            this.TaggedFriends.Size = new System.Drawing.Size(147, 20);
            this.TaggedFriends.TabIndex = 15;
            this.TaggedFriends.Text = "Tagged friends";
            // 
            // NumberofComments
            // 
            this.NumberofComments.AutoSize = true;
            this.NumberofComments.BackColor = System.Drawing.Color.RoyalBlue;
            this.NumberofComments.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberofComments.Location = new System.Drawing.Point(12, 23);
            this.NumberofComments.Name = "NumberofComments";
            this.NumberofComments.Size = new System.Drawing.Size(213, 20);
            this.NumberofComments.TabIndex = 17;
            this.NumberofComments.Text = "Number of comments";
            // 
            // postTextBox
            // 
            this.postTextBox.Location = new System.Drawing.Point(534, 23);
            this.postTextBox.Multiline = true;
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.Size = new System.Drawing.Size(379, 151);
            this.postTextBox.TabIndex = 20;
            // 
            // PostInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1209, 567);
            this.Controls.Add(shareYouPostButton);
            this.Controls.Add(this.postTextBox);
            this.Controls.Add(this.NumberofComments);
            this.Controls.Add(this.TaggedFriends);
            this.Controls.Add(this.Comments);
            this.Controls.Add(this.timeCreate);
            this.Controls.Add(this.labelTaggedFriends);
            this.Controls.Add(this.TimeCreated);
            this.Name = "PostInformationForm";
            this.Load += new System.EventHandler(this.PostInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TimeCreated;
        private System.Windows.Forms.Label labelTaggedFriends;
        private System.Windows.Forms.Label timeCreate;
        private System.Windows.Forms.Label Comments;
        private System.Windows.Forms.Label TaggedFriends;
        private System.Windows.Forms.Label NumberofComments;
        private System.Windows.Forms.TextBox postTextBox;
    }
}