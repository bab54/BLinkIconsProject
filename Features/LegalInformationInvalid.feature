Feature: LegalInformationInvalid

A short summary of the feature
A short summary of the feature

@tag1
Scenario Outline: Invalid Legal Information
Given a  User navigates to  BLinkIcons Website "https://blinkicons.reteicons.net/"
Then at the footer under company information   the User should not see "<information>"
Examples:
| information            |
| Privacy Statement      |
| Terms & Conditions     |
| Cookie Policy/Settings |
| Terms Of Use           |
		

