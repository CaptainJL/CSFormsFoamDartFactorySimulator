namespace CSFormsFoamDartFactorySimulator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label3 = new Label();
            statsListBox = new ListBox();
            foamDartsLabel = new Label();
            creditsLabel = new Label();
            FoamDartSellRateLabel = new Label();
            foamDartProdRateLabel = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(169, 21);
            label1.TabIndex = 0;
            label1.Text = "Foam Bullets Available:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 39);
            label3.Name = "label3";
            label3.Size = new Size(129, 21);
            label3.TabIndex = 2;
            label3.Text = "Credits Available:";
            // 
            // statsListBox
            // 
            statsListBox.FormattingEnabled = true;
            statsListBox.ItemHeight = 15;
            statsListBox.Location = new Point(1019, 479);
            statsListBox.Name = "statsListBox";
            statsListBox.Size = new Size(249, 229);
            statsListBox.TabIndex = 5;
            // 
            // foamDartsLabel
            // 
            foamDartsLabel.AutoSize = true;
            foamDartsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            foamDartsLabel.Location = new Point(211, 9);
            foamDartsLabel.Name = "foamDartsLabel";
            foamDartsLabel.Size = new Size(19, 21);
            foamDartsLabel.TabIndex = 6;
            foamDartsLabel.Text = "0";
            // 
            // creditsLabel
            // 
            creditsLabel.AutoSize = true;
            creditsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            creditsLabel.Location = new Point(211, 39);
            creditsLabel.Name = "creditsLabel";
            creditsLabel.Size = new Size(19, 21);
            creditsLabel.TabIndex = 7;
            creditsLabel.Text = "0";
            // 
            // FoamDartSellRateLabel
            // 
            FoamDartSellRateLabel.AutoSize = true;
            FoamDartSellRateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FoamDartSellRateLabel.Location = new Point(543, 39);
            FoamDartSellRateLabel.Name = "FoamDartSellRateLabel";
            FoamDartSellRateLabel.Size = new Size(19, 21);
            FoamDartSellRateLabel.TabIndex = 13;
            FoamDartSellRateLabel.Text = "0";
            // 
            // foamDartProdRateLabel
            // 
            foamDartProdRateLabel.AutoSize = true;
            foamDartProdRateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            foamDartProdRateLabel.Location = new Point(543, 9);
            foamDartProdRateLabel.Name = "foamDartProdRateLabel";
            foamDartProdRateLabel.Size = new Size(19, 21);
            foamDartProdRateLabel.TabIndex = 12;
            foamDartProdRateLabel.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(344, 39);
            label5.Name = "label5";
            label5.Size = new Size(166, 21);
            label5.TabIndex = 11;
            label5.Text = "Foam Bullets Sell Rate:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(344, 9);
            label6.Name = "label6";
            label6.Size = new Size(177, 21);
            label6.TabIndex = 10;
            label6.Text = "Foam Bullets Prod. Rate:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 720);
            Controls.Add(FoamDartSellRateLabel);
            Controls.Add(foamDartProdRateLabel);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(creditsLabel);
            Controls.Add(foamDartsLabel);
            Controls.Add(statsListBox);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Foam Bullet Factory Simulator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private ListBox statsListBox;
        private Label foamDartsLabel;
        private Label creditsLabel;
        private Label FoamDartSellRateLabel;
        private Label foamDartProdRateLabel;
        private Label label5;
        private Label label6;
    }
}