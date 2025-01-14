// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of VnetGateway and their operations over its parent. </summary>
    public partial class ServerfarmVirtualNetworkConnectionGatewayCollection : ArmCollection
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly AppServicePlansRestOperations _appServicePlansRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServerfarmVirtualNetworkConnectionGatewayCollection"/> class for mocking. </summary>
        protected ServerfarmVirtualNetworkConnectionGatewayCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServerfarmVirtualNetworkConnectionGatewayCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ServerfarmVirtualNetworkConnectionGatewayCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(ServerfarmVirtualNetworkConnectionGateway.ResourceType, out string apiVersion);
            _appServicePlansRestClient = new AppServicePlansRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServerfarmVirtualNetworkConnection.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServerfarmVirtualNetworkConnection.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// OperationId: AppServicePlans_UpdateVnetGateway
        /// <summary> Description for Update a Virtual Network gateway. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="gatewayName"> Name of the gateway. Only the &apos;primary&apos; gateway is supported. </param>
        /// <param name="connectionEnvelope"> Definition of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> or <paramref name="connectionEnvelope"/> is null. </exception>
        public virtual ServerfarmVirtualNetworkConnectionGatewayCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string gatewayName, VnetGatewayData connectionEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));
            if (connectionEnvelope == null)
            {
                throw new ArgumentNullException(nameof(connectionEnvelope));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionGatewayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appServicePlansRestClient.UpdateVnetGateway(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gatewayName, connectionEnvelope, cancellationToken);
                var operation = new ServerfarmVirtualNetworkConnectionGatewayCreateOrUpdateOperation(this, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// OperationId: AppServicePlans_UpdateVnetGateway
        /// <summary> Description for Update a Virtual Network gateway. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="gatewayName"> Name of the gateway. Only the &apos;primary&apos; gateway is supported. </param>
        /// <param name="connectionEnvelope"> Definition of the gateway. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> or <paramref name="connectionEnvelope"/> is null. </exception>
        public async virtual Task<ServerfarmVirtualNetworkConnectionGatewayCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string gatewayName, VnetGatewayData connectionEnvelope, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));
            if (connectionEnvelope == null)
            {
                throw new ArgumentNullException(nameof(connectionEnvelope));
            }

            using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionGatewayCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appServicePlansRestClient.UpdateVnetGatewayAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gatewayName, connectionEnvelope, cancellationToken).ConfigureAwait(false);
                var operation = new ServerfarmVirtualNetworkConnectionGatewayCreateOrUpdateOperation(this, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// OperationId: AppServicePlans_GetVnetGateway
        /// <summary> Description for Get a Virtual Network gateway. </summary>
        /// <param name="gatewayName"> Name of the gateway. Only the &apos;primary&apos; gateway is supported. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual Response<ServerfarmVirtualNetworkConnectionGateway> Get(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = _appServicePlansRestClient.GetVnetGateway(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gatewayName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServerfarmVirtualNetworkConnectionGateway(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}/gateways/{gatewayName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/serverfarms/{name}/virtualNetworkConnections/{vnetName}
        /// OperationId: AppServicePlans_GetVnetGateway
        /// <summary> Description for Get a Virtual Network gateway. </summary>
        /// <param name="gatewayName"> Name of the gateway. Only the &apos;primary&apos; gateway is supported. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public async virtual Task<Response<ServerfarmVirtualNetworkConnectionGateway>> GetAsync(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionGatewayCollection.Get");
            scope.Start();
            try
            {
                var response = await _appServicePlansRestClient.GetVnetGatewayAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gatewayName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ServerfarmVirtualNetworkConnectionGateway(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="gatewayName"> Name of the gateway. Only the &apos;primary&apos; gateway is supported. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual Response<ServerfarmVirtualNetworkConnectionGateway> GetIfExists(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionGatewayCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _appServicePlansRestClient.GetVnetGateway(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gatewayName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ServerfarmVirtualNetworkConnectionGateway>(null, response.GetRawResponse());
                return Response.FromValue(new ServerfarmVirtualNetworkConnectionGateway(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="gatewayName"> Name of the gateway. Only the &apos;primary&apos; gateway is supported. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public async virtual Task<Response<ServerfarmVirtualNetworkConnectionGateway>> GetIfExistsAsync(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionGatewayCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _appServicePlansRestClient.GetVnetGatewayAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, gatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ServerfarmVirtualNetworkConnectionGateway>(null, response.GetRawResponse());
                return Response.FromValue(new ServerfarmVirtualNetworkConnectionGateway(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="gatewayName"> Name of the gateway. Only the &apos;primary&apos; gateway is supported. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public virtual Response<bool> Exists(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(gatewayName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="gatewayName"> Name of the gateway. Only the &apos;primary&apos; gateway is supported. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="gatewayName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="gatewayName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string gatewayName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(gatewayName, nameof(gatewayName));

            using var scope = _clientDiagnostics.CreateScope("ServerfarmVirtualNetworkConnectionGatewayCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(gatewayName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, ServerfarmVirtualNetworkConnectionGateway, VnetGatewayData> Construct() { }
    }
}
