# Eau Claire's Salon

#### Applcation for fictitious salon owner to track Employee and Client data and work realtionships

#### By Christopher Ross Davila

## Technologies Used

* _.Net 6.0_
* _ASP.Net Core_
* _C#_
* _Entity Framework Core_
* _Git Hub_
* _VS code_
* _MySQL_
* _MySQL Workbench_


## Description
### Client Web applicaion that allows client to monitor, update and display Employee and Client data using one to many relationship in MySQL Schema in an MVC C Sharp project set up. This application utiilizes Helper methods and viewbag to simplify the cshtml code for user interface and DRY code on production side

## Setup/Installation Requirements

* _1. Clone this repo using `\$ git clone https://github.com/ChrisRDavila/EauClairesSalon.Solution.git`._
* _2. Open your terminal (e.g., Terminal or GitBash) and navigate to the production directory called "EauClairesSalon.solution" and use command `\$ code .` to open project in vs code_
* _3. _Create appsettings.json file to store database name, user name and password for connecting to MySQL database using this structure:_
```cs
 "ConnectionStrings": 
{
    "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
}
```
* _3. cont'd: where [YOUR-DB-NAME] is going to be the database you import and connect (i.e. data_base), [YOUR-USER-NAME] will be your MySQL log in name and [YOUR-PASSWORD-HERE] will be your MySQL password_
* _4. For next instructions please make sure you have access to MySQL and MySQLWorkbench_
* _5. _create and connect your own database in MySQL Workbench via termimal commands or directly in MySQL workbench, the following instructions in this README will us MySQLWorkbench_
* _Log in to MYSQL server using chosen log in name if changed or root if using default with _
* _this format -> 
* _2. Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory called "ProjectFile"._
* _3. In the command line, run the command `\$ dotnet run` to compile and execute the console application. Since this is a console application, you'll interact with it through text commands in your terminal._
* _4. Optionally, you can run `\$ dotnet build` to compile this console app without running it._
* _5. Use `\$ dotnet test run` in the Test directory to run test on the application_
* _6. use `\$ dotnet watch run` to cycle the server_
* _7. use `\$ dotnet watch run --launch-profile "production"` to run in production mode_


## Known Bugs

* _Any known issues_
* _should go here_

## License
[MIT](https://yourlicesnepage)