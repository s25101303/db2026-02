using System;
using System.Linq;
using System.Windows.Forms;

namespace UniversityManagementSystem26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ThemeHelper.Apply(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional: initialization logic
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new UniversityEntities())
            {
                // check if user exists (use Username field, not ID)
                var user = db.users
                    .Where(u => u.Username == userTextBox.Text && u.Password == passTextBox.Text)
                    .FirstOrDefault();

                if (user == null)
                {
                    MessageBox.Show("invalid username or password!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                // hide login form (clear fields before hiding)
                userTextBox.Text = "";
                passTextBox.Text = "";
                this.Hide();

                // open form based on role (case-insensitive, safe for null)
                switch ((user.role ?? "").ToLower())
                {
                    case "administrator":
                        using (var adminForm = new AdminForm())
                            adminForm.ShowDialog();
                        break;
                    case "instructor":
                        using (var facultyForm = new InstructorForm())
                            facultyForm.ShowDialog();
                        break;
                    case "student":
                        using (var studentForm = new StudentForm())
                            studentForm.ShowDialog();
                        break;
                    default:
                        MessageBox.Show("Unknown role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }

            // show login form again
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}