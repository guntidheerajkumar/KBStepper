
#import <UIKit/UIKit.h>
#import "StepperConstants.h"

@interface StepperView : UIView

@property (nonatomic) NSInteger numberTotalStep;
@property (nonatomic) NSInteger numberCompleted;
@property (nonatomic) NSInteger numberCurrent;
@property (nonatomic) CGFloat startX;
@property (nonatomic) CGFloat startY;

- (void)drawStepperInView:(UIView *)containerView;
- (void)drawStepperMarkInView:(UIView *)containerView withNumber:(NSInteger)markDigit withStatus:(NSInteger)markStatus;
- (void)setStepWithNumber:(int)step;

@end
