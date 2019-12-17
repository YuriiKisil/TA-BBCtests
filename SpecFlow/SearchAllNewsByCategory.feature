Feature: SearchAllNewsByCategory
	

@mytag
Scenario: Search All News By Category
	Given I go to NewsPage on BBC.com
	When I see category of main News
	Then I search all news of this category and check the <First article>
Examples: 
	| First article |
	| Asia          | 