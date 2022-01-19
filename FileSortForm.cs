using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSort
{
    public partial class FileSortForm : Form
    {
        /// <summary>
        /// Initializes the form
        /// </summary>
        public FileSortForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens the file explorer to choose a text file to be sorted.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                fileNameTextBox.Text = fileDialog.FileName;
            }
        }

        /// <summary>
        /// Sorts the previously chosen text file based on the method chosen in the radio buttons.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sortFilebutton_Click(object sender, EventArgs e)
        {
            string unsortedfile = fileNameTextBox.Text;
            bool valid = File.Exists(unsortedfile);

            if(!String.IsNullOrWhiteSpace(fileNameTextBox.Text) && valid)
            {
                errorProvider.SetError(fileNameTextBox, "");
                string[] unsortedArray = File.ReadAllLines(unsortedfile);
                if (bubbleSortRadioButton.Checked)
                {
                    sortedListBox.Items.Clear();
                    bubbleSort(unsortedArray);
                    errorProvider.SetError(sortedListBox, "");
                }
                else if (insertSortRadioButton.Checked)
                {
                    sortedListBox.Items.Clear();
                    insertionSort(unsortedArray);
                    errorProvider.SetError(sortedListBox, "");
                }
                else if (selectionSortRadioButton.Checked)
                {
                    sortedListBox.Items.Clear();
                    selectionSort(unsortedArray);
                    errorProvider.SetError(sortedListBox, "");

                }
                else
                {
                    errorProvider.SetError(sortedListBox, "Please select a sorting method");
                    sortedListBox.Items.Clear();
                }  
            }
            else
            {
                errorProvider.SetError(fileNameTextBox,"Please select a valid file name.");
            }
        }

        /// <summary>
        /// Performs a bubble sort on the unsorted string array that was passed to the function.
        /// Then loads the list box with the sorted array.
        /// </summary>
        /// <param name="arr"></param>
        private void bubbleSort(string[] arr)
        {
            int length = arr.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < (length - i - 1); j++)
                {
                    int result = String.Compare(arr[j], arr[j + 1]);

                    //Switch > to < to put in descending order
                    if (result > 0)
                    {
                        int k = j + 1;
                        swap(ref arr[j], ref arr[k]);
                    }
                }
            }
            PrintArray(arr, length);
        }

        /// <summary>
        /// Performs an insertion sort on the unsorted string array that was passed to the function.
        /// Then loads the list box with the sorted array.
        /// </summary>
        /// <param name="test"></param>
        private void insertionSort(string[] arr)
        {
            int length = arr.Length;

            for (int i = 1; i < length; i++)
            {
                string index = arr[i].ToString();
                int j = i - 1;

                while (j >= 0 && arr[j].CompareTo(index) >= 0)
                {

                    arr[j + 1] = arr[j];
                    j = j - 1;
                    
                    
                }
                arr[j + 1] = index;
            }

            PrintArray(arr, length);
        }

        /// <summary>
        /// Performs a selection sort on the unsorted string array that was passed to the function.
        /// Then loads the list box with the sorted array.
        /// </summary>
        /// <param name="arr"></param>
        private void selectionSort(string[] arr)
        {
            int length = arr.Length;

            for (int i = 0; i < length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < length; j++)
                {
                    int result = String.Compare(arr[j], arr[i]);
                    if (result < 0)
                    {
                        int result2 = String.Compare(arr[j], arr[min]);
                        if (result2 < 0)
                        {
                            min = j;
                            swap(ref arr[min], ref arr[i]);
                        }
                    }
                }
            }

            PrintArray(arr, length);
        }

        /// <summary>
        /// Passed an array and a length, fills the listbox with the sorted items.
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="length"></param>
        private void PrintArray(string[] arr, int length)
        {
            for (int p = 0; p < length; p++)
            {
                sortedListBox.Items.Add(arr[p]);
            }
        }


        /// <summary>
        /// Swaps two array elements at indexes test[a] and test[b].
        /// </summary>
        /// <param name="test"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }



    }
}
