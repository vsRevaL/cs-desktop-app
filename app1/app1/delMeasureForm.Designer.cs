
namespace app1
{
    partial class delMeasureForm
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.delSelectedBtn = new System.Windows.Forms.Button();
            this.delAllBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backToLoginBtn
            // 
            this.backToLoginBtn.BackColor = System.Drawing.Color.White;
            this.backToLoginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backToLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToLoginBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.backToLoginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(130)))));
            this.backToLoginBtn.Location = new System.Drawing.Point(78, 733);
            this.backToLoginBtn.Name = "backToLoginBtn";
            this.backToLoginBtn.Size = new System.Drawing.Size(282, 55);
            this.backToLoginBtn.TabIndex = 21;
            this.backToLoginBtn.Text = "Back to Menu";
            this.backToLoginBtn.UseVisualStyleBackColor = false;
            this.backToLoginBtn.Click += new System.EventHandler(this.backToLoginBtn_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.White;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkedListBox1.ForeColor = System.Drawing.Color.Black;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 82);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(426, 450);
            this.checkedListBox1.TabIndex = 22;
            // 
            // delSelectedBtn
            // 
            this.delSelectedBtn.BackColor = System.Drawing.Color.Crimson;
            this.delSelectedBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delSelectedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delSelectedBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delSelectedBtn.ForeColor = System.Drawing.Color.White;
            this.delSelectedBtn.Location = new System.Drawing.Point(78, 578);
            this.delSelectedBtn.Name = "delSelectedBtn";
            this.delSelectedBtn.Size = new System.Drawing.Size(282, 55);
            this.delSelectedBtn.TabIndex = 24;
            this.delSelectedBtn.Text = "Delete selected";
            this.delSelectedBtn.UseVisualStyleBackColor = false;
            this.delSelectedBtn.Click += new System.EventHandler(this.delSelectedBtn_Click);
            // 
            // delAllBtn
            // 
            this.delAllBtn.BackColor = System.Drawing.Color.Crimson;
            this.delAllBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delAllBtn.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delAllBtn.ForeColor = System.Drawing.Color.White;
            this.delAllBtn.Location = new System.Drawing.Point(78, 656);
            this.delAllBtn.Name = "delAllBtn";
            this.delAllBtn.Size = new System.Drawing.Size(282, 55);
            this.delAllBtn.TabIndex = 25;
            this.delAllBtn.Text = "Delete all";
            this.delAllBtn.UseVisualStyleBackColor = false;
            this.delAllBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(92)))));
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(433, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Pick the measure(s) you want to delete";
            // 
            // delMeasureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 800);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.delAllBtn);
            this.Controls.Add(this.delSelectedBtn);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.backToLoginBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "delMeasureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "delMeasureForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backToLoginBtn;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button delSelectedBtn;
        private System.Windows.Forms.Button delAllBtn;
        private System.Windows.Forms.Label label3;
    }
}