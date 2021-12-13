
namespace BasicFacebookFeatures
{
    partial class SelectPreferencesForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.ageRangelabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.fromLabel = new System.Windows.Forms.Label();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.continueButton = new System.Windows.Forms.Button();
            this.ToNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FromNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ToNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RoyalBlue;
            this.label2.Font = new System.Drawing.Font("Aharoni", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(346, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "What is your preference?";
            // 
            // ageRangelabel
            // 
            this.ageRangelabel.AutoSize = true;
            this.ageRangelabel.BackColor = System.Drawing.Color.RoyalBlue;
            this.ageRangelabel.Font = new System.Drawing.Font("Aharoni", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ageRangelabel.ForeColor = System.Drawing.SystemColors.Control;
            this.ageRangelabel.Location = new System.Drawing.Point(47, 156);
            this.ageRangelabel.Name = "ageRangelabel";
            this.ageRangelabel.Size = new System.Drawing.Size(282, 28);
            this.ageRangelabel.TabIndex = 5;
            this.ageRangelabel.Text = "Desirable age range";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ToLabel.Location = new System.Drawing.Point(147, 203);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(30, 20);
            this.ToLabel.TabIndex = 8;
            this.ToLabel.Text = "To";
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.fromLabel.Location = new System.Drawing.Point(-1, 200);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(57, 20);
            this.fromLabel.TabIndex = 9;
            this.fromLabel.Text = "From";
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.femaleRadioButton.Location = new System.Drawing.Point(12, 74);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(101, 24);
            this.femaleRadioButton.TabIndex = 13;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Font = new System.Drawing.Font("Aharoni", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.maleRadioButton.Location = new System.Drawing.Point(134, 74);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(80, 24);
            this.maleRadioButton.TabIndex = 15;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = false;
            // 
            // continueButton
            // 
            this.continueButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.continueButton.Font = new System.Drawing.Font("Aharoni", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.continueButton.Location = new System.Drawing.Point(124, 289);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(225, 67);
            this.continueButton.TabIndex = 16;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = false;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // ToNumericUpDown
            // 
            this.ToNumericUpDown.Location = new System.Drawing.Point(200, 197);
            this.ToNumericUpDown.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.ToNumericUpDown.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.ToNumericUpDown.Name = "ToNumericUpDown";
            this.ToNumericUpDown.Size = new System.Drawing.Size(68, 26);
            this.ToNumericUpDown.TabIndex = 17;
            this.ToNumericUpDown.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // FromNumericUpDown
            // 
            this.FromNumericUpDown.Location = new System.Drawing.Point(62, 197);
            this.FromNumericUpDown.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.FromNumericUpDown.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.FromNumericUpDown.Name = "FromNumericUpDown";
            this.FromNumericUpDown.Size = new System.Drawing.Size(67, 26);
            this.FromNumericUpDown.TabIndex = 18;
            this.FromNumericUpDown.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // SelectPreferencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(379, 385);
            this.Controls.Add(this.FromNumericUpDown);
            this.Controls.Add(this.ToNumericUpDown);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.maleRadioButton);
            this.Controls.Add(this.femaleRadioButton);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.ageRangelabel);
            this.Controls.Add(this.label2);
            this.Name = "SelectPreferencesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectPreferencesForm";
            ((System.ComponentModel.ISupportInitialize)(this.ToNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FromNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ageRangelabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.NumericUpDown ToNumericUpDown;
        private System.Windows.Forms.NumericUpDown FromNumericUpDown;
    }
}