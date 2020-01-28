using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGen
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{

			//creates variables
			string chars1 = "";
			string chars2 = "";
			string chars3 = "";
			string chars4 = "";

			//passLength converted to int for use in for loop
			string passLength = txtPassLength.Text;
			string passCombo;
			string results = "";
			
			//checks to make sure at least one box is checked
			if (specialChars.Checked == false && lowercaseLetters.Checked == false && uppercaseLetters.Checked == false && Numbers.Checked == false)
			{
				MessageBox.Show("Please check at least one of the boxes.","Error");
			
				//checks to make sure a password length was entered
			} else if(string.IsNullOrEmpty(txtPassLength.Text)) {

				MessageBox.Show("Please enter a length for you're password.", "Error");

			} else {

				//sets chars vars based on checkboxes
				if (specialChars.Checked)
				{
					chars2 = "!@#$%^&*";
				}

				if (lowercaseLetters.Checked)
				{
					chars4 = "abcdefghijklmnopqrstuvwxyz";
				}

				if (uppercaseLetters.Checked)
				{
					chars3 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
				}

				if (Numbers.Checked)
				{
					chars1 = "1234567890";
				}

				//combines all strings into 1 string
				passCombo = String.Concat(chars1, chars2, chars3, chars4);

				//converts string to array
				char[] charArr = passCombo.ToCharArray();

				Random rnd = new Random();

				var totalElements = charArr.Count();

				var passLengthNum = Convert.ToInt32(passLength);

				//runs as many times as passwordLength
				for (int i = 0; i < passLengthNum; i++)
				{
					int num = rnd.Next(0, totalElements);

					//runs once halfway through the for loop
					if (i == passLengthNum / 2)
					{
						if (string.IsNullOrEmpty(wordBox.Text))
						{
							//does nothing if empty
						}
						else
						{
							//ads the optional word to final pass
							results = String.Concat(results, wordBox.Text);
						}
							
					}

					//adds a character to the results
					results = String.Concat(results, charArr[num]);
				}

				//prints out the final password
				resultsBox.Text = results;
			}

			
		}
	}
}
