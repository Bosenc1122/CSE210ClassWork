using System;
{
Journal myjournal = new Journal();

myjournal.AddPrompt(
    new Prompt("How was your day?")
);
myjournal.AddPrompt(
    new Prompt("Where did you go today?")
);
myjournal.AddPrompt(
    new Prompt("What did you learn today?")
);
myjournal.AddPrompt(
    new Prompt("What was your favorite thing that happened today?")
);
myjournal.AddPrompt(
    new Prompt("What was the worst thing that happened today?")
);
myjournal.AddPrompt(
    new Prompt("If you could change something that happened today, what would you change?")
);
myjournal.AddPrompt(
    new Prompt("Who did you meet today?")
);
myjournal.AddPrompt(
    new Prompt("What do you want to do differently tomorrow because of what you did today?")
);
myjournal.AddPrompt(
    new Prompt("What are you grateful for today?")
);
myjournal.AddPrompt(
    new Prompt("How did you impact a stranger today?")
);

myjournal.AddEntry(
    new Entry(
        "May 2, 2023", 
        "Today was my birthday. It was good. I was able to go down to Idaho Falls with my wife and go out to dinner at the restraunt The Bees Knees. We then came back home and watched a movie"
    )
);


Menu _menu = new Menu(myjournal);
_menu.Display();


}

