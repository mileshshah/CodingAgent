using Microsoft.Agents.AI;

namespace CodingAgent.Runner
{
    public static class AgentRunner
    {
        public static async Task RunAsync(AIAgent agent)
        {
            var thread = agent.GetNewThread();

            while (true)
            {
                Console.Write("You > ");
                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input)) continue;
                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase)) break;

                Console.Write("Agent > ");
                await foreach (var update in agent.RunStreamingAsync(input, thread))
                {
                    Console.Write(update.ToString());
                }
                Console.WriteLine("\n");
            }
        }
    }
}