System Architecture

Overview

The University Management System is built as a monolithic desktop application using a classic two-tier client-server architecture. The application logic and user interface reside on the client side (Windows Forms), while the data persistence layer is managed by a centralized relational database (Microsoft SQL Server).

Technology Stack

•
Presentation Layer: Windows Forms (WinForms) using C# and .NET Framework 4.7.2.

•
Data Access Layer: Entity Framework (EF) and ADO.NET for database interactions.

•
Database Layer: Microsoft SQL Server (LocalDB for development).

Architecture Diagram

The system follows a straightforward data-driven architecture:

1.
User Interface (UI): The WinForms application provides the graphical interface for users to interact with the system. It handles user input, input validation, and displays data retrieved from the database.

2.
Business Logic: The core application logic, including role-based access control, scheduling conflict detection, and data processing for analytics, is implemented within the C# form classes and helper methods.

3.
Data Access: The application uses Entity Framework (via UniversityModel.edmx) to map database tables to C# objects, simplifying CRUD operations. Direct ADO.NET queries are also utilized for specific reporting and analytical functions.

4.
Database: The SQL Server database stores all persistent data, enforcing referential integrity through foreign keys and constraints.

Database Schema

The database is structured around several core entities that model a university environment. The primary tables include:

Table Name
Description
Key Relationships
department
Stores department details (name, building, budget).
Referenced by student, instructor, course.
student
Stores student records (ID, name, total credits).
Belongs to a department.
instructor
Stores faculty records (ID, name, salary).
Belongs to a department.
course
Stores course catalog information (ID, title, credits).
Offered by a department.
section
Represents a specific offering of a course.
Belongs to a course, scheduled in a time_slot.
takes
Tracks student enrollment and grades.
Links student to section.
time_slot
Defines class meeting times.
Referenced by section.
user
Manages authentication credentials and roles.
Used for system login.




Security and Access Control

Security is implemented at the application level through a role-based access control (RBAC) mechanism. Upon successful authentication against the user table, the system determines the user's role (Admin, Instructor, or Student) and dynamically adjusts the available UI components and accessible modules to ensure data privacy and operational security.

