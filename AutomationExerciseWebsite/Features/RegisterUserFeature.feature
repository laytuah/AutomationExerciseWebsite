Feature: RegisterUserFeature

Scenario: Register a user then delete
Given that you Launch browser and Navigate to url http://automationexercise.com
When you Click on Signup / Login button
And Enter signUp name and email address as:
		| Name   | SignUp Email address   |
		| Bisola | MummyAqeelah@gmail.com |
And Click Signup button
And select 'Mrs.' from the title option
And fills in the password field with 'Aqeelah'
And selects from the '5' 'November' '1990' from the Date Of Birth dropdowns
And Select checkbox Sign up for our newsletter!
And Select checkbox Receive special offers from our partners!
And Fill details as below: First name, Last name, Company, Address, Address2, Country, State, City, Zipcode, Mobile Number
		| First name | Last name | Company     | Address    | Address2     | State | City   | Zipcode | Mobile Number  |
		| Bisola     | Tiamiyu   | XYZ Limited | 16, Kajola | Irede street | Oyo   | Ibadan | 200242  | +2348079226500 |
And select 'Australia' from the country dropdown
And Click Create Account button
Then Verify that 'ACCOUNT CREATED!' is visible
When Click Continue button
When Click Delete Account button
Then Verify that 'ACCOUNT DELETED!' is visible and click Continue button


Scenario: Login User with correct email and password
		#Pre-requisite:A valid user must be created
Given that you Launch browser and Navigate to url http://automationexercise.com
When you Click on Signup / Login button
And Enter signUp name and email address as:
		| Name   | SignUp Email address   |
		| Bisola | MummyAqeelah@gmail.com |
And Click Signup button
And select 'Mrs.' from the title option
And fills in the password field with 'Aqeelah'
And selects from the '5' 'November' '1990' from the Date Of Birth dropdowns
And Select checkbox Sign up for our newsletter!
And Select checkbox Receive special offers from our partners!
And Fill details as below: First name, Last name, Company, Address, Address2, Country, State, City, Zipcode, Mobile Number
		| First name | Last name | Company     | Address    | Address2     | State | City   | Zipcode | Mobile Number  |
		| Bisola     | Tiamiyu   | XYZ Limited | 16, Kajola | Irede street | Oyo   | Ibadan | 200242  | +2348079226500 |
And select 'Australia' from the country dropdown
And Click Create Account button
And Click Continue button
And Click LogOut button
And you Click on Signup / Login button
And Enter login email and password as:
		| Login Email Address    | Login Password |
		| MummyAqeelah@gmail.com | Aqeelah        |
And Click login button
Then Verify that 'Logged in as' is visible on the homepage
When Click Delete Account button
Then Verify that 'ACCOUNT DELETED!' is visible and click Continue button