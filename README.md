# DateTimeChecker

Simple C# WinForms app based on the ProjectIntroduction.docx layout.

## Open and run

1. Open `DateTimeChecker.sln` in Visual Studio.
2. Set `DateTimeChecker` as the startup project if Visual Studio asks.
3. Press `F5` or click `Start`.

## Behavior

- `Clear` empties Day, Month, and Year.
- `Check` validates input format and range first.
- Valid range:
  - Day: 1-31
  - Month: 1-12
  - Year: 1000-3000
- The checker uses Gregorian leap-year rules.
- Closing the form shows the confirmation message box from the document.

## NUnit + Allure

Run this command from the folder that contains `DateTimeChecker.sln`:

```bash
dotnet test
```

Allure result files are written to `allure-results`.

For NUnit, do not use `--logger:allure`; `Allure.NUnit` writes the result files through the `[AllureNUnit]` attribute when normal `dotnet test` runs.
