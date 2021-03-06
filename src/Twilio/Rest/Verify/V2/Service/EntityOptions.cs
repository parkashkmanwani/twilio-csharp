/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Verify.V2.Service
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Create a new Entity for the Service
    /// </summary>
    public class CreateEntityOptions : IOptions<EntityResource>
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Unique identity of the Entity
        /// </summary>
        public string Identity { get; }

        /// <summary>
        /// Construct a new CreateEntityOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="identity"> Unique identity of the Entity </param>
        public CreateEntityOptions(string pathServiceSid, string identity)
        {
            PathServiceSid = pathServiceSid;
            Identity = identity;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Identity != null)
            {
                p.Add(new KeyValuePair<string, string>("Identity", Identity));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Delete a specific Entity.
    /// </summary>
    public class DeleteEntityOptions : IOptions<EntityResource>
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Unique identity of the Entity
        /// </summary>
        public string PathIdentity { get; }

        /// <summary>
        /// Construct a new DeleteEntityOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique identity of the Entity </param>
        public DeleteEntityOptions(string pathServiceSid, string pathIdentity)
        {
            PathServiceSid = pathServiceSid;
            PathIdentity = pathIdentity;
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
    /// Fetch a specific Entity.
    /// </summary>
    public class FetchEntityOptions : IOptions<EntityResource>
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Unique identity of the Entity
        /// </summary>
        public string PathIdentity { get; }

        /// <summary>
        /// Construct a new FetchEntityOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathIdentity"> Unique identity of the Entity </param>
        public FetchEntityOptions(string pathServiceSid, string pathIdentity)
        {
            PathServiceSid = pathServiceSid;
            PathIdentity = pathIdentity;
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
    /// Retrieve a list of all Entities for a Service.
    /// </summary>
    public class ReadEntityOptions : ReadOptions<EntityResource>
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }

        /// <summary>
        /// Construct a new ReadEntityOptions
        /// </summary>
        /// <param name="pathServiceSid"> Service Sid. </param>
        public ReadEntityOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
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