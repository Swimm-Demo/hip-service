namespace In.ProjectEKA.DefaultHipTest.Discovery.Patient.Helpers
{
    using DefaultHip.Discovery.Matcher;
    using FluentAssertions;
    using Xunit;

    [Collection("Fuzzy Match Names Tests")]
    public class FuzzyNameMatcherTest
    {
        [Fact]
        private void ShouldHaveOneDifference()
        {
            FuzzyNameMatcher.LevenshteinDistance("Ajoy", "Ajay").Should().Be(1);
            FuzzyNameMatcher.LevenshteinDistance("Chethan", "Chetan").Should().Be(1);            
            FuzzyNameMatcher.LevenshteinDistance("github", "git hub").Should().Be(1); 
        }

        [Fact]
        private void ShouldHaveTwoDifferences()
        {
            FuzzyNameMatcher.LevenshteinDistance("Akshatha", "Aksata").Should().Be(2); 
            FuzzyNameMatcher.LevenshteinDistance("Aksata", "Akshatha").Should().Be(2);
        }
    }

           
}