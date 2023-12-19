using Exercise;
using Spectre.Console;

var font = FigletFont.Load("../../../public/starwars.flf");

AnsiConsole.Write(
    new FigletText(font, "WTF?")
        .Centered()
        .Color(Color.Yellow2)
);
Application.Run();
