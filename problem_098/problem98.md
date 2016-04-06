# Anagramic squares
## Problem 98
By replacing each of the letters in the word CARE with 1, 2, 9, and 6 
respectively, we form a square number: 1296 = 362. What is remarkable is that, 
by using the same digital substitutions, the anagram, RACE, also forms a 
square number: 9216 = 962. We shall call CARE (and RACE) a square anagram word 
pair and specify further that leading zeroes are not permitted, neither may a 
different letter have the same digital value as another letter.

Using words.txt (right click and 'Save Link/Target As...'), a 16K text file 
containing nearly two-thousand common English words, find all the square 
anagram word pairs (a palindromic word is NOT considered to be an anagram 
of itself).

What is the largest square number formed by any member of such a pair?

NOTE: All anagrams formed must be contained in the given text file.

# Solution Notes

This was the last problem in the first 100 Euler Project problems for me to
solve because it was the toughest for me to solve. I ended up writing the 
most code out of all the first 100 solutions for this one, mainly because
I did not read the problem description close enough at first.

The only thing worth noting is that I used a Ternary Search Tree to 
generate the anagram list, which works really fast. The subsequent search
for squares is not fast and perhaps a candidate for a rewrite, but I am done
with this problem. 
