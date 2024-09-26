# SQL Query Management System

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT) ![Environment: Windows](https://img.shields.io/badge/Environment-Windows-blue)  ![IDE: VisualStudio](https://img.shields.io/badge/IDE-VisualStudio-purple) 

<div align="center">
    <img src="https://github.com/Giuseppe1343/SQL-Query-Poster/blob/main/ProjectDiagram/Photos/1-QueryPage.png" width="400"/>
    <img src="https://github.com/Giuseppe1343/SQL-Query-Poster/blob/main/ProjectDiagram/Photos/2-ParametersPage.png"  width="400"/>
    <img src="https://github.com/Giuseppe1343/SQL-Query-Poster/blob/main/ProjectDiagram/Photos/3-ShedulingPage.png" width="800"/>
</div><be>

## Overview

This project is designed to manage and execute SQL queries, providing results in various formats and sending them via email. The system consists of two main parts: the Server and the Client. The Server processes and sends requests from clients, handles scheduled queries, and performs multi-tasking email operations. The Client allows users to manage SQL queries, export results, and send them via email.

## Features

### Server Side
- **Add SQL Query**: Add new SQL queries to the system.
- **Update SQL Query**: Update existing SQL queries.
- **Copy SQL Query**: Duplicate existing SQL queries.
- **Delete SQL Query**: Remove SQL queries from the system.
- **Add Parameters to SQL Query**: Add parameters to SQL queries.
- **Assign Values to Parameters**: Assign values to the parameters in SQL queries.
- **Scheduled Queries**: Schedule queries to run at specific intervals.
- **Multi-Tasking Email Operations**: Send emails with query results simultaneously.

### Client Side
- **Export Query Results**: Export the results of SQL queries.
  - **As Excel**: Export results as Excel files.
  - **As HTML Table**: Export results as HTML tables.
- **Send Query Results via Email**: Send the results of SQL queries via email.
  - **As Excel**: Send results as Excel attachments.
  - **As HTML Table**: Send results as HTML tables in the email body.
- **Select Email Addresses**: Choose email addresses to send the query results to.
- **Admin Panel**: Admin users have full authority to manage users, queries, and schedules.

## Mini DB

The system includes a mini database to store:
- SQL queries
- Parameters and their values
- Schedules for running queries
- User information and permissions

## User Roles

- **Admin User**: Has full authority to manage all aspects of the system.
- **Regular Users**: Can change parameters, duplicate queries, and export results as Excel files.

## Getting Started

### Prerequisites

- .NET Framework 4.8
- SQL Server or any other supported database

### Installation

1. Clone the repository:

   2. Open the solution in Visual Studio.
3. Restore NuGet packages.
4. Build the solution.

### Configuration

1. Restore `query_poster.bak`
2. Configure the database connection string in `app.config`.
3. Set up email settings for sending query results.

### Running the Application

1. Start the server application.
2. Launch the client application.

## Usage

### Adding a SQL Query

1. Open the Query Editor.
2. Enter the SQL query and save.

### Updating a SQL Query

1. Select the query from the list.
2. Make the necessary changes and save.

### Copying a SQL Query

1. Select the query to copy.
2. Use the copy function to duplicate the query.

### Deleting a SQL Query

1. Select the query to delete.
2. Use the delete function to remove the query.

### Adding Parameters

1. Open the Parameter Editor.
2. Add parameters and assign values.

### Exporting Query Results

1. Run the query.
2. Choose the export format (Excel or HTML).
3. Save the exported file.

### Sending Query Results via Email

1. Run the query.
2. Choose the email format (Excel or HTML).
3. Enter the recipient email addresses.
4. Send the email.

### Scheduling Queries

1. Open the Scheduler.
2. Set the schedule for the query.
3. Save the schedule.

## Contact

For any questions or issues, please contact [ibrahimyusufcosgun@gmail.com].
