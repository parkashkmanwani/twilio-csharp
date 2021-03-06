/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Serverless.V1.Service.Environment
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Retrieve a list of all Variables.
    /// </summary>
    public class ReadVariableOptions : ReadOptions<VariableResource>
    {
        /// <summary>
        /// The SID of the Service to read the Variable resources from
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the environment with the Variable resources to read
        /// </summary>
        public string PathEnvironmentSid { get; }

        /// <summary>
        /// Construct a new ReadVariableOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to read the Variable resources from </param>
        /// <param name="pathEnvironmentSid"> The SID of the environment with the Variable resources to read </param>
        public ReadVariableOptions(string pathServiceSid, string pathEnvironmentSid)
        {
            PathServiceSid = pathServiceSid;
            PathEnvironmentSid = pathEnvironmentSid;
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

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Retrieve a specific variable.
    /// </summary>
    public class FetchVariableOptions : IOptions<VariableResource>
    {
        /// <summary>
        /// The SID of the Service to fetch the Variable resource from
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the environment with the Variable resource to fetch
        /// </summary>
        public string PathEnvironmentSid { get; }
        /// <summary>
        /// The SID of the Variable resource to fetch
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchVariableOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to fetch the Variable resource from </param>
        /// <param name="pathEnvironmentSid"> The SID of the environment with the Variable resource to fetch </param>
        /// <param name="pathSid"> The SID of the Variable resource to fetch </param>
        public FetchVariableOptions(string pathServiceSid, string pathEnvironmentSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathEnvironmentSid = pathEnvironmentSid;
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
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Create a new variable.
    /// </summary>
    public class CreateVariableOptions : IOptions<VariableResource>
    {
        /// <summary>
        /// The SID of the Service to create the Variable resource under
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the environment in which the variable exists
        /// </summary>
        public string PathEnvironmentSid { get; }
        /// <summary>
        /// A string by which the Variable resource can be referenced
        /// </summary>
        public string Key { get; }
        /// <summary>
        /// A string that contains the actual value of the variable
        /// </summary>
        public string Value { get; }

        /// <summary>
        /// Construct a new CreateVariableOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to create the Variable resource under </param>
        /// <param name="pathEnvironmentSid"> The SID of the environment in which the variable exists </param>
        /// <param name="key"> A string by which the Variable resource can be referenced </param>
        /// <param name="value"> A string that contains the actual value of the variable </param>
        public CreateVariableOptions(string pathServiceSid, string pathEnvironmentSid, string key, string value)
        {
            PathServiceSid = pathServiceSid;
            PathEnvironmentSid = pathEnvironmentSid;
            Key = key;
            Value = value;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Key != null)
            {
                p.Add(new KeyValuePair<string, string>("Key", Key));
            }

            if (Value != null)
            {
                p.Add(new KeyValuePair<string, string>("Value", Value));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Update a specific variable.
    /// </summary>
    public class UpdateVariableOptions : IOptions<VariableResource>
    {
        /// <summary>
        /// The SID of the Service to update the Variable resource under
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the environment with the Variable resource to update
        /// </summary>
        public string PathEnvironmentSid { get; }
        /// <summary>
        /// The SID of the Variable resource to update
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// A string by which the Variable resource can be referenced
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// A string that contains the actual value of the variable
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Construct a new UpdateVariableOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to update the Variable resource under </param>
        /// <param name="pathEnvironmentSid"> The SID of the environment with the Variable resource to update </param>
        /// <param name="pathSid"> The SID of the Variable resource to update </param>
        public UpdateVariableOptions(string pathServiceSid, string pathEnvironmentSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathEnvironmentSid = pathEnvironmentSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Key != null)
            {
                p.Add(new KeyValuePair<string, string>("Key", Key));
            }

            if (Value != null)
            {
                p.Add(new KeyValuePair<string, string>("Value", Value));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    ///
    /// Delete a specific variable.
    /// </summary>
    public class DeleteVariableOptions : IOptions<VariableResource>
    {
        /// <summary>
        /// The SID of the Service to delete the Variable resource from
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The SID of the environment with the Variables to delete
        /// </summary>
        public string PathEnvironmentSid { get; }
        /// <summary>
        /// The SID of the Variable resource to delete
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteVariableOptions
        /// </summary>
        /// <param name="pathServiceSid"> The SID of the Service to delete the Variable resource from </param>
        /// <param name="pathEnvironmentSid"> The SID of the environment with the Variables to delete </param>
        /// <param name="pathSid"> The SID of the Variable resource to delete </param>
        public DeleteVariableOptions(string pathServiceSid, string pathEnvironmentSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathEnvironmentSid = pathEnvironmentSid;
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