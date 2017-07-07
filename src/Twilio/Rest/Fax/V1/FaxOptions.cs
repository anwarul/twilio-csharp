using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Fax.V1 
{

    /// <summary>
    /// Fetch a specific fax.
    /// </summary>
    public class FetchFaxOptions : IOptions<FaxResource> 
    {
        /// <summary>
        /// A string that uniquely identifies this fax.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchFaxOptions
        /// </summary>
        ///
        /// <param name="pathSid"> A string that uniquely identifies this fax. </param>
        public FetchFaxOptions(string pathSid)
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
    /// Retrieve a list of all faxes.
    /// </summary>
    public class ReadFaxOptions : ReadOptions<FaxResource> 
    {
        /// <summary>
        /// Include only faxes sent from
        /// </summary>
        public string From { get; set; }
        /// <summary>
        /// Include only faxes sent to
        /// </summary>
        public string To { get; set; }
        /// <summary>
        /// Include only faxes created on or before
        /// </summary>
        public DateTime? DateCreatedOnOrBefore { get; set; }
        /// <summary>
        /// Include only faxes created after
        /// </summary>
        public DateTime? DateCreatedAfter { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (From != null)
            {
                p.Add(new KeyValuePair<string, string>("From", From));
            }

            if (To != null)
            {
                p.Add(new KeyValuePair<string, string>("To", To));
            }

            if (DateCreatedOnOrBefore != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreatedOnOrBefore", Serializers.DateTimeIso8601(DateCreatedOnOrBefore)));
            }

            if (DateCreatedAfter != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreatedAfter", Serializers.DateTimeIso8601(DateCreatedAfter)));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// Create a new fax to send to a phone number or SIP endpoint
    /// </summary>
    public class CreateFaxOptions : IOptions<FaxResource> 
    {
        /// <summary>
        /// The phone number or SIP address to send the fax to
        /// </summary>
        public string To { get; }
        /// <summary>
        /// URL that points to the fax media
        /// </summary>
        public Uri MediaUrl { get; }
        /// <summary>
        /// The quality of this fax
        /// </summary>
        public FaxResource.QualityEnum Quality { get; set; }
        /// <summary>
        /// URL for fax status callbacks
        /// </summary>
        public Uri StatusCallback { get; set; }
        /// <summary>
        /// Twilio number from which to originate the fax
        /// </summary>
        public string From { get; set; }
        /// <summary>
        /// Username for SIP authentication
        /// </summary>
        public string SipAuthUsername { get; set; }
        /// <summary>
        /// Password for SIP authentication
        /// </summary>
        public string SipAuthPassword { get; set; }
        /// <summary>
        /// Whether or not to store media
        /// </summary>
        public bool? StoreMedia { get; set; }

        /// <summary>
        /// Construct a new CreateFaxOptions
        /// </summary>
        ///
        /// <param name="to"> The phone number or SIP address to send the fax to </param>
        /// <param name="mediaUrl"> URL that points to the fax media </param>
        public CreateFaxOptions(string to, Uri mediaUrl)
        {
            To = to;
            MediaUrl = mediaUrl;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (To != null)
            {
                p.Add(new KeyValuePair<string, string>("To", To));
            }

            if (MediaUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("MediaUrl", MediaUrl.AbsoluteUri));
            }

            if (Quality != null)
            {
                p.Add(new KeyValuePair<string, string>("Quality", Quality.ToString()));
            }

            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", StatusCallback.AbsoluteUri));
            }

            if (From != null)
            {
                p.Add(new KeyValuePair<string, string>("From", From));
            }

            if (SipAuthUsername != null)
            {
                p.Add(new KeyValuePair<string, string>("SipAuthUsername", SipAuthUsername));
            }

            if (SipAuthPassword != null)
            {
                p.Add(new KeyValuePair<string, string>("SipAuthPassword", SipAuthPassword));
            }

            if (StoreMedia != null)
            {
                p.Add(new KeyValuePair<string, string>("StoreMedia", StoreMedia.Value.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// Update a specific fax.
    /// </summary>
    public class UpdateFaxOptions : IOptions<FaxResource> 
    {
        /// <summary>
        /// A string that uniquely identifies this fax.
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The updated status of this fax
        /// </summary>
        public FaxResource.UpdateStatusEnum Status { get; set; }

        /// <summary>
        /// Construct a new UpdateFaxOptions
        /// </summary>
        ///
        /// <param name="pathSid"> A string that uniquely identifies this fax. </param>
        public UpdateFaxOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// Delete a specific fax and its associated media.
    /// </summary>
    public class DeleteFaxOptions : IOptions<FaxResource> 
    {
        /// <summary>
        /// A string that uniquely identifies this fax.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteFaxOptions
        /// </summary>
        ///
        /// <param name="pathSid"> A string that uniquely identifies this fax. </param>
        public DeleteFaxOptions(string pathSid)
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