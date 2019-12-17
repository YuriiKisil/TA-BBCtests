Feature: Fill Question Form(140 symbols)

@mytag
Scenario: Fill Question Form(140 symbols)
	Given I open to BBC.com
	And I go to Question page
	When I fill Question form
	| Input                                            | Data                                                                                                                                         |
	| What questions would you like us to investigate? | Moyes, who spent 11 years at Everton before joining Manchester United,  is among the favourites to replace Silva. Silva. Was it worse it ??? |
	| Name                                             | Alex                                                                                                                                         |
	| Email address                                    | coach@ukr.u                                                                                                                                  |
	| Age                                              | 70                                                                                                                                           |
	| Postcode                                         | 44444                                                                                                                                        |
	Then I decide press Submit or not
