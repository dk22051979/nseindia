﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputCsvDisplayChartForms
{
    public partial class CSVFormMTN : Form
    {
        private int numberToCompute = 0;
        private int highestPercentageReached = 0;

        public CSVFormMTN()
        {
            InitializeComponent();
            InitializeBackgroundWorker();
        }

        // Set up the BackgroundWorker object by
        // attaching event handlers.
        private void InitializeBackgroundWorker()
        {
            backgroundWorker1.DoWork +=
                new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.RunWorkerCompleted +=
                new RunWorkerCompletedEventHandler(
            backgroundWorker1_RunWorkerCompleted);
            backgroundWorker1.ProgressChanged +=
                new ProgressChangedEventHandler(
            backgroundWorker1_ProgressChanged);
        }

        private void startAsyncButton_Click(System.Object sender,
            System.EventArgs e)
        {
            // Reset the text in the result label.
            resultLabel.Text = String.Empty;

            // Disable the UpDown control until
            // the asynchronous operation is done.
            this.numericUpDown1.Enabled = false;

            // Disable the Start button until
            // the asynchronous operation is done.
            this.startAsyncButton.Enabled = false;

            // Enable the Cancel button while
            // the asynchronous operation runs.
            this.cancelAsyncButton.Enabled = true;

            // Get the value from the UpDown control.
            numberToCompute = (int)numericUpDown1.Value;

            // Reset the variable for percentage tracking.
            highestPercentageReached = 0;

            // Start the asynchronous operation.
            backgroundWorker1.RunWorkerAsync(numberToCompute);
        }

        private void cancelAsyncButton_Click(System.Object sender,
            System.EventArgs e)
        {
            // Cancel the asynchronous operation.
            this.backgroundWorker1.CancelAsync();

            // Disable the Cancel button.
            cancelAsyncButton.Enabled = false;
        }

        // This event handler is where the actual,
        // potentially time-consuming work is done.
        private void backgroundWorker1_DoWork(object sender,
            DoWorkEventArgs e)
        {
            // Get the BackgroundWorker that raised this event.
            BackgroundWorker worker = sender as BackgroundWorker;

            // Assign the result of the computation
            // to the Result property of the DoWorkEventArgs
            // object. This is will be available to the
            // RunWorkerCompleted eventhandler.
            e.Result = ComputeFibonacci((int)e.Argument, worker, e);
        }

        // This event handler deals with the results of the
        // background operation.
        private void backgroundWorker1_RunWorkerCompleted(
            object sender, RunWorkerCompletedEventArgs e)
        {
            // First, handle the case where an exception was thrown.
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                // Next, handle the case where the user canceled
                // the operation.
                // Note that due to a race condition in
                // the DoWork event handler, the Cancelled
                // flag may not have been set, even though
                // CancelAsync was called.
                resultLabel.Text = "Canceled";
            }
            else
            {
                // Finally, handle the case where the operation
                // succeeded.
                resultLabel.Text = e.Result.ToString();
            }

            // Enable the UpDown control.
            this.numericUpDown1.Enabled = true;

            // Enable the Start button.
            startAsyncButton.Enabled = true;

            // Disable the Cancel button.
            cancelAsyncButton.Enabled = false;
        }

        // This event handler updates the progress bar.
        private void backgroundWorker1_ProgressChanged(object sender,
            ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
        }

        // This is the method that does the actual work. For this
        // example, it computes a Fibonacci number and
        // reports progress as it does its work.
        long ComputeFibonacci(int n, BackgroundWorker worker, DoWorkEventArgs e)
        {
            // The parameter n must be >= 0 and <= 91.
            // Fib(n), with n > 91, overflows a long.
            if ((n < 0) || (n > 91))
            {
                throw new ArgumentException(
                    "value must be >= 0 and <= 91", "n");
            }

            long result = 0;

            // Abort the operation if the user has canceled.
            // Note that a call to CancelAsync may have set
            // CancellationPending to true just after the
            // last invocation of this method exits, so this
            // code will not have the opportunity to set the
            // DoWorkEventArgs.Cancel flag to true. This means
            // that RunWorkerCompletedEventArgs.Cancelled will
            // not be set to true in your RunWorkerCompleted
            // event handler. This is a race condition.

            if (worker.CancellationPending)
            {
                e.Cancel = true;
            }
            else
            {
                if (n < 2)
                {
                    result = 1;
                }
                else
                {
                    result = ComputeFibonacci(n - 1, worker, e) +
                             ComputeFibonacci(n - 2, worker, e);
                }

                // Report progress as a percentage of the total task.
                int percentComplete =
                    (int)((float)n / (float)numberToCompute * 100);
                if (percentComplete > highestPercentageReached)
                {
                    highestPercentageReached = percentComplete;
                    worker.ReportProgress(percentComplete);
                }
            }

            return result;
        }


        public static DataTable PopulateDTFromCSVFile(string csv_file_path)
        {
            DataTable csvData = new DataTable();
            try
            {
                if (csv_file_path.EndsWith(".csv"))
                {
                    using (Microsoft.VisualBasic.FileIO.TextFieldParser csvReader = new Microsoft.VisualBasic.FileIO.TextFieldParser(csv_file_path))
                    {
                        csvReader.SetDelimiters(new string[] {
                    ","
                });
                        csvReader.HasFieldsEnclosedInQuotes = true;
                        //read column  
                        string[] colFields = csvReader.ReadFields();
                        foreach (string column in colFields)
                        {
                            DataColumn datecolumn = new DataColumn(column);
                            datecolumn.AllowDBNull = true;
                            csvData.Columns.Add(datecolumn);
                        }
                        while (!csvReader.EndOfData)
                        {
                            string[] fieldData = csvReader.ReadFields();
                            for (int i = 0; i < fieldData.Length; i++)
                            {
                                if (fieldData[i] == "")
                                {
                                    fieldData[i] = null;
                                }
                            }
                            csvData.Rows.Add(fieldData);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exce " + ex);
            }
            return csvData;
        }

        private void CSVFormMTN_Load(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.ShowDialog();
                int ImportedRecord = 0, inValidItem = 0;
                string SourceURl = "";
                if (dialog.FileName != "")
                {
                    if (dialog.FileName.EndsWith(".csv"))
                    {
                        DataTable dtNew = new DataTable();
                        dtNew = PopulateDTFromCSVFile(dialog.FileName);
                        if (Convert.ToString(dtNew.Columns[0]) != "INSTRUMENT")
                        {
                            MessageBox.Show("Invalid Items File");
                            //btnInsertToDB.Enabled = false;
                            return;
                        }
                        //textBox1.Text = dialog.SafeFileName;
                        SourceURl = dialog.FileName;
                        if (dtNew.Rows != null && dtNew.Rows.ToString() != String.Empty)                    //INSTRUMENT,SYMBOL,EXPIRY_DT,STRIKE_PR,OPTION_TYP,OPEN,HIGH,LOW,CLOSE,SETTLE_PR,CONTRACTS,VAL_INLAKH,OPEN_INT,CHG_IN_OI,TIMESTAMP
                        {
                            dgvCsvFile.DataSource = dtNew;
                        }
                        foreach (DataGridViewRow row in dgvCsvFile.Rows)
                        {
                            if (row.Cells["INSTRUMENT"].Value == null || Convert.ToString(row.Cells["SYMBOL"].Value) == "" || Convert.ToString(row.Cells["EXPIRY_DT"].Value) == "" || Convert.ToString(row.Cells["STRIKE_PR"].Value) == "" || Convert.ToString(row.Cells["OPTION_TYP"].Value) == "" || Convert.ToString(row.Cells["OPEN"].Value) == "" || row.Cells["HIGH"].Value == null || Convert.ToString(row.Cells["LOW"].Value) == "" || row.Cells["CLOSE"].Value == null || Convert.ToString(row.Cells["CONTRACTS"].Value) == "" || Convert.ToString(row.Cells["OPEN_INT"].Value) == "" || Convert.ToString(row.Cells["CHG_IN_OI"].Value) == "" || Convert.ToString(row.Cells["TIMESTAMP"].Value) == "" || row.Cells["SETTLE_PR"].Value == null)
                            {
                                row.DefaultCellStyle.BackColor = Color.Red;
                                inValidItem += 1;
                            }
                            else
                            {
                                ImportedRecord += 1;
                            }
                        }
                        if (dgvCsvFile.Rows.Count == 0)
                        {
                            //button2.Enabled = false;
                            MessageBox.Show("There is no data in this file", "NO LIMIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selected File is Invalid, Please Select valid csv file.", "NO LIMIT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception " + ex);
            }
        }
    }
}
