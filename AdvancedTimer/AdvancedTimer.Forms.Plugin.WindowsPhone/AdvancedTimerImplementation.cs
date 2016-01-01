using AdvancedTimer.Forms.Plugin.Abstractions;
using System;
using Xamarin.Forms;
using AdvancedTimer.Forms.Plugin.WindowsPhone;
using System.Windows.Threading;

[assembly: Dependency(typeof(AdvancedTimerImplementation))]
namespace AdvancedTimer.Forms.Plugin.WindowsPhone
{
    /// <summary>
    /// AdvancedTimer Implementation
    /// </summary>
    public class AdvancedTimerImplementation : IAdvancedTimer
    {
        DispatcherTimer timer;
        int interval;
        bool autoReset;

        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public static void Init() { }

        /// <summary>
        /// Used for initializing timer and options
        /// </summary>
        public void InitTimer(int interval, EventHandler e, bool autoReset)
        {
            if (this.timer == null)
            {
                this.timer = new DispatcherTimer();
                this.timer.Interval = TimeSpan.FromMilliseconds(interval);
                this.timer.Tick += e;
            }

            this.interval = interval;
            this.autoReset = autoReset;

            if(!autoReset)
                this.timer.Tick += (sender, args) =>
                {
                    timer.Stop();
                };
        }

        /// <summary>
        /// Used for starting timer
        /// </summary>
        public void StartTimer()
        {
            if (this.timer != null)
            {
                if (!this.timer.IsEnabled)
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
        public void StopTimer()
        {
            if (this.timer != null)
            {
                if (this.timer.IsEnabled)
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
        public bool IsTimerEnabled
        {
			get 
			{
				return this.timer.IsEnabled;
			}
        }

        /// <summary>
        /// Used for checking timer interval
        /// </summary>
        public int Interval
        {
			get 
			{
				return this.interval;
			}
			set 
			{
				this.interval = value;
				this.timer.Interval = TimeSpan.FromMilliseconds(value);
			}
        }

    }
}
