
namespace FGL.Mathf
{
    public static class FGLMathf
    {
        public static int ClampLoop(int value, int min, int max)
        {
            if (value > max)
            {
                return min;
            }
            if (value < min)
            {
                return max;
            }
            else
            {
                return value;
            }
        }

        public static float ClampLoop(float value, float min, float max)
        {
            if (value > max)
            {
                return min;
            }
            if (value < min)
            {
                return max;
            }
            else
            {
                return value;
            }
        }
    }
}
