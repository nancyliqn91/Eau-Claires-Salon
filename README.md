# Eau Claire's Salon

#### By _Qian Li_ 😊

#### This is my independent c# project for practice which creates a MVC web application to help a salon manage employees (stylists) and clients. 

## Technologies Used

* C#
* .NET
* HTML
* MVC
* Entity Framework
* MySQL Workbench
* VS code

## Description

It will serve as a a website where users can add a list of stylists working at the salon, and for each stylist, add clients who see that stylist. 

## Setup/Installation Requirements

* _Clone “Eau-Claires-Salon.solution“ from the repository to your desktop_.
* _Navigate to "Eau-Claires-Salon.solution" directory via your local terminal command line_.
* Run the app, first navigate to this project's production directory called "HairSalon". 
* In the command line, run `dotnet run` in the "HairSalon" directory to run the app. 
* Open the browser to _https://localhost:5001_. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://www.learnhowtoprogram.com/c-and-net/basic-web-applications/redirecting-to-https-and-issuing-a-security-certificate).
* Optionally, you can run `dotnet build` to compile this console app without running it.

## Database Connection String Setup 

* Create an appsetting.json file in the "HairSalon" directory of the project.
* Within appsettings.json, put in the following code, replacing the uid and pwd values with your own username and password for MySQL Workbench.

* Please add this appsettings.json file to the .gitignore file before push this cloned project to a public-facing repository.

HairSalon/appsettings.json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=qian_li;uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}

* Import the database named "qian_li.sql" from the root directory of the project. See instructions below.

## Import Database

* In the Navigator > Administration window, select Data Import/Restore.
* In Import Options select Import from Self-Contained File.
* Under Default Schema to be Imported To, select the New button.
* Enter the name of your database with _test appended to the end. In this case qian_li. Click Ok.
* Navigate to the tab called Import Progress and click Start Import at the bottom right corner of the window.
* After you are finished with the above steps, reopen the Navigator > Schemas tab. Right click and select Refresh All. The database will appear.

## Known Bugs

No bugs 

## License
[MIT](license.txt)
Copyright (c) 2023 Qian Li
