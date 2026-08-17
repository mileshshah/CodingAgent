using System.ComponentModel;
namespace CodingAgent.Tools
{
    public static class InvolkeCommandTools
    {
        [Description("Executes a shell command. Use when the user asks to run a command.")]
        public static string InvokeCommand(
            [Description("The shell command to execute.")]
            string command)
        {
            try
            {
                System.Diagnostics.Process.Start("cmd.exe", $"/C {command}");
                return $"Command executed successfully.";
            }
            catch (Exception ex)
            {
                return $"Error executing command '{command}': {ex.Message}";
            }
        }
    }
}