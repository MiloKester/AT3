using System;
using System.Windows.Forms;

// Names: Milo Kester and Vanie Srinivasan
// Date: 2023-10-20

// Sprint One
// Version: 1.0

// Name of the program: Astronomical Processing
// Brief explanation: Edit, Sort, and Search an array of integers
// Inputs: Takes a number for user to either edit to, or search for
// Processes: Bubble Sort, Binary Search, Edit data points, Add data to listbox
// Outputs: Listbox of all data points that is updated with each process

namespace AstronomicalProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // change default focus on application startup
            Btn_InsertData.Select();
        }

        // create the array
        int[] astroData = new int[24];


        // whenever an item is selected from the listbox, it will display in the input box
        private void ListBoxDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            string currentSelectedItem = ListBoxDisplay.SelectedItem.ToString();
            textBox_Entry.Text = currentSelectedItem;
        }

        // edit
        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            // checks to make sure edit is possible
            // if input is empty
            if (textBox_Entry.Text == "")
            {
                statusStrip_Message.Text = "Input Cannot Be Empty";
            }

            // if theres no data in listbox
            else if (ListBoxDisplay.Items.Count <= 0)
            {
                statusStrip_Message.Text = "There is No Data to Edit";
            }

            // if no item from listbox was selected to edit
            else if (ListBoxDisplay.SelectedItem == null)
            {
                statusStrip_Message.Text = "You must first select a data point to edit";
            }

            else
            {
                // try catch in case input slipped through checks to check if edit is possible
                try
                {
                    // get the current selected item and store the value as an int
                    int currentSelectedItem = Int32.Parse(ListBoxDisplay.SelectedItem.ToString());
                    // get the array index of the selected item
                    int currentSelectedIndex = Array.IndexOf(astroData, currentSelectedItem);
                    // change the value at that index to the value in the input box
                    astroData[currentSelectedIndex] = Int32.Parse(textBox_Entry.Text);
                    // resort and display
                    bubbleSort();
                    displayArray();
                } 
                // general error message for editing
                catch (Exception)
                {
                    statusStrip_Message.Text = "Error";
                }
                
            }
            
        }

        // binary search
        private void Btn_BinSearch_Click(object sender, EventArgs e)
        {
            // checking for user error 
            if (textBox_Entry.Text == "") {
                statusStrip_Message.Text = "Input Cannot Be Empty";
            }

            else if (ListBoxDisplay.Items.Count <= 0)
            {
                statusStrip_Message.Text = "There is No Data to Search Through";

            }
            else
            {
                // setting up for search
                int index = 0;
                bubbleSort();
                displayArray();

                // searching
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

        // bubble sort button
        private void Btn_Sort_Click(object sender, EventArgs e)
        {
            bubbleSort();
            displayArray();
        }

        // add test values to listbox
        private void Btn_InsertData_Click(object sender, EventArgs e)
        {
            // clear listbox for new set
            ListBoxDisplay.Items.Clear();
            Random rnd = new Random();

            for (int index = 0; index < astroData.Length; index++)
            {
                // add generated number at each index // min in inclusive, max is exclusive so between 10 and 99 inclusive 
                ListBoxDisplay.Items.Add(astroData[index] = rnd.Next(10, 100));
            }

            statusStrip_Message.Text = "Data Added";
        }

        // clear data from listbox
        private void Btn_ClearData_Click(object sender, EventArgs e)
        {
            ListBoxDisplay.Items.Clear();
            statusStrip_Message.Text = "Data Cleared";
        }

        // FUNCTIONS

        // bubble sort
        private void bubbleSort()
        {

            int i, j, tempSwap;
            bool swapped;

            // looping through array till everything has been compared (doesnt include the 24th int as it has nothing to compare against)
            for (i = 0; i < 24 - 1; i++)
            {
                swapped = false;

                // j (index counter) loop (i think the j < 24 - i - 1 is so it doesnt go through already sorted end results)
                for (j = 0; j < 24 - i - 1; j++)
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
        }

        // display array
        private void displayArray()
        {
            // if theres no data points
            if (ListBoxDisplay.Items.Count <= 0) {
                statusStrip_Message.Text = "There is No Data to Sort";

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

    }
}