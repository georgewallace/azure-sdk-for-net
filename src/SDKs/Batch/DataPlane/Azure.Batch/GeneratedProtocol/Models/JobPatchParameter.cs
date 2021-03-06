// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The set of changes to be made to a job.
    /// </summary>
    public partial class JobPatchParameter
    {
        /// <summary>
        /// Initializes a new instance of the JobPatchParameter class.
        /// </summary>
        public JobPatchParameter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobPatchParameter class.
        /// </summary>
        /// <param name="priority">The priority of the job.</param>
        /// <param name="onAllTasksComplete">The action the Batch service
        /// should take when all tasks in the job are in the completed
        /// state.</param>
        /// <param name="constraints">The execution constraints for the
        /// job.</param>
        /// <param name="poolInfo">The pool on which the Batch service runs the
        /// job's tasks.</param>
        /// <param name="metadata">A list of name-value pairs associated with
        /// the job as metadata.</param>
        public JobPatchParameter(int? priority = default(int?), OnAllTasksComplete? onAllTasksComplete = default(OnAllTasksComplete?), JobConstraints constraints = default(JobConstraints), PoolInformation poolInfo = default(PoolInformation), IList<MetadataItem> metadata = default(IList<MetadataItem>))
        {
            Priority = priority;
            OnAllTasksComplete = onAllTasksComplete;
            Constraints = constraints;
            PoolInfo = poolInfo;
            Metadata = metadata;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the priority of the job.
        /// </summary>
        /// <remarks>
        /// Priority values can range from -1000 to 1000, with -1000 being the
        /// lowest priority and 1000 being the highest priority. If omitted,
        /// the priority of the job is left unchanged.
        /// </remarks>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or sets the action the Batch service should take when all
        /// tasks in the job are in the completed state.
        /// </summary>
        /// <remarks>
        /// If omitted, the completion behavior is left unchanged. You may not
        /// change the value from terminatejob to noaction - that is, once you
        /// have engaged automatic job termination, you cannot turn it off
        /// again. If you try to do this, the request fails with an 'invalid
        /// property value' error response; if you are calling the REST API
        /// directly, the HTTP status code is 400 (Bad Request). Possible
        /// values include: 'noAction', 'terminateJob'
        /// </remarks>
        [JsonProperty(PropertyName = "onAllTasksComplete")]
        public OnAllTasksComplete? OnAllTasksComplete { get; set; }

        /// <summary>
        /// Gets or sets the execution constraints for the job.
        /// </summary>
        /// <remarks>
        /// If omitted, the existing execution constraints are left unchanged.
        /// </remarks>
        [JsonProperty(PropertyName = "constraints")]
        public JobConstraints Constraints { get; set; }

        /// <summary>
        /// Gets or sets the pool on which the Batch service runs the job's
        /// tasks.
        /// </summary>
        /// <remarks>
        /// You may change the pool for a job only when the job is disabled.
        /// The Patch Job call will fail if you include the poolInfo element
        /// and the job is not disabled. If you specify an
        /// autoPoolSpecification specification in the poolInfo, only the
        /// keepAlive property can be updated, and then only if the auto pool
        /// has a poolLifetimeOption of job. If omitted, the job continues to
        /// run on its current pool.
        /// </remarks>
        [JsonProperty(PropertyName = "poolInfo")]
        public PoolInformation PoolInfo { get; set; }

        /// <summary>
        /// Gets or sets a list of name-value pairs associated with the job as
        /// metadata.
        /// </summary>
        /// <remarks>
        /// If omitted, the existing job metadata is left unchanged.
        /// </remarks>
        [JsonProperty(PropertyName = "metadata")]
        public IList<MetadataItem> Metadata { get; set; }

    }
}
