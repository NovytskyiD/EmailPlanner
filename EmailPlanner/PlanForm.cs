using System;
using System.Windows.Forms;

namespace EmailPlanner
{
    public partial class PlanForm : Form
    {
        public PlanForm()
        {
            InitializeComponent();
        }

        private void firstLetterDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            secondLetterDateTimePicker.Value = firstLetterDateTimePicker.Value.AddDays(7);
            thirdLetterDateTimePicker.Value = firstLetterDateTimePicker.Value.AddDays(14);
            fourthLetterDateTimePicker.Value = firstLetterDateTimePicker.Value.AddDays(21);
        }
    }
}
