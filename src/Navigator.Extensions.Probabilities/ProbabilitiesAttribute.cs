namespace Navigator.Extensions.Probabilities;

/// <summary>
/// Specify the probability of an action being triggered.
/// <remarks>
/// For example, call this attribute with a (int) 10 for it to trigger only 10% of the time.
/// </remarks>
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
public class ProbabilitiesAttribute : Attribute
{
    /// <summary>
    /// Threshold for the action to trigger.
    /// </summary>
    public int Percentage { get; }

    /// <summary>
    /// Default constructor.
    /// </summary>
    /// <param name="percentage"></param>
    public ProbabilitiesAttribute(int percentage)
    {
        Percentage = percentage;
    }

}
