using System.Linq;

namespace EA.KodTest.Helpers
{
    internal static class PackageNumberValidator
    {
        const string ERROR_MISSING = "Kollinummer saknas";
        const string ERROR_INVALID = "Kollinummer har fel format";
        const int VALID_LENGTH = 18;

        internal static bool ValidatePackageNumber(string packageNumber, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrEmpty(packageNumber))
            {
                errorMessage = ERROR_MISSING;
                return false;
            }

            if (packageNumber.Length != VALID_LENGTH || !packageNumber.All(char.IsDigit))
            {
                errorMessage = ERROR_INVALID;
                return false;
            }

            return true;
        }
    }
}
