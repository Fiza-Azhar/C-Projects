
namespace appllication1
{
    partial class Form3
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.Gbutton = new System.Windows.Forms.Button();
            this.Fbutton = new System.Windows.Forms.Button();
            this.Cbutton = new System.Windows.Forms.Button();
            this.LDetails = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Gbutton);
            this.panel1.Controls.Add(this.Fbutton);
            this.panel1.Controls.Add(this.Cbutton);
            this.panel1.Controls.Add(this.LDetails);
            this.panel1.Location = new System.Drawing.Point(24, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 410);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.CadetBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(349, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Gbutton
            // 
            this.Gbutton.BackColor = System.Drawing.Color.GhostWhite;
            this.Gbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gbutton.Location = new System.Drawing.Point(142, 264);
            this.Gbutton.Name = "Gbutton";
            this.Gbutton.Size = new System.Drawing.Size(151, 49);
            this.Gbutton.TabIndex = 12;
            this.Gbutton.Text = "Grocery";
            this.Gbutton.UseVisualStyleBackColor = false;
            // 
            // Fbutton
            // 
            this.Fbutton.BackColor = System.Drawing.Color.GhostWhite;
            this.Fbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fbutton.Location = new System.Drawing.Point(142, 187);
            this.Fbutton.Name = "Fbutton";
            this.Fbutton.Size = new System.Drawing.Size(152, 50);
            this.Fbutton.TabIndex = 11;
            this.Fbutton.Text = "Food";
            this.Fbutton.UseVisualStyleBackColor = false;
            // 
            // Cbutton
            // 
            this.Cbutton.BackColor = System.Drawing.Color.GhostWhite;
            this.Cbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cbutton.Location = new System.Drawing.Point(142, 114);
            this.Cbutton.Name = "Cbutton";
            this.Cbutton.Size = new System.Drawing.Size(152, 49);
            this.Cbutton.TabIndex = 10;
            this.Cbutton.Text = "Clothes";
            this.Cbutton.UseVisualStyleBackColor = false;
            this.Cbutton.Click += new System.EventHandler(this.Cbutton_Click);
            // 
            // LDetails
            // 
            this.LDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LDetails.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDetails.Location = new System.Drawing.Point(21, 26);
            this.LDetails.Name = "LDetails";
            this.LDetails.Padding = new System.Windows.Forms.Padding(100, 10, 0, 0);
            this.LDetails.Size = new System.Drawing.Size(477, 57);
            this.LDetails.TabIndex = 9;
            this.LDetails.Text = "Select Item Catagory";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::appllication1.Properties.Resources.images__7_;
            this.pictureBox1.Location = new System.Drawing.Point(572, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 24);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(100, 10, 0, 0);
            this.label1.Size = new System.Drawing.Size(477, 57);
            this.label1.TabIndex = 10;
            this.label1.Text = "SHOPPING CENTER";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(849, 526);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LDetails;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Gbutton;
        private System.Windows.Forms.Button Fbutton;
        private System.Windows.Forms.Button Cbutton;
        private System.Windows.Forms.Button button1;
    }
}