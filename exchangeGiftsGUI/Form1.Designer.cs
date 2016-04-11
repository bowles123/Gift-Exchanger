namespace exchangeGiftsGUI
{
    partial class ExchangeForm
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
            this.BowlesButton = new System.Windows.Forms.Button();
            this.ThompsonButton = new System.Windows.Forms.Button();
            this.FamilyExchangeButton = new System.Windows.Forms.Button();
            this.IndividualExchanges = new System.Windows.Forms.RichTextBox();
            this.FamilyParticipatingPeople = new System.Windows.Forms.ListView();
            this.IndividualParticipatingPeople = new System.Windows.Forms.ListView();
            this.IndividualExchangeButton = new System.Windows.Forms.Button();
            this.FamilyExchanges = new System.Windows.Forms.RichTextBox();
            this.FamilyLabel = new System.Windows.Forms.Label();
            this.IndividualLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BowlesButton
            // 
            this.BowlesButton.Location = new System.Drawing.Point(13, 13);
            this.BowlesButton.Name = "BowlesButton";
            this.BowlesButton.Size = new System.Drawing.Size(91, 23);
            this.BowlesButton.TabIndex = 0;
            this.BowlesButton.Text = "Bowles Family";
            this.BowlesButton.UseVisualStyleBackColor = true;
            this.BowlesButton.Click += new System.EventHandler(this.BowlesButton_Click);
            // 
            // ThompsonButton
            // 
            this.ThompsonButton.Location = new System.Drawing.Point(282, 12);
            this.ThompsonButton.Name = "ThompsonButton";
            this.ThompsonButton.Size = new System.Drawing.Size(102, 23);
            this.ThompsonButton.TabIndex = 1;
            this.ThompsonButton.Text = "Thompson Family";
            this.ThompsonButton.UseVisualStyleBackColor = true;
            this.ThompsonButton.Click += new System.EventHandler(this.ThompsonButton_Click);
            // 
            // FamilyExchangeButton
            // 
            this.FamilyExchangeButton.Location = new System.Drawing.Point(12, 316);
            this.FamilyExchangeButton.Name = "FamilyExchangeButton";
            this.FamilyExchangeButton.Size = new System.Drawing.Size(100, 23);
            this.FamilyExchangeButton.TabIndex = 6;
            this.FamilyExchangeButton.Text = "Exchange Gifts";
            this.FamilyExchangeButton.UseVisualStyleBackColor = true;
            this.FamilyExchangeButton.Visible = false;
            this.FamilyExchangeButton.Click += new System.EventHandler(this.FamilyExchangeButton_Click);
            // 
            // IndividualExchanges
            // 
            this.IndividualExchanges.Location = new System.Drawing.Point(202, 51);
            this.IndividualExchanges.Name = "IndividualExchanges";
            this.IndividualExchanges.ReadOnly = true;
            this.IndividualExchanges.Size = new System.Drawing.Size(150, 100);
            this.IndividualExchanges.TabIndex = 12;
            this.IndividualExchanges.Text = "";
            this.IndividualExchanges.Visible = false;
            // 
            // FamilyParticipatingPeople
            // 
            this.FamilyParticipatingPeople.Location = new System.Drawing.Point(12, 210);
            this.FamilyParticipatingPeople.Name = "FamilyParticipatingPeople";
            this.FamilyParticipatingPeople.Size = new System.Drawing.Size(150, 100);
            this.FamilyParticipatingPeople.TabIndex = 13;
            this.FamilyParticipatingPeople.UseCompatibleStateImageBehavior = false;
            this.FamilyParticipatingPeople.Visible = false;
            this.FamilyParticipatingPeople.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.ParticipatingPeople_ItemChecked);
            // 
            // IndividualParticipatingPeople
            // 
            this.IndividualParticipatingPeople.CheckBoxes = true;
            this.IndividualParticipatingPeople.Location = new System.Drawing.Point(13, 62);
            this.IndividualParticipatingPeople.Name = "IndividualParticipatingPeople";
            this.IndividualParticipatingPeople.Size = new System.Drawing.Size(150, 100);
            this.IndividualParticipatingPeople.TabIndex = 14;
            this.IndividualParticipatingPeople.UseCompatibleStateImageBehavior = false;
            this.IndividualParticipatingPeople.Visible = false;
            this.IndividualParticipatingPeople.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.IndividualParticipatingPeople_ItemChecked);
            // 
            // IndividualExchangeButton
            // 
            this.IndividualExchangeButton.Location = new System.Drawing.Point(12, 168);
            this.IndividualExchangeButton.Name = "IndividualExchangeButton";
            this.IndividualExchangeButton.Size = new System.Drawing.Size(100, 23);
            this.IndividualExchangeButton.TabIndex = 15;
            this.IndividualExchangeButton.Text = "Exchange Gifts";
            this.IndividualExchangeButton.UseVisualStyleBackColor = true;
            this.IndividualExchangeButton.Visible = false;
            this.IndividualExchangeButton.Click += new System.EventHandler(this.IndividualExchangeButton_Click);
            // 
            // FamilyExchanges
            // 
            this.FamilyExchanges.Location = new System.Drawing.Point(202, 195);
            this.FamilyExchanges.Name = "FamilyExchanges";
            this.FamilyExchanges.ReadOnly = true;
            this.FamilyExchanges.Size = new System.Drawing.Size(150, 100);
            this.FamilyExchanges.TabIndex = 16;
            this.FamilyExchanges.Text = "";
            this.FamilyExchanges.Visible = false;
            // 
            // FamilyLabel
            // 
            this.FamilyLabel.AutoSize = true;
            this.FamilyLabel.Location = new System.Drawing.Point(12, 194);
            this.FamilyLabel.Name = "FamilyLabel";
            this.FamilyLabel.Size = new System.Drawing.Size(97, 13);
            this.FamilyLabel.TabIndex = 17;
            this.FamilyLabel.Text = "Family Participants:";
            this.FamilyLabel.Visible = false;
            // 
            // IndividualLabel
            // 
            this.IndividualLabel.AutoSize = true;
            this.IndividualLabel.Location = new System.Drawing.Point(13, 43);
            this.IndividualLabel.Name = "IndividualLabel";
            this.IndividualLabel.Size = new System.Drawing.Size(113, 13);
            this.IndividualLabel.TabIndex = 18;
            this.IndividualLabel.Text = "Individual Participants:";
            this.IndividualLabel.Visible = false;
            // 
            // ExchangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 342);
            this.Controls.Add(this.IndividualLabel);
            this.Controls.Add(this.FamilyLabel);
            this.Controls.Add(this.FamilyExchanges);
            this.Controls.Add(this.IndividualExchangeButton);
            this.Controls.Add(this.IndividualParticipatingPeople);
            this.Controls.Add(this.FamilyParticipatingPeople);
            this.Controls.Add(this.IndividualExchanges);
            this.Controls.Add(this.FamilyExchangeButton);
            this.Controls.Add(this.ThompsonButton);
            this.Controls.Add(this.BowlesButton);
            this.Name = "ExchangeForm";
            this.Text = "Exchange Gifts";
            this.Load += new System.EventHandler(this.ExchangeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BowlesButton;
        private System.Windows.Forms.Button ThompsonButton;
        private System.Windows.Forms.Button FamilyExchangeButton;
        private System.Windows.Forms.RichTextBox IndividualExchanges;
        private System.Windows.Forms.ListView FamilyParticipatingPeople;
        private System.Windows.Forms.ListView IndividualParticipatingPeople;
        private System.Windows.Forms.Button IndividualExchangeButton;
        private System.Windows.Forms.RichTextBox FamilyExchanges;
        private System.Windows.Forms.Label FamilyLabel;
        private System.Windows.Forms.Label IndividualLabel;
    }
}

