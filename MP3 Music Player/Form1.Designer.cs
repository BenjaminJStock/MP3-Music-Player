namespace MP3_Player
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
            this.label1 = new System.Windows.Forms.Label();
            this.Open = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(25, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No Mp3 Currently Playing";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(12, 142);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(104, 23);
            this.Open.TabIndex = 1;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Play
            // 
            this.Play.Location = new System.Drawing.Point(147, 142);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(104, 23);
            this.Play.TabIndex = 2;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(280, 142);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(104, 23);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "mp3";
            this.openFileDialog1.Filter = "\"Audio Files|*.mp3;*.wav;*.wmp\";";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Help";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 180);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximumSize = new System.Drawing.Size(412, 219);
            this.MinimumSize = new System.Drawing.Size(412, 219);
            this.Name = "Form1";
            this.Text = "MP3 Music Player v0.01";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

