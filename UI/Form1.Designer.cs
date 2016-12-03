namespace UI
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
            this.CreateIndexBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteIndexBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateIndexBtn
            // 
            this.CreateIndexBtn.Location = new System.Drawing.Point(12, 55);
            this.CreateIndexBtn.Name = "CreateIndexBtn";
            this.CreateIndexBtn.Size = new System.Drawing.Size(100, 23);
            this.CreateIndexBtn.TabIndex = 0;
            this.CreateIndexBtn.Text = "Create Index";
            this.CreateIndexBtn.UseVisualStyleBackColor = true;
            this.CreateIndexBtn.Click += new System.EventHandler(this.CreateIndexBtn_click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Elasticsearch Index Name";
            // 
            // DeleteIndexBtn
            // 
            this.DeleteIndexBtn.Location = new System.Drawing.Point(12, 84);
            this.DeleteIndexBtn.Name = "DeleteIndexBtn";
            this.DeleteIndexBtn.Size = new System.Drawing.Size(100, 23);
            this.DeleteIndexBtn.TabIndex = 3;
            this.DeleteIndexBtn.Text = "Delete Index";
            this.DeleteIndexBtn.UseVisualStyleBackColor = true;
            this.DeleteIndexBtn.Click += new System.EventHandler(this.DeleteIndexBtn_click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(464, 226);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 4;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 261);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.DeleteIndexBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CreateIndexBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateIndexBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeleteIndexBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}

