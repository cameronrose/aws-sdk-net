/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ElasticBeanstalk.Model;
using Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations;
using Amazon.ElasticBeanstalk.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticBeanstalk
{
    /// <summary>
    /// Implementation for accessing ElasticBeanstalk
    ///
    /// AWS Elastic Beanstalk 
    /// <para>
    /// AWS Elastic Beanstalk makes it easy for you to create, deploy, and manage scalable,
    /// fault-tolerant applications running on the Amazon Web Services cloud.
    /// </para>
    ///  
    /// <para>
    /// For more information about this product, go to the <a href="http://aws.amazon.com/elasticbeanstalk/">AWS
    /// Elastic Beanstalk</a> details page. The location of the latest AWS Elastic Beanstalk
    /// WSDL is <a href="http://elasticbeanstalk.s3.amazonaws.com/doc/2010-12-01/AWSElasticBeanstalk.wsdl">http://elasticbeanstalk.s3.amazonaws.com/doc/2010-12-01/AWSElasticBeanstalk.wsdl</a>.
    /// To install the Software Development Kits (SDKs), Integrated Development Environment
    /// (IDE) Toolkits, and command line tools that enable you to access the API, go to <a
    /// href="http://aws.amazon.com/tools/">Tools for Amazon Web Services</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Endpoints</b> 
    /// </para>
    ///  
    /// <para>
    /// For a list of region-specific endpoints that AWS Elastic Beanstalk supports, go to
    /// <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#elasticbeanstalk_region">Regions
    /// and Endpoints</a> in the <i>Amazon Web Services Glossary</i>.
    /// </para>
    /// </summary>
    public partial class AmazonElasticBeanstalkClient : AmazonServiceClient, IAmazonElasticBeanstalk
    {
        private static IServiceMetadata serviceMetadata = new AmazonElasticBeanstalkMetadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonElasticBeanstalkClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticBeanstalkConfig()) { }

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticBeanstalkClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticBeanstalkConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonElasticBeanstalkClient Configuration Object</param>
        public AmazonElasticBeanstalkClient(AmazonElasticBeanstalkConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonElasticBeanstalkClient(AWSCredentials credentials)
            : this(credentials, new AmazonElasticBeanstalkConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticBeanstalkClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonElasticBeanstalkConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with AWS Credentials and an
        /// AmazonElasticBeanstalkClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonElasticBeanstalkClient Configuration Object</param>
        public AmazonElasticBeanstalkClient(AWSCredentials credentials, AmazonElasticBeanstalkConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonElasticBeanstalkClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticBeanstalkConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticBeanstalkClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticBeanstalkConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticBeanstalkClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonElasticBeanstalkClient Configuration Object</param>
        public AmazonElasticBeanstalkClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonElasticBeanstalkConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonElasticBeanstalkClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticBeanstalkConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticBeanstalkClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticBeanstalkConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticBeanstalkClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticBeanstalkClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonElasticBeanstalkClient Configuration Object</param>
        public AmazonElasticBeanstalkClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonElasticBeanstalkConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  AbortEnvironmentUpdate

        internal virtual AbortEnvironmentUpdateResponse AbortEnvironmentUpdate(AbortEnvironmentUpdateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AbortEnvironmentUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AbortEnvironmentUpdateResponseUnmarshaller.Instance;

            return Invoke<AbortEnvironmentUpdateResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AbortEnvironmentUpdate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AbortEnvironmentUpdate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/AbortEnvironmentUpdate">REST API Reference for AbortEnvironmentUpdate Operation</seealso>
        public virtual Task<AbortEnvironmentUpdateResponse> AbortEnvironmentUpdateAsync(AbortEnvironmentUpdateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AbortEnvironmentUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AbortEnvironmentUpdateResponseUnmarshaller.Instance;

            return InvokeAsync<AbortEnvironmentUpdateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ApplyEnvironmentManagedAction

        internal virtual ApplyEnvironmentManagedActionResponse ApplyEnvironmentManagedAction(ApplyEnvironmentManagedActionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ApplyEnvironmentManagedActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplyEnvironmentManagedActionResponseUnmarshaller.Instance;

            return Invoke<ApplyEnvironmentManagedActionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ApplyEnvironmentManagedAction operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ApplyEnvironmentManagedAction operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ApplyEnvironmentManagedAction">REST API Reference for ApplyEnvironmentManagedAction Operation</seealso>
        public virtual Task<ApplyEnvironmentManagedActionResponse> ApplyEnvironmentManagedActionAsync(ApplyEnvironmentManagedActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ApplyEnvironmentManagedActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplyEnvironmentManagedActionResponseUnmarshaller.Instance;

            return InvokeAsync<ApplyEnvironmentManagedActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CheckDNSAvailability

        internal virtual CheckDNSAvailabilityResponse CheckDNSAvailability(CheckDNSAvailabilityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CheckDNSAvailabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckDNSAvailabilityResponseUnmarshaller.Instance;

            return Invoke<CheckDNSAvailabilityResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CheckDNSAvailability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CheckDNSAvailability operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CheckDNSAvailability">REST API Reference for CheckDNSAvailability Operation</seealso>
        public virtual Task<CheckDNSAvailabilityResponse> CheckDNSAvailabilityAsync(CheckDNSAvailabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CheckDNSAvailabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CheckDNSAvailabilityResponseUnmarshaller.Instance;

            return InvokeAsync<CheckDNSAvailabilityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ComposeEnvironments

        internal virtual ComposeEnvironmentsResponse ComposeEnvironments(ComposeEnvironmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ComposeEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ComposeEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<ComposeEnvironmentsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ComposeEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ComposeEnvironments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ComposeEnvironments">REST API Reference for ComposeEnvironments Operation</seealso>
        public virtual Task<ComposeEnvironmentsResponse> ComposeEnvironmentsAsync(ComposeEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ComposeEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ComposeEnvironmentsResponseUnmarshaller.Instance;

            return InvokeAsync<ComposeEnvironmentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateApplication

        internal virtual CreateApplicationResponse CreateApplication(CreateApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateApplication">REST API Reference for CreateApplication Operation</seealso>
        public virtual Task<CreateApplicationResponse> CreateApplicationAsync(CreateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateApplicationVersion

        internal virtual CreateApplicationVersionResponse CreateApplicationVersion(CreateApplicationVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationVersionResponseUnmarshaller.Instance;

            return Invoke<CreateApplicationVersionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateApplicationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApplicationVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateApplicationVersion">REST API Reference for CreateApplicationVersion Operation</seealso>
        public virtual Task<CreateApplicationVersionResponse> CreateApplicationVersionAsync(CreateApplicationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateApplicationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApplicationVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApplicationVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateConfigurationTemplate

        internal virtual CreateConfigurationTemplateResponse CreateConfigurationTemplate(CreateConfigurationTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationTemplateResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateConfigurationTemplate">REST API Reference for CreateConfigurationTemplate Operation</seealso>
        public virtual Task<CreateConfigurationTemplateResponse> CreateConfigurationTemplateAsync(CreateConfigurationTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConfigurationTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEnvironment

        internal virtual CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        public virtual Task<CreateEnvironmentResponse> CreateEnvironmentAsync(CreateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePlatformVersion

        internal virtual CreatePlatformVersionResponse CreatePlatformVersion(CreatePlatformVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePlatformVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlatformVersionResponseUnmarshaller.Instance;

            return Invoke<CreatePlatformVersionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlatformVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlatformVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreatePlatformVersion">REST API Reference for CreatePlatformVersion Operation</seealso>
        public virtual Task<CreatePlatformVersionResponse> CreatePlatformVersionAsync(CreatePlatformVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePlatformVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlatformVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePlatformVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateStorageLocation

        internal virtual CreateStorageLocationResponse CreateStorageLocation()
        {
            return CreateStorageLocation(new CreateStorageLocationRequest());
        }
        internal virtual CreateStorageLocationResponse CreateStorageLocation(CreateStorageLocationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStorageLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStorageLocationResponseUnmarshaller.Instance;

            return Invoke<CreateStorageLocationResponse>(request, options);
        }


        /// <summary>
        /// Creates a bucket in Amazon S3 to store application versions, logs, and other files
        /// used by Elastic Beanstalk environments. The Elastic Beanstalk console and EB CLI call
        /// this API the first time you create an environment in a region. If the storage location
        /// already exists, <code>CreateStorageLocation</code> still returns the bucket name but
        /// does not create a new bucket.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateStorageLocation service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.InsufficientPrivilegesException">
        /// The specified account does not have sufficient privileges for one or more AWS services.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.S3SubscriptionRequiredException">
        /// The specified account does not have a subscription to Amazon S3.
        /// </exception>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateStorageLocation">REST API Reference for CreateStorageLocation Operation</seealso>
        public virtual Task<CreateStorageLocationResponse> CreateStorageLocationAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return CreateStorageLocationAsync(new CreateStorageLocationRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateStorageLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStorageLocation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/CreateStorageLocation">REST API Reference for CreateStorageLocation Operation</seealso>
        public virtual Task<CreateStorageLocationResponse> CreateStorageLocationAsync(CreateStorageLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateStorageLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateStorageLocationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateStorageLocationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApplication

        internal virtual DeleteApplicationResponse DeleteApplication(DeleteApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DeleteApplication">REST API Reference for DeleteApplication Operation</seealso>
        public virtual Task<DeleteApplicationResponse> DeleteApplicationAsync(DeleteApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteApplicationVersion

        internal virtual DeleteApplicationVersionResponse DeleteApplicationVersion(DeleteApplicationVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteApplicationVersionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteApplicationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteApplicationVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DeleteApplicationVersion">REST API Reference for DeleteApplicationVersion Operation</seealso>
        public virtual Task<DeleteApplicationVersionResponse> DeleteApplicationVersionAsync(DeleteApplicationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteApplicationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteApplicationVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteApplicationVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConfigurationTemplate

        internal virtual DeleteConfigurationTemplateResponse DeleteConfigurationTemplate(DeleteConfigurationTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationTemplateResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DeleteConfigurationTemplate">REST API Reference for DeleteConfigurationTemplate Operation</seealso>
        public virtual Task<DeleteConfigurationTemplateResponse> DeleteConfigurationTemplateAsync(DeleteConfigurationTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConfigurationTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEnvironmentConfiguration

        internal virtual DeleteEnvironmentConfigurationResponse DeleteEnvironmentConfiguration(DeleteEnvironmentConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEnvironmentConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DeleteEnvironmentConfiguration">REST API Reference for DeleteEnvironmentConfiguration Operation</seealso>
        public virtual Task<DeleteEnvironmentConfigurationResponse> DeleteEnvironmentConfigurationAsync(DeleteEnvironmentConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEnvironmentConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePlatformVersion

        internal virtual DeletePlatformVersionResponse DeletePlatformVersion(DeletePlatformVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePlatformVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlatformVersionResponseUnmarshaller.Instance;

            return Invoke<DeletePlatformVersionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePlatformVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePlatformVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DeletePlatformVersion">REST API Reference for DeletePlatformVersion Operation</seealso>
        public virtual Task<DeletePlatformVersionResponse> DeletePlatformVersionAsync(DeletePlatformVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePlatformVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlatformVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePlatformVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccountAttributes

        internal virtual DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountAttributesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeApplications

        internal virtual DescribeApplicationsResponse DescribeApplications()
        {
            return DescribeApplications(new DescribeApplicationsRequest());
        }
        internal virtual DescribeApplicationsResponse DescribeApplications(DescribeApplicationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationsResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationsResponse>(request, options);
        }


        /// <summary>
        /// Returns the descriptions of existing applications.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApplications service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeApplications">REST API Reference for DescribeApplications Operation</seealso>
        public virtual Task<DescribeApplicationsResponse> DescribeApplicationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeApplicationsAsync(new DescribeApplicationsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeApplications">REST API Reference for DescribeApplications Operation</seealso>
        public virtual Task<DescribeApplicationsResponse> DescribeApplicationsAsync(DescribeApplicationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeApplicationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeApplicationVersions

        internal virtual DescribeApplicationVersionsResponse DescribeApplicationVersions()
        {
            return DescribeApplicationVersions(new DescribeApplicationVersionsRequest());
        }
        internal virtual DescribeApplicationVersionsResponse DescribeApplicationVersions(DescribeApplicationVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeApplicationVersionsResponse>(request, options);
        }


        /// <summary>
        /// Retrieve a list of application versions.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeApplicationVersions service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeApplicationVersions">REST API Reference for DescribeApplicationVersions Operation</seealso>
        public virtual Task<DescribeApplicationVersionsResponse> DescribeApplicationVersionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeApplicationVersionsAsync(new DescribeApplicationVersionsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeApplicationVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeApplicationVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeApplicationVersions">REST API Reference for DescribeApplicationVersions Operation</seealso>
        public virtual Task<DescribeApplicationVersionsResponse> DescribeApplicationVersionsAsync(DescribeApplicationVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeApplicationVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeApplicationVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeApplicationVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConfigurationOptions

        internal virtual DescribeConfigurationOptionsResponse DescribeConfigurationOptions()
        {
            return DescribeConfigurationOptions(new DescribeConfigurationOptionsRequest());
        }
        internal virtual DescribeConfigurationOptionsResponse DescribeConfigurationOptions(DescribeConfigurationOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationOptionsResponse>(request, options);
        }


        /// <summary>
        /// Describes the configuration options that are used in a particular configuration template
        /// or environment, or that a specified solution stack defines. The description includes
        /// the values the options, their default values, and an indication of the required action
        /// on a running environment if an option value is changed.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConfigurationOptions service method, as returned by ElasticBeanstalk.</returns>
        /// <exception cref="Amazon.ElasticBeanstalk.Model.TooManyBucketsException">
        /// The specified account has reached its limit of Amazon S3 buckets.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeConfigurationOptions">REST API Reference for DescribeConfigurationOptions Operation</seealso>
        public virtual Task<DescribeConfigurationOptionsResponse> DescribeConfigurationOptionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeConfigurationOptionsAsync(new DescribeConfigurationOptionsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeConfigurationOptions">REST API Reference for DescribeConfigurationOptions Operation</seealso>
        public virtual Task<DescribeConfigurationOptionsResponse> DescribeConfigurationOptionsAsync(DescribeConfigurationOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConfigurationOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConfigurationSettings

        internal virtual DescribeConfigurationSettingsResponse DescribeConfigurationSettings(DescribeConfigurationSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationSettingsResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationSettingsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConfigurationSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeConfigurationSettings">REST API Reference for DescribeConfigurationSettings Operation</seealso>
        public virtual Task<DescribeConfigurationSettingsResponse> DescribeConfigurationSettingsAsync(DescribeConfigurationSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConfigurationSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEnvironmentHealth

        internal virtual DescribeEnvironmentHealthResponse DescribeEnvironmentHealth(DescribeEnvironmentHealthRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentHealthResponseUnmarshaller.Instance;

            return Invoke<DescribeEnvironmentHealthResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironmentHealth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentHealth operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironmentHealth">REST API Reference for DescribeEnvironmentHealth Operation</seealso>
        public virtual Task<DescribeEnvironmentHealthResponse> DescribeEnvironmentHealthAsync(DescribeEnvironmentHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentHealthResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEnvironmentHealthResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEnvironmentManagedActionHistory

        internal virtual DescribeEnvironmentManagedActionHistoryResponse DescribeEnvironmentManagedActionHistory(DescribeEnvironmentManagedActionHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentManagedActionHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentManagedActionHistoryResponseUnmarshaller.Instance;

            return Invoke<DescribeEnvironmentManagedActionHistoryResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironmentManagedActionHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentManagedActionHistory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironmentManagedActionHistory">REST API Reference for DescribeEnvironmentManagedActionHistory Operation</seealso>
        public virtual Task<DescribeEnvironmentManagedActionHistoryResponse> DescribeEnvironmentManagedActionHistoryAsync(DescribeEnvironmentManagedActionHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentManagedActionHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentManagedActionHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEnvironmentManagedActionHistoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEnvironmentManagedActions

        internal virtual DescribeEnvironmentManagedActionsResponse DescribeEnvironmentManagedActions(DescribeEnvironmentManagedActionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentManagedActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentManagedActionsResponseUnmarshaller.Instance;

            return Invoke<DescribeEnvironmentManagedActionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironmentManagedActions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentManagedActions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironmentManagedActions">REST API Reference for DescribeEnvironmentManagedActions Operation</seealso>
        public virtual Task<DescribeEnvironmentManagedActionsResponse> DescribeEnvironmentManagedActionsAsync(DescribeEnvironmentManagedActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentManagedActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentManagedActionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEnvironmentManagedActionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEnvironmentResources

        internal virtual DescribeEnvironmentResourcesResponse DescribeEnvironmentResources(DescribeEnvironmentResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentResourcesResponseUnmarshaller.Instance;

            return Invoke<DescribeEnvironmentResourcesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironmentResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironmentResources operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironmentResources">REST API Reference for DescribeEnvironmentResources Operation</seealso>
        public virtual Task<DescribeEnvironmentResourcesResponse> DescribeEnvironmentResourcesAsync(DescribeEnvironmentResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEnvironmentResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEnvironments

        internal virtual DescribeEnvironmentsResponse DescribeEnvironments()
        {
            return DescribeEnvironments(new DescribeEnvironmentsRequest());
        }
        internal virtual DescribeEnvironmentsResponse DescribeEnvironments(DescribeEnvironmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<DescribeEnvironmentsResponse>(request, options);
        }


        /// <summary>
        /// Returns descriptions for existing environments.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEnvironments service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironments">REST API Reference for DescribeEnvironments Operation</seealso>
        public virtual Task<DescribeEnvironmentsResponse> DescribeEnvironmentsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeEnvironmentsAsync(new DescribeEnvironmentsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEnvironments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEnvironments">REST API Reference for DescribeEnvironments Operation</seealso>
        public virtual Task<DescribeEnvironmentsResponse> DescribeEnvironmentsAsync(DescribeEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEnvironmentsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEnvironmentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEvents

        internal virtual DescribeEventsResponse DescribeEvents()
        {
            return DescribeEvents(new DescribeEventsRequest());
        }
        internal virtual DescribeEventsResponse DescribeEvents(DescribeEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return Invoke<DescribeEventsResponse>(request, options);
        }


        /// <summary>
        /// Returns list of event descriptions matching criteria up to the last 6 weeks.
        /// 
        ///  <note> 
        /// <para>
        /// This action returns the most recent 1,000 events from the specified <code>NextToken</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual Task<DescribeEventsResponse> DescribeEventsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeEventsAsync(new DescribeEventsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        public virtual Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEventsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstancesHealth

        internal virtual DescribeInstancesHealthResponse DescribeInstancesHealth(DescribeInstancesHealthRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstancesHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstancesHealthResponseUnmarshaller.Instance;

            return Invoke<DescribeInstancesHealthResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstancesHealth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstancesHealth operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribeInstancesHealth">REST API Reference for DescribeInstancesHealth Operation</seealso>
        public virtual Task<DescribeInstancesHealthResponse> DescribeInstancesHealthAsync(DescribeInstancesHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstancesHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstancesHealthResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstancesHealthResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePlatformVersion

        internal virtual DescribePlatformVersionResponse DescribePlatformVersion(DescribePlatformVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePlatformVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePlatformVersionResponseUnmarshaller.Instance;

            return Invoke<DescribePlatformVersionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePlatformVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePlatformVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/DescribePlatformVersion">REST API Reference for DescribePlatformVersion Operation</seealso>
        public virtual Task<DescribePlatformVersionResponse> DescribePlatformVersionAsync(DescribePlatformVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePlatformVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePlatformVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePlatformVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAvailableSolutionStacks

        internal virtual ListAvailableSolutionStacksResponse ListAvailableSolutionStacks()
        {
            return ListAvailableSolutionStacks(new ListAvailableSolutionStacksRequest());
        }
        internal virtual ListAvailableSolutionStacksResponse ListAvailableSolutionStacks(ListAvailableSolutionStacksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAvailableSolutionStacksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAvailableSolutionStacksResponseUnmarshaller.Instance;

            return Invoke<ListAvailableSolutionStacksResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of the available solution stack names, with the public version first
        /// and then in reverse chronological order.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAvailableSolutionStacks service method, as returned by ElasticBeanstalk.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ListAvailableSolutionStacks">REST API Reference for ListAvailableSolutionStacks Operation</seealso>
        public virtual Task<ListAvailableSolutionStacksResponse> ListAvailableSolutionStacksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListAvailableSolutionStacksAsync(new ListAvailableSolutionStacksRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListAvailableSolutionStacks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableSolutionStacks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ListAvailableSolutionStacks">REST API Reference for ListAvailableSolutionStacks Operation</seealso>
        public virtual Task<ListAvailableSolutionStacksResponse> ListAvailableSolutionStacksAsync(ListAvailableSolutionStacksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAvailableSolutionStacksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAvailableSolutionStacksResponseUnmarshaller.Instance;

            return InvokeAsync<ListAvailableSolutionStacksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPlatformVersions

        internal virtual ListPlatformVersionsResponse ListPlatformVersions(ListPlatformVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPlatformVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlatformVersionsResponseUnmarshaller.Instance;

            return Invoke<ListPlatformVersionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListPlatformVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPlatformVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ListPlatformVersions">REST API Reference for ListPlatformVersions Operation</seealso>
        public virtual Task<ListPlatformVersionsResponse> ListPlatformVersionsAsync(ListPlatformVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPlatformVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPlatformVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPlatformVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RebuildEnvironment

        internal virtual RebuildEnvironmentResponse RebuildEnvironment(RebuildEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebuildEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebuildEnvironmentResponseUnmarshaller.Instance;

            return Invoke<RebuildEnvironmentResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RebuildEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebuildEnvironment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/RebuildEnvironment">REST API Reference for RebuildEnvironment Operation</seealso>
        public virtual Task<RebuildEnvironmentResponse> RebuildEnvironmentAsync(RebuildEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebuildEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebuildEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<RebuildEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RequestEnvironmentInfo

        internal virtual RequestEnvironmentInfoResponse RequestEnvironmentInfo(RequestEnvironmentInfoRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RequestEnvironmentInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestEnvironmentInfoResponseUnmarshaller.Instance;

            return Invoke<RequestEnvironmentInfoResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RequestEnvironmentInfo operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestEnvironmentInfo operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/RequestEnvironmentInfo">REST API Reference for RequestEnvironmentInfo Operation</seealso>
        public virtual Task<RequestEnvironmentInfoResponse> RequestEnvironmentInfoAsync(RequestEnvironmentInfoRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RequestEnvironmentInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestEnvironmentInfoResponseUnmarshaller.Instance;

            return InvokeAsync<RequestEnvironmentInfoResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestartAppServer

        internal virtual RestartAppServerResponse RestartAppServer(RestartAppServerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestartAppServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestartAppServerResponseUnmarshaller.Instance;

            return Invoke<RestartAppServerResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RestartAppServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestartAppServer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/RestartAppServer">REST API Reference for RestartAppServer Operation</seealso>
        public virtual Task<RestartAppServerResponse> RestartAppServerAsync(RestartAppServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestartAppServerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestartAppServerResponseUnmarshaller.Instance;

            return InvokeAsync<RestartAppServerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RetrieveEnvironmentInfo

        internal virtual RetrieveEnvironmentInfoResponse RetrieveEnvironmentInfo(RetrieveEnvironmentInfoRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetrieveEnvironmentInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetrieveEnvironmentInfoResponseUnmarshaller.Instance;

            return Invoke<RetrieveEnvironmentInfoResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RetrieveEnvironmentInfo operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RetrieveEnvironmentInfo operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/RetrieveEnvironmentInfo">REST API Reference for RetrieveEnvironmentInfo Operation</seealso>
        public virtual Task<RetrieveEnvironmentInfoResponse> RetrieveEnvironmentInfoAsync(RetrieveEnvironmentInfoRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RetrieveEnvironmentInfoRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RetrieveEnvironmentInfoResponseUnmarshaller.Instance;

            return InvokeAsync<RetrieveEnvironmentInfoResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SwapEnvironmentCNAMEs

        internal virtual SwapEnvironmentCNAMEsResponse SwapEnvironmentCNAMEs(SwapEnvironmentCNAMEsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SwapEnvironmentCNAMEsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SwapEnvironmentCNAMEsResponseUnmarshaller.Instance;

            return Invoke<SwapEnvironmentCNAMEsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SwapEnvironmentCNAMEs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SwapEnvironmentCNAMEs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/SwapEnvironmentCNAMEs">REST API Reference for SwapEnvironmentCNAMEs Operation</seealso>
        public virtual Task<SwapEnvironmentCNAMEsResponse> SwapEnvironmentCNAMEsAsync(SwapEnvironmentCNAMEsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SwapEnvironmentCNAMEsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SwapEnvironmentCNAMEsResponseUnmarshaller.Instance;

            return InvokeAsync<SwapEnvironmentCNAMEsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TerminateEnvironment

        internal virtual TerminateEnvironmentResponse TerminateEnvironment(TerminateEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<TerminateEnvironmentResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the TerminateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateEnvironment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/TerminateEnvironment">REST API Reference for TerminateEnvironment Operation</seealso>
        public virtual Task<TerminateEnvironmentResponse> TerminateEnvironmentAsync(TerminateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<TerminateEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateApplication

        internal virtual UpdateApplicationResponse UpdateApplication(UpdateApplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateApplication">REST API Reference for UpdateApplication Operation</seealso>
        public virtual Task<UpdateApplicationResponse> UpdateApplicationAsync(UpdateApplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateApplicationResourceLifecycle

        internal virtual UpdateApplicationResourceLifecycleResponse UpdateApplicationResourceLifecycle(UpdateApplicationResourceLifecycleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationResourceLifecycleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResourceLifecycleResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationResourceLifecycleResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplicationResourceLifecycle operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationResourceLifecycle operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateApplicationResourceLifecycle">REST API Reference for UpdateApplicationResourceLifecycle Operation</seealso>
        public virtual Task<UpdateApplicationResourceLifecycleResponse> UpdateApplicationResourceLifecycleAsync(UpdateApplicationResourceLifecycleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationResourceLifecycleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationResourceLifecycleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApplicationResourceLifecycleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateApplicationVersion

        internal virtual UpdateApplicationVersionResponse UpdateApplicationVersion(UpdateApplicationVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateApplicationVersionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApplicationVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApplicationVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateApplicationVersion">REST API Reference for UpdateApplicationVersion Operation</seealso>
        public virtual Task<UpdateApplicationVersionResponse> UpdateApplicationVersionAsync(UpdateApplicationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateApplicationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApplicationVersionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApplicationVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateConfigurationTemplate

        internal virtual UpdateConfigurationTemplateResponse UpdateConfigurationTemplate(UpdateConfigurationTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateConfigurationTemplateResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConfigurationTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConfigurationTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateConfigurationTemplate">REST API Reference for UpdateConfigurationTemplate Operation</seealso>
        public virtual Task<UpdateConfigurationTemplateResponse> UpdateConfigurationTemplateAsync(UpdateConfigurationTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConfigurationTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConfigurationTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConfigurationTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEnvironment

        internal virtual UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        public virtual Task<UpdateEnvironmentResponse> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTagsForResource

        internal virtual UpdateTagsForResourceResponse UpdateTagsForResource(UpdateTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<UpdateTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTagsForResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/UpdateTagsForResource">REST API Reference for UpdateTagsForResource Operation</seealso>
        public virtual Task<UpdateTagsForResourceResponse> UpdateTagsForResourceAsync(UpdateTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ValidateConfigurationSettings

        internal virtual ValidateConfigurationSettingsResponse ValidateConfigurationSettings(ValidateConfigurationSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateConfigurationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateConfigurationSettingsResponseUnmarshaller.Instance;

            return Invoke<ValidateConfigurationSettingsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ValidateConfigurationSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ValidateConfigurationSettings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticbeanstalk-2010-12-01/ValidateConfigurationSettings">REST API Reference for ValidateConfigurationSettings Operation</seealso>
        public virtual Task<ValidateConfigurationSettingsResponse> ValidateConfigurationSettingsAsync(ValidateConfigurationSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ValidateConfigurationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateConfigurationSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<ValidateConfigurationSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}