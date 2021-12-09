
namespace app1
{
    partial class editMeasure
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
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.backToLoginBtn = new System.Windows.Forms.Button();
            this.comboBox2Unit = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.comboBox1daytime = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
            this.label3.Location = new System.Drawing.Point(32, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(379, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Pick the measure you want to edit";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(12, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(408, 303);
            this.listBox1.TabIndex = 28;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
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
            this.backToLoginBtn.TabIndex = 29;
            this.backToLoginBtn.Text = "Back to Login";
            this.backToLoginBtn.UseVisualStyleBackColor = false;
            this.backToLoginBtn.Click += new System.EventHandler(this.backToLoginBtn_Click);
            // 
            // comboBox2Unit
            // 
            this.comboBox2Unit.FormattingEnabled = true;
            this.comboBox2Unit.Items.AddRange(new object[] {
            "mmol/l",
            "mg/dl"});
            this.comboBox2Unit.Location = new System.Drawing.Point(72, 568);
            this.comboBox2Unit.Name = "comboBox2Unit";
            this.comboBox2Unit.Size = new System.Drawing.Size(282, 31);
            this.comboBox2Unit.TabIndex = 33;
            this.comboBox2Unit.Text = "-- Chose Unit --";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Location = new System.Drawing.Point(72, 520);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(282, 30);
            this.numericUpDown1.TabIndex = 31;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(72, 423);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(282, 30);
            this.dateTimePicker1.TabIndex = 30;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(130)))));
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Location = new System.Drawing.Point(72, 614);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(282, 55);
            this.SaveBtn.TabIndex = 34;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.newM_Click);
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
            this.comboBox1daytime.Location = new System.Drawing.Point(72, 471);
            this.comboBox1daytime.Name = "comboBox1daytime";
            this.comboBox1daytime.Size = new System.Drawing.Size(282, 31);
            this.comboBox1daytime.TabIndex = 35;
            this.comboBox1daytime.Text = "-- Chose daytime --";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(72, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 28);
            this.label1.TabIndex = 36;
            this.label1.Text = "New attributes:";
            // 
            // editMeasure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1daytime);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.comboBox2Unit);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.backToLoginBtn);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "editMeasure";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "editMeasure";
            this.Load += new System.EventHandler(this.editMeasure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button backToLoginBtn;
        private System.Windows.Forms.ComboBox comboBox2Unit;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ComboBox comboBox1daytime;
        private System.Windows.Forms.Label label1;
    }
}