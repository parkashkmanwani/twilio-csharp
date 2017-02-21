using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Api.V2010.Account 
{

    /// <summary>
    /// ShortCodeResource
    /// </summary>
    public class ShortCodeResource : Resource 
    {
        private static Request BuildFetchRequest(FetchShortCodeOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SMS/ShortCodes/" + options.PathSid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Fetch an instance of a short code
        /// </summary>
        ///
        /// <param name="options"> Fetch ShortCode parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ShortCode </returns> 
        public static ShortCodeResource Fetch(FetchShortCodeOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch an instance of a short code
        /// </summary>
        ///
        /// <param name="options"> Fetch ShortCode parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ShortCode </returns> 
        public static async System.Threading.Tasks.Task<ShortCodeResource> FetchAsync(FetchShortCodeOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Fetch an instance of a short code
        /// </summary>
        ///
        /// <param name="sid"> Fetch by unique short-code Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ShortCode </returns> 
        public static ShortCodeResource Fetch(string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchShortCodeOptions(sid){PathAccountSid = accountSid};
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch an instance of a short code
        /// </summary>
        ///
        /// <param name="sid"> Fetch by unique short-code Sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ShortCode </returns> 
        public static async System.Threading.Tasks.Task<ShortCodeResource> FetchAsync(string sid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchShortCodeOptions(sid){PathAccountSid = accountSid};
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildUpdateRequest(UpdateShortCodeOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SMS/ShortCodes/" + options.PathSid + ".json",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Update a short code with the following parameters
        /// </summary>
        ///
        /// <param name="options"> Update ShortCode parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ShortCode </returns> 
        public static ShortCodeResource Update(UpdateShortCodeOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// Update a short code with the following parameters
        /// </summary>
        ///
        /// <param name="options"> Update ShortCode parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ShortCode </returns> 
        public static async System.Threading.Tasks.Task<ShortCodeResource> UpdateAsync(UpdateShortCodeOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Update a short code with the following parameters
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="friendlyName"> A human readable description of this resource </param>
        /// <param name="apiVersion"> The API version to use </param>
        /// <param name="smsUrl"> URL Twilio will request when receiving an SMS </param>
        /// <param name="smsMethod"> HTTP method to use when requesting the sms url </param>
        /// <param name="smsFallbackUrl"> URL Twilio will request if an error occurs in executing TwiML </param>
        /// <param name="smsFallbackMethod"> HTTP method Twilio will use with sms fallback url </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ShortCode </returns> 
        public static ShortCodeResource Update(string sid, string accountSid = null, string friendlyName = null, string apiVersion = null, Uri smsUrl = null, Twilio.Http.HttpMethod smsMethod = null, Uri smsFallbackUrl = null, Twilio.Http.HttpMethod smsFallbackMethod = null, ITwilioRestClient client = null)
        {
            var options = new UpdateShortCodeOptions(sid){PathAccountSid = accountSid, FriendlyName = friendlyName, ApiVersion = apiVersion, SmsUrl = smsUrl, SmsMethod = smsMethod, SmsFallbackUrl = smsFallbackUrl, SmsFallbackMethod = smsFallbackMethod};
            return Update(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Update a short code with the following parameters
        /// </summary>
        ///
        /// <param name="sid"> The sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="friendlyName"> A human readable description of this resource </param>
        /// <param name="apiVersion"> The API version to use </param>
        /// <param name="smsUrl"> URL Twilio will request when receiving an SMS </param>
        /// <param name="smsMethod"> HTTP method to use when requesting the sms url </param>
        /// <param name="smsFallbackUrl"> URL Twilio will request if an error occurs in executing TwiML </param>
        /// <param name="smsFallbackMethod"> HTTP method Twilio will use with sms fallback url </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ShortCode </returns> 
        public static async System.Threading.Tasks.Task<ShortCodeResource> UpdateAsync(string sid, string accountSid = null, string friendlyName = null, string apiVersion = null, Uri smsUrl = null, Twilio.Http.HttpMethod smsMethod = null, Uri smsFallbackUrl = null, Twilio.Http.HttpMethod smsFallbackMethod = null, ITwilioRestClient client = null)
        {
            var options = new UpdateShortCodeOptions(sid){PathAccountSid = accountSid, FriendlyName = friendlyName, ApiVersion = apiVersion, SmsUrl = smsUrl, SmsMethod = smsMethod, SmsFallbackUrl = smsFallbackUrl, SmsFallbackMethod = smsFallbackMethod};
            return await UpdateAsync(options, client);
        }
        #endif
    
        private static Request BuildReadRequest(ReadShortCodeOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/SMS/ShortCodes.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Retrieve a list of short-codes belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="options"> Read ShortCode parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ShortCode </returns> 
        public static ResourceSet<ShortCodeResource> Read(ReadShortCodeOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<ShortCodeResource>.FromJson("short_codes", response.Content);
            return new ResourceSet<ShortCodeResource>(page, options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Retrieve a list of short-codes belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="options"> Read ShortCode parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ShortCode </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<ShortCodeResource>> ReadAsync(ReadShortCodeOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<ShortCodeResource>.FromJson("short_codes", response.Content);
            return new ResourceSet<ShortCodeResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// Retrieve a list of short-codes belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="friendlyName"> Filter by friendly name </param>
        /// <param name="shortCode"> Filter by ShortCode </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of ShortCode </returns> 
        public static ResourceSet<ShortCodeResource> Read(string accountSid = null, string friendlyName = null, string shortCode = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadShortCodeOptions{PathAccountSid = accountSid, FriendlyName = friendlyName, ShortCode = shortCode, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Retrieve a list of short-codes belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="friendlyName"> Filter by friendly name </param>
        /// <param name="shortCode"> Filter by ShortCode </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of ShortCode </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<ShortCodeResource>> ReadAsync(string accountSid = null, string friendlyName = null, string shortCode = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadShortCodeOptions{PathAccountSid = accountSid, FriendlyName = friendlyName, ShortCode = shortCode, PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<ShortCodeResource> NextPage(Page<ShortCodeResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<ShortCodeResource>.FromJson("short_codes", response.Content);
        }
    
        /// <summary>
        /// Converts a JSON string into a ShortCodeResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ShortCodeResource object represented by the provided JSON </returns> 
        public static ShortCodeResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<ShortCodeResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        /// <summary>
        /// The unique sid that identifies this account
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The API version to use
        /// </summary>
        [JsonProperty("api_version")]
        public string ApiVersion { get; private set; }
        /// <summary>
        /// The date this resource was created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date this resource was last updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// A human readable description of this resource
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The short code. e.g., 894546.
        /// </summary>
        [JsonProperty("short_code")]
        public string ShortCode { get; private set; }
        /// <summary>
        /// A string that uniquely identifies this short-codes
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// HTTP method Twilio will use with sms fallback url
        /// </summary>
        [JsonProperty("sms_fallback_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod SmsFallbackMethod { get; private set; }
        /// <summary>
        /// URL Twilio will request if an error occurs in executing TwiML
        /// </summary>
        [JsonProperty("sms_fallback_url")]
        public Uri SmsFallbackUrl { get; private set; }
        /// <summary>
        /// HTTP method to use when requesting the sms url
        /// </summary>
        [JsonProperty("sms_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod SmsMethod { get; private set; }
        /// <summary>
        /// URL Twilio will request when receiving an SMS
        /// </summary>
        [JsonProperty("sms_url")]
        public Uri SmsUrl { get; private set; }
        /// <summary>
        /// The URI for this resource
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }
    
        private ShortCodeResource()
        {
        
        }
    }

}