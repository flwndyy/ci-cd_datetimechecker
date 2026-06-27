namespace DateTimeChecker;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        LoadLogo();
    }

    private void LoadLogo()
    {
        var logoPath = Path.Combine(AppContext.BaseDirectory, "Assets", "fpt-logo.png");

        if (File.Exists(logoPath))
        {
            pictureLogo.Image = Image.FromFile(logoPath);
        }
    }

    private void clearButton_Click(object sender, EventArgs e)
    {
        dayTextBox.Clear();
        monthTextBox.Clear();
        yearTextBox.Clear();
        dayTextBox.Focus();
    }

    private void checkButton_Click(object sender, EventArgs e)
    {
        var result = DateValidator.Validate(dayTextBox.Text.Trim(), monthTextBox.Text.Trim(), yearTextBox.Text.Trim());

        if (!result.InputIsValid)
        {
            ShowInputError(result);
            return;
        }

        var message = result.DateIsValid
            ? $"{result.FormattedDate} is correct date time!"
            : $"{result.FormattedDate} is NOT correct date time!";

        MessageBox.Show(this, message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (e.CloseReason != CloseReason.UserClosing)
        {
            return;
        }

        var answer = MessageBox.Show(
            this,
            "Are you sure to exit?",
            "Confirm",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Information);

        e.Cancel = answer == DialogResult.No;
    }

    private void ShowInputError(DateValidationResult result)
    {
        var fieldName = result.Field.ToString();
        var detail = result.Error == DateInputError.IncorrectFormat
            ? "incorrect format"
            : "out of range";

        MessageBox.Show(
            this,
            $"Input data for {fieldName} is {detail}!",
            "Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
    }
}
