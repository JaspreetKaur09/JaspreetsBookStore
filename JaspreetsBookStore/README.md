******************  Assignment-2  (PART-2)   ********************
*                   Name :~ Jaspreet Kaur                       *
*                   Stu ID :~ 0784780                           *
*                   Date :~ 2022-March-22                       *
*                   Time :~ 11:35 AM                            *
*****************************************************************

OMG! I am so behind ,have a lot to do.I thought assignment is supposed to do only on lab computer .I misuderstood it and now i should rush to do it .
In the class i did the assignment but now after the class i am startin the assignment again because i'm not satissfied :).

3:08 PM:- After doing some house chores Unwillingly :(.  I have created the new MVC application with the individual User accouunt Authentication til now.
         Moving to the safer side , Create a git repository and push it to github (Checking the github to confirm whether it got uploaded or not).

3:15 PM:- Step in  to the part 1.1 and looking over the files in the views folder and then jump to part 1.2 ,run our project ,explore the application in the browser.

3:20 PM :- Now the fun part begin, adding the replacing the bootstrap file to change the look of our application. So i went to bootswatch.com and choose the 
Mint theme.Download the bootstrap.css file and replace the bootstrap.css in the wwwroot/lib/bootstrap/dist/css folder. I just copy paste it.

3:24 PM :- Then i replace the site.css file in the css folder (wwwroot/css).And then link the bootstrap file to the _Layout.cshtml file as well as change the 
nav bar styling from navbar-light to nav-bar dark and bg-darl to bg-primary. Remove the dark text and add the additional properties to the footer.

Then i play game for just 5-7 min (Refresh the mind).

3:42 PM:-I remove the dark text styling from _LoginPartial.cshtml. Then i run the project and look if everything is working well .Everythin g work well,The theme got chnaged.

Push to github again!.

4:00 PM :- Adding aditional stylesheets and scripts to the _Layout.cshtml file. Added the css to the head tag in _layout.cshtml file.Additional script in the footer.

4:32 PM :- Adding the drop down menu to nav bar.Add the drop down menu with sub options in it .Then i save it refresh it and then run it.Push it to github :).

5:04 PM :- Adding the new project to the application.Copy the data folder to the JaspreetsBooks.DataAccess and delete the folder from the aplication.

5:24 PM :- Installing the Microsoft.Entity FrameworkCore.Relational and Core sqlserver Packages.They are succesfuly installed. Now moving to the next Part.

5:32 :- I deleted the migrations folder.Add the Micorosft.AspNetCore.Identity.EntityFrameworkCore Package to the JaspreetsBooks.DataAccess .Then i change the namespace  ApplicationDbContext.cs.
        Then delete the class1.cs file in every project.

6:06 PM :- I move Models folder to the JaspreetsBooks.Models and deleted the original one.The views/Shared/Error.cshtml file  is showing the error becuase model folder
is no there so we add the references to our application of JaspreetsBooks.Models project and of JaspreetsBooks.DataAccess project. Now we update the name of the folder model to ViewModels and change the
namespace in ErrorViewModels.cs file.

6:46 :- Add the Class to JaspreetsBooks.Utility .Adding the project references of the 3 projects to the main application.Then adding project references to the
JaspreetsBooks.DataAccess of the JaspreetsBooks.Models and Jaspreets.Books.Utility.

After a little break! Let's complete the application.

7:36 PM:- Adding the customers folder to the area folder in the application.Change the route in startup.cs file.Then moving the HomeControllers.cs to the 
Controllers folder and delete the data and model folder in the area/customer folder. Add the area controller to the homecontroller.s file.Then changing the
namespace in the Homcontroller.cs.

After having dinner ,watching movie continuing to finish part-1.

9:55 PM :-copy the _ViewImports.cshtml and _ViewStart.cshtml files to Area/Customers folder and then modify the path _ViewStart.cshtml.


******************* FINALLY COMPLETED THE PART-1 (ASSIGNMENT 1)*********************************************

OOPs!
 I fotgot to add the admin now i add it at the last moment. Now it's  done.



 ******************************************************** PART 2 ASSIGNMENT 2 ********************************************************************************************
DATE :- 2022-03-25
TIME :- 7:13 PM 

Now, move to next part of assignment-2 .We are left with 3 parts more.

7:29 PM :- Rebuild the project and look if there is any error.Run the application.Just to check everything is okay.

