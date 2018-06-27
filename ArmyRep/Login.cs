/*
 * Created by SharpDevelop.
 * User: KuanyshMadina
 * Date: 13.05.2018
 * Time: 11:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace ArmyRep
{
	/// <summary>
	/// Description of Login.
	/// </summary>
	public partial class frmLogin : Form
	{
		OleDbConnection connectionDB;
		string sSQLEditPart = "SELECT d.ID, d.DepName, d.IDDepType FROM tDep d where d.IDDeptype = 3 and d.IDStatus = 1";
		List<Department> aLoginPartList = new List<Department>();
		
		public frmLogin()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			//string sProvider = System.Configuration.ConfigurationSettings.AppSettings["provider"]; //old version
			//string sDataSource = System.Configuration.ConfigurationSettings.AppSettings["datasource"];  //old version
			string sProvider = System.Configuration.ConfigurationManager.AppSettings["provider"]; //new version
			string sDataSource = System.Configuration.ConfigurationManager.AppSettings["datasource"]; //new version
			string sConnectionString = "Provider="+sProvider+";" + @"Data Source="+sDataSource;
            connectionDB = new OleDbConnection(sConnectionString);
            connectionDB.Open();
		}
		void BtnEnterClick(object sender, EventArgs e)
		{
	
		}
		void FrmLoginLoad(object sender, EventArgs e)
		{
			OleDbDataAdapter adapter = new OleDbDataAdapter(sSQLEditPart, connectionDB);
			DbDataReader datareaderObject = adapter.SelectCommand.ExecuteReader();
			while (datareaderObject.Read())
			{
				cbPart.Items.Add(datareaderObject["DepName"].ToString());
				lbIDPart.Text = datareaderObject["ID"].ToString();
				Department dep = new Department();
				dep.ItemIndex = cbPart.Items.IndexOf(datareaderObject["DepName"].ToString());
				dep.ID = Int32.Parse(datareaderObject["ID"].ToString());
				dep.DepName = (string)datareaderObject["DepName"];
				aLoginPartList.Add(dep);
				dep = null;
			}
			if (!datareaderObject.IsClosed && datareaderObject != null)
			{
				datareaderObject.Close();
			}
			datareaderObject = null;
			adapter.Dispose();
			adapter = null;
		}
		void FrmLoginFormClosing(object sender, FormClosingEventArgs e)
		{
			if (connectionDB.State != ConnectionState.Closed)
			{
				connectionDB.Close();
			}
		}
	}
}
