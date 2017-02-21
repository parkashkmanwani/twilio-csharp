using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;

namespace Twilio.Rest.Api.V2010.Account.Call 
{

    /// <summary>
    /// CreateFeedbackOptions
    /// </summary>
    public class CreateFeedbackOptions : IOptions<FeedbackResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The call_sid
        /// </summary>
        public string PathCallSid { get; }
        /// <summary>
        /// The quality_score
        /// </summary>
        public int? QualityScore { get; }
        /// <summary>
        /// The issue
        /// </summary>
        public List<FeedbackResource.IssuesEnum> Issue { get; set; }
    
        /// <summary>
        /// Construct a new CreateFeedbackOptions
        /// </summary>
        ///
        /// <param name="callSid"> The call_sid </param>
        /// <param name="qualityScore"> The quality_score </param>
        public CreateFeedbackOptions(string callSid, int? qualityScore)
        {
            PathCallSid = callSid;
            QualityScore = qualityScore;
            Issue = new List<FeedbackResource.IssuesEnum>();
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (QualityScore != null)
            {
                p.Add(new KeyValuePair<string, string>("QualityScore", QualityScore.Value.ToString()));
            }
            
            if (Issue != null)
            {
                p.AddRange(Issue.Select(prop => new KeyValuePair<string, string>("Issue", prop.ToString())));
            }
            
            return p;
        }
    }

    /// <summary>
    /// Fetch an instance of a feedback entry for a call
    /// </summary>
    public class FetchFeedbackOptions : IOptions<FeedbackResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The call sid that uniquely identifies the call
        /// </summary>
        public string PathCallSid { get; }
    
        /// <summary>
        /// Construct a new FetchFeedbackOptions
        /// </summary>
        ///
        /// <param name="callSid"> The call sid that uniquely identifies the call </param>
        public FetchFeedbackOptions(string callSid)
        {
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
    /// Create or update a feedback entry for a call
    /// </summary>
    public class UpdateFeedbackOptions : IOptions<FeedbackResource> 
    {
        /// <summary>
        /// The account_sid
        /// </summary>
        public string PathAccountSid { get; set; }
        /// <summary>
        /// The call_sid
        /// </summary>
        public string PathCallSid { get; }
        /// <summary>
        /// An integer from 1 to 5
        /// </summary>
        public int? QualityScore { get; }
        /// <summary>
        /// Issues experienced during the call
        /// </summary>
        public List<FeedbackResource.IssuesEnum> Issue { get; set; }
    
        /// <summary>
        /// Construct a new UpdateFeedbackOptions
        /// </summary>
        ///
        /// <param name="callSid"> The call_sid </param>
        /// <param name="qualityScore"> An integer from 1 to 5 </param>
        public UpdateFeedbackOptions(string callSid, int? qualityScore)
        {
            PathCallSid = callSid;
            QualityScore = qualityScore;
            Issue = new List<FeedbackResource.IssuesEnum>();
        }
    
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (QualityScore != null)
            {
                p.Add(new KeyValuePair<string, string>("QualityScore", QualityScore.Value.ToString()));
            }
            
            if (Issue != null)
            {
                p.AddRange(Issue.Select(prop => new KeyValuePair<string, string>("Issue", prop.ToString())));
            }
            
            return p;
        }
    }

}