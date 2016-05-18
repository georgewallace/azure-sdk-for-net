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
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Management.RecoveryServices.Backup;
using Microsoft.Azure.Management.RecoveryServices.Backup.Models;

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    public static partial class BackupEngineOperationsExtensions
    {
        /// <summary>
        /// Lists all the backup engines registered to your Recovery Services
        /// Vault based on the query parameters and the pagination parameters
        /// passed in the arguments.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IBackupEngineOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name of your recovery services vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. Name of your recovery services vault.
        /// </param>
        /// <param name='queryParams'>
        /// Required. Query parameters for listing backup engines.
        /// </param>
        /// <param name='paginationParams'>
        /// Optional. Pagination parameters for controlling the response.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. Request header parameters.
        /// </param>
        /// <returns>
        /// Response returned by the list backup engines operation.
        /// </returns>
        public static BackupEngineListResponse List(this IBackupEngineOperations operations, string resourceGroupName, string resourceName, BackupEngineListQueryParams queryParams, PaginationRequest paginationParams, CustomRequestHeaders customRequestHeaders)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IBackupEngineOperations)s).ListAsync(resourceGroupName, resourceName, queryParams, paginationParams, customRequestHeaders);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Lists all the backup engines registered to your Recovery Services
        /// Vault based on the query parameters and the pagination parameters
        /// passed in the arguments.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.RecoveryServices.Backup.IBackupEngineOperations.
        /// </param>
        /// <param name='resourceGroupName'>
        /// Required. Resource group name of your recovery services vault.
        /// </param>
        /// <param name='resourceName'>
        /// Required. Name of your recovery services vault.
        /// </param>
        /// <param name='queryParams'>
        /// Required. Query parameters for listing backup engines.
        /// </param>
        /// <param name='paginationParams'>
        /// Optional. Pagination parameters for controlling the response.
        /// </param>
        /// <param name='customRequestHeaders'>
        /// Required. Request header parameters.
        /// </param>
        /// <returns>
        /// Response returned by the list backup engines operation.
        /// </returns>
        public static Task<BackupEngineListResponse> ListAsync(this IBackupEngineOperations operations, string resourceGroupName, string resourceName, BackupEngineListQueryParams queryParams, PaginationRequest paginationParams, CustomRequestHeaders customRequestHeaders)
        {
            return operations.ListAsync(resourceGroupName, resourceName, queryParams, paginationParams, customRequestHeaders, CancellationToken.None);
        }
    }
}
