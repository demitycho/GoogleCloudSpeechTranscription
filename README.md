
# react-native-google-cloud-speech-transcription

## Getting started

`$ npm install react-native-google-cloud-speech-transcription --save`

### Mostly automatic installation

`$ react-native link react-native-google-cloud-speech-transcription`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-google-cloud-speech-transcription` and add `RNGoogleCloudSpeechTranscription.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNGoogleCloudSpeechTranscription.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainActivity.java`
  - Add `import com.reactlibrary.RNGoogleCloudSpeechTranscriptionPackage;` to the imports at the top of the file
  - Add `new RNGoogleCloudSpeechTranscriptionPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-google-cloud-speech-transcription'
  	project(':react-native-google-cloud-speech-transcription').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-google-cloud-speech-transcription/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-google-cloud-speech-transcription')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNGoogleCloudSpeechTranscription.sln` in `node_modules/react-native-google-cloud-speech-transcription/windows/RNGoogleCloudSpeechTranscription.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Google.Cloud.Speech.Transcription.RNGoogleCloudSpeechTranscription;` to the usings at the top of the file
  - Add `new RNGoogleCloudSpeechTranscriptionPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNGoogleCloudSpeechTranscription from 'react-native-google-cloud-speech-transcription';

// TODO: What to do with the module?
RNGoogleCloudSpeechTranscription;
```
  