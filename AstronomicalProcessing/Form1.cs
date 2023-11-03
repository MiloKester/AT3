using System;
using System.Windows.Forms;
using System.Linq;

// Names: Milo Kester and Vanie Devi
// Date: 2023-10-27

// Sprint Two
// Version: 1.1

// Name of the program: Astronomical Processing
// Brief explanation: Edit, Sort, Search, Calculate values with an array of integers
// Inputs: Value to Edit, Value to Search For
// Processes: Add Data, Edit Data, Bubble Sort, Binary Search, Sequential Search, Calculate Mid-Extreme, Mode, Average, Range, Clear Program
// Outputs: Listbox of Data Points, Calculations

namespace AstronomicalProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Btn_InsertData.Select(); // Change Default Focus on Application Startup
        }

        int[] astroData = new int[24]; // Create Array

        // Display listbox selections in input box
        private void ListBoxDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentSelectedItem = ListBoxDisplay.SelectedItem.ToString();
            textBox_Entry.Text = currentSelectedItem;
        }

        #region BASIC CONTROLS

        // ADD VALUES
        private void Btn_InsertData_Click(object sender, EventArgs e)
        {
            resetProgram();
            // generate random numbers for each index in array
            Random rnd = new Random();
            for (int index = 0; index < astroData.Length; index++)
            {
                // add generated number at each index // min is inclusive, max is exclusive so between 10 and 99 inclusive 
                ListBoxDisplay.Items.Add(astroData[index] = rnd.Next(10, 100));
            }
            statusStrip_Message.Text = "Data Added";
        }

        // EDIT
        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            // is input empty
            if (textBox_Entry.Text == "")
            {
                statusStrip_Message.Text = "Input Cannot Be Empty";
            }

            // is there data in the listbox
            else if (ListBoxDisplay.Items.Count <= 0)
            {
                statusStrip_Message.Text = "There Is No Data To Edit";
            }

            // is there a valid selection
            else if (ListBoxDisplay.SelectedItem == null)
            {
                statusStrip_Message.Text = "You Must First Select A Value To Edit";
            }

            else
            {
                try
                {
                    // get the current selected item and store the value as an int
                    int currentSelectedItem = Int32.Parse(ListBoxDisplay.SelectedItem.ToString());

                    // get the array index of the selected item
                    int currentSelectedIndex = Array.IndexOf(astroData, currentSelectedItem);

                    // change the value at that index to the value in the input box
                    astroData[currentSelectedIndex] = Int32.Parse(textBox_Entry.Text);

                    // resort and display
                    displayArray();
                    statusStrip_Message.Text = "Edit was Successful";

                } 
                catch (Exception)
                {
                    statusStrip_Message.Text = "Error";
                }

            }

        }

        // SORT
        private void Btn_Sort_Click(object sender, EventArgs e)
        {
            bubbleSort();
            displayArray();
        }

        // CLEAR DATA
        private void Btn_ClearData_Click(object sender, EventArgs e)
        {
            resetProgram();
        }

        #endregion

        #region SEARCH

        // BINARY SEARCH
        private void Btn_BinSearch_Click(object sender, EventArgs e)
        {
            // is input empty
            if (textBox_Entry.Text == "")
            {
                statusStrip_Message.Text = "Input Cannot Be Empty";
            }

            // is there data in listbox
            else if (ListBoxDisplay.Items.Count <= 0)
            {
                statusStrip_Message.Text = "There Is No Data To Search Through";

            }
            else
            {
                int index = 0;
                bubbleSort();
                displayArray();

                // parse input as int to search for
                Int32.TryParse(textBox_Entry.Text, out int searchTerm);

                // get index of search term with inbuilt binary search function
                index = Array.BinarySearch(astroData, searchTerm);

                // if the index was found, say so
                if (index > -1)
                {
                    ListBoxDisplay.SelectedIndex = index;
                    statusStrip_Message.Text = "Search Was Found";
                }
                // else display it wasnt
                else
                {
                    statusStrip_Message.Text = "Search Was Not Found";
                }
            }
        }

        // SEQUENTIAL SEARCH
        private void Btn_SeqSearch_Click(object sender, EventArgs e)
        {
            // is input empty
            if (textBox_Entry.Text == "")
            {
                statusStrip_Message.Text = "Input Cannot Be Empty";
            }

            // is listbox empty
            else if (ListBoxDisplay.Items.Count <= 0)
            {
                statusStrip_Message.Text = "There is No Data to Search Through";

            }
            else
            {
                // parse input as search term
                Int32.TryParse(textBox_Entry.Text, out int searchTerm);

                // loop through array
                for (int i = 0; i < astroData.Length; i++)
                {
                    // if search term matches current index value
                    if (searchTerm == astroData[i])
                    {
                        // get index and display
                        int index = Array.IndexOf(astroData, searchTerm);
                        ListBoxDisplay.SelectedIndex = index;
                        statusStrip_Message.Text = "Search Was Found";
                        break;
                    }
                    // if not found
                    else
                    {
                        statusStrip_Message.Text = "Search Was Not Found";
                    }
                }
            }
        }

        #endregion

        #region MATHS

        // MID-EXTREME
        private void Btn_MidEx_Click(object sender, EventArgs e)
        {
            textBox_MidEx.Clear();
            // is listbox empty
            if (ListBoxDisplay.Items.Count <= 0)
            {
                statusStrip_Message.Text = "There Is No Data To Calculate";
            }
            else
            {
                // get max and min values
                int maxValue = astroData.Max();
                int minValue = astroData.Min();

                // calculate and display mid-extreme
                double midEx = (maxValue + minValue) / 2.0;
                textBox_MidEx.Text = midEx.ToString("0.00");
                statusStrip_Message.Text = "Mid-Extreme Found";
            }
        }

        // AVERAGE
        private void Btn_Ave_Click(object sender, EventArgs e)
        {
            textBox_Ave.Clear();
            // is listbox empty
            if (ListBoxDisplay.Items.Count <= 0)
            {
                statusStrip_Message.Text = "There Is No Data To Calculate";
            }
            else
            {
                double totalVal = 0;

                // loop through array and add each value to a total
                for (int i = 0; i < astroData.Length; i++)
                {
                    totalVal += astroData[i];
                }
                
                // calculate average
                double averageVal = totalVal / astroData.Length;
                textBox_Ave.Text = averageVal.ToString("0.00");
                statusStrip_Message.Text = "Average Found";
            }
        }

        // RANGE
        private void Btn_Range_Click(object sender, EventArgs e)
        {
            textBox_Range.Clear();
            // is listbox empty
            if (ListBoxDisplay.Items.Count <= 0)
            {
                statusStrip_Message.Text = "There Is No Data To Calculate";
            }
            else
            {
                // get min and max values
                int maxValue = astroData.Max();
                int minValue = astroData.Min();

                // calculate range
                int range = maxValue - minValue;
                textBox_Range.Text = range.ToString("0.00");
                statusStrip_Message.Text = "Range Found";
            }
        }

        // MODE
        private void Btn_Mode_Click(object sender, EventArgs e)
        {
            textBox_Mode.Clear();

            // is listbox empty
            if (ListBoxDisplay.Items.Count <= 0)
            {
                statusStrip_Message.Text = "There Is No Data To Calculate";
            }
            else
            {
                bubbleSort();
                displayArray();

                int currentNum = astroData[0];
                int currentCount = 1;
                int maxCount = 1;
                int mode = currentNum;
                bool foundMode = false;

                // loop through entire array
                for (int i = 1; i < astroData.Length; i++)
                {
                    // check if current index is the current number its counting
                    if (astroData[i] == currentNum)
                    {
                        currentCount++; // increase counter
                        // if the current counter is higher than the max count
                        if (currentCount > maxCount)
                        {
                            maxCount = currentCount; // change max count to the current count (increases)
                            mode = currentNum; // make mode the current number
                            foundMode = true;
                        }
                    }
                    else // if the current index isnt the current number its counting
                    {
                        currentNum = astroData[i]; // change current number to the current index value
                        currentCount = 1; // change count to 1
                    }
                }
                if (foundMode == true)
                {
                    textBox_Mode.Text = mode.ToString("0.00");
                    statusStrip_Message.Text = "Mode Found";
                }
                else
                {
                    statusStrip_Message.Text = "Mode Not Found";
                }

                
            }
        }

        #endregion  

        #region FUNCTIONS

        // BUBBLE SORT
        private void bubbleSort()
        {

            int i, j, tempSwap;
            bool swapped;

            // is listbox empty
            if (ListBoxDisplay.Items.Count <= 0)
            {
                statusStrip_Message.Text = "There Is No Data To Sort";
            }
            else
            {
                // loop through array (except last since nothing to compare against)
                for (i = 0; i < astroData.Length - 1; i++)
                {
                    swapped = false;

                    // j (index counter) loop (j < 24 - i - 1 is so it doesnt go through already sorted end results)
                    for (j = 0; j < astroData.Length - i - 1; j++)
                    {
                        // if the int at an index of the array is more than the next int, swap them 
                        if (astroData[j] > astroData[j + 1])
                        {
                            // holding the leftmost value in temp
                            tempSwap = astroData[j];
                            // the rightmost value moves to the leftmost spot
                            astroData[j] = astroData[j + 1];
                            // the temp (leftmost) moves to the rightmost spot
                            astroData[j + 1] = tempSwap;
                            swapped = true;
                        }
                    }
                    // if nothing was swapped after a loop, its finished sorting
                    if (swapped == false)
                        break;
                }
                statusStrip_Message.Text = "Data Sorted";
            }  
        }

        // DISPLAY ARRAY
        private void displayArray()
        {
            // without error checking, it'll fill the listbox with zeroes if empty
            if (ListBoxDisplay.Items.Count <= 0)
            {
                statusStrip_Message.Text = "There Is No Data To Sort";
            }
            else
            {
                // clear listbox
                ListBoxDisplay.Items.Clear();

                // loop through array and add data
                for (int index = 0; index < astroData.Length; index++)
                {
                    ListBoxDisplay.Items.Add(astroData[index]);
                }
            }
        }

        // RESET PROGRAM
        private void resetProgram()
        {
            // Clear Listbox
            ListBoxDisplay.Items.Clear();
            // Clear Array
            Array.Clear(astroData, 0, astroData.Length);
            // Clear Maths
            textBox_Ave.Clear();
            textBox_Range.Clear();
            textBox_MidEx.Clear();
            textBox_Mode.Clear();
            // Clear Input Box
            textBox_Entry.Clear();

            statusStrip_Message.Text = "Data Cleared";
        }

        #endregion

    }
}