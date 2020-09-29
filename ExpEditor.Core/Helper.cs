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

        public static float Random(float min, float max)
        {
            var random = new Random((int)DateTime.Now.Ticks);
            var value01 = random.NextDouble();
            return (float)(min + (value01 * (max - min)));
        }
    }
}
