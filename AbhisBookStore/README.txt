﻿2023-10-29
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

14:57
Added Reopsitory folder in .DataAccess

15:25
Added IRepository file in IRepository folder and modified it.

16:18
created new class in repository and modified it.

2023-11-05
14:45
created 2 files CategoryRepository and ICategoryRepository and modefyed them...

15:55
created SP_Call class in Repositry

16:41
Theren is an error in UnitOfWork file
Error	CS0053	Inconsistent accessibility: property type 'ISP_Call' is less accessible than property 'UnitOfWork.SP_Call'	AbhisBooks.DataAccess

20:41
I Forgot to add public in front of interface in ISP_Call...

2023-11-06
1:00
Created new file named CategoryController in Areas>Admin>Controllers

14:02
runs perfectly and commited to github...

16:09
modified Index file...

16:15
Created JavaScript and linked it to Index file...

16:19
Added Upsert View and modify it....

16:21
Created 2 partial views

16:25
Added asp action to Index file

16:27
Tested it and works perfectly...

19:09
Added script to delete and the delete button works perfectly....

19:11
Assignment part 2 Complete and Now I'll commit it to GitHub....


2023-11-15
22:10
Started Part-3 Section 1

22:16
created CoverType.cs file in Models project.

22:19
added migration and the name of the file is
20231116031911_AddCoverTypeToDb

22:34
created Categoryrepository and ICategoryRepository, and made changs...

22:42
Added CoverType to UnitOfWork and IUnitOfWork

22:52
Added CoverTypeController and updated the code...

23:01
added CoverType Index view and upsert view

23:29
It was not showing the table...

2023-11-16
00:09
thats because i have not made the js file to load the table... Now it works perfectly.

13:27
Created Product.cs class

13:37
added migration and the name of the file is:-
20231116183428_addProductToDb

14:10
Created ProductRepository and IProductRepository

14:17
added product to unitOfWork and IUnitOfWork...
Assignment 2 part 3 section1 completed now i'll commit it to github...


2023-11-17
15:02
Created Product Controller...

15:11
Created ProductVM view in ViewModels and installed .AspNetCore.Mvc.ViewFeature package...


15:36
Modified the productController file...

15:45
Added Index view

15:58
created product.js file and modified it according to category.js file...

16:02
Added link to _Layout.cshtml

16:06
Tested it and it runs perfectly...

16:16
Assignment2 part3 section 2 completed... ;)

2023-11-19
16:47
Started Part3 section3

16:55
Created Upsert for products...

22:44
created account on tiny.cloud and added script for text-area in upsert...

22:49
it runs and the text area is showing

2023-11-20
14:23
Added new subfolder in wwwroot> imges/products
And modefied the code in ProductController...

14:32
when I was creating new product and when i choose CoverType it shows category, so i changed the Upsert of product  and updated it. It was set to CategoryId..

14:35
Assignment 3 section 3 Completed.... now I'll commit it to github

2023-11-25
12:56
1:06 added new migration for product, changed foreign key...
20231125180655_UpdatedProduct

2023-11-27
18:26
for the ajax error i removed space between category and CoverType in product Controller....

18:34
The price and category was not showing in product, so i changed product.js and for price I also changed product index...

18:41
for part 4 I made changes in home Index view....

18:49
made changes in product controller for http post

18:55
made changes in startup.cs

19:02
updated upsert for product...

19:23
created refrence in of product in HomeController....

19:31
there was dash in price in the output.....

19:46
I removed removed strike tag...

19:48
Tested it and runs perfectly.... Ill commit it to github.....


2023-12-05
Added 3 products and published web app to azure.....