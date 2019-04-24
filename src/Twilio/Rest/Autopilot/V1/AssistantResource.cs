/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /
/// <summary>
/// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
/// currently do not have developer preview access, please contact help@twilio.com.
/// 
/// AssistantResource
/// </summary>

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Autopilot.V1 
{

    public class AssistantResource : Resource 
    {
        private static Request BuildFetchRequest(FetchAssistantOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Autopilot,
                "/v1/Assistants/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Assistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Assistant </returns> 
        public static AssistantResource Fetch(FetchAssistantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="options"> Fetch Assistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Assistant </returns> 
        public static async System.Threading.Tasks.Task<AssistantResource> FetchAsync(FetchAssistantOptions options, 
                                                                                      ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Assistant </returns> 
        public static AssistantResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchAssistantOptions(pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Assistant </returns> 
        public static async System.Threading.Tasks.Task<AssistantResource> FetchAsync(string pathSid, 
                                                                                      ITwilioRestClient client = null)
        {
            var options = new FetchAssistantOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadAssistantOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Autopilot,
                "/v1/Assistants",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Assistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Assistant </returns> 
        public static ResourceSet<AssistantResource> Read(ReadAssistantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<AssistantResource>.FromJson("assistants", response.Content);
            return new ResourceSet<AssistantResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="options"> Read Assistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Assistant </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<AssistantResource>> ReadAsync(ReadAssistantOptions options, 
                                                                                                  ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<AssistantResource>.FromJson("assistants", response.Content);
            return new ResourceSet<AssistantResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Assistant </returns> 
        public static ResourceSet<AssistantResource> Read(int? pageSize = null, 
                                                          long? limit = null, 
                                                          ITwilioRestClient client = null)
        {
            var options = new ReadAssistantOptions(){PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Assistant </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<AssistantResource>> ReadAsync(int? pageSize = null, 
                                                                                                  long? limit = null, 
                                                                                                  ITwilioRestClient client = null)
        {
            var options = new ReadAssistantOptions(){PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<AssistantResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<AssistantResource>.FromJson("assistants", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<AssistantResource> NextPage(Page<AssistantResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Autopilot,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<AssistantResource>.FromJson("assistants", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<AssistantResource> PreviousPage(Page<AssistantResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Autopilot,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<AssistantResource>.FromJson("assistants", response.Content);
        }

        private static Request BuildCreateRequest(CreateAssistantOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Autopilot,
                "/v1/Assistants",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Assistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Assistant </returns> 
        public static AssistantResource Create(CreateAssistantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="options"> Create Assistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Assistant </returns> 
        public static async System.Threading.Tasks.Task<AssistantResource> CreateAsync(CreateAssistantOptions options, 
                                                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        /// <param name="friendlyName"> A string to describe the new resource </param>
        /// <param name="logQueries"> Whether queries should be logged and kept after training </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the new resource </param>
        /// <param name="callbackUrl"> Reserved </param>
        /// <param name="callbackEvents"> Reserved </param>
        /// <param name="styleSheet"> A JSON string that defines the Assistant's style sheet </param>
        /// <param name="defaults"> A JSON object that defines the Assistant's default tasks for various scenarios </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Assistant </returns> 
        public static AssistantResource Create(string friendlyName = null, 
                                               bool? logQueries = null, 
                                               string uniqueName = null, 
                                               Uri callbackUrl = null, 
                                               string callbackEvents = null, 
                                               object styleSheet = null, 
                                               object defaults = null, 
                                               ITwilioRestClient client = null)
        {
            var options = new CreateAssistantOptions(){FriendlyName = friendlyName, LogQueries = logQueries, UniqueName = uniqueName, CallbackUrl = callbackUrl, CallbackEvents = callbackEvents, StyleSheet = styleSheet, Defaults = defaults};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        /// <param name="friendlyName"> A string to describe the new resource </param>
        /// <param name="logQueries"> Whether queries should be logged and kept after training </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the new resource </param>
        /// <param name="callbackUrl"> Reserved </param>
        /// <param name="callbackEvents"> Reserved </param>
        /// <param name="styleSheet"> A JSON string that defines the Assistant's style sheet </param>
        /// <param name="defaults"> A JSON object that defines the Assistant's default tasks for various scenarios </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Assistant </returns> 
        public static async System.Threading.Tasks.Task<AssistantResource> CreateAsync(string friendlyName = null, 
                                                                                       bool? logQueries = null, 
                                                                                       string uniqueName = null, 
                                                                                       Uri callbackUrl = null, 
                                                                                       string callbackEvents = null, 
                                                                                       object styleSheet = null, 
                                                                                       object defaults = null, 
                                                                                       ITwilioRestClient client = null)
        {
            var options = new CreateAssistantOptions(){FriendlyName = friendlyName, LogQueries = logQueries, UniqueName = uniqueName, CallbackUrl = callbackUrl, CallbackEvents = callbackEvents, StyleSheet = styleSheet, Defaults = defaults};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateAssistantOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Autopilot,
                "/v1/Assistants/" + options.PathSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update Assistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Assistant </returns> 
        public static AssistantResource Update(UpdateAssistantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="options"> Update Assistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Assistant </returns> 
        public static async System.Threading.Tasks.Task<AssistantResource> UpdateAsync(UpdateAssistantOptions options, 
                                                                                       ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="friendlyName"> A string to describe the resource </param>
        /// <param name="logQueries"> Whether queries should be logged and kept after training </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the resource </param>
        /// <param name="callbackUrl"> Reserved </param>
        /// <param name="callbackEvents"> Reserved </param>
        /// <param name="styleSheet"> A JSON string that defines the Assistant's style sheet </param>
        /// <param name="defaults"> A JSON object that defines the Assistant's [default
        ///                tasks](https://www.twilio.com/docs/autopilot/api/assistant/defaults) for various scenarios </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Assistant </returns> 
        public static AssistantResource Update(string pathSid, 
                                               string friendlyName = null, 
                                               bool? logQueries = null, 
                                               string uniqueName = null, 
                                               Uri callbackUrl = null, 
                                               string callbackEvents = null, 
                                               object styleSheet = null, 
                                               object defaults = null, 
                                               ITwilioRestClient client = null)
        {
            var options = new UpdateAssistantOptions(pathSid){FriendlyName = friendlyName, LogQueries = logQueries, UniqueName = uniqueName, CallbackUrl = callbackUrl, CallbackEvents = callbackEvents, StyleSheet = styleSheet, Defaults = defaults};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="friendlyName"> A string to describe the resource </param>
        /// <param name="logQueries"> Whether queries should be logged and kept after training </param>
        /// <param name="uniqueName"> An application-defined string that uniquely identifies the resource </param>
        /// <param name="callbackUrl"> Reserved </param>
        /// <param name="callbackEvents"> Reserved </param>
        /// <param name="styleSheet"> A JSON string that defines the Assistant's style sheet </param>
        /// <param name="defaults"> A JSON object that defines the Assistant's [default
        ///                tasks](https://www.twilio.com/docs/autopilot/api/assistant/defaults) for various scenarios </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Assistant </returns> 
        public static async System.Threading.Tasks.Task<AssistantResource> UpdateAsync(string pathSid, 
                                                                                       string friendlyName = null, 
                                                                                       bool? logQueries = null, 
                                                                                       string uniqueName = null, 
                                                                                       Uri callbackUrl = null, 
                                                                                       string callbackEvents = null, 
                                                                                       object styleSheet = null, 
                                                                                       object defaults = null, 
                                                                                       ITwilioRestClient client = null)
        {
            var options = new UpdateAssistantOptions(pathSid){FriendlyName = friendlyName, LogQueries = logQueries, UniqueName = uniqueName, CallbackUrl = callbackUrl, CallbackEvents = callbackEvents, StyleSheet = styleSheet, Defaults = defaults};
            return await UpdateAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteAssistantOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Autopilot,
                "/v1/Assistants/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete Assistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Assistant </returns> 
        public static bool Delete(DeleteAssistantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="options"> Delete Assistant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Assistant </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteAssistantOptions options, 
                                                                          ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Assistant </returns> 
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteAssistantOptions(pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        /// <param name="pathSid"> The unique string that identifies the resource </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Assistant </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteAssistantOptions(pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a AssistantResource object
        /// </summary>
        /// <param name="json"> Raw JSON string </param>
        /// <returns> AssistantResource object represented by the provided JSON </returns> 
        public static AssistantResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<AssistantResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The SID of the Account that created the resource
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The RFC 2822 date and time in GMT when the resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The RFC 2822 date and time in GMT when the resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The string that you assigned to describe the resource
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// Reserved
        /// </summary>
        [JsonProperty("latest_model_build_sid")]
        public string LatestModelBuildSid { get; private set; }
        /// <summary>
        /// A list of the URLs of the Assistant's related resources
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }
        /// <summary>
        /// Whether queries should be logged and kept after training
        /// </summary>
        [JsonProperty("log_queries")]
        public bool? LogQueries { get; private set; }
        /// <summary>
        /// The unique string that identifies the resource
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// An application-defined string that uniquely identifies the resource
        /// </summary>
        [JsonProperty("unique_name")]
        public string UniqueName { get; private set; }
        /// <summary>
        /// The absolute URL of the Assistant resource
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// Reserved
        /// </summary>
        [JsonProperty("callback_url")]
        public Uri CallbackUrl { get; private set; }
        /// <summary>
        /// Reserved
        /// </summary>
        [JsonProperty("callback_events")]
        public string CallbackEvents { get; private set; }

        private AssistantResource()
        {

        }
    }

}