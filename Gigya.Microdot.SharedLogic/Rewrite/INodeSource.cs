﻿using System;
using System.Threading.Tasks;
using Gigya.Common.Contracts.Exceptions;

namespace Gigya.Microdot.SharedLogic.Rewrite
{
    /// <summary>
    /// A source which supplies updated list of available nodes for discovery of a specific service and environment
    /// </summary>
    public interface INodeSource 
    {
        /// <summary>
        /// Returns all nodes. Throws detailed exception if no nodes are available which includes the source's reason.
        /// </summary>
        /// <returns>A non-empty array of nodes.</returns>
        /// <exception cref="EnvironmentException">Thrown when no nodes are available, the service was undeployed or an error occurred.</exception>
        INode[] GetNodes();

        /// <summary>
        /// Returns true if the service was undeployed.
        /// </summary>
        bool WasUndeployed { get; }

        /// <summary>
        /// Whether this source supports services which are deployed on multiple environments
        /// </summary>
        bool SupportsMultipleEnvironments { get; }

        void Shutdown();
    }
}