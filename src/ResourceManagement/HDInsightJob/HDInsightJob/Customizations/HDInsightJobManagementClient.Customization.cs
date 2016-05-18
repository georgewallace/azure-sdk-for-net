// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Globalization;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using Hyak.Common;
using Hyak.Common.TransientFaultHandling;

namespace Microsoft.Azure.Management.HDInsight.Job
{
    /// <summary>
    /// The HDInsight job client manages jobs against HDInsight clusters.
    /// </summary>
    public partial class HDInsightJobManagementClient : ServiceClient<HDInsightJobManagementClient>, IHDInsightJobManagementClient
    {
        private static readonly TimeSpan MinBackOff = TimeSpan.FromMinutes(0);
        private static readonly TimeSpan MaxBackOff = TimeSpan.FromMinutes(8);
        private const int RetryCount = 5;
        private static readonly TimeSpan DeltaBackOff = TimeSpan.FromMinutes(1);

        private static string SdkVersion = ".Net " + FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;

        /// <summary>
        /// Gets the recommended Retry Policy for the HDInsight Management Client.
        /// </summary>
        public static RetryPolicy HDInsightRetryPolicy
        {
            get
            {
                return new RetryPolicy(new DefaultHttpErrorDetectionStrategy(),
                    RetryCount, MinBackOff,
                    MaxBackOff, DeltaBackOff);
            }
        }

        /// <summary>
        /// Initializes a new instance of the HDInsightJobManagementClient
        /// class.
        /// </summary>
        /// <param name='clusterDnsName'>
        /// Required. The cluster dns name against which the job management is
        /// to be performed.
        /// </param>
        /// <param name='credentials'>
        /// Required. Basic authentication credentials for job submission.
        /// </param>
        /// <param name='retryPolicy'>
        /// Optional. Retry Policy for Http Transient errors.
        /// </param>
        public HDInsightJobManagementClient(string clusterDnsName, BasicAuthenticationCloudCredentials credentials, RetryPolicy retryPolicy = null)
            : this(clusterDnsName, credentials)
        {
            if (retryPolicy == null)
            {
                // If No retry policy is provided then use default retry policy
                retryPolicy = HDInsightJobManagementClient.HDInsightRetryPolicy;
                this.HttpClient.Timeout = MaxBackOff;
            }

            this.SetRetryPolicy(retryPolicy);
        }
    }
}
