
import { NativeModules } from 'react-native';

const { RNLaunchImage } = NativeModules;

export const hide = RNLaunchImage ? RNLaunchImage.hide : function(){};
