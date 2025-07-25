// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.ManagedServiceIdentities
{
    /// <summary>
    /// A Class representing a SystemAssignedIdentity along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="SystemAssignedIdentityResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetSystemAssignedIdentityResource method.
    /// Otherwise you can get one from its parent resource <see cref="ArmResource"/> using the GetSystemAssignedIdentity method.
    /// </summary>
    public partial class SystemAssignedIdentityResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SystemAssignedIdentityResource"/> instance. </summary>
        /// <param name="scope"> The scope. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string scope)
        {
            var resourceId = $"{scope}/providers/Microsoft.ManagedIdentity/identities/default";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _systemAssignedIdentityClientDiagnostics;
        private readonly SystemAssignedIdentitiesRestOperations _systemAssignedIdentityRestClient;
        private readonly SystemAssignedIdentityData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ManagedIdentity/identities";

        /// <summary> Initializes a new instance of the <see cref="SystemAssignedIdentityResource"/> class for mocking. </summary>
        protected SystemAssignedIdentityResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SystemAssignedIdentityResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SystemAssignedIdentityResource(ArmClient client, SystemAssignedIdentityData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SystemAssignedIdentityResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SystemAssignedIdentityResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _systemAssignedIdentityClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedServiceIdentities", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string systemAssignedIdentityApiVersion);
            _systemAssignedIdentityRestClient = new SystemAssignedIdentitiesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, systemAssignedIdentityApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SystemAssignedIdentityData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the systemAssignedIdentity available under the specified RP scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedIdentity/identities/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SystemAssignedIdentities_GetByScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-30</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SystemAssignedIdentityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SystemAssignedIdentityResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _systemAssignedIdentityClientDiagnostics.CreateScope("SystemAssignedIdentityResource.Get");
            scope.Start();
            try
            {
                var response = await _systemAssignedIdentityRestClient.GetByScopeAsync(Id.Parent, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SystemAssignedIdentityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the systemAssignedIdentity available under the specified RP scope.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/{scope}/providers/Microsoft.ManagedIdentity/identities/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SystemAssignedIdentities_GetByScope</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-11-30</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="SystemAssignedIdentityResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SystemAssignedIdentityResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _systemAssignedIdentityClientDiagnostics.CreateScope("SystemAssignedIdentityResource.Get");
            scope.Start();
            try
            {
                var response = _systemAssignedIdentityRestClient.GetByScope(Id.Parent, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SystemAssignedIdentityResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
