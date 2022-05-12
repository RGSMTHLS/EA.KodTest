namespace EA.KodTest
{
    internal class Package
    {
        public string PackageNumber { get; set; }
        public double Weight { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }

        public Package(string packageNumber, double weight, double length, double height, double width)
        {
            PackageNumber = packageNumber;
            Weight = weight;
            Length = length;
            Height = height;
            Width = width;
        }

    }
}
