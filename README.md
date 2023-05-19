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
* _5. _create and connect your own database in MySQL Workbench via termimal commands or directly in MySQL workbench, the following instructions in this README will use your termibal and MySQLWorkbench_
* _6. Launch MySQL server using chosen log in name if changed or root if using default with `\$ mysql -u [YOUR-USER-NAME] -p[YOUR-PASSWORD-HERE] `_
* _7. Open MySQL Workbench and Double click the MySQL instance in the connections section to open your MySQL instance, re-enter password if prompted_
* _8. Create a new schema in the connected server by clicking Schemas tab at top left and then clicking new schema option in local instance signified by a 3D cylinder with "+"circled on its bottom left side_ 
* _9. On new_schema page enter a name for Database name field to correpond with [YOUR-DATA-BASE], leave all defaults in place, click Apply, then finish and close once applied_
* _10. Create new tables for each Class we'll need in the project, with corresponding properties making sure that the ClassId fields are primary keys, integers, Not Null and Auto-incremented, also set up a foreign key property for our one to many relationship with a StylistID property for both tables and a default expression of '0' for the Clients property of StylistId, click apply to update table_
* _11. using administration tab select DataExport option select created schema in to export window, choose dump structure only, select export to self-contained file and choose name that matches the [YOUR-DB-HERE] field set up in appsettings.json, and if desired set path to where created .sql file will be in the directory for the cloned project_
* _12. click start export and this will create your .sql file to connect to the project file, exit mySQL_
* _. In the command line, run the command `\$ dotnet run` to compile and execute the console application. Since this is a console application, you'll interact with it through text commands in your terminal._
* _4. Optionally, you can run `\$ dotnet build` to compile this console app without running it._
* _5. Use `\$ dotnet test run` in the Test directory to run test on the application_
* _6. use `\$ dotnet watch run` to cycle the server_
* _7. use `\$ dotnet watch run --launch-profile "production"` to run in production mode_


## Known Bugs

* _Any known issues_
* _should go here_

## License
[MIT](https://yourlicesnepage)