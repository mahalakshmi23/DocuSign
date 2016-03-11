/*
 * Created by SharpDevelop.
 * User: Mahalakshmi
 * Date: 3/10/2016
 * Time: 12:49 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DocuSignCodingChallenge
{
	/// <summary>
	/// Description of UserInterface.
	/// This UserInterface contains an input textbox to enter the input.
	/// On clicking the evaluate button , the inputs are evaluated and 
	/// output is displayed.
	/// </summary>
	public partial class DressUP : Form
	{
		public DressUP()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			String input=txtInput.Text;
			String output="";
			
			//Checking if input is empty
			if(input.Trim().Equals(String.Empty))
			   output="Please enter an input";
			else
				output=DataAccessLayer.evaluate(input);

			//Making the hidden textbox visible so as to display the output.
			txtOutput.Visible=true;
			txtOutput.Text=output;
			input=String.Empty;
			
	
		}
	}
}
