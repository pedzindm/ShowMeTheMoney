namespace DBapp
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.custallocationlabel = new System.Windows.Forms.Label();
            this.MainInformationLabel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.SelectButton = new System.Windows.Forms.Button();
            this.RunButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1120, 152);
            this.dataGridView1.TabIndex = 0;
            // 
            // custallocationlabel
            // 
            this.custallocationlabel.AutoSize = true;
            this.custallocationlabel.Location = new System.Drawing.Point(12, 184);
            this.custallocationlabel.Name = "custallocationlabel";
            this.custallocationlabel.Size = new System.Drawing.Size(97, 13);
            this.custallocationlabel.TabIndex = 1;
            this.custallocationlabel.Text = "Allocation DB View";
            // 
            // MainInformationLabel
            // 
            this.MainInformationLabel.AutoSize = true;
            this.MainInformationLabel.Location = new System.Drawing.Point(12, 13);
            this.MainInformationLabel.Name = "MainInformationLabel";
            this.MainInformationLabel.Size = new System.Drawing.Size(85, 13);
            this.MainInformationLabel.TabIndex = 2;
            this.MainInformationLabel.Text = "Main Information";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 201);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1120, 150);
            this.dataGridView2.TabIndex = 3;
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(1057, 357);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(75, 23);
            this.SelectButton.TabIndex = 4;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(1057, 396);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 5;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(588, 359);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(452, 20);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 479);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.MainInformationLabel);
            this.Controls.Add(this.custallocationlabel);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "DB Application";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label custallocationlabel;
        private System.Windows.Forms.Label MainInformationLabel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

