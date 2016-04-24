namespace SlotMachineGUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imgBox1 = new System.Windows.Forms.PictureBox();
            this.imgBox2 = new System.Windows.Forms.PictureBox();
            this.imgBox3 = new System.Windows.Forms.PictureBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblPoints = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            this.lblJackpot = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // imgBox1
            // 
            this.imgBox1.Image = global::SlotMachineGUI.Properties.Resources.sealsinger;
            this.imgBox1.Location = new System.Drawing.Point(12, 66);
            this.imgBox1.Name = "imgBox1";
            this.imgBox1.Size = new System.Drawing.Size(252, 273);
            this.imgBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBox1.TabIndex = 0;
            this.imgBox1.TabStop = false;
            // 
            // imgBox2
            // 
            this.imgBox2.Image = ((System.Drawing.Image)(resources.GetObject("imgBox2.Image")));
            this.imgBox2.Location = new System.Drawing.Point(285, 66);
            this.imgBox2.Name = "imgBox2";
            this.imgBox2.Size = new System.Drawing.Size(246, 273);
            this.imgBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBox2.TabIndex = 1;
            this.imgBox2.TabStop = false;
            // 
            // imgBox3
            // 
            this.imgBox3.Image = ((System.Drawing.Image)(resources.GetObject("imgBox3.Image")));
            this.imgBox3.Location = new System.Drawing.Point(557, 66);
            this.imgBox3.Name = "imgBox3";
            this.imgBox3.Size = new System.Drawing.Size(246, 273);
            this.imgBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBox3.TabIndex = 2;
            this.imgBox3.TabStop = false;
            // 
            // btnPlay
            // 
            this.btnPlay.AutoSize = true;
            this.btnPlay.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(361, 397);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 43);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(605, 522);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(198, 43);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear my score...";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Visible = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(12, 533);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(0, 32);
            this.lblPoints.TabIndex = 5;
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResults.Location = new System.Drawing.Point(15, 464);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(0, 32);
            this.lblResults.TabIndex = 6;
            // 
            // lblJackpot
            // 
            this.lblJackpot.AutoSize = true;
            this.lblJackpot.BackColor = System.Drawing.Color.Transparent;
            this.lblJackpot.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJackpot.ForeColor = System.Drawing.Color.Black;
            this.lblJackpot.Location = new System.Drawing.Point(310, 9);
            this.lblJackpot.Name = "lblJackpot";
            this.lblJackpot.Size = new System.Drawing.Size(0, 28);
            this.lblJackpot.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SlotMachineGUI.Properties.Resources.SealHabitat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 577);
            this.Controls.Add(this.lblJackpot);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.imgBox3);
            this.Controls.Add(this.imgBox2);
            this.Controls.Add(this.imgBox1);
            this.Name = "Form1";
            this.Text = "Slot Machine GUI - David Palermo";
            ((System.ComponentModel.ISupportInitialize)(this.imgBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBox1;
        private System.Windows.Forms.PictureBox imgBox2;
        private System.Windows.Forms.PictureBox imgBox3;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Label lblJackpot;
    }
}

