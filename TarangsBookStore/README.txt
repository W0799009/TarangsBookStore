28-10-2022 17:36
Name: PAtel TArang Jigarbhai
ID: 0799009

I created tye project named TarangsBookStore.
I created the README.txt file.

Started Part 1.1
chacked viewstart.cshtml
Changed the startup.cs file.
Created git repository in lockal as well as on github web.
Kept the repository visibility to private.
Checked homecontroller.cs file
_Layout.cshtml file checked.
_LoginPartial.cshtml file checked.
_valiadtionScriptsPartial.cshtml file checked
_Error.cshtml file checked.
Checked _ViewImports.cshtml and _ViewStart.cshtml files.
Completed part 1.1

28-10-2022 18:29
Started Part 1.2 Debugging.
observed diagnostic Tools while running the application.
Completed Part 1.2


28-10-2022 18:58
Starting  Part 1.3 Bootstrap.
first of all selected bootstrap file online , downloaded the file.
Saved the new file as bootstrap and renamed the old file as bootstrao_old to keep a backup.
Changed the name of the css style sheet in _Layout.cshtml file from bootstrap.mim.css to bootstrap.css
Changed the nav-light to nav-dark and bg-white to bg-primary.
removed text-dark on line 23.
added property 'text-white-50 bg-primary' in class of footer.

In _LoginPartial.cshtml, Removed 'text-dark' from everywhere.
Time to run.
Got an arror that says;
	'HtmlString' does not contain a definition for 'GetAwaiter' and no accessible extension method 'GetAwaiter' 
	accepting a first argument of type 'HtmlString' could be found (are you missing a using directive or an assembly reference?)

I forget to write 'Async' after writing await which was creating an error.

Got the success in part1.3-Bootstrap.

31-10-2022 12:40
starting again.
Changing some css colours.
I changed colour of font, header and footer by changing it in bootstrap.css.
I was trying to change the colour of body tag but it was not happenning so i went into the inspect mode and tried some tricks.
Finally changed it too.
commit to git.

changed the properties to toggle the dropdown.
added the following links in _Layout.cshtml.
<link rel="stylesheet" href="https://cdn.datatables.net/1.10.16/css/jquery.dataTables.min.css" />
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.css" />
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/css/toastr.min.css" />
saved and commit to git.

added another links at the end of the _Layout.cshtml page which are shown below:
<script src="https://cdnjs.cloudflare.com/ajax/libs/jqueryui/1.12.1/jquery-ui.min.js"></script>
<script src="https://cdn.datatables.net/1.10.16/js/jquery.dataTables.min.js"></script>
<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js"></script>
<script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
<script src="https://kit.fontawesome.com/e19c476714.js"></script>


31-10-2022 13:27
Starting dropdown.
added dropdown code in nav of _Layout.cshtml.
saved and commited in git.

3-11-2022 12:16
Starting again.
My dropdown menu is not working so trying to find the error.
Got the problem, I wrote wrong name of the class in li tag.
completd the part 1.3 successfully.
Commit to git

3-11-2022 12:40
starting part 1.4 Set up the project.
added the three project named:
	TarangsBooks.DataAccess
	TarangsBooks.Models
	TarangsBooks.Utility


Coppied the data folder and pasted it in TarangsBooks.DataAccess project
Added the nudget packages of Microsoft.EntityFrameworkCore.Relational(3.1.28).
Delete the Migration folder from the data folder.
Commite to Git.

3-11-2022 19:30
Yeasterday night forgot to write readme.
After deleting the migration folder, I completed the the further steps as following.
Firstly added new package named Microsoft AspNetCore.Identity.EntityFrameworkCore version 3.1.28
Modified the namespace in ApplicationDbContext.cs file.
Deleted all Class1.cs file from all projects.
Built the project and got 48 errors.

And now I addes the modle folder to TarangsBooks.Utility project.

3-11-2022 19:50
Added project reference in .DataAccess and .Modles folder.
Renamred the modle folder to ViewModles.
Commit to git.

3-11-2022 19:50
Changed the namespace in ErroeViewModlel.cs
Completed the modle changes and built which succeded and got three errors in error list.

3-11-2022 20:25
in startup.cs 'AddContext' with the using statement.
Changed the error.cshtml file.
Corrected the default refereance to the errorViewModles to the new.
Commit to git.


-----------------------------------------------------------------------------------------------
                                     STARTING AGAIN
