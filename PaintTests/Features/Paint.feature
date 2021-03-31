Feature: Paint

Scenario: Open image, cut it and closed without changes.
	Given Paint is open
		And all old instance were closed
	When I open an image "test.jpg" from "C:\Users\d.stavitsky\Downloads"
		And I click button select all
		And I click button cut
		And I close app without saving
	Then image should not have changed