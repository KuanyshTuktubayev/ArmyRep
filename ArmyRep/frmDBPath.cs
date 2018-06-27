/*
 * Created by SharpDevelop.
 * User: ktuktubaev
 * Date: 12.06.2018
 * Time: 13:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ArmyRep
{
	/// <summary>
	/// Description of frmDBPath.
	/// </summary>
	public partial class frmDBPath : Form
	{
		public frmDBPath()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void BtnCancelClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void BtnOKClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
