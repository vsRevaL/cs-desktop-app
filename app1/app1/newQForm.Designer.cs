
namespace app1
{
    partial class newQForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.backToLoginBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelAvg = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.avgNum = new System.Windows.Forms.Label();
            this.MinNum = new System.Windows.Forms.Label();
            this.MaxNum = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Today",
            "Yesterday",
            "Last 7 days",
            "Last 30 days",
            "Every measure"});
            this.comboBox1.Location = new System.Drawing.Point(78, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(281, 31);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
            this.label1.Location = new System.Drawing.Point(132, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Chose an option";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
            this.label4.Location = new System.Drawing.Point(78, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "Measures between two dates";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(72, 142);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(287, 30);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(72, 190);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(287, 30);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(84, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 45);
            this.label5.TabIndex = 17;
            this.label5.Text = "-";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(12, 414);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(408, 257);
            this.listBox1.TabIndex = 18;
            // 
            // backToLoginBtn
            // 
            this.backToLoginBtn.BackColor = System.Drawing.Color.White;
            this.backToLoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToLoginBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backToLoginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(130)))));
            this.backToLoginBtn.Location = new System.Drawing.Point(72, 686);
            this.backToLoginBtn.Name = "backToLoginBtn";
            this.backToLoginBtn.Size = new System.Drawing.Size(282, 55);
            this.backToLoginBtn.TabIndex = 30;
            this.backToLoginBtn.Text = "Back to Menu";
            this.backToLoginBtn.UseVisualStyleBackColor = false;
            this.backToLoginBtn.Click += new System.EventHandler(this.backToLoginBtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(130)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(72, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(282, 55);
            this.button3.TabIndex = 31;
            this.button3.Text = "List";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
            this.label2.Location = new System.Drawing.Point(187, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 28);
            this.label2.TabIndex = 32;
            this.label2.Text = "Or";
            // 
            // labelAvg
            // 
            this.labelAvg.AutoSize = true;
            this.labelAvg.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAvg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
            this.labelAvg.Location = new System.Drawing.Point(12, 333);
            this.labelAvg.Name = "labelAvg";
            this.labelAvg.Size = new System.Drawing.Size(90, 28);
            this.labelAvg.TabIndex = 33;
            this.labelAvg.Text = "Average";
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
            this.labelMin.Location = new System.Drawing.Point(144, 333);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(103, 28);
            this.labelMin.TabIndex = 34;
            this.labelMin.Text = "Minimum";
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
            this.labelMax.Location = new System.Drawing.Point(291, 333);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(107, 28);
            this.labelMax.TabIndex = 35;
            this.labelMax.Text = "Maximum";
            // 
            // avgNum
            // 
            this.avgNum.AutoSize = true;
            this.avgNum.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.avgNum.Location = new System.Drawing.Point(12, 361);
            this.avgNum.Name = "avgNum";
            this.avgNum.Size = new System.Drawing.Size(20, 28);
            this.avgNum.TabIndex = 36;
            this.avgNum.Text = "-";
            // 
            // MinNum
            // 
            this.MinNum.AutoSize = true;
            this.MinNum.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MinNum.Location = new System.Drawing.Point(165, 361);
            this.MinNum.Name = "MinNum";
            this.MinNum.Size = new System.Drawing.Size(20, 28);
            this.MinNum.TabIndex = 37;
            this.MinNum.Text = "-";
            // 
            // MaxNum
            // 
            this.MaxNum.AutoSize = true;
            this.MaxNum.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MaxNum.Location = new System.Drawing.Point(301, 361);
            this.MaxNum.Name = "MaxNum";
            this.MaxNum.Size = new System.Drawing.Size(20, 28);
            this.MaxNum.TabIndex = 38;
            this.MaxNum.Text = "-";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(27, 299);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 31);
            this.panel1.TabIndex = 39;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
            this.radioButton2.Location = new System.Drawing.Point(177, 0);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(95, 27);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "mmol/L";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
            this.radioButton1.Location = new System.Drawing.Point(34, 0);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(86, 27);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "mg/dL";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // newQForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 753);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MaxNum);
            this.Controls.Add(this.MinNum);
            this.Controls.Add(this.avgNum);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelAvg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.backToLoginBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "newQForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "newQForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button backToLoginBtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelAvg;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label avgNum;
        private System.Windows.Forms.Label MinNum;
        private System.Windows.Forms.Label MaxNum;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}