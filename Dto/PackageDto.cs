namespace EA.KodTest.Dto
{
    internal class PackageDto
    {
        public double Weight { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public PackageDto(Package package)
        {
            Weight = package.Weight;
            Length = package.Length;
            Height = package.Height;
            Width = package.Width;
        }
    }
}
