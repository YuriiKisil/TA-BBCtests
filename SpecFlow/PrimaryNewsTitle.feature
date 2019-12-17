Feature: PimaryNewsTiyle
	User goes to BBC News page and check primary title/

@mytag
Scenario: Check Primary Titles
	Given I go to BBC.com web site
	When I go to the News Page 
	Then I can see BBC New page and '<PrimaryNewsTitle>'news article on page
Examples:
	| PrimaryNewsTitle                                |
	| Suu Kyi rejects genocide claims at top UN court |