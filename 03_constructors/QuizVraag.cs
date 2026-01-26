
class QuizVraag
{
    internal string vraag;
    internal string antwoord;


    internal QuizVraag(string vraag, string antwoord)
    {
        this.vraag = vraag;
        this.antwoord = antwoord;
    }

    private void Run()
    {
        QuizVraag quizVraag = new QuizVraag("Hierr komt de vraag","Hier komt het antwoord");
    }
}