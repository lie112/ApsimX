namespace Models.CLEM.Interfaces
{
    /// <summary>
    /// Interface for ruminant breeding parameters
    /// </summary>
    public interface IRuminantParametersBreeding
    {
        /// <summary>
        /// Proportion of SRW for zero calving/lambing rate
        /// </summary>
        double CriticalCowWeight { get; set; }
        /// <summary>
        /// Months between conception and parturition
        /// </summary>
        double GestationLength { get; set; }
        /// <summary>
        /// Inter-parturition interval coefficient of PW (months)
        /// </summary>
        double InterParturitionIntervalCoefficient { get; set; }
        /// <summary>
        /// Inter-parturition interval intercept of PW (months)
        /// </summary>
        double InterParturitionIntervalIntercept { get; set; }
        /// <summary>
        /// Maximum number of matings per male per day
        /// </summary>
        double MaximumMaleMatingsPerDay { get; set; }
        /// <summary>
        /// Minimum age for 1st mating (months)
        /// </summary>
        double MinimumAge1stMating { get; set; }
        /// <summary>
        /// Minimum number of days between last birth and conception
        /// </summary>
        double MinimumDaysBirthToConception { get; set; }
        /// <summary>
        /// Minimum size for 1st mating, proportion of SRW
        /// </summary>
        double MinimumSize1stMating { get; set; }
        /// <summary>
        /// Rate at which multiple births are concieved (twins, triplets, ...)
        /// </summary>
        double[] MultipleBirthRate { get; set; }
        /// <summary>
        /// Prenatal mortality rate
        /// </summary>
        double PrenatalMortality { get; set; }
        /// <summary>
        /// Proportion offspring born male
        /// </summary>
        double ProportionOffspringMale { get; set; }
    }
}