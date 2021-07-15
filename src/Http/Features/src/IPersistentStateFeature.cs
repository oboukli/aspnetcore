// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Microsoft.AspNetCore.Http.Features
{
    /// <summary>
    /// Provides access to a key/value collection that can be used to persist state between connections and requests.
    /// Whether a transport supports persisting state depends on the implementation. The transport must support
    /// pooling and reusing connection instances for state to be persisted.
    /// <para>
    /// Because values added to persistent state can live in memory until a connection is no longer pooled,
    /// use caution when adding items to this collection to avoid excessive memory use.
    /// </para>
    /// </summary>
    public interface IPersistentStateFeature
    {
        /// <summary>
        /// Gets a key/value collection that can be used to persist state between connections and requests.
        /// </summary>
        IDictionary<object, object?> State { get; }
    }
}
