using Xunit;
using Library.ApplicationCore.Enums;

namespace Library.UnitTests.ApplicationCore.Enums;

public class EnumHelperTest
{
    [Fact]
    public void GetDescription_NullValue_ReturnsEmptyString()
    {
        // Arrange & Act
        string result = EnumHelper.GetDescription(null);

        // Assert 
        Assert.Equal(string.Empty, result);
    }

    [Theory]
    [InlineData(LoanExtensionStatus.Success, "Book loan extension was successful.")]
    [InlineData(LoanExtensionStatus.LoanNotFound, "Loan not found.")]
    [InlineData(LoanExtensionStatus.Error, "Cannot extend book loan due to an error.")]
    public void GetDescription_LoanExtensionStatus_ReturnsCorrectDescription(LoanExtensionStatus status, string expected)
    {
        // Act
        string result = EnumHelper.GetDescription(status);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(LoanReturnStatus.Success, "Book was successfully returned.")]
    [InlineData(LoanReturnStatus.LoanNotFound, "Loan not found.")]
    [InlineData(LoanReturnStatus.Error, "Cannot return book due to an error.")]
    public void GetDescription_LoanReturnStatus_ReturnsCorrectDescription(LoanReturnStatus status, string expected)
    {
        // Act
        string result = EnumHelper.GetDescription(status);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(MembershipRenewalStatus.Success, "Membership renewal was successful.")]
    [InlineData(MembershipRenewalStatus.PatronNotFound, "Patron not found.")]
    [InlineData(MembershipRenewalStatus.Error, "Cannot renew membership due to an error.")]
    public void GetDescription_MembershipRenewalStatus_ReturnsCorrectDescription(MembershipRenewalStatus status, string expected)
    {
        // Act
        string result = EnumHelper.GetDescription(status);

        // Assert
        Assert.Equal(expected, result);
    }
}