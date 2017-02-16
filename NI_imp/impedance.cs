using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;

using System.Windows.Forms;
using NationalInstruments.DAQmx;



namespace NI_imp
{
    public partial class impedance : Form
    {
        string[] Test_file;
        string[] data_split;// = new string[lines];
        //string Imp_save_file = @"E:\Projects\myprj\NI_imp\SI_data.csv";
        //string Signals_file = @"E:\Projects\myprj\NI_imp\SI_signalsN.csv";
        string config_file = @"E:\Work\NI_impedance\NI_imp\config.csv";
        string tested_file = @"E:\Work\NI_impedance\NI_imp\Tested_mouses.csv";

        public struct Info_Lab
        {
            public int LineNum;
            public int time_duration_cycle;
            public int freq;
            public int time_delay; 
        }

        Info_Lab val_data;

        public impedance()
        {
            InitializeComponent();
        }

        private void cmd_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmd_browse_Click(object sender, EventArgs e)
        {
            //OpenFileDialog result = new OpenFileDialog(); // Show the dialog.

            

            // Set filter options and filter index.
            //result.Filter = "CSV Files (.csv)|*.csv";
            //result.FilterIndex = 1;
           /* if (result.ShowDialog() == DialogResult.OK) // Test result.
            {
                

             
            }*/
        }

        private void fill_data()
        {


        }

        private void cmd_measure_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row != null)
                {
                    textBox1.Text = row.Cells[0].Value.ToString();
                    //string value2 = row.Cells[1].Value.ToString();
                    //...
                }

            }
        }

        private void cmd_graph_Click(object sender, EventArgs e)
        {

        }

        private void impedance_Load(object sender, EventArgs e)
        {
            Config_Open();

            tested_mouse();

        }


        private bool Config_Open()
        {
            try
            {

                Test_file = File.ReadAllLines(config_file);
                int lines = Test_file.Count();
                label3.Text = config_file;

                for (int i = 1; i < lines; i++)
                {
                    data_split = Test_file[i].Split(',');
                    this.dataGridView1.Rows.Add(data_split[0], data_split[1], data_split[2], data_split[3]);
                }

                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
                dataGridView1.ReadOnly = true;

                cmd_measure.Enabled = true;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            return false;
        }

        private bool tested_mouse()
        {
            try
            {

                Test_file = File.ReadAllLines(tested_file);
                int lines = Test_file.Count();
                
                for (int i = 1; i < lines; i++)
                {
                    data_split = Test_file[i].Split(',');
                    this.dataGridView2.Rows.Add(data_split[0], data_split[1]);
                }

                dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
                dataGridView2.ReadOnly = true;

                cmd_measure.Enabled = true;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            return false;
        }
    }
}