-----------------------------------------------------------------------------------------------
2022-11-04 6:13PM
Deleted repository from Github and cleared whole project from Local.
Created whole project again with project type Web.
Starting Part 2.1.1 Setting up the project.
Completed the reviwing the files.
Completd part 2.1.1

-----------------------------------------------------------------------------------------------
2022-11-04 6:37PM
Starting Part 2.1.2 Debugging
Completed part 2.1.2 

-----------------------------------------------------------------------------------------------
2022-11-04 6:47PM
Starting Part 2.1.3 Bootstrap.
Chossen the Solar Bootstrap.
Replaced the bootstrap file by new bootstrap file of the Solar Theme.
From recent Project which I deleted I have backup of Layout.cshtml file so copied and paste Layout.cshtml file
Run the application and got the DropDown as I aspected.
Completed Part 2.1.3 Bootstrap.

-----------------------------------------------------------------------------------------------
2022-11-04 7:17PM
Starting Part 2.1.4. Add project and Modify.
Created Three Projects in Solution named as follows.
TarangsBooks.DataAccess,
TarangsBooks.Models,
TarangsBooks.Utility.
Copied Data folder and Pasted it into TarangsBooks.DataAccess
Deleted old Data Folder.
Installed Core.Relational and Core.SQLserver Packages version 3.1.28.
Delete the Migration Folder from data Folder.
Installed Identity.EntityFrameworkCore Package version 3.1.28.
Modified namespace in ApplicationDbContext.cs 
Deleted the Class1.cs file from all project.
Build the TarangsBooks.DataAccess

-------------------------------------------------------------------------------------------------
2022-11-04 8:12PM
Moved the models into the TarangsBooks.Models 
Deleted the original Models Folder.
Added Project Reference to DataAccess and Models.
Renamed the Models Folders to ViewModels.
Changed the namespace in ErrorViewModele.
Build the project Successfully.
Modified the startup.cs file.
Remove the using statement and.
Resolved one error and run the project.
It was a big success:) :) :)

-------------------------------------------------------------------------------------------------
2022-11-04 8:44PM
Starting Modification in Utitlity Project.
Created new class in Utility project and changed the Property to public static.
Added project reference to the main project.
In DataAccess Added project reference to modeles and Utility.
Added customer named Area in Areas. 
Changed the route in startup.cs file.
Moved the HomeController.cs file to customer>Controllers folder and deleted Models and Data folder from it.
Updated homeController.cs file.
Moved Home Folder into Vier Folder and modified HomeController Namespace.

----------------------------------------------------------------------------------------------------------------------------
2022-11-09 11:29AM
When I clone the repository from Github, my three projects which I made was found to be (Unloaded) status.
I tried but not getting the solution so creating project again.
Deleted those three project from the solution.
Starting PArt 2.1.4
Starting Part 2.1.4. Add project and Modify.
Created Three Projects in Solution named as follows.
TarangsBooks.DataAccess,
TarangsBooks.Models,
TarangsBooks.Utility.
From local machine, I coppied the content into the new prijects and now checking the content from the ppt.
Deleting the three class from the projects.
Still getting Errors so Decided to start again from beginning.
Befor deleting this project taking backup of README.txt file.

---------------------------------------------------------------------------------------------------------------------------
-------------------------------------------------STARTING PROJECT AGAIN----------------------------------------------------
---------------------------------------------------------------------------------------------------------------------------

2022-11-09 2:15PM
Starting Part 2.1.1 Setting up the project.
Completed the reviwing the files.
Completd part 2.1.1
 
---------------------------------------------------------------------------------------------------------------------------

2022-11-09 2:26PM
Starting Part 2.1.2 Debugging
Completed part 2.1.2 

---------------------------------------------------------------------------------------------------------------------------

2022-11-09 4:53PM
Starting Part 2.1.3 Bootstrap
Chossen the Solar Bootstrap.
Replaced the bootstrap file by new bootstrap file of the Morph Theme.
Part 2.1.3 completed successfully
Run the project and checked the dropdown.
Worked perfectly.

-------------------------------------------------------------------------------------------------------------------------

2022-11-09 6:11PM
Starting Part 2.1.4. Add project and Modify.
Created Three Projects in Solution named as follows.
TarangsBooks.DataAccess,
TarangsBooks.Models,
TarangsBooks.Utility.
Copied Data folder and Pasted it into TarangsBooks.DataAccess
Deleted old Data Folder.
Installed Core.Relational and Core.SQLserver Packages version 3.1.28.
Delete the Migration Folder from data Folder.
Installed Identity.EntityFrameworkCore Package version 3.1.28.
Modified namespace in ApplicationDbContext.cs 
Deleted the Class1.cs file from all project.
Build the TarangsBooks.DataAccess
EndTime: 6:38PM

