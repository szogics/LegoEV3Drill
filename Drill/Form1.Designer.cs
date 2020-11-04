namespace Drill
{
    partial class btnStartBelt
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStopMotors = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnStopBelt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect to Brick";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(170, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Disconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(305, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "Draw";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(21, 101);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(118, 38);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start drilling";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStopMotors
            // 
            this.btnStopMotors.Location = new System.Drawing.Point(170, 101);
            this.btnStopMotors.Name = "btnStopMotors";
            this.btnStopMotors.Size = new System.Drawing.Size(118, 38);
            this.btnStopMotors.TabIndex = 4;
            this.btnStopMotors.Text = "Stop all motors";
            this.btnStopMotors.UseVisualStyleBackColor = true;
            this.btnStopMotors.Click += new System.EventHandler(this.btnStopMotors_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(305, 101);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 38);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(21, 172);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 44);
            this.button5.TabIndex = 6;
            this.button5.Text = "Move belt";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnStopBelt
            // 
            this.btnStopBelt.Location = new System.Drawing.Point(173, 172);
            this.btnStopBelt.Name = "btnStopBelt";
            this.btnStopBelt.Size = new System.Drawing.Size(115, 44);
            this.btnStopBelt.TabIndex = 7;
            this.btnStopBelt.Text = "StopBelt";
            this.btnStopBelt.UseVisualStyleBackColor = true;
            this.btnStopBelt.Click += new System.EventHandler(this.btnStopBelt_Click);
            // 
            // btnStartBelt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStopBelt);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnStopMotors);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "btnStartBelt";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStopMotors;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnStopBelt;
    }
}

