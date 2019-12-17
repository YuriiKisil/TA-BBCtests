Feature: OtherNewsTitlesCheck
	

@mytag
Scenario: Checking other news titles
	Given I go to BBC.com
	When I open news page
	Then I see other news titles
| Titles                                             |
| New volcanic activity slows NZ recovery efforts    |
| Thunberg accuses world leaders of 'creative PR'    |
| Aramco jumps in world's biggest ever market debut  |
| Protesters storm museum over naked Zapata painting |
#| Merriam-Webster names 'they' its word of the year |
