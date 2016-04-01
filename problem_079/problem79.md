# Passcode derivation
## Problem 79
A common security method used for online banking is to ask the user for three 
random characters from a passcode. For example, if the passcode was 531278, they
may ask for the 2nd, 3rd, and 5th characters; the expected reply would be: 317.

The text file, keylog.txt, contains fifty successful login attempts.

Given that the three characters are always asked for in order, analyse the file 
so as to determine the shortest possible secret passcode of unknown length.

# Solution Notes
Strategy, for each passcode
 1) add first digit to front if not already in array
 2) for second and third digit, make sure they come after previous digit
 
Simple stuff really, so the code is short and simple to follow.