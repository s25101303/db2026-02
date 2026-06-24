User Guide: University Management System

This guide provides instructions on how to use the University Management System (UMS) desktop application. The system is designed for university administrators, instructors, and students to manage academic and administrative tasks efficiently.

1. Getting Started

1.1. System Requirements

•
Operating System: Windows 10 or later

•
.NET Framework 4.7.2 (or higher)

•
Microsoft SQL Server (LocalDB for development, full SQL Server for production)

1.2. Installation

Refer to the README.md file in the project root for detailed installation and setup instructions, including database configuration.

1.3. Login

Upon launching the application, you will be presented with a login screen.

1.
Enter your Username and Password.

2.
Click the Login button.

3.
Your access and available modules will be determined by your assigned role (Admin, Instructor, or Student).

2. Admin Dashboard

After successful login as an Administrator, you will see the main dashboard, which provides access to all management modules:

•
Student Management: Manage student records.

•
Instructor Management: Manage instructor details.

•
Department Management: Manage university departments.

•
Course Management: Manage the course catalog.

•
Enrollment Management: Manage student enrollments in courses.

•
Scheduling: Manage class time slots and prevent conflicts.

•
Reports & Analytics: Generate reports and view data visualizations.

3. Module Operations (CRUD)

Most management modules (Student, Instructor, Department, Course, Enrollment) follow a consistent interface for performing Create, Read, Update, and Delete (CRUD) operations.

3.1. Viewing Records

•
Select a module from the Admin Dashboard.

•
Existing records will be displayed in a data grid.

•
Use the Load button (if available) to refresh the data.

3.2. Adding New Records

1.
Enter the required information into the input fields (e.g., Student ID, Name, Department).

2.
Click the Add button.

3.
The system will validate the input and add the new record to the database.

3.3. Updating Existing Records

1.
Select a record from the data grid.

2.
The information for the selected record will populate the input fields.

3.
Modify the necessary fields.

4.
Click the Update button to save changes.

3.4. Deleting Records

1.
Select the record you wish to delete from the data grid.

2.
Click the Delete button.

3.
Confirm the deletion when prompted.

4. Specific Module Features

4.1. Scheduling and Time Slot Management

•
Add Time Slot: Define new time slots by specifying Day, Start Time, and End Time.

•
Check Conflicts: Before saving a new time slot, use this feature to identify any overlapping schedules.

4.2. Reports & Analytics

•
Reports Section: Click buttons to generate tabular data exports for Students, Courses, or Enrollments.

•
Analysis Section: View dynamic charts (e.g., Students by Department, Enrollment per Course) that visualize real-time data from the database.

5. Troubleshooting

•
Login Issues: Ensure your username and password are correct. If you are an administrator, verify the database connection string in appsettings.json.

•
Data Not Loading: Check your database connection. Ensure the SQL Server is running and accessible.

•
Input Validation Errors: Review the error message for specific details on what input is incorrect or missing.

