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

			string chars1 = "";
			string chars2 = "";
			string chars3 = "";
			string chars4 = "";
			var passLength = Convert.ToInt32(txtPassLength.Text);
			string passCombo;
			string results = "";


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

			passCombo = String.Concat(chars1, chars2, chars3, chars4);

			char[] charArr = passCombo.ToCharArray();

			Random rnd = new Random();

			var totalElements = charArr.Count();

			for (int i = 0; i < passLength; i++)
			{
				int num = rnd.Next(0, totalElements);
				results = String.Concat(results, charArr[num]);
			}

			resultsBox.Text = results;
		}
	}
}
