### Scoreboard

This is the first real program I ever wrote. I wrote a bunch of little console apps and WinForms apps before this, and I was working with other developers on a much larger project as well. About six months into my learning journey, I decided to take a crack at writing a basketball scoreboard. It pains me to think about how badly I wrote it. 

This is my second try at creating a basketball scoreboard program. I thought it would be good for schools for games. (My first attempt died quietly in Windows recycle bin). I imagine it'll work fine for volleyball and other sports, too, if you just want to display the score and run time outs, but I specifically designed it to be a basketball scoreboard.

The program is written in WinForms using .Net Framework 4.7. I decided to use a singleton pattern for an Event Controller. That way any windows and classes that want to know when changes happen or push changes out to all listeners can subscribe to it. As an accidental bonus, this pattern means that you can open up the "display window" as many times as you like, and all of them will be subscribed to the same Event Controller and show the same values. Maybe that could be useful if you wanted to hook multiple projectors up to the same laptop and show the scoreboard on each of them. 

Since this was the first program I ever built, I didn't have a clue how to create an installer for it. I published it using the Visual Studio built-in publisher wizard, which generated a folder that's supposed to have the .dll's in it that are needed for the install, and then some kind of .msi or something like that, which will unpackage it all. I zipped it and added it to this repo, so you can have at it all you like.

I was working for a business named Tech Support One, LLC when I wrote it, so I added their logo to it. They were using the DevExpress WinForms suite, so that's what I used to provide the prebuilt controls for the program. I think it looks nice, but I can't edit it anymore since I don't work there and I don't have DevExpress on my personal machine. :(

Feel free to use this program however you want to. Have fun!

The controller window has all the buttons for editing the values. It is intended to be used on the laptop screen.
![Controller](https://github.com/bcwalnja/Scoreboard/assets/56313601/e0bdd25a-2e82-43e2-b412-7cf08b3f042c)

The display window shows all the values. It is intended to be used on the projector screen.
![Display](https://github.com/bcwalnja/Scoreboard/assets/56313601/5f123677-15db-453a-af85-aa123d6f5696)