------------------------------------------------------------------------------------------------------------------------

2022-11-09 6:38PM
Starting Changes in Models.
Added Project Reference to DataAccess and Models.
Renamed the Models Folders to ViewModels.
Changed the namespace in ErrorViewModele.
Build the project Successfully.
Modified the startup.cs file.
Remove the using statement.
solved the errors that were arised.
Ending at: 10:59PM

------------------------------------------------------------------------------------------------------------------------

2022-11-09 10:59PM
Starting Modification in Utitlity Project.
Created new class in Utility project and changed the Property to public static.
Added project reference to the main project.
In DataAccess Added project reference to modeles and Utility.
Added customer named Area in Areas. 
Changed the route in startup.cs file.
Moved the HomeController.cs file to customer>Controllers folder and deleted Models and Data folder from it.
Updated homeController.cs file.
Moved Home Folder into Vier Folder and modified HomeController Namespace.
Runned the project and got the expected result without any error so I'm very happy.<:) <:)
End Ponit: 2022-11-09 11:45PM

-------------------------------------------------------------------------------------------------------------------------

2022-11-09 11:45PM

Starting Changes in Views.
Copied and pasted the _ViewImport and _ViewStart to Customer Area.
Added the correct path in _ViewStart.cshtml.
Runn the application and got the expected result fin ally . Love the Experience.
Added the area named it 'Admin'.
Added view files in the Admin folder 
Deleted data and Model folders.
Deleted the Controller Folder.
Github update.
Completed 2.1.4 successfully.
I rummed the application.
I got an error which I solved by checking my projects again step wise from the part which I changed lastly.

End Time: 2022-11-09 12:28PM
------------------------------------------------------------------------------------------------------------------------

Start Time: 2022-11-10 9:36 PM
Yesterday getting problem opening other pages like Privacy so cleared that error by adding 'Customer' in _Layout.cshtml
End Time: 2022-11-10 9:56 PM

------------------------------------------------------------------------------------------------------------------------

2022-11-11 04:13PM

Clone the repository from GitHub
Build the application ...
Test the application ...
All done ...
End time: 2022-11-11 04:17PM

--------------------------------------------------------------------------------------------------------------------------------------------------------------------
2022-11-11 04:18PM

Open and review the "appsettings.json" file
Update the database name in 3rd line of page .. i.e. Database=TarangsBookStore .. remove prefix and postfix stirng from database name 

Open NuGet package console
Run the command "Add-Migration AddDefaultIdentityMigration" in Default Project : TarangsBookStore
As it showing this error with this default project :
Build started...
Build succeeded.
Your target project 'TarangsBookStore' doesn't match your migrations assembly 'TarangsBooks.DataAccess'. Either change your target project or change your migrations assembly.
Change your migrations assembly by using DbContextOptionsBuilder. E.g. options.UseSqlServer(connection, b => b.MigrationsAssembly("TarangsBookStore")). By default, the migrations assembly is the assembly containing the DbContext.
Change your target project to the migrations project by using the Package Manager Console's Default project drop-down list, or by executing "dotnet ef" from the directory containing the migrations project.
End time: 04:30PM

------------------------------------------------------------------------------------------------------------------------------------------------------------

2022-11-11 04:13PM

Now change the Default project selection to : TranagsBookStore.DataAccess
And run again above command in package manager console
Output is :
Build started...
Build succeeded.
To undo this action, use Remove-Migration.
i.e Migration is done with this command in TarangsBookStore.DataAccess project
The migration file is created with the name of "20221111212244_AddDefaultIdentityMigration.cs"

Open and review this newly created migration file.
Change the related ASP.NET identity of table's columns.
End TIme:  05:15PM

----------------------------------------------------------------------------------------------------------------------------------------------------------

2022-11-11 05:27PM

After migration, now it's to update the database through package manager console 
with the command : "Update-Database"
Output is : 
Build started...
Build succeeded.
Done.

Open and review the updated database from the SQL Server Object Explorer
Build the application ...
Test the application ...
All done ...

Commit changes to the GitHub repository...
End Time: 05:56PM

----------------------------------------------------------------------------------------------------------------------------------------------------------

2022-11-11 06:13PM

Create new cs file in "TarangsBooks.Models" with the name of "Category.cs"
Open and update this "Category.cs" file as per pptx

Open "ApplicationDbContext.cs" file and add Category Database set and don't forget to include namespace

