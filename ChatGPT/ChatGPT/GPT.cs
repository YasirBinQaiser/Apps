using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenAI_API;
using OpenAI_API.Completions;

namespace ChatGPT
{
class GPT
{

OpenAIAPI openAI = new OpenAIAPI("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");
public async Task<string> GetAnswer(string question)
    {
    CompletionRequest completionRequest = new CompletionRequest();
    completionRequest.Prompt = question;
    completionRequest.Echo = false;
    completionRequest.MaxTokens = 1024;
    completionRequest.Temperature = 0.7;
    completionRequest.Model = OpenAI_API.Models.Model.DavinciCode;

    var x = await openAI.Completions.CreateCompletionsAsync(completionRequest);

    return x.ToString(); // await openAI.Completions.CreateAndFormatCompletion(completionRequest);

    }

}
}
