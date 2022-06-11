# Animal Shelter API

#### By **Cameron Ray**

#### ASP.Net Core API with JWT Authentication & Authorization

## Technologies Used

* C#
* .NET 5.0
* ASP.Net Core
* Entity Framework Core
* ASP.Net Core Identity
* ASP.Net Core API Routing
* JSON Web Tokens
* MySQL
* Postman


## Description
A simple showcase of a C# API utilizing the ASP.NET Core framework. The application has a single endpoint where users can filter animals in an animal shelter based on specific properties. Database will seed with sample data. Get requests do not require authentication. POST, PUT and DELETE requests will require a valid JSON Web Token in the header.

## Setup/Installation Requirements

* Requires MySQL for the database
* Clone the repository
* navigate to Shelter.Solution
* Create an appsettings.json file in the root of the Shelter folder.
```
$ cd Shelter/
$ touch appsettings.json
```
* Add the following to the appsettings.json file with the bracketed username and password replaced with your mysql username and password.
```JSON
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "JwtConfig":{
    "Secret": "[insert 32 character secret string]"
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=cameron_ray;uid=[username];pwd=[password]];"
  }
}
```
* restore and build the project
```
$ dotnet restore
$ dotnet build
```
* import the database located in the root of Shelter.Solution using MySQL Workbench. 
1. From the Navigator section click the Administration tab at the bottom of the section.
2. Click Data Import/Restore and select "Import from Self-Contained File."
3. select the path to import from. In this case it should be the clonedlocation/Shelter.Solution/cameron_ray.sql

* alternatively run the following command in the terminal to build a database for running the app.
```
$ dotnet ef database update
```
* start the project form the Shelter directory using
```
$ dotnet run
```
* Try API calls in the Postman desktop application to test it out. Documentation below. 

## API Documentation

Get Requests without parameters returns all animals in the shelter.
```
http://localhost:5000/api/animals
```

Get Requests have the option for Six Parameters which can be chained together. 
* String species - returns species match
* String breed - returns breeds containing parameter
* String gender - returns gender match
* Boolean fixed - 
* Boolean houseTrained -
* Boolean vaccinated -
An example of a single paramet


## Known Bugs
* No known bugs, feel free to contact me here if any are found.

## License

[MIT](LICENSE)

Copyright (c) June 2022 Cameron Ray