# Pierre's Sweet and Savory Treats

#### Asia Kaplanyan

## Technologies Used

* C#
* Razor HTML
* VS Code
* .Net 6
* MySQL
* Entity Framework Core 6
* Identity Entity Framework Core 6
* CSS

## Description
A website of a Pierre's Sweet and Savory Treats using MySQL and EF Core. User can login and add/edit/delete treats and flavors as well associate treats with flavors.

### Setup Instructions

#### You Will Need: 

* A code editor, like VS Code
* Git installed
* Install .Net6 SDK

#### Install MySQL Workbench:
* Follow the MySqlWorkbench installation instructions [here](https://www.mysql.com/products/workbench/), open MySql Workbench and select the Local 3306 server. Then select the "Administration" tab and click on "Data Import/Restore".
* In Import Options select "Import from Self-Contained File" and click the "..." button to navigate to the file ending in ".sql" in the top level of this repository.
* Under the "Default Schema to be Imported to" select "New..." and enter schema name of your choice. Click "Start Import" in the bottom right.
* Confirm the import was successful by clicking on the "Schemas" tab and seeing the schema you created listed.

#### Preliminary Project Set-up:
1. Clone or download this repository to your machine.
2. Navigate to the local directory (YourPath/ProjectName.Solution/ProjectName) and create a new file "appsettings.json".
3. Open the file in VS Code and add:
  ```
  {
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
  }
  ```

**IMPORTANT:** Be sure to replace your username, password, and name of your database for the fields [YOUR-USER-HERE], [YOUR-PASSWORD-HERE], AND [YOUR-DB-NAME].

4. Create a .gitignore file and add "appsettings.json", "bin", and "obj" to the ignored file list.  
5. Open your shell (e.g., Terminal or GitBash) and add your .gitignore file and commit it before adding any other files. 
6. Get to the direcotry called "Treats"
7. Install the EntityFrameworkCore.Design by running the following commant in the command line: `dotnet add package Microsoft.EntityFrameworkCore.Design -v 6.0.0`
8. Install Identuty Entity Framework by running the following command: `dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore -v 6.0.0`
9. Create an initial migration: `dotnet ef migrations add Initial`
10. Create your database with the following command: `dotnet ef database update`
11. In the command line, run the command `dotnet run` to compile and execute the console application. Optionally, you can run `dotnet build` to compile this console app without running it.
12. Run `dotnet watch run` in the command line to start the project in development mode with a watcher.
13. Open the browser to _https://localhost:5001_. If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://www.learnhowtoprogram.com/c-and-net/basic-web-applications/redirecting-to-https-and-issuing-a-security-certificate).

## Known Bugs

* Update role feature doesn't function

## License
Enjoy the site! If you have questions or suggestions for fixing the code, please contact me!

MIT License Copyright (c) 2023 Asia Kaplanyan
 Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.