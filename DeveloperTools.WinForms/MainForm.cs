namespace DeveloperTools.WinForms;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        tbMainNavigation.DrawItem += TbMainNavigation_DrawItem;
    }

    private void TbMainNavigation_DrawItem(object? sender, DrawItemEventArgs e)
    {
        var g = e.Graphics;
        Brush textBrush;

        // Get the item from the collection.
        var tabPage = tbMainNavigation.TabPages[e.Index];

        // Get the real bounds for the tab rectangle.
        var tabBounds = tbMainNavigation.GetTabRect(e.Index);

        if (e.State == DrawItemState.Selected)
        {
            // Draw a different background color, and don't paint a focus rectangle.
            textBrush = new SolidBrush(Color.Black);
            g.FillRectangle(new SolidBrush(Color.FromKnownColor(KnownColor.ControlLight)), e.Bounds);
        }
        else
        {
            textBrush = new SolidBrush(Color.Black);
            e.DrawBackground();
        }

        // Draw string. Center the text.
        var stringFlags = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center
        };

        g.DrawString(tabPage.Text, tabPage.Font, textBrush, tabBounds, new StringFormat(stringFlags));
    }
}