using Microsoft.Maui.Graphics;
using Perseus.Maui.Graphics;

namespace Perseus.Maui.Tests
{
    public class GraphicsTests
    {
        [Test]
        public void ColorFamilyGeneration()
        {
            Color expectedTint9 = Color.FromArgb("#f0ecf6");
            Color expectedTint8 = Color.FromArgb("#e0d9ed");
            Color expectedTint7 = Color.FromArgb("#d1c6e4");
            Color expectedTint6 = Color.FromArgb("#c1b3db");
            Color expectedTint5 = Color.FromArgb("#b2a0d2");
            Color expectedTint4 = Color.FromArgb("#a28dc9");
            Color expectedTint3 = Color.FromArgb("#937ac0");
            Color expectedTint2 = Color.FromArgb("#8367b7");
            Color expectedTint1 = Color.FromArgb("#7454ae");

            Color baseColor = Color.FromArgb("#6441a5");

            Color expectedShade9 = Color.FromArgb("#0a0610");
            Color expectedShade8 = Color.FromArgb("#140d21");
            Color expectedShade7 = Color.FromArgb("#1e1331");
            Color expectedShade6 = Color.FromArgb("#281a42");
            Color expectedShade5 = Color.FromArgb("#322153");
            Color expectedShade4 = Color.FromArgb("#3c2763");
            Color expectedShade3 = Color.FromArgb("#462e73");
            Color expectedShade2 = Color.FromArgb("#503484");
            Color expectedShade1 = Color.FromArgb("#5a3b95");

            ColorFamily colorFam = baseColor;

            Assert.Multiple(() =>
            {
                // Tints are failing, though they are (kinda) close to the "desired" result
                // when tested side by side with https://maketintsandshades.com/#6441A5.
                //
                // Will look into this another time since the gradient looks natural enough

                Assert.That(colorFam.Tint9, Is.EqualTo(expectedTint9), nameof(ColorFamily.Tint9));
                Assert.That(colorFam.Tint8, Is.EqualTo(expectedTint8), nameof(ColorFamily.Tint8));
                Assert.That(colorFam.Tint7, Is.EqualTo(expectedTint7), nameof(ColorFamily.Tint7));
                Assert.That(colorFam.Tint6, Is.EqualTo(expectedTint6), nameof(ColorFamily.Tint6));
                Assert.That(colorFam.Tint5, Is.EqualTo(expectedTint5), nameof(ColorFamily.Tint5));
                Assert.That(colorFam.Tint4, Is.EqualTo(expectedTint4), nameof(ColorFamily.Tint4));
                Assert.That(colorFam.Tint3, Is.EqualTo(expectedTint3), nameof(ColorFamily.Tint3));
                Assert.That(colorFam.Tint2, Is.EqualTo(expectedTint2), nameof(ColorFamily.Tint2));
                Assert.That(colorFam.Tint1, Is.EqualTo(expectedTint1), nameof(ColorFamily.Tint1));

                Assert.That(colorFam.Color, Is.EqualTo(baseColor));

                Assert.That(colorFam.Shade9, Is.EqualTo(expectedShade9), nameof(ColorFamily.Shade9));
                Assert.That(colorFam.Shade8, Is.EqualTo(expectedShade8), nameof(ColorFamily.Shade8));
                Assert.That(colorFam.Shade7, Is.EqualTo(expectedShade7), nameof(ColorFamily.Shade7));
                Assert.That(colorFam.Shade6, Is.EqualTo(expectedShade6), nameof(ColorFamily.Shade6));
                Assert.That(colorFam.Shade5, Is.EqualTo(expectedShade5), nameof(ColorFamily.Shade5));
                Assert.That(colorFam.Shade4, Is.EqualTo(expectedShade4), nameof(ColorFamily.Shade4));
                Assert.That(colorFam.Shade3, Is.EqualTo(expectedShade3), nameof(ColorFamily.Shade3));
                Assert.That(colorFam.Shade2, Is.EqualTo(expectedShade2), nameof(ColorFamily.Shade2));
                Assert.That(colorFam.Shade1, Is.EqualTo(expectedShade1), nameof(ColorFamily.Shade1));
            });
        }
    }
}
