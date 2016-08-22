
# react-native-launch-image

Only iOS was supported. (for native iOS launch image)

For both iOS&Android support, maybe you can use [rn-splash-screen](https://github.com/mehcode/rn-splash-screen/blob/master/docs/ios.md), 
which provides a extra view to contain launch image.

> *Notice:* You should not keep launch image more than 5 seconds, which 
may cause your app got killed by iOS. To do long-time work(like http 
request, which may fail or tooks long), you should first render a react 
native page, then hide launch image before work, or set a timeout, hide 
launch image even if request is still waiting.

## Getting started

`$ npm install react-native-launch-image --save`

### Mostly automatic installation

`$ react-native link react-native-launch-image`

### Manual installation

#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-launch-image` and add `RNLaunchImage.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNLaunchImage.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

## Usage

#### iOS

You should add following code to `AppDelegate.m` for keeping launch image:
 
```obj-c

#import "AppDelegate.h"

#import "RCTRootView.h"
#import "RNLaunchImage.h"  // <-- Add this line.

@implementation AppDelegate

- (BOOL)application:(UIApplication *)application didFinishLaunchingWithOptions:(NSDictionary *)launchOptions
{
    // ...other code
    
    [RNLaunchImage wait];   // <-- Add this line. This line MUST be the last line of this method.
    return YES;
}

@end

```


#### Javascript
 
Use RNLaunchImage.hide() to hide launch image manually. 

```javascript
import * as launchImage from 'react-native-launch-image';

class App extends React.Component {
    async componentDidMount(){
        // do anything while launch image keeps, use await to wait for an async task.
        launchImage.hide();
    }
}
```
