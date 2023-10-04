Feature:02_UserDetail
A short summary of the feature

Scenario: 002_UserDetail as a admin with valid user credentials
	Given Launch the application with valid user credentials URL and UserName and the Password
	When Click on Administration menu and selct User Detail Sub menu
    And UserDetail page should be opened and click on Addnewuser button
	And New user page should be opened and enter the basic info of FirstName, LastName, Username and password and user typen
	And click on save button and the record should be saved
	And Search Username and Click on Edit button and update the fields EditFirstName and EditLastName and click on save button
	And Search Username and Click on Delete Button 
	Then Delete Alert Confirm box should open and Click on the No button
	And Search Username and Click on Delete Button to delete the records
	Then Delete Alert Confirm Box should open and Click on the Yes button 
	And User should be able to logout from the application

 