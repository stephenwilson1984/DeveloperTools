namespace DeveloperTools.WinForms.Controls;

public partial class BaseConverter : UserControl
{
    // Decimal keys: 0-9, Back
    private readonly Keys[] _allowedDecimalKeys = [Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9,
        Keys.NumPad0, Keys.NumPad1, Keys.NumPad2, Keys.NumPad3, Keys.NumPad4, Keys.NumPad5, Keys.NumPad6, Keys.NumPad7, Keys.NumPad8, Keys.NumPad9, Keys.Back];

    // Binary keys: 0, 1, Back
    private readonly Keys[] _allowedBinaryKeys = [Keys.D0, Keys.D1, Keys.NumPad0, Keys.NumPad1, Keys.Back];

    // Octal keys: 0, 1, 2, 3, 4, 5, 6, 7, Back
    private readonly Keys[] _allowedOctalKeys = [Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7,
        Keys.NumPad0, Keys.NumPad1, Keys.NumPad2, Keys.NumPad3, Keys.NumPad4, Keys.NumPad5, Keys.NumPad6, Keys.NumPad7, Keys.Back];

    // Hexadecimal keys: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, A, B, C, D, E, F, Back
    private readonly Keys[] _allowedHexadecimalKeys = [Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7,
        Keys.D8, Keys.D9, Keys.NumPad0, Keys.NumPad1, Keys.NumPad2, Keys.NumPad3, Keys.NumPad4, Keys.NumPad5, Keys.NumPad6, Keys.NumPad7,
        Keys.A, Keys.B, Keys.C, Keys.D, Keys.E, Keys.F, Keys.Back];

    public BaseConverter()
    {
        InitializeComponent();

        txtSourceValue.KeyDown += TxtSourceValue_KeyDown;
        txtSourceValue.TextChanged += TxtSourceValue_TextChanged;
        cmbSourceType.SelectedIndexChanged += CmbSourceType_SelectedIndexChanged;
        cmbDestinationType.SelectedIndexChanged += CmbDestinationType_SelectedIndexChanged;
        btnReset.Click += BtnReset_Click;
        lnklblCopy.Click += LnkLblCopy_Click;
        Load += BaseConverter_Load;
    }

    private void BaseConverter_Load(object? sender, EventArgs e)
    {
        Reset();
    }

    private void BtnReset_Click(object? sender, EventArgs e)
    {
        Reset();
    }

    private void TxtSourceValue_TextChanged(object? sender, EventArgs e)
    {
        PerformConversion();
    }

    private void TxtSourceValue_KeyDown(object? sender, KeyEventArgs e)
    {
        e.Handled = cmbSourceType.SelectedItem switch
        {
            "Decimal" => !_allowedDecimalKeys.Contains(e.KeyCode),
            "Binary" => !_allowedBinaryKeys.Contains(e.KeyCode),
            "Octal" => !_allowedOctalKeys.Contains(e.KeyCode),
            "Hexadecimal" => !_allowedHexadecimalKeys.Contains(e.KeyCode),
            _ => e.Handled
        };

        if (e.Handled)
        {
            e.SuppressKeyPress = true;
        }
    }

    private void CmbSourceType_SelectedIndexChanged(object? sender, EventArgs e)
    {
        txtSourceValue.Text = string.Empty;
        txtDestinationValue.Text = string.Empty;
    }

    private void CmbDestinationType_SelectedIndexChanged(object? sender, EventArgs e)
    {
        PerformConversion();
    }

    private void LnkLblCopy_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtDestinationValue.Text))
        {
            return;
        }

        Clipboard.SetText(txtDestinationValue.Text);
    }

    private void PerformConversion()
    {
        if (string.IsNullOrWhiteSpace(txtSourceValue.Text))
        {
            return;
        }

        var sourceNumber = cmbSourceType.SelectedItem switch
        {
            "Decimal" => Convert.ToInt64(txtSourceValue.Text),
            "Binary" => Convert.ToInt64(txtSourceValue.Text, 2),
            "Octal" => Convert.ToInt64(txtSourceValue.Text, 8),
            "Hexadecimal" => Convert.ToInt64(txtSourceValue.Text, 16),
            _ => 0
        };

        txtDestinationValue.Text = cmbDestinationType.SelectedItem switch
        {
            "Decimal" => sourceNumber.ToString(),
            "Binary" => Convert.ToString(sourceNumber, 2),
            "Octal" => Convert.ToString(sourceNumber, 8),
            "Hexadecimal" => Convert.ToString(sourceNumber, 16),
            _ => string.Empty
        };
    }

    private void Reset()
    {
        cmbSourceType.SelectedIndex = 0;
        cmbDestinationType.SelectedIndex = 1;
        txtSourceValue.Text = string.Empty;
        txtDestinationValue.Text = string.Empty;

        txtSourceValue.Focus();
    }
}