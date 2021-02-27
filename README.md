# ResponseLinkAlertOneAssessment
 Developer Skills Assessment Exercise for ResponseLink/Alert1.  Prompt received Feb 20, 2021.

# Development Requirements:
## Project 1
A single shopping cart page with the following:
- Customer Name and address
- Ship Method and Ship Address
- Items Ordered (source hard coded)
- Order total amount
- Submit button to generate JSON object to send to API in project 2

## Project 2
Backend + data tier of the same application:
- REST style endpoints accepting JSON
- Basic security to protect endopint (JWT)
- Only implement Create of CRUD
- Auto connect to database and initialize
- Documentation

# Dependencies
- .Net Core 5
- Node JS (v14.15.5)
- Bootstrap 4.5.3

## NuGet Packages
- MIcrosoft.EntityFrameworkCore.SqlServer v5.0.3
- MIcrosoft.EntityFrameworkCore.Design v5.0.3
- MIcrosoft.EntityFrameworkCore.Tools v5.0.3
- Microsoft.AspNetCore.Authentication v5.0.3
- Microsoft.AspNetCore.Authentication.JwtBearer v2.2.0
- Microsoft.AspNetCore.SpaServices.Extensions v5.0.3
- Microsoft.TypeScript.MsBuild v4.1.4
- System.IdentityModel.Tokens.JWT v6.8.0

# Other Technologies Used
- Visual studio 2019 Community
- Angular Templates Extension (Visual Studio 2019)
- Angular CLI (run `npm install -g @angular/cli` in cmd or powershell)

# Hosting / Testing Instructions
1. open solution in Visual Studio 2019
2. reinstall nuget packages
3. update the connection string in `Data/StoreContext.cs` file to your localhost name if needed
4. run update-database in the package manager console
5. click play button to start in IIS Express
6. the default angular app main page should load with 'Order' and 'Log In' links in the navigation
7. Click 'Log In' to get a JWT Token
8. Click 'Order' to go to a basic order page
9. enter information and click 'Submit Order'

# Development Log
## 2/20/2021: 3 Hrs
- review requirements and reseach which frameworks to use (decided on Angular and DotNet Core 5)
- send email asking about certain parts of the prompt
- make room for Visual Studio update on my PC to get required frameworks
- update VS 2017
- draw mockups while update completes
- prototype in VS Code while waiting for VS 2017 to update
- after update learn that the required .Net Core 3 or 5 are not supported by VS 2017
- install VS 2019 and Node JS
- continue prototyping component code in VS Code while installations download
- let download overnight

## 2/21/2021: 2.75 Hrs
- finish installations
- create new Web project -> Angular template
- work on Cart component
  - new items class that fills array of hard coded cart items
  - load the array into the component
  - added CSS to make the cart match my mockup drawings

## 2/22/2021: 6.25 Hrs
- finish initial CSS for cart
- add Order, Customer, and ShippingOptions servies
- create Address component
- create Order component for displaying full order page
- research nesting components
- update components to work as part of Order component using `@Input()` and reference changes
- changes to typescript interfaces/classes
- fix issues with Address component loading 'Undefined' for all fields
- create Readme.MD (this file) for documenting requirements and time logging
- create shipping option component
- add totals to Order component

## 2/23/2021: 0 Hrs
- full day of work (still working part time for previous employer)


## 2/23/2021: 4 Hrs
- take another look at requirements and decide I made some of this too complicated for what is being asked in the requirements
- removed unnecessary components (Cart, Customer, ShippingOptions) and combined with the Order component
- test that changes did not break previously working code
- make selected shipping option update total cost
- make spacing adjustments with CSS
- fix two-way binding issues in various components and simplify code using `[(ngModel)]`

## 2/25/2021: 4.5 Hrs
- add service ode for communicating with OrderController API
- clean up TypeScript code and move interfaces and classes to their own file in core/models folder
- test for issues after changes
- create OrderController
- Create the database in SSMS on localhost
- create classes in C# Models folder
- research db access options for APIs and all research lead to using Entity Framework Core
- install Entity Framework Core packages
- update models for database constraints
- set up DB Context
- create migration and update database
- finish setting up OrderController `Create()` function

## 2/26/2021: 5 Hrs
- recover from PC crash (crashed sometime overnight)
- test API - receive errors
- research API errors
- fix Entity Framework issues
- API is writing to the database from the angular post call
- look into JWT
- start writing JWT code following tutorial when I discoverd some of the functions are now deprecated
- look into newer JWT creation methods
- start writing new JWT creation code

## 2/27/2021: 4.75 Hrs
- finish JWT creation code
- look into where and how to store JWT
- add code to store JWT in the local storage of the browser
- implemented 'Log In' button that gets the token and saves it in the browser
- added code to display a 'Log Out' button when a token exists to allow removing it
- update order form to get and pass the JWT token when posting to the Create API
- update order form to display text on success/fail of the API call
- type documentation/comments in code
- finish README.md file

Total Time including installation of software, research, and development: 30.25 Hrs