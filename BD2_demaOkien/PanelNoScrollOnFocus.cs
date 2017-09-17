using System;
using System.Windows.Forms;

namespace BD2_demaOkien
{
    public class PanelNoScrollOnFocus : Panel
    {
        public bool EnableAutoScrolling { get; set; }
        public PanelNoScrollOnFocus() : base()
        {
            EnableAutoScrolling = false;
        }
        protected override System.Drawing.Point ScrollToControl(Control activeControl)
        {
            if (EnableAutoScrolling)
                return base.ScrollToControl(activeControl);
            else
                return DisplayRectangle.Location;
        }
    }
}