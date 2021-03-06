/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Messaging.V1.Session
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// ReadWebhookOptions
    /// </summary>
    public class ReadWebhookOptions : ReadOptions<WebhookResource>
    {
        /// <summary>
        /// The SID of the Session with the Webhook resources to read
        /// </summary>
        public string PathSessionSid { get; }

        /// <summary>
        /// Construct a new ReadWebhookOptions
        /// </summary>
        /// <param name="pathSessionSid"> The SID of the Session with the Webhook resources to read </param>
        public ReadWebhookOptions(string pathSessionSid)
        {
            PathSessionSid = pathSessionSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// FetchWebhookOptions
    /// </summary>
    public class FetchWebhookOptions : IOptions<WebhookResource>
    {
        /// <summary>
        /// The SID of the Session with the Webhook resource to fetch
        /// </summary>
        public string PathSessionSid { get; }
        /// <summary>
        /// The SID of the resource to fetch
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchWebhookOptions
        /// </summary>
        /// <param name="pathSessionSid"> The SID of the Session with the Webhook resource to fetch </param>
        /// <param name="pathSid"> The SID of the resource to fetch </param>
        public FetchWebhookOptions(string pathSessionSid, string pathSid)
        {
            PathSessionSid = pathSessionSid;
            PathSid = pathSid;
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
    /// CreateWebhookOptions
    /// </summary>
    public class CreateWebhookOptions : IOptions<WebhookResource>
    {
        /// <summary>
        /// The SID of the Session for the webhook
        /// </summary>
        public string PathSessionSid { get; }
        /// <summary>
        /// The target of the webhook
        /// </summary>
        public WebhookResource.TargetEnum Target { get; }
        /// <summary>
        /// The absolute URL the webhook request should be sent to
        /// </summary>
        public string ConfigurationUrl { get; set; }
        /// <summary>
        /// The HTTP method we should use when sending a webhook request to url
        /// </summary>
        public WebhookResource.MethodEnum ConfigurationMethod { get; set; }
        /// <summary>
        /// The list of events that trigger a webhook event for the Session
        /// </summary>
        public List<string> ConfigurationFilters { get; set; }
        /// <summary>
        /// The list of keywords, firing webhook event for the Session
        /// </summary>
        public List<string> ConfigurationTriggers { get; set; }
        /// <summary>
        /// The SID of the studio flow where the webhook should be sent to
        /// </summary>
        public string ConfigurationFlowSid { get; set; }
        /// <summary>
        /// The number of times to call the webhook request if the first attempt fails
        /// </summary>
        public int? ConfigurationRetryCount { get; set; }
        /// <summary>
        /// The message index for which and its successors the webhook will be replayed
        /// </summary>
        public int? ConfigurationReplayAfter { get; set; }
        /// <summary>
        /// Whether buffering should be applied to messages
        /// </summary>
        public bool? ConfigurationBufferMessages { get; set; }
        /// <summary>
        /// The period to buffer messages
        /// </summary>
        public int? ConfigurationBufferWindow { get; set; }

        /// <summary>
        /// Construct a new CreateWebhookOptions
        /// </summary>
        /// <param name="pathSessionSid"> The SID of the Session for the webhook </param>
        /// <param name="target"> The target of the webhook </param>
        public CreateWebhookOptions(string pathSessionSid, WebhookResource.TargetEnum target)
        {
            PathSessionSid = pathSessionSid;
            Target = target;
            ConfigurationFilters = new List<string>();
            ConfigurationTriggers = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Target != null)
            {
                p.Add(new KeyValuePair<string, string>("Target", Target.ToString()));
            }

            if (ConfigurationUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("Configuration.Url", ConfigurationUrl));
            }

            if (ConfigurationMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("Configuration.Method", ConfigurationMethod.ToString()));
            }

            if (ConfigurationFilters != null)
            {
                p.AddRange(ConfigurationFilters.Select(prop => new KeyValuePair<string, string>("Configuration.Filters", prop)));
            }

            if (ConfigurationTriggers != null)
            {
                p.AddRange(ConfigurationTriggers.Select(prop => new KeyValuePair<string, string>("Configuration.Triggers", prop)));
            }

            if (ConfigurationFlowSid != null)
            {
                p.Add(new KeyValuePair<string, string>("Configuration.FlowSid", ConfigurationFlowSid.ToString()));
            }

            if (ConfigurationRetryCount != null)
            {
                p.Add(new KeyValuePair<string, string>("Configuration.RetryCount", ConfigurationRetryCount.ToString()));
            }

            if (ConfigurationReplayAfter != null)
            {
                p.Add(new KeyValuePair<string, string>("Configuration.ReplayAfter", ConfigurationReplayAfter.ToString()));
            }

            if (ConfigurationBufferMessages != null)
            {
                p.Add(new KeyValuePair<string, string>("Configuration.BufferMessages", ConfigurationBufferMessages.Value.ToString().ToLower()));
            }

            if (ConfigurationBufferWindow != null)
            {
                p.Add(new KeyValuePair<string, string>("Configuration.BufferWindow", ConfigurationBufferWindow.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// UpdateWebhookOptions
    /// </summary>
    public class UpdateWebhookOptions : IOptions<WebhookResource>
    {
        /// <summary>
        /// The SID of the Session for the webhook
        /// </summary>
        public string PathSessionSid { get; }
        /// <summary>
        /// The SID that identifies the resource to update
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The absolute URL the webhook request should be sent to
        /// </summary>
        public string ConfigurationUrl { get; set; }
        /// <summary>
        /// The HTTP method we should use when sending a webhook request to url
        /// </summary>
        public WebhookResource.MethodEnum ConfigurationMethod { get; set; }
        /// <summary>
        /// The list of events that trigger a  webhook event for the Session
        /// </summary>
        public List<string> ConfigurationFilters { get; set; }
        /// <summary>
        /// The list of keywords, that trigger a webhook event for the Session
        /// </summary>
        public List<string> ConfigurationTriggers { get; set; }
        /// <summary>
        /// The SID of the studio flow where the webhook should be sent to
        /// </summary>
        public string ConfigurationFlowSid { get; set; }
        /// <summary>
        /// The number of times to try the webhook request if the first attempt fails
        /// </summary>
        public int? ConfigurationRetryCount { get; set; }
        /// <summary>
        /// Whether buffering should be applied to messages
        /// </summary>
        public bool? ConfigurationBufferMessages { get; set; }
        /// <summary>
        /// The period to buffer messages
        /// </summary>
        public int? ConfigurationBufferWindow { get; set; }

        /// <summary>
        /// Construct a new UpdateWebhookOptions
        /// </summary>
        /// <param name="pathSessionSid"> The SID of the Session for the webhook </param>
        /// <param name="pathSid"> The SID that identifies the resource to update </param>
        public UpdateWebhookOptions(string pathSessionSid, string pathSid)
        {
            PathSessionSid = pathSessionSid;
            PathSid = pathSid;
            ConfigurationFilters = new List<string>();
            ConfigurationTriggers = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (ConfigurationUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("Configuration.Url", ConfigurationUrl));
            }

            if (ConfigurationMethod != null)
            {
                p.Add(new KeyValuePair<string, string>("Configuration.Method", ConfigurationMethod.ToString()));
            }

            if (ConfigurationFilters != null)
            {
                p.AddRange(ConfigurationFilters.Select(prop => new KeyValuePair<string, string>("Configuration.Filters", prop)));
            }

            if (ConfigurationTriggers != null)
            {
                p.AddRange(ConfigurationTriggers.Select(prop => new KeyValuePair<string, string>("Configuration.Triggers", prop)));
            }

            if (ConfigurationFlowSid != null)
            {
                p.Add(new KeyValuePair<string, string>("Configuration.FlowSid", ConfigurationFlowSid.ToString()));
            }

            if (ConfigurationRetryCount != null)
            {
                p.Add(new KeyValuePair<string, string>("Configuration.RetryCount", ConfigurationRetryCount.ToString()));
            }

            if (ConfigurationBufferMessages != null)
            {
                p.Add(new KeyValuePair<string, string>("Configuration.BufferMessages", ConfigurationBufferMessages.Value.ToString().ToLower()));
            }

            if (ConfigurationBufferWindow != null)
            {
                p.Add(new KeyValuePair<string, string>("Configuration.BufferWindow", ConfigurationBufferWindow.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// DeleteWebhookOptions
    /// </summary>
    public class DeleteWebhookOptions : IOptions<WebhookResource>
    {
        /// <summary>
        /// The SID of the Session with the Webhook resource to delete
        /// </summary>
        public string PathSessionSid { get; }
        /// <summary>
        /// The SID that identifies the resource to delete
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteWebhookOptions
        /// </summary>
        /// <param name="pathSessionSid"> The SID of the Session with the Webhook resource to delete </param>
        /// <param name="pathSid"> The SID that identifies the resource to delete </param>
        public DeleteWebhookOptions(string pathSessionSid, string pathSid)
        {
            PathSessionSid = pathSessionSid;
            PathSid = pathSid;
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