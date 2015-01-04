using AdvancedTimer.Forms.Plugin.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace FormsTest
{
    public class App
	{
		static Label label;
        static IAdvancedTimer timer;

        public static Page GetMainPage()
        {
            timer = DependencyService.Get<IAdvancedTimer>();

			label = new Label
			{
				Text = "Hello, Forms!",
				VerticalOptions = LayoutOptions.CenterAndExpand,
				HorizontalOptions = LayoutOptions.CenterAndExpand,
			};

            Button button1 = new Button
            {
                Text = String.Format("Start timer!"),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };

            Button button2 = new Button
            {
                Text = String.Format("Stop timer!"),
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
            };


            button1.Clicked += (sender, args) =>
            {
                label.Text = "Timer Started!";
                timer.initTimer(3000, timerElapsed, true);
                timer.startTimer();
            };

            button2.Clicked += (sender, args) =>
            {
                label.Text = "Timer Stopped!";
                timer.stopTimer();
            };

            return new ContentPage
            {
                Content = new StackLayout
                {
					Children = { label, button1, button2 }
                }
            };
        }

        public static void timerElapsed(object o, EventArgs e)
        {
			//DisplayAlert ("Alert", DateTime.Now.ToString() , "OK");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() =>
            {
                timer.setInterval(timer.getInterval() + 1000);
                label.Text = "Hello, " + DateTime.Now;
            });
        }
    }
}
