/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Off-Sync.com. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using System.Collections.Generic;

namespace OffSync.Mapping.Practises
{
    public sealed partial class MappingContext
    {
        private readonly IDictionary<object, object> _mappings = new Dictionary<object, object>();

        public void AddMapping(
            object source,
            object target)
            => _mappings.Add(
                source,
                target);

        public bool TryGetMapping(
            object source,
            out object target)
            => _mappings.TryGetValue(
                source,
                out target);
    }
}
