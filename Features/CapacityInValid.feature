Feature: CapacityInValid

The user would like to see the list of services

@tag1
Scenario: Valid Values
Given  the user navigates to the BLinkIcons website "https://blinkicons.reteicons.net/"
When  the user clicks on  about item
Then the user should not be directed to the cpacity page displaying "Our Capabilities"
	
