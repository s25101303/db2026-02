using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UniversityManagementSystem26
{
    public static class ThemeHelper
    {
        public static void Apply(Form form)
        {
            if (form == null) return;

            form.BackColor = Color.FromArgb(241, 245, 249); // slate-100 (light gray-blue background)
            form.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);
            form.StartPosition = FormStartPosition.CenterScreen;

            StyleControls(form.Controls);
        }

        private static void StyleControls(Control.ControlCollection controls)
        {
            if (controls == null) return;

            foreach (Control control in controls)
            {
                // Recursively style child controls
                if (control.HasChildren)
                {
                    StyleControls(control.Controls);
                }

                if (control is Panel panel)
                {
                    // Detect if this is a header panel (spans top of form)
                    if (panel.Location.Y <= 15 && panel.Height >= 40 && panel.Width >= 300)
                    {
                        panel.BackColor = Color.FromArgb(15, 23, 42); // slate-900 (deep slate)
                        panel.BorderStyle = BorderStyle.None;

                        // Force all labels inside header panel to be white with professional font
                        foreach (Control inner in panel.Controls)
                        {
                            if (inner is Label lbl)
                            {
                                lbl.ForeColor = Color.White;
                                if (lbl.Font.Size >= 14 || lbl.Text.ToUpper() == lbl.Text)
                                {
                                    lbl.Font = new Font("Segoe UI", 16f, FontStyle.Bold);
                                }
                                else
                                {
                                    lbl.Font = new Font("Segoe UI Semibold", 10f, FontStyle.Bold);
                                }
                            }
                        }
                    }
                    else
                    {
                        // Clean card/container background
                        panel.BackColor = Color.White;
                        panel.BorderStyle = BorderStyle.None;
                    }
                }
                else if (control is Label label)
                {
                    // Check if parent is a header panel (which we already styled)
                    if (label.Parent is Panel parentPanel && parentPanel.Location.Y <= 15 && parentPanel.Height >= 40 && parentPanel.Width >= 300)
                    {
                        label.ForeColor = Color.White;
                    }
                    else
                    {
                        label.ForeColor = Color.FromArgb(51, 65, 85); // slate-700 (dark gray)
                        if (label.Font.Size >= 14)
                        {
                            label.Font = new Font("Segoe UI", 14f, FontStyle.Bold);
                            label.ForeColor = Color.FromArgb(15, 23, 42); // slate-900
                        }
                        else
                        {
                            label.Font = new Font("Segoe UI Semibold", 9.5f, FontStyle.Bold);

                            // Clean up typical short database field names to be professional
                            string cleaned = label.Text.Trim();
                            if (cleaned.Equals("dept name:", StringComparison.OrdinalIgnoreCase))
                                label.Text = "Department:";
                            else if (cleaned.Equals("tot cred:", StringComparison.OrdinalIgnoreCase))
                                label.Text = "Total Credits:";
                            else if (cleaned.Equals("course id:", StringComparison.OrdinalIgnoreCase))
                                label.Text = "Course ID:";
                            else if (cleaned.Equals("credits:", StringComparison.OrdinalIgnoreCase))
                                label.Text = "Credits:";
                            else if (cleaned.Equals("time slot id:", StringComparison.OrdinalIgnoreCase))
                                label.Text = "Time Slot ID:";
                            else if (cleaned.Equals("start hr:", StringComparison.OrdinalIgnoreCase))
                                label.Text = "Start Hour:";
                            else if (cleaned.Equals("start min:", StringComparison.OrdinalIgnoreCase))
                                label.Text = "Start Minute:";
                            else if (cleaned.Equals("end hr:", StringComparison.OrdinalIgnoreCase))
                                label.Text = "End Hour:";
                            else if (cleaned.Equals("end min:", StringComparison.OrdinalIgnoreCase))
                                label.Text = "End Minute:";
                            else if (cleaned.Equals("name:", StringComparison.OrdinalIgnoreCase))
                                label.Text = "Name:";
                            else if (cleaned.Equals("title:", StringComparison.OrdinalIgnoreCase))
                                label.Text = "Title:";
                            else if (cleaned.Equals("day:", StringComparison.OrdinalIgnoreCase))
                                label.Text = "Day:";
                        }
                    }
                }
                else if (control is Button button)
                {
                    button.FlatStyle = FlatStyle.Flat;
                    button.FlatAppearance.BorderSize = 0;
                    button.Font = new Font("Segoe UI Semibold", 9.5f, FontStyle.Bold);
                    button.Cursor = Cursors.Hand;

                    Color defaultBg = GetButtonColor(button.Text);
                    button.BackColor = defaultBg;
                    button.ForeColor = Color.White;

                    // Hover effects using MouseEnter/MouseLeave
                    button.MouseEnter += (s, e) =>
                    {
                        button.BackColor = AdjustBrightness(defaultBg, -0.1f); // Darken slightly on hover
                    };
                    button.MouseLeave += (s, e) =>
                    {
                        button.BackColor = defaultBg; // Restore default background
                    };
                }
                else if (control is TextBox textBox)
                {
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                    textBox.Font = new Font("Segoe UI", 10f, FontStyle.Regular);
                    textBox.BackColor = Color.White;
                    textBox.ForeColor = Color.FromArgb(15, 23, 42); // slate-900

                    textBox.GotFocus += (s, e) =>
                    {
                        textBox.BackColor = Color.FromArgb(248, 250, 252); // slate-50 on focus
                    };
                    textBox.LostFocus += (s, e) =>
                    {
                        textBox.BackColor = Color.White;
                    };
                }
                else if (control is DataGridView dgv)
                {
                    dgv.BackgroundColor = Color.White;
                    dgv.BorderStyle = BorderStyle.None;
                    dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                    dgv.GridColor = Color.FromArgb(226, 232, 240); // slate-200
                    dgv.RowHeadersVisible = false;
                    dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dgv.AllowUserToResizeRows = false;
                    dgv.RowTemplate.Height = 32;
                    dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                    dgv.ColumnHeadersHeight = 36;
                    dgv.EnableHeadersVisualStyles = false;

                    // Header Style
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59); // slate-800
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9.5f, FontStyle.Bold);
                    dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 41, 59);
                    dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                    // Cell Style
                    dgv.DefaultCellStyle.BackColor = Color.White;
                    dgv.DefaultCellStyle.ForeColor = Color.FromArgb(51, 65, 85); // slate-700
                    dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254); // blue-100
                    dgv.DefaultCellStyle.SelectionForeColor = Color.FromArgb(15, 23, 42); // slate-900
                    dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9.5f, FontStyle.Regular);

                    // Alternating Row Style
                    dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252); // slate-50
                    dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(51, 65, 85);
                    dgv.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
                    dgv.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.FromArgb(15, 23, 42);
                }
                else if (control is Chart chart)
                {
                    chart.BackColor = Color.White;
                    chart.BorderlineColor = Color.Transparent;

                    if (chart.ChartAreas.Count > 0)
                    {
                        var area = chart.ChartAreas[0];
                        area.BackColor = Color.FromArgb(248, 250, 252); // slate-50
                        area.AxisX.LineColor = Color.FromArgb(203, 213, 225); // slate-300
                        area.AxisY.LineColor = Color.FromArgb(203, 213, 225);
                        area.AxisX.MajorGrid.LineColor = Color.FromArgb(241, 245, 249); // slate-100
                        area.AxisY.MajorGrid.LineColor = Color.FromArgb(241, 245, 249);
                        area.AxisX.LabelStyle.Font = new Font("Segoe UI", 8.5f, FontStyle.Regular);
                        area.AxisY.LabelStyle.Font = new Font("Segoe UI", 8.5f, FontStyle.Regular);
                        area.AxisX.LabelStyle.ForeColor = Color.FromArgb(100, 116, 139);
                        area.AxisY.LabelStyle.ForeColor = Color.FromArgb(100, 116, 139);
                    }

                    if (chart.Legends.Count > 0)
                    {
                        chart.Legends[0].Font = new Font("Segoe UI", 8.5f, FontStyle.Regular);
                        chart.Legends[0].ForeColor = Color.FromArgb(100, 116, 139);
                        chart.Legends[0].BackColor = Color.Transparent;
                    }

                    // Theme colors for Chart Series
                    Color[] palette = new Color[] {
                        Color.FromArgb(59, 130, 246),  // Blue 500
                        Color.FromArgb(16, 185, 129),  // Emerald 500
                        Color.FromArgb(245, 158, 11),  // Amber 500
                        Color.FromArgb(99, 102, 241),  // Indigo 500
                        Color.FromArgb(236, 72, 153)   // Pink 500
                    };

                    for (int i = 0; i < chart.Series.Count; i++)
                    {
                        chart.Series[i].Color = palette[i % palette.Length];
                        chart.Series[i].Font = new Font("Segoe UI Semibold", 8.5f, FontStyle.Bold);
                    }
                }
            }
        }

        private static Color GetButtonColor(string text)
        {
            if (string.IsNullOrEmpty(text))
                return Color.FromArgb(37, 99, 235); // Default Blue

            string t = text.Trim().ToUpper();

            if (t == "DELETE" || t.Contains("REMOVE"))
                return Color.FromArgb(239, 68, 68); // Red 500
            
            if (t == "ADD" || t == "INSERT" || t == "SAVE" || t == "CREATE")
                return Color.FromArgb(16, 185, 129); // Emerald 500
            
            if (t == "UPDATE" || t == "EDIT")
                return Color.FromArgb(245, 158, 11); // Amber 500
            
            if (t == "BACK" || t == "CANCEL" || t == "CLOSE" || t == "LOGOUT")
                return Color.FromArgb(100, 116, 139); // Slate 500
            
            if (t == "LOGIN")
                return Color.FromArgb(37, 99, 235); // Blue 600

            // Default fallback
            return Color.FromArgb(37, 99, 235); // Blue 600
        }

        private static Color AdjustBrightness(Color color, float correctionFactor)
        {
            float red = (float)color.R;
            float green = (float)color.G;
            float blue = (float)color.B;

            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }

            return Color.FromArgb(color.A, (int)Math.Max(0, Math.Min(255, red)), (int)Math.Max(0, Math.Min(255, green)), (int)Math.Max(0, Math.Min(255, blue)));
        }
    }
}
