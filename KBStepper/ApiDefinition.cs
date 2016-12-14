using System;
using Foundation;
using UIKit;

namespace KBCustomStepper
{
	// @interface StepperView : UIView
	[BaseType(typeof(UIView))]
	interface StepperView
	{
		// @property (nonatomic) NSInteger numberTotalStep;
		[Export("numberTotalStep")]
		nint NumberTotalStep { get; set; }

		// @property (nonatomic) NSInteger numberCompleted;
		[Export("numberCompleted")]
		nint NumberCompleted { get; set; }

		// @property (nonatomic) NSInteger numberCurrent;
		[Export("numberCurrent")]
		nint NumberCurrent { get; set; }

		// @property (nonatomic) CGFloat startX;
		[Export("startX")]
		nfloat StartX { get; set; }

		// @property (nonatomic) CGFloat startY;
		[Export("startY")]
		nfloat StartY { get; set; }

		// -(void)drawStepperInView:(UIView *)containerView;
		[Export("drawStepperInView:")]
		void DrawStepperInView(UIView containerView);

		// -(void)drawStepperMarkInView:(UIView *)containerView withNumber:(NSInteger)markDigit withStatus:(NSInteger)markStatus;
		[Export("drawStepperMarkInView:withNumber:withStatus:")]
		void DrawStepperMarkInView(UIView containerView, nint markDigit, nint markStatus);

		// -(void)setStepWithNumber:(int)step;
		[Export("setStepWithNumber:")]
		void SetStepWithNumber(int step);
	}
}
