Feature: CopyRightIconInvalid

The user would like to see © 2026 - B-LinkIcons, All rights reserved.s

@tag1
Scenario: Valid CopyRightIcons
Given  the User navigates to  BLinkIcons Website "https://blinkicons.reteicons.net/"
Then the user should  not see at the footer "© 2025 - B-LinkIcons, All rights reserved."
	