/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NSubstitute;
using NSubstitute.ExceptionExtensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Rest.Voice.V1;

namespace Twilio.Tests.Rest.Voice.V1
{

    [TestFixture]
    public class SourceIpMappingTest : TwilioTest
    {
        [Test]
        public void TestCreateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Voice,
                "/v1/SourceIpMappings",
                ""
            );
            request.AddPostParam("IpRecordSid", Serialize("ILXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"));
            request.AddPostParam("SipDomainSid", Serialize("SDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SourceIpMappingResource.Create("ILXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "SDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestCreateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.Created,
                                         "{\"sid\": \"IBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"ip_record_sid\": \"ILaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sip_domain_sid\": \"SDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2020-03-18T23:31:36Z\",\"date_updated\": \"2020-03-18T23:31:36Z\",\"url\": \"https://voice.twilio.com/v1/SourceIpMappings/IBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = SourceIpMappingResource.Create("ILXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "SDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestFetchRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Voice,
                "/v1/SourceIpMappings/IBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SourceIpMappingResource.Fetch("IBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestFetchResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"sid\": \"IBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"ip_record_sid\": \"ILaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sip_domain_sid\": \"SDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2020-03-18T23:31:36Z\",\"date_updated\": \"2020-03-18T23:31:37Z\",\"url\": \"https://voice.twilio.com/v1/SourceIpMappings/IBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = SourceIpMappingResource.Fetch("IBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Get,
                Twilio.Rest.Domain.Voice,
                "/v1/SourceIpMappings",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SourceIpMappingResource.Read(client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestReadFullResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"meta\": {\"page\": 0,\"page_size\": 50,\"first_page_url\": \"https://voice.twilio.com/v1/SourceIpMappings?PageSize=50&Page=0\",\"previous_page_url\": null,\"url\": \"https://voice.twilio.com/v1/SourceIpMappings?PageSize=50&Page=0\",\"next_page_url\": null,\"key\": \"source_ip_mappings\"},\"source_ip_mappings\": [{\"sid\": \"IBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"ip_record_sid\": \"ILaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sip_domain_sid\": \"SDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"date_created\": \"2020-03-18T23:31:36Z\",\"date_updated\": \"2020-03-18T23:31:37Z\",\"url\": \"https://voice.twilio.com/v1/SourceIpMappings/IBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}]}"
                                     ));

            var response = SourceIpMappingResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestReadEmptyResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"meta\": {\"page\": 0,\"page_size\": 50,\"first_page_url\": \"https://voice.twilio.com/v1/SourceIpMappings?PageSize=50&Page=0\",\"previous_page_url\": null,\"url\": \"https://voice.twilio.com/v1/SourceIpMappings?PageSize=50&Page=0\",\"next_page_url\": null,\"key\": \"source_ip_mappings\"},\"source_ip_mappings\": []}"
                                     ));

            var response = SourceIpMappingResource.Read(client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestUpdateRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Post,
                Twilio.Rest.Domain.Voice,
                "/v1/SourceIpMappings/IBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            request.AddPostParam("SipDomainSid", Serialize("SDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"));
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SourceIpMappingResource.Update("IBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "SDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestUpdateResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.OK,
                                         "{\"sid\": \"IBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"ip_record_sid\": \"ILaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\",\"sip_domain_sid\": \"SDaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab\",\"date_created\": \"2020-03-18T23:31:36Z\",\"date_updated\": \"2020-03-18T23:31:37Z\",\"url\": \"https://voice.twilio.com/v1/SourceIpMappings/IBaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\"}"
                                     ));

            var response = SourceIpMappingResource.Update("IBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "SDXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }

        [Test]
        public void TestDeleteRequest()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            var request = new Request(
                HttpMethod.Delete,
                Twilio.Rest.Domain.Voice,
                "/v1/SourceIpMappings/IBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX",
                ""
            );
            twilioRestClient.Request(request).Throws(new ApiException("Server Error, no content"));

            try
            {
                SourceIpMappingResource.Delete("IBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
                Assert.Fail("Expected TwilioException to be thrown for 500");
            }
            catch (ApiException) {}
            twilioRestClient.Received().Request(request);
        }

        [Test]
        public void TestDeleteResponse()
        {
            var twilioRestClient = Substitute.For<ITwilioRestClient>();
            twilioRestClient.AccountSid.Returns("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            twilioRestClient.Request(Arg.Any<Request>())
                            .Returns(new Response(
                                         System.Net.HttpStatusCode.NoContent,
                                         "null"
                                     ));

            var response = SourceIpMappingResource.Delete("IBXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", client: twilioRestClient);
            Assert.NotNull(response);
        }
    }

}