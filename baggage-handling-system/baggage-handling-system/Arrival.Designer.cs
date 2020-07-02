namespace baggage_handling_system
{
    partial class Arrival
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arrival));
            this.btnArrival = new System.Windows.Forms.Button();
            this.ArrivalTimer = new System.Windows.Forms.Timer(this.components);
            this.lblBaggage = new System.Windows.Forms.Label();
            this.txtboxBaggageID = new System.Windows.Forms.TextBox();
            this.pnlBaggagesName = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnArrival
            // 
            this.btnArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnArrival.Location = new System.Drawing.Point(547, 593);
            this.btnArrival.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnArrival.Name = "btnArrival";
            this.btnArrival.Size = new System.Drawing.Size(209, 39);
            this.btnArrival.TabIndex = 1;
            this.btnArrival.Text = "Arrival";
            this.btnArrival.UseVisualStyleBackColor = true;
            this.btnArrival.Click += new System.EventHandler(this.btnArrival_Click);
            // 
            // ArrivalTimer
            // 
            this.ArrivalTimer.Interval = 1000;
            this.ArrivalTimer.Tick += new System.EventHandler(this.ArrivalTimer_Tick);
            // 
            // lblBaggage
            // 
            this.lblBaggage.AutoSize = true;
            this.lblBaggage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaggage.Location = new System.Drawing.Point(12, 600);
            this.lblBaggage.Name = "lblBaggage";
            this.lblBaggage.Size = new System.Drawing.Size(262, 25);
            this.lblBaggage.TabIndex = 3;
            this.lblBaggage.Text = "Enter Your Baggages ID (,) : ";
            // 
            // txtboxBaggageID
            // 
            this.txtboxBaggageID.BackColor = System.Drawing.Color.White;
            this.txtboxBaggageID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxBaggageID.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic);
            this.txtboxBaggageID.Location = new System.Drawing.Point(298, 604);
            this.txtboxBaggageID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxBaggageID.Name = "txtboxBaggageID";
            this.txtboxBaggageID.Size = new System.Drawing.Size(137, 21);
            this.txtboxBaggageID.TabIndex = 2;
            // 
            // pnlBaggagesName
            // 
            this.pnlBaggagesName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlBaggagesName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlBaggagesName.Location = new System.Drawing.Point(298, 624);
            this.pnlBaggagesName.Name = "pnlBaggagesName";
            this.pnlBaggagesName.Size = new System.Drawing.Size(137, 1);
            this.pnlBaggagesName.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(298, 624);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 1);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(780, 577);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::baggage_handling_system.Properties.Resources.criss_cross;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(749, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 17;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Arrival
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(786, 654);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlBaggagesName);
            this.Controls.Add(this.lblBaggage);
            this.Controls.Add(this.txtboxBaggageID);
            this.Controls.Add(this.btnArrival);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Arrival";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arrival";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnArrival;
        private System.Windows.Forms.Timer ArrivalTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBaggage;
        private System.Windows.Forms.TextBox txtboxBaggageID;
        private System.Windows.Forms.Panel pnlBaggagesName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
    }
}