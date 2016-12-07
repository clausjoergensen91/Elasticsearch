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
            this.button1 = new System.Windows.Forms.Button();
            this.postBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Create node";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // postBtn
            // 
            this.postBtn.Location = new System.Drawing.Point(240, 142);
            this.postBtn.Name = "postBtn";
            this.postBtn.Size = new System.Drawing.Size(75, 23);
            this.postBtn.TabIndex = 6;
            this.postBtn.Text = "Post";
            this.postBtn.UseVisualStyleBackColor = true;
            this.postBtn.Click += new System.EventHandler(this.postBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Title";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Text";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(240, 36);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 10;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(240, 63);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitle.TabIndex = 11;
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(240, 86);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(100, 20);
            this.textBoxText.TabIndex = 12;
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Location = new System.Drawing.Point(240, 13);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(100, 20);
            this.textBoxIndex.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 261);
            this.Controls.Add(this.textBoxIndex);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.postBtn);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button postBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxText;
        private System.Windows.Forms.TextBox textBoxIndex;
    }
}

