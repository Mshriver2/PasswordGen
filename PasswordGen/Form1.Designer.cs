namespace PasswordGen
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.uppercaseLetters = new System.Windows.Forms.CheckBox();
			this.lowercaseLetters = new System.Windows.Forms.CheckBox();
			this.specialChars = new System.Windows.Forms.CheckBox();
			this.Numbers = new System.Windows.Forms.CheckBox();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPassLength = new System.Windows.Forms.TextBox();
			this.resultsBox = new System.Windows.Forms.RichTextBox();
			this.wordBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// uppercaseLetters
			// 
			this.uppercaseLetters.AutoSize = true;
			this.uppercaseLetters.Location = new System.Drawing.Point(207, 28);
			this.uppercaseLetters.Name = "uppercaseLetters";
			this.uppercaseLetters.Size = new System.Drawing.Size(113, 17);
			this.uppercaseLetters.TabIndex = 0;
			this.uppercaseLetters.Text = "Uppercase Letters";
			this.uppercaseLetters.UseVisualStyleBackColor = true;
			// 
			// lowercaseLetters
			// 
			this.lowercaseLetters.AutoSize = true;
			this.lowercaseLetters.Location = new System.Drawing.Point(207, 51);
			this.lowercaseLetters.Name = "lowercaseLetters";
			this.lowercaseLetters.Size = new System.Drawing.Size(113, 17);
			this.lowercaseLetters.TabIndex = 1;
			this.lowercaseLetters.Text = "Lowercase Letters";
			this.lowercaseLetters.UseVisualStyleBackColor = true;
			// 
			// specialChars
			// 
			this.specialChars.AutoSize = true;
			this.specialChars.Location = new System.Drawing.Point(207, 97);
			this.specialChars.Name = "specialChars";
			this.specialChars.Size = new System.Drawing.Size(91, 17);
			this.specialChars.TabIndex = 3;
			this.specialChars.Text = "Special Chars";
			this.specialChars.UseVisualStyleBackColor = true;
			// 
			// Numbers
			// 
			this.Numbers.AutoSize = true;
			this.Numbers.Location = new System.Drawing.Point(207, 74);
			this.Numbers.Name = "Numbers";
			this.Numbers.Size = new System.Drawing.Size(68, 17);
			this.Numbers.TabIndex = 2;
			this.Numbers.Text = "Numbers";
			this.Numbers.UseVisualStyleBackColor = true;
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(43, 150);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(100, 23);
			this.btnSubmit.TabIndex = 4;
			this.btnSubmit.Text = "Generate";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(207, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(125, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Select Password Options";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Generated Password";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(54, 108);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Enter a length";
			// 
			// txtPassLength
			// 
			this.txtPassLength.Location = new System.Drawing.Point(43, 124);
			this.txtPassLength.Name = "txtPassLength";
			this.txtPassLength.Size = new System.Drawing.Size(100, 20);
			this.txtPassLength.TabIndex = 9;
			// 
			// resultsBox
			// 
			this.resultsBox.Location = new System.Drawing.Point(26, 26);
			this.resultsBox.Name = "resultsBox";
			this.resultsBox.Size = new System.Drawing.Size(142, 79);
			this.resultsBox.TabIndex = 10;
			this.resultsBox.Text = "";
			// 
			// wordBox
			// 
			this.wordBox.Location = new System.Drawing.Point(210, 152);
			this.wordBox.Name = "wordBox";
			this.wordBox.Size = new System.Drawing.Size(122, 20);
			this.wordBox.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(210, 133);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(110, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = " Add a word (optional)";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(367, 185);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.wordBox);
			this.Controls.Add(this.resultsBox);
			this.Controls.Add(this.txtPassLength);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.specialChars);
			this.Controls.Add(this.Numbers);
			this.Controls.Add(this.lowercaseLetters);
			this.Controls.Add(this.uppercaseLetters);
			this.Name = "Form1";
			this.Text = "Password Generator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox uppercaseLetters;
		private System.Windows.Forms.CheckBox lowercaseLetters;
		private System.Windows.Forms.CheckBox specialChars;
		private System.Windows.Forms.CheckBox Numbers;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPassLength;
		private System.Windows.Forms.RichTextBox resultsBox;
		private System.Windows.Forms.TextBox wordBox;
		private System.Windows.Forms.Label label4;
	}
}

