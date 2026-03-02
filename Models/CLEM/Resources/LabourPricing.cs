using APSIM.Core;
using Models.CLEM.Groupings;
using Models.Core;
using Models.Core.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Models.CLEM.Resources
{
    /// <summary>
    /// User entry of Labour prices
    /// </summary>
    [Serializable]
    [ViewName("UserInterface.Views.PropertyMultiModelView")]
    [PresenterName("UserInterface.Presenters.PropertyMultiModelPresenter")]
    [ValidParent(ParentType = typeof(Labour))]
    [Description("Holds all labour price entries that define the pay rate of individuals")]
    [Version(1, 0, 1, "Initial release")]
    [HelpUri(@"Content/Features/Resources/Labour/LabourPricing.htm")]
    public class LabourPricing : CLEMModel, IValidatableObject
    {
        #region validation

        /// <inheritdoc/>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!Node.FindChildren<LabourPriceGroup>().Any())
            {
                yield return new ValidationResult($"No [LabourPriceGroups] have been provided for [r={Name}].\r\nAdd [LabourPriceGroups] to include labour pricing.", new string[] { "Labour pricing" });
            }
            else if (Node.FindChildren<LabourPriceGroup>().Count(a => a.Value == 0) > 0)
            {
                yield return new ValidationResult($"No price [Value] has been set for some of the [LabourPriceGroup] in [r={Name}]\r\nThese will not result in price calculations and can be deleted.", new string[] { "Labour pricing" });
            }
        }

        #endregion
    }
}
