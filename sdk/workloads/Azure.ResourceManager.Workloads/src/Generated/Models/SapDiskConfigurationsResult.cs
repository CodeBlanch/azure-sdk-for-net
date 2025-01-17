// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The list of disk configuration for vmSku which are part of SAP deployment. </summary>
    public partial class SapDiskConfigurationsResult
    {
        /// <summary> Initializes a new instance of SapDiskConfigurationsResult. </summary>
        internal SapDiskConfigurationsResult()
        {
            DiskConfigurations = new ChangeTrackingList<SapDiskConfiguration>();
        }

        /// <summary> Initializes a new instance of SapDiskConfigurationsResult. </summary>
        /// <param name="diskConfigurations"> Gets the list of Disk Configurations. </param>
        internal SapDiskConfigurationsResult(IReadOnlyList<SapDiskConfiguration> diskConfigurations)
        {
            DiskConfigurations = diskConfigurations;
        }

        /// <summary> Gets the list of Disk Configurations. </summary>
        public IReadOnlyList<SapDiskConfiguration> DiskConfigurations { get; }
    }
}
