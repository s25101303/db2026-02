using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace UniversityManagementSystem26
{
    public partial class InstructorForm : Form
    {
        // Adjust server name if you use LocalDB instead of SQLEXPRESS
        private readonly string conStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=University;Integrated Security=True";


        public InstructorForm()
        {
            InitializeComponent();
            ThemeHelper.Apply(this);

            // Ensure buttons are wired even if Designer missed them
            this.button1.Click += this.button1_Click; // LOAD
            this.button2.Click += this.button2_Click; // ADD
            this.button3.Click += this.button3_Click; // UPDATE
            this.button4.Click += this.button4_Click; // DELETE
            this.button5.Click += this.button5_Click_1; // BACK

            // Wire DataGridView events to populate textboxes when a row is clicked/selected
            this.instructorDataGridView.CellClick += InstructorDataGridView_CellClick;
            this.instructorDataGridView.SelectionChanged += InstructorDataGridView_SelectionChanged;
        }

        private void instructorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.instructorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.universityDataSet);
        }

        private void instructorBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.instructorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.universityDataSet);
        }

        private void InstructorForm_Load(object sender, EventArgs e)
        {
            // Load instructors on form load
            LoadInstructors();
        }

        private void LoadInstructors(string idFilter = null)
        {
            try
            {
                using (var con = new SqlConnection(conStr))
                {
                    SqlDataAdapter da;
                    if (!string.IsNullOrWhiteSpace(idFilter))
                    {
                        da = new SqlDataAdapter("SELECT * FROM instructor WHERE ID = @id", con);
                        da.SelectCommand.Parameters.AddWithValue("@id", idFilter);
                    }
                    else
                    {
                        da = new SqlDataAdapter("SELECT * FROM instructor", con);
                    }

                    var dt = new DataTable();
                    da.Fill(dt);
                    instructorDataGridView.DataSource = dt;

                    // If any row exists, select first row to populate textboxes
                    if (instructorDataGridView.Rows.Count > 0)
                    {
                        instructorDataGridView.ClearSelection();
                        instructorDataGridView.Rows[0].Selected = true;
                        PopulateTextBoxesFromRow(instructorDataGridView.Rows[0]);
                    }
                    else
                    {
                        ClearInstructorTextboxes();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = (iDTextBox.Text ?? "").Trim();
            LoadInstructors(string.IsNullOrEmpty(id) ? null : id);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ADD
            var id = (iDTextBox.Text ?? "").Trim();
            var name = (nameTextBox.Text ?? "").Trim();
            var dept = (dept_nameTextBox.Text ?? "").Trim();
            var salaryText = (salaryTextBox.Text ?? "").Trim();

            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(dept))
            {
                MessageBox.Show("Please enter ID, name and department.");
                return;
            }

            if (!decimal.TryParse(salaryText, out decimal salary))
            {
                MessageBox.Show("Enter a valid numeric salary (or leave blank for 0).");
                return;
            }

            try
            {
                using (var con = new SqlConnection(conStr))
                {
                    con.Open();

                    // ensure department exists
                    using (var checkDept = new SqlCommand("SELECT COUNT(1) FROM department WHERE dept_name = @dept", con))
                    {
                        checkDept.Parameters.AddWithValue("@dept", dept);
                        int d = Convert.ToInt32(checkDept.ExecuteScalar());
                        if (d == 0)
                        {
                            MessageBox.Show("Department '" + dept + "' does not exist. Add the department first or choose an existing one.");
                            return;
                        }
                    }

                    // ensure instructor id not already present
                    using (var checkInst = new SqlCommand("SELECT COUNT(1) FROM instructor WHERE ID = @id", con))
                    {
                        checkInst.Parameters.AddWithValue("@id", id);
                        int s = Convert.ToInt32(checkInst.ExecuteScalar());
                        if (s > 0)
                        {
                            MessageBox.Show("An instructor with this ID already exists.");
                            return;
                        }
                    }

                    using (var cmd = new SqlCommand("INSERT INTO instructor(ID, name, dept_name, salary) VALUES(@id, @name, @dept, @salary)", con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", name);
                        cmd.Parameters.AddWithValue("@dept", dept);
                        cmd.Parameters.AddWithValue("@salary", salary);
                        int rows = cmd.ExecuteNonQuery();
                        MessageBox.Show(rows > 0 ? "Instructor Added Successfully!" : "Insert failed.");
                    }
                }

                ClearInstructorTextboxes();
                LoadInstructors();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("DB error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // UPDATE
            var id = (iDTextBox.Text ?? "").Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Enter the instructor ID to update.");
                return;
            }

            if (!decimal.TryParse((salaryTextBox.Text ?? "").Trim(), out decimal salary))
            {
                MessageBox.Show("Enter a valid numeric salary (or leave blank for 0).");
                return;
            }

            try
            {
                using (var con = new SqlConnection(conStr))
                {
                    using (var cmd = new SqlCommand("UPDATE instructor SET name=@name, dept_name=@dept, salary=@salary WHERE ID=@id", con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("@name", nameTextBox.Text ?? "");
                        cmd.Parameters.AddWithValue("@dept", dept_nameTextBox.Text ?? "");
                        cmd.Parameters.AddWithValue("@salary", salary);
                        con.Open();
                        int rows = cmd.ExecuteNonQuery();
                        MessageBox.Show("Rows Updated: " + rows);
                    }
                }

                LoadInstructors();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update error: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // DELETE
            var id = (iDTextBox.Text ?? "").Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Enter the instructor ID to delete.");
                return;
            }

            var confirm = MessageBox.Show($"Delete instructor with ID '{id}'?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var con = new SqlConnection(conStr))
                {
                    using (var cmd = new SqlCommand("DELETE FROM instructor WHERE ID=@id", con))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        con.Open();
                        int rows = cmd.ExecuteNonQuery();
                        MessageBox.Show("Rows Deleted: " + rows);
                    }
                }

                ClearInstructorTextboxes();
                LoadInstructors();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete error: " + ex.Message);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            // BACK button: go back to AdminForm
            var admin = Application.OpenForms.OfType<AdminForm>().FirstOrDefault();
            if (admin != null)
            {
                admin.Show();
                admin.BringToFront();
            }
            else
            {
                var af = new AdminForm();
                af.Show();
            }
            this.Close();
        }

        // When a cell is clicked, populate textboxes from that row
        private void InstructorDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // header or invalid
            var row = instructorDataGridView.Rows[e.RowIndex];
            PopulateTextBoxesFromRow(row);
        }

        // When selection changes (keyboard or mouse), populate textboxes from first selected row
        private void InstructorDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (instructorDataGridView.SelectedRows.Count > 0)
            {
                PopulateTextBoxesFromRow(instructorDataGridView.SelectedRows[0]);
                return;
            }

            if (instructorDataGridView.CurrentRow != null)
            {
                PopulateTextBoxesFromRow(instructorDataGridView.CurrentRow);
            }
        }

        // Helper: populate textboxes using DataPropertyName lookups (works whether columns are autogenerated or designer columns)
        private void PopulateTextBoxesFromRow(DataGridViewRow row)
        {
            if (row == null) return;

            iDTextBox.Text = GetCellValue(row, "ID");
            nameTextBox.Text = GetCellValue(row, "name");
            dept_nameTextBox.Text = GetCellValue(row, "dept_name");
            salaryTextBox.Text = GetCellValue(row, "salary");
        }

        private string GetCellValue(DataGridViewRow row, string dataPropertyName)
        {
            if (row == null) return "";

            var col = instructorDataGridView.Columns
                .Cast<DataGridViewColumn>()
                .FirstOrDefault(c => string.Equals(c.DataPropertyName, dataPropertyName, StringComparison.OrdinalIgnoreCase) ||
                                     string.Equals(c.Name, dataPropertyName, StringComparison.OrdinalIgnoreCase) ||
                                     string.Equals(c.HeaderText, dataPropertyName, StringComparison.OrdinalIgnoreCase));

            if (col != null)
            {
                var val = row.Cells[col.Index].Value;
                return val == null || val == DBNull.Value ? "" : val.ToString();
            }

            // fallback: try by index positions commonly used in designer (0..)
            try
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    var dp = instructorDataGridView.Columns[cell.ColumnIndex].DataPropertyName;
                    if (string.Equals(dp, dataPropertyName, StringComparison.OrdinalIgnoreCase))
                    {
                        var v = cell.Value;
                        return v == null || v == DBNull.Value ? "" : v.ToString();
                    }
                }
            }
            catch { }

            return "";
        }

        private void ClearInstructorTextboxes()
        {
            iDTextBox.Text = "";
            nameTextBox.Text = "";
            dept_nameTextBox.Text = "";
            salaryTextBox.Text = "";
        }
    }
}