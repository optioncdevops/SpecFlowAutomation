Feature:02_UserDetail
A short summary of the feature

Scenario: 001_UserDetail as a admin with valid user credentials
	Given Launch the application with valid user credentials '<URL>' and '<UserName>' and the '<Password>'
	When The Dashboard should be open
	Then Click on Administration menu and selct UserDetail Sub menu
    And UserDetail page should be opened and click on Addnewuser button
	And New user page should be opened and enter the basic info of '<FirstName>' '<LastName>' '<Email>' '<EmailPwd>'
	And click on save button and the record should be saved
	And Search '<Email>' and Click on Edit button and update the fields '<EditFirstName>' '<EditLastName>' and click on save button
	And Search '<Email>' and Click on Delete Button to delete the records
	Then Delete Alert Confirm box should open and Click on the No button
	And Search '<Email>' and Click on Delete Button to delete the records
	Then Delete Alert Confirm Box should open and Click on the Yes button 


Examples: 
| URL                             | UserName             | Password | FirstName | LastName | Email        | EmailPwd | EditFirstName | EditLastName |
| https://viper.allnewoptionc.com | jclement@optionc.com | password | HpTest    | User     | hp1@gmail.com | testing  | EditTest      | User1        |
