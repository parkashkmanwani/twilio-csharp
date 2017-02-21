using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

namespace Twilio.Rest.Taskrouter.V1.Workspace 
{

    /// <summary>
    /// WorkflowResource
    /// </summary>
    public class WorkflowResource : Resource 
    {
        private static Request BuildFetchRequest(FetchWorkflowOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.PathWorkspaceSid + "/Workflows/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch Workflow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Workflow </returns> 
        public static WorkflowResource Fetch(FetchWorkflowOptions options, ITwilioRestClient client = null)
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
        /// <param name="options"> Fetch Workflow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Workflow </returns> 
        public static async System.Threading.Tasks.Task<WorkflowResource> FetchAsync(FetchWorkflowOptions options, ITwilioRestClient client = null)
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
        /// <param name="sid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Workflow </returns> 
        public static WorkflowResource Fetch(string workspaceSid, string sid, ITwilioRestClient client = null)
        {
            var options = new FetchWorkflowOptions(workspaceSid, sid);
            return Fetch(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Workflow </returns> 
        public static async System.Threading.Tasks.Task<WorkflowResource> FetchAsync(string workspaceSid, string sid, ITwilioRestClient client = null)
        {
            var options = new FetchWorkflowOptions(workspaceSid, sid);
            return await FetchAsync(options, client);
        }
        #endif
    
        private static Request BuildUpdateRequest(UpdateWorkflowOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.PathWorkspaceSid + "/Workflows/" + options.PathSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="options"> Update Workflow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Workflow </returns> 
        public static WorkflowResource Update(UpdateWorkflowOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
    
        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="options"> Update Workflow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Workflow </returns> 
        public static async System.Threading.Tasks.Task<WorkflowResource> UpdateAsync(UpdateWorkflowOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif
    
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="assignmentCallbackUrl"> The assignment_callback_url </param>
        /// <param name="fallbackAssignmentCallbackUrl"> The fallback_assignment_callback_url </param>
        /// <param name="configuration"> The configuration </param>
        /// <param name="taskReservationTimeout"> The task_reservation_timeout </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Workflow </returns> 
        public static WorkflowResource Update(string workspaceSid, string sid, string friendlyName = null, Uri assignmentCallbackUrl = null, Uri fallbackAssignmentCallbackUrl = null, string configuration = null, int? taskReservationTimeout = null, ITwilioRestClient client = null)
        {
            var options = new UpdateWorkflowOptions(workspaceSid, sid){FriendlyName = friendlyName, AssignmentCallbackUrl = assignmentCallbackUrl, FallbackAssignmentCallbackUrl = fallbackAssignmentCallbackUrl, Configuration = configuration, TaskReservationTimeout = taskReservationTimeout};
            return Update(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="assignmentCallbackUrl"> The assignment_callback_url </param>
        /// <param name="fallbackAssignmentCallbackUrl"> The fallback_assignment_callback_url </param>
        /// <param name="configuration"> The configuration </param>
        /// <param name="taskReservationTimeout"> The task_reservation_timeout </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Workflow </returns> 
        public static async System.Threading.Tasks.Task<WorkflowResource> UpdateAsync(string workspaceSid, string sid, string friendlyName = null, Uri assignmentCallbackUrl = null, Uri fallbackAssignmentCallbackUrl = null, string configuration = null, int? taskReservationTimeout = null, ITwilioRestClient client = null)
        {
            var options = new UpdateWorkflowOptions(workspaceSid, sid){FriendlyName = friendlyName, AssignmentCallbackUrl = assignmentCallbackUrl, FallbackAssignmentCallbackUrl = fallbackAssignmentCallbackUrl, Configuration = configuration, TaskReservationTimeout = taskReservationTimeout};
            return await UpdateAsync(options, client);
        }
        #endif
    
        private static Request BuildDeleteRequest(DeleteWorkflowOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.PathWorkspaceSid + "/Workflows/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete Workflow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Workflow </returns> 
        public static bool Delete(DeleteWorkflowOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
    
        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete Workflow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Workflow </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteWorkflowOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif
    
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Workflow </returns> 
        public static bool Delete(string workspaceSid, string sid, ITwilioRestClient client = null)
        {
            var options = new DeleteWorkflowOptions(workspaceSid, sid);
            return Delete(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="sid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Workflow </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string workspaceSid, string sid, ITwilioRestClient client = null)
        {
            var options = new DeleteWorkflowOptions(workspaceSid, sid);
            return await DeleteAsync(options, client);
        }
        #endif
    
        private static Request BuildReadRequest(ReadWorkflowOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.PathWorkspaceSid + "/Workflows",
                client.Region,
                queryParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Workflow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Workflow </returns> 
        public static ResourceSet<WorkflowResource> Read(ReadWorkflowOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));
            
            var page = Page<WorkflowResource>.FromJson("workflows", response.Content);
            return new ResourceSet<WorkflowResource>(page, options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Workflow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Workflow </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<WorkflowResource>> ReadAsync(ReadWorkflowOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));
            
            var page = Page<WorkflowResource>.FromJson("workflows", response.Content);
            return new ResourceSet<WorkflowResource>(page, options, client);
        }
        #endif
    
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Workflow </returns> 
        public static ResourceSet<WorkflowResource> Read(string workspaceSid, string friendlyName = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadWorkflowOptions(workspaceSid){FriendlyName = friendlyName, PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Workflow </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<WorkflowResource>> ReadAsync(string workspaceSid, string friendlyName = null, int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadWorkflowOptions(workspaceSid){FriendlyName = friendlyName, PageSize = pageSize, Limit = limit};
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
        public static Page<WorkflowResource> NextPage(Page<WorkflowResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Taskrouter,
                    client.Region
                )
            );
            
            var response = client.Request(request);
            return Page<WorkflowResource>.FromJson("workflows", response.Content);
        }
    
        private static Request BuildCreateRequest(CreateWorkflowOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Taskrouter,
                "/v1/Workspaces/" + options.PathWorkspaceSid + "/Workflows",
                client.Region,
                postParams: options.GetParams()
            );
        }
    
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="options"> Create Workflow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Workflow </returns> 
        public static WorkflowResource Create(CreateWorkflowOptions options, ITwilioRestClient client = null)
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
        /// <param name="options"> Create Workflow parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Workflow </returns> 
        public static async System.Threading.Tasks.Task<WorkflowResource> CreateAsync(CreateWorkflowOptions options, ITwilioRestClient client = null)
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
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="configuration"> The configuration </param>
        /// <param name="assignmentCallbackUrl"> The assignment_callback_url </param>
        /// <param name="fallbackAssignmentCallbackUrl"> The fallback_assignment_callback_url </param>
        /// <param name="taskReservationTimeout"> The task_reservation_timeout </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Workflow </returns> 
        public static WorkflowResource Create(string workspaceSid, string friendlyName, string configuration, Uri assignmentCallbackUrl = null, Uri fallbackAssignmentCallbackUrl = null, int? taskReservationTimeout = null, ITwilioRestClient client = null)
        {
            var options = new CreateWorkflowOptions(workspaceSid, friendlyName, configuration){AssignmentCallbackUrl = assignmentCallbackUrl, FallbackAssignmentCallbackUrl = fallbackAssignmentCallbackUrl, TaskReservationTimeout = taskReservationTimeout};
            return Create(options, client);
        }
    
        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="workspaceSid"> The workspace_sid </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="configuration"> The configuration </param>
        /// <param name="assignmentCallbackUrl"> The assignment_callback_url </param>
        /// <param name="fallbackAssignmentCallbackUrl"> The fallback_assignment_callback_url </param>
        /// <param name="taskReservationTimeout"> The task_reservation_timeout </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Workflow </returns> 
        public static async System.Threading.Tasks.Task<WorkflowResource> CreateAsync(string workspaceSid, string friendlyName, string configuration, Uri assignmentCallbackUrl = null, Uri fallbackAssignmentCallbackUrl = null, int? taskReservationTimeout = null, ITwilioRestClient client = null)
        {
            var options = new CreateWorkflowOptions(workspaceSid, friendlyName, configuration){AssignmentCallbackUrl = assignmentCallbackUrl, FallbackAssignmentCallbackUrl = fallbackAssignmentCallbackUrl, TaskReservationTimeout = taskReservationTimeout};
            return await CreateAsync(options, client);
        }
        #endif
    
        /// <summary>
        /// Converts a JSON string into a WorkflowResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> WorkflowResource object represented by the provided JSON </returns> 
        public static WorkflowResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<WorkflowResource>(json);
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
        /// The assignment_callback_url
        /// </summary>
        [JsonProperty("assignment_callback_url")]
        public Uri AssignmentCallbackUrl { get; private set; }
        /// <summary>
        /// The configuration
        /// </summary>
        [JsonProperty("configuration")]
        public string Configuration { get; private set; }
        /// <summary>
        /// The date_created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date_updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The document_content_type
        /// </summary>
        [JsonProperty("document_content_type")]
        public string DocumentContentType { get; private set; }
        /// <summary>
        /// The fallback_assignment_callback_url
        /// </summary>
        [JsonProperty("fallback_assignment_callback_url")]
        public Uri FallbackAssignmentCallbackUrl { get; private set; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The task_reservation_timeout
        /// </summary>
        [JsonProperty("task_reservation_timeout")]
        public int? TaskReservationTimeout { get; private set; }
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
        /// <summary>
        /// The links
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }
    
        private WorkflowResource()
        {
        
        }
    }

}