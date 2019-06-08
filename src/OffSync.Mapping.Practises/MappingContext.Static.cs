/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Off-Sync.com. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using System.Threading;

namespace OffSync.Mapping.Practises
{
    public sealed partial class MappingContext
    {
        private static readonly AsyncLocal<IMappingContext> _current = new AsyncLocal<IMappingContext>();

        public static IMappingContext Current => _current.Value;

        public static IMappingContext Create()
        {
            var context = new MappingContext();

            _current.Value = context;

            return context;
        }
    }
}
