namespace Models.CLEM.Interfaces
{
    /// <summary>
    /// Interface for ruminant general parameters
    /// </summary>
    public interface IRuminantParametersGeneral
    {
        /// <summary>
        /// Age growth rate coefficient
        /// </summary>
        double AgeGrowthRateCoefficient { get; set; }
        /// <summary>
        /// Weight(kg) of 1 animal equivalent(steer)
        /// </summary>
        double BaseAnimalEquivalent { get; set; }
        /// <summary>
        /// Body condition score range
        /// </summary>
        double[] BCScoreRange { get; set; }
        /// <summary>
        /// Body condition score to determine additional mortality
        /// </summary>
        double BodyConditionScoreForMortality { get; set; }
        /// <summary>
        /// Low body condition score to mortality rate
        /// </summary>
        double BodyConditionScoreMortalityRate { get; set; }
        /// <summary>
        /// Maximum size of individual relative to SRW
        /// </summary>
        double MaximumSizeOfIndividual { get; set; }
        /// <summary>
        /// Mortality rate base
        /// </summary>
        double MortalityBase { get; set; }
        /// <summary>
        /// Mortality rate coefficient
        /// </summary>
        double MortalityCoefficient { get; set; }
        /// <summary>
        /// Mortality rate exponent
        /// </summary>
        double MortalityExponent { get; set; }
        /// <summary>
        /// Mortality rate intercept
        /// </summary>
        double MortalityIntercept { get; set; }
        /// <summary>
        /// The age (months) at which individuals will stop suckiling and naturally wean
        /// </summary>
        double NaturalWeaningAge { get; set; }
        /// <summary>
        /// Relative body condition to score rate
        /// </summary>
        double RelBCToScoreRate { get; set; }
        /// <summary>
        /// Standard Reference Weight at birth
        /// </summary>
        double SRWBirth { get; set; }
        /// <summary>
        /// Standard Reference Weight of female
        /// </summary>
        double SRWFemale { get; set; }
        /// <summary>
        /// SWR growth scalar
        /// </summary>
        double SRWGrowthScalar { get; set; }
        /// <summary>
        /// Standard Reference Weight for male from female multiplier
        /// </summary>
        double SRWMaleMultiplier { get; set; }
        /// <summary>
        /// Juvenile mortality rate coefficient
        /// </summary>
        double JuvenileMortalityCoefficient { get; set; }
        /// <summary>
        /// Juvenile mortality rate exponent
        /// </summary>
        double JuvenileMortalityExponent { get; set; }
        /// <summary>
        /// Juvenile mortality rate maximum
        /// </summary>
        double JuvenileMortalityMaximum { get; set; }
        /// <summary>
        /// Proportion of max body weight needed for survival
        /// </summary>
        double ProportionOfMaxWeightToSurvive { get; set; }

    }
}