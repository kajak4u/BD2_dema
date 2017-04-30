using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsCalendar;

namespace BD2_demaOkien
{
    //this code is awful but I didn't find a better way...
    class DayScheduler : WindowsFormsCalendar.Calendar
    {
        protected override void OnMouseWheel(MouseEventArgs e)
        {
            //disable stupid scrolling with no scrollbar
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            //disable auto scrolling
            ICalendarSelectableElement beg = this.SelectedElementStart;
            ICalendarSelectableElement end = this.SelectedElementEnd;
            bool checkVisibility = false;
            switch (e.KeyCode)
            {
                case Keys.Down:
                    if (end.Date.TimeOfDay + new TimeSpan(0, (int)this.TimeScale, 0) >= new TimeSpan(16, 0, 0))
                        return;
                    checkVisibility = true;
                    break;
                case Keys.Up:
                    if (beg.Date.TimeOfDay <= new TimeSpan(8, 0, 0))
                        return;
                    checkVisibility = true;
                    break;
            }
            base.OnKeyDown(e);
            if (checkVisibility && this.Parent is ScrollableControl)
            {
                ScrollableControl parent = (ScrollableControl)this.Parent;
                ICalendarSelectableElement elem = (e.KeyCode == Keys.Down) ? this.SelectedElementEnd : this.SelectedElementStart;
                Rectangle bounds = elem.Bounds;
                bounds.Location = new Point(bounds.Location.X, bounds.Location.Y + this.Top);
                using (Control c = new Control() { Parent = parent, Bounds = bounds })
                {
                    parent.ScrollControlIntoView(c);
                }
            }
        }
    }
}
