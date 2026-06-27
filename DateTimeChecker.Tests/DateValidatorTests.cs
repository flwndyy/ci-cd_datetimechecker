using Allure.NUnit;
using Allure.NUnit.Attributes;
using NUnit.Framework;

namespace DateTimeChecker.Tests;

[TestFixture]
[AllureNUnit]
[AllureSuite("Date Time Checker")]
[AllureFeature("Date validation")]
public sealed class DateValidatorTests
{
    [Test]
    [AllureStory("Input format")]
    [AllureName("Reject non numeric day")]
    public void RejectsNonNumericDay()
    {
        var result = DateValidator.Validate("abc", "12", "2024");

        Assert.That(result.InputIsValid, Is.False);
        Assert.That(result.Field, Is.EqualTo(DateInputField.Day));
        Assert.That(result.Error, Is.EqualTo(DateInputError.IncorrectFormat));
    }

    [Test]
    [AllureStory("Input range")]
    [AllureName("Reject day outside 1-31")]
    public void RejectsDayOutsideRange()
    {
        var result = DateValidator.Validate("32", "12", "2024");

        Assert.That(result.InputIsValid, Is.False);
        Assert.That(result.Field, Is.EqualTo(DateInputField.Day));
        Assert.That(result.Error, Is.EqualTo(DateInputError.OutOfRange));
    }

    [Test]
    [AllureStory("Input range")]
    [AllureName("Reject month outside 1-12")]
    public void RejectsMonthOutsideRange()
    {
        var result = DateValidator.Validate("1", "13", "2024");

        Assert.That(result.InputIsValid, Is.False);
        Assert.That(result.Field, Is.EqualTo(DateInputField.Month));
        Assert.That(result.Error, Is.EqualTo(DateInputError.OutOfRange));
    }

    [Test]
    [AllureStory("Input range")]
    [AllureName("Reject year outside 1000-3000")]
    public void RejectsYearOutsideRange()
    {
        var result = DateValidator.Validate("1", "12", "999");

        Assert.That(result.InputIsValid, Is.False);
        Assert.That(result.Field, Is.EqualTo(DateInputField.Year));
        Assert.That(result.Error, Is.EqualTo(DateInputError.OutOfRange));
    }

    [Test]
    [AllureStory("Gregorian calendar")]
    [AllureName("Accept valid leap day")]
    public void AcceptsValidLeapDay()
    {
        var result = DateValidator.Validate("29", "2", "2000");

        Assert.That(result.InputIsValid, Is.True);
        Assert.That(result.DateIsValid, Is.True);
    }

    [Test]
    [AllureStory("Gregorian calendar")]
    [AllureName("Reject invalid leap day")]
    public void RejectsInvalidLeapDay()
    {
        var result = DateValidator.Validate("29", "2", "1900");

        Assert.That(result.InputIsValid, Is.True);
        Assert.That(result.DateIsValid, Is.False);
    }

    [Test]
    [AllureStory("Gregorian calendar")]
    [AllureName("Reject day that exceeds days in month")]
    public void RejectsDayThatExceedsDaysInMonth()
    {
        var result = DateValidator.Validate("31", "4", "2024");

        Assert.That(result.InputIsValid, Is.True);
        Assert.That(result.DateIsValid, Is.False);
    }

    [Test]
    [AllureStory("Display")]
    [AllureName("Format date as dd/MM/yyyy")]
    public void FormatsDateAsDayMonthYear()
    {
        var result = DateValidator.Validate("1", "2", "2024");

        Assert.That(result.FormattedDate, Is.EqualTo("01/02/2024"));
    }
}
