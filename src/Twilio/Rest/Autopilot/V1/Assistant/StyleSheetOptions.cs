/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Autopilot.V1.Assistant 
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Returns Style sheet JSON object for the Assistant
    /// </summary>
    public class FetchStyleSheetOptions : IOptions<StyleSheetResource> 
    {
        /// <summary>
        /// The SID of the Assistant with the StyleSheet resource to fetch
        /// </summary>
        public string PathAssistantSid { get; }

        /// <summary>
        /// Construct a new FetchStyleSheetOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The SID of the Assistant with the StyleSheet resource to fetch </param>
        public FetchStyleSheetOptions(string pathAssistantSid)
        {
            PathAssistantSid = pathAssistantSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// Updates the style sheet for an Assistant identified by `assistant_sid`.
    /// </summary>
    public class UpdateStyleSheetOptions : IOptions<StyleSheetResource> 
    {
        /// <summary>
        /// The SID of the Assistant with the StyleSheet resource to update
        /// </summary>
        public string PathAssistantSid { get; }
        /// <summary>
        /// The JSON string that describes the style sheet object
        /// </summary>
        public object StyleSheet { get; set; }

        /// <summary>
        /// Construct a new UpdateStyleSheetOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The SID of the Assistant with the StyleSheet resource to update </param>
        public UpdateStyleSheetOptions(string pathAssistantSid)
        {
            PathAssistantSid = pathAssistantSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (StyleSheet != null)
            {
                p.Add(new KeyValuePair<string, string>("StyleSheet", Serializers.JsonObject(StyleSheet)));
            }

            return p;
        }
    }

}