namespace Zest_Script.userControls
{
    /// <summary>
    /// This interface should be used when a user control allows its values to be updated by
    /// the configuration. When a configuration is loaded or created, the <see cref="UpdateValues"/>
    /// method is called for all implementing classes.
    /// </summary>
    public interface IUpdatable
    {
        /// <summary>
        /// Indicate how the control should update its values based on the current configuration.
        /// </summary>
        public bool UpdateValues();
    }
}
