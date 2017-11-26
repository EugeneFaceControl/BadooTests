Feature: Liker
	In order to put likes
	As a user
	I want to be put likes

@mytag
Scenario: Like a girl
	Given I navigate to login page
	And I login via facebook
	When I submit my user's data
	And I like 100 times
	Then I see pop up window with notification