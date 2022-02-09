## MarsRover

I have made 2 projects one console application which implements Mars Rover and one test project which has unit tests for the same. 

## Console App 

* Application is about a Mars Rover/Robot which can move only forward in the following directions -> North, South, East and West.
* In order to change direction it has 2 ooperations rotate Left or Rotate Right. 

![Magic Diary](https://user-images.githubusercontent.com/15065217/153096215-0869da65-54db-4714-8832-e49eea2676ec.png)

### Task 

* rover controller can send command messages to the rover and make it perform the above movement tasks. 
* Rover can only move on the plateau and will not perform the 'move forward' operation if it is at the edge of the plateau. 

![Magic Diary](https://user-images.githubusercontent.com/15065217/153096265-8a84551e-785c-4de0-8bd7-9ea8e6aa12ba.png)

### Code Skeleton
-- Model <br>
----- Rover.cs<br>
----- Plateau.cs<br>
----- Direction.cs <br>
<br>
-- Utility <br>
---- RoverOperator.cs <br>
<br>
-- Program.cs<br>
-- RoverTask.cs <br>
<br>
* Idea behind making such folder structure was to divide the responsibility of task among the components. 
* Have taken the direction as enum for the ease of read and use of direction in clean way. 
* All the rover's operation is done thorugh RoverOperator which provides extension to the Rover object. 
* Plateau object is used to define the boundaries of the plateau and also has methods to check if rover is at edge of it. 

### TDD approach
* Took up the TDD approach where I started by writing test case for 'plateau edge and rotation scenarios' which can be seen in RoverOperatorTest class.
* After writing the test cases , worte the code for the RoverOperator and other model class. 
* Then ran 2 sample test cases and tested if the output was coming correct. 

### Input and Output
* Input and Output is same as was specified i.e. Dimension of the plateau e.g 5x5 and list of commands LFFRFFLRLR. 
* Rover starts from 1,1 coordinate and traverses as per the command list. 'L' or 'R' or 'F'. 
* Output will be the cordinates of the rover at the end of all the command exection. example: 3,4,West

### Note
* While reading the question I saw that output for the given sample input in the question was wrong as output must have been 1,1,West. instead of 1,4,West. 
