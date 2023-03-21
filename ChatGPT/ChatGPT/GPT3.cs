using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenAI.GPT3;
using OpenAI.GPT3.Interfaces;
using OpenAI.GPT3.Managers;
using OpenAI.GPT3.ObjectModels.RequestModels;
using OpenAI.GPT3.ObjectModels;

namespace ChatGPT
{
class GPT3
{
OpenAIService openAI = null;
public GPT3 ()
    {
    OpenAiOptions aiOptions = new OpenAiOptions();
    aiOptions.ApiKey = "sk-Your Key here";
    openAI = new OpenAIService(aiOptions);
    }

public async Task<string> GetAnswer(string question)
    {
    var completionResult = await openAI.Completions.CreateCompletion(new CompletionCreateRequest()
        {
        Prompt = question,
        Model = Models.TextDavinciV3,
        Temperature = 0.5F,
        User = "YBQ",
        TopP = 0.25F,
        MaxTokens = 1024
        });
    
    StringBuilder strBuilder = new StringBuilder();
    if (completionResult.Successful)
        { 
        foreach (var choice in completionResult.Choices)
            strBuilder.Append(choice.Text);
        }     
    else
        {
        if (completionResult.Error == null)
            {
            strBuilder.Append("Unknown Error");
            }
        strBuilder.Append($"{completionResult.Error.Code}: {completionResult.Error.Message}");
        }

    return strBuilder.ToString();
    }

}
}
