namespace DateTimeChecker;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        pictureLogo = new PictureBox();
        titleLabel = new Label();
        dayLabel = new Label();
        monthLabel = new Label();
        yearLabel = new Label();
        dayTextBox = new TextBox();
        monthTextBox = new TextBox();
        yearTextBox = new TextBox();
        clearButton = new Button();
        checkButton = new Button();
        ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
        SuspendLayout();
        // 
        // pictureLogo
        // 
        pictureLogo.Location = new Point(25, 6);
        pictureLogo.Name = "pictureLogo";
        pictureLogo.Size = new Size(181, 59);
        pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureLogo.TabIndex = 0;
        pictureLogo.TabStop = false;
        // 
        // titleLabel
        // 
        titleLabel.AutoSize = true;
        titleLabel.Font = new Font("Arial", 26F, FontStyle.Regular, GraphicsUnit.Point);
        titleLabel.ForeColor = Color.DodgerBlue;
        titleLabel.Location = new Point(55, 75);
        titleLabel.Name = "titleLabel";
        titleLabel.Size = new Size(304, 40);
        titleLabel.TabIndex = 1;
        titleLabel.Text = "Date Time Checker";
        // 
        // dayLabel
        // 
        dayLabel.AutoSize = true;
        dayLabel.Location = new Point(105, 134);
        dayLabel.Name = "dayLabel";
        dayLabel.Size = new Size(27, 13);
        dayLabel.TabIndex = 2;
        dayLabel.Text = "Day";
        dayLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // monthLabel
        // 
        monthLabel.AutoSize = true;
        monthLabel.Location = new Point(105, 162);
        monthLabel.Name = "monthLabel";
        monthLabel.Size = new Size(40, 13);
        monthLabel.TabIndex = 4;
        monthLabel.Text = "Month";
        monthLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // yearLabel
        // 
        yearLabel.AutoSize = true;
        yearLabel.Location = new Point(105, 190);
        yearLabel.Name = "yearLabel";
        yearLabel.Size = new Size(29, 13);
        yearLabel.TabIndex = 6;
        yearLabel.Text = "Year";
        yearLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // dayTextBox
        // 
        dayTextBox.Location = new Point(152, 131);
        dayTextBox.Name = "dayTextBox";
        dayTextBox.Size = new Size(100, 20);
        dayTextBox.TabIndex = 3;
        // 
        // monthTextBox
        // 
        monthTextBox.Location = new Point(152, 159);
        monthTextBox.Name = "monthTextBox";
        monthTextBox.Size = new Size(100, 20);
        monthTextBox.TabIndex = 5;
        // 
        // yearTextBox
        // 
        yearTextBox.Location = new Point(152, 187);
        yearTextBox.Name = "yearTextBox";
        yearTextBox.Size = new Size(100, 20);
        yearTextBox.TabIndex = 7;
        // 
        // clearButton
        // 
        clearButton.Location = new Point(99, 226);
        clearButton.Name = "clearButton";
        clearButton.Size = new Size(73, 24);
        clearButton.TabIndex = 8;
        clearButton.Text = "Clear";
        clearButton.UseVisualStyleBackColor = true;
        clearButton.Click += clearButton_Click;
        // 
        // checkButton
        // 
        checkButton.Location = new Point(197, 226);
        checkButton.Name = "checkButton";
        checkButton.Size = new Size(73, 24);
        checkButton.TabIndex = 9;
        checkButton.Text = "Check";
        checkButton.UseVisualStyleBackColor = true;
        checkButton.Click += checkButton_Click;
        // 
        // Form1
        // 
        AcceptButton = checkButton;
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        CancelButton = clearButton;
        ClientSize = new Size(390, 270);
        Controls.Add(checkButton);
        Controls.Add(clearButton);
        Controls.Add(yearTextBox);
        Controls.Add(monthTextBox);
        Controls.Add(dayTextBox);
        Controls.Add(yearLabel);
        Controls.Add(monthLabel);
        Controls.Add(dayLabel);
        Controls.Add(titleLabel);
        Controls.Add(pictureLogo);
        Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        FormClosing += Form1_FormClosing;
        ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private PictureBox pictureLogo;
    private Label titleLabel;
    private Label dayLabel;
    private Label monthLabel;
    private Label yearLabel;
    private TextBox dayTextBox;
    private TextBox monthTextBox;
    private TextBox yearTextBox;
    private Button clearButton;
    private Button checkButton;
}
