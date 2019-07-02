namespace RectangleWinFormsGame
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



        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.UpButton = new System.Windows.Forms.Button();
            this.LeftButton = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.DownButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
             
            // panel1
            
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(5, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 344);
            this.panel1.TabIndex = 0;
            
            // UpButton
            
            this.UpButton.Location = new System.Drawing.Point(326, 357);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(81, 24);
            this.UpButton.TabIndex = 1;
            this.UpButton.Text = "Up";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            
            // LeftButton
            
            this.LeftButton.Location = new System.Drawing.Point(279, 387);
            this.LeftButton.Name = "LeftButton";
            this.LeftButton.Size = new System.Drawing.Size(81, 24);
            this.LeftButton.TabIndex = 2;
            this.LeftButton.Text = "Left";
            this.LeftButton.UseVisualStyleBackColor = true;
            this.LeftButton.Click += new System.EventHandler(this.LeftButton_Click);
            
            // RightButton
            
            this.RightButton.Location = new System.Drawing.Point(366, 387);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(81, 24);
            this.RightButton.TabIndex = 3;
            this.RightButton.Text = "Right";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            
            // DownButton
            
            this.DownButton.Location = new System.Drawing.Point(326, 417);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(81, 24);
            this.DownButton.TabIndex = 4;
            this.DownButton.Text = "Down";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            
            // Form1
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 446);
            this.Controls.Add(this.DownButton);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.LeftButton);
            this.Controls.Add(this.UpButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Rectangle Game";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Rectangle1;
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button LeftButton;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Label Rectangle2;
    }
}

