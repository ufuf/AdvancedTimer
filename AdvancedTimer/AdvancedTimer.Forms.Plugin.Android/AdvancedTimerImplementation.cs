using AdvancedTimer.Forms.Plugin.Abstractions;
using System;
using Xamarin.Forms;
using AdvancedTimer.Forms.Plugin.Droid;
using System.Timers;

[assembly: Dependency(typeof(AdvancedTimerImplementation))]
namespace AdvancedTimer.Forms.Plugin.Droid
{
    /// <summary>
    /// AdvancedTimer Implementation
    /// </summary>
    public class AdvancedTimerImplementation : IAdvancedTimer
    {
        Timer timer;
        int interval;
        bool autoReset;

        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public static void Init() { }

        /// <summary>
        /// Used for initializing timer and options
        /// </summary>
        public void initTimer(int interval, EventHandler e, bool autoReset)
        {
            if (this.timer == null)
            {
                this.timer = new Timer(interval);
                this.timer.Elapsed += new ElapsedEventHandler(e);
            }

            this.interval = interval;
            this.autoReset = autoReset;

            this.timer.AutoReset = autoReset;
        }

        /// <summary>
        /// Used for starting timer
        /// </summary>
        public void startTimer()
        {
            if (this.timer != null)
            {
                if (!this.timer.Enabled)
                {
                    this.timer.Start();
                }
            }
            else
            {
                throw new NullReferenceException("Timer not initialized. You should call initTimer function first!");
            }
        }

        /// <summary>
        /// Used for stopping timer
        /// </summary>
        public void stopTimer()
        {
            if (this.timer != null)
            {
                if (this.timer.Enabled)
                {
                    this.timer.Stop();
                }
            }
            else
            {
                throw new NullReferenceException("Timer not initialized. You should call initTimer function first!");
            }
        }

        /// <summary>
        /// Used for checking timer status
        /// </summary>
        public bool isTimerEnabled()
        {
            return this.timer.Enabled;
        }

        /// <summary>
        /// Used for checking timer interval
        /// </summary>
        public int getInterval()
        {
            return this.interval;
        }

        /// <summary>
        /// Used for setting timer interval
        /// </summary>
        public void setInterval(int interval)
        { 
            this.interval = interval;
            this.timer.Interval = interval;
        }
    }
}
