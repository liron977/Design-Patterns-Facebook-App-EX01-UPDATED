namespace BasicFacebookFeatures
{
    partial class PostRankForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label messageLabel;
            this.postMessage = new System.Windows.Forms.ListBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monthsChartPosts = new System.Windows.Forms.Button();
            this.yearChartPost = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ThePostWithTheMaxCommrns = new System.Windows.Forms.Label();
            this.ascending = new System.Windows.Forms.RadioButton();
            this.descendingSorted = new System.Windows.Forms.RadioButton();
            this.SortOrderMessage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            messageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(40, 22);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(197, 40);
            messageLabel.TabIndex = 0;
            messageLabel.Text = "Please choose a post from\r\n the list and edit it here:";
            // 
            // postMessage
            // 
            this.postMessage.DataSource = this.postBindingSource;
            this.postMessage.DisplayMember = "Message";
            this.postMessage.FormattingEnabled = true;
            this.postMessage.ItemHeight = 20;
            this.postMessage.Location = new System.Drawing.Point(23, 147);
            this.postMessage.Name = "postMessage";
            this.postMessage.Size = new System.Drawing.Size(820, 324);
            this.postMessage.TabIndex = 0;
            this.postMessage.SelectedIndexChanged += new System.EventHandler(this.postMessage_SelectedIndexChanged);
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // monthsChartPosts
            // 
            this.monthsChartPosts.BackColor = System.Drawing.Color.CornflowerBlue;
            this.monthsChartPosts.Font = new System.Drawing.Font("Aharoni", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthsChartPosts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.monthsChartPosts.Location = new System.Drawing.Point(572, 469);
            this.monthsChartPosts.Name = "monthsChartPosts";
            this.monthsChartPosts.Size = new System.Drawing.Size(271, 137);
            this.monthsChartPosts.TabIndex = 4;
            this.monthsChartPosts.Text = "Chart of posts per month";
            this.monthsChartPosts.UseVisualStyleBackColor = false;
            this.monthsChartPosts.Click += new System.EventHandler(this.monthsChartPosts_Click);
            // 
            // yearChartPost
            // 
            this.yearChartPost.BackColor = System.Drawing.Color.CornflowerBlue;
            this.yearChartPost.Font = new System.Drawing.Font("Aharoni", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearChartPost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yearChartPost.Location = new System.Drawing.Point(23, 473);
            this.yearChartPost.Name = "yearChartPost";
            this.yearChartPost.Size = new System.Drawing.Size(271, 129);
            this.yearChartPost.TabIndex = 5;
            this.yearChartPost.Text = "Chart of posts per year";
            this.yearChartPost.UseVisualStyleBackColor = false;
            this.yearChartPost.Click += new System.EventHandler(this.yearChartPost_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.textBox1.Location = new System.Drawing.Point(12, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(831, 26);
            this.textBox1.TabIndex = 6;
            // 
            // ThePostWithTheMaxCommrns
            // 
            this.ThePostWithTheMaxCommrns.AutoSize = true;
            this.ThePostWithTheMaxCommrns.BackColor = System.Drawing.Color.AliceBlue;
            this.ThePostWithTheMaxCommrns.Location = new System.Drawing.Point(228, 9);
            this.ThePostWithTheMaxCommrns.Name = "ThePostWithTheMaxCommrns";
            this.ThePostWithTheMaxCommrns.Size = new System.Drawing.Size(391, 20);
            this.ThePostWithTheMaxCommrns.TabIndex = 7;
            this.ThePostWithTheMaxCommrns.Text = "The post the recived the most amount of comments is:\r\n";
            // 
            // ascending
            // 
            this.ascending.AutoSize = true;
            this.ascending.Location = new System.Drawing.Point(232, 117);
            this.ascending.Name = "ascending";
            this.ascending.Size = new System.Drawing.Size(162, 24);
            this.ascending.TabIndex = 8;
            this.ascending.TabStop = true;
            this.ascending.Text = "Ascending sorted ";
            this.ascending.UseVisualStyleBackColor = true;
            this.ascending.CheckedChanged += new System.EventHandler(this.ascending_CheckedChanged);
            // 
            // descendingSorted
            // 
            this.descendingSorted.AutoSize = true;
            this.descendingSorted.Location = new System.Drawing.Point(483, 117);
            this.descendingSorted.Name = "descendingSorted";
            this.descendingSorted.Size = new System.Drawing.Size(168, 24);
            this.descendingSorted.TabIndex = 9;
            this.descendingSorted.TabStop = true;
            this.descendingSorted.Text = "Descending sorted";
            this.descendingSorted.UseVisualStyleBackColor = true;
            this.descendingSorted.CheckedChanged += new System.EventHandler(this.descendingSorted_CheckedChanged);
            // 
            // SortOrderMessage
            // 
            this.SortOrderMessage.AutoSize = true;
            this.SortOrderMessage.ForeColor = System.Drawing.Color.Blue;
            this.SortOrderMessage.Location = new System.Drawing.Point(210, 61);
            this.SortOrderMessage.Name = "SortOrderMessage";
            this.SortOrderMessage.Size = new System.Drawing.Size(441, 40);
            this.SortOrderMessage.TabIndex = 10;
            this.SortOrderMessage.Text = "Want to see your posts ordered by the number of comments?\r\n                      " +
    "Choose which order to be displayed ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(messageLabel);
            this.panel1.Controls.Add(this.messageTextBox);
            this.panel1.Location = new System.Drawing.Point(849, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 168);
            this.panel1.TabIndex = 11;
            // 
            // messageTextBox
            // 
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Message", true));
            this.messageTextBox.Location = new System.Drawing.Point(9, 104);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(291, 26);
            this.messageTextBox.TabIndex = 1;
            // 
            // PostRankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1155, 606);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SortOrderMessage);
            this.Controls.Add(this.descendingSorted);
            this.Controls.Add(this.ascending);
            this.Controls.Add(this.ThePostWithTheMaxCommrns);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.yearChartPost);
            this.Controls.Add(this.monthsChartPosts);
            this.Controls.Add(this.postMessage);
            this.Name = "PostRankForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PostRankForm";
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox postMessage;
        private System.Windows.Forms.Button monthsChartPosts;
        private System.Windows.Forms.Button yearChartPost;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label ThePostWithTheMaxCommrns;
        private System.Windows.Forms.RadioButton ascending;
        private System.Windows.Forms.RadioButton descendingSorted;
        private System.Windows.Forms.Label SortOrderMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.TextBox messageTextBox;
    }
}