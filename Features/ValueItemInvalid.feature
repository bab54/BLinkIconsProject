Feature: ValueItemInvalid

The user would not like to see the values of the the organisation

@tag1
Scenario: Valid Values
Given  a user navigates to the BLinkIcons website "https://blinkicons.reteicons.net/"
When  a user clicks on about item
Then the user should not  be directed to the values page displaying "Our Values & Culture"
	
