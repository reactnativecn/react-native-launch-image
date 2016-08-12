
# react-native-launch-image

Currently 

## Getting started

`$ npm install react-native-launch-image --save`

### Mostly automatic installation

`$ react-native link react-native-launch-image`

#### iOS


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
```javascript
import RNLaunchImage from 'react-native-launch-image';

class App extends React.Component {
    async componentDidMount(){
        // do anything while launch image keeps, use await to wait for an async task.
        RNLaunchImage.hide();
    }
}
```
