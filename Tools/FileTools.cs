using System.ComponentModel;
namespace CodingAgent.Tools
{
    public static class FileTools
    {
        [Description("Writes content to a file. Use when the user asks to write to a file.")]
        public static string WriteFile(
            [Description("The path to the file to write.")]
            string filePath,
            [Description("The content to write to the file.")]
            string content)
        {
            try
            {
                File.WriteAllText(filePath, content);
                return $"Content written to '{filePath}' successfully.";
            }
            catch (Exception ex)
            {
                return $"Error writing to file '{filePath}': {ex.Message}";
            }
        }
    }
}