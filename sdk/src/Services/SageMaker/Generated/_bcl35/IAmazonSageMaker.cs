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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SageMaker.Model;

namespace Amazon.SageMaker
{
    /// <summary>
    /// Interface for accessing SageMaker
    ///
    /// Definition of the public APIs exposed by SageMaker
    /// </summary>
    public partial interface IAmazonSageMaker : IAmazonService, IDisposable
    {

        
        #region  AddTags


        /// <summary>
        /// Adds or overwrites one or more tags for the specified Amazon SageMaker resource. You
        /// can add tags to notebook instances, training jobs, hyperparameter tuning jobs, models,
        /// endpoint configurations, and endpoints.
        /// 
        ///  
        /// <para>
        /// Each tag consists of a key and an optional value. Tag keys must be unique per resource.
        /// For more information about tags, see For more information, see <a href="https://aws.amazon.com/answers/account-management/aws-tagging-strategies/">AWS
        /// Tagging Strategies</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Tags that you add to a hyperparameter tuning job by calling this API are also added
        /// to any training jobs that the hyperparameter tuning job launches after you call this
        /// API, but not to training jobs that the hyperparameter tuning job launched before you
        /// called this API. To make sure that the tags associated with a hyperparameter tuning
        /// job are also added to all training jobs that the hyperparameter tuning job launches,
        /// add the tags when you first create the tuning job by specifying them in the <code>Tags</code>
        /// parameter of <a>CreateHyperParameterTuningJob</a> 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/AddTags">REST API Reference for AddTags Operation</seealso>
        AddTagsResponse AddTags(AddTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AddTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTags operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAddTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/AddTags">REST API Reference for AddTags Operation</seealso>
        IAsyncResult BeginAddTags(AddTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AddTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddTags.</param>
        /// 
        /// <returns>Returns a  AddTagsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/AddTags">REST API Reference for AddTags Operation</seealso>
        AddTagsResponse EndAddTags(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateAlgorithm


        /// <summary>
        /// Create a machine learning algorithm that you can use in Amazon SageMaker and list
        /// in the AWS Marketplace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAlgorithm service method.</param>
        /// 
        /// <returns>The response from the CreateAlgorithm service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateAlgorithm">REST API Reference for CreateAlgorithm Operation</seealso>
        CreateAlgorithmResponse CreateAlgorithm(CreateAlgorithmRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAlgorithm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAlgorithm operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAlgorithm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateAlgorithm">REST API Reference for CreateAlgorithm Operation</seealso>
        IAsyncResult BeginCreateAlgorithm(CreateAlgorithmRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAlgorithm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAlgorithm.</param>
        /// 
        /// <returns>Returns a  CreateAlgorithmResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateAlgorithm">REST API Reference for CreateAlgorithm Operation</seealso>
        CreateAlgorithmResponse EndCreateAlgorithm(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCodeRepository


        /// <summary>
        /// Creates a Git repository as a resource in your Amazon SageMaker account. You can associate
        /// the repository with notebook instances so that you can use Git source control for
        /// the notebooks you create. The Git repository is a resource in your Amazon SageMaker
        /// account, so it can be associated with more than one notebook instance, and it persists
        /// independently from the lifecycle of any notebook instances it is associated with.
        /// 
        ///  
        /// <para>
        /// The repository can be hosted either in <a href="http://docs.aws.amazon.com/codecommit/latest/userguide/welcome.html">AWS
        /// CodeCommit</a> or in any other Git repository.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeRepository service method.</param>
        /// 
        /// <returns>The response from the CreateCodeRepository service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateCodeRepository">REST API Reference for CreateCodeRepository Operation</seealso>
        CreateCodeRepositoryResponse CreateCodeRepository(CreateCodeRepositoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCodeRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCodeRepository operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCodeRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateCodeRepository">REST API Reference for CreateCodeRepository Operation</seealso>
        IAsyncResult BeginCreateCodeRepository(CreateCodeRepositoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCodeRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCodeRepository.</param>
        /// 
        /// <returns>Returns a  CreateCodeRepositoryResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateCodeRepository">REST API Reference for CreateCodeRepository Operation</seealso>
        CreateCodeRepositoryResponse EndCreateCodeRepository(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCompilationJob


        /// <summary>
        /// Starts a model compilation job. After the model has been compiled, Amazon SageMaker
        /// saves the resulting model artifacts to an Amazon Simple Storage Service (Amazon S3)
        /// bucket that you specify. 
        /// 
        ///  
        /// <para>
        /// If you choose to host your model using Amazon SageMaker hosting services, you can
        /// use the resulting model artifacts as part of the model. You can also use the artifacts
        /// with AWS IoT Greengrass. In that case, deploy them as an ML resource.
        /// </para>
        ///  
        /// <para>
        /// In the request body, you provide the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A name for the compilation job
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Information about the input model artifacts 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The output location for the compiled model and the device (target) that the model
        /// runs on 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>The Amazon Resource Name (ARN) of the IAM role that Amazon SageMaker assumes
        /// to perform the model compilation job</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can also provide a <code>Tag</code> to track the model compilation job's resource
        /// use and costs. The response body contains the <code>CompilationJobArn</code> for the
        /// compiled job.
        /// </para>
        ///  
        /// <para>
        /// To stop a model compilation job, use <a>StopCompilationJob</a>. To get information
        /// about a particular model compilation job, use <a>DescribeCompilationJob</a>. To get
        /// information about multiple model compilation jobs, use <a>ListCompilationJobs</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCompilationJob service method.</param>
        /// 
        /// <returns>The response from the CreateCompilationJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateCompilationJob">REST API Reference for CreateCompilationJob Operation</seealso>
        CreateCompilationJobResponse CreateCompilationJob(CreateCompilationJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCompilationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCompilationJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCompilationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateCompilationJob">REST API Reference for CreateCompilationJob Operation</seealso>
        IAsyncResult BeginCreateCompilationJob(CreateCompilationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCompilationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCompilationJob.</param>
        /// 
        /// <returns>Returns a  CreateCompilationJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateCompilationJob">REST API Reference for CreateCompilationJob Operation</seealso>
        CreateCompilationJobResponse EndCreateCompilationJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateEndpoint


        /// <summary>
        /// Creates an endpoint using the endpoint configuration specified in the request. Amazon
        /// SageMaker uses the endpoint to provision resources and deploy models. You create the
        /// endpoint configuration with the <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/API_CreateEndpointConfig.html">CreateEndpointConfig</a>
        /// API. 
        /// 
        ///  <note> 
        /// <para>
        ///  Use this API only for hosting models using Amazon SageMaker hosting services. 
        /// </para>
        ///  </note> 
        /// <para>
        /// The endpoint name must be unique within an AWS Region in your AWS account. 
        /// </para>
        ///  
        /// <para>
        /// When it receives the request, Amazon SageMaker creates the endpoint, launches the
        /// resources (ML compute instances), and deploys the model(s) on them. 
        /// </para>
        ///  
        /// <para>
        /// When Amazon SageMaker receives the request, it sets the endpoint status to <code>Creating</code>.
        /// After it creates the endpoint, it sets the status to <code>InService</code>. Amazon
        /// SageMaker can then process incoming requests for inferences. To check the status of
        /// an endpoint, use the <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/API_DescribeEndpoint.html">DescribeEndpoint</a>
        /// API.
        /// </para>
        ///  
        /// <para>
        /// For an example, see <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/ex1.html">Exercise
        /// 1: Using the K-Means Algorithm Provided by Amazon SageMaker</a>. 
        /// </para>
        ///  
        /// <para>
        /// If any of the models hosted at this endpoint get model data from an Amazon S3 location,
        /// Amazon SageMaker uses AWS Security Token Service to download model artifacts from
        /// the S3 path you provided. AWS STS is activated in your IAM user account by default.
        /// If you previously deactivated AWS STS for a region, you need to reactivate AWS STS
        /// for that region. For more information, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_enable-regions.html">Activating
        /// and Deactivating AWS STS i an AWS Region</a> in the <i>AWS Identity and Access Management
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateEndpoint service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        CreateEndpointResponse CreateEndpoint(CreateEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpoint operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        IAsyncResult BeginCreateEndpoint(CreateEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEndpoint.</param>
        /// 
        /// <returns>Returns a  CreateEndpointResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEndpoint">REST API Reference for CreateEndpoint Operation</seealso>
        CreateEndpointResponse EndCreateEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateEndpointConfig


        /// <summary>
        /// Creates an endpoint configuration that Amazon SageMaker hosting services uses to deploy
        /// models. In the configuration, you identify one or more models, created using the <code>CreateModel</code>
        /// API, to deploy and the resources that you want Amazon SageMaker to provision. Then
        /// you call the <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/API_CreateEndpoint.html">CreateEndpoint</a>
        /// API.
        /// 
        ///  <note> 
        /// <para>
        ///  Use this API only if you want to use Amazon SageMaker hosting services to deploy
        /// models into production. 
        /// </para>
        ///  </note> 
        /// <para>
        /// In the request, you define one or more <code>ProductionVariant</code>s, each of which
        /// identifies a model. Each <code>ProductionVariant</code> parameter also describes the
        /// resources that you want Amazon SageMaker to provision. This includes the number and
        /// type of ML compute instances to deploy. 
        /// </para>
        ///  
        /// <para>
        /// If you are hosting multiple models, you also assign a <code>VariantWeight</code> to
        /// specify how much traffic you want to allocate to each model. For example, suppose
        /// that you want to host two models, A and B, and you assign traffic weight 2 for model
        /// A and 1 for model B. Amazon SageMaker distributes two-thirds of the traffic to Model
        /// A, and one-third to model B. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpointConfig service method.</param>
        /// 
        /// <returns>The response from the CreateEndpointConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEndpointConfig">REST API Reference for CreateEndpointConfig Operation</seealso>
        CreateEndpointConfigResponse CreateEndpointConfig(CreateEndpointConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEndpointConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEndpointConfig operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEndpointConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEndpointConfig">REST API Reference for CreateEndpointConfig Operation</seealso>
        IAsyncResult BeginCreateEndpointConfig(CreateEndpointConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEndpointConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEndpointConfig.</param>
        /// 
        /// <returns>Returns a  CreateEndpointConfigResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateEndpointConfig">REST API Reference for CreateEndpointConfig Operation</seealso>
        CreateEndpointConfigResponse EndCreateEndpointConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateHyperParameterTuningJob


        /// <summary>
        /// Starts a hyperparameter tuning job. A hyperparameter tuning job finds the best version
        /// of a model by running many training jobs on your dataset using the algorithm you choose
        /// and values for hyperparameters within ranges that you specify. It then chooses the
        /// hyperparameter values that result in a model that performs the best, as measured by
        /// an objective metric that you choose.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHyperParameterTuningJob service method.</param>
        /// 
        /// <returns>The response from the CreateHyperParameterTuningJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateHyperParameterTuningJob">REST API Reference for CreateHyperParameterTuningJob Operation</seealso>
        CreateHyperParameterTuningJobResponse CreateHyperParameterTuningJob(CreateHyperParameterTuningJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateHyperParameterTuningJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateHyperParameterTuningJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateHyperParameterTuningJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateHyperParameterTuningJob">REST API Reference for CreateHyperParameterTuningJob Operation</seealso>
        IAsyncResult BeginCreateHyperParameterTuningJob(CreateHyperParameterTuningJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateHyperParameterTuningJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateHyperParameterTuningJob.</param>
        /// 
        /// <returns>Returns a  CreateHyperParameterTuningJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateHyperParameterTuningJob">REST API Reference for CreateHyperParameterTuningJob Operation</seealso>
        CreateHyperParameterTuningJobResponse EndCreateHyperParameterTuningJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLabelingJob


        /// <summary>
        /// Creates a job that uses workers to label the data objects in your input dataset. You
        /// can use the labeled data to train machine learning models.
        /// 
        ///  
        /// <para>
        /// You can select your workforce from one of three providers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A private workforce that you create. It can include employees, contractors, and outside
        /// experts. Use a private workforce when want the data to stay within your organization
        /// or when a specific set of skills is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// One or more vendors that you select from the AWS Marketplace. Vendors provide expertise
        /// in specific areas. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The Amazon Mechanical Turk workforce. This is the largest workforce, but it should
        /// only be used for public data or data that has been stripped of any personally identifiable
        /// information.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can also use <i>automated data labeling</i> to reduce the number of data objects
        /// that need to be labeled by a human. Automated data labeling uses <i>active learning</i>
        /// to determine if a data object can be labeled by machine or if it needs to be sent
        /// to a human worker. For more information, see <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/sms-automated-labeling.html">Using
        /// Automated Data Labeling</a>.
        /// </para>
        ///  
        /// <para>
        /// The data objects to be labeled are contained in an Amazon S3 bucket. You create a
        /// <i>manifest file</i> that describes the location of each object. For more information,
        /// see <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/sms-data.html">Using Input
        /// and Output Data</a>.
        /// </para>
        ///  
        /// <para>
        /// The output can be used as the manifest file for another labeling job or as training
        /// data for your machine learning models.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLabelingJob service method.</param>
        /// 
        /// <returns>The response from the CreateLabelingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateLabelingJob">REST API Reference for CreateLabelingJob Operation</seealso>
        CreateLabelingJobResponse CreateLabelingJob(CreateLabelingJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLabelingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLabelingJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLabelingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateLabelingJob">REST API Reference for CreateLabelingJob Operation</seealso>
        IAsyncResult BeginCreateLabelingJob(CreateLabelingJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLabelingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLabelingJob.</param>
        /// 
        /// <returns>Returns a  CreateLabelingJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateLabelingJob">REST API Reference for CreateLabelingJob Operation</seealso>
        CreateLabelingJobResponse EndCreateLabelingJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateModel


        /// <summary>
        /// Creates a model in Amazon SageMaker. In the request, you name the model and describe
        /// a primary container. For the primary container, you specify the docker image containing
        /// inference code, artifacts (from prior training), and custom environment map that the
        /// inference code uses when you deploy the model for predictions.
        /// 
        ///  
        /// <para>
        /// Use this API to create a model if you want to use Amazon SageMaker hosting services
        /// or run a batch transform job.
        /// </para>
        ///  
        /// <para>
        /// To host your model, you create an endpoint configuration with the <code>CreateEndpointConfig</code>
        /// API, and then create an endpoint with the <code>CreateEndpoint</code> API. Amazon
        /// SageMaker then deploys all of the containers that you defined for the model in the
        /// hosting environment. 
        /// </para>
        ///  
        /// <para>
        /// To run a batch transform using your model, you start a job with the <code>CreateTransformJob</code>
        /// API. Amazon SageMaker uses your model and your dataset to get inferences which are
        /// then saved to a specified S3 location.
        /// </para>
        ///  
        /// <para>
        /// In the <code>CreateModel</code> request, you must define a container with the <code>PrimaryContainer</code>
        /// parameter.
        /// </para>
        ///  
        /// <para>
        /// In the request, you also provide an IAM role that Amazon SageMaker can assume to access
        /// model artifacts and docker image for deployment on ML compute hosting instances or
        /// for batch transform jobs. In addition, you also use the IAM role to manage permissions
        /// the inference code needs. For example, if the inference code access any other AWS
        /// resources, you grant necessary permissions via this role.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModel service method.</param>
        /// 
        /// <returns>The response from the CreateModel service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModel">REST API Reference for CreateModel Operation</seealso>
        CreateModelResponse CreateModel(CreateModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModel operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModel">REST API Reference for CreateModel Operation</seealso>
        IAsyncResult BeginCreateModel(CreateModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModel.</param>
        /// 
        /// <returns>Returns a  CreateModelResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModel">REST API Reference for CreateModel Operation</seealso>
        CreateModelResponse EndCreateModel(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateModelPackage


        /// <summary>
        /// Creates a model package that you can use to create Amazon SageMaker models or list
        /// on AWS Marketplace. Buyers can subscribe to model packages listed on AWS Marketplace
        /// to create models in Amazon SageMaker.
        /// 
        ///  
        /// <para>
        /// To create a model package by specifying a Docker container that contains your inference
        /// code and the Amazon S3 location of your model artifacts, provide values for <code>InferenceSpecification</code>.
        /// To create a model from an algorithm resource that you created or subscribed to in
        /// AWS Marketplace, provide a value for <code>SourceAlgorithmSpecification</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateModelPackage service method.</param>
        /// 
        /// <returns>The response from the CreateModelPackage service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelPackage">REST API Reference for CreateModelPackage Operation</seealso>
        CreateModelPackageResponse CreateModelPackage(CreateModelPackageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateModelPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateModelPackage operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateModelPackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelPackage">REST API Reference for CreateModelPackage Operation</seealso>
        IAsyncResult BeginCreateModelPackage(CreateModelPackageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateModelPackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateModelPackage.</param>
        /// 
        /// <returns>Returns a  CreateModelPackageResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateModelPackage">REST API Reference for CreateModelPackage Operation</seealso>
        CreateModelPackageResponse EndCreateModelPackage(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateNotebookInstance


        /// <summary>
        /// Creates an Amazon SageMaker notebook instance. A notebook instance is a machine learning
        /// (ML) compute instance running on a Jupyter notebook. 
        /// 
        ///  
        /// <para>
        /// In a <code>CreateNotebookInstance</code> request, specify the type of ML compute instance
        /// that you want to run. Amazon SageMaker launches the instance, installs common libraries
        /// that you can use to explore datasets for model training, and attaches an ML storage
        /// volume to the notebook instance. 
        /// </para>
        ///  
        /// <para>
        /// Amazon SageMaker also provides a set of example notebooks. Each notebook demonstrates
        /// how to use Amazon SageMaker with a specific algorithm or with a machine learning framework.
        /// 
        /// </para>
        ///  
        /// <para>
        /// After receiving the request, Amazon SageMaker does the following:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Creates a network interface in the Amazon SageMaker VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// (Option) If you specified <code>SubnetId</code>, Amazon SageMaker creates a network
        /// interface in your own VPC, which is inferred from the subnet ID that you provide in
        /// the input. When creating this network interface, Amazon SageMaker attaches the security
        /// group that you specified in the request to the network interface that it creates in
        /// your VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Launches an EC2 instance of the type specified in the request in the Amazon SageMaker
        /// VPC. If you specified <code>SubnetId</code> of your VPC, Amazon SageMaker specifies
        /// both network interfaces when launching this instance. This enables inbound traffic
        /// from your own VPC to the notebook instance, assuming that the security groups allow
        /// it.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// After creating the notebook instance, Amazon SageMaker returns its Amazon Resource
        /// Name (ARN).
        /// </para>
        ///  
        /// <para>
        /// After Amazon SageMaker creates the notebook instance, you can connect to the Jupyter
        /// server and work in Jupyter notebooks. For example, you can write code to explore a
        /// dataset that you can use for model training, train a model, host models by creating
        /// Amazon SageMaker endpoints, and validate hosted models. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/how-it-works.html">How
        /// It Works</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotebookInstance service method.</param>
        /// 
        /// <returns>The response from the CreateNotebookInstance service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateNotebookInstance">REST API Reference for CreateNotebookInstance Operation</seealso>
        CreateNotebookInstanceResponse CreateNotebookInstance(CreateNotebookInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNotebookInstance operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNotebookInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateNotebookInstance">REST API Reference for CreateNotebookInstance Operation</seealso>
        IAsyncResult BeginCreateNotebookInstance(CreateNotebookInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNotebookInstance.</param>
        /// 
        /// <returns>Returns a  CreateNotebookInstanceResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateNotebookInstance">REST API Reference for CreateNotebookInstance Operation</seealso>
        CreateNotebookInstanceResponse EndCreateNotebookInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateNotebookInstanceLifecycleConfig


        /// <summary>
        /// Creates a lifecycle configuration that you can associate with a notebook instance.
        /// A <i>lifecycle configuration</i> is a collection of shell scripts that run when you
        /// create or start a notebook instance.
        /// 
        ///  
        /// <para>
        /// Each lifecycle configuration script has a limit of 16384 characters.
        /// </para>
        ///  
        /// <para>
        /// The value of the <code>$PATH</code> environment variable that is available to both
        /// scripts is <code>/sbin:bin:/usr/sbin:/usr/bin</code>.
        /// </para>
        ///  
        /// <para>
        /// View CloudWatch Logs for notebook instance lifecycle configurations in log group <code>/aws/sagemaker/NotebookInstances</code>
        /// in log stream <code>[notebook-instance-name]/[LifecycleConfigHook]</code>.
        /// </para>
        ///  
        /// <para>
        /// Lifecycle configuration scripts cannot run for longer than 5 minutes. If a script
        /// runs for longer than 5 minutes, it fails and the notebook instance is not created
        /// or started.
        /// </para>
        ///  
        /// <para>
        /// For information about notebook instance lifestyle configurations, see <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/notebook-lifecycle-config.html">Step
        /// 2.1: (Optional) Customize a Notebook Instance</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotebookInstanceLifecycleConfig service method.</param>
        /// 
        /// <returns>The response from the CreateNotebookInstanceLifecycleConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateNotebookInstanceLifecycleConfig">REST API Reference for CreateNotebookInstanceLifecycleConfig Operation</seealso>
        CreateNotebookInstanceLifecycleConfigResponse CreateNotebookInstanceLifecycleConfig(CreateNotebookInstanceLifecycleConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNotebookInstanceLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNotebookInstanceLifecycleConfig operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNotebookInstanceLifecycleConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateNotebookInstanceLifecycleConfig">REST API Reference for CreateNotebookInstanceLifecycleConfig Operation</seealso>
        IAsyncResult BeginCreateNotebookInstanceLifecycleConfig(CreateNotebookInstanceLifecycleConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNotebookInstanceLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNotebookInstanceLifecycleConfig.</param>
        /// 
        /// <returns>Returns a  CreateNotebookInstanceLifecycleConfigResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateNotebookInstanceLifecycleConfig">REST API Reference for CreateNotebookInstanceLifecycleConfig Operation</seealso>
        CreateNotebookInstanceLifecycleConfigResponse EndCreateNotebookInstanceLifecycleConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePresignedNotebookInstanceUrl


        /// <summary>
        /// Returns a URL that you can use to connect to the Jupyter server from a notebook instance.
        /// In the Amazon SageMaker console, when you choose <code>Open</code> next to a notebook
        /// instance, Amazon SageMaker opens a new tab showing the Jupyter server home page from
        /// the notebook instance. The console uses this API to get the URL and show the page.
        /// 
        ///  
        /// <para>
        /// You can restrict access to this API and to the URL that it returns to a list of IP
        /// addresses that you specify. To restrict access, attach an IAM policy that denies access
        /// to this API unless the call comes from an IP address in the specified list to every
        /// AWS Identity and Access Management user, group, or role used to access the notebook
        /// instance. Use the <code>NotIpAddress</code> condition operator and the <code>aws:SourceIP</code>
        /// condition context key to specify the list of IP addresses that you want to have access
        /// to the notebook instance. For more information, see <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/howitworks-access-ws.html#nbi-ip-filter">Limit
        /// Access to a Notebook Instance by IP Address</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePresignedNotebookInstanceUrl service method.</param>
        /// 
        /// <returns>The response from the CreatePresignedNotebookInstanceUrl service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreatePresignedNotebookInstanceUrl">REST API Reference for CreatePresignedNotebookInstanceUrl Operation</seealso>
        CreatePresignedNotebookInstanceUrlResponse CreatePresignedNotebookInstanceUrl(CreatePresignedNotebookInstanceUrlRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePresignedNotebookInstanceUrl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePresignedNotebookInstanceUrl operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePresignedNotebookInstanceUrl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreatePresignedNotebookInstanceUrl">REST API Reference for CreatePresignedNotebookInstanceUrl Operation</seealso>
        IAsyncResult BeginCreatePresignedNotebookInstanceUrl(CreatePresignedNotebookInstanceUrlRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePresignedNotebookInstanceUrl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePresignedNotebookInstanceUrl.</param>
        /// 
        /// <returns>Returns a  CreatePresignedNotebookInstanceUrlResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreatePresignedNotebookInstanceUrl">REST API Reference for CreatePresignedNotebookInstanceUrl Operation</seealso>
        CreatePresignedNotebookInstanceUrlResponse EndCreatePresignedNotebookInstanceUrl(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTrainingJob


        /// <summary>
        /// Starts a model training job. After training completes, Amazon SageMaker saves the
        /// resulting model artifacts to an Amazon S3 location that you specify. 
        /// 
        ///  
        /// <para>
        /// If you choose to host your model using Amazon SageMaker hosting services, you can
        /// use the resulting model artifacts as part of the model. You can also use the artifacts
        /// in a deep learning service other than Amazon SageMaker, provided that you know how
        /// to use them for inferences. 
        /// </para>
        ///  
        /// <para>
        /// In the request body, you provide the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>AlgorithmSpecification</code> - Identifies the training algorithm to use. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HyperParameters</code> - Specify these algorithm-specific parameters to influence
        /// the quality of the final model. For a list of hyperparameters for each training algorithm
        /// provided by Amazon SageMaker, see <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/algos.html">Algorithms</a>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>InputDataConfig</code> - Describes the training dataset and the Amazon S3 location
        /// where it is stored.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>OutputDataConfig</code> - Identifies the Amazon S3 location where you want
        /// Amazon SageMaker to save the results of model training. 
        /// </para>
        ///   </li> <li> 
        /// <para>
        ///  <code>ResourceConfig</code> - Identifies the resources, ML compute instances, and
        /// ML storage volumes to deploy for model training. In distributed training, you specify
        /// more than one instance. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RoleARN</code> - The Amazon Resource Number (ARN) that Amazon SageMaker assumes
        /// to perform tasks on your behalf during model training. You must grant this role the
        /// necessary permissions so that Amazon SageMaker can successfully complete model training.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>StoppingCondition</code> - Sets a duration for training. Use this parameter
        /// to cap model training costs. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For more information about Amazon SageMaker, see <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/how-it-works.html">How
        /// It Works</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrainingJob service method.</param>
        /// 
        /// <returns>The response from the CreateTrainingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTrainingJob">REST API Reference for CreateTrainingJob Operation</seealso>
        CreateTrainingJobResponse CreateTrainingJob(CreateTrainingJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrainingJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTrainingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTrainingJob">REST API Reference for CreateTrainingJob Operation</seealso>
        IAsyncResult BeginCreateTrainingJob(CreateTrainingJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTrainingJob.</param>
        /// 
        /// <returns>Returns a  CreateTrainingJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTrainingJob">REST API Reference for CreateTrainingJob Operation</seealso>
        CreateTrainingJobResponse EndCreateTrainingJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTransformJob


        /// <summary>
        /// Starts a transform job. A transform job uses a trained model to get inferences on
        /// a dataset and saves these results to an Amazon S3 location that you specify.
        /// 
        ///  
        /// <para>
        /// To perform batch transformations, you create a transform job and use the data that
        /// you have readily available.
        /// </para>
        ///  
        /// <para>
        /// In the request body, you provide the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>TransformJobName</code> - Identifies the transform job. The name must be unique
        /// within an AWS Region in an AWS account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ModelName</code> - Identifies the model to use. <code>ModelName</code> must
        /// be the name of an existing Amazon SageMaker model in the same AWS Region and AWS account.
        /// For information on creating a model, see <a>CreateModel</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TransformInput</code> - Describes the dataset to be transformed and the Amazon
        /// S3 location where it is stored.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TransformOutput</code> - Identifies the Amazon S3 location where you want Amazon
        /// SageMaker to save the results from the transform job.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TransformResources</code> - Identifies the ML compute instances for the transform
        /// job.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For more information about how batch transformation works Amazon SageMaker, see <a
        /// href="http://docs.aws.amazon.com/sagemaker/latest/dg/batch-transform.html">How It
        /// Works</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTransformJob service method.</param>
        /// 
        /// <returns>The response from the CreateTransformJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTransformJob">REST API Reference for CreateTransformJob Operation</seealso>
        CreateTransformJobResponse CreateTransformJob(CreateTransformJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTransformJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTransformJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTransformJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTransformJob">REST API Reference for CreateTransformJob Operation</seealso>
        IAsyncResult BeginCreateTransformJob(CreateTransformJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTransformJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTransformJob.</param>
        /// 
        /// <returns>Returns a  CreateTransformJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateTransformJob">REST API Reference for CreateTransformJob Operation</seealso>
        CreateTransformJobResponse EndCreateTransformJob(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateWorkteam


        /// <summary>
        /// Creates a new work team for labeling your data. A work team is defined by one or more
        /// Amazon Cognito user pools. You must first create the user pools before you can create
        /// a work team.
        /// 
        ///  
        /// <para>
        /// You cannot create more than 25 work teams in an account and region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkteam service method.</param>
        /// 
        /// <returns>The response from the CreateWorkteam service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceInUseException">
        /// Resource being accessed is in use.
        /// </exception>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateWorkteam">REST API Reference for CreateWorkteam Operation</seealso>
        CreateWorkteamResponse CreateWorkteam(CreateWorkteamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkteam operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkteam operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateWorkteam
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateWorkteam">REST API Reference for CreateWorkteam Operation</seealso>
        IAsyncResult BeginCreateWorkteam(CreateWorkteamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateWorkteam operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateWorkteam.</param>
        /// 
        /// <returns>Returns a  CreateWorkteamResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/CreateWorkteam">REST API Reference for CreateWorkteam Operation</seealso>
        CreateWorkteamResponse EndCreateWorkteam(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAlgorithm


        /// <summary>
        /// Removes the specified algorithm from your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlgorithm service method.</param>
        /// 
        /// <returns>The response from the DeleteAlgorithm service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteAlgorithm">REST API Reference for DeleteAlgorithm Operation</seealso>
        DeleteAlgorithmResponse DeleteAlgorithm(DeleteAlgorithmRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAlgorithm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAlgorithm operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAlgorithm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteAlgorithm">REST API Reference for DeleteAlgorithm Operation</seealso>
        IAsyncResult BeginDeleteAlgorithm(DeleteAlgorithmRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAlgorithm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAlgorithm.</param>
        /// 
        /// <returns>Returns a  DeleteAlgorithmResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteAlgorithm">REST API Reference for DeleteAlgorithm Operation</seealso>
        DeleteAlgorithmResponse EndDeleteAlgorithm(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCodeRepository


        /// <summary>
        /// Deletes the specified Git repository from your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCodeRepository service method.</param>
        /// 
        /// <returns>The response from the DeleteCodeRepository service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteCodeRepository">REST API Reference for DeleteCodeRepository Operation</seealso>
        DeleteCodeRepositoryResponse DeleteCodeRepository(DeleteCodeRepositoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCodeRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCodeRepository operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCodeRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteCodeRepository">REST API Reference for DeleteCodeRepository Operation</seealso>
        IAsyncResult BeginDeleteCodeRepository(DeleteCodeRepositoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCodeRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCodeRepository.</param>
        /// 
        /// <returns>Returns a  DeleteCodeRepositoryResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteCodeRepository">REST API Reference for DeleteCodeRepository Operation</seealso>
        DeleteCodeRepositoryResponse EndDeleteCodeRepository(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEndpoint


        /// <summary>
        /// Deletes an endpoint. Amazon SageMaker frees up all of the resources that were deployed
        /// when the endpoint was created. 
        /// 
        ///  
        /// <para>
        /// Amazon SageMaker retires any custom KMS key grants associated with the endpoint, meaning
        /// you don't need to use the <a href="http://docs.aws.amazon.com/kms/latest/APIReference/API_RevokeGrant.html">RevokeGrant</a>
        /// API call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint service method.</param>
        /// 
        /// <returns>The response from the DeleteEndpoint service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpoint operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        IAsyncResult BeginDeleteEndpoint(DeleteEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEndpoint.</param>
        /// 
        /// <returns>Returns a  DeleteEndpointResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEndpoint">REST API Reference for DeleteEndpoint Operation</seealso>
        DeleteEndpointResponse EndDeleteEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEndpointConfig


        /// <summary>
        /// Deletes an endpoint configuration. The <code>DeleteEndpointConfig</code> API deletes
        /// only the specified configuration. It does not delete endpoints created using the configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpointConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteEndpointConfig service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEndpointConfig">REST API Reference for DeleteEndpointConfig Operation</seealso>
        DeleteEndpointConfigResponse DeleteEndpointConfig(DeleteEndpointConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEndpointConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEndpointConfig operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEndpointConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEndpointConfig">REST API Reference for DeleteEndpointConfig Operation</seealso>
        IAsyncResult BeginDeleteEndpointConfig(DeleteEndpointConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEndpointConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEndpointConfig.</param>
        /// 
        /// <returns>Returns a  DeleteEndpointConfigResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteEndpointConfig">REST API Reference for DeleteEndpointConfig Operation</seealso>
        DeleteEndpointConfigResponse EndDeleteEndpointConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteModel


        /// <summary>
        /// Deletes a model. The <code>DeleteModel</code> API deletes only the model entry that
        /// was created in Amazon SageMaker when you called the <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/API_CreateModel.html">CreateModel</a>
        /// API. It does not delete model artifacts, inference code, or the IAM role that you
        /// specified when creating the model.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel service method.</param>
        /// 
        /// <returns>The response from the DeleteModel service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        DeleteModelResponse DeleteModel(DeleteModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteModel operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        IAsyncResult BeginDeleteModel(DeleteModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteModel.</param>
        /// 
        /// <returns>Returns a  DeleteModelResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModel">REST API Reference for DeleteModel Operation</seealso>
        DeleteModelResponse EndDeleteModel(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteModelPackage


        /// <summary>
        /// Deletes a model package.
        /// 
        ///  
        /// <para>
        /// A model package is used to create Amazon SageMaker models or list on AWS Marketplace.
        /// Buyers can subscribe to model packages listed on AWS Marketplace to create models
        /// in Amazon SageMaker.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelPackage service method.</param>
        /// 
        /// <returns>The response from the DeleteModelPackage service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelPackage">REST API Reference for DeleteModelPackage Operation</seealso>
        DeleteModelPackageResponse DeleteModelPackage(DeleteModelPackageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteModelPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteModelPackage operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteModelPackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelPackage">REST API Reference for DeleteModelPackage Operation</seealso>
        IAsyncResult BeginDeleteModelPackage(DeleteModelPackageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteModelPackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteModelPackage.</param>
        /// 
        /// <returns>Returns a  DeleteModelPackageResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteModelPackage">REST API Reference for DeleteModelPackage Operation</seealso>
        DeleteModelPackageResponse EndDeleteModelPackage(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteNotebookInstance


        /// <summary>
        /// Deletes an Amazon SageMaker notebook instance. Before you can delete a notebook instance,
        /// you must call the <code>StopNotebookInstance</code> API. 
        /// 
        ///  <important> 
        /// <para>
        /// When you delete a notebook instance, you lose all of your data. Amazon SageMaker removes
        /// the ML compute instance, and deletes the ML storage volume and the network interface
        /// associated with the notebook instance. 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotebookInstance service method.</param>
        /// 
        /// <returns>The response from the DeleteNotebookInstance service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteNotebookInstance">REST API Reference for DeleteNotebookInstance Operation</seealso>
        DeleteNotebookInstanceResponse DeleteNotebookInstance(DeleteNotebookInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotebookInstance operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNotebookInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteNotebookInstance">REST API Reference for DeleteNotebookInstance Operation</seealso>
        IAsyncResult BeginDeleteNotebookInstance(DeleteNotebookInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNotebookInstance.</param>
        /// 
        /// <returns>Returns a  DeleteNotebookInstanceResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteNotebookInstance">REST API Reference for DeleteNotebookInstance Operation</seealso>
        DeleteNotebookInstanceResponse EndDeleteNotebookInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteNotebookInstanceLifecycleConfig


        /// <summary>
        /// Deletes a notebook instance lifecycle configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotebookInstanceLifecycleConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteNotebookInstanceLifecycleConfig service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteNotebookInstanceLifecycleConfig">REST API Reference for DeleteNotebookInstanceLifecycleConfig Operation</seealso>
        DeleteNotebookInstanceLifecycleConfigResponse DeleteNotebookInstanceLifecycleConfig(DeleteNotebookInstanceLifecycleConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNotebookInstanceLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotebookInstanceLifecycleConfig operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNotebookInstanceLifecycleConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteNotebookInstanceLifecycleConfig">REST API Reference for DeleteNotebookInstanceLifecycleConfig Operation</seealso>
        IAsyncResult BeginDeleteNotebookInstanceLifecycleConfig(DeleteNotebookInstanceLifecycleConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNotebookInstanceLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNotebookInstanceLifecycleConfig.</param>
        /// 
        /// <returns>Returns a  DeleteNotebookInstanceLifecycleConfigResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteNotebookInstanceLifecycleConfig">REST API Reference for DeleteNotebookInstanceLifecycleConfig Operation</seealso>
        DeleteNotebookInstanceLifecycleConfigResponse EndDeleteNotebookInstanceLifecycleConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTags


        /// <summary>
        /// Deletes the specified tags from an Amazon SageMaker resource.
        /// 
        ///  
        /// <para>
        /// To list a resource's tags, use the <code>ListTags</code> API. 
        /// </para>
        ///  <note> 
        /// <para>
        /// When you call this API to delete tags from a hyperparameter tuning job, the deleted
        /// tags are not removed from training jobs that the hyperparameter tuning job launched
        /// before you called this API.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        DeleteTagsResponse DeleteTags(DeleteTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        IAsyncResult BeginDeleteTags(DeleteTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTags.</param>
        /// 
        /// <returns>Returns a  DeleteTagsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        DeleteTagsResponse EndDeleteTags(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteWorkteam


        /// <summary>
        /// Deletes an existing work team. This operation can't be undone.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkteam service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkteam service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteWorkteam">REST API Reference for DeleteWorkteam Operation</seealso>
        DeleteWorkteamResponse DeleteWorkteam(DeleteWorkteamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkteam operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkteam operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteWorkteam
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteWorkteam">REST API Reference for DeleteWorkteam Operation</seealso>
        IAsyncResult BeginDeleteWorkteam(DeleteWorkteamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteWorkteam operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteWorkteam.</param>
        /// 
        /// <returns>Returns a  DeleteWorkteamResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DeleteWorkteam">REST API Reference for DeleteWorkteam Operation</seealso>
        DeleteWorkteamResponse EndDeleteWorkteam(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAlgorithm


        /// <summary>
        /// Returns a description of the specified algorithm that is in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlgorithm service method.</param>
        /// 
        /// <returns>The response from the DescribeAlgorithm service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeAlgorithm">REST API Reference for DescribeAlgorithm Operation</seealso>
        DescribeAlgorithmResponse DescribeAlgorithm(DescribeAlgorithmRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAlgorithm operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAlgorithm operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAlgorithm
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeAlgorithm">REST API Reference for DescribeAlgorithm Operation</seealso>
        IAsyncResult BeginDescribeAlgorithm(DescribeAlgorithmRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAlgorithm operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAlgorithm.</param>
        /// 
        /// <returns>Returns a  DescribeAlgorithmResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeAlgorithm">REST API Reference for DescribeAlgorithm Operation</seealso>
        DescribeAlgorithmResponse EndDescribeAlgorithm(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCodeRepository


        /// <summary>
        /// Gets details about the specified Git repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCodeRepository service method.</param>
        /// 
        /// <returns>The response from the DescribeCodeRepository service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeCodeRepository">REST API Reference for DescribeCodeRepository Operation</seealso>
        DescribeCodeRepositoryResponse DescribeCodeRepository(DescribeCodeRepositoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCodeRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCodeRepository operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCodeRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeCodeRepository">REST API Reference for DescribeCodeRepository Operation</seealso>
        IAsyncResult BeginDescribeCodeRepository(DescribeCodeRepositoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCodeRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCodeRepository.</param>
        /// 
        /// <returns>Returns a  DescribeCodeRepositoryResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeCodeRepository">REST API Reference for DescribeCodeRepository Operation</seealso>
        DescribeCodeRepositoryResponse EndDescribeCodeRepository(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCompilationJob


        /// <summary>
        /// Returns information about a model compilation job.
        /// 
        ///  
        /// <para>
        /// To create a model compilation job, use <a>CreateCompilationJob</a>. To get information
        /// about multiple model compilation jobs, use <a>ListCompilationJobs</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCompilationJob service method.</param>
        /// 
        /// <returns>The response from the DescribeCompilationJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeCompilationJob">REST API Reference for DescribeCompilationJob Operation</seealso>
        DescribeCompilationJobResponse DescribeCompilationJob(DescribeCompilationJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCompilationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCompilationJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCompilationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeCompilationJob">REST API Reference for DescribeCompilationJob Operation</seealso>
        IAsyncResult BeginDescribeCompilationJob(DescribeCompilationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCompilationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCompilationJob.</param>
        /// 
        /// <returns>Returns a  DescribeCompilationJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeCompilationJob">REST API Reference for DescribeCompilationJob Operation</seealso>
        DescribeCompilationJobResponse EndDescribeCompilationJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEndpoint


        /// <summary>
        /// Returns the description of an endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoint service method.</param>
        /// 
        /// <returns>The response from the DescribeEndpoint service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        DescribeEndpointResponse DescribeEndpoint(DescribeEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpoint operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        IAsyncResult BeginDescribeEndpoint(DescribeEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEndpoint.</param>
        /// 
        /// <returns>Returns a  DescribeEndpointResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEndpoint">REST API Reference for DescribeEndpoint Operation</seealso>
        DescribeEndpointResponse EndDescribeEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEndpointConfig


        /// <summary>
        /// Returns the description of an endpoint configuration created using the <code>CreateEndpointConfig</code>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointConfig service method.</param>
        /// 
        /// <returns>The response from the DescribeEndpointConfig service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEndpointConfig">REST API Reference for DescribeEndpointConfig Operation</seealso>
        DescribeEndpointConfigResponse DescribeEndpointConfig(DescribeEndpointConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEndpointConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEndpointConfig operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEndpointConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEndpointConfig">REST API Reference for DescribeEndpointConfig Operation</seealso>
        IAsyncResult BeginDescribeEndpointConfig(DescribeEndpointConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEndpointConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEndpointConfig.</param>
        /// 
        /// <returns>Returns a  DescribeEndpointConfigResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeEndpointConfig">REST API Reference for DescribeEndpointConfig Operation</seealso>
        DescribeEndpointConfigResponse EndDescribeEndpointConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeHyperParameterTuningJob


        /// <summary>
        /// Gets a description of a hyperparameter tuning job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHyperParameterTuningJob service method.</param>
        /// 
        /// <returns>The response from the DescribeHyperParameterTuningJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeHyperParameterTuningJob">REST API Reference for DescribeHyperParameterTuningJob Operation</seealso>
        DescribeHyperParameterTuningJobResponse DescribeHyperParameterTuningJob(DescribeHyperParameterTuningJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHyperParameterTuningJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHyperParameterTuningJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHyperParameterTuningJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeHyperParameterTuningJob">REST API Reference for DescribeHyperParameterTuningJob Operation</seealso>
        IAsyncResult BeginDescribeHyperParameterTuningJob(DescribeHyperParameterTuningJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHyperParameterTuningJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHyperParameterTuningJob.</param>
        /// 
        /// <returns>Returns a  DescribeHyperParameterTuningJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeHyperParameterTuningJob">REST API Reference for DescribeHyperParameterTuningJob Operation</seealso>
        DescribeHyperParameterTuningJobResponse EndDescribeHyperParameterTuningJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLabelingJob


        /// <summary>
        /// Gets information about a labeling job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLabelingJob service method.</param>
        /// 
        /// <returns>The response from the DescribeLabelingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeLabelingJob">REST API Reference for DescribeLabelingJob Operation</seealso>
        DescribeLabelingJobResponse DescribeLabelingJob(DescribeLabelingJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLabelingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLabelingJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLabelingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeLabelingJob">REST API Reference for DescribeLabelingJob Operation</seealso>
        IAsyncResult BeginDescribeLabelingJob(DescribeLabelingJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLabelingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLabelingJob.</param>
        /// 
        /// <returns>Returns a  DescribeLabelingJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeLabelingJob">REST API Reference for DescribeLabelingJob Operation</seealso>
        DescribeLabelingJobResponse EndDescribeLabelingJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeModel


        /// <summary>
        /// Describes a model that you created using the <code>CreateModel</code> API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModel service method.</param>
        /// 
        /// <returns>The response from the DescribeModel service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModel">REST API Reference for DescribeModel Operation</seealso>
        DescribeModelResponse DescribeModel(DescribeModelRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeModel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeModel operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeModel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModel">REST API Reference for DescribeModel Operation</seealso>
        IAsyncResult BeginDescribeModel(DescribeModelRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeModel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeModel.</param>
        /// 
        /// <returns>Returns a  DescribeModelResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModel">REST API Reference for DescribeModel Operation</seealso>
        DescribeModelResponse EndDescribeModel(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeModelPackage


        /// <summary>
        /// Returns a description of the specified model package, which is used to create Amazon
        /// SageMaker models or list them on AWS Marketplace.
        /// 
        ///  
        /// <para>
        /// To create models in Amazon SageMaker, buyers can subscribe to model packages listed
        /// on AWS Marketplace.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelPackage service method.</param>
        /// 
        /// <returns>The response from the DescribeModelPackage service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelPackage">REST API Reference for DescribeModelPackage Operation</seealso>
        DescribeModelPackageResponse DescribeModelPackage(DescribeModelPackageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeModelPackage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeModelPackage operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeModelPackage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelPackage">REST API Reference for DescribeModelPackage Operation</seealso>
        IAsyncResult BeginDescribeModelPackage(DescribeModelPackageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeModelPackage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeModelPackage.</param>
        /// 
        /// <returns>Returns a  DescribeModelPackageResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeModelPackage">REST API Reference for DescribeModelPackage Operation</seealso>
        DescribeModelPackageResponse EndDescribeModelPackage(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeNotebookInstance


        /// <summary>
        /// Returns information about a notebook instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotebookInstance service method.</param>
        /// 
        /// <returns>The response from the DescribeNotebookInstance service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeNotebookInstance">REST API Reference for DescribeNotebookInstance Operation</seealso>
        DescribeNotebookInstanceResponse DescribeNotebookInstance(DescribeNotebookInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotebookInstance operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNotebookInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeNotebookInstance">REST API Reference for DescribeNotebookInstance Operation</seealso>
        IAsyncResult BeginDescribeNotebookInstance(DescribeNotebookInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNotebookInstance.</param>
        /// 
        /// <returns>Returns a  DescribeNotebookInstanceResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeNotebookInstance">REST API Reference for DescribeNotebookInstance Operation</seealso>
        DescribeNotebookInstanceResponse EndDescribeNotebookInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeNotebookInstanceLifecycleConfig


        /// <summary>
        /// Returns a description of a notebook instance lifecycle configuration.
        /// 
        ///  
        /// <para>
        /// For information about notebook instance lifestyle configurations, see <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/notebook-lifecycle-config.html">Step
        /// 2.1: (Optional) Customize a Notebook Instance</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotebookInstanceLifecycleConfig service method.</param>
        /// 
        /// <returns>The response from the DescribeNotebookInstanceLifecycleConfig service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeNotebookInstanceLifecycleConfig">REST API Reference for DescribeNotebookInstanceLifecycleConfig Operation</seealso>
        DescribeNotebookInstanceLifecycleConfigResponse DescribeNotebookInstanceLifecycleConfig(DescribeNotebookInstanceLifecycleConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNotebookInstanceLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNotebookInstanceLifecycleConfig operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNotebookInstanceLifecycleConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeNotebookInstanceLifecycleConfig">REST API Reference for DescribeNotebookInstanceLifecycleConfig Operation</seealso>
        IAsyncResult BeginDescribeNotebookInstanceLifecycleConfig(DescribeNotebookInstanceLifecycleConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNotebookInstanceLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNotebookInstanceLifecycleConfig.</param>
        /// 
        /// <returns>Returns a  DescribeNotebookInstanceLifecycleConfigResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeNotebookInstanceLifecycleConfig">REST API Reference for DescribeNotebookInstanceLifecycleConfig Operation</seealso>
        DescribeNotebookInstanceLifecycleConfigResponse EndDescribeNotebookInstanceLifecycleConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSubscribedWorkteam


        /// <summary>
        /// Gets information about a work team provided by a vendor. It returns details about
        /// the subscription with a vendor in the AWS Marketplace.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscribedWorkteam service method.</param>
        /// 
        /// <returns>The response from the DescribeSubscribedWorkteam service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeSubscribedWorkteam">REST API Reference for DescribeSubscribedWorkteam Operation</seealso>
        DescribeSubscribedWorkteamResponse DescribeSubscribedWorkteam(DescribeSubscribedWorkteamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSubscribedWorkteam operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscribedWorkteam operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSubscribedWorkteam
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeSubscribedWorkteam">REST API Reference for DescribeSubscribedWorkteam Operation</seealso>
        IAsyncResult BeginDescribeSubscribedWorkteam(DescribeSubscribedWorkteamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSubscribedWorkteam operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSubscribedWorkteam.</param>
        /// 
        /// <returns>Returns a  DescribeSubscribedWorkteamResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeSubscribedWorkteam">REST API Reference for DescribeSubscribedWorkteam Operation</seealso>
        DescribeSubscribedWorkteamResponse EndDescribeSubscribedWorkteam(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTrainingJob


        /// <summary>
        /// Returns information about a training job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrainingJob service method.</param>
        /// 
        /// <returns>The response from the DescribeTrainingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTrainingJob">REST API Reference for DescribeTrainingJob Operation</seealso>
        DescribeTrainingJobResponse DescribeTrainingJob(DescribeTrainingJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrainingJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTrainingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTrainingJob">REST API Reference for DescribeTrainingJob Operation</seealso>
        IAsyncResult BeginDescribeTrainingJob(DescribeTrainingJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTrainingJob.</param>
        /// 
        /// <returns>Returns a  DescribeTrainingJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTrainingJob">REST API Reference for DescribeTrainingJob Operation</seealso>
        DescribeTrainingJobResponse EndDescribeTrainingJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTransformJob


        /// <summary>
        /// Returns information about a transform job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTransformJob service method.</param>
        /// 
        /// <returns>The response from the DescribeTransformJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTransformJob">REST API Reference for DescribeTransformJob Operation</seealso>
        DescribeTransformJobResponse DescribeTransformJob(DescribeTransformJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTransformJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTransformJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTransformJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTransformJob">REST API Reference for DescribeTransformJob Operation</seealso>
        IAsyncResult BeginDescribeTransformJob(DescribeTransformJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTransformJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTransformJob.</param>
        /// 
        /// <returns>Returns a  DescribeTransformJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeTransformJob">REST API Reference for DescribeTransformJob Operation</seealso>
        DescribeTransformJobResponse EndDescribeTransformJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeWorkteam


        /// <summary>
        /// Gets information about a specific work team. You can see information such as the create
        /// date, the last updated date, membership information, and the work team's Amazon Resource
        /// Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkteam service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkteam service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeWorkteam">REST API Reference for DescribeWorkteam Operation</seealso>
        DescribeWorkteamResponse DescribeWorkteam(DescribeWorkteamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkteam operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkteam operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeWorkteam
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeWorkteam">REST API Reference for DescribeWorkteam Operation</seealso>
        IAsyncResult BeginDescribeWorkteam(DescribeWorkteamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeWorkteam operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeWorkteam.</param>
        /// 
        /// <returns>Returns a  DescribeWorkteamResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/DescribeWorkteam">REST API Reference for DescribeWorkteam Operation</seealso>
        DescribeWorkteamResponse EndDescribeWorkteam(IAsyncResult asyncResult);

        #endregion
        
        #region  GetSearchSuggestions


        /// <summary>
        /// An auto-complete API for the search functionality in the Amazon SageMaker console.
        /// It returns suggestions of possible matches for the property name to use in <code>Search</code>
        /// queries. Provides suggestions for <code>HyperParameters</code>, <code>Tags</code>,
        /// and <code>Metrics</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSearchSuggestions service method.</param>
        /// 
        /// <returns>The response from the GetSearchSuggestions service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetSearchSuggestions">REST API Reference for GetSearchSuggestions Operation</seealso>
        GetSearchSuggestionsResponse GetSearchSuggestions(GetSearchSuggestionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetSearchSuggestions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSearchSuggestions operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSearchSuggestions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetSearchSuggestions">REST API Reference for GetSearchSuggestions Operation</seealso>
        IAsyncResult BeginGetSearchSuggestions(GetSearchSuggestionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSearchSuggestions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSearchSuggestions.</param>
        /// 
        /// <returns>Returns a  GetSearchSuggestionsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/GetSearchSuggestions">REST API Reference for GetSearchSuggestions Operation</seealso>
        GetSearchSuggestionsResponse EndGetSearchSuggestions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAlgorithms


        /// <summary>
        /// Lists the machine learning algorithms that have been created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAlgorithms service method.</param>
        /// 
        /// <returns>The response from the ListAlgorithms service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAlgorithms">REST API Reference for ListAlgorithms Operation</seealso>
        ListAlgorithmsResponse ListAlgorithms(ListAlgorithmsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAlgorithms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAlgorithms operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAlgorithms
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAlgorithms">REST API Reference for ListAlgorithms Operation</seealso>
        IAsyncResult BeginListAlgorithms(ListAlgorithmsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAlgorithms operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAlgorithms.</param>
        /// 
        /// <returns>Returns a  ListAlgorithmsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListAlgorithms">REST API Reference for ListAlgorithms Operation</seealso>
        ListAlgorithmsResponse EndListAlgorithms(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCodeRepositories


        /// <summary>
        /// Gets a list of the Git repositories in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCodeRepositories service method.</param>
        /// 
        /// <returns>The response from the ListCodeRepositories service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCodeRepositories">REST API Reference for ListCodeRepositories Operation</seealso>
        ListCodeRepositoriesResponse ListCodeRepositories(ListCodeRepositoriesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCodeRepositories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCodeRepositories operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCodeRepositories
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCodeRepositories">REST API Reference for ListCodeRepositories Operation</seealso>
        IAsyncResult BeginListCodeRepositories(ListCodeRepositoriesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCodeRepositories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCodeRepositories.</param>
        /// 
        /// <returns>Returns a  ListCodeRepositoriesResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCodeRepositories">REST API Reference for ListCodeRepositories Operation</seealso>
        ListCodeRepositoriesResponse EndListCodeRepositories(IAsyncResult asyncResult);

        #endregion
        
        #region  ListCompilationJobs


        /// <summary>
        /// Lists model compilation jobs that satisfy various filters.
        /// 
        ///  
        /// <para>
        /// To create a model compilation job, use <a>CreateCompilationJob</a>. To get information
        /// about a particular model compilation job you have created, use <a>DescribeCompilationJob</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCompilationJobs service method.</param>
        /// 
        /// <returns>The response from the ListCompilationJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCompilationJobs">REST API Reference for ListCompilationJobs Operation</seealso>
        ListCompilationJobsResponse ListCompilationJobs(ListCompilationJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListCompilationJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCompilationJobs operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCompilationJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCompilationJobs">REST API Reference for ListCompilationJobs Operation</seealso>
        IAsyncResult BeginListCompilationJobs(ListCompilationJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListCompilationJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCompilationJobs.</param>
        /// 
        /// <returns>Returns a  ListCompilationJobsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListCompilationJobs">REST API Reference for ListCompilationJobs Operation</seealso>
        ListCompilationJobsResponse EndListCompilationJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEndpointConfigs


        /// <summary>
        /// Lists endpoint configurations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointConfigs service method.</param>
        /// 
        /// <returns>The response from the ListEndpointConfigs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEndpointConfigs">REST API Reference for ListEndpointConfigs Operation</seealso>
        ListEndpointConfigsResponse ListEndpointConfigs(ListEndpointConfigsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEndpointConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEndpointConfigs operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEndpointConfigs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEndpointConfigs">REST API Reference for ListEndpointConfigs Operation</seealso>
        IAsyncResult BeginListEndpointConfigs(ListEndpointConfigsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEndpointConfigs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEndpointConfigs.</param>
        /// 
        /// <returns>Returns a  ListEndpointConfigsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEndpointConfigs">REST API Reference for ListEndpointConfigs Operation</seealso>
        ListEndpointConfigsResponse EndListEndpointConfigs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListEndpoints


        /// <summary>
        /// Lists endpoints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEndpoints service method.</param>
        /// 
        /// <returns>The response from the ListEndpoints service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEndpoints">REST API Reference for ListEndpoints Operation</seealso>
        ListEndpointsResponse ListEndpoints(ListEndpointsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEndpoints operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEndpoints">REST API Reference for ListEndpoints Operation</seealso>
        IAsyncResult BeginListEndpoints(ListEndpointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEndpoints.</param>
        /// 
        /// <returns>Returns a  ListEndpointsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListEndpoints">REST API Reference for ListEndpoints Operation</seealso>
        ListEndpointsResponse EndListEndpoints(IAsyncResult asyncResult);

        #endregion
        
        #region  ListHyperParameterTuningJobs


        /// <summary>
        /// Gets a list of <a>HyperParameterTuningJobSummary</a> objects that describe the hyperparameter
        /// tuning jobs launched in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListHyperParameterTuningJobs service method.</param>
        /// 
        /// <returns>The response from the ListHyperParameterTuningJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHyperParameterTuningJobs">REST API Reference for ListHyperParameterTuningJobs Operation</seealso>
        ListHyperParameterTuningJobsResponse ListHyperParameterTuningJobs(ListHyperParameterTuningJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListHyperParameterTuningJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListHyperParameterTuningJobs operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListHyperParameterTuningJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHyperParameterTuningJobs">REST API Reference for ListHyperParameterTuningJobs Operation</seealso>
        IAsyncResult BeginListHyperParameterTuningJobs(ListHyperParameterTuningJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListHyperParameterTuningJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListHyperParameterTuningJobs.</param>
        /// 
        /// <returns>Returns a  ListHyperParameterTuningJobsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListHyperParameterTuningJobs">REST API Reference for ListHyperParameterTuningJobs Operation</seealso>
        ListHyperParameterTuningJobsResponse EndListHyperParameterTuningJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLabelingJobs


        /// <summary>
        /// Gets a list of labeling jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLabelingJobs service method.</param>
        /// 
        /// <returns>The response from the ListLabelingJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListLabelingJobs">REST API Reference for ListLabelingJobs Operation</seealso>
        ListLabelingJobsResponse ListLabelingJobs(ListLabelingJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLabelingJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLabelingJobs operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLabelingJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListLabelingJobs">REST API Reference for ListLabelingJobs Operation</seealso>
        IAsyncResult BeginListLabelingJobs(ListLabelingJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLabelingJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLabelingJobs.</param>
        /// 
        /// <returns>Returns a  ListLabelingJobsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListLabelingJobs">REST API Reference for ListLabelingJobs Operation</seealso>
        ListLabelingJobsResponse EndListLabelingJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListLabelingJobsForWorkteam


        /// <summary>
        /// Gets a list of labeling jobs assigned to a specified work team.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLabelingJobsForWorkteam service method.</param>
        /// 
        /// <returns>The response from the ListLabelingJobsForWorkteam service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListLabelingJobsForWorkteam">REST API Reference for ListLabelingJobsForWorkteam Operation</seealso>
        ListLabelingJobsForWorkteamResponse ListLabelingJobsForWorkteam(ListLabelingJobsForWorkteamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListLabelingJobsForWorkteam operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLabelingJobsForWorkteam operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLabelingJobsForWorkteam
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListLabelingJobsForWorkteam">REST API Reference for ListLabelingJobsForWorkteam Operation</seealso>
        IAsyncResult BeginListLabelingJobsForWorkteam(ListLabelingJobsForWorkteamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListLabelingJobsForWorkteam operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLabelingJobsForWorkteam.</param>
        /// 
        /// <returns>Returns a  ListLabelingJobsForWorkteamResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListLabelingJobsForWorkteam">REST API Reference for ListLabelingJobsForWorkteam Operation</seealso>
        ListLabelingJobsForWorkteamResponse EndListLabelingJobsForWorkteam(IAsyncResult asyncResult);

        #endregion
        
        #region  ListModelPackages


        /// <summary>
        /// Lists the model packages that have been created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModelPackages service method.</param>
        /// 
        /// <returns>The response from the ListModelPackages service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelPackages">REST API Reference for ListModelPackages Operation</seealso>
        ListModelPackagesResponse ListModelPackages(ListModelPackagesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListModelPackages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListModelPackages operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListModelPackages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelPackages">REST API Reference for ListModelPackages Operation</seealso>
        IAsyncResult BeginListModelPackages(ListModelPackagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListModelPackages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListModelPackages.</param>
        /// 
        /// <returns>Returns a  ListModelPackagesResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModelPackages">REST API Reference for ListModelPackages Operation</seealso>
        ListModelPackagesResponse EndListModelPackages(IAsyncResult asyncResult);

        #endregion
        
        #region  ListModels


        /// <summary>
        /// Lists models created with the <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/API_CreateModel.html">CreateModel</a>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListModels service method.</param>
        /// 
        /// <returns>The response from the ListModels service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModels">REST API Reference for ListModels Operation</seealso>
        ListModelsResponse ListModels(ListModelsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListModels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListModels operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListModels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModels">REST API Reference for ListModels Operation</seealso>
        IAsyncResult BeginListModels(ListModelsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListModels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListModels.</param>
        /// 
        /// <returns>Returns a  ListModelsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListModels">REST API Reference for ListModels Operation</seealso>
        ListModelsResponse EndListModels(IAsyncResult asyncResult);

        #endregion
        
        #region  ListNotebookInstanceLifecycleConfigs


        /// <summary>
        /// Lists notebook instance lifestyle configurations created with the <a>CreateNotebookInstanceLifecycleConfig</a>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookInstanceLifecycleConfigs service method.</param>
        /// 
        /// <returns>The response from the ListNotebookInstanceLifecycleConfigs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListNotebookInstanceLifecycleConfigs">REST API Reference for ListNotebookInstanceLifecycleConfigs Operation</seealso>
        ListNotebookInstanceLifecycleConfigsResponse ListNotebookInstanceLifecycleConfigs(ListNotebookInstanceLifecycleConfigsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListNotebookInstanceLifecycleConfigs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookInstanceLifecycleConfigs operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNotebookInstanceLifecycleConfigs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListNotebookInstanceLifecycleConfigs">REST API Reference for ListNotebookInstanceLifecycleConfigs Operation</seealso>
        IAsyncResult BeginListNotebookInstanceLifecycleConfigs(ListNotebookInstanceLifecycleConfigsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListNotebookInstanceLifecycleConfigs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNotebookInstanceLifecycleConfigs.</param>
        /// 
        /// <returns>Returns a  ListNotebookInstanceLifecycleConfigsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListNotebookInstanceLifecycleConfigs">REST API Reference for ListNotebookInstanceLifecycleConfigs Operation</seealso>
        ListNotebookInstanceLifecycleConfigsResponse EndListNotebookInstanceLifecycleConfigs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListNotebookInstances


        /// <summary>
        /// Returns a list of the Amazon SageMaker notebook instances in the requester's account
        /// in an AWS Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookInstances service method.</param>
        /// 
        /// <returns>The response from the ListNotebookInstances service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListNotebookInstances">REST API Reference for ListNotebookInstances Operation</seealso>
        ListNotebookInstancesResponse ListNotebookInstances(ListNotebookInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListNotebookInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListNotebookInstances operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListNotebookInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListNotebookInstances">REST API Reference for ListNotebookInstances Operation</seealso>
        IAsyncResult BeginListNotebookInstances(ListNotebookInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListNotebookInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListNotebookInstances.</param>
        /// 
        /// <returns>Returns a  ListNotebookInstancesResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListNotebookInstances">REST API Reference for ListNotebookInstances Operation</seealso>
        ListNotebookInstancesResponse EndListNotebookInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  ListSubscribedWorkteams


        /// <summary>
        /// Gets a list of the work teams that you are subscribed to in the AWS Marketplace. The
        /// list may be empty if no work team satisfies the filter specified in the <code>NameContains</code>
        /// parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubscribedWorkteams service method.</param>
        /// 
        /// <returns>The response from the ListSubscribedWorkteams service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListSubscribedWorkteams">REST API Reference for ListSubscribedWorkteams Operation</seealso>
        ListSubscribedWorkteamsResponse ListSubscribedWorkteams(ListSubscribedWorkteamsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListSubscribedWorkteams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSubscribedWorkteams operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSubscribedWorkteams
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListSubscribedWorkteams">REST API Reference for ListSubscribedWorkteams Operation</seealso>
        IAsyncResult BeginListSubscribedWorkteams(ListSubscribedWorkteamsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSubscribedWorkteams operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSubscribedWorkteams.</param>
        /// 
        /// <returns>Returns a  ListSubscribedWorkteamsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListSubscribedWorkteams">REST API Reference for ListSubscribedWorkteams Operation</seealso>
        ListSubscribedWorkteamsResponse EndListSubscribedWorkteams(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTags


        /// <summary>
        /// Returns the tags for the specified Amazon SageMaker resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTags service method.</param>
        /// 
        /// <returns>The response from the ListTags service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTags">REST API Reference for ListTags Operation</seealso>
        ListTagsResponse ListTags(ListTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTags">REST API Reference for ListTags Operation</seealso>
        IAsyncResult BeginListTags(ListTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTags.</param>
        /// 
        /// <returns>Returns a  ListTagsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTags">REST API Reference for ListTags Operation</seealso>
        ListTagsResponse EndListTags(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTrainingJobs


        /// <summary>
        /// Lists training jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrainingJobs service method.</param>
        /// 
        /// <returns>The response from the ListTrainingJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrainingJobs">REST API Reference for ListTrainingJobs Operation</seealso>
        ListTrainingJobsResponse ListTrainingJobs(ListTrainingJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrainingJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrainingJobs operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrainingJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrainingJobs">REST API Reference for ListTrainingJobs Operation</seealso>
        IAsyncResult BeginListTrainingJobs(ListTrainingJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrainingJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrainingJobs.</param>
        /// 
        /// <returns>Returns a  ListTrainingJobsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrainingJobs">REST API Reference for ListTrainingJobs Operation</seealso>
        ListTrainingJobsResponse EndListTrainingJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTrainingJobsForHyperParameterTuningJob


        /// <summary>
        /// Gets a list of <a>TrainingJobSummary</a> objects that describe the training jobs that
        /// a hyperparameter tuning job launched.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrainingJobsForHyperParameterTuningJob service method.</param>
        /// 
        /// <returns>The response from the ListTrainingJobsForHyperParameterTuningJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrainingJobsForHyperParameterTuningJob">REST API Reference for ListTrainingJobsForHyperParameterTuningJob Operation</seealso>
        ListTrainingJobsForHyperParameterTuningJobResponse ListTrainingJobsForHyperParameterTuningJob(ListTrainingJobsForHyperParameterTuningJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTrainingJobsForHyperParameterTuningJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTrainingJobsForHyperParameterTuningJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTrainingJobsForHyperParameterTuningJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrainingJobsForHyperParameterTuningJob">REST API Reference for ListTrainingJobsForHyperParameterTuningJob Operation</seealso>
        IAsyncResult BeginListTrainingJobsForHyperParameterTuningJob(ListTrainingJobsForHyperParameterTuningJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTrainingJobsForHyperParameterTuningJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTrainingJobsForHyperParameterTuningJob.</param>
        /// 
        /// <returns>Returns a  ListTrainingJobsForHyperParameterTuningJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTrainingJobsForHyperParameterTuningJob">REST API Reference for ListTrainingJobsForHyperParameterTuningJob Operation</seealso>
        ListTrainingJobsForHyperParameterTuningJobResponse EndListTrainingJobsForHyperParameterTuningJob(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTransformJobs


        /// <summary>
        /// Lists transform jobs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTransformJobs service method.</param>
        /// 
        /// <returns>The response from the ListTransformJobs service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTransformJobs">REST API Reference for ListTransformJobs Operation</seealso>
        ListTransformJobsResponse ListTransformJobs(ListTransformJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTransformJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTransformJobs operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTransformJobs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTransformJobs">REST API Reference for ListTransformJobs Operation</seealso>
        IAsyncResult BeginListTransformJobs(ListTransformJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTransformJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTransformJobs.</param>
        /// 
        /// <returns>Returns a  ListTransformJobsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListTransformJobs">REST API Reference for ListTransformJobs Operation</seealso>
        ListTransformJobsResponse EndListTransformJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  ListWorkteams


        /// <summary>
        /// Gets a list of work teams that you have defined in a region. The list may be empty
        /// if no work team satisfies the filter specified in the <code>NameContains</code> parameter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWorkteams service method.</param>
        /// 
        /// <returns>The response from the ListWorkteams service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListWorkteams">REST API Reference for ListWorkteams Operation</seealso>
        ListWorkteamsResponse ListWorkteams(ListWorkteamsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListWorkteams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListWorkteams operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListWorkteams
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListWorkteams">REST API Reference for ListWorkteams Operation</seealso>
        IAsyncResult BeginListWorkteams(ListWorkteamsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListWorkteams operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListWorkteams.</param>
        /// 
        /// <returns>Returns a  ListWorkteamsResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/ListWorkteams">REST API Reference for ListWorkteams Operation</seealso>
        ListWorkteamsResponse EndListWorkteams(IAsyncResult asyncResult);

        #endregion
        
        #region  RenderUiTemplate


        /// <summary>
        /// Renders the UI template so that you can preview the worker's experience.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RenderUiTemplate service method.</param>
        /// 
        /// <returns>The response from the RenderUiTemplate service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/RenderUiTemplate">REST API Reference for RenderUiTemplate Operation</seealso>
        RenderUiTemplateResponse RenderUiTemplate(RenderUiTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RenderUiTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RenderUiTemplate operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRenderUiTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/RenderUiTemplate">REST API Reference for RenderUiTemplate Operation</seealso>
        IAsyncResult BeginRenderUiTemplate(RenderUiTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RenderUiTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRenderUiTemplate.</param>
        /// 
        /// <returns>Returns a  RenderUiTemplateResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/RenderUiTemplate">REST API Reference for RenderUiTemplate Operation</seealso>
        RenderUiTemplateResponse EndRenderUiTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  Search


        /// <summary>
        /// Finds Amazon SageMaker resources that match a search query. Matching resource objects
        /// are returned as a list of <code>SearchResult</code> objects in the response. You can
        /// sort the search results by any resource property in a ascending or descending order.
        /// 
        ///  
        /// <para>
        /// You can query against the following value types: numerical, text, Booleans, and timestamps.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the Search service method.</param>
        /// 
        /// <returns>The response from the Search service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/Search">REST API Reference for Search Operation</seealso>
        SearchResponse Search(SearchRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the Search operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the Search operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSearch
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/Search">REST API Reference for Search Operation</seealso>
        IAsyncResult BeginSearch(SearchRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  Search operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSearch.</param>
        /// 
        /// <returns>Returns a  SearchResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/Search">REST API Reference for Search Operation</seealso>
        SearchResponse EndSearch(IAsyncResult asyncResult);

        #endregion
        
        #region  StartNotebookInstance


        /// <summary>
        /// Launches an ML compute instance with the latest version of the libraries and attaches
        /// your ML storage volume. After configuring the notebook instance, Amazon SageMaker
        /// sets the notebook instance status to <code>InService</code>. A notebook instance's
        /// status must be <code>InService</code> before you can connect to your Jupyter notebook.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartNotebookInstance service method.</param>
        /// 
        /// <returns>The response from the StartNotebookInstance service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartNotebookInstance">REST API Reference for StartNotebookInstance Operation</seealso>
        StartNotebookInstanceResponse StartNotebookInstance(StartNotebookInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartNotebookInstance operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartNotebookInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartNotebookInstance">REST API Reference for StartNotebookInstance Operation</seealso>
        IAsyncResult BeginStartNotebookInstance(StartNotebookInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartNotebookInstance.</param>
        /// 
        /// <returns>Returns a  StartNotebookInstanceResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StartNotebookInstance">REST API Reference for StartNotebookInstance Operation</seealso>
        StartNotebookInstanceResponse EndStartNotebookInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  StopCompilationJob


        /// <summary>
        /// Stops a model compilation job.
        /// 
        ///  
        /// <para>
        ///  To stop a job, Amazon SageMaker sends the algorithm the SIGTERM signal. This gracefully
        /// shuts the job down. If the job hasn't stopped, it sends the SIGKILL signal.
        /// </para>
        ///  
        /// <para>
        /// When it receives a <code>StopCompilationJob</code> request, Amazon SageMaker changes
        /// the <a>CompilationJobSummary$CompilationJobStatus</a> of the job to <code>Stopping</code>.
        /// After Amazon SageMaker stops the job, it sets the <a>CompilationJobSummary$CompilationJobStatus</a>
        /// to <code>Stopped</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopCompilationJob service method.</param>
        /// 
        /// <returns>The response from the StopCompilationJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopCompilationJob">REST API Reference for StopCompilationJob Operation</seealso>
        StopCompilationJobResponse StopCompilationJob(StopCompilationJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopCompilationJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopCompilationJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopCompilationJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopCompilationJob">REST API Reference for StopCompilationJob Operation</seealso>
        IAsyncResult BeginStopCompilationJob(StopCompilationJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopCompilationJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopCompilationJob.</param>
        /// 
        /// <returns>Returns a  StopCompilationJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopCompilationJob">REST API Reference for StopCompilationJob Operation</seealso>
        StopCompilationJobResponse EndStopCompilationJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StopHyperParameterTuningJob


        /// <summary>
        /// Stops a running hyperparameter tuning job and all running training jobs that the tuning
        /// job launched.
        /// 
        ///  
        /// <para>
        /// All model artifacts output from the training jobs are stored in Amazon Simple Storage
        /// Service (Amazon S3). All data that the training jobs write to Amazon CloudWatch Logs
        /// are still available in CloudWatch. After the tuning job moves to the <code>Stopped</code>
        /// state, it releases all reserved resources for the tuning job.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopHyperParameterTuningJob service method.</param>
        /// 
        /// <returns>The response from the StopHyperParameterTuningJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopHyperParameterTuningJob">REST API Reference for StopHyperParameterTuningJob Operation</seealso>
        StopHyperParameterTuningJobResponse StopHyperParameterTuningJob(StopHyperParameterTuningJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopHyperParameterTuningJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopHyperParameterTuningJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopHyperParameterTuningJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopHyperParameterTuningJob">REST API Reference for StopHyperParameterTuningJob Operation</seealso>
        IAsyncResult BeginStopHyperParameterTuningJob(StopHyperParameterTuningJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopHyperParameterTuningJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopHyperParameterTuningJob.</param>
        /// 
        /// <returns>Returns a  StopHyperParameterTuningJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopHyperParameterTuningJob">REST API Reference for StopHyperParameterTuningJob Operation</seealso>
        StopHyperParameterTuningJobResponse EndStopHyperParameterTuningJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StopLabelingJob


        /// <summary>
        /// Stops a running labeling job. A job that is stopped cannot be restarted. Any results
        /// obtained before the job is stopped are placed in the Amazon S3 output bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopLabelingJob service method.</param>
        /// 
        /// <returns>The response from the StopLabelingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopLabelingJob">REST API Reference for StopLabelingJob Operation</seealso>
        StopLabelingJobResponse StopLabelingJob(StopLabelingJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopLabelingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopLabelingJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopLabelingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopLabelingJob">REST API Reference for StopLabelingJob Operation</seealso>
        IAsyncResult BeginStopLabelingJob(StopLabelingJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopLabelingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopLabelingJob.</param>
        /// 
        /// <returns>Returns a  StopLabelingJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopLabelingJob">REST API Reference for StopLabelingJob Operation</seealso>
        StopLabelingJobResponse EndStopLabelingJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StopNotebookInstance


        /// <summary>
        /// Terminates the ML compute instance. Before terminating the instance, Amazon SageMaker
        /// disconnects the ML storage volume from it. Amazon SageMaker preserves the ML storage
        /// volume. 
        /// 
        ///  
        /// <para>
        /// To access data on the ML storage volume for a notebook instance that has been terminated,
        /// call the <code>StartNotebookInstance</code> API. <code>StartNotebookInstance</code>
        /// launches another ML compute instance, configures it, and attaches the preserved ML
        /// storage volume so you can continue your work. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopNotebookInstance service method.</param>
        /// 
        /// <returns>The response from the StopNotebookInstance service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopNotebookInstance">REST API Reference for StopNotebookInstance Operation</seealso>
        StopNotebookInstanceResponse StopNotebookInstance(StopNotebookInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopNotebookInstance operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopNotebookInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopNotebookInstance">REST API Reference for StopNotebookInstance Operation</seealso>
        IAsyncResult BeginStopNotebookInstance(StopNotebookInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopNotebookInstance.</param>
        /// 
        /// <returns>Returns a  StopNotebookInstanceResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopNotebookInstance">REST API Reference for StopNotebookInstance Operation</seealso>
        StopNotebookInstanceResponse EndStopNotebookInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  StopTrainingJob


        /// <summary>
        /// Stops a training job. To stop a job, Amazon SageMaker sends the algorithm the <code>SIGTERM</code>
        /// signal, which delays job termination for 120 seconds. Algorithms might use this 120-second
        /// window to save the model artifacts, so the results of the training is not lost. 
        /// 
        ///  
        /// <para>
        /// Training algorithms provided by Amazon SageMaker save the intermediate results of
        /// a model training job. This intermediate data is a valid model artifact. You can use
        /// the model artifacts that are saved when Amazon SageMaker stops a training job to create
        /// a model. 
        /// </para>
        ///  
        /// <para>
        /// When it receives a <code>StopTrainingJob</code> request, Amazon SageMaker changes
        /// the status of the job to <code>Stopping</code>. After Amazon SageMaker stops the job,
        /// it sets the status to <code>Stopped</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTrainingJob service method.</param>
        /// 
        /// <returns>The response from the StopTrainingJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopTrainingJob">REST API Reference for StopTrainingJob Operation</seealso>
        StopTrainingJobResponse StopTrainingJob(StopTrainingJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopTrainingJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopTrainingJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopTrainingJob">REST API Reference for StopTrainingJob Operation</seealso>
        IAsyncResult BeginStopTrainingJob(StopTrainingJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopTrainingJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopTrainingJob.</param>
        /// 
        /// <returns>Returns a  StopTrainingJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopTrainingJob">REST API Reference for StopTrainingJob Operation</seealso>
        StopTrainingJobResponse EndStopTrainingJob(IAsyncResult asyncResult);

        #endregion
        
        #region  StopTransformJob


        /// <summary>
        /// Stops a transform job.
        /// 
        ///  
        /// <para>
        /// When Amazon SageMaker receives a <code>StopTransformJob</code> request, the status
        /// of the job changes to <code>Stopping</code>. After Amazon SageMaker stops the job,
        /// the status is set to <code>Stopped</code>. When you stop a transform job before it
        /// is completed, Amazon SageMaker doesn't store the job's output in Amazon S3.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopTransformJob service method.</param>
        /// 
        /// <returns>The response from the StopTransformJob service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceNotFoundException">
        /// Resource being access is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopTransformJob">REST API Reference for StopTransformJob Operation</seealso>
        StopTransformJobResponse StopTransformJob(StopTransformJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopTransformJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopTransformJob operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopTransformJob
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopTransformJob">REST API Reference for StopTransformJob Operation</seealso>
        IAsyncResult BeginStopTransformJob(StopTransformJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopTransformJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopTransformJob.</param>
        /// 
        /// <returns>Returns a  StopTransformJobResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/StopTransformJob">REST API Reference for StopTransformJob Operation</seealso>
        StopTransformJobResponse EndStopTransformJob(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateCodeRepository


        /// <summary>
        /// Updates the specified Git repository with the specified values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCodeRepository service method.</param>
        /// 
        /// <returns>The response from the UpdateCodeRepository service method, as returned by SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateCodeRepository">REST API Reference for UpdateCodeRepository Operation</seealso>
        UpdateCodeRepositoryResponse UpdateCodeRepository(UpdateCodeRepositoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCodeRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCodeRepository operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCodeRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateCodeRepository">REST API Reference for UpdateCodeRepository Operation</seealso>
        IAsyncResult BeginUpdateCodeRepository(UpdateCodeRepositoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCodeRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCodeRepository.</param>
        /// 
        /// <returns>Returns a  UpdateCodeRepositoryResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateCodeRepository">REST API Reference for UpdateCodeRepository Operation</seealso>
        UpdateCodeRepositoryResponse EndUpdateCodeRepository(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEndpoint


        /// <summary>
        /// Deploys the new <code>EndpointConfig</code> specified in the request, switches to
        /// using newly created endpoint, and then deletes resources provisioned for the endpoint
        /// using the previous <code>EndpointConfig</code> (there is no availability loss). 
        /// 
        ///  
        /// <para>
        /// When Amazon SageMaker receives the request, it sets the endpoint status to <code>Updating</code>.
        /// After updating the endpoint, it sets the status to <code>InService</code>. To check
        /// the status of an endpoint, use the <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/API_DescribeEndpoint.html">DescribeEndpoint</a>
        /// API. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You cannot update an endpoint with the current <code>EndpointConfig</code>. To update
        /// an endpoint, you must create a new <code>EndpointConfig</code>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpoint service method.</param>
        /// 
        /// <returns>The response from the UpdateEndpoint service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateEndpoint">REST API Reference for UpdateEndpoint Operation</seealso>
        UpdateEndpointResponse UpdateEndpoint(UpdateEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpoint operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateEndpoint">REST API Reference for UpdateEndpoint Operation</seealso>
        IAsyncResult BeginUpdateEndpoint(UpdateEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEndpoint.</param>
        /// 
        /// <returns>Returns a  UpdateEndpointResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateEndpoint">REST API Reference for UpdateEndpoint Operation</seealso>
        UpdateEndpointResponse EndUpdateEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateEndpointWeightsAndCapacities


        /// <summary>
        /// Updates variant weight of one or more variants associated with an existing endpoint,
        /// or capacity of one variant associated with an existing endpoint. When it receives
        /// the request, Amazon SageMaker sets the endpoint status to <code>Updating</code>. After
        /// updating the endpoint, it sets the status to <code>InService</code>. To check the
        /// status of an endpoint, use the <a href="http://docs.aws.amazon.com/sagemaker/latest/dg/API_DescribeEndpoint.html">DescribeEndpoint</a>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointWeightsAndCapacities service method.</param>
        /// 
        /// <returns>The response from the UpdateEndpointWeightsAndCapacities service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateEndpointWeightsAndCapacities">REST API Reference for UpdateEndpointWeightsAndCapacities Operation</seealso>
        UpdateEndpointWeightsAndCapacitiesResponse UpdateEndpointWeightsAndCapacities(UpdateEndpointWeightsAndCapacitiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEndpointWeightsAndCapacities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEndpointWeightsAndCapacities operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEndpointWeightsAndCapacities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateEndpointWeightsAndCapacities">REST API Reference for UpdateEndpointWeightsAndCapacities Operation</seealso>
        IAsyncResult BeginUpdateEndpointWeightsAndCapacities(UpdateEndpointWeightsAndCapacitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEndpointWeightsAndCapacities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEndpointWeightsAndCapacities.</param>
        /// 
        /// <returns>Returns a  UpdateEndpointWeightsAndCapacitiesResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateEndpointWeightsAndCapacities">REST API Reference for UpdateEndpointWeightsAndCapacities Operation</seealso>
        UpdateEndpointWeightsAndCapacitiesResponse EndUpdateEndpointWeightsAndCapacities(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateNotebookInstance


        /// <summary>
        /// Updates a notebook instance. NotebookInstance updates include upgrading or downgrading
        /// the ML compute instance used for your notebook instance to accommodate changes in
        /// your workload requirements. You can also update the VPC security groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotebookInstance service method.</param>
        /// 
        /// <returns>The response from the UpdateNotebookInstance service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateNotebookInstance">REST API Reference for UpdateNotebookInstance Operation</seealso>
        UpdateNotebookInstanceResponse UpdateNotebookInstance(UpdateNotebookInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotebookInstance operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNotebookInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateNotebookInstance">REST API Reference for UpdateNotebookInstance Operation</seealso>
        IAsyncResult BeginUpdateNotebookInstance(UpdateNotebookInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNotebookInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNotebookInstance.</param>
        /// 
        /// <returns>Returns a  UpdateNotebookInstanceResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateNotebookInstance">REST API Reference for UpdateNotebookInstance Operation</seealso>
        UpdateNotebookInstanceResponse EndUpdateNotebookInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateNotebookInstanceLifecycleConfig


        /// <summary>
        /// Updates a notebook instance lifecycle configuration created with the <a>CreateNotebookInstanceLifecycleConfig</a>
        /// API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotebookInstanceLifecycleConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateNotebookInstanceLifecycleConfig service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateNotebookInstanceLifecycleConfig">REST API Reference for UpdateNotebookInstanceLifecycleConfig Operation</seealso>
        UpdateNotebookInstanceLifecycleConfigResponse UpdateNotebookInstanceLifecycleConfig(UpdateNotebookInstanceLifecycleConfigRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNotebookInstanceLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotebookInstanceLifecycleConfig operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNotebookInstanceLifecycleConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateNotebookInstanceLifecycleConfig">REST API Reference for UpdateNotebookInstanceLifecycleConfig Operation</seealso>
        IAsyncResult BeginUpdateNotebookInstanceLifecycleConfig(UpdateNotebookInstanceLifecycleConfigRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNotebookInstanceLifecycleConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNotebookInstanceLifecycleConfig.</param>
        /// 
        /// <returns>Returns a  UpdateNotebookInstanceLifecycleConfigResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateNotebookInstanceLifecycleConfig">REST API Reference for UpdateNotebookInstanceLifecycleConfig Operation</seealso>
        UpdateNotebookInstanceLifecycleConfigResponse EndUpdateNotebookInstanceLifecycleConfig(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateWorkteam


        /// <summary>
        /// Updates an existing work team with new member definitions or description.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkteam service method.</param>
        /// 
        /// <returns>The response from the UpdateWorkteam service method, as returned by SageMaker.</returns>
        /// <exception cref="Amazon.SageMaker.Model.ResourceLimitExceededException">
        /// You have exceeded an Amazon SageMaker resource limit. For example, you might have
        /// too many training jobs created.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateWorkteam">REST API Reference for UpdateWorkteam Operation</seealso>
        UpdateWorkteamResponse UpdateWorkteam(UpdateWorkteamRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateWorkteam operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateWorkteam operation on AmazonSageMakerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateWorkteam
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateWorkteam">REST API Reference for UpdateWorkteam Operation</seealso>
        IAsyncResult BeginUpdateWorkteam(UpdateWorkteamRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateWorkteam operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateWorkteam.</param>
        /// 
        /// <returns>Returns a  UpdateWorkteamResult from SageMaker.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sagemaker-2017-07-24/UpdateWorkteam">REST API Reference for UpdateWorkteam Operation</seealso>
        UpdateWorkteamResponse EndUpdateWorkteam(IAsyncResult asyncResult);

        #endregion
        
    }
}