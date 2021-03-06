/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Taskrouter.V1
{

    /// <summary>
    /// FetchWorkspaceOptions
    /// </summary>
    public class FetchWorkspaceOptions : IOptions<WorkspaceResource>
    {
        /// <summary>
        /// The SID of the resource to fetch
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchWorkspaceOptions
        /// </summary>
        /// <param name="pathSid"> The SID of the resource to fetch </param>
        public FetchWorkspaceOptions(string pathSid)
        {
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
    /// UpdateWorkspaceOptions
    /// </summary>
    public class UpdateWorkspaceOptions : IOptions<WorkspaceResource>
    {
        /// <summary>
        /// The SID of the resource to update
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The SID of the Activity that will be used when new Workers are created in the Workspace
        /// </summary>
        public string DefaultActivitySid { get; set; }
        /// <summary>
        /// The URL we should call when an event occurs
        /// </summary>
        public Uri EventCallbackUrl { get; set; }
        /// <summary>
        /// The list of Workspace events for which to call event_callback_url
        /// </summary>
        public string EventsFilter { get; set; }
        /// <summary>
        /// A string to describe the Workspace resource
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// Whether multi-tasking is enabled
        /// </summary>
        public bool? MultiTaskEnabled { get; set; }
        /// <summary>
        /// The SID of the Activity that will be assigned to a Worker when a Task reservation times out without a response
        /// </summary>
        public string TimeoutActivitySid { get; set; }
        /// <summary>
        /// The type of TaskQueue to prioritize when Workers are receiving Tasks from both types of TaskQueues
        /// </summary>
        public WorkspaceResource.QueueOrderEnum PrioritizeQueueOrder { get; set; }

        /// <summary>
        /// Construct a new UpdateWorkspaceOptions
        /// </summary>
        /// <param name="pathSid"> The SID of the resource to update </param>
        public UpdateWorkspaceOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (DefaultActivitySid != null)
            {
                p.Add(new KeyValuePair<string, string>("DefaultActivitySid", DefaultActivitySid.ToString()));
            }

            if (EventCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("EventCallbackUrl", Serializers.Url(EventCallbackUrl)));
            }

            if (EventsFilter != null)
            {
                p.Add(new KeyValuePair<string, string>("EventsFilter", EventsFilter));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (MultiTaskEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("MultiTaskEnabled", MultiTaskEnabled.Value.ToString().ToLower()));
            }

            if (TimeoutActivitySid != null)
            {
                p.Add(new KeyValuePair<string, string>("TimeoutActivitySid", TimeoutActivitySid.ToString()));
            }

            if (PrioritizeQueueOrder != null)
            {
                p.Add(new KeyValuePair<string, string>("PrioritizeQueueOrder", PrioritizeQueueOrder.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// ReadWorkspaceOptions
    /// </summary>
    public class ReadWorkspaceOptions : ReadOptions<WorkspaceResource>
    {
        /// <summary>
        /// The friendly_name of the Workspace resources to read
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// CreateWorkspaceOptions
    /// </summary>
    public class CreateWorkspaceOptions : IOptions<WorkspaceResource>
    {
        /// <summary>
        /// A string to describe the Workspace resource
        /// </summary>
        public string FriendlyName { get; }
        /// <summary>
        /// The URL we should call when an event occurs
        /// </summary>
        public Uri EventCallbackUrl { get; set; }
        /// <summary>
        /// The list of Workspace events for which to call event_callback_url
        /// </summary>
        public string EventsFilter { get; set; }
        /// <summary>
        /// Whether multi-tasking is enabled
        /// </summary>
        public bool? MultiTaskEnabled { get; set; }
        /// <summary>
        /// An available template name
        /// </summary>
        public string Template { get; set; }
        /// <summary>
        /// The type of TaskQueue to prioritize when Workers are receiving Tasks from both types of TaskQueues
        /// </summary>
        public WorkspaceResource.QueueOrderEnum PrioritizeQueueOrder { get; set; }

        /// <summary>
        /// Construct a new CreateWorkspaceOptions
        /// </summary>
        /// <param name="friendlyName"> A string to describe the Workspace resource </param>
        public CreateWorkspaceOptions(string friendlyName)
        {
            FriendlyName = friendlyName;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (EventCallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("EventCallbackUrl", Serializers.Url(EventCallbackUrl)));
            }

            if (EventsFilter != null)
            {
                p.Add(new KeyValuePair<string, string>("EventsFilter", EventsFilter));
            }

            if (MultiTaskEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("MultiTaskEnabled", MultiTaskEnabled.Value.ToString().ToLower()));
            }

            if (Template != null)
            {
                p.Add(new KeyValuePair<string, string>("Template", Template));
            }

            if (PrioritizeQueueOrder != null)
            {
                p.Add(new KeyValuePair<string, string>("PrioritizeQueueOrder", PrioritizeQueueOrder.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// DeleteWorkspaceOptions
    /// </summary>
    public class DeleteWorkspaceOptions : IOptions<WorkspaceResource>
    {
        /// <summary>
        /// The SID of the resource to delete
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteWorkspaceOptions
        /// </summary>
        /// <param name="pathSid"> The SID of the resource to delete </param>
        public DeleteWorkspaceOptions(string pathSid)
        {
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