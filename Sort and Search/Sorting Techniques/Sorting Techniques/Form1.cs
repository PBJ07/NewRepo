using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Sorting_Techniques
{
    //Pearl Baburaj
    //April 22 2023
    /*Sort and Search methods*/

    public partial class frmSort : Form
    {
        List<int> myNums = new List<int>(); //List array

        public frmSort()
        {
            InitializeComponent();
        }

        //Exit Program button
        private void btnExit_Click(object sender, EventArgs e) 
        {
            Application.Exit();
        }

        //Display Function
        private void Display()
        {
            lstDisplay.Items.Clear();
            //Display in listbox
            for (int i = 0; i < myNums.Count; i++)
            {
                lstDisplay.Items.Add(myNums[i]);
            }
        }

        //Generate and display random numbers
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            myNums.Clear();
            //Generate random numbers
            if (int.TryParse(txtNum.Text.Trim(), out int n)) //check user input is valid
            {
                for (int i = 0; i < n; i++) //add numbers to myNums according to user input
                {
                    myNums.Add(rnd.Next(1, n + 1));

                }
                Display();
            }
            else
            {
                MessageBox.Show("Please enter a number.");
            }
        }

        //Bubble Sort button
        private void btnBubble_Click(object sender, EventArgs e)
        {
            int top = myNums.Count - 1;
            Stopwatch myTime = new Stopwatch();
            myTime.Start();
            //loop through myNums list
            for (int i = 0; i < top; i++)
            {
                for (int j = 0; j < top; j++) 
                {
                    //compares j with j+1, swaps if j is greater
                    if (myNums[j] > myNums[j + 1])
                    {
                        int temp = myNums[j];
                        myNums[j] = myNums[j + 1];
                        myNums[j + 1] = temp;
                    }
                }
            }
            myTime.Stop();
            Display();
            MessageBox.Show($"{myTime.ElapsedMilliseconds / 1000}");
        }
        //rnd 20000 = 11s
        //sorted 20000 = 7s

        //Better Bubble Sort button
        private void btnBetterBub_Click(object sender, EventArgs e)
        {
            int top = myNums.Count - 1;
            bool sorted = false;
            Stopwatch myTime = new Stopwatch();
            myTime.Start();
            while (!sorted) //while list is not sorted
            {
                sorted = true;
                //go through myNums list
                for (int j = 0; j < top; j++)
                {
                    //if j is greater than j+1, swaps and list not sorted
                    if (myNums[j] > myNums[j + 1])
                    {
                        int temp = myNums[j];
                        myNums[j] = myNums[j + 1];
                        myNums[j + 1] = temp;
                        sorted = false;
                    }
                }
                top -= 1;
            }
            myTime.Stop();
            Display();
            MessageBox.Show($"{myTime.ElapsedMilliseconds / 1000}");
        }
        //rnd 20000 = 7s
        //sorted 20000 = 0s

        //Selection Sort button
        private void btnSelection_Click(object sender, EventArgs e)
        {
            int top = myNums.Count();
            Stopwatch myTime = new Stopwatch();
            myTime.Start();
            for (int i = 0; i < top - 1; i++) //goes through myNums list
            {
                int Index = i;
                //goes through list starting from i+1
                for (int j = i + 1; j < top; j++)
                {
                    //updates index if index j is smaller than index
                    if (myNums[j] < myNums[Index])
                    {
                        Index = j;
                    }
                }
                //if i is not smallest number found
                if (Index != i)
                {
                    int temp = myNums[i];
                    myNums[i] = myNums[Index];
                    myNums[Index] = temp;
                }
            }
            myTime.Stop();
            Display();
            MessageBox.Show($"{myTime.ElapsedMilliseconds / 1000}");
        }
        //rnd 20000 = 2s
        //sorted 20000 = 2s

        //Insertion Sort button
        private void btnInsertion_Click(object sender, EventArgs e)
        {

            int top = myNums.Count();
            Stopwatch myTime = new Stopwatch();
            myTime.Start();
            for (int i = 1; i < top; i++) //goes through myNums list
            {
                int temp = myNums[i];
                int position = i;
                //shifts numbers to right to sort
                while (position > 0 && myNums[position - 1] > temp)
                {
                    myNums[position] = myNums[position - 1];
                    position = position - 1;
                }
                myNums[position] = temp; 
            }
            myTime.Stop();
            Display();
            MessageBox.Show($"{myTime.ElapsedMilliseconds / 1000}");
        }
        //rnd 20000 = 2s
        //sorted 20000 = 0s

        //Linear Search button
        private void btnLinear_Click_1(object sender, EventArgs e)
        {
            bool found = false;
            int index = 0;
            if (int.TryParse(txtSearch.Text.Trim(), out int n)) //check if user input is valid
            {
                //loop through array
                for (int i = 0; i < myNums.Count(); i++)
                {
                    //check if user input number was found in array
                    if (myNums[i] == n)
                    {
                        found = true;
                        index = i;
                    }
                }
                //Message box to display if number was found while searching
                if (found == true)
                {
                    MessageBox.Show($"The number {n} IS in the list at {index}.");
                }
                else
                {
                    MessageBox.Show($"The number {n} is NOT in the list.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a number.");
            }
        }

        //Binary Search button
        private void btnBinary_Click(object sender, EventArgs e)
        {
            bool found = false;
            int bottom = 0;
            int top = myNums.Count - 1;
            int count = 0;
            if (int.TryParse(txtSearch.Text.Trim(), out int n)) //check if user input is valid
            {
                //keep searching until number not found and not searched through
                while (bottom <= top && !found)
                {
                    count++;
                    int middle = (bottom + top) / 2;
                    if (n == myNums[middle]) //if number was found
                    {
                        found = true;

                    }
                    else if (n > myNums[middle]) //if number is greater than middle index
                    {
                        bottom = middle + 1;
                    }
                    else //if number is less than middle index
                    {
                        top = middle - 1;
                    }
                }
                //Message box to display result of search
                if (found == true)
                {
                    MessageBox.Show($"The number {n} IS in the list. Made {count} comparisons to find it.");
                }
                else
                {
                    MessageBox.Show($"The number {n} is NOT in the list. Made {count} comparisons.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a number.");
            }
        }
    }


    //Questions: SORTS
    /* 1) Which of these sorts worked the best when the data was random?
     * The insertion sort and selection sort were the sorts that worked best when the data was random.  
     * 
     * 2) Which one worked the best when the data was already sorted?
     * The insertion sort and better bubble sort were the sorts that worked best when the data was random. 
     * Bubble sort does not loop through the array if the the data is already sorted.
     * Insertion sort also works because it'll loop through the whole array but will only swicth values if there is a 
     * difference in size between the value.
     * 
     * 3) Why does it matter whether the data was already sorted or not?
     * The sorts took less time when the data was already sorted rather than when it wasn't. 
     * Understanding this can let you use the sort that you need to use to be more time-efficient
     */
}

