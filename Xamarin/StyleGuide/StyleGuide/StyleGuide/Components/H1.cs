using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace StyleGuide.Components
{
    public class H1 : Label
    {
        public H1() {
            this.FontFamily = "Headlines";
            this.FontSize = 20;
            var list = new List<string>();
            list.Add("color-brand-01");
            this.StyleClass = list;
        }
    }
}
