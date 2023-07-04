Feature: LanguagesFeature

I would like to create, edit, delete Languages in Project Mars profile

@tag1
Scenario: [Creat new languages record with valid details]
	Given [I logged into webportal successfully]
	When [I create a new language record]
	Then [The record should be created successfully]
