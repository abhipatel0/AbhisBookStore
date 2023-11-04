2023-10-29
14:38
Created a new project named AbhisBookStore using .net 5.0

14:40
Removed this (options => options.SignIn.RequireConfirmedAccount = true) piece of code from startup.cs 

14:42
createa a Github repository...

14:46
Reviewed part 1

14:49
Debugging completed.

15:08
Added bootstrap theme named Plus and it successfully runs...

15:10
Comited the code to github. 

2023-10-30
14:35
Added additional CSS And Script...

14:50
Added dropdown menu... 

15:02
Added three projects... C# library Verson 3.1
And named them: - AbhisBooks.DataAccess
							.Models
							.Utility

15:05
Copyed and pasted data folder to .DataAccess project and deleted the old one...

15:07
Installed the packages..

15:15
Deleted the migration folder...

15:29
Changed the namespace in ApplicationDbContext.cs
And Deleted all the Class1.cs from 3 projects.

18:03
moved the models folder...
and changed the namespace

18:47
solved the errors and it runs successfully.... 
the error was in HomeController.cs the error namespace was missing.

19:16
Added SD.cs class in Utility project

19:20
edited SD.cs and add added refrences...

19:40
Added new area...

20:14
Updated the customers area and it runs perfectly...

20:23
Added Admin area and did the useful updates... And it runs sucessfully...

20:24
Comited to github...
but i saw that the three projects were not uploaded to github.... So I asked my classmate aand he told me to create the whole project again and this time we do not have to check the 'Place the solutions and projects in same folder'option...

2023-10-31
1:55
Finally my project is done and I'm comiting it to github....

2023-11-04
13:39
Started part 2

13:52
Added migration to .DataAccess project using Comand  add-migration AddDefaultIdentityMigration
The name of file is 20231104175149_AddDefaultIdentityMigration

14:07
added Category.cs file in .Models project and edited it...

14:33
added migration using command add-migration AddCategoryToDb
The name of file is 20231104183315_AddCategoryToDb

14:41 
now I'm asked to re-run the migration command but it shows error that "The name 'AddCategoryToDb' is used by an existing migration."

14:42
So i removed the previou migration using command Remove-Migration...

14:49
Added new migration named 20231104184850_AddCategoryToDb