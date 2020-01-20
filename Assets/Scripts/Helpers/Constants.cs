using System.Collections.Generic;
using UnityEngine;
using BallJumper.Enums;


namespace BallJumper
{
    public static class Constants
    {
        public static readonly int DefaultScore = 0;
        public static readonly int DefaultArraySize = 5;
        public static readonly float MaxForceOfBallShift = 10.0f;
        public static readonly float FallHeight = -10.0f;
        public static readonly int FirstTouchElement = 0;

        public static readonly Dictionary<ColorTypes, Color> ColorsDictionary = new Dictionary<ColorTypes, Color>()
        {
            { ColorTypes.Black,   Color.black },
            { ColorTypes.Blue,    Color.blue },
            { ColorTypes.Cyan,    Color.cyan },
            { ColorTypes.Gray,    Color.gray },
            { ColorTypes.Green,   Color.green },
            { ColorTypes.Magenta, Color.magenta },
            { ColorTypes.Red,     Color.red },
            { ColorTypes.White,   Color.white },
            { ColorTypes.Yellow,  Color.yellow }
        };
    }
}
