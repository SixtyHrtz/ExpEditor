using System;

namespace ExpEditor.Core
{
    public static class Helper
    {
        public static int Random(int min, int max)
        {
            var random = new Random((int)DateTime.Now.Ticks);
            return random.Next(min, max + 1);
        }
    }
}
