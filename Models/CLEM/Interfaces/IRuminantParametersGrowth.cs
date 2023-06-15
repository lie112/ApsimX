namespace Models.CLEM.Interfaces
{
    /// <summary>
    /// Interface for ruminant growth parameters
    /// </summary>
    public interface IRuminantParametersGrowth
    {
        /// <summary>
        /// Cashmere coefficient
        /// </summary>
        double CashmereCoefficient { get; set; }
        /// <summary>
        /// Energy growth efficiency coefficient
        /// </summary>
        double EGrowthEfficiencyCoefficient { get; set; }
        /// <summary>
        /// Energy growth efficiency intercept
        /// </summary>
        double EGrowthEfficiencyIntercept { get; set; }
        /// <summary>
        /// Energy lactation efficiency coefficient
        /// </summary>
        double ELactationEfficiencyCoefficient { get; set; }
        /// <summary>
        /// Energy lactation efficiency intercept
        /// </summary>
        double ELactationEfficiencyIntercept { get; set; }
        /// <summary>
        /// Energy maintenance coefficient
        /// </summary>
        double EMaintCoefficient { get; set; }
        /// <summary>
        /// Energy maintenance efficiency coefficient
        /// </summary>
        double EMaintEfficiencyCoefficient { get; set; }
        /// <summary>
        /// Energy maintenance efficiency intercept
        /// </summary>
        double EMaintEfficiencyIntercept { get; set; }
        /// <summary>
        /// Energy maintenance exponent
        /// </summary>
        double EMaintExponent { get; set; }
        /// <summary>
        /// Energy maintenance intercept
        /// </summary>
        double EMaintIntercept { get; set; }
        /// <summary>
        /// Maximum age for energy maintenance calculation (yrs)
        /// </summary>
        double EnergyMaintenanceMaximumAge { get; set; }
        /// <summary>
        /// Shape of curve for diet vs pasture
        /// </summary>
        double GreenDietCoefficient { get; set; }
        /// <summary>
        /// Maximum green in diet
        /// </summary>
        double GreenDietMax { get; set; }
        /// <summary>
        /// Proportion green in pasture at zero in diet
        /// was %
        /// </summary>
        double GreenDietZero { get; set; }
        /// <summary>
        /// Growth efficiency
        /// </summary>
        double GrowthEfficiency { get; set; }
        /// <summary>
        /// Parameter for calculation of energy needed per kg empty body gain #1 (a, see p37 Table 1.11 Nutrient Requirements of domesticated ruminants)
        /// </summary>
        double GrowthEnergyIntercept1 { get; set; }
        /// <summary>
        /// Parameter for calculation of energy needed per kg empty body gain #2 (b, see p37 Table 1.11 Nutrient Requirements of domesticated ruminants)
        /// </summary>
        double GrowthEnergyIntercept2 { get; set; }
        /// <summary>
        /// Intake coefficient in relation to live weight
        /// </summary>
        double IntakeCoefficient { get; set; }
        /// <summary>
        /// Coefficient to adjust intake for herbage biomass
        /// </summary>
        double IntakeCoefficientBiomass { get; set; }
        /// <summary>
        /// Intake intercept in relation to live weight
        /// </summary>
        double IntakeIntercept { get; set; }
        /// <summary>
        /// Breed factor for maintenence energy
        /// </summary>
        double Kme { get; set; }
        /// <summary>
        /// Lactating Potential intake modifier Coefficient A
        /// </summary>
        double LactatingPotentialModifierConstantA { get; set; }
        /// <summary>
        /// Lactating Potential intake modifier Coefficient B
        /// </summary>
        double LactatingPotentialModifierConstantB { get; set; }
        /// <summary>
        /// Lactating Potential intake modifier Coefficient C
        /// </summary>
        double LactatingPotentialModifierConstantC { get; set; }
        /// <summary>
        /// Max juvenile (suckling) intake as proportion of LWT
        /// </summary>
        double MaxJuvenileIntake { get; set; }
        /// <summary>
        /// Coefficient of juvenile milk intake
        /// </summary>
        double MilkIntakeCoefficient { get; set; }
        /// <summary>
        /// Intercept of juvenile milk intake
        /// </summary>
        double MilkIntakeIntercept { get; set; }
        /// <summary>
        /// Maximum juvenile milk intake
        /// </summary>
        double MilkIntakeMaximum { get; set; }
        /// <summary>
        /// Milk as proportion of LWT for fodder substitution
        /// </summary>
        double MilkLWTFodderSubstitutionProportion { get; set; }
        /// <summary>
        /// Potential intake modifier for maximum intake possible when overfeeding
        /// </summary>
        double OverfeedPotentialIntakeModifier { get; set; }
        /// <summary>
        /// Proportional discount to intake due to milk intake
        /// </summary>
        double ProportionalDiscountDueToMilk { get; set; }
        /// <summary>
        /// Proportion of max body weight needed for survival
        /// </summary>
        double ProportionOfMaxWeightToSurvive { get; set; }
        /// <summary>
        /// Protein requirement coeff (g/kg feed)
        /// </summary>
        double ProteinCoefficient { get; set; }
        /// <summary>
        /// Protein degradability
        /// </summary>
        double ProteinDegradability { get; set; }
        /// <summary>
        /// Enforce strict feeding limits
        /// </summary>
        bool StrictFeedingLimits { get; set; }
        /// <summary>
        /// Wool coefficient
        /// </summary>
        double WoolCoefficient { get; set; }
        /// <summary>
        /// Methane production from intake coefficient
        /// </summary>
        double MethaneProductionCoefficient { get; set; }
    }
}