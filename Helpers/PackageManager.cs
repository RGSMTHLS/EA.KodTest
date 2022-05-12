using EA.KodTest.Data;
using System.Linq;

namespace EA.KodTest.Helpers
{
    internal static class PackageManager
    {
        public static Package GetPackage(string packageNumber)
        {
            var package = MockData.MockPackages.FirstOrDefault(p => p.PackageNumber == packageNumber);
            return package;
        }
    }
}
