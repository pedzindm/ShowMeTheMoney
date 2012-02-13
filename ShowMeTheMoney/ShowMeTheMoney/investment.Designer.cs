namespace ShowMeTheMoney
{
    partial class investment
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
            this.principle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startdate = new System.Windows.Forms.DateTimePicker();
            this.enddate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.interestrate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Bankname = new System.Windows.Forms.TextBox();
            this.insertbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Principle";
            // 
            // principle
            // 
            this.principle.Location = new System.Drawing.Point(7, 30);
            this.principle.Name = "principle";
            this.principle.Size = new System.Drawing.Size(100, 20);
            this.principle.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Date";
            // 
            // startdate
            // 
            this.startdate.Location = new System.Drawing.Point(7, 74);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(212, 20);
            this.startdate.TabIndex = 3;
            // 
            // enddate
            // 
            this.enddate.Location = new System.Drawing.Point(7, 119);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(212, 20);
            this.enddate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "interest Rate(ie .06 for 6%)";
            // 
            // interestrate
            // 
            this.interestrate.Location = new System.Drawing.Point(7, 162);
            this.interestrate.Name = "interestrate";
            this.interestrate.Size = new System.Drawing.Size(100, 20);
            this.interestrate.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bank Name";
            // 
            // Bankname
            // 
            this.Bankname.Location = new System.Drawing.Point(7, 216);
            this.Bankname.Name = "Bankname";
            this.Bankname.Size = new System.Drawing.Size(100, 20);
            this.Bankname.TabIndex = 10;
            // 
            // insertbutton
            // 
            this.insertbutton.Location = new System.Drawing.Point(396, 353);
            this.insertbutton.Name = "insertbutton";
            this.insertbutton.Size = new System.Drawing.Size(75, 23);
            this.insertbutton.TabIndex = 11;
            this.insertbutton.Text = "Insert";
            this.insertbutton.UseVisualStyleBackColor = true;
            this.insertbutton.Click += new System.EventHandler(this.insertbutton_Click);
            // 
            // investment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 388);
            this.Controls.Add(this.insertbutton);
            this.Controls.Add(this.Bankname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.interestrate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.enddate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.startdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.principle);
            this.Controls.Add(this.label1);
            this.Name = "investment";
            this.Text = "investment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox principle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker startdate;
        private System.Windows.Forms.DateTimePicker enddate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox interestrate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Bankname;
        private System.Windows.Forms.Button insertbutton;
    }
}