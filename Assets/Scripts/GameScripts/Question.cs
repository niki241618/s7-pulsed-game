namespace GameScripts
{
    public class Question
    {
        public Category Category { get; set; }
        public string Text { get; set; }
        public int Points { get; set; } = 1;

        public Question(string text, Category category)
        {
            Category = category;
            Text = text;
        }
    }
}