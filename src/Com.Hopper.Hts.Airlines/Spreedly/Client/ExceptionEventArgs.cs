using System;

namespace Com.Hopper.Hts.Airlines.Spreedly.Client
{
    /// <summary>
    /// Useful for tracking server health
    /// </summary>
    public class ExceptionEventArgs : EventArgs
    {
        /// <summary>
        /// The ApiResponse
        /// </summary>
        public Exception Exception { get; }

        /// <summary>
        /// The ExcepetionEventArgs
        /// </summary>
        /// <param name="exception"></param>
        public ExceptionEventArgs(Exception exception)
        {
            Exception = exception;
        }
    }
}
