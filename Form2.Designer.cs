namespace NoteTaking
{
    partial class Form2
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
            this.SaveBtn = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.content1 = new System.Windows.Forms.RichTextBox();
            this.title1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(55, 289);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(136, 289);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 1;
            this.Back.Text = "Back to All";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // content1
            // 
            this.content1.Location = new System.Drawing.Point(55, 154);
            this.content1.Name = "content1";
            this.content1.Size = new System.Drawing.Size(252, 96);
            this.content1.TabIndex = 2;
            this.content1.Text = "";
            // 
            // title1
            // 
            this.title1.Location = new System.Drawing.Point(55, 107);
            this.title1.Name = "title1";
            this.title1.PlaceholderText = "Title";
            this.title1.Size = new System.Drawing.Size(100, 23);
            this.title1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(395, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "Share your thoughts!";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 394);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title1);
            this.Controls.Add(this.content1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.SaveBtn);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button SaveBtn;
        private Button Back;
        private RichTextBox content1;
        private TextBox title1;
        private Label label1;
    }
}