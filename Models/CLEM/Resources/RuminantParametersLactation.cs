using Models.CLEM.Interfaces;

namespace Models.CLEM.Resources
{
    internal class RuminantParametersLactation : IRuminantParametersLactation
    {
        /// <summary>
        /// Constructor to create a deep copy of model of type IRuminantParametersLactation to a new RuminantParametersLactation
        /// </summary>
        /// <param name="baseModel">Base model with values to copy</param>
        public RuminantParametersLactation(IRuminantParametersLactation baseModel)
        {
            MilkCurveSuckling = baseModel.MilkCurveSuckling;
            MilkCurveNonSuckling = baseModel.MilkCurveNonSuckling;
            MilkingDays = baseModel.MilkingDays;
            MilkPeakYield = baseModel.MilkPeakYield;
            MilkOffsetDay = baseModel.MilkOffsetDay;
            MilkPeakDay = baseModel.MilkPeakDay;
        }

        /// <inheritdoc/>
        public double MilkCurveSuckling { get; set; }
        /// <inheritdoc/>
        public double MilkCurveNonSuckling { get; set; }
        /// <inheritdoc/>
        public double MilkingDays { get; set; }
        /// <inheritdoc/>
        public double MilkPeakYield { get; set; }
        /// <inheritdoc/>
        public double MilkOffsetDay { get; set; }
        /// <inheritdoc/>
        public double MilkPeakDay { get; set; }
    }
}
