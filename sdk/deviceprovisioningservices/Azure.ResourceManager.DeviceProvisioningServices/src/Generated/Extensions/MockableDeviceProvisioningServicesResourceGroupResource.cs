// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.DeviceProvisioningServices.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableDeviceProvisioningServicesResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableDeviceProvisioningServicesResourceGroupResource"/> class for mocking. </summary>
        protected MockableDeviceProvisioningServicesResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableDeviceProvisioningServicesResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableDeviceProvisioningServicesResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of DeviceProvisioningServiceResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of DeviceProvisioningServiceResources and their operations over a DeviceProvisioningServiceResource. </returns>
        public virtual DeviceProvisioningServiceCollection GetDeviceProvisioningServices()
        {
            return GetCachedClient(client => new DeviceProvisioningServiceCollection(client, Id));
        }

        /// <summary>
        /// Get the metadata of the provisioning service without SAS keys.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProvisioningServiceDescription_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceProvisioningServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="provisioningServiceName"> Name of the provisioning service to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="provisioningServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="provisioningServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<DeviceProvisioningServiceResource>> GetDeviceProvisioningServiceAsync(string provisioningServiceName, CancellationToken cancellationToken = default)
        {
            return await GetDeviceProvisioningServices().GetAsync(provisioningServiceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the metadata of the provisioning service without SAS keys.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Devices/provisioningServices/{provisioningServiceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProvisioningServiceDescription_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-02-01-preview</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="DeviceProvisioningServiceResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="provisioningServiceName"> Name of the provisioning service to retrieve. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="provisioningServiceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="provisioningServiceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<DeviceProvisioningServiceResource> GetDeviceProvisioningService(string provisioningServiceName, CancellationToken cancellationToken = default)
        {
            return GetDeviceProvisioningServices().Get(provisioningServiceName, cancellationToken);
        }
    }
}
