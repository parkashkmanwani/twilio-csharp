using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Taskrouter.V1.Workspace.Workflow 
{

    /// <summary>
    /// WorkflowStatisticsResource
    /// </summary>
    public class WorkflowStatisticsResource : Resource 
    {
        private static Request BuildFetchRequest(FetchWorkflowStatisticsOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.PathWorkspaceSid + "/Workflows/" + options.PathWorkflowSid + "/Statistics",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch WorkflowStatistics parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of WorkflowStatistics </returns> 
        public static WorkflowStatisticsResource Fetch(FetchWorkflowStatisticsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch WorkflowStatistics parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of WorkflowStatistics </returns> 
        public static async System.Threading.Tasks.Task<WorkflowStatisticsResource> FetchAsync(FetchWorkflowStatisticsOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="workflowSid"> The workflow_sid </param>
        /// <param name="minutes"> The minutes </param>
        /// <param name="startDate"> The start_date </param>
        /// <param name="endDate"> The end_date </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of WorkflowStatistics </returns> 
        public static WorkflowStatisticsResource Fetch(string workspaceSid, string workflowSid, int? minutes = null, DateTime? startDate = null, DateTime? endDate = null, ITwilioRestClient client = null)
        {
            var options = new FetchWorkflowStatisticsOptions(workspaceSid, workflowSid){Minutes = minutes, StartDate = startDate, EndDate = endDate};
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="workflowSid"> The workflow_sid </param>
        /// <param name="minutes"> The minutes </param>
        /// <param name="startDate"> The start_date </param>
        /// <param name="endDate"> The end_date </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of WorkflowStatistics </returns> 
        public static async System.Threading.Tasks.Task<WorkflowStatisticsResource> FetchAsync(string workspaceSid, string workflowSid, int? minutes = null, DateTime? startDate = null, DateTime? endDate = null, ITwilioRestClient client = null)
        {
            var options = new FetchWorkflowStatisticsOptions(workspaceSid, workflowSid){Minutes = minutes, StartDate = startDate, EndDate = endDate};
            return await FetchAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a WorkflowStatisticsResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> WorkflowStatisticsResource object represented by the provided JSON </returns> 
        public static WorkflowStatisticsResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<WorkflowStatisticsResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }
    
        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The cumulative
        /// </summary>
        [JsonProperty("cumulative")]
        public object Cumulative { get; private set; }
        /// <summary>
        /// The realtime
        /// </summary>
        [JsonProperty("realtime")]
        public object Realtime { get; private set; }
        /// <summary>
        /// The workflow_sid
        /// </summary>
        [JsonProperty("workflow_sid")]
        public string WorkflowSid { get; private set; }
        /// <summary>
        /// The workspace_sid
        /// </summary>
        [JsonProperty("workspace_sid")]
        public string WorkspaceSid { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
    
        private WorkflowStatisticsResource()
        {
        
        }
    }

}