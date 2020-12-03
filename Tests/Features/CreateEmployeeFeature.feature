Feature: CreateEmployeeFeature
	This page includes scenarios to create an employee using correct data

Scenario: When I create employee with correct data I should get new employee entered data and status OK
When Create request '/create' with POST method
And I create a request boyd with following data
| employee_name | employee_salary | employee_age |
| Test Name     | 1000            | 20           |
And serelaized body to the API request
And Execute API
Then returned status code will be '200'
