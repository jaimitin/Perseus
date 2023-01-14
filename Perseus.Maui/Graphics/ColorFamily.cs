using Microsoft.Maui.Graphics;

namespace Perseus.Maui.Graphics
{
    /// <summary>
    /// Represents a <see cref="Microsoft.Maui.Graphics.Color"/> and its possible tints/shades
    /// </summary>
    public readonly struct ColorFamily
    {
        /// <summary>
        /// Initialize a new <see cref="ColorFamily"/> based on the base <paramref name="color"/>
        /// </summary>
        public ColorFamily(Color color)
        {
            float l = color.GetLuminosity();

            Tint9 = color.WithLuminosity(l + (l * 0.9f));
            Tint8 = color.WithLuminosity(l + (l * 0.8f));
            Tint7 = color.WithLuminosity(l + (l * 0.7f));
            Tint6 = color.WithLuminosity(l + (l * 0.6f));
            Tint5 = color.WithLuminosity(l + (l * 0.5f));
            Tint4 = color.WithLuminosity(l + (l * 0.4f));
            Tint3 = color.WithLuminosity(l + (l * 0.3f));
            Tint2 = color.WithLuminosity(l + (l * 0.2f));
            Tint1 = color.WithLuminosity(l + (l * 0.1f));

            Color = color;

            Shade1 = color.WithLuminosity(l - (l * 0.1f));
            Shade2 = color.WithLuminosity(l - (l * 0.2f));
            Shade3 = color.WithLuminosity(l - (l * 0.3f));
            Shade4 = color.WithLuminosity(l - (l * 0.4f));
            Shade5 = color.WithLuminosity(l - (l * 0.5f));
            Shade6 = color.WithLuminosity(l - (l * 0.6f));
            Shade7 = color.WithLuminosity(l - (l * 0.7f));
            Shade8 = color.WithLuminosity(l - (l * 0.8f));
            Shade9 = color.WithLuminosity(l - (l * 0.9f));
        }

        /// <summary>
        /// 90% Lighter
        /// </summary>
        public Color Tint9 { get; }

        /// <summary>
        /// 80% Lighter
        /// </summary>
        public Color Tint8 { get; }

        /// <summary>
        /// 70% Lighter
        /// </summary>
        public Color Tint7 { get; }

        /// <summary>
        /// 60% Lighter
        /// </summary>
        public Color Tint6 { get; }

        /// <summary>
        /// 50% Lighter
        /// </summary>
        public Color Tint5 { get; }

        /// <summary>
        /// 40% Lighter
        /// </summary>
        public Color Tint4 { get; }

        /// <summary>
        /// 30% Lighter
        /// </summary>
        public Color Tint3 { get; }

        /// <summary>
        /// 20% Lighter
        /// </summary>
        public Color Tint2 { get; }

        /// <summary>
        /// 10% Lighter
        /// </summary>
        public Color Tint1 { get; }

        /// <summary>
        /// Actual color
        /// </summary>
        public Color Color { get; }

        /// <summary>
        /// 10% Darker
        /// </summary>
        public Color Shade1 { get; }

        /// <summary>
        /// 20% Darker
        /// </summary>
        public Color Shade2 { get; }

        /// <summary>
        /// 30% Darker
        /// </summary>
        public Color Shade3 { get; }

        /// <summary>
        /// 40% Darker
        /// </summary>
        public Color Shade4 { get; }

        /// <summary>
        /// 50% Darker
        /// </summary>
        public Color Shade5 { get; }

        /// <summary>
        /// 60% Darker
        /// </summary>
        public Color Shade6 { get; }

        /// <summary>
        /// 70% Darker
        /// </summary>
        public Color Shade7 { get; }

        /// <summary>
        /// 80% Darker
        /// </summary>
        public Color Shade8 { get; }

        /// <summary>
        /// 90% Darker
        /// </summary>
        public Color Shade9 { get; }


        /// <inheritdoc cref="ColorFamily(Color)"/>
        public static implicit operator ColorFamily(Color color)
        {
            return new(color);
        }
    }
}
