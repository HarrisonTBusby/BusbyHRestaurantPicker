# BusbyHRestaurantPicker

This program randomizer a bunch of restaurants in hopes of finding something that you want to eat.

This program uses a while loop, else if statements, string arrays, and a randomizer to make the user able to choose what food type they want.


Peer reviewed by: Kenneth Fujimura
Project works for the most part and there's an eligance to how simple your program is. But there's a few bugs worth mentioning:
- When you ask for cateogry inputs, the way you have things set up asks for very specific string inputs that could potentially confuse users. So at the very least, I would include instructions in your code to very clearly instruct the user what to type. So I would include quotes (e.g. "fast food") around the words you're asking the user to type. Because if they type something different but don't get it exactly right it could lead to confusion.
- The else if check for the fast food category on line 23 checks for "fastFood" but your input string forces all inputs to be lowercase. So there's no way to actually call the fast food category. I would probably change this check to "fast food" because you present "fast food" as an option in the program dialog with the user.
- On Line 24, you've got that line indented which I assume is on accident. It doesn't affect how your program runs, and it's not the biggest thing, but it triggers my OCD lol.
Fix those things and I think you've got a pretty solid program.


