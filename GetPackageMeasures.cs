using EA.KodTest.Dto;
using EA.KodTest.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace EA.KodTest
{
    public static class GetPackageMeasures
    {
        [FunctionName("GetPackageMeasures")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            string packageNumber = req.Query["packageNumber"];
            var packageNumberIsValid = PackageNumberValidator.ValidatePackageNumber(packageNumber, out string errorMessage);
            if (!packageNumberIsValid)
            {
                return new BadRequestObjectResult(errorMessage);
            }

            var package = PackageManager.GetPackage(packageNumber);
            if(package == null)
            {
                return new NotFoundResult();
            }
            return new OkObjectResult(new PackageDto(package));
        }
    }
}
