using System.Collections.Generic;
using Forms.Core.Models.Pages;
using Forms.Core.Models.Questions;
using Forms.Core.Models.Static;
using Forms.Core.Models.Validation;

namespace Forms.Core.Forms.Test.FormElements
{
    public class RegularTextInput
    {
        public static Task Task => new Task
        {
            Id = "text-input-task",
            Name = "Text input (regular)",
            GroupNameIndex = 2,
            TaskItems = new List<ITaskItem>
            {
                new TaskQuestionPage
                {
                    Id = "text-input-page",
                    Header = "Enter an alphanumeric value",
                    Questions = new List<BaseQuestion>
                    {
                        new TextInputQuestion
                        {
                            Id = "question1",
                            Label = "Label goes here",
                            Hint = "Hint goes here",
                            Validator = new TextInputValidation(new TextInputValidationProperties()
                            {
                                IsRequired = true,
                                MaxLength = 50,
                                MinLength = 10
                            })
                        }
                    },
                }
            }
        };
    }
}