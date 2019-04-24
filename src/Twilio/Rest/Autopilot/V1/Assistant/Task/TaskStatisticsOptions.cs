/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Autopilot.V1.Assistant.Task 
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// FetchTaskStatisticsOptions
    /// </summary>
    public class FetchTaskStatisticsOptions : IOptions<TaskStatisticsResource> 
    {
        /// <summary>
        /// The SID of the Assistant that is the parent of the resource to fetch
        /// </summary>
        public string PathAssistantSid { get; }
        /// <summary>
        /// The SID of the Task that is associated with the resource to fetch
        /// </summary>
        public string PathTaskSid { get; }

        /// <summary>
        /// Construct a new FetchTaskStatisticsOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The SID of the Assistant that is the parent of the resource to fetch </param>
        /// <param name="pathTaskSid"> The SID of the Task that is associated with the resource to fetch </param>
        public FetchTaskStatisticsOptions(string pathAssistantSid, string pathTaskSid)
        {
            PathAssistantSid = pathAssistantSid;
            PathTaskSid = pathTaskSid;
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

}