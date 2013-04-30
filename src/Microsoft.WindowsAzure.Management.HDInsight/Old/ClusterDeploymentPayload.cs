﻿// Copyright (c) Microsoft Corporation
// All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License"); you may not
// use this file except in compliance with the License.  You may obtain a copy
// of the License at http://www.apache.org/licenses/LICENSE-2.0
// 
// THIS CODE IS PROVIDED *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY IMPLIED
// WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE,
// MERCHANTABLITY OR NON-INFRINGEMENT.
// 
// See the Apache Version 2.0 License for specific language governing
// permissions and limitations under the License.

namespace Microsoft.WindowsAzure.Management.HDInsight.Old
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;

    [DataContract(Name = "ClusterDeployment",
        Namespace = "http://schemas.datacontract.org/2004/07/Microsoft.ClusterServices.DataAccess.Context")]
    internal class ClusterDeploymentPayload : Payload
    {
        [DataMember(EmitDefaultValue = false)]
        internal int Id { get; set; }

        [DataMember(EmitDefaultValue = false)]
        internal string ClusterUsername { get; set; }

        [DataMember(EmitDefaultValue = false)]
        internal string ClusterPassword { get; set; }

        [DataMember(EmitDefaultValue = false, IsRequired = true)]
        internal List<ASVAccountPayload> ASVAccounts { get; set; }

        [DataMember(EmitDefaultValue = false, IsRequired = true)]
        internal List<ClusterNodeSizePayload> NodeSizes { get; set; }

        [DataMember(EmitDefaultValue = false, IsRequired = false)]
        public List<SqlAzureMetaStorePayload> SqlMetaStores { get; set; }

        [DataMember(EmitDefaultValue = false)]
        internal string Version { get; set; }

        /// <summary>
        ///     Default HDInsight version.
        /// </summary>
        internal const string DEFAULTVERSION = "default";

        public ClusterDeploymentPayload()
        {
            this.ASVAccounts = new List<ASVAccountPayload>();
            this.NodeSizes = new List<ClusterNodeSizePayload>();
            this.SqlMetaStores = new List<SqlAzureMetaStorePayload>();
        }
    }
}