// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Sub-protection policy which includes schedule and retention
    /// </summary>
    public partial class SubProtectionPolicy
    {
        /// <summary>
        /// Initializes a new instance of the SubProtectionPolicy class.
        /// </summary>
        public SubProtectionPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubProtectionPolicy class.
        /// </summary>
        /// <param name="policyType">Type of backup policy type</param>
        /// <param name="schedulePolicy">Backup schedule specified as part of
        /// backup policy.</param>
        /// <param name="retentionPolicy">Retention policy with the details on
        /// backup copy retention ranges.</param>
        public SubProtectionPolicy(string policyType = default(string), SchedulePolicy schedulePolicy = default(SchedulePolicy), RetentionPolicy retentionPolicy = default(RetentionPolicy))
        {
            PolicyType = policyType;
            SchedulePolicy = schedulePolicy;
            RetentionPolicy = retentionPolicy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets type of backup policy type
        /// </summary>
        [JsonProperty(PropertyName = "policyType")]
        public string PolicyType { get; set; }

        /// <summary>
        /// Gets or sets backup schedule specified as part of backup policy.
        /// </summary>
        [JsonProperty(PropertyName = "schedulePolicy")]
        public SchedulePolicy SchedulePolicy { get; set; }

        /// <summary>
        /// Gets or sets retention policy with the details on backup copy
        /// retention ranges.
        /// </summary>
        [JsonProperty(PropertyName = "retentionPolicy")]
        public RetentionPolicy RetentionPolicy { get; set; }

    }
}