7:31 PM :- Open appsetting.json file.Change the Database and then add the migration to the JaspreetsBooks.DataAccess.  I got the error of changing the default project
in package console ,after changing the default project then the migration is added.

7:47 PM:- A new migration is created in .Data Access project ,i review the code and the update the database.Then review the sql server to check the tables.
check for the errors and run the application.

After a break moving towards the next part.

9:40 PM :- Freaked out! go errors.Trying to update the database but it's not working. Then fix the bubgs by adding the name method in category.cs and then try to
run the app.It Works!.

10:48 PM:- Reach at the part-2.2 of assignment-2 . Creating a repository folder in JaspreetsBooks.Data Access project and a IRepository as a sub folder in it.
Creating a new item in the Irepository folder to handle the CRUD operations in category.

Upload the files to Github :).

10:58 PM: Make some changes in the IRepository.cs file.Add hte namespace linq.expression and removing the other one and adding some methods in it.

2022-03-26 

10:47 AM :- Creating a new Repository class in Repository folder.Update the code in it according to the file in assignment 2 folder
in BlackBoard.

11:19 AM :- Create the new files in ICategoryRepository and CategoryRepository in the Repository folder.Modify the category Repository
and implement the interface to update to remove the errors.

11:29 AM :-Modify the ICategoryRepository file add the using system statement and add the method in it. 

4:12 PM:- Update the CategoryRepository file,use the .NET LINQ to retrieve the First or default category object and then pass the id as genric entity which matches the category id.
Upload to github :).

6:54 PM :-Add the new interface ISP_Call.cs to the IRepository folder.I update the code in the ISP_Call.cs file

8:42 PM:modify the ISP_Call.cs file ,install the nuget packages for the dogger.Now next step is to add the SP_Call.cs file in the Repository.

2022-03-27
Something went wrong ,now i have to redo the part 2.2 :(
found the error ,the AddCategoryToDb ws not modified.

1:22 PM:-Modifying the AddCategoryToDb.Add the table categpry to the databse and then now i'm going to rebuild the migration and
then update the database.Check the SQl server explorer if the category table is added or not.

2:27 PM:- Still,the databse is not updated the category table is not shwing in the sql explorer window.Mail to the professor to help me out.

2:30 PM:-Redoing the part 2.2 ,actually i copied the files before deleting them from the project.now i'll be creating the file again
and then copy the code only from the previous files. I need to make some chages by myself to make it sure again no error can occur.

3:06 PM:-Redo the steps before adding the unit of work. :( So Tired. *_*

3:27 PM:-Update the ISP_Call and then add the new file SP_call to the repository modify the code. NOw there is ) error in the project :).

4:48 PM:-Add the catehory controller in areas/Admin folder .Then add the index.cshtml in areas/Admin/Vire folder.Modify the code and then push it to github.

                            ****************Redo the project again ************************
Redo the assignment as i was not able to add the category table to my database. So now i'm continuing the project .

2022-04-06 

1:45 PM :- Recreate the migration  ~ ~ ~ 20220406181911_AddCategoryToDb ~ ~ ~ and then i able to solve my issue.The Category table is build.

12:32 PM :- Created the Repository and IRepository folder in the JaspreetsBooks.DataAccess.Create an interface and modify it. 

1:29 AM :- Then i create the ICategoryRepository interface in the  Irepository folder ,update the code. Later addeed the Category Repository class to the project. 
Build the project and upload to github.

1:59 AM :- add on the new interface ISP_Call to the IRepository folder and then update the code.Upload it to github.

2022-04-07 

11:42 AM :- Create the SP_Call class file in the Repository folder and modify the code. Add the interface and add the using statement in the file.

