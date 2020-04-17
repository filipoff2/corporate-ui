using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace StyleGuide.Components
{
    class CIcon : Label
    {
        public CIcon()
        {
            this.FontFamily = "Icons";
            this.FontSize = 20;
            var list = new List<string>();
            list.Add("color-brand-02");
            this.StyleClass = list;
        }
    }
}
