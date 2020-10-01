using System.Drawing;
using System.Windows.Forms;

namespace ExpEditor.Windows
{
    public static class Helper
    {
        public static int GetTextWidth(this string text) =>
            TextRenderer.MeasureText(text, SystemFonts.DefaultFont).Width;
    }
}
