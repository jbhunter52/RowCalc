namespace RowCalc
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
            this.TextBox6 = new System.Windows.Forms.TextBox();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.TextBox500msec = new System.Windows.Forms.TextBox();
            this.TextBox500mmin = new System.Windows.Forms.TextBox();
            this.TextBoxCalhr = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBoxCalMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBox6
            // 
            this.TextBox6.Location = new System.Drawing.Point(106, 162);
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.Size = new System.Drawing.Size(78, 20);
            this.TextBox6.TabIndex = 26;
            // 
            // TextBox5
            // 
            this.TextBox5.Location = new System.Drawing.Point(106, 133);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.Size = new System.Drawing.Size(78, 20);
            this.TextBox5.TabIndex = 25;
            // 
            // TextBox4
            // 
            this.TextBox4.Location = new System.Drawing.Point(106, 104);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.Size = new System.Drawing.Size(78, 20);
            this.TextBox4.TabIndex = 24;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(28, 67);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(72, 13);
            this.Label3.TabIndex = 19;
            this.Label3.Text = "500m min:sec";
            // 
            // TextBox500msec
            // 
            this.TextBox500msec.Location = new System.Drawing.Point(142, 64);
            this.TextBox500msec.Name = "TextBox500msec";
            this.TextBox500msec.Size = new System.Drawing.Size(42, 20);
            this.TextBox500msec.TabIndex = 18;
            // 
            // TextBox500mmin
            // 
            this.TextBox500mmin.Location = new System.Drawing.Point(106, 64);
            this.TextBox500mmin.Name = "TextBox500mmin";
            this.TextBox500mmin.Size = new System.Drawing.Size(30, 20);
            this.TextBox500mmin.TabIndex = 17;
            // 
            // TextBoxCalhr
            // 
            this.TextBoxCalhr.Location = new System.Drawing.Point(106, 12);
            this.TextBoxCalhr.Name = "TextBoxCalhr";
            this.TextBoxCalhr.Size = new System.Drawing.Size(78, 20);
            this.TextBoxCalhr.TabIndex = 15;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(64, 15);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(36, 13);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "Cal/hr";
            // 
            // TextBoxCalMin
            // 
            this.TextBoxCalMin.Location = new System.Drawing.Point(106, 37);
            this.TextBoxCalMin.Name = "TextBoxCalMin";
            this.TextBoxCalMin.Size = new System.Drawing.Size(78, 20);
            this.TextBoxCalMin.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Cal/min";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 267);
            this.Controls.Add(this.TextBoxCalMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox6);
            this.Controls.Add(this.TextBox5);
            this.Controls.Add(this.TextBox4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.TextBox500msec);
            this.Controls.Add(this.TextBox500mmin);
            this.Controls.Add(this.TextBoxCalhr);
            this.Controls.Add(this.Label2);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TextBox6;
        internal System.Windows.Forms.TextBox TextBox5;
        internal System.Windows.Forms.TextBox TextBox4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TextBox500msec;
        internal System.Windows.Forms.TextBox TextBox500mmin;
        internal System.Windows.Forms.TextBox TextBoxCalhr;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TextBoxCalMin;
        internal System.Windows.Forms.Label label1;
    }
}

