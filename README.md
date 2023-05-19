What Is This?
This is an example repo corresponding to multiple lessons within the LearnHowToProgram.com walkthrough on creating a Template application in Section 3: Database Basics.

This project corresponds to the classwork and lessons that describe how to connect an ASP.NET Core MVC project to a MySQL database using Entity Framework Core. There are multiple lessons in this series. The first lesson in the series is Introducing Entity Framework Core.

There are multiple branches in this repo that are described more below.

How To Run This Project
Install Tools
Install the tools that are introduced in this series of lessons on LearnHowToProgram.com.

Set up the Databases
Follow the instructions in the LearnHowToProgram.com lesson "Creating a Test Database: Exporting and Importing Databases with MySQL Workbench" to use the template_with_ef_core_dump.sql file located at the top level of this repo to create a new database in MySQL Workbench with the name template_with_ef_core.

Set Up and Run Project
Clone this repo.
Open the terminal and navigate to this project's production directory called "ToDoList".
Within the production directory "ToDoList", create a new file called appsettings.json.
Within appsettings.json, put in the following code, replacing the uid and pwd values with your own username and password for MySQL. For the LearnHowToProgram.com lessons, we always assume the uid is root and the pwd is epicodus.
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=best_restaurants_with_ef_core;uid=root;pwd=epicodus;"
  }
}
Within the production directory "Template", run dotnet watch run in the command line to start the project in development mode with a watcher.
Open the browser to https://localhost:5001. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: Redirecting to HTTPS and Issuing a Security Certificate.