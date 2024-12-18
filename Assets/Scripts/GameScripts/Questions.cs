using System.Collections.Generic;

namespace GameScripts
{
    public static class Questions
    {
        private static readonly Dictionary<Category, string[]> AllQuestions = new()
        {
            {
                Category.MindMatters, new[] 
                {
                    "Wat doe jij om jezelf op te vrolijken als je een slechte dag hebt?",
                    "Wie is iemand bij wie je je echt fijn voelt om over je gevoelens te praten, en waarom?", 
                    "Wat is iets wat je zou willen doen om te ontspannen, maar nog nooit hebt geprobeerd",
                    "Wat is een uitdaging die je laatst hebt meegemaakt, en hoe heb je die aangepakt?",
                }
            },
            {
                Category.ClicksAndGiggles, new[]
                {
                    "Wat is de grappigste meme of trend die je recent hebt gezien?",
                    "Als je één beroemdheid of influencer zou kunnen ontmoeten, wie zou het zijn en waarom?",
                    "Wat is één lied of playlist die je de laatste tijd steeds op repeat zet?",
                    "Als je één superkracht voor een dag zou kunnen hebben, welke zou het zijn en waarom?",
                }
            },
            {
                Category.DeepDives, new[]
                {
                    "Wat is een onderwerp of iets waar je stiekem van houdt, ook al is het niet je favoriete vak?",
                    "Hoe bereid je je meestal voor op een belangrijke toets of project?",
                    "Als je één ding aan je school zou kunnen veranderen, wat zou het dan zijn??",
                    "Wat denk je dat de belangrijkste eigenschap is van een goed persoon?",
                    "Als je één ding aan de wereld zou kunnen veranderen, wat zou het dan zijn?",
                    "Wat denk je dat het leven betekenisvol maakt?"
                }
            },
            {
                Category.FutureYou, new[]
                {
                    "Welke skill zou je graag willen leren in het komende jaar?",
                    "Stel je voor dat je je ideale baan of hobby hebt in de toekomst. Hoe zou dat eruitzien?",
                    "Wat zorgt ervoor dat je door blijft gaan met je doelen?",
                    "Wat is één ding waar je echt trots op bent aan jezelf?"
                }
            }
        };
        
        
        public static Question QuestionForCategory(Category category)
        {
            var questionsForCategory = AllQuestions[category];
            string text = questionsForCategory[UnityEngine.Random.Range(0, questionsForCategory.Length)];
            
            return new Question(text, category);
        }
    }
}