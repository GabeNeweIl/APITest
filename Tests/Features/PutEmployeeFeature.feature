Feature: PutEmployeeFeature
	This page includes put method scenarios


Scenario: When I do PUT request to update information about employee I should get statuc code OK
When Create request '/update/{id}' with PUT method
And Create URL segment 'id' with parameter '1'
And I create a request boyd with following data
| employee_name | employee_salary | employee_age |
| Test Name     | 1000            | 20           |
And serelaized body to the API request
And Execute API
Then returned status code will be '200'

Scenario: When I do PUT request to update information about employee with wrong id I should get status code Not Found
When Create request '/update/{id}' with PUT method
And Create URL segment 'id' with parameter 'wrong'
And I create a request boyd with following data
| employee_name | employee_salary | employee_age |
| Test Name     | 1000            | 20           |
And serelaized body to the API request
And Execute API
Then returned status code will be '404'