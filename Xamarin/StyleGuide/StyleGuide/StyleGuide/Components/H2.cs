using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace StyleGuide.Components
{
    public class H2 : Label
    {
        public H2() {
            this.FontFamily = "Headlines";
            this.FontSize = 15;
            var list = new List<string>();
            list.Add("color-brand-02");
            this.StyleClass = list;
        }
    }
}
