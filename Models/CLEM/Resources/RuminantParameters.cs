using System.Collections.Generic;
using System.Reflection;

namespace Models.CLEM.Resources
{
    /// <summary>
    /// Stores all ruminant parameters and manages depp copy duplication when individual parameters need to change
    /// </summary>
    public class RuminantParameters
    {
        private Dictionary<string, bool> modified = new();

        /// <summary>
        /// Constructor for deep values based copy from parent RuminantType details
        /// </summary>
        /// <param name="baseType">A RuminatType model</param>
        public RuminantParameters(RuminantType baseType)
        {
            BreedDetails = baseType;
            modified.Add("Herd", false);
            General = new RuminantParametersGeneral(baseType);
            modified.Add("General", false);
            Growth = new RuminantParametersGrowth(baseType);
            modified.Add("Growth", false);
            Breeding = new RuminantParametersBreeding(baseType);
            modified.Add("Breeding", false);
        }

        /// <summary>
        /// Constructor for shallow reference based copy from parent details
        /// Non modifed parameter sets will be shared across the entire herd of individuals
        /// </summary>
        /// <param name="parent">A RuminantParameters object from parent</param>
        public RuminantParameters(RuminantParameters parent)
        {
            BreedDetails = parent.BreedDetails;
            modified.Add("Details", false);
            General = parent.General;
            modified.Add("General", false);
            Growth = parent.Growth;
            modified.Add("Growth", false);
            Breeding = parent.Breeding;
            modified.Add("Breeding", false);
        }

        /// <summary>
        /// Update a property in Ruminant parameters and create deep copy to separate from shared parent values if needed.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="propertyInfo"></param>
        /// <param name="value"></param>
        public void Update(string key, PropertyInfo propertyInfo, object value)
        {
            if(!modified.GetValueOrDefault(key))
            {
                switch (key)
                {
                    case "General":
                        if(propertyInfo.GetValue(General) != value)
                        {
                            if (!modified.GetValueOrDefault(key))
                            {
                                General = new RuminantParametersGeneral(General);
                                modified[key] = true;
                            }
                            propertyInfo.SetValue(General, value);
                        }
                        break;
                    case "Growth":
                        if (propertyInfo.GetValue(Growth) != value)
                        {
                            if (!modified.GetValueOrDefault(key))
                            {
                                Growth = new RuminantParametersGrowth(Growth);
                                modified[key] = true;
                            }
                            propertyInfo.SetValue(Growth, value);
                        }
                        break;
                    case "Breeding":
                        if (propertyInfo.GetValue(Breeding) != value)
                        {
                            if (!modified.GetValueOrDefault(key))
                            {
                                Breeding = new RuminantParametersBreeding(Breeding);
                                modified[key] = true;
                            }
                            propertyInfo.SetValue(Breeding, value);
                        }
                        break;
                    case "Lactation":
                        if (propertyInfo.GetValue(Lactation) != value)
                        {
                            if (!modified.GetValueOrDefault(key))
                            {
                                Lactation = new RuminantParametersLactation(Lactation);
                                modified[key] = true;
                            }
                            propertyInfo.SetValue(Lactation, value);
                        }
                        break;
                    default:
                        break;
                }
                modified[key] = true;
            }
        }

        /// <summary>
        /// Breed details model with controlling breed/herd details
        /// </summary>
        public RuminantType BreedDetails { get; set; }
        /// <summary>
        /// General Parameters holder
        /// </summary>
        public RuminantParametersGeneral General { get; set; }

        /// <summary>
        /// Growth parameters holder
        /// </summary>
        public RuminantParametersGrowth Growth { get; set; }
        /// <summary>
        /// Breed Parameters holder
        /// </summary>
        public RuminantParametersBreeding Breeding { get; set; }
        /// <summary>
        /// Lactation Parameters holder
        /// </summary>
        public RuminantParametersLactation Lactation { get; set; }
    }
}
