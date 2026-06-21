using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

/*
 ================================ Boss Battle    The Color    100 XP ==================================
   The second pedestal asks you to create a Color class to represent a color. The pedestal includes an
   etching of this diagram that illustrates its potential usage:
   The color consists of three parts or channels: red, green, and blue, which indicate how much those
   channels are lit up. Each channel can be from 0 to 255. 0 means completely off; 255 means completely
   on.

   The pedestal also includes some color names, with a set of numbers indicating their specific values for
   each channel. These are commonly used colors: White (255, 255, 255), Black (0, 0, 0), Red (255, 0, 0),
   Orange (255,165, 0), Yellow (255, 255, 0), Green (0, 128, 0), Blue (0, 0, 255), Purple (128, 0, 128).

Objectives:
   • Define a new Color class with properties for its red, green, and blue channels.
   • Add appropriate constructors that you feel make sense for creating new Color objects.
   • Create static properties to define the eight commonly used colors for easy access.
   • In your main method, make two Color-typed variables. Use a constructor to create a color instance
   and use a static property for the other. Display each of their red, green, and blue channel values.
 */
namespace Level24_TheCatacombsOfTheClass
{
    internal class Color
    {
        // Define backing fields for the red, green, and blue channels,
        // as byte values ranging from 0 to 255. So no validation is needed for the values.
        private byte _red;
        private byte _green;

        private byte _blue;

        //
        public byte RedChannel
        {
            get => _red;
        }

        public byte GreenChannel
        {
            get => _green;
        }

        public byte BlueChannel
        {
            get => _blue;
        }

        // Define static properties for the eight commonly used colors.
        public static Color White { get; } = new Color(255, 255, 255);
        public static Color Black { get; } = new Color(0, 0, 0);
        public static Color Red { get; } = new Color(255, 0, 0);
        public static Color Orange { get; } = new Color(255, 165, 0);
        public static Color Yellow { get; } = new Color(255, 255, 0);
        public static Color Green { get; } = new Color(0, 128, 0);
        public static Color Blue { get; } = new Color(0, 0, 255);
        public static Color Purple { get; } = new Color(128, 0, 128);


        // Define a default constructor that initializes the color to black (0, 0, 0).
        public Color() : this(0, 0, 0) // Default to black
        {
        }

        // Define a constructor that takes three byte parameters for the red, green, and blue channels.
        public Color(byte R, byte G, byte B)
        {
            _red = R;
            _green = G;
            _blue = B;
        }
    }
}