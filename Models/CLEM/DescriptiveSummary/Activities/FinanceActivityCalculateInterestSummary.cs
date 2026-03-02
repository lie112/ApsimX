using Models.CLEM.Activities;
using Models.CLEM.Resources;
using System;
using System.IO;
using System.Linq;

namespace Models.CLEM.DescriptiveSummary;

/// <summary>
/// Descriptive summary provider for Finnance Activity Calculate Interest
/// </summary>
public class FinanceActivityCalculateInterestSummary : DescriptiveSummaryProviderBase<FinanceActivityCalculateInterest>
{
    /// <inheritdoc/>
    public override void BuildSummary()
    {
        ZoneCLEM clemParent = ModelTyped.Node.FindParent<ZoneCLEM>(recurse: true);
        ResourcesHolder resHolder;
        Finance finance = null;
        if (clemParent != null)
        {
            resHolder = clemParent.Node.FindChildren<ResourcesHolder>().FirstOrDefault();
            finance = resHolder.FindResourceGroup<Finance>();
            if (finance != null && !finance.Enabled)
                finance = null;
        }
        if (finance == null)
        {
            generator.AddBlockWithText($"This activity is not required as no {generator.DisplaySummaryResourceTypeSnippet("Finance")} resource is available.", classString:"infoBanner warning" );
        }
        else
        {
            generator.AddBlockWithText($"Interest rates are set in the {generator.DisplaySummaryResourceTypeSnippet("FinanceType")} component.");
            foreach (FinanceType accnt in finance.Node.FindChildren<FinanceType>().Where(a => a.Enabled))
            {
                if (accnt.InterestRateCharged == 0 & accnt.InterestRatePaid == 0)
                {
                    generator.AddBlockWithText($"This activity is not needed for {generator.DisplaySummaryResourceTypeSnippet(accnt.Name)} as no interest rates are set.", classString: "infoBanner");
                }
                else
                {
                    generator.AddBlockWithText($"This activity will calculate interest charged for {generator.DisplaySummaryResourceTypeSnippet(accnt.Name)} at a rate of {generator.DisplaySummaryValueSnippet(accnt.InterestRateCharged, warnZero: true)}.");
                }
            }
        }

    }
}
