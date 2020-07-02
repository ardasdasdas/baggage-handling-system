namespace baggage_handling_system
{
    partial class Security
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
            this.btnExit = new System.Windows.Forms.Button();
            this.timerSecurity = new System.Windows.Forms.Timer(this.components);
            this.btnDiscard = new System.Windows.Forms.Button();
            this.btnSecurity = new System.Windows.Forms.Button();
            this.txtSuspicious = new System.Windows.Forms.TextBox();
            this.lblSuspicious = new System.Windows.Forms.Label();
            this.pBoxSecurity = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSecurity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::baggage_handling_system.Properties.Resources.criss_cross;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(502, 9);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(19, 20);
            this.btnExit.TabIndex = 20;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timerSecurity
            // 
            this.timerSecurity.Interval = 2000;
            this.timerSecurity.Tick += new System.EventHandler(this.timerSecurity_Tick);
            // 
            // btnDiscard
            // 
            this.btnDiscard.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnDiscard.Location = new System.Drawing.Point(364, 111);
            this.btnDiscard.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(149, 41);
            this.btnDiscard.TabIndex = 8;
            this.btnDiscard.Text = "Discard";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Visible = false;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // btnSecurity
            // 
            this.btnSecurity.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSecurity.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnSecurity.Location = new System.Drawing.Point(143, 9);
            this.btnSecurity.Margin = new System.Windows.Forms.Padding(2);
            this.btnSecurity.Name = "btnSecurity";
            this.btnSecurity.Size = new System.Drawing.Size(197, 42);
            this.btnSecurity.TabIndex = 7;
            this.btnSecurity.Text = "Security Control";
            this.btnSecurity.UseVisualStyleBackColor = true;
            this.btnSecurity.Click += new System.EventHandler(this.btnSecurity_Click);
            // 
            // txtSuspicious
            // 
            this.txtSuspicious.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSuspicious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSuspicious.Location = new System.Drawing.Point(132, 72);
            this.txtSuspicious.Margin = new System.Windows.Forms.Padding(2);
            this.txtSuspicious.Name = "txtSuspicious";
            this.txtSuspicious.Size = new System.Drawing.Size(389, 19);
            this.txtSuspicious.TabIndex = 6;
            // 
            // lblSuspicious
            // 
            this.lblSuspicious.AutoSize = true;
            this.lblSuspicious.BackColor = System.Drawing.Color.Transparent;
            this.lblSuspicious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSuspicious.Location = new System.Drawing.Point(4, 72);
            this.lblSuspicious.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuspicious.Name = "lblSuspicious";
            this.lblSuspicious.Size = new System.Drawing.Size(125, 20);
            this.lblSuspicious.TabIndex = 5;
            this.lblSuspicious.Text = "Your baggage is";
            // 
            // pBoxSecurity
            // 
            this.pBoxSecurity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxSecurity.Location = new System.Drawing.Point(0, -1);
            this.pBoxSecurity.Margin = new System.Windows.Forms.Padding(2);
            this.pBoxSecurity.Name = "pBoxSecurity";
            this.pBoxSecurity.Size = new System.Drawing.Size(527, 479);
            this.pBoxSecurity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxSecurity.TabIndex = 0;
            this.pBoxSecurity.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::baggage_handling_system.Properties.Resources.luggage1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::baggage_handling_system.Properties.Resources.luggage11;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(526, 477);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Security
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(526, 477);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDiscard);
            this.Controls.Add(this.btnSecurity);
            this.Controls.Add(this.txtSuspicious);
            this.Controls.Add(this.lblSuspicious);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pBoxSecurity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Security";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Security";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxSecurity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timerSecurity;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.Button btnSecurity;
        private System.Windows.Forms.TextBox txtSuspicious;
        private System.Windows.Forms.Label lblSuspicious;
        private System.Windows.Forms.PictureBox pBoxSecurity;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}