namespace ClockApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ConsoleTextBox = new System.Windows.Forms.RichTextBox();
            this.DecTime = new System.Windows.Forms.TextBox();
            this.Bintime = new System.Windows.Forms.TextBox();
            this.OctTime = new System.Windows.Forms.TextBox();
            this.HexTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.DecDate = new System.Windows.Forms.TextBox();
            this.BinDate = new System.Windows.Forms.TextBox();
            this.OctDate = new System.Windows.Forms.TextBox();
            this.HexDate = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // ConsoleTextBox
            // 
            this.ConsoleTextBox.Location = new System.Drawing.Point(485, 244);
            this.ConsoleTextBox.Name = "ConsoleTextBox";
            this.ConsoleTextBox.Size = new System.Drawing.Size(303, 144);
            this.ConsoleTextBox.TabIndex = 0;
            this.ConsoleTextBox.Text = "";
            // 
            // DecTime
            // 
            this.DecTime.Location = new System.Drawing.Point(8, 59);
            this.DecTime.Name = "DecTime";
            this.DecTime.Size = new System.Drawing.Size(335, 23);
            this.DecTime.TabIndex = 1;
            // 
            // Bintime
            // 
            this.Bintime.Location = new System.Drawing.Point(8, 141);
            this.Bintime.Name = "Bintime";
            this.Bintime.Size = new System.Drawing.Size(335, 23);
            this.Bintime.TabIndex = 2;
            // 
            // OctTime
            // 
            this.OctTime.Location = new System.Drawing.Point(8, 217);
            this.OctTime.Name = "OctTime";
            this.OctTime.Size = new System.Drawing.Size(335, 23);
            this.OctTime.TabIndex = 3;
            // 
            // HexTime
            // 
            this.HexTime.Location = new System.Drawing.Point(8, 288);
            this.HexTime.Name = "HexTime";
            this.HexTime.Size = new System.Drawing.Size(335, 23);
            this.HexTime.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Decimal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bineary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Octal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hexidecimal";
            // 
            // RefreshTimer
            // 
            this.RefreshTimer.Enabled = true;
            this.RefreshTimer.Interval = 490;
            this.RefreshTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DecDate
            // 
            this.DecDate.Location = new System.Drawing.Point(8, 88);
            this.DecDate.Name = "DecDate";
            this.DecDate.Size = new System.Drawing.Size(335, 23);
            this.DecDate.TabIndex = 9;
            // 
            // BinDate
            // 
            this.BinDate.Location = new System.Drawing.Point(8, 170);
            this.BinDate.Name = "BinDate";
            this.BinDate.Size = new System.Drawing.Size(335, 23);
            this.BinDate.TabIndex = 10;
            // 
            // OctDate
            // 
            this.OctDate.Location = new System.Drawing.Point(8, 244);
            this.OctDate.Name = "OctDate";
            this.OctDate.Size = new System.Drawing.Size(335, 23);
            this.OctDate.TabIndex = 11;
            // 
            // HexDate
            // 
            this.HexDate.Location = new System.Drawing.Point(8, 317);
            this.HexDate.Name = "HexDate";
            this.HexDate.Size = new System.Drawing.Size(335, 23);
            this.HexDate.TabIndex = 12;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(8, 362);
            this.progressBar1.MarqueeAnimationSpeed = 300;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(361, 23);
            this.progressBar1.Step = 20;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.HexDate);
            this.Controls.Add(this.OctDate);
            this.Controls.Add(this.BinDate);
            this.Controls.Add(this.DecDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HexTime);
            this.Controls.Add(this.OctTime);
            this.Controls.Add(this.Bintime);
            this.Controls.Add(this.DecTime);
            this.Controls.Add(this.ConsoleTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ConsoleTextBox;
        private System.Windows.Forms.TextBox DecTime;
        private System.Windows.Forms.TextBox Bintime;
        private System.Windows.Forms.TextBox OctTime;
        private System.Windows.Forms.TextBox HexTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer RefreshTimer;
        private System.Windows.Forms.TextBox DecDate;
        private System.Windows.Forms.TextBox BinDate;
        private System.Windows.Forms.TextBox OctDate;
        private System.Windows.Forms.TextBox HexDate;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}
