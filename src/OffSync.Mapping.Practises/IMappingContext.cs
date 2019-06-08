/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Off-Sync.com. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using System;

namespace OffSync.Mapping.Practises
{
    public interface IMappingContext :
        IDisposable
    {
        bool TryGetMapping(
            object source,
            out object target);

        void AddMapping(
            object source,
            object target);
    }
}
