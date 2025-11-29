public static class Joke
{
    readonly static string[] jokes =
    {
        "Knock, knock.\nWho’s there?\nLettuce.\nLettuce who?\nLettuce in, it's cold out here!",
        "Knock, knock.\nWho’s there?\nCow says.\nCow says who?\nNo, silly—cow says mooooo!",
        "Knock, knock.\nWho’s there?\nTank.\nTank who?\nYou're welcome!",
        "Knock, knock.\nWho’s there?\nBoo.\nBoo who?\nAw, don’t cry!",
        "Knock, knock.\nWho’s there?\nEtch.\nEtch who?\nBless you!",
        "Knock, knock.\nWho’s there?\nNana.\nNana who?\nNana your business!",
        "Knock, knock.\nWho’s there?\nIce cream.\nIce cream who?\nICE CREAM every time I see a scary movie!",
        "Knock, knock.\nWho’s there?\nHarry.\nHarry who?\nHarry up and answer the door!",
        "Knock, knock.\nWho’s there?\nInterrupting cow.\nInterrupting cow wh—\nMOOOO!",
        "Knock, knock.\nWho’s there?\nWooden shoe.\nWooden shoe who?\nWooden shoe like to hear another joke?"
    };

    public static string TellMeAJoke()
    {
        var rnd = new Random();
        int index = rnd.Next(jokes.Length);

        return jokes[index];
    }
}