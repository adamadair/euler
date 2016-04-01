#XOR decryption
##Problem 59
Each character on a computer is assigned a unique code and the preferred 
standard is ASCII (American Standard Code for Information Interchange). For 
example, uppercase A = 65, asterisk (*) = 42, and lowercase k = 107.

A modern encryption method is to take a text file, convert the bytes to ASCII, 
then XOR each byte with a given value, taken from a secret key. The advantage 
with the XOR function is that using the same encryption key on the cipher text, 
restores the plain text; for example, 65 XOR 42 = 107, then 107 XOR 42 = 65.

For unbreakable encryption, the key is the same length as the plain text 
message, and the key is made up of random bytes. The user would keep the 
encrypted message and the encryption key in different locations, and without 
both "halves", it is impossible to decrypt the message.

Unfortunately, this method is impractical for most users, so the modified method
is to use a password as a key. If the password is shorter than the message,
which is likely, the key is repeated cyclically throughout the message.
The balance for this method is using a sufficiently long password key for
security, but short enough to be memorable.

Your task has been made easy, as the encryption key consists of three lower case
characters. Using cipher.txt (right click and 'Save Link/Target As...'), a file
containing the encrypted ASCII codes, and the knowledge that the plain text must
contain common English words, decrypt the message and find the sum of the ASCII
values in the original text.

## Solution Notes
I enjoyed this problem very much. There were many different ways to attack the
problem. I took an iterative approach, each step getting closer to the final
solution.

1. Generate all possible keys. This ends up being 17576 possible solutions.
Looping through all keys and generating all possible decryption candidates 
into a file made a text fil 20+MB large, which was too large to search through
looking for english text effectively.

2. Add a test for unprintable characters. If any are in the decrypted text 
throw out that key as a possible solution. This filtered many, and made the 
output small enough to probably search through.

3. Given the description of the problem I used a regular expression to look 
for characters that would not normally be found in printed english text and 
that provides the only solution.

If this hadn't worked I was going to dust off my TST based dictionary code and 
do a proper comparison of potential words with the dictionary, but this worked
out OK.