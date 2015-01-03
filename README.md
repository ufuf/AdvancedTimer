AdvancedTimer
=============

AdvancedTimer implementation for Xamarin.Forms

## AdvancedTimer
Timer object and its methods are implemented for extended support for timers.
You can start, stop, change interval of a timer.
For Xamarin.Forms projects
Can be used with Dependency service.

#### Setup
* Available on NuGet
* Install into your PCL project and Client projects.

In your iOS, Android, and Windows Phone projects please call:

```
AdvancedTimer.Forms.Plugin.iOS.AdvancedTimerImplementation.Init();
```

You must do this AFTER you call Xamarin.Forms.Init();


#### API Usage

To gain access to the Timer class simply use the dependency service:

```
IAdvancedTimer timer = DependencyService.Get<IAdvancedTimer>();
```

You MUST call initTimer for timer initialization;

```
timer.initTimer(3000, timerElapsed, true);
```

                
                
#### Methods

```
timer.startTimer();
```
```
timer.stopTimer();
```
```
timer.getInterval()
```
```
timer.setInterval(5000);
```
```
timer.isTimerEnabled();
```

#### Contributors
* [ufuf](https://github.com/ufuf)

Thanks!

#### License
MIT License
