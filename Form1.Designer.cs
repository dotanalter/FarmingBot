namespace FarmingBot
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pqsnumber = new System.Windows.Forms.Label();
            this.nxgot = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timestart = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lastpq = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pqtimelast = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.detectedcount = new System.Windows.Forms.Label();
            this.bp = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PQs DID:";
            // 
            // pqsnumber
            // 
            this.pqsnumber.AutoSize = true;
            this.pqsnumber.Location = new System.Drawing.Point(97, 42);
            this.pqsnumber.Name = "pqsnumber";
            this.pqsnumber.Size = new System.Drawing.Size(13, 13);
            this.pqsnumber.TabIndex = 2;
            this.pqsnumber.Text = "0";
            // 
            // nxgot
            // 
            this.nxgot.AutoSize = true;
            this.nxgot.Location = new System.Drawing.Point(97, 73);
            this.nxgot.Name = "nxgot";
            this.nxgot.Size = new System.Drawing.Size(13, 13);
            this.nxgot.TabIndex = 4;
            this.nxgot.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "NX got:";
            // 
            // timestart
            // 
            this.timestart.AutoSize = true;
            this.timestart.Location = new System.Drawing.Point(173, 240);
            this.timestart.Name = "timestart";
            this.timestart.Size = new System.Drawing.Size(13, 13);
            this.timestart.TabIndex = 6;
            this.timestart.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Start Time:";
            // 
            // lastpq
            // 
            this.lastpq.AutoSize = true;
            this.lastpq.Location = new System.Drawing.Point(118, 103);
            this.lastpq.Name = "lastpq";
            this.lastpq.Size = new System.Drawing.Size(13, 13);
            this.lastpq.TabIndex = 8;
            this.lastpq.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Last PQ time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Last PQ time:";
            // 
            // pqtimelast
            // 
            this.pqtimelast.AutoSize = true;
            this.pqtimelast.Location = new System.Drawing.Point(118, 131);
            this.pqtimelast.Name = "pqtimelast";
            this.pqtimelast.Size = new System.Drawing.Size(13, 13);
            this.pqtimelast.TabIndex = 10;
            this.pqtimelast.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Lie Bot Detected:";
            // 
            // detectedcount
            // 
            this.detectedcount.AutoSize = true;
            this.detectedcount.Location = new System.Drawing.Point(141, 18);
            this.detectedcount.Name = "detectedcount";
            this.detectedcount.Size = new System.Drawing.Size(13, 13);
            this.detectedcount.TabIndex = 12;
            this.detectedcount.Text = "0";
            // 
            // bp
            // 
            this.bp.AutoSize = true;
            this.bp.Location = new System.Drawing.Point(203, 18);
            this.bp.Name = "bp";
            this.bp.Size = new System.Drawing.Size(13, 13);
            this.bp.TabIndex = 14;
            this.bp.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(173, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "BP:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(206, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 28);
            this.button2.TabIndex = 15;
            this.button2.Text = "exit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "label7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.detectedcount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pqtimelast);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastpq);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timestart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nxgot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pqsnumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Faq u ellinia ya fatma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pqsnumber;
        private System.Windows.Forms.Label nxgot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timestart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lastpq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pqtimelast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label detectedcount;
        private System.Windows.Forms.Label bp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
    }
}

