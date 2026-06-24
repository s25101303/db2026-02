using System;
using System.Linq;
using System.Windows.Forms;

namespace UniversityManagementSystem26
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            ThemeHelper.Apply(this);

            // Wire up the remaining buttons to the correct handlers.
            // Mapping is chosen to match the button text in the Designer:
            // - button2: INSTRUCTOR -> button2_Click
            // - button3: DEPARTMENT -> button3_Click
            // - button4: COURSE -> uses existing button5_Click (CourseForm)
            // - button5: ENROLLMENT -> uses existing button4_Click (EnrollmentForm)
            // - button6: SCHEDULING -> uses existing button7_Click (SchedulingForm)
            // - button7: REPORT AND ANALYTICS -> uses existing button8_Click (Report___Analysis)
            // - button8: LOGOUT -> uses existing button6_Click (Logout/Close)
            this.button2.Click += this.button2_Click;
            this.button3.Click += this.button3_Click;
            this.button4.Click += this.button5_Click; // designer button4 is COURSE, method that opens CourseForm is button5_Click
            this.button5.Click += this.button4_Click; // designer button5 is ENROLLMENT, method that opens EnrollmentForm is button4_Click
            this.button6.Click += this.button7_Click; // designer button6 is SCHEDULING, method that opens SchedulingForm is button7_Click
            this.button7.Click += this.button8_Click; // designer button7 is REPORT AND ANALYTICS, method that opens report is button8_Click
            this.button8.Click += this.button6_Click; // designer button8 is LOGOUT, method that closes form is button6_Click
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentForm sf = new StudentForm();
            sf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InstructorForm inf = new InstructorForm();
            inf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DepartmentForm df = new DepartmentForm();
            df.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CourseForm frm = new CourseForm();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EnrollmentForm frm = new EnrollmentForm();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Logout: close the admin form so the hidden LoginForm (caller) can re-show itself.
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Open Scheduling form
            var sf = new SchedulingForm();
            sf.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Open Report and Analytics form
            var rep = Application.OpenForms.OfType<Report___Analysis>().FirstOrDefault();
            if (rep != null)
            {
                rep.Show();
                rep.BringToFront();
                return;
            }

            try
            {
                var newRep = new Report___Analysis();
                newRep.Show();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open report form: " + ex.Message);
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}