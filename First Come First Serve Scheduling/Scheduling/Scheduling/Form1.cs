using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduling
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();


/*            //Start Time
            string ST1 = lbl3_2.Text;
            string ST2 = lbl3_3.Text;
            string ST3 = lbl3_4.Text;
            string ST4 = lbl3_5.Text;

            //Finish Time
            string FT1 = lbl4_2.Text;
            string FT2 = lbl4_3.Text;
            string FT3 = lbl4_4.Text;
            string FT4 = lbl4_5.Text;


            //Waiting Time
            string WT1 = lbl5_2.Text;
            string WT2 = lbl5_3.Text;
            string WT3 = lbl5_4.Text;
            string WT4 = lbl5_5.Text;

            //Time Allocation
            string TA1 = lbl6_2.Text;
            string TA2 = lbl6_3.Text;
            string TA3 = lbl6_4.Text;
            string TA4 = lbl6_5.Text;
*/

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        { }

            
         

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
           
        }

        private void lbl1_2_Click(object sender, EventArgs e)
        {

        }

        private void tbAT1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnGenerate_Click_1(object sender, EventArgs e)
        {

            // Check the first pair
            if (string.IsNullOrEmpty(tbAT1.Text) || string.IsNullOrEmpty(tbBT1.Text))
            {
                lbl0_2.Text = "P1";
                lbl1_2.Text = "0";
                lbl2_2.Text = "0";
            }
            else
            {
                lbl0_2.Text = "P1";
                lbl1_2.Text = tbAT1.Text;
                lbl2_2.Text = tbBT1.Text;
            }

            // Check the second pair
            if (string.IsNullOrEmpty(tbAT2.Text) || string.IsNullOrEmpty(tbBT2.Text))
            {
                lbl0_3.Text = "P2";
                lbl1_3.Text = "0";
                lbl2_3.Text = "0";
            }
            else
            {
                lbl0_3.Text = "P2";
                lbl1_3.Text = tbAT2.Text;
                lbl2_3.Text = tbBT2.Text;
            }

            // Check the third pair
            if (string.IsNullOrEmpty(tbAT3.Text) || string.IsNullOrEmpty(tbBT3.Text))
            {
                lbl0_4.Text = "P3";
                lbl1_4.Text = "0";
                lbl2_4.Text = "0";
            }
            else
            {
                lbl0_4.Text = "P3";
                lbl1_4.Text = tbAT3.Text;
                lbl2_4.Text = tbBT3.Text;
            }

            // Check the fourth pair
            if (string.IsNullOrEmpty(tbAT4.Text) || string.IsNullOrEmpty(tbBT4.Text))
            {
                lbl0_5.Text = "P4";
                lbl1_5.Text = "0";
                lbl2_5.Text = "0";
            }
            else
            {
                lbl0_5.Text = "P4";
                lbl1_5.Text = tbAT4.Text;
                lbl2_5.Text = tbBT4.Text;
            }

            btnFCFS.Enabled = true;
            btnSPN.Enabled = true;

            for (int i = 3; i <= 6; i++)
            {
                for (int j = 2; j <= 5; j++)
                {
                    // Construct the label name dynamically
                    string labelName = $"lbl{i}_{j}";

                    // Find the control by name (assuming this code is within a form or control that contains the labels)
                    Control lbl = this.Controls.Find(labelName, true).FirstOrDefault();

                    // If the label is found, set its Text property to an empty string
                    if (lbl != null)
                    {
                        lbl.Text = "";
                    }
                }
            }

            /*
                        lbl0_2.Text = "P1";
                        lbl0_3.Text = "P2";
                        lbl0_4.Text = "P3";
                        lbl0_5.Text = "P4";

                        lbl1_2.Text = tbAT1.Text;
                        lbl1_3.Text = tbAT2.Text;
                        lbl1_4.Text = tbAT3.Text;
                        lbl1_5.Text = tbAT4.Text;

                        lbl2_2.Text = tbBT1.Text;
                        lbl2_3.Text = tbBT2.Text;
                        lbl2_4.Text = tbBT3.Text;
                        lbl2_5.Text = tbBT4.Text;

                        */
        }

        private void lbl1_3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click_1(object sender, EventArgs e)
        {

        }

        private void btnFCFS_Click(object sender, EventArgs e)
        {
            try
            {
                btnFCFS.Enabled = false;
                btnSPN.Enabled = false;

                lblFCFS.Text = "First Come First Serve";
                lblSPN.Text = "";
                // Initialize variables to hold parsed values, using nullable integers
                int? AT1 = TryParseNullableInt(lbl1_2.Text);
                int? AT2 = TryParseNullableInt(lbl1_3.Text);
                int? AT3 = TryParseNullableInt(lbl1_4.Text);
                int? AT4 = TryParseNullableInt(lbl1_5.Text);

                int? BT1 = TryParseNullableInt(lbl2_2.Text);
                int? BT2 = TryParseNullableInt(lbl2_3.Text);
                int? BT3 = TryParseNullableInt(lbl2_4.Text);
                int? BT4 = TryParseNullableInt(lbl2_5.Text);

                // Create a list of processes with their arrival and burst times
                var processes = new List<(string Name, int? ArrivalTime, int? BurstTime, int Index)>
                    {
                        ("P1", AT1, BT1, 0),
                        ("P2", AT2, BT2, 1),
                        ("P3", AT3, BT3, 2),
                        ("P4", AT4, BT4, 3)
                    };

                // Check for null values and show an error if any are found
                if (processes.Any(p => p.ArrivalTime == null || p.BurstTime == null))
                {
                    MessageBox.Show("All fields must be filled with valid integers.");

                    lblFCFS.Text = "";
                    lblSPN.Text = "";

                    btnFCFS.Enabled = true;
                    btnSPN.Enabled = true;
                    return;


                }

                // Sort processes by arrival time, and then by their index to handle ties
                var sortedProcesses = processes.OrderBy(p => p.ArrivalTime).ThenBy(p => p.Index).ToList();

                // Create arrays for storing the results
                int[] startTimes = new int[4];
                int[] finishTimes = new int[4];
                int[] waitingTimes = new int[4];
                int[] timeAllocations = new int[4];

                // Initialize the first process
                startTimes[0] = sortedProcesses[0].ArrivalTime.Value;
                finishTimes[0] = startTimes[0] + sortedProcesses[0].BurstTime.Value;
                waitingTimes[0] = 0;
                timeAllocations[0] = finishTimes[0] - sortedProcesses[0].ArrivalTime.Value;

                // Calculate times for subsequent processes
                for (int i = 1; i < sortedProcesses.Count; i++)
                {
                    startTimes[i] = Math.Max(finishTimes[i - 1], sortedProcesses[i].ArrivalTime.Value);
                    waitingTimes[i] = startTimes[i] - sortedProcesses[i].ArrivalTime.Value;
                    finishTimes[i] = startTimes[i] + sortedProcesses[i].BurstTime.Value;
                    timeAllocations[i] = finishTimes[i] - sortedProcesses[i].ArrivalTime.Value;
                }

                // Assign the sorted process names, arrival times, and burst times to labels
                lbl0_2.Text = sortedProcesses[0].Name;
                lbl0_3.Text = sortedProcesses[1].Name;
                lbl0_4.Text = sortedProcesses[2].Name;
                lbl0_5.Text = sortedProcesses[3].Name;

                lbl1_2.Text = sortedProcesses[0].ArrivalTime.ToString();
                lbl1_3.Text = sortedProcesses[1].ArrivalTime.ToString();
                lbl1_4.Text = sortedProcesses[2].ArrivalTime.ToString();
                lbl1_5.Text = sortedProcesses[3].ArrivalTime.ToString();

                lbl2_2.Text = sortedProcesses[0].BurstTime.ToString();
                lbl2_3.Text = sortedProcesses[1].BurstTime.ToString();
                lbl2_4.Text = sortedProcesses[2].BurstTime.ToString();
                lbl2_5.Text = sortedProcesses[3].BurstTime.ToString();

                // Assign the start times to labels
                lbl3_2.Text = startTimes[0].ToString();
                lbl3_3.Text = startTimes[1].ToString();
                lbl3_4.Text = startTimes[2].ToString();
                lbl3_5.Text = startTimes[3].ToString();

                // Assign the finish times to labels
                lbl4_2.Text = finishTimes[0].ToString();
                lbl4_3.Text = finishTimes[1].ToString();
                lbl4_4.Text = finishTimes[2].ToString();
                lbl4_5.Text = finishTimes[3].ToString();

                // Assign the waiting times to labels
                lbl5_2.Text = waitingTimes[0].ToString();
                lbl5_3.Text = waitingTimes[1].ToString();
                lbl5_4.Text = waitingTimes[2].ToString();
                lbl5_5.Text = waitingTimes[3].ToString();

                // Assign the time allocations to labels
                lbl6_2.Text = timeAllocations[0].ToString();
                lbl6_3.Text = timeAllocations[1].ToString();
                lbl6_4.Text = timeAllocations[2].ToString();
                lbl6_5.Text = timeAllocations[3].ToString();


                int inputSubtract = 0;
                for (int i = 0; i < 4; i++)
                {
                    if (timeAllocations[i] == 0 && waitingTimes[i] == 0)
                    {
                        inputSubtract++;
                    }

                    
                }

                // Total Time Allocation
                double TTA = timeAllocations.Sum();
                lblTTA2.Text = TTA.ToString();

                // Average Time Allocation
                double ATA = TTA / (4 - inputSubtract);
                lblATA.Text = ATA.ToString("F3");

                // Total Waiting Time
                double TWT = waitingTimes.Sum();
                lblTWT.Text = TWT.ToString();

                // Average Waiting Time
                double AWT = TWT / (4 - inputSubtract);
                lblAWT2.Text = AWT.ToString("F3");






            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        // Helper method to try parsing a string to a nullable integer
        private int? TryParseNullableInt(string text)
        {
            if (int.TryParse(text, out int result))
            {
                return result;
            }
            return null;
        }

        private void lbl0_2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 6; i++)
            {
                for (int j = 2; j <= 5; j++)
                {
                    // Construct the label name dynamically
                    string labelName = $"lbl{i}_{j}";

                    // Find the control by name (assuming this code is within a form or control that contains the labels)
                    Control lbl = this.Controls.Find(labelName, true).FirstOrDefault();

                    // If the label is found, set its Text property to an empty string
                    if (lbl != null)
                    {
                        lbl.Text = "";
                    }
                }
            }

            lblATA.Text = "";
            lblAWT2.Text = "";
            lblTTA2.Text = "";
            lblTWT.Text = "";

            lblFCFS.Text = "";
            lblSPN.Text = "";

            btnFCFS.Enabled = true;
            btnSPN.Enabled = true;






        }

        private void lblTTA_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbAT1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void lblTTA2_Click(object sender, EventArgs e)
        {

        }

        private void lblTTA3_Click(object sender, EventArgs e)
        {

        }

        private void lblAWT2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnSPN_Click(object sender, EventArgs e)
        {
            try
            {
                btnFCFS.Enabled = false;
                btnSPN.Enabled = false;
                lblFCFS.Text = "";
                lblSPN.Text = "Shortest Process Next";
                // Initialize variables to hold parsed values, using nullable integers
                int? AT1 = TryParseNullableInt(lbl1_2.Text);
                int? AT2 = TryParseNullableInt(lbl1_3.Text);
                int? AT3 = TryParseNullableInt(lbl1_4.Text);
                int? AT4 = TryParseNullableInt(lbl1_5.Text);

                int? BT1 = TryParseNullableInt(lbl2_2.Text);
                int? BT2 = TryParseNullableInt(lbl2_3.Text);
                int? BT3 = TryParseNullableInt(lbl2_4.Text);
                int? BT4 = TryParseNullableInt(lbl2_5.Text);

                // Create a list of processes with their arrival and burst times
                var processes = new List<(string Name, int? ArrivalTime, int? BurstTime, int Index)>
                    {
                        ("P1", AT1, BT1, 0),
                        ("P2", AT2, BT2, 1),
                        ("P3", AT3, BT3, 2),
                        ("P4", AT4, BT4, 3)
                    };

                // Check for null values and show an error if any are found
                if (processes.Any(p => p.ArrivalTime == null || p.BurstTime == null))
                {
                    MessageBox.Show("All fields must be filled with valid integers.");
                    lblFCFS.Text = "";
                    lblSPN.Text = "";

                    btnFCFS.Enabled = true;
                    btnSPN.Enabled = true;

                    return;
                }

                // Sort processes by arrival time, and then by their index to handle ties
                //var sortedProcesses = processes.OrderBy(p => p.ArrivalTime).ThenBy(p => p.BurstTime).ThenBy(p => p.Index).ToList();


                // Sort processes using Shortest Process Next (SPN) scheduling algorithm
                var sortedProcesses = ScheduleSPN(processes);

                // Create arrays for storing the results
                int[] startTimes = new int[4];
                int[] finishTimes = new int[4];
                int[] waitingTimes = new int[4];
                int[] timeAllocations = new int[4];

                // Initialize the first process
                startTimes[0] = sortedProcesses[0].ArrivalTime.Value;
                finishTimes[0] = startTimes[0] + sortedProcesses[0].BurstTime.Value;
                waitingTimes[0] = 0;
                timeAllocations[0] = finishTimes[0] - sortedProcesses[0].ArrivalTime.Value;

                // Calculate times for subsequent processes
                for (int i = 1; i < sortedProcesses.Count; i++)
                {
                    startTimes[i] = Math.Max(finishTimes[i - 1], sortedProcesses[i].ArrivalTime.Value);
                    waitingTimes[i] = startTimes[i] - sortedProcesses[i].ArrivalTime.Value;
                    finishTimes[i] = startTimes[i] + sortedProcesses[i].BurstTime.Value;
                    timeAllocations[i] = finishTimes[i] - sortedProcesses[i].ArrivalTime.Value;
                }

                // Assign the sorted process names, arrival times, and burst times to labels
                lbl0_2.Text = sortedProcesses[0].Name;
                lbl0_3.Text = sortedProcesses[1].Name;
                lbl0_4.Text = sortedProcesses[2].Name;
                lbl0_5.Text = sortedProcesses[3].Name;

                lbl1_2.Text = sortedProcesses[0].ArrivalTime.ToString();
                lbl1_3.Text = sortedProcesses[1].ArrivalTime.ToString();
                lbl1_4.Text = sortedProcesses[2].ArrivalTime.ToString();
                lbl1_5.Text = sortedProcesses[3].ArrivalTime.ToString();

                lbl2_2.Text = sortedProcesses[0].BurstTime.ToString();
                lbl2_3.Text = sortedProcesses[1].BurstTime.ToString();
                lbl2_4.Text = sortedProcesses[2].BurstTime.ToString();
                lbl2_5.Text = sortedProcesses[3].BurstTime.ToString();

                // Assign the start times to labels
                lbl3_2.Text = startTimes[0].ToString();
                lbl3_3.Text = startTimes[1].ToString();
                lbl3_4.Text = startTimes[2].ToString();
                lbl3_5.Text = startTimes[3].ToString();

                // Assign the finish times to labels
                lbl4_2.Text = finishTimes[0].ToString();
                lbl4_3.Text = finishTimes[1].ToString();
                lbl4_4.Text = finishTimes[2].ToString();
                lbl4_5.Text = finishTimes[3].ToString();

                // Assign the waiting times to labels
                lbl5_2.Text = waitingTimes[0].ToString();
                lbl5_3.Text = waitingTimes[1].ToString();
                lbl5_4.Text = waitingTimes[2].ToString();
                lbl5_5.Text = waitingTimes[3].ToString();

                // Assign the time allocations to labels
                lbl6_2.Text = timeAllocations[0].ToString();
                lbl6_3.Text = timeAllocations[1].ToString();
                lbl6_4.Text = timeAllocations[2].ToString();
                lbl6_5.Text = timeAllocations[3].ToString();


                int inputSubtract = 0;
                for (int i = 0; i < 4; i++)
                {
                    if (timeAllocations[i] == 0 && waitingTimes[i] == 0)
                    {
                        inputSubtract++;
                    }


                }

                // Total Time Allocation
                double TTA = timeAllocations.Sum();
                lblTTA2.Text = TTA.ToString();

                // Average Time Allocation
                double ATA = TTA / (4 - inputSubtract);
                lblATA.Text = ATA.ToString("F3");

                // Total Waiting Time
                double TWT = waitingTimes.Sum();
                lblTWT.Text = TWT.ToString();

                // Average Waiting Time
                double AWT = TWT / (4 - inputSubtract);
                lblAWT2.Text = AWT.ToString("F3");






            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        public static List<(string Name, int? ArrivalTime, int? BurstTime, int Index)> ScheduleSPN(List<(string Name, int? ArrivalTime, int? BurstTime, int Index)> processes)
        {
            // Create a list to store the sorted processes
            var sortedProcesses = new List<(string Name, int? ArrivalTime, int? BurstTime, int Index)>();

            // Initialize the current time
            int currentTime = 0;

            // Create a list to hold the processes that have not yet been completed
            var remainingProcesses = new List<(string Name, int? ArrivalTime, int? BurstTime, int Index)>(processes);

            while (remainingProcesses.Any())
            {
                // Get the list of processes that have arrived by the current time
                var availableProcesses = remainingProcesses.Where(p => p.ArrivalTime <= currentTime).ToList();

                if (availableProcesses.Any())
                {
                    // Select the process with the shortest burst time
                    var nextProcess = availableProcesses.OrderBy(p => p.BurstTime).ThenBy(p => p.ArrivalTime).First();

                    // Add the selected process to the sorted list
                    sortedProcesses.Add(nextProcess);

                    // Update the current time by adding the burst time of the selected process
                    currentTime += nextProcess.BurstTime.Value;

                    // Remove the selected process from the remaining processes list
                    remainingProcesses.Remove(nextProcess);
                }
                else
                {
                    // If no process is available, move the current time forward to the next arriving process
                    currentTime = remainingProcesses.Min(p => p.ArrivalTime.Value);
                }
            }

            return sortedProcesses;
        }

    }
}

