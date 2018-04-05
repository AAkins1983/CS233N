/* #4: Briefly describe the function and the significance of each of the numbered sections of code 
in this C# program. The code is taken from one solution for the click event handler shared by all 
of the cards in the Concentration game you created in lab 3. */

object sender = The first the object that generated the event; in this case a picture box… What
did the user click?

(PictureBox)sender = casting “sender” as a PictureBox, because sender is the most generic object.

(card.Name.Substring(4)) = using the substring method to get the character in index 4; gets the 
value in the index.

Index1 = cardIndex = assignment statement, assigning “cardIndex” to “index1.”

cards[cardIndex] = Going to array of filenames and getting the filename that matches with the 
PictureBox, and creating an image that gets shown in that PictureBox