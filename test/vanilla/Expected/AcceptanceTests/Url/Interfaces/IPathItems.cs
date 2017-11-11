// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

namespace Fixtures.AcceptanceTestsUrl
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// PathItems operations.
    /// </summary>
    public partial interface IPathItems
    {
        IPathItemsWithHttpMessages WithHttpMessages();

        /// <summary>
        /// send globalStringPath='globalStringPath', pathItemStringPath='pathItemStringPath',
        /// localStringPath='localStringPath', globalStringQuery='globalStringQuery',
        /// pathItemStringQuery='pathItemStringQuery', localStringQuery='localStringQuery'
        /// </summary>
        /// <param name='localStringPath'>
        /// should contain value 'localStringPath'
        /// </param>
        /// <param name='pathItemStringPath'>
        /// A string value 'pathItemStringPath' that appears in the path
        /// </param>
        /// <param name='localStringQuery'>
        /// should contain value 'localStringQuery'
        /// </param>
        /// <param name='pathItemStringQuery'>
        /// A string value 'pathItemStringQuery' that appears as a query parameter
        /// </param>
        void GetAllWithValues(string localStringPath, string pathItemStringPath, string localStringQuery = default(string), string pathItemStringQuery = default(string));

        /// <summary>
        /// send globalStringPath='globalStringPath', pathItemStringPath='pathItemStringPath',
        /// localStringPath='localStringPath', globalStringQuery='globalStringQuery',
        /// pathItemStringQuery='pathItemStringQuery', localStringQuery='localStringQuery'
        /// </summary>
        /// <param name='localStringPath'>
        /// should contain value 'localStringPath'
        /// </param>
        /// <param name='pathItemStringPath'>
        /// A string value 'pathItemStringPath' that appears in the path
        /// </param>
        /// <param name='localStringQuery'>
        /// should contain value 'localStringQuery'
        /// </param>
        /// <param name='pathItemStringQuery'>
        /// A string value 'pathItemStringQuery' that appears as a query parameter
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task GetAllWithValuesAsync(string localStringPath, string pathItemStringPath, string localStringQuery = default(string), string pathItemStringQuery = default(string), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// send globalStringPath='globalStringPath', pathItemStringPath='pathItemStringPath',
        /// localStringPath='localStringPath', globalStringQuery=null, pathItemStringQuery='pathItemStringQuery',
        /// localStringQuery='localStringQuery'
        /// </summary>
        /// <param name='localStringPath'>
        /// should contain value 'localStringPath'
        /// </param>
        /// <param name='pathItemStringPath'>
        /// A string value 'pathItemStringPath' that appears in the path
        /// </param>
        /// <param name='localStringQuery'>
        /// should contain value 'localStringQuery'
        /// </param>
        /// <param name='pathItemStringQuery'>
        /// A string value 'pathItemStringQuery' that appears as a query parameter
        /// </param>
        void GetGlobalQueryNull(string localStringPath, string pathItemStringPath, string localStringQuery = default(string), string pathItemStringQuery = default(string));

        /// <summary>
        /// send globalStringPath='globalStringPath', pathItemStringPath='pathItemStringPath',
        /// localStringPath='localStringPath', globalStringQuery=null, pathItemStringQuery='pathItemStringQuery',
        /// localStringQuery='localStringQuery'
        /// </summary>
        /// <param name='localStringPath'>
        /// should contain value 'localStringPath'
        /// </param>
        /// <param name='pathItemStringPath'>
        /// A string value 'pathItemStringPath' that appears in the path
        /// </param>
        /// <param name='localStringQuery'>
        /// should contain value 'localStringQuery'
        /// </param>
        /// <param name='pathItemStringQuery'>
        /// A string value 'pathItemStringQuery' that appears as a query parameter
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task GetGlobalQueryNullAsync(string localStringPath, string pathItemStringPath, string localStringQuery = default(string), string pathItemStringQuery = default(string), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// send globalStringPath=globalStringPath, pathItemStringPath='pathItemStringPath', localStringPath='localStringPath',
        /// globalStringQuery=null, pathItemStringQuery='pathItemStringQuery', localStringQuery=null
        /// </summary>
        /// <param name='localStringPath'>
        /// should contain value 'localStringPath'
        /// </param>
        /// <param name='pathItemStringPath'>
        /// A string value 'pathItemStringPath' that appears in the path
        /// </param>
        /// <param name='localStringQuery'>
        /// should contain null value
        /// </param>
        /// <param name='pathItemStringQuery'>
        /// A string value 'pathItemStringQuery' that appears as a query parameter
        /// </param>
        void GetGlobalAndLocalQueryNull(string localStringPath, string pathItemStringPath, string localStringQuery = default(string), string pathItemStringQuery = default(string));

        /// <summary>
        /// send globalStringPath=globalStringPath, pathItemStringPath='pathItemStringPath', localStringPath='localStringPath',
        /// globalStringQuery=null, pathItemStringQuery='pathItemStringQuery', localStringQuery=null
        /// </summary>
        /// <param name='localStringPath'>
        /// should contain value 'localStringPath'
        /// </param>
        /// <param name='pathItemStringPath'>
        /// A string value 'pathItemStringPath' that appears in the path
        /// </param>
        /// <param name='localStringQuery'>
        /// should contain null value
        /// </param>
        /// <param name='pathItemStringQuery'>
        /// A string value 'pathItemStringQuery' that appears as a query parameter
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task GetGlobalAndLocalQueryNullAsync(string localStringPath, string pathItemStringPath, string localStringQuery = default(string), string pathItemStringQuery = default(string), CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// send globalStringPath='globalStringPath', pathItemStringPath='pathItemStringPath',
        /// localStringPath='localStringPath', globalStringQuery='globalStringQuery', pathItemStringQuery=null,
        /// localStringQuery=null
        /// </summary>
        /// <param name='localStringPath'>
        /// should contain value 'localStringPath'
        /// </param>
        /// <param name='pathItemStringPath'>
        /// A string value 'pathItemStringPath' that appears in the path
        /// </param>
        /// <param name='localStringQuery'>
        /// should contain value null
        /// </param>
        /// <param name='pathItemStringQuery'>
        /// should contain value null
        /// </param>
        void GetLocalPathItemQueryNull(string localStringPath, string pathItemStringPath, string localStringQuery = default(string), string pathItemStringQuery = default(string));

        /// <summary>
        /// send globalStringPath='globalStringPath', pathItemStringPath='pathItemStringPath',
        /// localStringPath='localStringPath', globalStringQuery='globalStringQuery', pathItemStringQuery=null,
        /// localStringQuery=null
        /// </summary>
        /// <param name='localStringPath'>
        /// should contain value 'localStringPath'
        /// </param>
        /// <param name='pathItemStringPath'>
        /// A string value 'pathItemStringPath' that appears in the path
        /// </param>
        /// <param name='localStringQuery'>
        /// should contain value null
        /// </param>
        /// <param name='pathItemStringQuery'>
        /// should contain value null
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task GetLocalPathItemQueryNullAsync(string localStringPath, string pathItemStringPath, string localStringQuery = default(string), string pathItemStringQuery = default(string), CancellationToken cancellationToken = default(CancellationToken));
    }
}