namespace DateTimeChecker;

public enum DateInputField
{
    None,
    Day,
    Month,
    Year
}

public enum DateInputError
{
    None,
    IncorrectFormat,
    OutOfRange
}

public sealed record DateValidationResult(
    bool InputIsValid,
    bool DateIsValid,
    DateInputField Field,
    DateInputError Error,
    int Day,
    int Month,
    int Year)
{
    public string FormattedDate => $"{Day:00}/{Month:00}/{Year:0000}";
}

public static class DateValidator
{
    public static DateValidationResult Validate(string dayText, string monthText, string yearText)
    {
        if (!TryReadNumber(dayText, 1, 31, DateInputField.Day, out var day, out var inputError))
        {
            return inputError;
        }

        if (!TryReadNumber(monthText, 1, 12, DateInputField.Month, out var month, out inputError))
        {
            return inputError;
        }

        if (!TryReadNumber(yearText, 1000, 3000, DateInputField.Year, out var year, out inputError))
        {
            return inputError;
        }

        var isValidDate = day <= DaysInMonth(year, month);
        return new DateValidationResult(true, isValidDate, DateInputField.None, DateInputError.None, day, month, year);
    }

    public static int DaysInMonth(int year, int month)
    {
        return month switch
        {
            1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
            4 or 6 or 9 or 11 => 30,
            2 => IsLeapYear(year) ? 29 : 28,
            _ => 0
        };
    }

    private static bool TryReadNumber(
        string text,
        int minimum,
        int maximum,
        DateInputField field,
        out int value,
        out DateValidationResult result)
    {
        if (!int.TryParse(text, out value))
        {
            result = new DateValidationResult(false, false, field, DateInputError.IncorrectFormat, 0, 0, 0);
            return false;
        }

        if (value < minimum || value > maximum)
        {
            result = new DateValidationResult(false, false, field, DateInputError.OutOfRange, 0, 0, 0);
            return false;
        }

        result = new DateValidationResult(true, false, DateInputField.None, DateInputError.None, 0, 0, 0);
        return true;
    }

    private static bool IsLeapYear(int year)
    {
        if (year % 400 == 0)
        {
            return true;
        }

        if (year % 100 == 0)
        {
            return false;
        }

        return year % 4 == 0;
    }
}
