# Claire's Salon Manager

### By Emma Gerigscott

![gif of webpage in action](./HairSalon/wwwroot/img/claire.gif)

## Description

Claire, the impecable salon manager, needed a website to track all her many stylists and corresponding clients. In this web application, Claire can add, update, and delete stylists, clients, and appointments to keep track of her business.

## Technologies Used

* C#
* .NET
* ASP.NET Core
* MVC
* Entity Framework Core
* Pomelo Entity Framework Core
* Html Helpers
* MySQL

## Setup Instructions

1. Clone this repo.
2. Open your terminal (e.g. Terminal or GitBash) and navigate to this project's directory called "HairSalon".
3. Set up the database:
  * Import the SQL dump file located in the root directory of this project (HairSalon.Solution) to your MySQL workbench:
    * In the _Navigator > Administration_ window, select _Data Import/Restore_.
    * In _Import Options_ select _Import from Self-Contained File_.
    * Navigate to the sql file located in the root of this projects directory
    * Under _Default Schema to be Imported To_, select the _New_ button.
    * Name your database ```claires_salon```
    * Click _Ok_
    * Navigate to the tab called _Import Progress_ and click _Start Import_ at the bottom right corner of the window.
  * You should see the new schema in your _Navigator > Schemas_ tab called ```claires_salon```
4. Set up the project:
  * Create a file called 'appsettings.json' in HairSalon.Solution/HairSalon directory
  * Add the following code to the appsettings.json file:
  ```
  {
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=claires_salon;uid=[YOUR_SQL_USER_ID];pwd=[YOUR_SQL_PASSWORD];"
    }
  }
  ```
5. Running the project in your browser:
  * Navigate to the directory "HairSalon" from your terminal.
  * Run the command from HairSalon ```dotnet watch run```
  * Your browser should automatically open ```https://localhost:5001/```. You may need to enter your computers password when prompted to allow ASP.NET Core to run in your browser.


## Known Bugs

* _Date and time can overlap for Stylists_
* _Appointments table needs more information, like cost and appointment length_
* _Appointments can be made for clients with a different stylist_

## License
[MIT](https://opensource.org/licenses/MIT)  
Copyright © 2023 Emma Gerigscott