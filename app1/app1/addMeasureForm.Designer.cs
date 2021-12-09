
namespace app1
{
    partial class addMeasureForm
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
            this.backToLoginBtn = new System.Windows.Forms.Button();
            this.comboBox2Unit = new System.Windows.Forms.ComboBox();
            this.comboBox1daytime = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.newM = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // backToLoginBtn
            // 
            this.backToLoginBtn.BackColor = System.Drawing.Color.White;
            this.backToLoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToLoginBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backToLoginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(130)))));
            this.backToLoginBtn.Location = new System.Drawing.Point(77, 733);
            this.backToLoginBtn.Name = "backToLoginBtn";
            this.backToLoginBtn.Size = new System.Drawing.Size(282, 55);
            this.backToLoginBtn.TabIndex = 27;
            this.backToLoginBtn.Text = "Back to Menu";
            this.backToLoginBtn.UseVisualStyleBackColor = false;
            this.backToLoginBtn.Click += new System.EventHandler(this.backToLoginBtn_Click);
            // 
            // comboBox2Unit
            // 
            this.comboBox2Unit.FormattingEnabled = true;
            this.comboBox2Unit.Items.AddRange(new object[] {
            "mmol/l",
            "mg/dl"});
            this.comboBox2Unit.Location = new System.Drawing.Point(77, 599);
            this.comboBox2Unit.Name = "comboBox2Unit";
            this.comboBox2Unit.Size = new System.Drawing.Size(282, 31);
            this.comboBox2Unit.TabIndex = 26;
            this.comboBox2Unit.Text = "-- Chose Unit --";
            // 
            // comboBox1daytime
            // 
            this.comboBox1daytime.FormattingEnabled = true;
            this.comboBox1daytime.Items.AddRange(new object[] {
            "before breakfast",
            "after breakfast",
            "before dinner",
            "after dinner",
            "before supper",
            "after supper",
            "at night"});
            this.comboBox1daytime.Location = new System.Drawing.Point(77, 445);
            this.comboBox1daytime.Name = "comboBox1daytime";
            this.comboBox1daytime.Size = new System.Drawing.Size(282, 31);
            this.comboBox1daytime.TabIndex = 25;
            this.comboBox1daytime.Text = "-- Chose daytime --";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Location = new System.Drawing.Point(77, 529);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(282, 30);
            this.numericUpDown1.TabIndex = 24;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(77, 362);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(282, 30);
            this.dateTimePicker1.TabIndex = 23;
            // 
            // newM
            // 
            this.newM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(130)))));
            this.newM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newM.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newM.ForeColor = System.Drawing.Color.White;
            this.newM.Location = new System.Drawing.Point(77, 672);
            this.newM.Name = "newM";
            this.newM.Size = new System.Drawing.Size(282, 55);
            this.newM.TabIndex = 21;
            this.newM.Text = "Add";
            this.newM.UseVisualStyleBackColor = false;
            this.newM.Click += new System.EventHandler(this.newM_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 419);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Daytime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 573);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Unit";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(24, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(394, 303);
            this.listBox1.TabIndex = 32;
            // 
            // addMeasureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 800);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backToLoginBtn);
            this.Controls.Add(this.comboBox2Unit);
            this.Controls.Add(this.comboBox1daytime);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.newM);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addMeasureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "newMeasure2";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backToLoginBtn;
        private System.Windows.Forms.ComboBox comboBox2Unit;
        private System.Windows.Forms.ComboBox comboBox1daytime;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button newM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
    }
}