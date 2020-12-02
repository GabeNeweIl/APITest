Feature: GetEmployeesFeature
	This page  scenarios how to access list of employees

Scenario: I do request of employees and i should get 24 employees
Given Create request '/employees' with GET method
And Execute API
When Deserialize the employee api content
Then i should get list of 24 employees


Scenario: I do request of employess and i should get status OK
Given Create request '/employees' with GET method
And Execute API
Then returned status code will be '200'
