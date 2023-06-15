using Models.CLEM.Interfaces;

namespace Models.CLEM.Resources
{
    /// <summary>
    /// Container for ruminant general parameters
    /// </summary>
    public class RuminantParametersGeneral : IRuminantParametersGeneral
    {
        /// <summary>
        /// A constructor to create a deep copy of runinant type to a new RuminantParametersGrow 
        /// </summary>
        /// <param name="baseModel">A baseModel model with parameters</param>
        public RuminantParametersGeneral(IRuminantParametersGeneral baseModel)
        {
            NaturalWeaningAge = baseModel.NaturalWeaningAge;
            SRWBirth = baseModel.SRWBirth;
            SRWFemale = baseModel.SRWFemale;
            SRWGrowthScalar = baseModel.SRWGrowthScalar;
            SRWMaleMultiplier = baseModel.SRWMaleMultiplier;
            AgeGrowthRateCoefficient = baseModel.AgeGrowthRateCoefficient;
            RelBCToScoreRate = baseModel.RelBCToScoreRate;
            BCScoreRange = baseModel.BCScoreRange.Clone() as double[];
            BodyConditionScoreForMortality = baseModel.BodyConditionScoreForMortality;
            BodyConditionScoreMortalityRate = baseModel.BodyConditionScoreMortalityRate;
            BaseAnimalEquivalent = baseModel.BaseAnimalEquivalent;
            MortalityBase = baseModel.MortalityBase;
            MaximumSizeOfIndividual = baseModel.MaximumSizeOfIndividual;
            MortalityCoefficient = baseModel.MortalityCoefficient;
            MortalityExponent = baseModel.MortalityExponent;
            MortalityIntercept = baseModel.MortalityIntercept;
            JuvenileMortalityCoefficient = baseModel.JuvenileMortalityCoefficient;
            JuvenileMortalityExponent = baseModel.JuvenileMortalityExponent;
            JuvenileMortalityMaximum = baseModel.JuvenileMortalityMaximum;
        }
        ///<inheritdoc/>
        public double NaturalWeaningAge { get; set; }
        ///<inheritdoc/>
        public double SRWFemale { get; set; }
        ///<inheritdoc/>
        public double SRWMaleMultiplier { get; set; }
        ///<inheritdoc/>
        public double SRWBirth { get; set; }
        ///<inheritdoc/>
        public double AgeGrowthRateCoefficient { get; set; }
        ///<inheritdoc/>
        public double SRWGrowthScalar { get; set; }
        ///<inheritdoc/>
        public double RelBCToScoreRate { get; set; } = 0.15;
        ///<inheritdoc/>
        public double[] BCScoreRange { get; set; } = { 0, 3, 5 };
        ///<inheritdoc/>
        public double BodyConditionScoreForMortality { get; set; } = 0;
        ///<inheritdoc/>
        public double BodyConditionScoreMortalityRate { get; set; } = 0.5;
        ///<inheritdoc/>
        public double BaseAnimalEquivalent { get; set; }
        ///<inheritdoc/>
        public double MaximumSizeOfIndividual { get; set; }
        ///<inheritdoc/>
        public double MortalityBase { get; set; }
        ///<inheritdoc/>
        public double MortalityCoefficient { get; set; }
        ///<inheritdoc/>
        public double MortalityIntercept { get; set; }
        ///<inheritdoc/>
        public double MortalityExponent { get; set; }
        ///<inheritdoc/>
        public double JuvenileMortalityCoefficient { get; set; }
        ///<inheritdoc/>
        public double JuvenileMortalityMaximum { get; set; }
        ///<inheritdoc/>
        public double JuvenileMortalityExponent { get; set; }
    }
}
