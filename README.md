
# react-native-launch-image

Currently only iOS was supported. (for native iOS launch image)
 
On android launch image should be implemented as a activity, this is under development. 

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

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNLaunchImagePackage;` to the imports at the top of the file
  - Add `new RNLaunchImagePackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-launch-image'
  	project(':react-native-launch-image').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-launch-image/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-launch-image')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNLaunchImage.sln` in `node_modules/react-native-launch-image/windows/RNLaunchImage.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Cl.Json.RNLaunchImage;` to the usings at the top of the file
  - Add `new RNLaunchImagePackage()` to the `List<IReactPackage>` returned by the `Packages` method
      

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
