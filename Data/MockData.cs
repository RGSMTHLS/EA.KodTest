using System.Collections.Generic;

namespace EA.KodTest.Data
{
    internal static class MockData
    {
        public static IList<Package> MockPackages = new List<Package>
        {
            new Package("123456789123456789",
                        11,
                        12,
                        13,
                        14),
            new Package("987654321987654321",
                        19.5,
                        15,
                        10,
                        10),
            new Package("987654321987654322",
                        15,
                        16,
                        12,
                        14)
        };
    }
}
