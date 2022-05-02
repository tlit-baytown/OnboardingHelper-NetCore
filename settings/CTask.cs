namespace Zest_Script.settings
{
    /// <summary>
    /// This class is used to hold message information while performing the on-boarding process.
    /// This class cannot be inherited.
    /// </summary>
    public sealed class CTask
    {
        /// <summary>
        /// A short display message.
        /// </summary>
        public string ShortMessage { get; set; } = string.Empty;
        /// <summary>
        /// A longer, more descriptive message.
        /// </summary>
        public string DescriptionMessage { get; set; } = string.Empty;

        /// <summary>
        /// Create a new CTask object.
        /// </summary>
        public CTask() { }

        /// <summary>
        /// Create a new CTask object with the specified arguments.
        /// </summary>
        /// <param name="shortMessage">A short display message.</param>
        /// <param name="descriptionMessage">A longer, more descriptive message.</param>
        public CTask(string shortMessage, string descriptionMessage)
        {
            ShortMessage = shortMessage;
            DescriptionMessage = descriptionMessage;
        }
    }
}
