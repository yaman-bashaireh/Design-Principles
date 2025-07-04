﻿namespace UsingOCP
{
    internal static class QuestionBank
    {
        public static List<Question> Generate()
        {
            return new List<Question>
            {
                new WHQuestion { Title = "What are the four pillars of OOP?", Mark = 8 },

                new MultipleChoiceQuestion {Title = "Which of the following are value types?", Mark = 6, Choices = new List<string> {"A: Integer","B: Array","C: Single", } },

                new TrueFalseQuestion { Title = "Earth is Bigger than sun?", Mark = 4 },

                new MultipleChoiceQuestion { Title = "Which of the following is an 8-byte Integer?", Mark = 6, Choices = new List<string> { "A.  Long", "B.  Integer", "C.  Short" } },

                new MatchQuestion { Title = "Match Column One values with single choice from 2nd Column?", Mark = 10, Rows = new Dictionary<string, string> { { "A", "b" }, { "B", "c" }, { "C", "a" } } }
            };
        }
    }
}