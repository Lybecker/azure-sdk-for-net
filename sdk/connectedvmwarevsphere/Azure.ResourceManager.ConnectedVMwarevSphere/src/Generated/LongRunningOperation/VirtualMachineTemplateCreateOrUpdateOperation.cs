// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.ConnectedVMwarevSphere;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    /// <summary> Create Or Update virtual machine template. </summary>
    public partial class VirtualMachineTemplateCreateOrUpdateOperation : Operation<VirtualMachineTemplate>, IOperationSource<VirtualMachineTemplate>
    {
        private readonly OperationInternals<VirtualMachineTemplate> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of VirtualMachineTemplateCreateOrUpdateOperation for mocking. </summary>
        protected VirtualMachineTemplateCreateOrUpdateOperation()
        {
        }

        internal VirtualMachineTemplateCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<VirtualMachineTemplate>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "VirtualMachineTemplateCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override VirtualMachineTemplate Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VirtualMachineTemplate>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VirtualMachineTemplate>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        VirtualMachineTemplate IOperationSource<VirtualMachineTemplate>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = VirtualMachineTemplateData.DeserializeVirtualMachineTemplateData(document.RootElement);
            return new VirtualMachineTemplate(_operationBase, data);
        }

        async ValueTask<VirtualMachineTemplate> IOperationSource<VirtualMachineTemplate>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = VirtualMachineTemplateData.DeserializeVirtualMachineTemplateData(document.RootElement);
            return new VirtualMachineTemplate(_operationBase, data);
        }
    }
}
