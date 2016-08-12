
#import "RNLaunchImage.h"

static bool waiting = true;

@implementation RNLaunchImage

- (dispatch_queue_t)methodQueue
{
    return dispatch_get_main_queue();
}
RCT_EXPORT_MODULE()

+ (void)wait {
  while (waiting) {
    NSDate* later = [NSDate dateWithTimeIntervalSinceNow:0.1];
    [[NSRunLoop mainRunLoop] runUntilDate:later];
  }
}

RCT_EXPORT_METHOD(hide) {
    dispatch_async(dispatch_get_main_queue(),
                   ^{
                     waiting = false;
                   });
}


@end
  