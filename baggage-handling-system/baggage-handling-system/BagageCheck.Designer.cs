namespace baggage_handling_system
{
    partial class BagageCheck
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
            this.btnWeigh = new System.Windows.Forms.Button();
            this.btnBuyExtraBaggage = new System.Windows.Forms.Button();
            this.lblTotalWeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWeigh
            // 
            this.btnWeigh.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnWeigh.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnWeigh.Location = new System.Drawing.Point(141, 467);
            this.btnWeigh.Name = "btnWeigh";
            this.btnWeigh.Size = new System.Drawing.Size(305, 52);
            this.btnWeigh.TabIndex = 1;
            this.btnWeigh.Text = "Weigh";
            this.btnWeigh.UseVisualStyleBackColor = false;
            this.btnWeigh.Click += new System.EventHandler(this.btnWeigh_Click);
            // 
            // btnBuyExtraBaggage
            // 
            this.btnBuyExtraBaggage.BackColor = System.Drawing.Color.Transparent;
            this.btnBuyExtraBaggage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyExtraBaggage.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBuyExtraBaggage.Location = new System.Drawing.Point(230, 549);
            this.btnBuyExtraBaggage.Name = "btnBuyExtraBaggage";
            this.btnBuyExtraBaggage.Size = new System.Drawing.Size(124, 72);
            this.btnBuyExtraBaggage.TabIndex = 3;
            this.btnBuyExtraBaggage.Text = "Buy Extra Baggage";
            this.btnBuyExtraBaggage.UseVisualStyleBackColor = false;
            this.btnBuyExtraBaggage.Visible = false;
            this.btnBuyExtraBaggage.Click += new System.EventHandler(this.btnBuyExtraBaggage_Click);
            // 
            // lblTotalWeight
            // 
            this.lblTotalWeight.AutoSize = true;
            this.lblTotalWeight.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalWeight.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalWeight.Location = new System.Drawing.Point(12, 400);
            this.lblTotalWeight.Name = "lblTotalWeight";
            this.lblTotalWeight.Size = new System.Drawing.Size(414, 37);
            this.lblTotalWeight.TabIndex = 4;
            this.lblTotalWeight.Text = "Total weight of your baggages: ";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.BackColor = System.Drawing.Color.Transparent;
            this.lblWeight.Font = new System.Drawing.Font("Calibri", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWeight.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWeight.Location = new System.Drawing.Point(345, 394);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(0, 46);
            this.lblWeight.TabIndex = 5;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::baggage_handling_system.Properties.Resources.criss_cross;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(542, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 18;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // BagageCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::baggage_handling_system.Properties.Resources.weight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(579, 778);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.lblTotalWeight);
            this.Controls.Add(this.btnBuyExtraBaggage);
            this.Controls.Add(this.btnWeigh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BagageCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BagageCheck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnWeigh;
        private System.Windows.Forms.Button btnBuyExtraBaggage;
        private System.Windows.Forms.Label lblTotalWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Button btnExit;
    }
}