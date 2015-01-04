using System;

namespace AdvancedTimer.Forms.Plugin.Abstractions
{
    /// <summary>
    /// AdvancedTimer Interface
    /// </summary>
    public interface IAdvancedTimer
    {
        /// <summary>
        /// Used for initializing timer and options
        /// </summary>
        void initTimer(int interval, EventHandler e, bool autoReset);

        /// <summary>
        /// Used for starting timer
        /// </summary>
        void startTimer();

        /// <summary>
        /// Used for stopping timer
        /// </summary>
        void stopTimer();

        /// <summary>
        /// Used for checking timer status
        /// </summary>
        bool isTimerEnabled();

        /// <summary>
        /// Used for checking timer interval
        /// </summary>
        int getInterval();

        /// <summary>
        /// Used for setting timer interval
        /// </summary>
        void setInterval(int interval);
    }
}
