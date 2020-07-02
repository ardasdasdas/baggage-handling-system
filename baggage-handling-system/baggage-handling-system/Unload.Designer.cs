namespace baggage_handling_system
{
    partial class Unload
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
            this.Unload_Timer = new System.Windows.Forms.Timer(this.components);
            this.btnTransferCheck = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTransfer = new System.Windows.Forms.Label();
            this.lblBaggageTransferText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Unload_Timer
            // 
            this.Unload_Timer.Interval = 1000;
            this.Unload_Timer.Tick += new System.EventHandler(this.Unload_Timer_Tick);
            // 
            // btnTransferCheck
            // 
            this.btnTransferCheck.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTransferCheck.Location = new System.Drawing.Point(0, 759);
            this.btnTransferCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTransferCheck.Name = "btnTransferCheck";
            this.btnTransferCheck.Size = new System.Drawing.Size(1343, 64);
            this.btnTransferCheck.TabIndex = 200;
            this.btnTransferCheck.Text = "Check Baggage Transfer";
            this.btnTransferCheck.UseVisualStyleBackColor = true;
            this.btnTransferCheck.Click += new System.EventHandler(this.btnTransferCheck_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::baggage_handling_system.Properties.Resources.Unloaddd1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1343, 759);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 204;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::baggage_handling_system.Properties.Resources.criss_cross;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(1306, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 205;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTransfer
            // 
            this.lblTransfer.AutoSize = true;
            this.lblTransfer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTransfer.Location = new System.Drawing.Point(182, 716);
            this.lblTransfer.Name = "lblTransfer";
            this.lblTransfer.Size = new System.Drawing.Size(256, 25);
            this.lblTransfer.TabIndex = 202;
            this.lblTransfer.Text = "Your baggage will go to the  ";
            // 
            // lblBaggageTransferText
            // 
            this.lblBaggageTransferText.AutoSize = true;
            this.lblBaggageTransferText.BackColor = System.Drawing.Color.Transparent;
            this.lblBaggageTransferText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBaggageTransferText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaggageTransferText.Location = new System.Drawing.Point(454, 716);
            this.lblBaggageTransferText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBaggageTransferText.Name = "lblBaggageTransferText";
            this.lblBaggageTransferText.Size = new System.Drawing.Size(0, 25);
            this.lblBaggageTransferText.TabIndex = 203;
            // 
            // Unload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 823);
            this.Controls.Add(this.lblBaggageTransferText);
            this.Controls.Add(this.lblTransfer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTransferCheck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Unload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unload";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Unload_Timer;
        private System.Windows.Forms.Button btnTransferCheck;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTransfer;
        private System.Windows.Forms.Label lblBaggageTransferText;
    }
}