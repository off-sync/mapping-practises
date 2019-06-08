﻿/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Off-Sync.com. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

namespace OffSync.Mapping.Practises
{
    public static class MapperExtensions
    {
        public static TTarget MapRoot<TSource, TTarget>(
            this IMapper<TSource, TTarget> mapper,
            TSource root)
        {
            using (MappingContext.Create())
            {
                return mapper.Map(root);
            }
        }
    }
}
