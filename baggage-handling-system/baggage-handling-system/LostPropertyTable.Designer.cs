namespace baggage_handling_system
{
    partial class LostPropertyTable
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
            this.btnFindLostBaggage = new System.Windows.Forms.Button();
            this.lblLost = new System.Windows.Forms.Label();
            this.txtBoxBaggageID = new System.Windows.Forms.TextBox();
            this.Lost_Timer = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFindLostBaggage
            // 
            this.btnFindLostBaggage.BackColor = System.Drawing.Color.Transparent;
            this.btnFindLostBaggage.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnFindLostBaggage.Location = new System.Drawing.Point(233, 478);
            this.btnFindLostBaggage.Margin = new System.Windows.Forms.Padding(4);
            this.btnFindLostBaggage.Name = "btnFindLostBaggage";
            this.btnFindLostBaggage.Size = new System.Drawing.Size(196, 47);
            this.btnFindLostBaggage.TabIndex = 7;
            this.btnFindLostBaggage.Text = "Search";
            this.btnFindLostBaggage.UseVisualStyleBackColor = false;
            this.btnFindLostBaggage.Click += new System.EventHandler(this.btnFindLostBaggage_Click);
            // 
            // lblLost
            // 
            this.lblLost.AutoSize = true;
            this.lblLost.BackColor = System.Drawing.Color.Transparent;
            this.lblLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLost.Location = new System.Drawing.Point(67, 417);
            this.lblLost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLost.Name = "lblLost";
            this.lblLost.Size = new System.Drawing.Size(152, 29);
            this.lblLost.TabIndex = 6;
            this.lblLost.Text = "Baggage ID :";
            // 
            // txtBoxBaggageID
            // 
            this.txtBoxBaggageID.Location = new System.Drawing.Point(233, 423);
            this.txtBoxBaggageID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxBaggageID.Name = "txtBoxBaggageID";
            this.txtBoxBaggageID.Size = new System.Drawing.Size(196, 22);
            this.txtBoxBaggageID.TabIndex = 5;
            // 
            // Lost_Timer
            // 
            this.Lost_Timer.Interval = 1000;
            this.Lost_Timer.Tick += new System.EventHandler(this.Lost_Timer_Tick);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::baggage_handling_system.Properties.Resources.criss_cross;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(516, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 20;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LostPropertyTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::baggage_handling_system.Properties.Resources.baggageLost;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(553, 711);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnFindLostBaggage);
            this.Controls.Add(this.lblLost);
            this.Controls.Add(this.txtBoxBaggageID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LostPropertyTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LostPropertyTable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindLostBaggage;
        private System.Windows.Forms.Label lblLost;
        private System.Windows.Forms.TextBox txtBoxBaggageID;
        private System.Windows.Forms.Timer Lost_Timer;
        private System.Windows.Forms.Button btnExit;
    }
}