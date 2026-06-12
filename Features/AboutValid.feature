Feature: AboutValid

A short summary of the feature

@tag1
Scenario: Valid About Button
	Given a user navigates to BLinkIcons Website "https://blinkicons.reteicons.net/"
	When the user clicks on About button
	Then  the user is redirected to About page "About Our Company"