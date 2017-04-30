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
        private TimeSpan _dayBegin = new TimeSpan(0,0,0);
        private TimeSpan _dayEnd = new TimeSpan(24,0,0);
        public TimeSpan dayBegin
        {
            get {   return _dayBegin; }
            set {   _dayBegin = value; UpdatePos(); }
        }
        public TimeSpan dayEnd
        {
            get { return _dayEnd; }
            set { _dayEnd = value; UpdatePos(); }
        }
        private DateTime TodayDate {
            get { return this.Days[0].Date; }
        }
        private TimeSpan Interval
        {
            get { return new TimeSpan(0, (int)this.TimeScale, 0); }
        }
        public new void SetViewRange(DateTime dateStart, DateTime dateEnd)
        {
            base.SetViewRange(dateStart, dateEnd);
            UpdatePos();
        }
        private void UpdatePos()
        {
            DateTime date = TodayDate;
            DateTime begin = date + dayBegin;
            DateTime end = date + dayEnd - Interval;
            CalendarTimeScaleUnit unit = GetTimeUnit(begin);
            CalendarTimeScaleUnit unit2 = GetTimeUnit(end);
            this.Top = -unit.Bounds.Top;
            this.Height = unit2.Bounds.Bottom;
        }
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
            bool suspendBaseEvent = false;
            switch (e.KeyCode)
            {
                case Keys.Down:
                    if(end == null)
                    {
                        suspendBaseEvent = true;
                        end = GetTimeUnit(TodayDate + dayBegin);
                        this.SetSelectionRange(end, end);
                    }
                    else if (end.Date.TimeOfDay + Interval >= this.dayEnd)
                        return;
                    checkVisibility = true;
                    break;
                case Keys.Up:
                    if(beg == null)
                    {
                        suspendBaseEvent = true;
                        beg = GetTimeUnit(TodayDate + dayEnd - Interval);
                        this.SetSelectionRange(beg, beg);
                    }
                    else if (beg.Date.TimeOfDay <= this.dayBegin)
                        return;
                    checkVisibility = true;
                    break;
            }
            if(!suspendBaseEvent)
                base.OnKeyDown(e);
            if (checkVisibility && this.Parent is ScrollableControl)
            {
                ScrollableControl parent = (ScrollableControl)this.Parent;
                ICalendarSelectableElement elem;
                if (suspendBaseEvent)
                    elem = (e.KeyCode == Keys.Down) ? end : beg ;
                else
                    elem = (e.KeyCode == Keys.Down) ? this.SelectedElementEnd : this.SelectedElementStart;
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
