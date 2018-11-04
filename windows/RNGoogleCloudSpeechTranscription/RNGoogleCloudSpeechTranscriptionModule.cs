using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Google.Cloud.Speech.Transcription.RNGoogleCloudSpeechTranscription
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNGoogleCloudSpeechTranscriptionModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNGoogleCloudSpeechTranscriptionModule"/>.
        /// </summary>
        internal RNGoogleCloudSpeechTranscriptionModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNGoogleCloudSpeechTranscription";
            }
        }
    }
}