12:54 PM:- Trying to update the startup.cs file but get thi error :(
Error	CS0311	The type 'JaspreetsBooks.DataAccess.Repository.UnitOfWork' cannot be used as type parameter 'TImplementation' in the 
generic type or method 'ServiceCollectionServiceExtensions.AddScoped<TService, TImplementation>(IServiceCollection)'. 
There is no implicit reference conversion from 'JaspreetsBooks.DataAccess.Repository.UnitOfWork' to 'JaspreetsBooks.DataAccess.Repository.IRepository.IUnitOfWork'.	JaspreetsBookStore	C:\Users\Jaspreet Kaur\source\repos\JaspreetsBookStore\JaspreetsBookStore\Startup.cs	39	Active

Solve the error by adding the reference of IUnitOfWork to UnitOfWork.

1:38 PM: Update the startup.cs file and upload it to github.

  ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Lunch time ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
3:57 PM :- Add a Categorycontroller to the Admin Area.Update thr cod and upload it to github.

4:03 PM :- add the view to the Are/Admin/View folder name as index.cshtml and modify the code and link it to the path _Layout,cshtml file.

4:26 PM :-Update the code in _Layout file add the link to category file.The category name was no displayin in the 
droopdown menu so i look over the code and then change the class that i added wrong and then run the program.
Everything goes well.

4:43 PM:- Add the icons to the category page and add the category.js file ,update the code in it.

4:48 PM:-Add the @section call to the index.cshtml file and then save it,upload it to github.

2022-04-10 

11:59 PM :- Update the CategoryController file add an action method to Upsert. 

12:09 Am :- Then i add the Upsert razor view to the category folder and then update the code.
UPLOAD IT TO GITHUB!

12:16 AM:- Create a pratial view in the views folder named it _CreateAndBackToListButton.then update the code.

12:28 AM:- add the title object , model to the Upsert.cshtml file.
UPLOAD IT TO GITHUB!

1:23 AM:- Add the Validation to the add category field. Then upload to github.

1:29 AM:- add the save mthod to CategoryComtoller.cs file.

1:46 AM :- Update the category.js file.
Run the Application.

**************************************** Part 3 Section 1 *********************************
2:16 AM :- Add Product class to Jaspreetsbooks.Models Project.Update the code.

2022-04-15

8:55 PM : - I forogot to add the COvertype class in models project and then update the code ,upload it to github.

2022-04-16 

7:56 PM:- Add the CoverTypeRepositoryClass to repository folder and then uodate the code . 
UPLOAD THE FILE TO GITHUB.

8:00 PM :- Add the ICoverTypeRepository to the Irepository folder ,update the code.Then add the covertype to
UnitOfWork and IUnitOfWork. 

I forgot to add the Interfaces and classes of product . 

8:07 PM :- Add the IProductRepository interface and ProductRepository class to the dataAccess project.

8:24 PM : - Make the minor changes to the code and upload to gihub.

8:48 PM:- Add the migration to the .DataAccess project. 
20220417004812_AddProductToDb .

Earlier it didn't work but then i remove it and add it again. Then it work.

9:02 PM :- Update the product class to title,author. UPLOAD TO GITHUB.

9:05 PM :- 20220417010424_addValidationToProduct
Add the mogration  to  .DataAccess project.Upload to github.

10:00 PM : - Add the product controller to Areas/Admin/Controllers .Modify the code ,add the web host environment to the
controller.

10:30 PM:- Add the ProductVM model to ViewModels ,update the code. Install the  Microsoft.AspNetCore.Mvc.ViewFeatures in the project.

UPLOAD TO GITHUB!

10:37 PM : -Update the Product controller, iAction upser to call productVM. 

10:43 PM :- Add the javascript files for product and coverType.

10:59 PM :- Modify the index.cshtml file in product folder in areas. Link the product.js file to it.

Build the solutino , there is no error. :)

11:06 PM : - Add the Upsert.cs file to Product folder in Areas/Admin/Views.Modify the code.

**************************************************************** PART-4 Assignment 2 ********************************************************************** 
OMG! My category is not adding to the table. I need to review the files.

2022-04-19 
11:40 AM :- Update the code of CategoryController.cs file .
upload it to github. 

11:52 :- Update the _Viewstart.cshtml file link the layout file to it. 

2022-04-20

8:45:- Update the code in category.js file. But still there is sql error in thr projrct.:(

9:14 AM:- Update the addValidationToproduct migration.save it and now let's see if everything is working well.
Atleast now our product page is open earlier there was nothing when we click the product in navbar we are
directed to product page.

9:23 AM :- I don't know why but earlier i downloaded the Micorosft.AspNetCore.Mvc.ViewFeatures package ,now it;s not in the 
dependencies so i download it again.

9:50 AM:- Delete the migration AddDefaultIdentityMigration and add the 20220420134936_AddStoredProcForCoverType to the JaspreetsBooks.DataAccess project.

9:53 AM :- Update the code AddCoverTypeToDb migration.Upload to github.

10:19 AM:-Add the images to images/products folder in wwrootfolder.

10:51 AM:-Update the HomeController.cs file .Upload it to gihub.