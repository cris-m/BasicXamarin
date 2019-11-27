using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace BasicXamarin.XAML.Module
{
    public class NamedColor
    {
        public string Name { private set; get; }

        public string FriendlyName { private set; get; }

        public Color Color { private set; get; }

        public string RgbDisplay { private set; get; }

        // Static members.
        static NamedColor()
        {
            List<NamedColor> all = new List<NamedColor>();
            StringBuilder stringBuilder = new StringBuilder();

            // Loop through the public static fields of the Color structure.
            foreach (FieldInfo fieldInfo in typeof(Color).GetRuntimeFields())
            {
                if (fieldInfo.IsPublic &&
                    fieldInfo.IsStatic &&
                    fieldInfo.FieldType == typeof(Color))
                {
                    // Convert the name to a friendly name.
                    string name = fieldInfo.Name;
                    stringBuilder.Clear();
                    int index = 0;

                    foreach (char ch in name)
                    {
                        if (index != 0 && Char.IsUpper(ch))
                        {
                            stringBuilder.Append(' ');
                        }
                        stringBuilder.Append(ch);
                        index++;
                    }

                    // Instantiate a NamedColor object.
                    Color color = (Color)fieldInfo.GetValue(null);

                    NamedColor namedColor = new NamedColor
                    {
                        Name = name,
                        FriendlyName = stringBuilder.ToString(),
                        Color = color,
                        RgbDisplay = String.Format("{0:X2}-{1:X2}-{2:X2}",
                                                   (int)(255 * color.R),
                                                   (int)(255 * color.G),
                                                   (int)(255 * color.B))
                    };

                    // Add it to the collection.
                    all.Add(namedColor);
                }
            }
            all.TrimExcess();
            All = all;
        }

        public static IList<NamedColor> All { private set; get; }

        public static readonly Color aliceblue = Color.FromRgb(240, 248, 255);
        public static readonly Color antiquewhite = Color.FromRgb(250, 235, 215);
        public static readonly Color aqua = Color.FromRgb(0, 255, 255);
        public static readonly Color aquamarine = Color.FromRgb(127, 255, 212);
        public static readonly Color azure = Color.FromRgb(240, 255, 255);
        public static readonly Color beige = Color.FromRgb(245, 245, 220);
        public static readonly Color bisque = Color.FromRgb(255, 228, 196);
        public static readonly Color black = Color.FromRgb(0, 0, 0);
        public static readonly Color blanchedalmond = Color.FromRgb(255, 235, 205);
        public static readonly Color blue = Color.FromRgb(0, 0, 255);
        public static readonly Color blueviolet = Color.FromRgb(138, 43, 226);
        public static readonly Color brown = Color.FromRgb(165, 42, 42);
        public static readonly Color burlywood = Color.FromRgb(222, 184, 135);
        public static readonly Color cadetblue = Color.FromRgb(95, 158, 160);
        public static readonly Color chartreuse = Color.FromRgb(127, 255, 0);
        public static readonly Color chocolate = Color.FromRgb(210, 105, 30);
        public static readonly Color coral = Color.FromRgb(255, 127, 80);
        public static readonly Color cornflowerblue = Color.FromRgb(100, 149, 237);
        public static readonly Color cornsilk = Color.FromRgb(255, 248, 220);
        public static readonly Color crimson = Color.FromRgb(220, 20, 60);
        public static readonly Color cyan = Color.FromRgb(0, 255, 255);
        public static readonly Color darkblue = Color.FromRgb(0, 0, 139);
        public static readonly Color darkcyan = Color.FromRgb(0, 139, 139);
        public static readonly Color darkgoldenrod = Color.FromRgb(184, 134, 11);
        public static readonly Color darkgray = Color.FromRgb(169, 169, 169);
        public static readonly Color darkgreen = Color.FromRgb(0, 100, 0);
        public static readonly Color darkkhaki = Color.FromRgb(189, 183, 107);
        public static readonly Color darkmagenta = Color.FromRgb(139, 0, 139);
        public static readonly Color darkolivegreen = Color.FromRgb(85, 107, 47);
        public static readonly Color darkorange = Color.FromRgb(255, 140, 0);
        public static readonly Color darkorchid = Color.FromRgb(153, 50, 204);
        public static readonly Color darkred = Color.FromRgb(139, 0, 0);
        public static readonly Color darksalmon = Color.FromRgb(233, 150, 122);
        public static readonly Color darkseagreen = Color.FromRgb(143, 188, 139);
        public static readonly Color darkslateblue = Color.FromRgb(72, 61, 139);
        public static readonly Color darkslategray = Color.FromRgb(47, 79, 79);
        public static readonly Color darkturquoise = Color.FromRgb(0, 206, 209);
        public static readonly Color darkviolet = Color.FromRgb(148, 0, 211);
        public static readonly Color deeppink = Color.FromRgb(255, 20, 147);
        public static readonly Color deepskyblue = Color.FromRgb(0, 191, 255);
        public static readonly Color dimgray = Color.FromRgb(105, 105, 105);
        public static readonly Color dodgerblue = Color.FromRgb(30, 144, 255);
        public static readonly Color firebrick = Color.FromRgb(178, 34, 34);
        public static readonly Color floralwhite = Color.FromRgb(255, 250, 240);
        public static readonly Color forestgreen = Color.FromRgb(34, 139, 34);
        public static readonly Color fuchsia = Color.FromRgb(255, 0, 255);
        public static readonly Color gainsboro = Color.FromRgb(220, 220, 220);
        public static readonly Color ghostwhite = Color.FromRgb(248, 248, 255);
        public static readonly Color gold = Color.FromRgb(255, 215, 0);
        public static readonly Color goldenrod = Color.FromRgb(218, 165, 32);
        public static readonly Color gray = Color.FromRgb(128, 128, 128);
        public static readonly Color green = Color.FromRgb(0, 128, 0);
        public static readonly Color greenyellow = Color.FromRgb(173, 255, 47);
        public static readonly Color honeydew = Color.FromRgb(240, 255, 240);
        public static readonly Color hotpink = Color.FromRgb(255, 105, 180);
        public static readonly Color indianred = Color.FromRgb(205, 92, 92);
        public static readonly Color indigo = Color.FromRgb(75, 0, 130);
        public static readonly Color ivory = Color.FromRgb(255, 255, 240);
        public static readonly Color khaki = Color.FromRgb(240, 230, 140);
        public static readonly Color lavender = Color.FromRgb(230, 230, 250);
        public static readonly Color lavenderblush = Color.FromRgb(255, 240, 245);
        public static readonly Color lawngreen = Color.FromRgb(124, 252, 0);
        public static readonly Color lemonchiffon = Color.FromRgb(255, 250, 205);
        public static readonly Color lightblue = Color.FromRgb(173, 216, 230);
        public static readonly Color lightcoral = Color.FromRgb(240, 128, 128);
        public static readonly Color lightcyan = Color.FromRgb(224, 255, 255);
        public static readonly Color lightgoldenrodyellow = Color.FromRgb(250, 250, 210);
        public static readonly Color lightgray = Color.FromRgb(211, 211, 211);
        public static readonly Color lightgreen = Color.FromRgb(144, 238, 144);
        public static readonly Color lightpink = Color.FromRgb(255, 182, 193);
        public static readonly Color lightsalmon = Color.FromRgb(255, 160, 122);
        public static readonly Color lightseagreen = Color.FromRgb(32, 178, 170);
        public static readonly Color lightskyblue = Color.FromRgb(135, 206, 250);
        public static readonly Color lightslategray = Color.FromRgb(119, 136, 153);
        public static readonly Color lightsteelblue = Color.FromRgb(176, 196, 222);
        public static readonly Color lightyellow = Color.FromRgb(255, 255, 224);
        public static readonly Color lime = Color.FromRgb(0, 255, 0);
        public static readonly Color limegreen = Color.FromRgb(50, 205, 50);
        public static readonly Color linen = Color.FromRgb(250, 240, 230);
        public static readonly Color magenta = Color.FromRgb(255, 0, 255);
        public static readonly Color maroon = Color.FromRgb(128, 0, 0);
        public static readonly Color mediumaquamarine = Color.FromRgb(102, 205, 170);
        public static readonly Color mediumblue = Color.FromRgb(0, 0, 205);
        public static readonly Color mediumorchid = Color.FromRgb(186, 85, 211);
        public static readonly Color mediumpurple = Color.FromRgb(147, 112, 219);
        public static readonly Color mediumseagreen = Color.FromRgb(60, 179, 113);
        public static readonly Color mediumslateblue = Color.FromRgb(123, 104, 238);
        public static readonly Color mediumspringgreen = Color.FromRgb(0, 250, 154);
        public static readonly Color mediumturquoise = Color.FromRgb(72, 209, 204);
        public static readonly Color mediumvioletred = Color.FromRgb(199, 21, 133);
        public static readonly Color midnightblue = Color.FromRgb(25, 25, 112);
        public static readonly Color mintcream = Color.FromRgb(245, 255, 250);
        public static readonly Color mistyrose = Color.FromRgb(255, 228, 225);
        public static readonly Color moccasin = Color.FromRgb(255, 228, 181);
        public static readonly Color navajowhite = Color.FromRgb(255, 222, 173);
        public static readonly Color navy = Color.FromRgb(0, 0, 128);
        public static readonly Color oldlace = Color.FromRgb(253, 245, 230);
        public static readonly Color olive = Color.FromRgb(128, 128, 0);
        public static readonly Color olivedrab = Color.FromRgb(107, 142, 35);
        public static readonly Color orange = Color.FromRgb(255, 165, 0);
        public static readonly Color orangered = Color.FromRgb(255, 69, 0);
        public static readonly Color orchid = Color.FromRgb(218, 112, 214);
        public static readonly Color palegoldenrod = Color.FromRgb(238, 232, 170);
        public static readonly Color palegreen = Color.FromRgb(152, 251, 152);
        public static readonly Color paleturquoise = Color.FromRgb(175, 238, 238);
        public static readonly Color palevioletred = Color.FromRgb(219, 112, 147);
        public static readonly Color papayawhip = Color.FromRgb(255, 239, 213);
        public static readonly Color peachpuff = Color.FromRgb(255, 218, 185);
        public static readonly Color peru = Color.FromRgb(205, 133, 63);
        public static readonly Color pink = Color.FromRgb(255, 192, 203);
        public static readonly Color plum = Color.FromRgb(221, 160, 221);
        public static readonly Color powderblue = Color.FromRgb(176, 224, 230);
        public static readonly Color purple = Color.FromRgb(128, 0, 128);
        public static readonly Color red = Color.FromRgb(255, 0, 0);
        public static readonly Color rosybrown = Color.FromRgb(188, 143, 143);
        public static readonly Color royalblue = Color.FromRgb(65, 105, 225);
        public static readonly Color saddlebrown = Color.FromRgb(139, 69, 19);
        public static readonly Color salmon = Color.FromRgb(250, 128, 114);
        public static readonly Color sandybrown = Color.FromRgb(244, 164, 96);
        public static readonly Color seagreen = Color.FromRgb(46, 139, 87);
        public static readonly Color seashell = Color.FromRgb(255, 245, 238);
        public static readonly Color sienna = Color.FromRgb(160, 82, 45);
        public static readonly Color silver = Color.FromRgb(192, 192, 192);
        public static readonly Color skyblue = Color.FromRgb(135, 206, 235);
        public static readonly Color slateblue = Color.FromRgb(106, 90, 205);
        public static readonly Color slategray = Color.FromRgb(112, 128, 144);
        public static readonly Color snow = Color.FromRgb(255, 250, 250);
        public static readonly Color springgreen = Color.FromRgb(0, 255, 127);
        public static readonly Color steelblue = Color.FromRgb(70, 130, 180);
        public static readonly Color tan = Color.FromRgb(210, 180, 140);
        public static readonly Color teal = Color.FromRgb(0, 128, 128);
        public static readonly Color thistle = Color.FromRgb(216, 191, 216);
        public static readonly Color tomato = Color.FromRgb(255, 99, 71);
        public static readonly Color turquoise = Color.FromRgb(64, 224, 208);
        public static readonly Color violet = Color.FromRgb(238, 130, 238);
        public static readonly Color wheat = Color.FromRgb(245, 222, 179);
        public static readonly Color white = Color.FromRgb(255, 255, 255);
        public static readonly Color whitesmoke = Color.FromRgb(245, 245, 245);
        public static readonly Color yellow = Color.FromRgb(255, 255, 0);
        public static readonly Color yellowgreen = Color.FromRgb(154, 205, 50);

    }
}
