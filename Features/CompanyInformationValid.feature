Feature: CompanyInformationValid

A short summary of the feature

@tag1
Scenario Outline: Valid company Information
Given  the User navigates to the BLinkIcons website "https://blinkicons.reteicons.net/"
Then at the footer the user should see "<information>"
Examples:
| information                  |
| About Us                     |
| Contact Us                   |
| Modern Slavery Act Statement |
| Industries                   |
| Services                     |
| News                         |
		

