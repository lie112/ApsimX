using Models.CLEM.Interfaces;

namespace Models.CLEM.Resources
{
    /// <summary>
    /// Container for ruminant breeding parameters
    /// </summary>
    public class RuminantParametersBreeding : IRuminantParametersBreeding
    {
        /// <summary>
        /// A constructor to create a deep copy of model of type IRuminantParametersBreeding to a new RuminantParametersBreeding 
        /// </summary>
        /// <param name="baseModel">Base model with values to copy</param>
        public RuminantParametersBreeding(IRuminantParametersBreeding baseModel)
        {
            ProportionOffspringMale = baseModel.ProportionOffspringMale;
            InterParturitionIntervalIntercept = baseModel.InterParturitionIntervalIntercept;
            InterParturitionIntervalCoefficient = baseModel.InterParturitionIntervalCoefficient;
            GestationLength = baseModel.GestationLength;
            MinimumAge1stMating = baseModel.MinimumAge1stMating;
            MinimumSize1stMating = baseModel.MinimumSize1stMating;
            MinimumDaysBirthToConception = baseModel.MinimumDaysBirthToConception;
            MultipleBirthRate = baseModel.MultipleBirthRate.Clone() as double[];
            CriticalCowWeight = baseModel.CriticalCowWeight;
            MaximumMaleMatingsPerDay = baseModel.MaximumMaleMatingsPerDay;
            PrenatalMortality = baseModel.PrenatalMortality;
        }

        /// <inheritdoc/>
        public double ProportionOffspringMale { get; set; }
        /// <inheritdoc/>
        public double InterParturitionIntervalIntercept { get; set; }
        /// <inheritdoc/>
        public double InterParturitionIntervalCoefficient { get; set; }
        /// <inheritdoc/>
        public double GestationLength { get; set; }
        /// <inheritdoc/>
        public double MinimumAge1stMating { get; set; }
        /// <inheritdoc/>
        public double MinimumSize1stMating { get; set; }
        /// <inheritdoc/>
        public double MinimumDaysBirthToConception { get; set; }
        /// <inheritdoc/>
        public double[] MultipleBirthRate { get; set; }
        /// <inheritdoc/>
        public double CriticalCowWeight { get; set; }
        /// <inheritdoc/>
        public double MaximumMaleMatingsPerDay { get; set; }
        /// <inheritdoc/>
        public double PrenatalMortality { get; set; }
    }
}
