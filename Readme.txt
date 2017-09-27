The Solutions consists of the following Projects:

1- Street.Library:- Contains the classes that are responsible for handling all of the street operations like reading street specifications or checking the validity of a certain specifications or the number of houses

2- Street.Tests:- Contains the unit tests for all the code files of the project

3- Street.Console Application:- Contains a simple program that tests the Street Library

Project Street Library Contains the following directories:-

1- Common:- Contains the common classes and interfaces that are shared between story1 and story2.

2- Story1:- Contains all classes and interfaces that handle the business of story1

3- Story2:- Contains all classes and interfaces that handle the business of story2

Directory Street.Library.Common contains the following classes and interfaces:-

1- IStreetSpecifications interface:- represents the base implementation for any service that is responsible for reading the specifications of a certain street, note (The interface is not binded to File streams, but can read the specifications of any source like 
filestream or webservices or anything).

2- FileStreetSpecifications class:- represents the concrete implmentation of the IStreetSpecifications interface, but this class is built specific to read from files.

3- StreetOperation Abstract class:- represents the base implementations for any class that will handle streets, it contains methods to access the FileSpecifications service and reading the data of the street.

Notes:- This class is loosely coupled with the class FileStreetSpecifications by the following:-

a. It implements the base interface that allows any type of streetspecifications reading.

b. It uses dependency injection to create the FileStreetSpecifications object via constructor.

Directory Street.Library.Story1:-

1- IStreetTracker interface :- Represents the base implementation for any class that is responsible for checking the validity of the street and display the number of houses in the street or the number of left houses or the number ofright houses, Using the interface 
gives the advantage of the ability to add any type of tracker (for example if the file format will change, or the criteria to add building together will change)

2- TownPlannerStreetTracker class:- Represents the concrete implementationof the IStreetTracker interface, this class is created specific as the story1 mentions as the following

The street specification file lists all the house numbers in the street from west to east.

- House numbering starts from 1

- All the houses on the left-hand (north) side of the street are oddnumbered- All the houses on the right-hand (south) side of the street are even numbered

- For example, a street specification file containing "1 3 2" can beinterpreted as there being, from west to east:- house #1 on the left-hand (north) side of the street, - followed by house #3, also on the left-hand (north) side of the street, 

- followed by house #2 on the right-hand (south) side of the street.- (Note: in the real world houses on a street are frequently directly opposite each other. For this purposes of this exercise,   this is assumed never to be the case!)
- On each side of the street no number can be skipped and no number can be used more than once

Directory StreetLibrary.Story2:-

1-INewsPaperDeliveryOrder interface:- Represents the base implementation for any class that is responsible for retrieving the order in which the news papers boy will traverse the street.

Notes:- 

1- This interface is independent on the traversing method, so both HouseByHouse and NorthSouth apporoaches are implementing this interface.

2- This interface is responsible only on the delivery order and doesn't calculate the number of turns to cross the street since not all delivery approaches will have the number of turns to cross the street unknown (the north to south approach 
for example always have value 1).2-INewsPaparsDeliveryStreetCrossing interface :- Represents the base implementation for any class that is responsible for retrieving the number of times the news papers boy will cross the street.

3- NewsPaperDeliveryHouseByHouseApproach class:- Represents the class responsible for handling the news papers boy traversing the street house by house, this class implements 2 interfaces:-

a. The INewsPaperDeliveryOrder which is responsible for calculating the correct order of houses. 

b. The INewsPapersStreetCrossing which is responsible for calculating the number of times he will cross the street.

4- NewsPapersDeliveryNorthSouthApproach class:- Represents the class responsible for handling the news papers boy traversing the street north then south, this class implements 1 interface the INewsPaperDeliveryOrder which is responsible for calculating the correct order 
of houses, but it doesn't implement the INewsPapersStreetCrossing.