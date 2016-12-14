using System;
using KBCustomStepper;
using CoreGraphics;
using Foundation;
using UIKit;

namespace Sample
{
	public partial class ViewController : UIViewController
	{
		private int _currentStep;
		private int _totalStep;
		private StepperView stepper;

		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

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
	}
}