Open NuGet package console
Run the command "Add-Migration AddCategoryToDb" in Current Project selection : TarangsBooks.DataAccess
Output is :
Build started...
Build succeeded.
To undo this action, use Remove-Migration.

After migration, now it's to update the database through package manager console 
with the command : "Update-Database"
Output is : 
Build started...
Build succeeded.
Done.

End Time: 06:59PM

-----------------------------------------------------------------------------------------------------------------------------------------------------------

2022-11-12 01:26PM

Starting Part 2.2.2 Build the project.

Made Repository folder in data sccess project 
Made another folder in Repositoty and named it IRepository.
Created new Interface type file in IRepository folder. 
Changed the using statements.
added the curd operations.
Methods to use for curd operations: GEt Item from Db, List of Items, Add object, remove obeject.
Saved the changes.

Made another class in repository folder and name it Repository.cs.
added a using statements.
ALso modified the class name and visibility.
Using alt enter on error I replaced the colde with the interface.
Replaced the give code in Assignment 2 folder with our Repository.cs file.
replaced the 'andrews' name with tarang name space.
Created new classes in IRepository and Repository and named it ICategoryRepository and CategoryRepository respectively.
Modified the CategoryRepository.cs file.
Got one error about the not useing the ICategoryRepository value.
moving on, Changing the ICategoryRepository file.
changed the namespace and class added.
Using the alt and enter key selected the interface and added the code in CategoryRepository which also solved the error.
Writing the code given in the ppt in CategoryRepository.cs file.
I got an error in FirstOrDefault but then it get solved as i forget to write using statement of Linq in it.
Bild the project with 4 succeed.
Commit to git.
End time: 4:40 PM

----------------------------------------------------------------------------------------------------------------------------------------------------------

2022-11-12 04:41PM
Added a new interface in the IRepository named it ISP_Call.cs file.
Using alt and enter added the nuget pagage manager of dapper.
Added the code block and in the ISP_Call.cs file.
Created new class named SP_Call and implemented appropriate using and ISP_Call interface.
Added addition using of database connectivity.
Changed the whole SP_Call.cs file.
Added an interface type file in IRepository name it IUnitOfWork.
Changed the Code ad save it.
Added new class in the Repository folder and named it UnitOfWork.
Change the code of block as showed in the slides.
build the project with no errors.
Commit to the git.

Getting error when added the like code in the startup.cs file.
Trying to solve the error.
solved it.
I forget to write public in IUnitOfWork file.
Commit to git.
Part 2.2.2 completd successfully.

End Time: 9:00
-----------------------------------------------------------------------------------------------------------------------------

2022-11-13 12:06AM
Starting Part 2.2.3 Category CRUD
Created new controller called CategoryController.cs
Updated that file as given in ppt.
Created new folder in Views of Admin and named it Category.
Created new Index View in Category Folder.
Saved and then run the application.
Completd and checked the index.
Commit to git.
End Time: 12:55AM
------------------------------------------------------------------------------------------------------------------------------------

2022-11-13 12:55AM
Updated the Index.cshtml file.
Created the Category.Js file and copied the posted code on Blackboard.
Updated the index.cshtml file.
Got an error while getting Categories how ever Solved it and commit to git
Update the CategoryController by new code in ppt.
Added view on UPSERT.
Copied Code from Assignment 2 section for UPSERT and Save it .
Created a partial view and nemed it _CreateAndBackToListButton.
Update it with given code block in ppt
Created another partial view and name it _EditAndBackToListButton
Update it with given code block in ppt
Modified the Upsert file.
Adde the asp-action="Upsert" in Index.cshtml.
Run the application .

VAlidation working perfetly.
updated the CategoryController.cs file
solved the error on save function.
Comment the CategoryRepository file _db.SaveChanges code.
Change the place of the save line in Upsert file.
Run the application.
It worked perfectely.
End Time:3.41AM
-------------------------------------------------------------------------------------------------------------------------------------------

2022-11-13 12:03PM
Starting API.
Call the httpDelete in CategoryController.cs file.
Added funtionality in Category.Js file by adding OnClick.
Added the functionality of Delete in Category.js file.
I was not abele to see the delet button as a button, It was just a logo so I tried several things and but not getting the expected result.
Got the error,in the code of onclick, after that code the space was missing so it was not taking that as a button.
Got the expected result as shown in the ppt.
Part 2.2.3 completed successfully.
wheheeeeeeeeeeeeee:) :) :)
Commit to git.
End Time: 1:51PM

-------------------------------------------------------------------------------------------------------------------------------------------------

