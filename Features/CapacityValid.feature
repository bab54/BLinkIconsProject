Feature: CapacityValid

The user would like to see the list of services

@tag1
Scenario: Valid Values
Given  the user navigates to  BLinkIcons website "https://blinkicons.reteicons.net/"
When  the user clicks on capacity item
Then the user should be directed to the cpacity page displaying "Our Capabilities"
	
