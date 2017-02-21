using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Api.V2010.Account.Conference 
{

    /// <summary>
    /// ParticipantResource
    /// </summary>
    public class ParticipantResource : Resource 
    {
        public sealed class StatusEnum : StringEnum 
        {
            private StatusEnum(string value) : base(value) {}
            public StatusEnum() {}
        
            public static readonly StatusEnum Queued = new StatusEnum("queued");
            public static readonly StatusEnum Connecting = new StatusEnum("connecting");
            public static readonly StatusEnum Ringing = new StatusEnum("ringing");
            public static readonly StatusEnum Connected = new StatusEnum("connected");
            public static readonly StatusEnum Complete = new StatusEnum("complete");
            public static readonly StatusEnum Failed = new StatusEnum("failed");
        }
    
        public sealed class BeepEnum : StringEnum 
        {
            private BeepEnum(string value) : base(value) {}
            public BeepEnum() {}
        
            public static readonly BeepEnum True = new BeepEnum("true");
            public static readonly BeepEnum False = new BeepEnum("false");
            public static readonly BeepEnum Onenter = new BeepEnum("onEnter");
            public static readonly BeepEnum Onexit = new BeepEnum("onExit");
        }
    
        public sealed class ConferenceRecordEnum : StringEnum 
        {
            private ConferenceRecordEnum(string value) : base(value) {}
            public ConferenceRecordEnum() {}
        
            public static readonly ConferenceRecordEnum DoNotRecord = new ConferenceRecordEnum("do-not-record");
            public static readonly ConferenceRecordEnum RecordFromStart = new ConferenceRecordEnum("record-from-start");
        }
    
        private static Request BuildFetchRequest(FetchParticipantOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Conferences/" + options.PathConferenceSid + "/Participants/" + options.PathCallSid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Fetch an instance of a participant
        /// </summary>
        ///
        /// <param name="options"> Fetch Participant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Participant </returns> 
        public static ParticipantResource Fetch(FetchParticipantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch an instance of a participant
        /// </summary>
        ///
        /// <param name="options"> Fetch Participant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Participant </returns> 
        public static async System.Threading.Tasks.Task<ParticipantResource> FetchAsync(FetchParticipantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Fetch an instance of a participant
        /// </summary>
        ///
        /// <param name="conferenceSid"> The string that uniquely identifies this conference </param>
        /// <param name="callSid"> The call_sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Participant </returns> 
        public static ParticipantResource Fetch(string conferenceSid, string callSid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchParticipantOptions(conferenceSid, callSid){PathAccountSid = accountSid};
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Fetch an instance of a participant
        /// </summary>
        ///
        /// <param name="conferenceSid"> The string that uniquely identifies this conference </param>
        /// <param name="callSid"> The call_sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Participant </returns> 
        public static async System.Threading.Tasks.Task<ParticipantResource> FetchAsync(string conferenceSid, string callSid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new FetchParticipantOptions(conferenceSid, callSid){PathAccountSid = accountSid};
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildUpdateRequest(UpdateParticipantOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Conferences/" + options.PathConferenceSid + "/Participants/" + options.PathCallSid + ".json",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Update the properties of this participant
        /// </summary>
        ///
        /// <param name="options"> Update Participant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Participant </returns> 
        public static ParticipantResource Update(UpdateParticipantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// Update the properties of this participant
        /// </summary>
        ///
        /// <param name="options"> Update Participant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Participant </returns> 
        public static async System.Threading.Tasks.Task<ParticipantResource> UpdateAsync(UpdateParticipantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// Update the properties of this participant
        /// </summary>
        ///
        /// <param name="conferenceSid"> The string that uniquely identifies this conference </param>
        /// <param name="callSid"> The call_sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="muted"> Indicates if the participant should be muted </param>
        /// <param name="hold"> The hold </param>
        /// <param name="holdUrl"> The hold_url </param>
        /// <param name="holdMethod"> The hold_method </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Participant </returns> 
        public static ParticipantResource Update(string conferenceSid, string callSid, string accountSid = null, bool? muted = null, bool? hold = null, Uri holdUrl = null, Twilio.Http.HttpMethod holdMethod = null, ITwilioRestClient client = null)
        {
            var options = new UpdateParticipantOptions(conferenceSid, callSid){PathAccountSid = accountSid, Muted = muted, Hold = hold, HoldUrl = holdUrl, HoldMethod = holdMethod};
            return Update(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Update the properties of this participant
        /// </summary>
        ///
        /// <param name="conferenceSid"> The string that uniquely identifies this conference </param>
        /// <param name="callSid"> The call_sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="muted"> Indicates if the participant should be muted </param>
        /// <param name="hold"> The hold </param>
        /// <param name="holdUrl"> The hold_url </param>
        /// <param name="holdMethod"> The hold_method </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Participant </returns> 
        public static async System.Threading.Tasks.Task<ParticipantResource> UpdateAsync(string conferenceSid, string callSid, string accountSid = null, bool? muted = null, bool? hold = null, Uri holdUrl = null, Twilio.Http.HttpMethod holdMethod = null, ITwilioRestClient client = null)
        {
            var options = new UpdateParticipantOptions(conferenceSid, callSid){PathAccountSid = accountSid, Muted = muted, Hold = hold, HoldUrl = holdUrl, HoldMethod = holdMethod};
            return await UpdateAsync(options, client);
        }
        #endif
    
        private static Request BuildCreateRequest(CreateParticipantOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Conferences/" + options.PathConferenceSid + "/Participants.json",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="options"> Create Participant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Participant </returns> 
        public static ParticipantResource Create(CreateParticipantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="options"> Create Participant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Participant </returns> 
        public static async System.Threading.Tasks.Task<ParticipantResource> CreateAsync(CreateParticipantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="conferenceSid"> The conference_sid </param>
        /// <param name="from"> The from </param>
        /// <param name="to"> The to </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="statusCallback"> The status_callback </param>
        /// <param name="statusCallbackMethod"> The status_callback_method </param>
        /// <param name="statusCallbackEvent"> The status_callback_event </param>
        /// <param name="timeout"> The timeout </param>
        /// <param name="record"> The record </param>
        /// <param name="muted"> The muted </param>
        /// <param name="beep"> The beep </param>
        /// <param name="startConferenceOnEnter"> The start_conference_on_enter </param>
        /// <param name="endConferenceOnExit"> The end_conference_on_exit </param>
        /// <param name="waitUrl"> The wait_url </param>
        /// <param name="waitMethod"> The wait_method </param>
        /// <param name="earlyMedia"> The early_media </param>
        /// <param name="maxParticipants"> The max_participants </param>
        /// <param name="conferenceRecord"> The conference_record </param>
        /// <param name="conferenceTrim"> The conference_trim </param>
        /// <param name="conferenceStatusCallback"> The conference_status_callback </param>
        /// <param name="conferenceStatusCallbackMethod"> The conference_status_callback_method </param>
        /// <param name="conferenceStatusCallbackEvent"> The conference_status_callback_event </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Participant </returns> 
        public static ParticipantResource Create(string conferenceSid, Types.PhoneNumber from, Types.PhoneNumber to, string accountSid = null, Uri statusCallback = null, Twilio.Http.HttpMethod statusCallbackMethod = null, List<string> statusCallbackEvent = null, int? timeout = null, bool? record = null, bool? muted = null, ParticipantResource.BeepEnum beep = null, bool? startConferenceOnEnter = null, bool? endConferenceOnExit = null, Uri waitUrl = null, Twilio.Http.HttpMethod waitMethod = null, bool? earlyMedia = null, int? maxParticipants = null, ParticipantResource.ConferenceRecordEnum conferenceRecord = null, string conferenceTrim = null, Uri conferenceStatusCallback = null, Twilio.Http.HttpMethod conferenceStatusCallbackMethod = null, List<string> conferenceStatusCallbackEvent = null, ITwilioRestClient client = null)
        {
            var options = new CreateParticipantOptions(conferenceSid, from, to){PathAccountSid = accountSid, StatusCallback = statusCallback, StatusCallbackMethod = statusCallbackMethod, StatusCallbackEvent = statusCallbackEvent, Timeout = timeout, Record = record, Muted = muted, Beep = beep, StartConferenceOnEnter = startConferenceOnEnter, EndConferenceOnExit = endConferenceOnExit, WaitUrl = waitUrl, WaitMethod = waitMethod, EarlyMedia = earlyMedia, MaxParticipants = maxParticipants, ConferenceRecord = conferenceRecord, ConferenceTrim = conferenceTrim, ConferenceStatusCallback = conferenceStatusCallback, ConferenceStatusCallbackMethod = conferenceStatusCallbackMethod, ConferenceStatusCallbackEvent = conferenceStatusCallbackEvent};
            return Create(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="conferenceSid"> The conference_sid </param>
        /// <param name="from"> The from </param>
        /// <param name="to"> The to </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="statusCallback"> The status_callback </param>
        /// <param name="statusCallbackMethod"> The status_callback_method </param>
        /// <param name="statusCallbackEvent"> The status_callback_event </param>
        /// <param name="timeout"> The timeout </param>
        /// <param name="record"> The record </param>
        /// <param name="muted"> The muted </param>
        /// <param name="beep"> The beep </param>
        /// <param name="startConferenceOnEnter"> The start_conference_on_enter </param>
        /// <param name="endConferenceOnExit"> The end_conference_on_exit </param>
        /// <param name="waitUrl"> The wait_url </param>
        /// <param name="waitMethod"> The wait_method </param>
        /// <param name="earlyMedia"> The early_media </param>
        /// <param name="maxParticipants"> The max_participants </param>
        /// <param name="conferenceRecord"> The conference_record </param>
        /// <param name="conferenceTrim"> The conference_trim </param>
        /// <param name="conferenceStatusCallback"> The conference_status_callback </param>
        /// <param name="conferenceStatusCallbackMethod"> The conference_status_callback_method </param>
        /// <param name="conferenceStatusCallbackEvent"> The conference_status_callback_event </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Participant </returns> 
        public static async System.Threading.Tasks.Task<ParticipantResource> CreateAsync(string conferenceSid, Types.PhoneNumber from, Types.PhoneNumber to, string accountSid = null, Uri statusCallback = null, Twilio.Http.HttpMethod statusCallbackMethod = null, List<string> statusCallbackEvent = null, int? timeout = null, bool? record = null, bool? muted = null, ParticipantResource.BeepEnum beep = null, bool? startConferenceOnEnter = null, bool? endConferenceOnExit = null, Uri waitUrl = null, Twilio.Http.HttpMethod waitMethod = null, bool? earlyMedia = null, int? maxParticipants = null, ParticipantResource.ConferenceRecordEnum conferenceRecord = null, string conferenceTrim = null, Uri conferenceStatusCallback = null, Twilio.Http.HttpMethod conferenceStatusCallbackMethod = null, List<string> conferenceStatusCallbackEvent = null, ITwilioRestClient client = null)
        {
            var options = new CreateParticipantOptions(conferenceSid, from, to){PathAccountSid = accountSid, StatusCallback = statusCallback, StatusCallbackMethod = statusCallbackMethod, StatusCallbackEvent = statusCallbackEvent, Timeout = timeout, Record = record, Muted = muted, Beep = beep, StartConferenceOnEnter = startConferenceOnEnter, EndConferenceOnExit = endConferenceOnExit, WaitUrl = waitUrl, WaitMethod = waitMethod, EarlyMedia = earlyMedia, MaxParticipants = maxParticipants, ConferenceRecord = conferenceRecord, ConferenceTrim = conferenceTrim, ConferenceStatusCallback = conferenceStatusCallback, ConferenceStatusCallbackMethod = conferenceStatusCallbackMethod, ConferenceStatusCallbackEvent = conferenceStatusCallbackEvent};
            return await CreateAsync(options, client);
        }
        #endif
    
        private static Request BuildDeleteRequest(DeleteParticipantOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Conferences/" + options.PathConferenceSid + "/Participants/" + options.PathCallSid + ".json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Kick a participant from a given conference
        /// </summary>
        ///
        /// <param name="options"> Delete Participant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Participant </returns> 
        public static bool Delete(DeleteParticipantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
    
        #if !NET35
        /// <summary>
        /// Kick a participant from a given conference
        /// </summary>
        ///
        /// <param name="options"> Delete Participant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Participant </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteParticipantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif
    
        /// <summary>
        /// Kick a participant from a given conference
        /// </summary>
        ///
        /// <param name="conferenceSid"> The string that uniquely identifies this conference </param>
        /// <param name="callSid"> The call_sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Participant </returns> 
        public static bool Delete(string conferenceSid, string callSid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteParticipantOptions(conferenceSid, callSid){PathAccountSid = accountSid};
            return Delete(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Kick a participant from a given conference
        /// </summary>
        ///
        /// <param name="conferenceSid"> The string that uniquely identifies this conference </param>
        /// <param name="callSid"> The call_sid </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Participant </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string conferenceSid, string callSid, string accountSid = null, ITwilioRestClient client = null)
        {
            var options = new DeleteParticipantOptions(conferenceSid, callSid){PathAccountSid = accountSid};
            return await DeleteAsync(options, client);
        }
        #endif
    
        private static Request BuildReadRequest(ReadParticipantOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Api,
                "/2010-04-01/Accounts/" + (options.PathAccountSid ?? client.AccountSid) + "/Conferences/" + options.PathConferenceSid + "/Participants.json",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// Retrieve a list of participants belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="options"> Read Participant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Participant </returns> 
        public static ResourceSet<ParticipantResource> Read(ReadParticipantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<ParticipantResource>.FromJson("participants", response.Content);
            return new ResourceSet<ParticipantResource>(page, options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Retrieve a list of participants belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="options"> Read Participant parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Participant </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<ParticipantResource>> ReadAsync(ReadParticipantOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<ParticipantResource>.FromJson("participants", response.Content);
            return new ResourceSet<ParticipantResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// Retrieve a list of participants belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="conferenceSid"> The string that uniquely identifies this conference </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="muted"> Filter by muted participants </param>
        /// <param name="hold"> The hold </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Participant </returns> 
        public static ResourceSet<ParticipantResource> Read(string conferenceSid, string accountSid = null, bool? muted = null, bool? hold = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadParticipantOptions(conferenceSid){PathAccountSid = accountSid, Muted = muted, Hold = hold, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// Retrieve a list of participants belonging to the account used to make the request
        /// </summary>
        ///
        /// <param name="conferenceSid"> The string that uniquely identifies this conference </param>
        /// <param name="accountSid"> The account_sid </param>
        /// <param name="muted"> Filter by muted participants </param>
        /// <param name="hold"> The hold </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Participant </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<ParticipantResource>> ReadAsync(string conferenceSid, string accountSid = null, bool? muted = null, bool? hold = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadParticipantOptions(conferenceSid){PathAccountSid = accountSid, Muted = muted, Hold = hold, PageSize = pageSize, Limit = limit};
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
        public static Page<ParticipantResource> NextPage(Page<ParticipantResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Api,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<ParticipantResource>.FromJson("participants", response.Content);
        }
    
        /// <summary>
        /// Converts a JSON string into a ParticipantResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ParticipantResource object represented by the provided JSON </returns> 
        public static ParticipantResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<ParticipantResource>(json);
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
        /// A string that uniquely identifies this call
        /// </summary>
        [JsonProperty("call_sid")]
        public string CallSid { get; private set; }
        /// <summary>
        /// A string that uniquely identifies this conference
        /// </summary>
        [JsonProperty("conference_sid")]
        public string ConferenceSid { get; private set; }
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
        /// Indicates if the endConferenceOnExit was set
        /// </summary>
        [JsonProperty("end_conference_on_exit")]
        public bool? EndConferenceOnExit { get; private set; }
        /// <summary>
        /// Indicates if the participant is muted
        /// </summary>
        [JsonProperty("muted")]
        public bool? Muted { get; private set; }
        /// <summary>
        /// The hold
        /// </summary>
        [JsonProperty("hold")]
        public bool? Hold { get; private set; }
        /// <summary>
        /// Indicates if the startConferenceOnEnter attribute was set
        /// </summary>
        [JsonProperty("start_conference_on_enter")]
        public bool? StartConferenceOnEnter { get; private set; }
        /// <summary>
        /// The status
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ParticipantResource.StatusEnum Status { get; private set; }
        /// <summary>
        /// The URI for this resource
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; private set; }
    
        private ParticipantResource()
        {
        
        }
    }

}