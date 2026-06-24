University Management System

Project Description

This project is a desktop-based University Management System (UMS) developed using C# and the .NET Framework. It provides a comprehensive solution for managing various university operations, including student, instructor, department, course, enrollment, and scheduling information. The system features a secure, role-based login and offers robust reporting and analytics capabilities.

Team Members

Name
Student ID
固婕霹(25101303)
巴興婷(25101307)
李心妍(25101317)




Tech Stack

•
Language: C#

•
Framework: .NET Framework 4.7.2

•
UI: Windows Forms

•
Database: Microsoft SQL Server (LocalDB)

•
ORM: Entity Framework

•
IDE: Visual Studio 2022

Key Features

•
Secure Role-Based Login: Differentiates access for Admin, Instructor, and Student roles.

•
Student Management: Full CRUD operations for student records (ID, Name, Department, Total Credits).

•
Instructor Management: Comprehensive management of instructor details (ID, Name, Department, Salary) with department validation.

•
Department Management: CRUD operations for university departments (Name, Building, Budget).

•
Course Management: Maintains the university course catalog (Course ID, Title, Department, Credits).

•
Enrollment Management: Tracks student enrollment in courses, including grades, with validation for existing students and courses.

•
Scheduling and Time Slot Management: Manages class schedules and automatically detects time conflicts to prevent double-booking.

•
Reports & Analytics: Generates tabular reports and visual analytics (pie charts, column charts) on student, course, and enrollment data.

How to Run

1.
Restore NuGet packages in Visual Studio.

2.
Update the connection string in appsettings.json (or App.config for Windows Forms applications) to point to your SQL Server instance. The default connection string used during development was Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=University;Integrated Security=True.

3.
Run the database/schema.sql script on your SQL Server to create the necessary database schema and tables.

4.
Open the project in Visual Studio 2022 and press F5 to build and run the application.

Database Schema Overview

The system utilizes an eleven-table database schema to ensure data integrity and efficient management of university data. Key tables include student, instructor, department, course, section, takes, time_slot, classroom, advisor, and user, interconnected via foreign key relationships.

