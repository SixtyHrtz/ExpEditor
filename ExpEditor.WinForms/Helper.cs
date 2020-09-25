using System.Drawing;
using System.Windows.Forms;

namespace ExpEditor.WinForms
{
    public static class Helper
    {
        public static int GetTextWidth(this string text) =>
            TextRenderer.MeasureText(text, SystemFonts.DefaultFont).Width;
    }
}
