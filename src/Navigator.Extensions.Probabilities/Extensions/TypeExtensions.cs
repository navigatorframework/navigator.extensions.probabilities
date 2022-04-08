namespace Navigator.Extensions.Probabilities.Extensions;

internal static class TypeExtensions
{
    public static int GetProbabilities(this Type type)
    {
        if (Attribute.GetCustomAttribute(type, typeof(ProbabilitiesAttribute)) is ProbabilitiesAttribute probabilitiesAttribute)
        {
            return probabilitiesAttribute.Percentage;
        }

        return default;
    }
}