Feature: LegalInformationValid


A short summary of the feature

@tag1
Scenario Outline: Valid Legal Information
Given a  User navigates to  BLinkIcons website "https://blinkicons.reteicons.net/"
Then at the footer the User should see "<information>"
Examples:
| information            |
| Privacy Statement      |
| Terms & Conditions     |
| Cookie Policy/Settings |
| Terms Of Use           |
		

