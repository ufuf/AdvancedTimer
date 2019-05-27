AdvancedTimer
=============

AdvancedTimer implementation for Xamarin.Forms

Timer object and its methods are implemented for extended support for timers.
You can start, stop, change interval of a timer.
For Xamarin.Forms projects
Can be used with Dependency service.

# THIS PROJECT IS DEPRECATED
This repo is not maintained anymore. See here [#20](https://github.com/ufuf/AdvancedTimer/issues/20) for more information.

## What now?
## Consider to use [d-m-wilson](https://github.com/d-m-wilson/AdvancedTimer)'s update, which rely on .Net Standart.


### Setup
* Available on NuGet: https://www.nuget.org/packages/Mobilist.AdvancedTimer.Forms.Plugin/
* Install into your PCL project and Client projects.

In your iOS, Android, and Windows Phone projects please call:

iOS
```
AdvancedTimer.Forms.Plugin.iOS.AdvancedTimerImplementation.Init();
```

Android
```
AdvancedTimer.Forms.Plugin.Droid.AdvancedTimerImplementation.Init();
```

You must do this AFTER you call Xamarin.Forms.Init();


### API Usage

To gain access to the Timer class simply use the dependency service:

```
IAdvancedTimer timer = DependencyService.Get<IAdvancedTimer>();
```

You MUST call initTimer for timer initialization;

```
timer.initTimer(3000, timerElapsed, true);
```
initTimer(interval, Eventhandler function, AutoReset);
                
                
### Methods

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

### Contributors
* [ufuf](https://github.com/ufuf)
* [d-m-wilson](https://github.com/d-m-wilson)


Thanks!

#### License
MIT License
