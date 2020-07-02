namespace baggage_handling_system
{
    partial class Transfer
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
            this.TransferTimer = new System.Windows.Forms.Timer(this.components);
            this.btnTransfer = new System.Windows.Forms.Button();
            this.picBoxTransfer = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTransfer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TransferTimer
            // 
            this.TransferTimer.Interval = 1000;
            this.TransferTimer.Tick += new System.EventHandler(this.TransferTimer_Tick);
            // 
            // btnTransfer
            // 
            this.btnTransfer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTransfer.Location = new System.Drawing.Point(0, 0);
            this.btnTransfer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(1727, 82);
            this.btnTransfer.TabIndex = 1;
            this.btnTransfer.Text = "Baggages Transfer Process";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // picBoxTransfer
            // 
            this.picBoxTransfer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxTransfer.Location = new System.Drawing.Point(0, 0);
            this.picBoxTransfer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picBoxTransfer.Name = "picBoxTransfer";
            this.picBoxTransfer.Size = new System.Drawing.Size(1727, 937);
            this.picBoxTransfer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxTransfer.TabIndex = 0;
            this.picBoxTransfer.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::baggage_handling_system.Properties.Resources.baggagesTransfer;
            this.pictureBox1.Location = new System.Drawing.Point(0, 82);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1727, 855);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1727, 937);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.picBoxTransfer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Transfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTransfer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer TransferTimer;
        private System.Windows.Forms.PictureBox picBoxTransfer;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}