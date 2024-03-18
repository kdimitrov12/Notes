using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteTaking
{
    public partial class Form3 : Form
    {
        private string noteID;
        private void Form3_Load(object sender, EventArgs e)
        {
            // Add your initialization or setup code here
        }
        public Form3(string title, string content, string id)
        {
            InitializeComponent();

            txtTitle.Text = title ?? "N/A";

            // Set the content in the RichTextBox
            rtbNoteDetails.Text = content ?? "N/A";
            noteID = id; // Store the ID of the note

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
        
              Form1 form1 = new Form1();
              form1.Show();
              this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve new title and content
            string newTitle = txtTitle.Text;
            string newContent = rtbNoteDetails.Text;

            // Update the note in the database
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\localDB1; Initial Catalog=NoteDB; Integrated Security=True;"))
                {
                    connection.Open();
                    string query = "UPDATE Notes SET Title = @Title, Content = @Content WHERE NoteID = @NoteID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Title", newTitle);
                    command.Parameters.AddWithValue("@Content", newContent);
                    command.Parameters.AddWithValue("@NoteID", noteID);
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Note updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update note.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while updating note: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
