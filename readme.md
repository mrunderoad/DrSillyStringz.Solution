# _Dr.Sillystringz Factory_

### _By: Isaac Overstreet_

#### _This application lets users add engineers, machines and locations using a many to many database relationship with c# .NET._

## Technologies Used

* _C#_
* _MySQL_
* _cshtml_
* _css_
* _Bootstrap_
* _Entity Framework_
* _.NET_

## Description

_This project build for Epicodus C# friday project is to display knowledge of a many to many relationship. This particular application is for assigning engineers to machines and locations. Users may create an engineer, assign the engineer to locations and machines. Same goes for machines and locations._

## Setup/Installation Requirements

* _Make sure you have MySQL Workbench installed._
* _Clone this repository to your desktop from https://github.com/mrunderoad/DrSillyStringz.Solution_
* _Navigate to the HairSalon directory in your terminal using `cd Factory`._
* _Inside the `Factory` directory, add a new file named `appsettings.json`._
* _Inside the `appsettings.json` file, add this code with your database, username and password in the specified places in the code._ 
```c#
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=DATABASE HERE;uid=USERNAME;pwd=PASSWORD;"
  }
}
```
* _Inside the `Factory` directory, run `dotnet ef database update` to create a database based off the migrations folder included in the repository._
* _Run `dotnet restore` to restore the obj and bin folders._
* _Run `dotnet build` to build the project._
* _Run `dotnet run` to start a localhost. `ctrl+click` on the localhost option in your terminal to view the project in your browser._

## Known Bugs

* _No known bugs at this time._

## License

[MIT](https://opensource.org/licenses/MIT)

_Copyright (c) 2022  Isaac Overstreet_