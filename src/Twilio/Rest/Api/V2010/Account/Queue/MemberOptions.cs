using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Api.V2010.Account.Queue 
{

    /// <summary>
    /// Fetch a specific members of the queue
    /// </summary>
    public class FetchMemberOptions : IOptions<MemberResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The Queue in which to find the members
        /// </summary>
        public string PathQueueSid { get; }
        /// <summary>
        /// The call_sid
        /// </summary>
        public string PathCallSid { get; }
    
        /// <summary>
        /// Construct a new FetchMemberOptions
        /// </summary>
        ///
        /// <param name="queueSid"> The Queue in which to find the members </param>
        /// <param name="callSid"> The call_sid </param>
        public FetchMemberOptions(string queueSid, string callSid)
        {
            PathQueueSid = queueSid;
            PathCallSid = callSid;
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
    /// Dequeue a member from a queue and have the member's call begin executing the TwiML document at that URL
    /// </summary>
    public class UpdateMemberOptions : IOptions<MemberResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The Queue in which to find the members
        /// </summary>
        public string PathQueueSid { get; }
        /// <summary>
        /// The call_sid
        /// </summary>
        public string PathCallSid { get; }
        /// <summary>
        /// The url
        /// </summary>
        public Uri Url { get; }
        /// <summary>
        /// The method
        /// </summary>
        public Twilio.Http.HttpMethod Method { get; }
    
        /// <summary>
        /// Construct a new UpdateMemberOptions
        /// </summary>
        ///
        /// <param name="queueSid"> The Queue in which to find the members </param>
        /// <param name="callSid"> The call_sid </param>
        /// <param name="url"> The url </param>
        /// <param name="method"> The method </param>
        public UpdateMemberOptions(string queueSid, string callSid, Uri url, Twilio.Http.HttpMethod method)
        {
            PathQueueSid = queueSid;
            PathCallSid = callSid;
            Url = url;
            Method = method;
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Url != null)
            {
                p.Add(new KeyValuePair<string, string>("Url", Url.ToString()));
            }
            
            if (Method != null)
            {
                p.Add(new KeyValuePair<string, string>("Method", Method.ToString()));
            }
            
            return p;
        }
    }

    /// <summary>
    /// Retrieve a list of members in the queue
    /// </summary>
    public class ReadMemberOptions : ReadOptions<MemberResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The Queue in which to find members
        /// </summary>
        public string PathQueueSid { get; }
    
        /// <summary>
        /// Construct a new ReadMemberOptions
        /// </summary>
        ///
        /// <param name="queueSid"> The Queue in which to find members </param>
        public ReadMemberOptions(string queueSid)
        {
            PathQueueSid = queueSid;
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

}