/*
 * SPDX-FileCopyrightText: Bosch Rexroth AG
 *
 * SPDX-License-Identifier: MIT
 */

using Datalayer;

namespace Samples.Datalayer.Provider.Alldata
{
    using System;

    /// <summary>
    /// ReadOnlyNodeHandler provides handler with read-only support.
    /// </summary>
    internal class ReadOnlyNodeHandler : IProviderNodeHandler
    {
        /// <summary>
        /// Gets the Node.
        /// </summary>
        public Node Node { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadOnlyNodeHandler"/> class.
        /// </summary>
        /// <param name="node">The node<see cref="Node"/>.</param>
        public ReadOnlyNodeHandler(Node node)
        {
            Node = node;
        }

        /// <summary>
        /// The OnCreate callback handler.
        /// </summary>
        /// <param name="address">The address<see cref="string"/>.</param>
        /// <param name="args">The args<see cref="IVariant"/>.</param>
        /// <param name="result">The result<see cref="IProviderNodeResult"/>.</param>
        public void OnCreate(string address, IVariant args, IProviderNodeResult result)
        {
            Console.WriteLine($"OnCreate {address}");
            result.SetResult(DLR_RESULT.DL_UNSUPPORTED);
        }

        /// <summary>
        /// The OnRemove callback handler..
        /// </summary>
        /// <param name="address">The address<see cref="string"/>.</param>
        /// <param name="result">The result<see cref="IProviderNodeResult"/>.</param>
        public void OnRemove(string address, IProviderNodeResult result)
        {
            Console.WriteLine($"OnRemove {address}");
            result.SetResult(DLR_RESULT.DL_UNSUPPORTED);
        }

        /// <summary>
        /// The OnBrowse callback handler.
        /// </summary>
        /// <param name="address">The address<see cref="string"/>.</param>
        /// <param name="result">The result<see cref="IProviderNodeResult"/>.</param>
        public void OnBrowse(string address, IProviderNodeResult result)
        {
            Console.WriteLine($"OnBrowse {address}");
            result.SetResult(DLR_RESULT.DL_UNSUPPORTED);
        }

        /// <summary>
        /// The OnRead callback handler..
        /// </summary>
        /// <param name="address">The address<see cref="string"/>.</param>
        /// <param name="args">The args<see cref="IVariant"/>.</param>
        /// <param name="result">The result<see cref="IProviderNodeResult"/>.</param>
        public void OnRead(string address, IVariant args, IProviderNodeResult result)
        {
            Console.WriteLine($"OnRead {address}: {args}");
            result.SetResult(DLR_RESULT.DL_OK, Node.Value);
        }

        /// <summary>
        /// The OnWrite callback handler..
        /// </summary>
        /// <param name="address">The address<see cref="string"/>.</param>
        /// <param name="writeValue">The writeValue<see cref="IVariant"/>.</param>
        /// <param name="result">The result<see cref="IProviderNodeResult"/>.</param>
        public void OnWrite(string address, IVariant writeValue, IProviderNodeResult result)
        {
            Console.WriteLine($"OnWrite {address}: {writeValue}");
            result.SetResult(DLR_RESULT.DL_UNSUPPORTED);
        }

        /// <summary>
        /// The OnMetadata callback handler..
        /// </summary>
        /// <param name="address">The address<see cref="string"/>.</param>
        /// <param name="result">The result<see cref="IProviderNodeResult"/>.</param>
        public void OnMetadata(string address, IProviderNodeResult result)
        {
            Console.WriteLine($"OnMetadata {address}");
            result.SetResult(DLR_RESULT.DL_OK, Node.Metadata);
        }
    }
}
