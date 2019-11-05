# LunchAndLearnCAT

PROBLEM DEFINITION

•Each nanobot has a co-ordinate (X, Y, Z) and a signal radius.
•The radius is how far the nanobot can scan other nanobots.
•You must find the nanobot with the largest radius and calculate how many other nanobots it influences (including itself) using the Manhattan distance.

Example:

pos=<0,0,0>,r=4
pos=<1,0,0>,r=1
pos=<4,0,0>,r=3
pos=<0,2,0>,r=1
pos=<0,5,0>,r=3
pos=<0,0,3>,r=1
pos=<1,1,1>,r=1
pos=<1,1,2>,r=1
pos=<1,3,1>,r=1

The strongest nanobot is the first one (position 0,0,0) because its signal radius, 4 is the largest. 
Using that nanobot's location and signal radius, the following nanobots are in or out of range:

The nanobot at 0,0,0 is distance 0 away, and so it is in range.
The nanobot at 1,0,0 is distance 1 away, and so it is in range.
The nanobot at 4,0,0 is distance 4 away, and so it is in range.
The nanobot at 0,2,0 is distance 2 away, and so it is in range.
The nanobot at 0,5,0 is distance 5 away, and so it is not in range.
The nanobot at 0,0,3 is distance 3 away, and so it is in range.
The nanobot at 1,1,1 is distance 3 away, and so it is in range.
The nanobot at 1,1,2 is distance 4 away, and so it is in range.
The nanobot at 1,3,1 is distance 5 away, and so it is not in range.

In this example, in total, 7 nanobots are in range of the nanobot with the largest signal radius.
