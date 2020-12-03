Feature: GetSpecificEmployee
	This page containes scenarios how to access a specific employee




Scenario: I do request for employee and I should get employee with unique id
When Create request 'employee/{id}' with GET method
And Create URL segment 'id' with parameter '1'
And Execute API
And Deserialize the employee api content
Then The employee should have the following values
| id | employee_name | employee_salary | employee_age |
| 1  | Tiger Nixon   | 320800          | 61           |


Scenario: I do request for employee and I should get status "200"
When Create request 'employee/{id}' with GET method
And Create URL segment 'id' with parameter '1'
And Execute API
Then returned status code will be '200'

Scenario: I do request with wrong segment "id" and response code must be 404
When Create request 'employee/{id}' with GET method
And Create URL segment 'id' with parameter 'wrong'
And Execute API
Then returned status code will be '404'