using Models.CLEM.Activities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.CLEM.DescriptiveSummary;

/// <summary>
/// Descriptive summary provider for Crop Activity Task
/// </summary>
public class CropActivityTaskSummary : DescriptiveSummaryProviderBase<CropActivityTask>
{
    /// <summary>
    /// Constructor
    /// </summary>
    public CropActivityTaskSummary()
    {
        SummaryStyle = HTMLSummaryStyle.SubActivity;
    }

    /// <inheritdoc/>
    public override void BuildSummary()
    {
        if (ModelTyped.Node.FindChildren<ActivityFee>().Count() + ModelTyped.Node.FindChildren<LabourRequirement>().Count() == 0)
            generator.AddBlockWithText("This task is not needed as it has no fee or labour requirement", "infoBanner warning");
    }
}
