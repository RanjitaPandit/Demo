Feature: AddProduct
	

@mytag
Scenario: Add an item to Wish List
	Given I click on Search Bar
	And Enter the name of the Product which I want to buy
	And Select an Item from the Product List 
	And I enter Product details 
	When I click on Add to Wish List
	Then The item should Successfully be added to My Wish List
