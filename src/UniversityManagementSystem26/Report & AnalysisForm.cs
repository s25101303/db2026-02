using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace UniversityManagementSystem26
{
    public partial class Report___Analysis : Form
    {
        string conStr =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=University;Integrated Security=True";

        public Report___Analysis()
        {
            InitializeComponent();
            ThemeHelper.Apply(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con =
                    new SqlConnection(conStr);

                string query =
                    "SELECT * FROM student";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, con);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                dgvReport.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
        }

        private void chartAnalytics_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conStr);

                string query =
                @"SELECT dept_name,
                 COUNT(*) AS TotalStudents
          FROM student
          GROUP BY dept_name";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, con);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                chartAnalytics.Series.Clear();

                Series series =
                    new Series("Students");

                series.ChartType =
                    SeriesChartType.Pie;

                foreach (DataRow row in dt.Rows)
                {
                    series.Points.AddXY(
                        row["dept_name"].ToString(),
                        Convert.ToInt32(row["TotalStudents"])
                    );
                }

                chartAnalytics.Series.Add(series);

                chartAnalytics.Titles.Clear();
                chartAnalytics.Titles.Add(
                    "Students by Department");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con =
                    new SqlConnection(conStr);

                string query =
                    "SELECT * FROM course";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, con);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                dgvReport.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(conStr);

                string query =
                @"SELECT course_id,
                 COUNT(ID) AS TotalStudents
          FROM takes
          GROUP BY course_id";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, con);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                chartAnalytics.Series.Clear();

                Series series =
                    new Series("Enrollment");

                series.ChartType =
                    SeriesChartType.Column;

                foreach (DataRow row in dt.Rows)
                {
                    series.Points.AddXY(
                        row["course_id"].ToString(),
                        Convert.ToInt32(row["TotalStudents"])
                    );
                }

                chartAnalytics.Series.Add(series);

                chartAnalytics.Titles.Clear();
                chartAnalytics.Titles.Add(
                    "Enrollment per Course");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {


            SqlConnection con = new SqlConnection(conStr);

            string query =
            @"SELECT course_id,
       credits
FROM course";

            SqlDataAdapter da =
                new SqlDataAdapter(query, con);

            DataTable dt =
                new DataTable();

            da.Fill(dt);

            chartAnalytics.Series.Clear();

            Series series =
                new Series("Credits");

            series.ChartType =
                SeriesChartType.Column;

            foreach (DataRow row in dt.Rows)
            {
                series.Points.AddXY(
                    row["course_id"].ToString(),
                    Convert.ToInt32(row["credits"])
                );
            }

            chartAnalytics.Series.Add(series);

            chartAnalytics.Titles.Clear();
            chartAnalytics.Titles.Add(
                "Course Credits Analysis");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con =
                    new SqlConnection(conStr);

                string query =
                @"SELECT
        s.ID,
        s.name,
        c.course_id,
        c.title,
        t.grade
      FROM takes t
      INNER JOIN student s
          ON t.ID = s.ID
      INNER JOIN course c
          ON t.course_id = c.course_id";

                SqlDataAdapter da =
                    new SqlDataAdapter(query, con);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                dgvReport.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}