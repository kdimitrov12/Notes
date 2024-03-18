using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NoteTaking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadNotes();
        }

        private void LoadNotes()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\localDB1; Initial Catalog=NoteDB; Integrated Security=True;"))
                {
                    connection.Open();

                    string query = "SELECT NoteID, Title, Content, Timestamp FROM Notes";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    // Clear existing items and columns in the ListView
                    listViewNotes.Items.Clear();
                    listViewNotes.Columns.Clear();

                    // Add columns to the ListView
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        listViewNotes.Columns.Add(reader.GetName(i));
                    }

                    // Loop through each row returned by the SQL query
                    while (reader.Read())
                    {
                        // Create a new ListViewItem for each row
                        ListViewItem item = new ListViewItem();

                        // Add main item for the first column (NoteID)
                        item.Text = reader["NoteID"].ToString();

                        // Add sub-items for the remaining columns
                        for (int i = 1; i < reader.FieldCount; i++)
                        {
                            // Add sub-item for the current column
                            item.SubItems.Add(reader[i].ToString());
                        }

                        // Add the ListViewItem to the ListView
                        listViewNotes.Items.Add(item);
                    }

                    // Close the SqlDataReader
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            // Check if a note is selected in the ListView
            if (listViewNotes.SelectedItems.Count > 0)
            {
                // Retrieve the NoteID from the selected ListViewItem's Tag property
                int noteID = Convert.ToInt32(listViewNotes.SelectedItems[0].Text);

                try
                {
                    // Connect to the SQL Server database
                    using (SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\localDB1; Initial Catalog=NoteDB; Integrated Security=True;"))
                    {
                        connection.Open();

                        // Prepare the SQL DELETE query
                        string query = "DELETE FROM Notes WHERE NoteID = @NoteID";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@NoteID", noteID);

                        // Execute the SQL DELETE query
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // If deletion is successful, remove the note from the ListView
                            listViewNotes.Items.Remove(listViewNotes.SelectedItems[0]);
                            MessageBox.Show("Note deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // If no rows were affected, display an error message
                            MessageBox.Show("Failed to delete the note.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that occur during the database operation
                    MessageBox.Show("An error occurred while deleting the note: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // If no note is selected, display an error message
                MessageBox.Show("Please select a note to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCreateNote_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void view_Click(object sender, EventArgs e)
        {
            // Check if a note is selected in the ListView
            if (listViewNotes.SelectedItems.Count > 0)
            {
                // Retrieve the title and content of the selected note
                string title = listViewNotes.SelectedItems[0].SubItems[1].Text;
                string content = listViewNotes.SelectedItems[0].SubItems[2].Text; // Assuming content is in the second column
                string id = listViewNotes.SelectedItems[0].Text.ToString(); // Assuming you store note ID in the Tag property


                // Create a new instance of the NoteDetailsForm
                Form3 detailsForm = new Form3(title, content, id);
                this.Hide();

                // Show the NoteDetailsForm
                detailsForm.ShowDialog(); // Use Show() if you don't want it to be modal
            }
            else
            {
                MessageBox.Show("Please select a note to view details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}