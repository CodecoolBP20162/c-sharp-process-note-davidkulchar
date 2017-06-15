using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace TaskManager
{
    public partial class Form1 : Form
    {

        Process[] proc;
        public Form1()
        {
            InitializeComponent();
            GetAllProcesses();

        }


        void GetAllProcesses()
        {
            proc = Process.GetProcesses();
            dataGridView1.Rows.Clear();
            int i = 0;
            foreach (Process p in proc)
            {
                i++;
                dataGridView1.Rows.Add(i, p.ProcessName, "");
            }
        }

        private void Form1_Load(object Sender, EventArgs e)
        {
            GetAllProcesses();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                proc[dataGridView1.CurrentCell.RowIndex].Kill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GetAllProcesses();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Process p = proc[dataGridView1.CurrentCell.RowIndex];
            lbCpu.Text = "CPU: " + CountCPU(p).ToString() + "%";
            try
            {
                lbMem.Text = "Memory: " + (Convert.ToInt32(p.WorkingSet64) / (8)).ToString();
                lbRunTime.Text = "RunTime: \n" + (DateTime.Now - p.StartTime);
                lbStartTime.Text = "StartTime: \n" + p.StartTime;
            }
            catch (Exception ex) {
                lbRunTime.Text = "You have no power here! \n Permission denied! ";
            }
            lbThreads.Text = "Threads: " + p.Threads.Count;
        }

        private void btnRunNewTask_Click(object sender, EventArgs e)
        {
            using (Form2 frm = new Form2())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    GetAllProcesses();
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("", "Message: Your comments sadly wont be saved. Go cry in the corner", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var window = MessageBox.Show("Message: Your comments sadly wont be saved. Go cry in the corner", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            e.Cancel = (window == DialogResult.Cancel);
        }

        private void btnProps_Click(object sender, EventArgs e)
        {
            Process p = proc[dataGridView1.CurrentCell.RowIndex];
            String Mess = "";
            foreach (ProcessThread th in p.Threads)
                Mess += "\n" + th.ToString();
            MessageBox.Show(Mess, "Current Threads: \n", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        static double CountCPU(Process p)
        {
            PerformanceCounter myAppCpu =
                new PerformanceCounter(
                    "Process", "% Processor Time", p.ProcessName, true);
            double pct = myAppCpu.NextValue();
            //Thread.Sleep(1000);
            return pct;
            }
        }
    }