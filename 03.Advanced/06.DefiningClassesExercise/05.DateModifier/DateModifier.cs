using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    internal class DateModifier
    {
        private int differenceInDays;
        private DateTime firstDate;
        private DateTime secondDate;

        public DateModifier(string firstDate, string secondDate)
        {
            this.firstDate = DateTime.Parse(firstDate);
            this.secondDate = DateTime.Parse(secondDate);
        }

        public int DifferenceInDays 
        {
            get
            {
                return differenceInDays = Math.Abs((int)(firstDate - secondDate).TotalDays);
            }
        }
    }
}