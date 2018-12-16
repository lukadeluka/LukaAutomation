Feature: MyAccount
	In order to use all functionallities
	As a user
	I want to be able to manage my account

@MyAccount
Scenario: User can log in
	Given user opens sign in page
	And enters correct credentials
	When user submits the login form
	Then user will be logged in

@MyAccount
Scenario: User can add wishlist
	Given user opens sign in page
	And enters correct credentials
	Given user submits the login form 
	When user opens my wishlist
	Then can add new wishlist
