
using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Com.Reactlibrary.RNLaunchImage
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNLaunchImageModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNLaunchImageModule"/>.
        /// </summary>
        internal RNLaunchImageModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNLaunchImage";
            }
        }
    }
}
