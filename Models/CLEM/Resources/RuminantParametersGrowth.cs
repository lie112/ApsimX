using Models.CLEM.Interfaces;

namespace Models.CLEM.Resources
{
    /// <summary>
    /// Container class for Ruminant growth parameters
    /// </summary>
    public class RuminantParametersGrowth : IRuminantParametersGrowth
    {
        /// <summary>
        /// A constructor to create a deep copy of runinant type to a new RuminantParametersGrow 
        /// </summary>
        /// <param name="baseModel">A baseModel model with parameters</param>
        public RuminantParametersGrowth(IRuminantParametersGrowth baseModel)
        {
            EMaintEfficiencyCoefficient = baseModel.EMaintEfficiencyCoefficient;
            EMaintEfficiencyIntercept = baseModel.EMaintEfficiencyIntercept;
            EGrowthEfficiencyCoefficient = baseModel.EMaintEfficiencyCoefficient;
            EGrowthEfficiencyIntercept = baseModel.EMaintEfficiencyIntercept;
            ELactationEfficiencyCoefficient = baseModel.ELactationEfficiencyCoefficient;
            ELactationEfficiencyIntercept = baseModel.ELactationEfficiencyIntercept;
            EMaintExponent = baseModel.EMaintExponent;
            EMaintCoefficient = baseModel.EMaintCoefficient;
            EMaintIntercept = baseModel.EMaintIntercept;
            EnergyMaintenanceMaximumAge = baseModel.EnergyMaintenanceMaximumAge;
            Kme = baseModel.Kme;
            GrowthEnergyIntercept1 = baseModel.GrowthEnergyIntercept1;
            GrowthEnergyIntercept2 = baseModel.GrowthEnergyIntercept2;
            GrowthEfficiency = baseModel.GrowthEfficiency;
            IntakeCoefficient = baseModel.IntakeCoefficient;
            IntakeCoefficientBiomass = baseModel.IntakeCoefficientBiomass;
            IntakeIntercept = baseModel.IntakeIntercept;
            OverfeedPotentialIntakeModifier = baseModel.OverfeedPotentialIntakeModifier;
            ProteinCoefficient = baseModel.ProteinCoefficient;
            ProteinDegradability = baseModel.ProteinDegradability;
            MaxJuvenileIntake = baseModel.MaxJuvenileIntake;
            MilkIntakeCoefficient = baseModel.MilkIntakeCoefficient;
            MilkIntakeIntercept = baseModel.MilkIntakeIntercept;
            MilkIntakeMaximum = baseModel.MilkIntakeMaximum;
            MilkLWTFodderSubstitutionProportion = baseModel.MilkLWTFodderSubstitutionProportion;
            GreenDietMax = baseModel.GreenDietMax;
            CashmereCoefficient = baseModel.CashmereCoefficient;
            LactatingPotentialModifierConstantA = baseModel.LactatingPotentialModifierConstantA;
            LactatingPotentialModifierConstantB = baseModel.LactatingPotentialModifierConstantB;
            LactatingPotentialModifierConstantC = baseModel.LactatingPotentialModifierConstantC;
            GreenDietCoefficient = baseModel.GreenDietCoefficient;
            GreenDietZero = baseModel.GreenDietZero;
            ProportionalDiscountDueToMilk = baseModel.ProportionalDiscountDueToMilk;
            StrictFeedingLimits = baseModel.StrictFeedingLimits;
            WoolCoefficient = baseModel.WoolCoefficient;
            MethaneProductionCoefficient = baseModel.MethaneProductionCoefficient;
        }

        ///<inheritdoc/>
        public double EMaintEfficiencyCoefficient { get; set; }
        ///<inheritdoc/>
        public double EMaintEfficiencyIntercept { get; set; }
        ///<inheritdoc/>
        public double EGrowthEfficiencyCoefficient { get; set; }
        ///<inheritdoc/>
        public double EGrowthEfficiencyIntercept { get; set; }
        ///<inheritdoc/>
        public double ELactationEfficiencyCoefficient { get; set; }
        ///<inheritdoc/>
        public double ELactationEfficiencyIntercept { get; set; }
        ///<inheritdoc/>
        public double EMaintExponent { get; set; }
        ///<inheritdoc/>
        public double EMaintIntercept { get; set; }
        ///<inheritdoc/>
        public double EMaintCoefficient { get; set; }
        ///<inheritdoc/>
        public double EnergyMaintenanceMaximumAge { get; set; }
        ///<inheritdoc/>
        public double Kme { get; set; }
        ///<inheritdoc/>
        public double GrowthEnergyIntercept1 { get; set; }
        ///<inheritdoc/>
        public double GrowthEnergyIntercept2 { get; set; }
        ///<inheritdoc/>
        public double GrowthEfficiency { get; set; }
        ///<inheritdoc/>
        public double IntakeCoefficient { get; set; }
        ///<inheritdoc/>
        public double IntakeIntercept { get; set; }
        ///<inheritdoc/>
        public double OverfeedPotentialIntakeModifier { get; set; }
        ///<inheritdoc/>
        public double ProteinCoefficient { get; set; }
        ///<inheritdoc/>
        public double ProteinDegradability { get; set; }
        ///<inheritdoc/>
        public double GreenDietMax { get; set; }
        ///<inheritdoc/>
        public double GreenDietCoefficient { get; set; }
        ///<inheritdoc/>
        public double GreenDietZero { get; set; }
        ///<inheritdoc/>
        public double IntakeCoefficientBiomass { get; set; }
        ///<inheritdoc/>
        public bool StrictFeedingLimits { get; set; }
        ///<inheritdoc/>
        public double MilkIntakeCoefficient { get; set; }
        ///<inheritdoc/>
        public double MilkIntakeIntercept { get; set; }
        ///<inheritdoc/>
        public double MilkIntakeMaximum { get; set; }
        ///<inheritdoc/>
        public double MilkLWTFodderSubstitutionProportion { get; set; }
        ///<inheritdoc/>
        public double MaxJuvenileIntake { get; set; }
        ///<inheritdoc/>
        public double ProportionalDiscountDueToMilk { get; set; }
        ///<inheritdoc/>
        public double LactatingPotentialModifierConstantA { get; set; }
        ///<inheritdoc/>
        public double LactatingPotentialModifierConstantB { get; set; }
        ///<inheritdoc/>
        public double LactatingPotentialModifierConstantC { get; set; }
        ///<inheritdoc/>
        public double WoolCoefficient { get; set; }
        ///<inheritdoc/>
        public double CashmereCoefficient { get; set; }
        ///<inheritdoc/>
        public double MethaneProductionCoefficient { get; set; }

    }
}
