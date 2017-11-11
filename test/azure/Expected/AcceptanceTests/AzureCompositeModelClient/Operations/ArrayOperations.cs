// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.Azure.AcceptanceTestsAzureCompositeModelClient
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ArrayOperations operations.
    /// </summary>
    public partial class ArrayOperations : IArrayOperations
    {
        /// <summary>
        /// Initializes a new instance of the ArrayOperations class.
        /// </summary>
        /// <param name='operationsWithHttpMessages'>
        /// Reference to the low level operations
        /// </param>
        /// <exception cref='System.ArgumentNullException'>
        /// Thrown when a required parameter is null.
        /// </exception>
        public ArrayOperations(IArrayOperationsWithHttpMessages operationsWithHttpMessages)
        {
            if (operationsWithHttpMessages == null)
            {
                throw new System.ArgumentNullException(nameof(operationsWithHttpMessages));
            }
            OperationsWithHttpMessages = operationsWithHttpMessages;
        }

        private IArrayOperationsWithHttpMessages OperationsWithHttpMessages { get; set; }

        public IArrayOperationsWithHttpMessages WithHttpMessages()
        {
            return OperationsWithHttpMessages;
        }

        /// <summary>
        /// Get complex types with array property
        /// </summary>
        public ArrayWrapper GetValid()
        {
            return GetValidAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get complex types with array property
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<ArrayWrapper> GetValidAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetValidAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Put complex types with array property
        /// </summary>
        /// <param name='array'>
        /// </param>
        public void PutValid(IList<string> array = default(IList<string>))
        {
            PutValidAsync(array).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Put complex types with array property
        /// </summary>
        /// <param name='array'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task PutValidAsync(IList<string> array = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.PutValidAsync(array, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Get complex types with array property which is empty
        /// </summary>
        public ArrayWrapper GetEmpty()
        {
            return GetEmptyAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get complex types with array property which is empty
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<ArrayWrapper> GetEmptyAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetEmptyAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

        /// <summary>
        /// Put complex types with array property which is empty
        /// </summary>
        /// <param name='array'>
        /// </param>
        public void PutEmpty(IList<string> array = default(IList<string>))
        {
            PutEmptyAsync(array).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Put complex types with array property which is empty
        /// </summary>
        /// <param name='array'>
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task PutEmptyAsync(IList<string> array = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
        {
            (await OperationsWithHttpMessages.PutEmptyAsync(array, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }

        /// <summary>
        /// Get complex types with array property while server doesn't provide a response payload
        /// </summary>
        public ArrayWrapper GetNotProvided()
        {
            return GetNotProvidedAsync().GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get complex types with array property while server doesn't provide a response payload
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public async Task<ArrayWrapper> GetNotProvidedAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            using (var _result = await OperationsWithHttpMessages.GetNotProvidedAsync(null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }

    }
}