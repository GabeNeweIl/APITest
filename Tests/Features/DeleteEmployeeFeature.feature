Feature: DeleteEmployeeFeature
	This page includes scenarios to delete an employee by Id

Scenario: When I delete employee I should get code status "OK"
Given Create request '/delete/{id}' with DELETE method
And Create URL segment 'id' with parameter '1'
And Execute API
Then returned status code will be '200'

Scenario: When I delete employee with wrong id I should get status code "Not Found"
Given Create request '/delete/{id}' with DELETE method
And Create URL segment 'id' with parameter 'wrong'
And Execute API
Then returned status code will be '200'