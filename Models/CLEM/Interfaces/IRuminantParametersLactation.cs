namespace Models.CLEM.Interfaces
{
    /// <summary>
    /// Interface for ruminant lactation parameters
    /// </summary>
    public interface IRuminantParametersLactation
    {
        /// <summary>
        /// Milk curve shape suckling
        /// </summary>
        double MilkCurveNonSuckling { get; set; }
        /// <summary>
        /// Milk curve shape non suckling
        /// </summary>
        double MilkCurveSuckling { get; set; }
        /// <summary>
        /// Number of days for milking
        /// </summary>
        double MilkingDays { get; set; }
        /// <summary>
        /// Milk offset day
        /// </summary>
        double MilkOffsetDay { get; set; }
        /// <summary>
        /// Milk peak day
        /// </summary>
        double MilkPeakDay { get; set; }
        /// <summary>
        /// Peak milk yield(kg/day)
        /// </summary>
        double MilkPeakYield { get; set; }
    }
}