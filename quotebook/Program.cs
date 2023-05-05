// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Source source = new Source("None Were with Him","https://www.churchofjesuschrist.org/study/general-conference/2009/04/none-were-with-him");

Console.WriteLine(source.Stringify());

Quote holland = new Quote("Elder Holland","Because Jesus walked such a long, lonely path utterly alone, we do not have to do so.",source);

//Console.WriteLine(holland.GetQuote());

Board quoteboard = new Board();

quoteboard.AddQuote(
    new Quote(
        "Paul",
        "God hath not given us the spirit of fear; but of power, and of love and of a sound mind.",
        new Source("2 Timothy 1:7")
    )
);

quoteboard.AddQuote(
    new Quote(
        "Sister Elain S. Dalton",
        "Work Hard to achive your dreams. Don't let discouragment or mistakes delay you.",
        new Source("How to Dare Great Things",
        "https://www.churchofjesuschrist.org/study/new-era/2012/03/hot-to-dare-great-things?lang=eng"
        )
    )
);

quoteboard.AddQuote(
    new Quote(
        "Alma",
        "If ye have faith ye hope for things which are not seen, which are true.",
        new Source("Alma 32:21")
    )
);

quoteboard.AddQuote(
    new Quote(
        "Alma",
        "Live in thanksgiving daily.",
        new Source("Alma 34:38")
    )
);

quoteboard.AddQuote(
    new Quote(
        "Elder Joseph B. Wirthlin",
        "Because of [Him], we will live forever.",
        new Source("Timely Topics: What is the Difference between Immortality and Eternal Life?",
        "https://www.churchofjesuschrist.org/study/new-era/2006/11/what-is-the-difference-between-immortality-and-eternal-life"
        )
    )
);

//quoteboard.GetRandomQuote();

Menu _menu = new Menu(quoteboard);
_menu.Display();
