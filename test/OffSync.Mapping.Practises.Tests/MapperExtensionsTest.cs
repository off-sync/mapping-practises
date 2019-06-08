/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Off-Sync.com. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using Moq;

using NUnit.Framework;

namespace OffSync.Mapping.Practises.Tests
{
    [TestFixture]
    public class MapperExtensionsTest
    {
        private Mock<IMapper<Source, Target>> _mapper;

        public class Source
        {
        }

        public class Target
        {
        }

        [SetUp]
        public void SetUp()
        {
            _mapper = new Mock<IMapper<Source, Target>>();

            _mapper
                .Setup(m => m.Map(It.IsAny<Source>()))
                .Returns(CheckMapInvocation);
        }

        private Target CheckMapInvocation()
        {
            Assert.That(
                MappingContext.Current,
                Is.Not.Null);

            return new Target();
        }

        [Test]
        public void RootMapShouldCallMapWithinMappingContext()
        {
            using (MappingContext.Create())
            {
                _mapper.Object.MapRoot(new Source());
            }
        }
    }
}
