namespace ShowMeTheMoney
{
    partial class Bonds
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
            this.Bondname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.interestrate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.enddate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.startdate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.principle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.insertbutton = new System.Windows.Forms.Button();
            this.bondtype = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.riskvalue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bondname
            // 
            this.Bondname.Location = new System.Drawing.Point(12, 207);
            this.Bondname.Name = "Bondname";
            this.Bondname.Size = new System.Drawing.Size(100, 20);
            this.Bondname.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Bond Name";
            // 
            // interestrate
            // 
            this.interestrate.Location = new System.Drawing.Point(12, 153);
            this.interestrate.Name = "interestrate";
            this.interestrate.Size = new System.Drawing.Size(100, 20);
            this.interestrate.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "interest Rate(ie .06 for 6%)";
            // 
            // enddate
            // 
            this.enddate.Location = new System.Drawing.Point(12, 110);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(212, 20);
            this.enddate.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "End Date";
            // 
            // startdate
            // 
            this.startdate.Location = new System.Drawing.Point(12, 65);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(212, 20);
            this.startdate.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Start Date";
            // 
            // principle
            // 
            this.principle.Location = new System.Drawing.Point(12, 21);
            this.principle.Name = "principle";
            this.principle.Size = new System.Drawing.Size(100, 20);
            this.principle.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Principle";
            // 
            // insertbutton
            // 
            this.insertbutton.Location = new System.Drawing.Point(352, 314);
            this.insertbutton.Name = "insertbutton";
            this.insertbutton.Size = new System.Drawing.Size(75, 21);
            this.insertbutton.TabIndex = 21;
            this.insertbutton.Text = "Insert";
            this.insertbutton.UseVisualStyleBackColor = true;
            this.insertbutton.Click += new System.EventHandler(this.insertbutton_Click_1);
            // 
            // bondtype
            // 
            this.bondtype.Location = new System.Drawing.Point(164, 207);
            this.bondtype.Name = "bondtype";
            this.bondtype.Size = new System.Drawing.Size(100, 20);
            this.bondtype.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Bond Type(IE Federal)";
            // 
            // riskvalue
            // 
            this.riskvalue.Location = new System.Drawing.Point(12, 255);
            this.riskvalue.Name = "riskvalue";
            this.riskvalue.Size = new System.Drawing.Size(100, 20);
            this.riskvalue.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Risk Value(ie .02)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(135, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "A field is not valid";
            this.label8.Visible = false;
            // 
            // Bonds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 347);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.riskvalue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bondtype);
            this.Controls.Add(this.insertbutton);
            this.Controls.Add(this.Bondname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.interestrate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.enddate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.principle);
            this.Controls.Add(this.label1);
            this.Name = "Bonds";
            this.Text = "Bonds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Bondname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox interestrate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker enddate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker startdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox principle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insertbutton;
        private System.Windows.Forms.TextBox bondtype;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox riskvalue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}