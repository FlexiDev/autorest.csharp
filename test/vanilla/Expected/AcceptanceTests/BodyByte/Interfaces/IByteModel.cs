// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.AcceptanceTestsBodyByte
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// ByteModel operations.
    /// </summary>
    public partial interface IByteModel
    {
        IByteModelWithHttpMessages WithHttpMessages();

        /// <summary>
        /// Get null byte value
        /// </summary>
        byte[] GetNull();

        /// <summary>
        /// Get null byte value
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<byte[]> GetNullAsync(CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get empty byte value ''
        /// </summary>
        byte[] GetEmpty();

        /// <summary>
        /// Get empty byte value ''
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<byte[]> GetEmptyAsync(CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get non-ascii byte string hex(FF FE FD FC FB FA F9 F8 F7 F6)
        /// </summary>
        byte[] GetNonAscii();

        /// <summary>
        /// Get non-ascii byte string hex(FF FE FD FC FB FA F9 F8 F7 F6)
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<byte[]> GetNonAsciiAsync(CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Put non-ascii byte string hex(FF FE FD FC FB FA F9 F8 F7 F6)
        /// </summary>
        /// <param name='byteBody'>
        /// Base64-encoded non-ascii byte string hex(FF FE FD FC FB FA F9 F8 F7 F6)
        /// </param>
        void PutNonAscii(byte[] byteBody);

        /// <summary>
        /// Put non-ascii byte string hex(FF FE FD FC FB FA F9 F8 F7 F6)
        /// </summary>
        /// <param name='byteBody'>
        /// Base64-encoded non-ascii byte string hex(FF FE FD FC FB FA F9 F8 F7 F6)
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task PutNonAsciiAsync(byte[] byteBody, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get invalid byte value ':::SWAGGER::::'
        /// </summary>
        byte[] GetInvalid();

        /// <summary>
        /// Get invalid byte value ':::SWAGGER::::'
        /// </summary>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<byte[]> GetInvalidAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}