# Boats

#### By _**Nicole Sanders, Katy Daviscourt**_

## Description


## Specifications

### User Stories

* Login as a sales associate or a manager.

* As a sales associate I can perform the following actions on a single page using AJAX.
	* see complete inventory to help customers
	* make a sale, which reduces inventory and increases revenue
	* process a return which returns an item to inventory and credits a refund
	* see all of my sales, and make comments that only I can see
	* calculate my commission based on my individual sales

* As a manager I can perform the following actions on a single page using AJAX
	* see inventory AND costs for inventory items
	* review and edit sales by all sales associates, to correct for errors
	* view sales associate comments on sales
	* see commission for all sales associates
	* add or remove sales associates
	* add new inventory for sale, including item cost and sale price
	* see the total balance sheet for the entire store (revenue - costs = profit)

### Specs

* When you go to the index page, the program has a form that will let you log in or sign up as a manager.
* If the user does not sign in, they will have access to the sales associate pages only
* On every page, if the user is signed in, there will be an option to sign off that will sign you off and redirect to the index page.
* When the user navigates to the inventory page, they will see a list of inventory.
* If you are not logged in, you can choose an item from inventory to make a sale, which will reduce the number of items left and increase revenue by the sale amount.
* If you are not logged in, you can process a return on an item, which will increase the number of items in inventory and decrease revenue by the sale amount.
* If you are not logged in, you can see a list of all past sales and make comments on any of them.
* If you are not logged in, you can calculate your commission based on your individual sales.

* If you are logged in, when you go to the inventory page it will show a list of inventory along with each item's cost.
* If you are logged in, you can view and edit each sale by any associate
* If you are logged in, You can view the comments an associate has made on any sale.
* If you are logged in, you can see a list of all sales associates and each of their commissions.
* If you are logged in, you can add or remove sales associates from the database.
* If you are logged in, you can add new inventory for sale, with properties including name, cost and sale price.
* If you are logged in, you can see the total balance sheet for the whole store, which will include all costs, all revenue and the total profit.


## Setup/Installation Requirements


* Clone this repository
* In the command line navigate to the same folder that the project.json file is located in
* Run the commands:
  * dotnet ef database update

## Known Bugs

There are no known bugs. Please contact us if any are discovered.

## Support and contact details

Contact Nicole Sanders at nsanders9022@gmail.com for any questions, comments, or concerns.

## Technologies Used

* C#
* Visual Studio 2015 Update 3
* Entity Framework 1.0.0 Preview 2
* Identity Framework
* .NET Core 1.0.0 Preview 2 003131
* Microsoft SQL Server Management Studio
* AJAX

### License

*This software is licensed under the MIT license*

Copyright (c) 2017 **_Nicole Sanders, Katy Daviscourt_**
