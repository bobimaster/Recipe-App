using System.Drawing;
using System.Windows.Forms;

public static class ManageThemes
{
    public static bool darkMode = false;

    public static void ApplyTheme(Form form)
    {
        Color backColor = darkMode ? Color.FromArgb(40, 40, 40) : SystemColors.Control;
        Color foreColor = darkMode ? Color.White : Color.Black;
        Color rtbBackColor = darkMode ? Color.FromArgb(60, 60, 60) : Color.White;
        Color titleBarColor = darkMode ? Color.Black : Color.LightGray;
        form.BackColor = backColor;

        foreach (Control c in form.Controls)
        {
            if (c is Label || c is Button)
            {
                c.BackColor = backColor;
                c.ForeColor = foreColor;
            }
            else if (c is RichTextBox rtb)
            {
                rtb.BackColor = rtbBackColor;
                rtb.ForeColor = foreColor;
            }
            else if (c is TextBox tb)
            {
                tb.BackColor = backColor;
                tb.ForeColor = foreColor;
            }
            else if (c is Panel panel && panel.Name == "panelTitleBar")
            {
                panel.BackColor = titleBarColor;

                foreach (Control inner in panel.Controls)
                {
                    inner.ForeColor = foreColor;
                    inner.BackColor = titleBarColor;
                }
            }
        }
    }
}
