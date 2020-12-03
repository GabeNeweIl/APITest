Feature: GetEmployeesFeature
	This page  scenarios how to access list of employees


Scenario: I do request of employees and I should get 24 employees
When Create request '/employees' with GET method
And Execute API
And Deserialize the employees api content
Then I should get list of 24 employees


Scenario: I do request of employess and I should get status OK
When Create request '/employees' with GET method
And Execute API
Then returned status code will be '200'
