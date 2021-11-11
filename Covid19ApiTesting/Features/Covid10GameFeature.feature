Feature: Covid10GameFeature
	Hit Endpoints of Covid19 game 

@HitEndpointsOfCovid19GameWithValidToken
Scenario: Hit Covid10Game Endpoints with valid Token
	Given Get Token for Covid Game
	When Verify The Token
	Then Get The list of users for the game
	| attribute | value |
	| Status    | OK    |