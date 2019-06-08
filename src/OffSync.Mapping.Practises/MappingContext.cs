/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Off-Sync.com. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

namespace OffSync.Mapping.Practises
{
    public sealed partial class MappingContext :
        IMappingContext
    {
        private MappingContext()
        {
        }

        public void Dispose()
        {
            _mappings.Clear();

            _current.Value = null;
        }
    }
}
