using System;
using System.Linq;
using UnityEngine;
using BallJumper.Enums;


namespace BallJumper.Models
{
    public class ColoredPlatformModel
    {
        public event Action<Color> OnSwithColor;

        private ColorTypes[] _colors;
        private int _curentIndex;

        public Color _curentColor { get; private set; }

        public ColoredPlatformModel()
        {
            var colors = Constants.ColorsDictionary.Keys;
            _colors = colors.ToArray();

            _curentIndex = 0;
            _curentColor = Constants.ColorsDictionary[_colors[_curentIndex]];
        }
        
        public void SwitchColor()
        {
            _curentIndex++;
            _curentIndex = _curentIndex < _colors.Length ? _curentIndex : 0;
            _curentColor = Constants.ColorsDictionary[_colors[_curentIndex]];

            OnSwithColor?.Invoke(_curentColor);
        }
    }
}
