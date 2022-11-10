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
2022-11-09 11:45PM

-------------------------------------------------------------------------------------------------------------------------

2022-11-09 11:45PM

Starting Changes in Views.
Copied and pasted the _ViewImport and _ViewStart to Customer Area.
Added the correct path in _ViewStart.cshtml.

