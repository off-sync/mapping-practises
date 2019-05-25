/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Off-Sync.com. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

namespace OffSync.Mapping.Practises
{
    public interface IMapper<in TSource, out TTarget>
    {
        TTarget Map(TSource source);
    }
}
