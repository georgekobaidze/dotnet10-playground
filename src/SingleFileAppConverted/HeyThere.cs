
using Spectre.Console;

var calendar = new Calendar(2025, 11);
calendar.AddCalendarEvent(2025, 11, 16);
calendar.HighlightStyle(Style.Parse("blue bold"));
AnsiConsole.Write(calendar);