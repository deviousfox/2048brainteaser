
using UnityEngine;

namespace FGL.String
{
    public static class FGLString
    {
        public static string TimeToString(float t)
        {
            return (t - (t % 60)) / 60 + ":" + t % 60;
        }

        
    }
    public struct StringWithColor
    {
        public Color _color { get; private set; }
        public string _string { get; private set; }

        public StringWithColor(Color _color, string _string = null)
        {
            this._color = _color;
            this._string = _string;
        }
    }
}

