namespace NoteTaking
{
    partial class Form1 : Form
    {
        private ListView listViewNotes;
        private Button buttonCreateNote;
        private Button btnDelete;

        private void InitializeComponent()
        {
            this.listViewNotes = new System.Windows.Forms.ListView();
            this.buttonCreateNote = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.view = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewNotes
            // 
            this.listViewNotes.Location = new System.Drawing.Point(0, 145);
            this.listViewNotes.Name = "listViewNotes";
            this.listViewNotes.Size = new System.Drawing.Size(517, 200);
            this.listViewNotes.TabIndex = 1;
            this.listViewNotes.UseCompatibleStateImageBehavior = false;
            this.listViewNotes.View = System.Windows.Forms.View.Details;
            // 
            // buttonCreateNote
            // 
            this.buttonCreateNote.Location = new System.Drawing.Point(298, 384);
            this.buttonCreateNote.Name = "buttonCreateNote";
            this.buttonCreateNote.Size = new System.Drawing.Size(100, 30);
            this.buttonCreateNote.TabIndex = 2;
            this.buttonCreateNote.Text = "Create Note";
            this.buttonCreateNote.Click += new System.EventHandler(this.buttonCreateNote_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(404, 384);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete Note";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(207, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Current Notes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(55, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(425, 54);
            this.label2.TabIndex = 6;
            this.label2.Text = "Welcome to your Diary";
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(192, 384);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(100, 30);
            this.view.TabIndex = 7;
            this.view.Text = "View Note";
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(516, 426);
            this.Controls.Add(this.view);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewNotes);
            this.Controls.Add(this.buttonCreateNote);
            this.Controls.Add(this.btnDelete);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label1;
        private Label label2;
        private Button view;
    }
}
