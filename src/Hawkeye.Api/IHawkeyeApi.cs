﻿using System;

using Hawkeye.Api.Reflection;

namespace Hawkeye.Api
{
    /// <summary>
    /// Represents the Hawkeye API. To be used by plugins
    /// </summary>
    public interface IHawkeyeApi
    {
        /// <summary>
        /// Gets a reference to Hawkeye's main window.
        /// </summary>
        /// <value>The editor.</value>
        IHawkeyeEditor Editor { get; }

        /// <summary>
        /// Gets an instance of the Reflection API.
        /// </summary>
        /// <value>The reflection API.</value>
        IReflectionApi ReflectionApi { get; }
    }
}