2022-11-22 10:38PM
Starting Part 2.3.1 Cover Type CRUD
All Things worked successfully.
Created the CoverType.cs file in TarangsDooks.Models project.
Added the ID and Name Category in that class and added the using statement.
Adding Migration.
Migration done successfully.
Updated Database successfully.
Changed the ApplicationDbContext and added the Covertype line.
Created CoverTypeRepository in Repository folder.
Created ICoverTypeRepository in IRepositories.
Changed the content in both files and save the changes.
Added the CoverType in UnitOfWork amd IUnitOfWorlk.

Adde the CoverType in the nav bar.
Added the new controller in the Controller folder and nemed it CoverType.
made all changes in CoverType controller.cs file.
 Created the razor page of index.
 End: 2022-11-23 2:14AM
-------------------------------------------------------------------------------------------------------------------------------------

2022-11-23 10:43PM

Contineuing part 2.3.1 again.

Adde the data of Categories into the Covertype database.
I think it is because of the javascript.
So I am changing the category.js with coverType.js file.
Creating the js file in js folder and Adding the code of Category into it with modifications.
Solved the error and got the empty database of coverType but when I am creating the CoverType I am not getting it .
So I found that I didnt make the upsert so I am getting the problem.
Created the Upsert.cshtml in the CoverType folder.
Completed the Part of Creating CURD pages of CoverType.

END: 2022-11-23 11:12PM
-------------------------------------------------------------------------------------------------------------------------------------

2022-11-23 11:13PM 
Starting 3.2 Product CURD.
Add a new class in .Models Project.
Adde the given code into it and saved the Product.cs file.
Added the Migration which created the file in migration folder named 20221124043408_AddProductToDb.cs
Update Databse.
Checked the product in table of SQL server object Explorer.
Added the required filed in the product.cs file
Added the migration which created the file in migration folder with name 20221124044251_addValidationToProduct.cs
Update the database.
Created the ProductRepository.cs file in Repository folder.
Created the IProductRepository.cs file in IRepository folder.
Updated the ProductRepository.cs file withe the given code in ppt.
Added the product in the UnitOfWork and IUnitOfWork.
Cleared the errors successfully.
Build the project.
Push to Git.
Part 2.3.2 Completd Successfully.
First PPT Completd.

END: 2022-11-23 12:23AM 

----------------------------------------------------------------------------------------------------------------------------

2022-11-23 12:25AM 

Starting Part 3.2 Build the project.
Added the ProductController to the controller folder.
Modified that file and saved.
Added the package named Microsoft.AspNetCore.Mvc.Rendering in all projects.
Created the new file and named it ProductVM in the Models project.
Updated the file as said and added the using statement. 
Comment the upsert code for now after modifying it.
Modifying the API.
created new folder in the view folder and named it Product.
Added new razor page in the view model.
Copied the category view razor page and changed the content.
created new Product.js file and save the changes in it.
Changed the index.cshtml chnages by adding new columns of other product.
Changing the _Layout.cshtml to add a new link of Product.
Run the project. Got an exception, Continue the run.
Commit to git.

Part 3.2 Completed successfully.
End: 2022-11-23 2:30AM 
------------------------------------------------------------------------------------------------------------------------------

2022-11-23 2:59AM 

Created Upsert in the Product folder with partial view.
copied the CoverType Upsert and Saved the file with some initial changes.
Commit to git.

End: 3:10AM
---------------------------------------------------------------------------------------------------------------------------------------------------------

2022-11-23 11:30AM 
Continuing the Changes in the Upsert file.
wrote the code in the Upsert file and saved it.
Added the script tag and those code.
Created the account on given link.
Copied the ID and pasted at appropriate place.
Changed the Model.ID into Model.Product.Id in Upsert.
Run the project.
Moving further.
Creating new folder in wwwroot/images with the name Product.
unComment the necessory code and Run the application.
Commit to git.
End: 1:17PM
-------------------------------------------------------------------------------------------------------------------------------------------------------------

2022-11-23 1:49PM
I was not getting the exect same as shown in ppt of upseart.
Then I found that you already provided the file in the assignment 2 so I copied it and pasted into the upsert form.
Then I was getting the Category dropdown in covertype .
So I chnaged the code yoy provided and got the exect same as shown in PPT.
Still getting error in creating the Product.
Getting this popup wrror when opening the Product page which says ...
"DataTables warning: table id=tblData - Ajax error. For more information about this error, please see http://datatables.net/tn/7".
Commit to git.
End : 2:20PM
