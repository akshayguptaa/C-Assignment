Feature: Checking the functionality of flight booking at Expedia.com

Scenario: aOpen browser and website
Given Open the GoogleChrome  
Then Open the Expedia Website

Scenario: bMulticity Round trip
Then select flight tab
And select MultiCity Option
Then enter Source1 and Destination1
And Choose DateOfJourney1 and Choose Number of travelers
Then now choose Source2 and Destination2
And Choose DateOfJourney2 
Then now choose Source3 and Destination3
And Choose DateOfJourney3


Scenario: cSearching the flights for trip
Then Click On the Search Button


Scenario: dTrip Summary
When Ensuring correct information of all three flights
Then Ensuring the correct amount per person 

 Scenario: eClosing the Browser
     When Report are generate
     Then now Close browser
      

