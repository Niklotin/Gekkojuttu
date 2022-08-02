using System;
using System.Windows.Forms;

namespace aikakoneGekko
{
    
    public partial class Form1 : Form
    {

        DateTime startDate = new DateTime();
        DateTime endDate = new DateTime();


        //set min&max date for the Datetime pickers, and intialize component
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.MaxDate = DateTime.Now.Date;
            dateTimePicker1.MinDate = new DateTime(2013, 4, 28);
            dateTimePicker2.MaxDate = DateTime.Now.Date;
            dateTimePicker2.Value = DateTime.Now.Date;
            dateTimePicker2.MinDate = new DateTime(2013, 4, 28);
        }


        // GetData button, if the start date is set before the end date display a warning text
        // If not then do stuff
        private void GetData_Click(object sender, EventArgs e)
        {
            long startingDateTimestamp = datajutut.TimeThings.DateTimetoUnixTimeStamp(startDate);
            long endingDateTimestamp = datajutut.TimeThings.DateTimetoUnixTimeStamp(endDate);

            if(startingDateTimestamp > endingDateTimestamp)
            {
                varoitusLabel.Text = "Unfortunately you have to start before you end.\nPlease set the starting date before the ending date.";
            }
            else
            {
                varoitusLabel.Text = "";
                System.Threading.Tasks.Task task = apijutut.ApiHelper.GetData(startingDateTimestamp, endingDateTimestamp + 3600);
                loadedDataLabel.Text = "Loaded data from: " + dateTimePicker1.Value + " to " + dateTimePicker2.Value;
            }
        }
        /// <summary>
        /// Sets the date for dateTimePicker1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            startDate = this.dateTimePicker1.Value;
            startDate = DateTime.SpecifyKind(startDate, DateTimeKind.Utc);
        }
        /// <summary>
        /// Sets the date for dateTimePicker2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            endDate = this.dateTimePicker2.Value;
            endDate = DateTime.SpecifyKind(endDate, DateTimeKind.Utc);
        }
        /// <summary>
        /// Gets the data for the bearishBox (bearish trend)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            bearishBox.Text = datajutut.DataThings.HaluttuData(1);
        } 
        /// <summary>
        /// Gets the data for the trading volume box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            TradingVolumeBox.Text = datajutut.DataThings.HaluttuData(2);
        }
        /// <summary>
        /// Gets the data for the timemachine button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void manipulateButton_Click(object sender, EventArgs e)
        {
            TimeSheenBox.Text = datajutut.DataThings.HaluttuData(3);
        }

    }
}
