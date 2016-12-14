# KBStepper

KB Custom Stepper

###Usage

```
private int _currentStep;
private int _totalStep;
private StepperView stepper;

public override void ViewDidLoad()
{
	base.ViewDidLoad();

	_currentStep = 2;
	_totalStep = 4;

	stepper = new StepperView();
	stepper.NumberTotalStep = _totalStep;
	stepper.NumberCurrent = _currentStep;

	stepper.DrawStepperInView(this.View);

	BtnNext.TouchUpInside += (sender, e) => {
		++_currentStep;
		if (_currentStep > _totalStep) {
			_currentStep = _totalStep + 1;
		}
		stepper.SetStepWithNumber(_currentStep);
	};

	BtnPrevious.TouchUpInside += (sender, e) => {
		--_currentStep;
		if (_currentStep <= 0) {
			_currentStep = 1;
		}
		stepper.SetStepWithNumber(_currentStep);
	};
}
```

###Output 

![](https://github.com/guntidheerajkumar/KBStepper/blob/master/Output.gif)
