# Coded triangle numbers
## Problem 42
The nth term of the sequence of triangle numbers is given by, tn = ½n(n+1); so the first ten triangle numbers are:

1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...

By converting each letter in a word to a number corresponding to its alphabetical position and adding these values we form a word value. For example, the word value for SKY is 19 + 11 + 25 = 55 = t10. If the word value is a triangle number then we shall call the word a triangle word.

Using words.txt (right click and 'Save Link/Target As...'), a 16K text file containing nearly two-thousand common English words, how many are triangle words?

# Solution Notes

1. Added brackets around the provided data set to make it valid JSON, which makes it easier (I think) to get it into an array.
2. Since this was the second time calculating word values I added letter.rb to the working library in case we have to do it again.
3. Used a hash to store the triange numbers, which provided a quick lookup from the calculated word value.