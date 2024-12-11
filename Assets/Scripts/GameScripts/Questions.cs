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
                    "What’s one thing you do to cheer yourself up on a tough day?",
                    "Who is someone you feel comfortable talking to about your feelings, and why?", 
                    "What’s a stress-relief activity you’ve always wanted to try but haven’t yet?",
                    "What’s a challenge you faced recently, and how did you overcome it?",
                    "What advice would you give to someone feeling nervous about something?",
                    "What’s a piece of advice you’ve received that really stuck with you?",
                }
            },
            {
                Category.DeepDives, new[]
                {
                    "What’s a subject or topic you secretly love, even if it’s not your favorite class?",
                    "How do you usually prepare for an important test or project?",
                    "If you could change one thing about your school, what would it be?",
                    "What do you think is the most important quality in a good person?",
                    "If you could change one thing about the world, what would it be?",
                    "What do you think makes life meaningful?",
                }
            },
            {
                Category.ClicksAndGiggles, new[]
                {
                    "What’s the funniest meme or trend you’ve seen recently?",
                    "If you could meet any celebrity or influencer, who would it be and why?",
                    "What’s one song or playlist you keep on repeat these days?",
                    "What’s one song or playlist you keep on repeat these days?",
                    "If you could have any superpower for a day, what would it be and why?",
                    "What’s the most unusual food you’ve ever tried or want to try?",
                    "If you could invent a holiday, what would people celebrate and how?",
                    "What’s your favorite thing about social media, and what’s something you dislike?",
                }
            },
            {
                Category.FutureYou, new[]
                {
                    "What’s a skill you’d like to learn in the next year?",
                    "Imagine your ideal job or hobby in the future. What would it be?",
                    "What motivates you to keep working toward your goals?",
                    "What’s one thing about yourself that you’re really proud of?",
                    "How do you usually express yourself when you’re feeling creative?",
                    "If you could design a T-shirt to represent your personality, what would it look like?"
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