using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exchange_Calculator
{
    public partial class Form1 : Form
    { //variables data types
        string countryfrom = "";
        string countryto = "";
        decimal amount;
        decimal exchangerate;
        string currency = "";//arrays
        decimal result;
        private string[,] currencyArray = { { "pounds", "USA", "1.52", "$" }, //array list creates a list of data, this places data into the program for the user.
                                          { "USA", "pounds", "0.66", "£" }, 
                                          { "pounds", "euro", "1.28", "€" }, 
                                          { "euro", "pounds", "0.78", "£" }, 
                                          { "euro", "USA", "1.19", "£" }, 
                                          { "USA", "euro", "0.84", "€" } };
        string excep;

        public Form1()
        {
            InitializeComponent();

        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            try
            {
                //variables are being convertered to data types
                amount = Convert.ToDecimal(txtAmount.Text);
                //getting selected item from the combo boxes and stores it as a varible 
                countryfrom = (string)comboCurrent.SelectedItem;
                countryto = (string)comboSecondCurrency.SelectedItem;
                Exchange();
                display();
            }
            catch (Exception error)
            {
                MessageBox.Show("You have inputted the amount wrong " + error.Message);
            }
       
        }


        public void Exchange()
        {
            int count = 0;
           
            //below is a while loop. if it is true it will run the instructions
            while (count < currencyArray.GetUpperBound(0)) // getupperbounds is a key word that tells the computer to count the number of rows in the array
            {

                if (countryfrom.Equals(currencyArray[count, 0]) & (countryto.Equals(currencyArray[count, 1])))
                {
                    exchangerate = Convert.ToDecimal(currencyArray[count, 2]);// pulling the exchange rate out of the array
                    currency = currencyArray[count, 3];// pulling the currency symbol out of the array
                    break; // the break breaks the loop when it finds a match
                }

                count++; //this line adds one to the value held by the variable count
            }

            equals();
        }
        public void equals()
        {//calculation
            result = (amount * exchangerate);
        }

        public void display()
        {
            txtResult.Text = result.ToString();
        }

        private void txtExchangeRate_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}


