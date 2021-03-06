// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataMigration.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Login level output for the task that validates connection to SQL Server
    /// and also validates source server requirements
    /// </summary>
    [Newtonsoft.Json.JsonObject("LoginLevelOutput")]
    public partial class ConnectToSourceSqlServerTaskOutputLoginLevel : ConnectToSourceSqlServerTaskOutput
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ConnectToSourceSqlServerTaskOutputLoginLevel class.
        /// </summary>
        public ConnectToSourceSqlServerTaskOutputLoginLevel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ConnectToSourceSqlServerTaskOutputLoginLevel class.
        /// </summary>
        /// <param name="id">Result identifier</param>
        /// <param name="name">Login name.</param>
        /// <param name="loginType">The type of login. Possible values include:
        /// 'WindowsUser', 'WindowsGroup', 'SqlLogin', 'Certificate',
        /// 'AsymmetricKey', 'ExternalUser', 'ExternalGroup'</param>
        /// <param name="defaultDatabase">The default database for the
        /// login.</param>
        /// <param name="isEnabled">The state of the login.</param>
        /// <param name="migrationEligibility">Information about eligiblity of
        /// login for migration.</param>
        public ConnectToSourceSqlServerTaskOutputLoginLevel(string id = default(string), string name = default(string), string loginType = default(string), string defaultDatabase = default(string), bool? isEnabled = default(bool?), MigrationEligibilityInfo migrationEligibility = default(MigrationEligibilityInfo))
            : base(id)
        {
            Name = name;
            LoginType = loginType;
            DefaultDatabase = defaultDatabase;
            IsEnabled = isEnabled;
            MigrationEligibility = migrationEligibility;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets login name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the type of login. Possible values include: 'WindowsUser',
        /// 'WindowsGroup', 'SqlLogin', 'Certificate', 'AsymmetricKey',
        /// 'ExternalUser', 'ExternalGroup'
        /// </summary>
        [JsonProperty(PropertyName = "loginType")]
        public string LoginType { get; private set; }

        /// <summary>
        /// Gets the default database for the login.
        /// </summary>
        [JsonProperty(PropertyName = "defaultDatabase")]
        public string DefaultDatabase { get; private set; }

        /// <summary>
        /// Gets the state of the login.
        /// </summary>
        [JsonProperty(PropertyName = "isEnabled")]
        public bool? IsEnabled { get; private set; }

        /// <summary>
        /// Gets information about eligiblity of login for migration.
        /// </summary>
        [JsonProperty(PropertyName = "migrationEligibility")]
        public MigrationEligibilityInfo MigrationEligibility { get; private set; }

    }
}
