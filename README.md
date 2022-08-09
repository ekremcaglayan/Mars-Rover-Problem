# Mars-Rover-Problem

## Problem
A squad of robotic rovers are to be landed by NASA on a plateau on Mars. This plateau, which is curiously rectangular, must be navigated by the rovers so that their on board cameras can get a complete view of the surrounding terrain to send back to Earth. A rover's position and location is represented by a combination of x and y coordinates and a letter representing one of the four cardinal compass points. The plateau is divided up into a grid to simplify navigation. And we have two types of rovers. An example position might be 0, 0, N, which means the rover is in the bottom left corner and facing North. In order to control a Normal Robot, NASA sends a simple string of letters. The possible letters are 'L', 'R' and 'M'. 'L' and 'R' makes the Normal Robot spin 90 degrees left or right respectively, without moving from its current spot. 'M' means move forward one grid point, and maintain the same heading. Assume that the square directly North from (x, y) is (x, y+1). There are two commands for the Mini Robot, one is 'B' the 180-degree rotation command and 'M' one grid point command.

### Input
The first line of input is the upper-right coordinates of the plateau, the lower-left coordinates are assumed to be 0,0. The rest of the input is information pertaining to the rovers that have been deployed. Each rover has three lines of input. The first line gives the robot's position. Our rover has two types, in the second line we are asked to select the type of our robot. The third line is a series of instructions telling the rover how to explore the plateau. If we want to add a new robot, you must type "Y" in the question "Would you like to continue? (Y/N):".

The position is made up of two integers and a letter separated by spaces, corresponding to the x and y coordinates and the rover's orientation. Each rover will be finished sequentially, which means that the second rover won't start to move until the first one has finished moving. Output: The output for each rover should be its final coordinates and heading. And this code can show where the robot is in matrix.

### Test Input
![image](https://user-images.githubusercontent.com/79373487/183698730-07e0a286-8b1a-4e98-b591-e5653f713872.png)

### Excepted Output
![image](https://user-images.githubusercontent.com/79373487/183698905-d1f3024f-4c9b-4bcd-8feb-7731b478762d.png)
