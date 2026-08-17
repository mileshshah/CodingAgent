using CodingAgent.Runner.AgentRunner;
using CodingAgent.Tools;
using Microsoft.Agents.AI;
using Microsoft.Extensions.AI;
using OpenAI;

var apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY")
    ?? throw new InvalidOperationException("Set OPENAI_API_KEY");

var tools = new List<AITool>
{
    AIFunctionFactory.Create(DateTimeTools.GetCurrentDateTime),
    AIFunctionFactory.Create(DateTimeTools.CalculateDateDifference),
    AIFunctionFactory.Create(FileTools.WriteFile),
    AIFunctionFactory.Create(InvolkeCommandTools.InvokeCommand)
};

var chatClient = new OpenAIClient(apiKey)
    .GetChatClient("gpt-4o-mini");
var agent = new ChatClientAgent(chatClient.AsIChatClient(),
        name: "Assistant",
        instructions: """
            You are a friendly and knowledgeable AI assistant.
            Be concise but thorough. If you don't know something, admit it.
            Always respond in the user's language.
            """,
            tools: tools);

Console.WriteLine("Agent ready! Type 'exit' to quit.\n");

await AgentRunner.RunAsync(agent);