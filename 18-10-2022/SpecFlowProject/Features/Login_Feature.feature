Feature: Login_Feature

A short summary of the feature

@tag1
Scenario: Successful Login with Valid Credentials
    Given User gives userid as 'testuser_1'
    Given  User gives password as 'Test@123'
    When UserClicksLogin
    Then SuccessfulLogin message should display

Scenario: Successful LogOut
    Given  the input is 0
    When User LogOut from the Application
    Then Successful LogOut message should display

Scenario: product to cart and quantity check
Given the prodname is 'Snacks'
Given the quantity is 5
When quantity and product is added to cart
Then Product is not null or empty and quantity is greater than zero which is added