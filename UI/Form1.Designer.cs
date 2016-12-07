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
            this.label2 = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.bodyBox = new System.Windows.Forms.TextBox();
            this.idTxt = new System.Windows.Forms.Label();
            this.titleTxt = new System.Windows.Forms.Label();
            this.bodyTxt = new System.Windows.Forms.Label();
            this.postDocBtn = new System.Windows.Forms.Button();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter document info";
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(253, 29);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(100, 20);
            this.idText.TabIndex = 7;
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(253, 55);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(100, 20);
            this.titleBox.TabIndex = 8;
            // 
            // bodyBox
            // 
            this.bodyBox.Location = new System.Drawing.Point(253, 81);
            this.bodyBox.Name = "bodyBox";
            this.bodyBox.Size = new System.Drawing.Size(100, 20);
            this.bodyBox.TabIndex = 9;
            // 
            // idTxt
            // 
            this.idTxt.AutoSize = true;
            this.idTxt.Location = new System.Drawing.Point(190, 32);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(16, 13);
            this.idTxt.TabIndex = 10;
            this.idTxt.Text = "Id";
            // 
            // titleTxt
            // 
            this.titleTxt.AutoSize = true;
            this.titleTxt.Location = new System.Drawing.Point(190, 60);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.Size = new System.Drawing.Size(27, 13);
            this.titleTxt.TabIndex = 11;
            this.titleTxt.Text = "Title";
            // 
            // bodyTxt
            // 
            this.bodyTxt.AutoSize = true;
            this.bodyTxt.Location = new System.Drawing.Point(190, 84);
            this.bodyTxt.Name = "bodyTxt";
            this.bodyTxt.Size = new System.Drawing.Size(31, 13);
            this.bodyTxt.TabIndex = 12;
            this.bodyTxt.Text = "Body";
            // 
            // postDocBtn
            // 
            this.postDocBtn.Location = new System.Drawing.Point(253, 107);
            this.postDocBtn.Name = "postDocBtn";
            this.postDocBtn.Size = new System.Drawing.Size(75, 23);
            this.postDocBtn.TabIndex = 13;
            this.postDocBtn.Text = "Post";
            this.postDocBtn.UseVisualStyleBackColor = true;
            this.postDocBtn.Click += new System.EventHandler(this.postDocBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 261);
            this.Controls.Add(this.postDocBtn);
            this.Controls.Add(this.bodyTxt);
            this.Controls.Add(this.titleTxt);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.bodyBox);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox bodyBox;
        private System.Windows.Forms.Label idTxt;
        private System.Windows.Forms.Label titleTxt;
        private System.Windows.Forms.Label bodyTxt;
        private System.Windows.Forms.Button postDocBtn;
    }
}

