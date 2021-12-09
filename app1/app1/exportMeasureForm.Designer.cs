
namespace app1
{
    partial class exportMeasureForm
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
            this.exportAllBtn = new System.Windows.Forms.Button();
            this.exportSelectedBtn = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.backToLoginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
            this.label3.Location = new System.Drawing.Point(9, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(435, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Pick the measure(s) you want to export";
            // 
            // exportAllBtn
            // 
            this.exportAllBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(130)))));
            this.exportAllBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportAllBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exportAllBtn.ForeColor = System.Drawing.Color.White;
            this.exportAllBtn.Location = new System.Drawing.Point(75, 634);
            this.exportAllBtn.Name = "exportAllBtn";
            this.exportAllBtn.Size = new System.Drawing.Size(282, 55);
            this.exportAllBtn.TabIndex = 30;
            this.exportAllBtn.Text = "Export all";
            this.exportAllBtn.UseVisualStyleBackColor = false;
            this.exportAllBtn.Click += new System.EventHandler(this.exportAllBtn_Click);
            // 
            // exportSelectedBtn
            // 
            this.exportSelectedBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(130)))));
            this.exportSelectedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportSelectedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportSelectedBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exportSelectedBtn.ForeColor = System.Drawing.Color.White;
            this.exportSelectedBtn.Location = new System.Drawing.Point(75, 553);
            this.exportSelectedBtn.Name = "exportSelectedBtn";
            this.exportSelectedBtn.Size = new System.Drawing.Size(282, 55);
            this.exportSelectedBtn.TabIndex = 29;
            this.exportSelectedBtn.Text = "Export selected";
            this.exportSelectedBtn.UseVisualStyleBackColor = false;
            this.exportSelectedBtn.Click += new System.EventHandler(this.exportSelectedBtn_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.White;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkedListBox1.ForeColor = System.Drawing.Color.Black;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(9, 65);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(426, 450);
            this.checkedListBox1.TabIndex = 28;
            // 
            // backToLoginBtn
            // 
            this.backToLoginBtn.BackColor = System.Drawing.Color.White;
            this.backToLoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToLoginBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backToLoginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(130)))));
            this.backToLoginBtn.Location = new System.Drawing.Point(75, 716);
            this.backToLoginBtn.Name = "backToLoginBtn";
            this.backToLoginBtn.Size = new System.Drawing.Size(282, 55);
            this.backToLoginBtn.TabIndex = 27;
            this.backToLoginBtn.Text = "Back to Menu";
            this.backToLoginBtn.UseVisualStyleBackColor = false;
            this.backToLoginBtn.Click += new System.EventHandler(this.backToLoginBtn_Click);
            // 
            // exportMeasureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 800);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exportAllBtn);
            this.Controls.Add(this.exportSelectedBtn);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.backToLoginBtn);
            this.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "exportMeasureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "exportMeasureForm";
            this.Load += new System.EventHandler(this.exportMeasureForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exportAllBtn;
        private System.Windows.Forms.Button exportSelectedBtn;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button backToLoginBtn;
    }
}