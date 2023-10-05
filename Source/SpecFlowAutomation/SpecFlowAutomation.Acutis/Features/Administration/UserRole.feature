Feature: 03_UserRole

A short summary of the feature

Scenario: 003_UserRole as a admin with valid user credentials
	Given Launch the application with valid user credentials URL and UserName and the Password
	When Click on Administration menu and selct User Role Sub menu
    And User Role page should be opened and click on Addnewrole button
	And Click on Role Cancel button
    And User Role page should be opened and click on Addnewrole button
	And New user role page should be opened and enter the basic info of User Role Name and Description
	And click on Role save button and the record should be saved
	And Search User Role Name and Click on Edit button and update the fields Edit User Role Name  and  click on save button
	And Click on Delete Button to delete the records
	Then Delete Alert Confirm box should open and Click on the No button
	And Click on Delete Button to delete the records
	Then Delete Alert Confirm Box should open and Click on the Yes button 
	And User should be able to logout from the application
