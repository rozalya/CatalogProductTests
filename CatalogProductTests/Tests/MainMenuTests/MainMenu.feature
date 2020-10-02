Feature: MainMenu

Background: 
	Given cockies are accepted
	When  Defualt menu settings are cleared

Scenario: Catalog is loaded
	Then product catalog is loaded


Scenario: Refresh functionality
	Given Refresh button is clicked
	Then The page is refreshed

Scenario: Next page functionality
	Then Next page button is clicked
	 And The next page is displayed

Scenario Outline: Export file
	 Then Export of Type is in progress

Examples: 
	| Type   |
	|  PDF   |
	|  CSV   |
	|  XLSX  |
	|  PPTX  |
	|  RTF   |
	|  IMAGE |
	|  DOCX  |

Scenario: Print file
	Then Print button is clicked
	Then Print file is in progress

Scenario: Table of Contents links
Then click on link
 And The chosen page is displayed
