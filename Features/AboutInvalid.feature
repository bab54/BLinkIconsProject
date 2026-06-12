Feature: AboutInvalid

A short summary of the feature

@tag1
Scenario:Invalid About Button
	Given the  user navigates to BLinkIcons Website "https://blinkicons.reteicons.net/"
	When the user clicks on values button
	Then  the user is  not redirected to About page "About Our Company"