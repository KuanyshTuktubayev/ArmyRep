/*
 * Created by SharpDevelop.
 * User: Kuanysh Tuktubayev
 * Date: 21.04.2018
 * Time: 10:57
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
using System.Configuration;
using System.Windows.Forms.VisualStyles;

namespace ArmyRep
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class frmMain : Form
	{
		string sProvider = "";
		string sDataSource = "";
		string sConnectionString = "";
		OleDbConnection connectionDB;
		/*string sIDPartCurrent = System.Configuration.ConfigurationSettings.AppSettings["IDPartCurrent"];
		string sSQLEditDep = "SELECT d.ID, d.DepName, d.IDDepType, d.IDParent, d.IDMRPerson, p.Lastname +' '+ p.Firstname +' '+ p.Patronymic as MRFIO FROM tDep d left join tPerson p on d.IDMRPerson = p.ID where d.IDParent = " + sIDPartCurrent + " and d.IDDeptype = 2 and d.IDStatus = 1";
		string sSQLEditPart = "SELECT d.ID, d.DepName, d.IDDepType FROM tDep d where d.IDParent = " + sIDPartCurrent + " and d.IDDeptype = 3 and d.IDStatus = 1";
		string sSQLEditRank = "SELECT r.ID, r.RankName FROM tRank r where r.IDStatus = 1";
		string sSQLEditDeptype = "SELECT dt.ID, dt.TypeName FROM tDepType dt where dt.IDStatus = 1";*/
		string sIDPartCurrent = "";
		string sIDWHCurrent = "";
		string sSQLEditDep = "";
		string sSQLEditPart = "";
		string sSQLEditRank = "";
		string sSQLEditDeptype = "";
		string sSQLEditCat = "";
		string sSQLEditProdtype = "";
		string sSQLEditUsingtype = "";
		string sSQLEditPerson = "";
		
		int nShowPageEditPart = 1;
		int nShowPageEditCategory = 1;
		int nShowPageEditDeptype = 1;
		int nShowPageEditUsingtype = 1;
		
		//string sSQLToWH = "";
		//string sSQLFromWH = "";
		
		
		/*
		 Да, это выглядит глупо, но в SharpDevelop нет визуальных компонентов для работы с БД, чтобы хранить нужные значения, отображая лишь часть из них
		 Например, в listbox можно хранить лишь значения одного поля (текст), но нельзя хранить айдишник
		 Поэтому приходится использовать нижеперечисленные массивы (коллекции объектов).
		 Это приведет к расходованию ОЗУ, но куда деваться? Придется сразу очищать память от ненужных данных.
		 */
		List<Department> aEditDepList = new List<Department>();
		List<Department> aEditPartList = new List<Department>();
		List<Rank> aEditRankList = new List<Rank>();
		List<DepType> aEditDeptypeList = new List<DepType>();
		List<Category> aEditCatList = new List<Category>();
		List<ProductType> aEditProdtypeList = new List<ProductType>();
		List<UsingType> aEditUsingtypeList = new List<UsingType>();
		List<Person> aEditPersonList = new List<Person>();
		
		List<Department> aToWHFromList = new List<Department>();
		List<Department> aFromWHToList = new List<Department>();
		List<Category> aToWHCat = new List<Category>();
		List<Category> aFromWHCat = new List<Category>();
		List<ProductType> aToWHProdTypesList = new List<ProductType>();
		List<ProductType> aFromWHProdTypesList = new List<ProductType>();
		List<GivingProd> aToWHChoicedProdsList = new List<GivingProd>();
		List<GivingProd> aFromWHChoicedProdsList = new List<GivingProd>();
		
		public frmMain()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// Add constructor code after the InitializeComponent() call.
			//
			//string sProvider = System.Configuration.ConfigurationSettings.AppSettings["provider"]; //old version
			//string sDataSource = System.Configuration.ConfigurationSettings.AppSettings["datasource"]; //old version
			sProvider = System.Configuration.ConfigurationManager.AppSettings["provider"]; //new version
			sDataSource = System.Configuration.ConfigurationManager.AppSettings["datasource"]; //new version
			sConnectionString = "Provider="+sProvider+";" + @"Data Source="+sDataSource;
            connectionDB = new OleDbConnection(sConnectionString);
            try
            {
            	connectionDB.Open();
            }
            catch
            {
            	//MessageBox.Show("Неправильно указан путь к базе данных. Исправьте файл ''ArmyRep.exe.config'' - проставье правильный путь в атрибуте ''value'' для ключа ''datasource''");
            	MessageBox.Show("Неправильно указан путь к базе данных. Сейчас будет предложено выбрать файл базы данных...");
            }
            //sIDPartCurrent = System.Configuration.ConfigurationSettings.AppSettings["IDPartCurrent"]; //old version
            sIDPartCurrent = System.Configuration.ConfigurationManager.AppSettings["IDPartCurrent"]; //new version
            
            try
            {
            	nShowPageEditPart = int.Parse(System.Configuration.ConfigurationManager.AppSettings["showPageEditPart"]);
            }
            catch
            {}
            
            try
            {
            	nShowPageEditCategory = int.Parse(System.Configuration.ConfigurationManager.AppSettings["showPageEditCategory"]);
            }
            catch
            {}
            
            try
            {
            	nShowPageEditDeptype = int.Parse(System.Configuration.ConfigurationManager.AppSettings["showPageEditDeptype"]);
            }
            catch
            {}
            
            try
            {
            	nShowPageEditUsingtype = int.Parse(System.Configuration.ConfigurationManager.AppSettings["showPageEditUsetype"]);
            }
            catch
            {}
            
			sSQLEditDep = "SELECT d.ID, d.DepName, d.IDDepType, d.IDParent, d.IDMRPerson, p.Lastname +' '+ p.Firstname +' '+ p.Patronymic as MRFIO FROM tDep d left join tPerson p on d.IDMRPerson = p.ID where d.IDParent = " + sIDPartCurrent + " and d.IDDeptype = 2 and d.IDStatus = 1";
			sSQLEditPart = "SELECT d.ID, d.DepName, d.IDDepType FROM tDep d where d.IDParent is null and d.IDDeptype = 3 and d.IDStatus = 1";
			sSQLEditRank = "SELECT r.ID, r.RankName FROM tRank r where r.IDStatus = 1";
			sSQLEditDeptype = "SELECT dt.ID, dt.TypeName FROM tDepType dt where dt.IDStatus = 1";
			sSQLEditCat = "SELECT c.ID, c.CatName FROM tCat c where c.IDStatus = 1";
			sSQLEditProdtype = "SELECT pt.ID, pt.TypeName, pt.IDUsingType, ut.TypeName as UsingTypeName FROM tProdType pt left join tUsingType ut on ut.ID = pt.IDUsingType where pt.IDStatus = 1";
			sSQLEditUsingtype = "SELECT ut.ID, ut.TypeName FROM tUsingType ut where ut.IDStatus = 1";
			//sSQLEditPerson = "SELECT p.ID, p.LastName, p.FirstName, p.Patronymic, p.Birthdate, p.Deathdate, p.IDStatus FROM tPerson p where p.IDStatus = 1";
			sSQLEditPerson = @"SELECT p.ID, p.LastName, p.FirstName, p.Patronymic, p.Gender, p.Birthdate, p.Deathdate, p.IDStatus, pr.IDPerson, pr.IDRank, pr.DateFrom, (select r.RankName from tRank r where r.ID = pr.IDRank) as RankName
							FROM tPerson p
							left join (select pr.ID, pr.IDPerson, pr.IDRank, pr.DateFrom
									from tPersonRank pr
									where pr.ID in (select max(pr2.ID) from tPersonRank pr2 where pr2.IDPerson = pr.IDPerson)
									) pr on pr.IDPerson = p.ID 						
							where 1=1
							and p.IDStatus = 1";
		}
		
		int getID(string pTable, string pFieldType, string pFieldValue)
		{
			//getID("tDep", "WH", sIDPartCurrent);
			if (pTable.Equals("tDep"))
			{
				if ((pFieldType == "WH") && (!string.IsNullOrEmpty(pFieldValue)))
				{
					string sSQL = "select ID from tDep d where d.idparent = " + sIDPartCurrent + " and d.iddeptype = 1 and d.idstatus = 1";
					int nID = -1;
					OleDbDataAdapter adapter = new OleDbDataAdapter(sSQL, connectionDB);
					DbDataReader drObject = adapter.SelectCommand.ExecuteReader();
					while (drObject.Read())
					{
						nID = Convert.ToInt32(drObject["ID"]);
					}
					if (!drObject.IsClosed && drObject != null)
					{
						drObject.Close();
					}
					drObject = null;
					adapter.Dispose();
					adapter = null;
					return nID;
				}
				else
				{
					return 0;
				}
			}
			else
			{
				return 0;
			}
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			if (connectionDB.State == ConnectionState.Closed)
			{
				pnMenu.Visible = false;
				OpenFileDialog fd = new OpenFileDialog();
				fd.Filter = "База данных MS Access (*.accdb, *.adb)|*.adb;*.accdb";
				fd.ShowDialog();
				if (fd.FileName.Length > 0)
				{
					sConnectionString = "Provider="+sProvider+";" + @"Data Source="+fd.FileName;
					connectionDB = null;
					connectionDB = new OleDbConnection(sConnectionString);
					try
		            {
		            	connectionDB.Open();
		            	pnMenu.Visible = true;
		            	//TODO: write here code to save appsettings with new path
			            AddOrUpdateAppSettings("datasource", fd.FileName);
		            }
		            catch
		            {
		            	MessageBox.Show("Неправильно указан файл базы данных. Исправьте файл ''ArmyRep.exe.config'' - проставье правильный путь в атрибуте ''value'' для ключа ''datasource''");
		            	Application.Exit();
		            }
		            finally
		            {
		            	fd = null;
		            }
				}
				else
				{
					fd = null;
					MessageBox.Show("Исправьте файл ''ArmyRep.exe.config'' - проставье правильный путь в атрибуте ''value'' для ключа ''datasource''");
					Application.Exit();
				}
			}
			sIDWHCurrent = Convert.ToString(getID("tDep", "WH", sIDPartCurrent));
			tcEdit.Visible = false;
			tcWH.Visible = false;
			tcDep.Visible = false;
			tcUse.Visible = false;
			/*--------------------
 			* TODO: open this commented block when you shall create a login-form
			frmLogin loginForm = new frmLogin();
			loginForm.ShowDialog();
			loginForm.Close();
			if (!loginForm.IsDisposed)
			{
				loginForm.Dispose();
			}
			loginForm = null;
			---------------------*/
		}
		
		public static void AddOrUpdateAppSettings(string key, string value)
		{
		    try
		    {
		        var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
		        var settings = configFile.AppSettings.Settings;
		        if (settings[key] == null)
		        {
		            //settings.Add(key, value);
		        }
		        else
		        {
		            settings[key].Value = value;
		        }
		        configFile.Save(ConfigurationSaveMode.Modified);
		        ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
		    }
		    catch (ConfigurationErrorsException)
		    {
		        Console.WriteLine("Error writing app settings");
		    }
		}
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			CloseDataReadsOfEdit();
			CloseDataReadsOfWH();
			CloseDataReadersOfDep();
			CloseDataReadersOfUse();
			if (connectionDB.State != ConnectionState.Closed)
			{
				connectionDB.Close();
			}
		}
		void BtnEditClick(object sender, EventArgs e)
		{
			tcEdit.Dock = DockStyle.Fill;
			tcEdit.Visible = true;
			tcWH.Visible = false;
			tcDep.Visible = false;
			tcUse.Visible = false;
			CloseDataReadsOfWH();
			CloseDataReadersOfDep();
			CloseDataReadersOfUse();
			
			//Подразделение
			MakeDataReader("drEditDep", sSQLEditDep);
			//звание
			MakeDataReader("drEditRank", sSQLEditRank);
			//Тип подразделения
			MakeDataReader("drEditDeptype", sSQLEditDeptype);
			//категория
			MakeDataReader("drEditCat", sSQLEditCat);
			//типы активов/ценностей/продуктов
			MakeDataReader("drEditProdtype", sSQLEditProdtype);
			//виды пользования
			MakeDataReader("drEditUsingtype", sSQLEditUsingtype);
			//Воинская часть
			MakeDataReader("drEditPart", sSQLEditPart);
			//Человек
			MakeDataReader("drEditPerson", sSQLEditPerson);
			
			scEditPerson.SplitterDistance = btnEditPersonFind.Location.Y + btnEditPersonFind.Height + 15;
			
			if (nShowPageEditPart.Equals(0))
			{
				tcEdit.TabPages.Remove(tpPart);
			}
			if (nShowPageEditCategory.Equals(0))
			{
				tcEdit.TabPages.Remove(tpCategory);
			}
			if (nShowPageEditDeptype.Equals(0))
			{
				tcEdit.TabPages.Remove(tpDepType);
			}
			if (nShowPageEditUsingtype.Equals(0))
			{
				tcEdit.TabPages.Remove(tpUsingType);
			}
		}
		void MakeDataReader(string datareaderName, string sSQL)
		{
			OleDbDataAdapter adapter = new OleDbDataAdapter(sSQL, connectionDB);
			DbDataReader datareaderObject = adapter.SelectCommand.ExecuteReader();
			if (datareaderName == "drEditDep")
			{
				lsbEditDepList.Items.Clear();
				aEditDepList.Clear();
				while (datareaderObject.Read())
				{
					string sID = datareaderObject["ID"].ToString();
					string sName = datareaderObject["DepName"].ToString();
					txEditDepName.Text = sName;
					lsbEditDepList.Items.Add(sName);
					lbEditIDDep.Text = sID;
					Department dep = new Department();
					dep.ItemIndex = lsbEditDepList.Items.IndexOf(txEditDepName.Text);
					dep.ID = Int32.Parse(sID);
					dep.DepName = sName;
					aEditDepList.Add(dep);
					dep = null;
				}
			
			var adapterDepTypes = new OleDbDataAdapter(sSQLEditDeptype, connectionDB);
			DbDataReader drObjectDepTypes = adapterDepTypes.SelectCommand.ExecuteReader();
			while (drObjectDepTypes.Read())
			{
				string sID = drObjectDepTypes["ID"].ToString();
				string sUsingTypeName = drObjectDepTypes["TypeName"].ToString();
				cbEditDepDeptype.Items.Add(sUsingTypeName);
				lbEditDepDeptypeID.Text = sID;
			}
			if (!drObjectDepTypes.IsClosed && drObjectDepTypes != null)
			{
				drObjectDepTypes.Close();
			}
			drObjectDepTypes = null;
			adapterDepTypes.Dispose();
			adapterDepTypes = null;
			}
			else if (datareaderName == "drEditPart")
			{
				lsbEditPartList.Items.Clear();
				aEditPartList.Clear();
				while (datareaderObject.Read())
				{
					string sID = datareaderObject["ID"].ToString();
					string sName = datareaderObject["DepName"].ToString();
					txEditPartName.Text = sName;
					lsbEditPartList.Items.Add(sName);
					lbEditIDPart.Text = sID;
					Department dep = new Department();
					dep.ItemIndex = lsbEditPartList.Items.IndexOf(txEditPartName.Text);
					dep.ID = Int32.Parse(sID);
					dep.DepName = sName;
					aEditPartList.Add(dep);
					dep = null;
				}
			}
			else if (datareaderName == "drEditRank")
			{
				lsbEditRankList.Items.Clear();
				aEditRankList.Clear();
				while (datareaderObject.Read())
				{
					string sID = datareaderObject["ID"].ToString();
					string sName = datareaderObject["RankName"].ToString();
					txEditRankName.Text = sName;
					lsbEditRankList.Items.Add(sName);
					lbEditIDRank.Text = sID;
					Rank rank = new Rank();
					rank.ItemIndex = lsbEditRankList.Items.IndexOf(txEditRankName.Text);
					rank.ID = Int32.Parse(sID);
					rank.RankName = sName;
					aEditRankList.Add(rank);
					rank = null;
				}
			}
			else if (datareaderName == "drEditDeptype")
			{
				lsbEditDeptypeList.Items.Clear();
				aEditDeptypeList.Clear();
				while (datareaderObject.Read())
				{
					string sID = datareaderObject["ID"].ToString();
					string sName = datareaderObject["TypeName"].ToString();
					txEditDeptypeName.Text = sName;
					lsbEditDeptypeList.Items.Add(sName);
					lbEditIDDeptype.Text = sID;
					DepType deptype = new DepType();
					deptype.ItemIndex = lsbEditDeptypeList.Items.IndexOf(txEditDeptypeName.Text);
					deptype.ID = Int32.Parse(sID);
					deptype.TypeName = sName;
					aEditDeptypeList.Add(deptype);
					deptype = null;
				}
			}
			else if (datareaderName == "drEditCat")
			{
				lsbEditCatList.Items.Clear();
				aEditCatList.Clear();
				while (datareaderObject.Read())
				{
					string sID = datareaderObject["ID"].ToString();
					string sName = datareaderObject["CatName"].ToString();
					txEditCatName.Text = sName;
					lsbEditCatList.Items.Add(sName);
					lbEditIDCat.Text = sID;
					Category cat = new Category();
					cat.ItemIndex = lsbEditCatList.Items.IndexOf(txEditCatName.Text);
					cat.ID = Int32.Parse(sID);
					cat.CatName = sName;
					aEditCatList.Add(cat);
					cat = null;
				}
			}
			else if (datareaderName == "drEditUsingtype")
			{
				lsbEditUsingtypeList.Items.Clear();
				aEditUsingtypeList.Clear();
				while (datareaderObject.Read())
				{
					string sID = datareaderObject["ID"].ToString();
					string sName = datareaderObject["TypeName"].ToString();
					txEditUsingtypeName.Text = sName;
					lsbEditUsingtypeList.Items.Add(sName);
					lbEditIDUsingtype.Text = sID;
					UsingType ut = new UsingType();
					ut.ItemIndex = lsbEditUsingtypeList.Items.IndexOf(txEditUsingtypeName.Text);
					ut.ID = Int32.Parse(sID);
					ut.TypeName = sName;
					aEditUsingtypeList.Add(ut);
					ut = null;
				}
			}
			else if (datareaderName == "drEditProdtype")
			{
				lsbEditProdtypeList.Items.Clear();
				cbEditPTUsingtypeName.Items.Clear();
				aEditProdtypeList.Clear();
				
				OleDbDataAdapter adapterUsingTypes = new OleDbDataAdapter(sSQLEditUsingtype, connectionDB);
				DbDataReader drObjectUsingTypes = adapterUsingTypes.SelectCommand.ExecuteReader();
				while (drObjectUsingTypes.Read())
				{
					string sID = drObjectUsingTypes["ID"].ToString();
					string sUsingTypeName = drObjectUsingTypes["TypeName"].ToString();
					cbEditPTUsingtypeName.Items.Add(sUsingTypeName);
					lbEditPTIDUsingtype.Text = sID;
				}
				if (!drObjectUsingTypes.IsClosed && drObjectUsingTypes != null)
				{
					drObjectUsingTypes.Close();
				}
				drObjectUsingTypes = null;
				adapterUsingTypes.Dispose();
				adapterUsingTypes = null;
				
				while (datareaderObject.Read())
				{
					string sID = datareaderObject["ID"].ToString();
					string sName = datareaderObject["TypeName"].ToString();
					string sIDUsingType = datareaderObject["IDUsingType"].ToString();
					string sUsingTypeName = datareaderObject["UsingTypeName"].ToString();
					txEditProdtypeName.Text =sName;
					lsbEditProdtypeList.Items.Add(sName);
					cbEditPTUsingtypeName.SelectedItem = cbEditPTUsingtypeName.Items[cbEditPTUsingtypeName.Items.IndexOf(sUsingTypeName)];
					lbEditIDProdtype.Text = sID;
					lbEditPTIDUsingtype.Text = sIDUsingType;
					ProductType prodtype = new ProductType();
					prodtype.ItemIndex = lsbEditProdtypeList.Items.IndexOf(txEditProdtypeName.Text);
					prodtype.ID = Int32.Parse(sID);
					prodtype.TypeName = sName;
					prodtype.IDUsingType = Int32.Parse(sIDUsingType);
					prodtype.UsingTypeItemIndex = cbEditPTUsingtypeName.Items.IndexOf(sUsingTypeName);
					prodtype.UsingTypeName = sUsingTypeName;
					aEditProdtypeList.Add(prodtype);
					prodtype = null;
				}
			}
			else if (datareaderName == "drEditPerson")
			{
				lsbEditPersonList.Items.Clear();
				aEditPersonList.Clear();
				dgvEditPersonList.Rows.Clear();
				if (dgvEditPersonList.ColumnCount <= 9)
				{
					dgvEditPersonList.Columns.Clear();
					int nCol = 0;
					while (dgvEditPersonList.ColumnCount < 9)
					{
						switch (nCol)
						{
							case 0:
								dgvEditPersonList.Columns.Add("IDPerson", "ID");
								break;
							case 1:
								dgvEditPersonList.Columns.Add("Lastname", "Фамилия");
								break;
							case 2:
								dgvEditPersonList.Columns.Add("Firstname", "Имя");
								break;
							case 3:
								dgvEditPersonList.Columns.Add("Patronymic", "Отчество");
								break;
							case 4:
								dgvEditPersonList.Columns.Add("Gender", "Пол");
								break;
							case 5:
								dgvEditPersonList.Columns.Add("BirthDate", "Дата рожд");
								break;
							case 6:
								dgvEditPersonList.Columns.Add("DeathDate", "Дата смерти");
								break;
							case 7:
								dgvEditPersonList.Columns.Add("RankName", "Звание");
								break;
							case 8:
								dgvEditPersonList.Columns.Add("RankDateFrom", "Дата звания");
								break;
							default:
								dgvEditPersonList.Columns.Add("Column"+nCol.ToString(), "Столбец"+nCol.ToString());
								break;
						}
						nCol++;
					}
				}
				
				OleDbDataAdapter adapterRanks = new OleDbDataAdapter(sSQLEditRank, connectionDB);
				DbDataReader drObjectRanks = adapterRanks.SelectCommand.ExecuteReader();
				while (drObjectRanks.Read())
				{
					string sID = drObjectRanks["ID"].ToString();
					string sRankName = drObjectRanks["RankName"].ToString();
					cbEditPersonRankName.Items.Add(sRankName);
					lbEditPIDRank.Text = sID;
				}
				if (!drObjectRanks.IsClosed && drObjectRanks != null)
				{
					drObjectRanks.Close();
				}
				drObjectRanks = null;
				adapterRanks.Dispose();
				adapterRanks = null;
				
				while (datareaderObject.Read())
				{
					string sID = datareaderObject["ID"].ToString();
					string sLastName = datareaderObject["LastName"].ToString();
					string sFirstName = datareaderObject["FirstName"].ToString();
					string sPatronymic = datareaderObject["Patronymic"].ToString();
					string sFIO = sLastName + " " + sFirstName + " " + sPatronymic;
					DateTime dtBirthdate = (datareaderObject["Birthdate"].ToString().Equals(string.Empty)) ? DateTime.MaxValue.Date : Convert.ToDateTime(datareaderObject["Birthdate"]).Date;
					DateTime dtDeathdate = (datareaderObject["Deathdate"].ToString().Equals(string.Empty)) ? DateTime.MaxValue.Date : Convert.ToDateTime(datareaderObject["Deathdate"]).Date;
					string sIDRankOfPerson = datareaderObject["IDRank"].ToString();
					string sRankNameOfPerson = datareaderObject["RankName"].ToString();
					DateTime dtRankDateOfPerson = (datareaderObject["DateFrom"].ToString().Equals(string.Empty)) ? DateTime.MinValue.Date : Convert.ToDateTime(datareaderObject["DateFrom"]).Date;
					bool bGender = (bool)datareaderObject["Gender"];
					txEditPersonLastname.Text = sLastName;
					txEditPersonFirstname.Text = sFirstName;
					txEditPersonPatronymic.Text = sPatronymic;
					if (bGender)
					{
						rbEditPersonGenderM.Checked = true;
					}
					else
					{
						rbEditPersonGenderF.Checked = true;
					}
					dtpEditPersonBirthdate.Value = dtBirthdate.Date;
					if (dtDeathdate == DateTime.MaxValue.Date)
					{
						dtpEditPersonDeathdate.Value = dtpEditPersonDeathdate.MaxDate.Date;
						chbEditPersonDeath.Checked = false;
						dtDeathdate = dtpEditPersonDeathdate.MaxDate.Date;
					}
					else
					{
						dtpEditPersonDeathdate.Value = dtDeathdate.Date;
						chbEditPersonDeath.Checked = true;
					}
					
					dgvEditPersonList.Rows.Add(sID, sLastName, sFirstName, sPatronymic, (bGender) ? "М" : "Ж", dtBirthdate.Date, dtDeathdate.Date, sRankNameOfPerson, dtRankDateOfPerson);
					dgvEditPersonList.ClearSelection();
					dgvEditPersonList.Rows[dgvEditPersonList.Rows.Count-1].Selected = true;
					lsbEditPersonList.Items.Add(sFIO);
					lbEditIDPerson.Text = sID;
					cbEditPersonRankName.SelectedIndex = cbEditPersonRankName.Items.IndexOf(sRankNameOfPerson);
					dtpEditPersonRankDatefrom.Value = dtRankDateOfPerson.Date;
					Person person = new Person();
					person.ItemIndex = lsbEditPersonList.Items.IndexOf(sFIO);
					person.ID = Int32.Parse(sID);
					person.LastName = sLastName;
					person.FirstName = sFirstName;
					person.Patronymic = sPatronymic;
					person.Gender = bGender;
					person.Birthdate = dtBirthdate.Date;
					person.Deathdate = dtDeathdate.Date;
					person.IDRank = int.Parse(sIDRankOfPerson);
					person.RankName = sRankNameOfPerson;
					person.RankDateFrom = dtRankDateOfPerson.Date;
					aEditPersonList.Add(person);
					person = null;
				}
			}
			
			if (!datareaderObject.IsClosed && datareaderObject != null)
			{
				datareaderObject.Close();
			}
			datareaderObject = null;
			adapter.Dispose();
			adapter = null;
		}
		void PnMenuClick(object sender, EventArgs e)
		{
			tcEdit.Visible = false;
			tcWH.Visible = false;
			tcDep.Visible = false;
			tcUse.Visible = false;
			CloseDataReadsOfEdit();
			CloseDataReadsOfWH();
			CloseDataReadersOfDep();
			CloseDataReadersOfUse();
		}
		void BtnDepClick(object sender, EventArgs e)
		{
			tcDep.Dock = DockStyle.Fill;
			tcDep.Visible = true;
			tcEdit.Visible = false;
			tcWH.Visible = false;
			tcUse.Visible = false;
			CloseDataReadsOfEdit();
			CloseDataReadsOfWH();
			CloseDataReadersOfUse();
			
			//приход на склад
			MakeReadyDepData("drToDep", "all");
		}
		void CloseDataReadsOfEdit()
		{
			aEditPartList.Clear();
			aEditDepList.Clear();
			aEditDeptypeList.Clear();
			aEditUsingtypeList.Clear();
			aEditRankList.Clear();
			aEditCatList.Clear();
			aEditProdtypeList.Clear();
			aEditPersonList.Clear();
		}
		void CloseDataReadsOfWH()
		{
			aToWHFromList.Clear();
			aToWHCat.Clear();
			aToWHChoicedProdsList.Clear();
			aToWHProdTypesList.Clear();
			aFromWHCat.Clear();
		}
		void CloseDataReadersOfDep()
		{
		}
		void CloseDataReadersOfUse()
		{
		}
		void BtnUseClick(object sender, EventArgs e)
		{
			tcUse.Dock = DockStyle.Fill;
			tcUse.Visible = true;
			tcEdit.Visible = false;
			tcWH.Visible = false;
			tcDep.Visible = false;
			CloseDataReadsOfEdit();
			CloseDataReadsOfWH();
			CloseDataReadersOfDep();
		}
		void LsbDepListSelectedIndexChanged(object sender, EventArgs e)
		{
			Department dep = new Department();
			dep = aEditDepList.Find(item => item.ItemIndex == lsbEditDepList.SelectedIndex);
			lbEditIDDep.Text = dep.ID.ToString();
			txEditDepName.Text = dep.DepName;
			dep = null;
		}
		void BtnEditDepNewClick(object sender, EventArgs e)
		{
			txEditDepName.Text = "";
			lbEditIDDep.Text = "";
		}
		void BtnEditDepSaveClick(object sender, EventArgs e)
		{
			string sSQL = sSQLEditDep;
			if (lbEditIDDep.Text == "")
			{
				//insert new record
				OleDbDataAdapter adapter = new OleDbDataAdapter(sSQL, connectionDB);
				adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				adapter.InsertCommand = new OleDbCommand(
					        "INSERT INTO tDep (DepName, IDDepType, IDParent, IDMRPerson, IDStatus) " +
					        "VALUES ('"+txEditDepName.Text+"', 2, 1, null, 1)");
				adapter.InsertCommand.Connection = connectionDB;
				adapter.InsertCommand.ExecuteScalar();
				adapter = null;
			}
			else
			{
				//update this record
				OleDbDataAdapter adapter = new OleDbDataAdapter(sSQL, connectionDB);
				adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				adapter.UpdateCommand = new OleDbCommand(
					        "UPDATE tDep SET DepName = '" + txEditDepName.Text + "' " +
					        "WHERE ID = "+lbEditIDDep.Text+"");
				adapter.UpdateCommand.Connection = connectionDB;
				adapter.UpdateCommand.ExecuteScalar();
				adapter = null;
			}
			MakeDataReader("drEditDep", sSQLEditDep);
		}
		void BtnEditDepDeleteClick(object sender, EventArgs e)
		{
			if (lbEditIDDep.Text != "")
			{
				string sSQL = sSQLEditDep;
				OleDbDataAdapter adapter = new OleDbDataAdapter(sSQL, connectionDB);
				adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				adapter.UpdateCommand = new OleDbCommand(
					        "UPDATE tDep SET IDStatus = 2 " +
					        "WHERE ID = "+lbEditIDDep.Text+"");
				adapter.UpdateCommand.Connection = connectionDB;
				adapter.UpdateCommand.ExecuteScalar();
				adapter = null;
				MakeDataReader("drEditDep", sSQLEditDep);
			}
		}
		void BtnEditRankNewClick(object sender, EventArgs e)
		{
			txEditRankName.Text = "";
			lbEditIDRank.Text = "";
		}
		void BtnEditCatNewClick(object sender, EventArgs e)
		{
			txEditCatName.Text = "";
			lbEditIDCat.Text = "";
		}
		void BtnEditDeptypeNewClick(object sender, EventArgs e)
		{
			txEditDeptypeName.Text = "";
			lbEditIDDeptype.Text = "";
		}
		void BtnEditPartNewClick(object sender, EventArgs e)
		{ 
			txEditPartName.Text = "";
			lbEditIDPart.Text = "";
		}
		void BtnEditRankDeleteClick(object sender, EventArgs e)
		{
			if (lbEditIDRank.Text != "")
			{
				string sSQL = sSQLEditRank;
				OleDbDataAdapter adapter = new OleDbDataAdapter(sSQL, connectionDB);
				adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				adapter.UpdateCommand = new OleDbCommand(
					        "UPDATE tRank SET IDStatus = 2 " +
					        "WHERE ID = "+lbEditIDRank.Text+"");
				adapter.UpdateCommand.Connection = connectionDB;
				adapter.UpdateCommand.ExecuteScalar();
				adapter = null;
				MakeDataReader("drEditRank", sSQLEditRank);
			}
		}
		void ChbEditPersonDeathCheckedChanged(object sender, EventArgs e)
		{
			if (chbEditPersonDeath.Checked)
			{
				lbEditPersonDeathdate.Visible = true;
				dtpEditPersonDeathdate.Visible = true;
				dtpEditPersonDeathdate.Value = DateTime.Today;
			}
			else
			{
				lbEditPersonDeathdate.Visible = false;
				dtpEditPersonDeathdate.Visible = false;
				dtpEditPersonDeathdate.Value = dtpEditPersonDeathdate.MaxDate.Date;
			}
		}
		void BtnEditPersonSaveClick(object sender, EventArgs e)
		{
			string sSQL = sSQLEditPerson;
			if (lbEditIDUsingtype.Text == "")
			{
				//insert new record
				OleDbDataAdapter adapter = new OleDbDataAdapter(sSQL, connectionDB);
				adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				adapter.InsertCommand = new OleDbCommand(
					        "INSERT INTO tPerson (LastName, FirstName, Patronymic, Gender, Birthdate, Deathdate, IDStatus) " +
					        "VALUES ('"+txEditPersonLastname.Text+"', '"+txEditPersonFirstname.Text+"', '"+txEditPersonPatronymic.Text+"', 1, '"+dtpEditPersonBirthdate.Value.ToShortDateString()+"', '"+dtpEditPersonDeathdate.Value.ToShortDateString()+"' 1)");
				adapter.InsertCommand.Connection = connectionDB;
				string sID = adapter.InsertCommand.ExecuteScalar().ToString();
				adapter.Dispose();
				adapter = null;
				
				string sIDRankNew = (lbEditPIDRank.Text != "" && int.Parse(lbEditPIDRank.Text) > 0) ? lbEditPIDRank.Text : "1";
				/*if (lbEditPIDRank.Text != "" && int.Parse(lbEditPIDRank.Text) > 0)
				{
					sIDRankNew = lbEditPIDRank.Text;
				}
				else
				{
					sIDRankNew = "1";
				}*/
				sSQL = "select pr.IDPerson, pr.IDRank, pr.DateFrom from tPersonRank pr where pr.IDPerson = " + sID + " ";
				adapter = new OleDbDataAdapter(sSQL, connectionDB);
				adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				adapter.InsertCommand = new OleDbCommand(
					        "INSERT INTO tPersonRank (IDPerson, IDRank, DateFrom) " +
					        "VALUES ("+sID+", "+sIDRankNew+", CDate('"+dtpEditPersonRankDatefrom.Value.ToShortDateString()+"'))");
				adapter.InsertCommand.Connection = connectionDB;
				adapter.Dispose();
				adapter = null;
			}
			else
			{
				//update this record
				string sDeathDate = "";
				if (chbEditPersonDeath.Checked)
				{
					sDeathDate = ", Deathdate = '"+dtpEditPersonDeathdate.Value.ToShortDateString()+"' ";
				}
				OleDbDataAdapter adapter = new OleDbDataAdapter(sSQL, connectionDB);
				adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				adapter.UpdateCommand = new OleDbCommand(
					        "UPDATE tPerson SET LastName = '" + txEditPersonLastname.Text + "', FirstName = '"+txEditPersonFirstname.Text+"', Patronymic = '"+txEditPersonPatronymic.Text+"', " +
					        "Birthdate = '"+dtpEditPersonBirthdate.Value.ToShortDateString()+"' "+sDeathDate +
					        "WHERE ID = "+lbEditIDPerson.Text+"");
				adapter.UpdateCommand.Connection = connectionDB;
				adapter.UpdateCommand.ExecuteScalar();
				adapter = null;
				/*
				aEditPersonList.Find(item => item.ID.ToString() == lbEditIDPerson.Text).LastName = txEditPersonLastname.Text;
				aEditPersonList.Find(item => item.ID.ToString() == lbEditIDPerson.Text).FirstName = txEditPersonFirstname.Text;
				aEditPersonList.Find(item => item.ID.ToString() == lbEditIDPerson.Text).Patronymic = txEditPersonPatronymic.Text;
				aEditPersonList.Find(item => item.ID.ToString() == lbEditIDPerson.Text).Birthdate = dtpEditPersonBirthdate.Value.Date;
				if (chbEditPersonDeath.Checked)
				{
					aEditPersonList.Find(item => item.ID.ToString() == lbEditIDPerson.Text).Deathdate = dtpEditPersonDeathdate.Value.Date;
				}
				*/
				bool isNeedUpdateIDRank = false;
				bool isNeedUpdateRankDate = false;
				sSQL = "select pr.IDPerson, pr.IDRank, pr.DateFrom from tPersonRank pr where pr.IDPerson = " + lbEditIDPerson.Text + " ";
				adapter = new OleDbDataAdapter(sSQL, connectionDB);
				DbDataReader drObjectRank = adapter.SelectCommand.ExecuteReader();
				while (drObjectRank.Read())
				{
					int nRankID = (int)drObjectRank["IDRank"];
					DateTime dtRankDateFrom = (DateTime)drObjectRank["DateFrom"];
					if (!nRankID.Equals(int.Parse(lbEditPIDRank.Text)) && dtRankDateFrom.Date.Equals(dtpEditPersonRankDatefrom.Value.Date))
					{
						isNeedUpdateIDRank = true;
					}
					if (nRankID.Equals(int.Parse(lbEditPIDRank.Text)) && !dtRankDateFrom.Date.Equals(dtpEditPersonRankDatefrom.Value.Date))
					{
						isNeedUpdateRankDate = true;
					}
				}
				if (!drObjectRank.IsClosed && drObjectRank != null)
				{
					drObjectRank.Close();
				}
				drObjectRank = null;
				adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				if (isNeedUpdateIDRank)
				{
					string sUpd = "Update tPersonRank Set IDRank=" + lbEditPIDRank.Text + " " +
						"Where IDPerson=" + lbEditIDPerson.Text + " and DateFrom=CDate('" + dtpEditPersonRankDatefrom.Value.Date.ToShortDateString() + "')";
					adapter.UpdateCommand = new OleDbCommand(
					        sUpd
					        );
					adapter.UpdateCommand.Connection = connectionDB;
					adapter.UpdateCommand.ExecuteScalar();
				}
				else if (isNeedUpdateRankDate)
				{
					string sUpd = "Update tPersonRank Set DateFrom=CDate('" + dtpEditPersonRankDatefrom.Value.Date.ToShortDateString() + "') " +
						"Where IDPerson=" + lbEditIDPerson.Text + " and IDRank=" + lbEditPIDRank.Text;
					adapter.UpdateCommand = new OleDbCommand(
					        sUpd
					        );
					adapter.UpdateCommand.Connection = connectionDB;
					adapter.UpdateCommand.ExecuteScalar();
				}
				else
				{
					string sIns = "INSERT INTO tPersonRank (IDPerson, IDRank, DateFrom) " +
						"VALUES ("+lbEditIDPerson.Text+", "+lbEditPIDRank.Text+", CDate('"+dtpEditPersonRankDatefrom.Value.ToShortDateString()+"'))";
					adapter.InsertCommand = new OleDbCommand(
					       sIns
					       );
					adapter.InsertCommand.Connection = connectionDB;
					adapter.InsertCommand.ExecuteScalar();
				}
				adapter.Dispose();
				adapter = null;
			}
			MakeDataReader("drEditPerson", sSQLEditPerson);
			if (!chbEditPersonDeath.Checked)
			{
				lbEditPersonDeathdate.Visible = false;
				dtpEditPersonDeathdate.Visible = false;
			}
		}
		void BtnEditRankSaveClick(object sender, EventArgs e)
		{
			string sSQL = sSQLEditRank;
			if (lbEditIDRank.Text == "")
			{
				//insert new record
				OleDbDataAdapter adapter = new OleDbDataAdapter(sSQL, connectionDB);
				adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				adapter.InsertCommand = new OleDbCommand(
					        "INSERT INTO tRank (RankName, IDStatus) " +
					        "VALUES ('"+txEditRankName.Text+"', 1)");
				adapter.InsertCommand.Connection = connectionDB;
				adapter.InsertCommand.ExecuteScalar();
				adapter = null;
				MakeDataReader("drEditRank", sSQLEditRank);
			}
			else
			{
				//update this record
				OleDbDataAdapter adapter = new OleDbDataAdapter(sSQL, connectionDB);
				adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				adapter.UpdateCommand = new OleDbCommand(
					        "UPDATE tRank SET RankName = '" + txEditRankName.Text + "' " +
					        "WHERE ID = "+lbEditIDRank.Text+"");
				adapter.UpdateCommand.Connection = connectionDB;
				adapter.UpdateCommand.ExecuteScalar();
				adapter = null;
			}
		}
		void BtnEditPartSaveClick(object sender, EventArgs e)
		{
			string sSQL = sSQLEditPart;
			if (lbEditIDPart.Text == "")
			{
				//insert new record
				OleDbDataAdapter adapter = new OleDbDataAdapter(sSQL, connectionDB);
				adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				adapter.InsertCommand = new OleDbCommand(
					        "INSERT INTO tDep (DepName, IDDepType, IDParent, IDMRPerson, IDStatus) " +
					        "VALUES ('"+txEditPartName.Text+"', 3, null, null, 1)");
				adapter.InsertCommand.Connection = connectionDB;
				adapter.InsertCommand.ExecuteScalar();
				adapter = null;
				MakeDataReader("drEditPart", sSQLEditPart);
			}
			else
			{
				//update this record
				OleDbDataAdapter adapter = new OleDbDataAdapter(sSQL, connectionDB);
				adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				adapter.UpdateCommand = new OleDbCommand(
					        "UPDATE tDep SET DepName = '" + txEditPartName.Text + "' " +
					        "WHERE ID = "+lbEditIDPart.Text+"");
				adapter.UpdateCommand.Connection = connectionDB;
				adapter.UpdateCommand.ExecuteScalar();
				adapter = null;
			}
		}
		void BtnEditPartDeleteClick(object sender, EventArgs e)
		{
			if (lbEditIDPart.Text != "")
			{
				string sSQL = sSQLEditPart;
				OleDbDataAdapter adapter = new OleDbDataAdapter(sSQL, connectionDB);
				adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				adapter.UpdateCommand = new OleDbCommand(
					        "UPDATE tDep SET IDStatus = 2 " +
					        "WHERE ID = "+lbEditIDPart.Text+"");
				adapter.UpdateCommand.Connection = connectionDB;
				adapter.UpdateCommand.ExecuteScalar();
				adapter = null;
				MakeDataReader("drEditPart", sSQLEditPart);
			}
		}
		void BtnEditDeptypeSaveClick(object sender, EventArgs e)
		{
			string sSQL = sSQLEditDeptype;
			if (lbEditIDDeptype.Text == "")
			{
				//insert new record
				OleDbDataAdapter adapter = new OleDbDataAdapter(sSQL, connectionDB);
				adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				adapter.InsertCommand = new OleDbCommand(
					        "INSERT INTO tDepType (TypeName, IDStatus) " +
					        "VALUES ('"+txEditDeptypeName.Text+"', 1)");
				adapter.InsertCommand.Connection = connectionDB;
				adapter.InsertCommand.ExecuteScalar();
				MakeDataReader("drEditDeptype", sSQLEditDeptype);
			}
			else
			{
				//update this record
				OleDbDataAdapter adapter = new OleDbDataAdapter(sSQL, connectionDB);
				adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				adapter.UpdateCommand = new OleDbCommand(
					        "UPDATE tDepType SET TypeName = '" + txEditDeptypeName.Text + "' " +
					        "WHERE ID = "+lbEditIDDeptype.Text+"");
				adapter.UpdateCommand.Connection = connectionDB;
				adapter.UpdateCommand.ExecuteScalar();
				adapter = null;
			}
		}
		void LsbEditRankListSelectedIndexChanged(object sender, EventArgs e)
		{
			Rank rank = new Rank();
			rank = aEditRankList.Find(item => item.ItemIndex == lsbEditRankList.SelectedIndex);
			lbEditIDRank.Text = rank.ID.ToString();
			txEditRankName.Text = rank.RankName;
			rank = null;
		}
		void LsbEditPartListSelectedIndexChanged(object sender, EventArgs e)
		{
			Department part = new Department();
			part = aEditPartList.Find(item => item.ItemIndex == lsbEditPartList.SelectedIndex);
			lbEditIDPart.Text = part.ID.ToString();
			txEditPartName.Text = part.DepName;
			part = null;
		}
		void LsbEditDeptypeListSelectedIndexChanged(object sender, EventArgs e)
		{
			DepType deptype = new DepType();
			deptype = aEditDeptypeList.Find(item => item.ItemIndex == lsbEditDeptypeList.SelectedIndex);
			lbEditIDDeptype.Text = deptype.ID.ToString();
			txEditDeptypeName.Text = deptype.TypeName;
			deptype = null;
		}
		void BtnEditCatDeleteClick(object sender, EventArgs e)
		{
			if (lbEditIDCat.Text != "")
			{
				string sSQL = sSQLEditCat;
				OleDbDataAdapter adapter = new OleDbDataAdapter(sSQL, connectionDB);
				adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				adapter.UpdateCommand = new OleDbCommand(
					        "UPDATE tCat SET IDStatus = 2 " +
					        "WHERE ID = "+lbEditIDCat.Text+"");
				adapter.UpdateCommand.Connection = connectionDB;
				adapter.UpdateCommand.ExecuteScalar();
				adapter.Dispose();
				adapter = null;
				MakeDataReader("drEditCat", sSQLEditCat);
			}
		}
		void BtnEditCatSaveClick(object sender, EventArgs e)
		{
			string sSQL = sSQLEditCat;
			if (lbEditIDCat.Text == "")
			{
				//insert new record
				OleDbDataAdapter adapter = new OleDbDataAdapter(sSQL, connectionDB);
				adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				adapter.InsertCommand = new OleDbCommand(
					        "INSERT INTO tCat (CatName, IDStatus) " +
					        "VALUES ('"+txEditCatName.Text+"', 1)");
				adapter.InsertCommand.Connection = connectionDB;
				adapter.InsertCommand.ExecuteScalar();
				adapter.Dispose();
				adapter = null;
			}
			else
			{
				//update this record
				OleDbDataAdapter adapter = new OleDbDataAdapter(sSQL, connectionDB);
				adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				adapter.UpdateCommand = new OleDbCommand(
					        "UPDATE tCat SET CatName = '" + txEditCatName.Text + "' " +
					        "WHERE ID = "+lbEditIDCat.Text+"");
				adapter.UpdateCommand.Connection = connectionDB;
				adapter.UpdateCommand.ExecuteScalar();
				adapter = null;
			}
			MakeDataReader("drEditCat", sSQLEditCat);
		}
		void BtnEditProdNewClick(object sender, EventArgs e)
		{
			txEditProdtypeName.Text = "";
			lbEditIDProdtype.Text = "";
			if(cbEditPTUsingtypeName.Items.Count > 0)
			{
			  cbEditPTUsingtypeName.SelectedIndex = 0;
			}
		}
		void BtnEditProdDelClick(object sender, EventArgs e)
		{
			if (lbEditIDProdtype.Text != "")
			{
				string sSQL = sSQLEditProdtype;
				OleDbDataAdapter adapter = new OleDbDataAdapter(sSQL, connectionDB);
				adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				adapter.UpdateCommand = new OleDbCommand(
					        "UPDATE tProdType SET IDStatus = 2 " +
					        "WHERE ID = "+lbEditIDProdtype.Text+"");
				adapter.UpdateCommand.Connection = connectionDB;
				adapter.UpdateCommand.ExecuteScalar();
				adapter = null;
				MakeDataReader("drEditProdtype", sSQLEditProdtype);
			}
		}
		void BtnEditProdtypeSaveClick(object sender, EventArgs e)
		{
			string sSQL = sSQLEditProdtype;
			if (lbEditIDProdtype.Text == "")
			{
				//insert new record
				string sSelectedIDUsingType = aEditProdtypeList.Find(item => item.UsingTypeName == cbEditPTUsingtypeName.SelectedItem.ToString()).IDUsingType.ToString();
				OleDbDataAdapter adapter = new OleDbDataAdapter(sSQL, connectionDB);
				adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				adapter.InsertCommand = new OleDbCommand(
					        "INSERT INTO tProdType (TypeName, IDUsingType, IDStatus) " +
							"VALUES ('"+txEditProdtypeName.Text+"', "+sSelectedIDUsingType+", 1)");
				adapter.InsertCommand.Connection = connectionDB;
				adapter.InsertCommand.ExecuteScalar();
				adapter = null;
			}
			else
			{
				//update this record
				Int32 nIDUsingType = aEditProdtypeList.Find(item => item.UsingTypeName == cbEditPTUsingtypeName.SelectedItem.ToString()).IDUsingType;
				OleDbDataAdapter adapter = new OleDbDataAdapter(sSQL, connectionDB);
				adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				adapter.UpdateCommand = new OleDbCommand(
					        "UPDATE tProdType SET TypeName = '" + txEditProdtypeName.Text + "' " +
					        ", IDUsingType = " + nIDUsingType.ToString() + " " +
					        "WHERE ID = "+lbEditIDProdtype.Text+"");
				adapter.UpdateCommand.Connection = connectionDB;
				adapter.UpdateCommand.ExecuteScalar();
				adapter = null;
			}
			MakeDataReader("drEditProdtype", sSQLEditProdtype);
		}
		void LsbEditProdtypeListSelectedIndexChanged(object sender, EventArgs e)
		{
			ProductType prodtype = new ProductType();
			prodtype = aEditProdtypeList.Find(item => item.ItemIndex == lsbEditProdtypeList.SelectedIndex);
			lbEditIDProdtype.Text = prodtype.ID.ToString();
			txEditProdtypeName.Text = prodtype.TypeName;
			cbEditPTUsingtypeName.SelectedIndex = prodtype.UsingTypeItemIndex;
			lbEditPTIDUsingtype.Text = prodtype.IDUsingType.ToString();
			prodtype = null;
		}
		void CbEditUsingtypeNameSelectedIndexChanged(object sender, EventArgs e)
		{
			if (aEditProdtypeList != null && aEditProdtypeList.Count > 0)
			{
				string ssss = cbEditPTUsingtypeName.SelectedItem.ToString();
				ProductType pt = new ProductType();
				pt = aEditProdtypeList.Find(item => item.UsingTypeName == cbEditPTUsingtypeName.SelectedItem.ToString());
				lbEditPTIDUsingtype.Text = (pt == null) ? aEditProdtypeList[0].IDUsingType.ToString() : pt.IDUsingType.ToString();
			}
		}
		void BtnWHClick(object sender, EventArgs e)
		{
			tcWH.Dock = DockStyle.Fill;
			tcWH.Visible = true;
			tcEdit.Visible = false;
			tcDep.Visible = false;
			tcUse.Visible = false;
			CloseDataReadsOfEdit();
			CloseDataReadersOfDep();
			CloseDataReadersOfUse();
			
			scToWH.SplitterDistance = lsbToWHProdtypes.Location.Y + lsbToWHProdtypes.Height + 15;
			scToWHChoicedList.SplitterDistance = btnToWHChoiceSave.Location.Y + btnToWHChoiceSave.Height + 10;
			
			
			//приход на склад
			MakeReadyWHData("drToWH", "all");
			//расход со склада
			MakeReadyWHData("drFromWH", "all");
		}
		void BtnEditUsingtypeNewClick(object sender, EventArgs e)
		{
			txEditUsingtypeName.Text = "";
			lbEditIDUsingtype.Text = "";
		}
		void BtnEditUsingtypeDelClick(object sender, EventArgs e)
		{
			if (lbEditIDUsingtype.Text != "")
			{
				string sSQL = sSQLEditUsingtype;
				OleDbDataAdapter adapter = new OleDbDataAdapter(sSQL, connectionDB);
				adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				adapter.UpdateCommand = new OleDbCommand(
					        "UPDATE tUsingType SET IDStatus = 2 " +
					        "WHERE ID = "+lbEditIDUsingtype.Text+"");
				adapter.UpdateCommand.Connection = connectionDB;
				adapter.UpdateCommand.ExecuteScalar();
				adapter = null;
				MakeDataReader("drEditUsingtype", sSQLEditUsingtype);
			}
		}
		void BtnEditUsingtypeSaveClick(object sender, EventArgs e)
		{
			string sSQL = sSQLEditUsingtype;
			if (lbEditIDUsingtype.Text == "")
			{
				//insert new record
				OleDbDataAdapter adapter = new OleDbDataAdapter(sSQL, connectionDB);
				adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				adapter.InsertCommand = new OleDbCommand(
					        "INSERT INTO tUsingType (TypeName, IDStatus) " +
					        "VALUES ('"+txEditUsingtypeName.Text+"', 1)");
				adapter.InsertCommand.Connection = connectionDB;
				adapter.InsertCommand.ExecuteScalar();
				adapter = null;
			}
			else
			{
				//update this record
				OleDbDataAdapter adapter = new OleDbDataAdapter(sSQL, connectionDB);
				adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				adapter.UpdateCommand = new OleDbCommand(
					        "UPDATE tUsingType SET TypeName = '" + txEditUsingtypeName.Text + "' " +
					        "WHERE ID = "+lbEditIDUsingtype.Text+"");
				adapter.UpdateCommand.Connection = connectionDB;
				adapter.UpdateCommand.ExecuteScalar();
				adapter = null;
			}
			MakeDataReader("drEditUsingtype", sSQLEditUsingtype);
		}
		void LsbEditUsingtypeListSelectedIndexChanged(object sender, EventArgs e)
		{
			UsingType ut = new UsingType();
			ut = aEditUsingtypeList.Find(item => item.ItemIndex == lsbEditUsingtypeList.SelectedIndex);
			lbEditIDUsingtype.Text = ut.ID.ToString();
			txEditUsingtypeName.Text = ut.TypeName;
			ut = null;
		}
		void BtnEditPersonNewClick(object sender, EventArgs e)
		{
			txEditPersonLastname.Text = "";
			txEditPersonFirstname.Text = "";
			txEditPersonPatronymic.Text = "";
			dtpEditPersonBirthdate.Value = DateTime.Now;
			dtpEditPersonDeathdate.Value = DateTime.Now;
			dtpEditPersonDeathdate.Enabled = true;
			dtpEditPersonDeathdate.Visible = true;
			chbEditPersonDeath.Checked = true;
			lbEditIDPerson.Text = "";
			cbEditPersonRankName.SelectedIndex = 0;
			dtpEditPersonRankDatefrom.Value = DateTime.Now;
		}
		void BtnEditPersonDeleteClick(object sender, EventArgs e)
		{
			if (lbEditIDPerson.Text != "")
			{
				string sSQL = sSQLEditPerson;
				OleDbDataAdapter adapter = new OleDbDataAdapter(sSQL, connectionDB);
				adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				adapter.UpdateCommand = new OleDbCommand(
					        "UPDATE tPerson SET IDStatus = 2 " +
					        "WHERE ID = "+lbEditIDPerson.Text+"");
				adapter.UpdateCommand.Connection = connectionDB;
				adapter.UpdateCommand.ExecuteScalar();
				adapter = null;
				MakeDataReader("drEditPerson", sSQLEditPerson);
			}
		}
		void BtnEditPersonFindClick(object sender, EventArgs e)
		{
			//TODO: dont clear array, we must just filter array and show result. we dont need to use db if we have an array with db-data
			
			List<Person> aFoundPersons = aEditPersonList.FindAll(item => item.LastName.Contains(txEditPersonLastname.Text) && item.FirstName.Contains(txEditPersonFirstname.Text) && item.Patronymic.Contains(txEditPersonPatronymic.Text));
			dgvEditPersonList.Rows.Clear();
			foreach (Person p in aFoundPersons)
			{
				dgvEditPersonList.Rows.Add(p.ID, p.LastName, p.FirstName, p.Patronymic, p.Gender, p.Birthdate, p.Deathdate, p.RankName, p.RankDateFrom);
			}
			
			//dgvEditPersonList.Rows.Add(sID, sLastName);
			/*string sFirstName = drObjectPerson["FirstName"].ToString();
			string sPatronymic = drObjectPerson["Patronymic"].ToString();
			string sFIO = sLastName +" "+ sFirstName +" "+ sPatronymic;
			string sGender = (Convert.ToBoolean(drObjectPerson["Gender"]).Equals(true)) ? "М" : "Ж";
			string sBirthdate = Convert.ToDateTime(drObjectPerson["Birthdate"]).Date.ToShortDateString();
			string sDeathdate = Convert.ToDateTime(drObjectPerson["Deathdate"]).Date.ToShortDateString();
			string sIDRank = drObjectPerson["IDRank"].ToString();
			string sRankName = drObjectPerson["RankName"].ToString();
			string sRankDateFrom = Convert.ToDateTime(drObjectPerson["DateFrom"]).Date.ToShortDateString();
			*/
			/*
			//string sSQL = "Select * from tPerson p where upper(p.LastName) like upper('"+txEditPersonLastname.Text+"') and upper(p.FirstName) like upper('"+txEditPersonFirstname.Text+"') and upper(p.Patronymic) like upper('"+txEditPersonPatronymic.Text+"') ";
			string sSQL = sSQLEditPerson + " and ucase(p.LastName) like ucase('%"+txEditPersonLastname.Text+"%') and ucase(p.FirstName) like ucase('%"+txEditPersonFirstname.Text+"%') and ucase(p.Patronymic) like ucase('%"+txEditPersonPatronymic.Text+"%') " +
				((dtpEditPersonBirthdate.Value.Date.Equals(DateTime.Today.Date)) ? " " : " and p.birthdate = CDate('" +dtpEditPersonBirthdate.Value.Date.ToShortDateString()+"')")
				+ " and p.gender = " + ((rbEditPersonGenderM.Checked) ? "true " : "false ");
			OleDbDataAdapter adapter = new OleDbDataAdapter(sSQL, connectionDB);
			DbDataReader drObjectPerson = adapter.SelectCommand.ExecuteReader();
			aEditPersonList.Clear();
			dgvEditPersonList.Rows.Clear();
			while (drObjectPerson.Read())
			{
				string sID = drObjectPerson["ID"].ToString();
				string sLastName = drObjectPerson["LastName"].ToString();
				string sFirstName = drObjectPerson["FirstName"].ToString();
				string sPatronymic = drObjectPerson["Patronymic"].ToString();
				string sFIO = sLastName +" "+ sFirstName +" "+ sPatronymic;
				string sGender = (Convert.ToBoolean(drObjectPerson["Gender"]).Equals(true)) ? "М" : "Ж";
				string sBirthdate = Convert.ToDateTime(drObjectPerson["Birthdate"]).Date.ToShortDateString();
				string sDeathdate = Convert.ToDateTime(drObjectPerson["Deathdate"]).Date.ToShortDateString();
				string sIDRank = drObjectPerson["IDRank"].ToString();
				string sRankName = drObjectPerson["RankName"].ToString();
				string sRankDateFrom = Convert.ToDateTime(drObjectPerson["DateFrom"]).Date.ToShortDateString();
				lsbEditPersonList.Items.Add(sFIO);
				lsbEditPersonList.SelectedItem = lsbEditPersonList.Items.IndexOf(sFIO);
				lbEditIDPerson.Text = sID;
				dgvEditPersonList.Rows.Add(sID, sLastName, sFirstName, sPatronymic, sGender, sBirthdate, sDeathdate, sRankName, sRankDateFrom);
			}
			if (!drObjectPerson.IsClosed && drObjectPerson != null)
			{
				drObjectPerson.Close();
			}
			drObjectPerson = null;
			adapter.Dispose();
			adapter = null;
			*/
		}
		void MakeReadyWHData(string sWHTab, string sObj)
		{
			OleDbDataAdapter adapter;
			DbDataReader datareaderObject;
			if (sWHTab == "drToWH")
			{
				string sSQL = "";
				if (sObj == "all" || sObj == "cbToWHCat")
				{
					//-----------------------
					//list of Category for combo
					sSQL = "select * from tCat c where c.idstatus = 1";
					adapter = new OleDbDataAdapter(sSQL, connectionDB);
					datareaderObject = adapter.SelectCommand.ExecuteReader();
					cbToWHCat.Items.Clear();
					aToWHCat.Clear();
					while (datareaderObject.Read())
					{
						string sID = datareaderObject["ID"].ToString();
						string sName = datareaderObject["CatName"].ToString();
						cbToWHCat.Items.Add(sName);
						lbToWHIDCat.Text = sID;
						Category cat = new Category();
						cat.ItemIndex = cbToWHCat.Items.IndexOf(sName);
						cat.ID = Int32.Parse(sID);
						cat.CatName = sName;
						aToWHCat.Add(cat);
					}
					cbToWHCat.SelectedIndex = 0;
					if (!datareaderObject.IsClosed && datareaderObject != null)
					{
						datareaderObject.Close();
					}
					datareaderObject = null;
					adapter.Dispose();
					adapter = null;
					//-----------------------
				}
				
				if (sObj == "all" || sObj == "cbToWHFromName")
				{
					//TODO: Check value of IDDeptType if that is right
					//list of Dep for "where from" combo
					if (rbToWHFromPart.Checked)
					{
						sSQL = "select * from tDep d where d.idparent is null and d.id <> " + sIDPartCurrent + " and d.idstatus = 1 and iddeptype = 3";
					}
					else
					{
						sSQL = "select * from tDep d where d.idparent = " + sIDPartCurrent + " and d.idstatus = 1 and iddeptype = 2";
					}
					adapter = new OleDbDataAdapter(sSQL, connectionDB);
					datareaderObject = adapter.SelectCommand.ExecuteReader();
					cbToWHFromName.Items.Clear();
					aToWHFromList.Clear();
					while (datareaderObject.Read())
					{
						string sID = datareaderObject["ID"].ToString();
						string sName = datareaderObject["DepName"].ToString();
						string sIDDepType = datareaderObject["IDDepType"].ToString();
						cbToWHFromName.Items.Add(sName);
						lbToWHFromIDDep.Text = sID;
						Department dep = new Department();
						dep.ItemIndex = cbToWHFromName.Items.IndexOf(sName);
						dep.ID = Int32.Parse(sID);
						dep.DepName = sName;
						dep.IDDepType = Int16.Parse(sIDDepType);
						aToWHFromList.Add(dep);
						dep = null;
					}
					cbToWHFromName.SelectedIndex = 0;
					if (!datareaderObject.IsClosed && datareaderObject != null)
					{
						datareaderObject.Close();
					}
					datareaderObject = null;
					adapter.Dispose();
					adapter = null;
				}
				
				if (sObj == "all" || sObj == "lsbToWHProdtypes")
				{
					//-----------------------
					//list of ProductType for listbox available types
					sSQL = "select pt.ID, pt.TypeName, pt.IDUsingType, ut.TypeName as UsingTypeName from tProdType pt left join tUsingType ut on ut.ID = pt.IDUsingType where pt.IDStatus = 1";
					adapter = new OleDbDataAdapter(sSQL, connectionDB);
					datareaderObject = adapter.SelectCommand.ExecuteReader();
					lsbToWHProdtypes.Items.Clear();
					aToWHProdTypesList.Clear();
					while (datareaderObject.Read())
					{
						string sID = datareaderObject["ID"].ToString();
						string sName = datareaderObject["TypeName"].ToString();
						string sIDUsingType = datareaderObject["IDUsingType"].ToString();
						string sUsingTypeName = datareaderObject["UsingTypeName"].ToString();
						lsbToWHProdtypes.Items.Add(sName);
						ProductType pt = new ProductType();
						pt.ItemIndex = lsbToWHProdtypes.Items.IndexOf(sName);
						pt.ID = Int32.Parse(sID);
						pt.TypeName = sName;
						pt.IDUsingType = Int32.Parse(sIDUsingType);
						pt.UsingTypeName = sUsingTypeName;
						aToWHProdTypesList.Add(pt);
						pt = null;
					}
					if (!datareaderObject.IsClosed && datareaderObject != null)
					{
						datareaderObject.Close();
					}
					datareaderObject = null;
					adapter.Dispose();
					adapter = null;
					//-----------------------
				}
				//get all data in WH
				ShowDataOfWH("drToWH");
			}
			//TODO: finish this block:
			else if (sWHTab == "drFromWH")
			{
				string sSQL = "";
				if (sObj == "all" || sObj == "cbFromWHCat")
				{
					//-----------------------
					//list of Category for combo
					sSQL = "select * from tCat c where c.idstatus = 1";
					adapter = new OleDbDataAdapter(sSQL, connectionDB);
					datareaderObject = adapter.SelectCommand.ExecuteReader();
					cbFromWHCat.Items.Clear();
					aFromWHCat.Clear();
					while (datareaderObject.Read())
					{
						string sID = datareaderObject["ID"].ToString();
						string sName = datareaderObject["CatName"].ToString();
						cbFromWHCat.Items.Add(sName);
						lbFromWHIDCat.Text = sID;
						Category cat = new Category();
						cat.ItemIndex = cbFromWHCat.Items.IndexOf(sName);
						cat.ID = Int32.Parse(sID);
						cat.CatName = sName;
						aFromWHCat.Add(cat);
					}
					cbFromWHCat.SelectedIndex = 0;
					if (!datareaderObject.IsClosed && datareaderObject != null)
					{
						datareaderObject.Close();
					}
					datareaderObject = null;
					adapter.Dispose();
					adapter = null;
					//-----------------------
				}
				
				if (sObj == "all" || sObj == "cbFromWHToDep")
				{
					//list of Dep for "where from" combo
					if (rbFromWHtoPart.Checked)
					{
						sSQL = "select * from tDep d where d.idparent is null and d.id <> " + sIDPartCurrent + " and d.idstatus = 1 and iddeptype = 3";
					}
					else
					{
						sSQL = "select * from tDep d where d.idparent = " + sIDPartCurrent + " and d.idstatus = 1 and iddeptype = 2";
					}
					adapter = new OleDbDataAdapter(sSQL, connectionDB);
					datareaderObject = adapter.SelectCommand.ExecuteReader();
					cbFromWHToDep.Items.Clear();
					aFromWHToList.Clear();
					while (datareaderObject.Read())
					{
						string sID = datareaderObject["ID"].ToString();
						string sName = datareaderObject["DepName"].ToString();
						cbFromWHToDep.Items.Add(sName);
						lbFromWHToIDDep.Text = sID;
						Department dep = new Department();
						dep.ItemIndex = cbFromWHToDep.Items.IndexOf(sName);
						dep.ID = Int32.Parse(sID);
						dep.DepName = sName;
						aFromWHToList.Add(dep);
						dep = null;
					}
					cbFromWHToDep.SelectedIndex = 0;
					if (!datareaderObject.IsClosed && datareaderObject != null)
					{
						datareaderObject.Close();
					}
					datareaderObject = null;
					adapter.Dispose();
					adapter = null;
				}
				
				if (sObj == "all" || sObj == "lsbFromWHProdTypes")
				{
					//-----------------------
					//list of ProductType for listbox available types
					sSQL = "select pt.ID, pt.TypeName, pt.IDUsingType, ut.TypeName as UsingTypeName from tProdType pt left join tUsingType ut on ut.ID = pt.IDUsingType where pt.IDStatus = 1";
					adapter = new OleDbDataAdapter(sSQL, connectionDB);
					datareaderObject = adapter.SelectCommand.ExecuteReader();
					lsbFromWHProdTypes.Items.Clear();
					aFromWHProdTypesList.Clear();
					while (datareaderObject.Read())
					{
						string sID = datareaderObject["ID"].ToString();
						string sName = datareaderObject["TypeName"].ToString();
						string sIDUsingType = datareaderObject["IDUsingType"].ToString();
						string sUsingTypeName = datareaderObject["UsingTypeName"].ToString();
						lsbFromWHProdTypes.Items.Add(sName);
						ProductType pt = new ProductType();
						pt.ItemIndex = lsbFromWHProdTypes.Items.IndexOf(sName);
						pt.ID = Int32.Parse(sID);
						pt.TypeName = sName;
						pt.IDUsingType = Int32.Parse(sIDUsingType);
						pt.UsingTypeName = sUsingTypeName;
						aFromWHProdTypesList.Add(pt);
						pt = null;
					}
					if (!datareaderObject.IsClosed && datareaderObject != null)
					{
						datareaderObject.Close();
					}
					datareaderObject = null;
					adapter.Dispose();
					adapter = null;
					//-----------------------
				}
				//get all data in WH
				ShowDataOfWH("drFromWH");
			}
		}
		
		void CbToWHFromNameSelectedIndexChanged(object sender, EventArgs e)
		{
			if (aToWHFromList.Count > 0 )
			{
				lbToWHFromIDDep.Text = aToWHFromList.Find(item => item.ItemIndex == cbToWHFromName.SelectedIndex).ID.ToString();
			}
			else
			{
				lbToWHFromIDDep.Text = "";
			}
		}
		void RbToWHFromPartCheckedChanged(object sender, EventArgs e)
		{
			MakeReadyWHData("drToWH", "cbToWHFromName");
		}
		void TxToWHFindProdKeyUp(object sender, KeyEventArgs e)
		{
			string sFind = txToWHFindProd.Text;
			/* //might this code will work slow, better use code in bottom using only array
 			string sSQL = "select pt.ID, pt.TypeName, pt.IDUsingType, ut.TypeName as UsingTypeName from tProdType pt left join tUsingType ut on ut.ID = pt.IDUsingType where pt.IDStatus = 1 and upper(pt.TypeName) like upper('%"+sFind+"%')";
			OleDbDataAdapter adapter = new OleDbDataAdapter(sSQL, connectionDB);;
			DbDataReader datareaderObject = adapter.SelectCommand.ExecuteReader();
			lsbToWHProdtypes.Items.Clear();
			aToWHProdTypesList.Clear();
			while (datareaderObject.Read())
			{
				string sID = datareaderObject["ID"].ToString();
				string sName = datareaderObject["TypeName"].ToString();
				string sIDUsingType = datareaderObject["IDUsingType"].ToString();
				string sUsingTypeName = datareaderObject["UsingTypeName"].ToString();
				lsbToWHProdtypes.Items.Add(sName);
				ProductType pt = new ProductType();
				pt.ItemIndex = lsbToWHProdtypes.Items.IndexOf(sName);
				pt.ID = Int32.Parse(sID);
				pt.TypeName = sName;
				pt.IDUsingType = Int32.Parse(sIDUsingType);
				pt.UsingTypeName = sUsingTypeName;
				aToWHProdTypesList.Add(pt);
				pt = null;
			}
			if (!datareaderObject.IsClosed && datareaderObject != null)
			{
				datareaderObject.Close();
			}
			datareaderObject = null;
			adapter.Dispose();
			adapter = null;
			*/
			//using array:
			if (aToWHProdTypesList.Count > 0)
			{
				lsbToWHProdtypes.Items.Clear();
				foreach (ProductType pt in aToWHProdTypesList)
				{
					if (pt.TypeName.ToUpper().Contains(sFind.ToUpper()))
					{
						lsbToWHProdtypes.Items.Add(pt.TypeName);
					}
				}
			}
		}
		void LsbEditCatListSelectedIndexChanged(object sender, EventArgs e)
		{
			Category category = new Category();
			category = aEditCatList.Find(item => item.ItemIndex == lsbEditCatList.SelectedIndex);
			lbEditIDCat.Text = category.ID.ToString();
			txEditCatName.Text = category.CatName;
			category = null;
		}
		void BtnToWHChoiceProdClick(object sender, EventArgs e)
		{
			if (aToWHProdTypesList.Count > 0)
			{
				//dgvEditPersonList.Rows.Clear();
				if (dgvToWHChoicedProds.ColumnCount <= 10)
				{
					//dgvToWHChoicedProds.Columns.Clear();
					int nCol = dgvToWHChoicedProds.ColumnCount;
					while (dgvToWHChoicedProds.ColumnCount < 10)
					{
						switch (nCol)
						{
							case 0:
								dgvToWHChoicedProds.Columns.Add("IDProdType", "ID");
								break;
							case 1:
								dgvToWHChoicedProds.Columns.Add("ProdTypeName", "Вид ценности");
								break;
							case 2:
								dgvToWHChoicedProds.Columns.Add("ProdCount", "Количество");
								break;
							case 3:
								dgvToWHChoicedProds.Columns.Add("ProdPrice", "Цена");
								break;
							case 4:
								dgvToWHChoicedProds.Columns.Add("InvNum", "Инв номер");
								break;
							case 5:
								dgvToWHChoicedProds.Columns.Add("CatName", "Категория");
								break;
							case 6:
								dgvToWHChoicedProds.Columns.Add("FromDepName", "Отправитель");
								break;
							case 7:
								dgvToWHChoicedProds.Columns.Add("ToDepName", "Получатель");
								break;
							case 8:
								dgvToWHChoicedProds.Columns.Add("ActNum", "Номер акта");
								break;
							case 9:
								dgvToWHChoicedProds.Columns.Add("ActDate", "Дата акта");
								break;
							default:
								dgvToWHChoicedProds.Columns.Add("Column"+nCol.ToString(), "Столбец"+nCol.ToString());
								break;
						}
						nCol++;
					}
				}
				foreach (string item in lsbToWHProdtypes.SelectedItems)
				{
					GivingProd prod = new GivingProd();
					prod.ProdType = aToWHProdTypesList.Find(element => element.TypeName == item);
					if (double.TryParse(mtxToWHPrice.Text, out prod.ProdPrice) == false)
					{
						MessageBox.Show("Неправильно указана цена <" + mtxToWHPrice.Text + ">");
						prod.ProdPrice = 0;
					}
					prod.ActNum = txToWHActNum.Text;
					prod.ActDate = dtpToWHActDate.Value;
					prod.FromDep = aToWHFromList.Find(element => element.DepName == cbToWHFromName.SelectedItem.ToString());
					
					//current part (department)
					string sSQLCurrentPart = "select d.*, dt.TypeName from tDep d left join tDepType dt on dt.ID = d.IDDepType where d.idParent = " + sIDPartCurrent;
					OleDbDataAdapter adapter = new OleDbDataAdapter(sSQLCurrentPart, connectionDB);
					DbDataReader datareaderObject = adapter.SelectCommand.ExecuteReader();
					if (datareaderObject.Read())
					{
						string sID = datareaderObject["ID"].ToString();
						string sName = datareaderObject["DepName"].ToString();
						string sIDDepType = datareaderObject["IDDepType"].ToString();
						string sDepTypeName = datareaderObject["TypeName"].ToString();
						Department curPart = new Department();
						curPart.ItemIndex = 0;
						curPart.ID = Int32.Parse(sID);
						curPart.DepName = sName;
						curPart.IDDepType = Convert.ToInt16(sIDDepType);
						curPart.DepTypeName = sDepTypeName;
						prod.ToDep = curPart;
						curPart = null;
					}
					if (!datareaderObject.IsClosed && datareaderObject != null)
					{
						datareaderObject.Close();
					}
					datareaderObject = null;
					adapter.Dispose();
					adapter = null;
					
					if (!int.TryParse(udToWHProdCount.Text, out prod.ProdCount))
					{
						MessageBox.Show("Цена указана неправильно!");
						prod.ProdCount = 0;
					}
					prod.ProdCategory = aToWHCat.Find(elem => elem.CatName == cbToWHCat.SelectedItem.ToString());
					
					//TODO: check the value of IDUsingType in this condition:
					if (aToWHProdTypesList.Find(element => element.TypeName == item).IDUsingType == 1)
					{
						prod.InvNum = txToWHInvNum.Text;
					}
					else
					{
						prod.InvNum = "";
					}
					
					aToWHChoicedProdsList.Add(prod);
					dgvToWHChoicedProds.Rows.Add(prod.ProdType.ID, prod.ProdType.TypeName, prod.ProdCount, prod.ProdPrice, prod.InvNum, prod.ProdCategory.CatName, prod.FromDep.DepName, prod.ToDep.DepTypeName + "(" + prod.ToDep.DepName + ")", prod.ActNum, prod.ActDate);
					prod = null;
				}
				
				/// <summary>
				/// steps:
				/// 1) insert into tAct, save newID
				/// 2) insert into tActProd vales(choiced prods)
				/// 4) insert into tDeptoDep --not need
				/// </summary>
				//insert new record
				string sSQL = "";
				string sIDAct = string.Empty;
				string sActNum = txToWHActNum.Text;
				string sActDate = dtpToWHActDate.Value.ToShortDateString();
				string sIDDepFrom = lbToWHFromIDDep.Text;
				
				sSQL = "select * from tAct a where a.ActNum = '" + sActNum + "' and a.actdate = CDate('"+sActDate+"') and a.IDDepFrom = "+sIDDepFrom;
				OleDbDataAdapter adapterAct = new OleDbDataAdapter(sSQL, connectionDB);
				DbDataReader datareaderObjectSave;
				
				//try to find this act
				datareaderObjectSave = adapterAct.SelectCommand.ExecuteReader();
				if (datareaderObjectSave.Read())
				{
					sIDAct = datareaderObjectSave["ID"].ToString();
					string sActN = datareaderObjectSave["ActNum"].ToString();
				}
				if (!datareaderObjectSave.IsClosed && datareaderObjectSave != null)
				{
					datareaderObjectSave.Close();
				}
				datareaderObjectSave = null;
				
				//if act is new, then create new act
				if (sIDAct.Equals(string.Empty))
				{
					adapterAct.MissingSchemaAction = MissingSchemaAction.AddWithKey;
					adapterAct.InsertCommand = new OleDbCommand(
						        "INSERT INTO tAct (ActNum, ActDate, IDTransferType, IDDepFrom, IDDepTo) " +
						        "VALUES ('"+sActNum+"', CDate('"+sActDate+"'), 1, "+sIDDepFrom+", "+sIDWHCurrent+")"
						       );
					adapterAct.InsertCommand.Connection = connectionDB;
					//TODO: this line is error, I must fix it
					//sIDAct = (string)adapter.InsertCommand.ExecuteScalar();
					adapterAct.InsertCommand.ExecuteScalar();
					
					datareaderObjectSave = adapterAct.SelectCommand.ExecuteReader();
					if (datareaderObjectSave.Read())
					{
						sIDAct = datareaderObjectSave["ID"].ToString();
						string sActN = datareaderObjectSave["ActNum"].ToString();
					}
					if (!datareaderObjectSave.IsClosed && datareaderObjectSave != null)
					{
						datareaderObjectSave.Close();
					}
					datareaderObjectSave = null;
				}
				adapterAct.Dispose();
				adapterAct = null;
				
				//add products for this act
				sSQL = "select * from tActProd ap where ap.idact = " + sIDAct;
				adapterAct = new OleDbDataAdapter(sSQL, connectionDB);
				adapterAct.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				foreach (GivingProd pr in aToWHChoicedProdsList)
				{
					adapterAct.InsertCommand = new OleDbCommand(
						        "INSERT INTO tActProd (IDAct, IDProdType, ProdPrice, ProdCount, InvNum, IDProdCat) " +
						        "VALUES ("+sIDAct+", "+pr.ProdType.ID.ToString()+", "+pr.ProdPrice.ToString()+", "+pr.ProdCount+", "+((pr.InvNum.Equals(string.Empty)) ? "null" : pr.InvNum)+", "+pr.ProdCategory.ID+")"
						       );
					adapterAct.InsertCommand.Connection = connectionDB;
					adapterAct.InsertCommand.ExecuteScalar();
					adapterAct.InsertCommand.Dispose();
					adapterAct.InsertCommand = null;
				}
				adapterAct.Dispose();
				adapterAct = null;
				
				MessageBox.Show("Сохранил");
			}
		}
		void LsbToWHProdtypesSelectedIndexChanged(object sender, EventArgs e)
		{
			if (aToWHProdTypesList.Count > 0)
			{
				foreach (string item in lsbToWHProdtypes.SelectedItems)
				{
					//TODO: check the value of IDUsingType in this condition:
					if (aToWHProdTypesList.Find(element => element.TypeName == item).IDUsingType == 1)
					{
						lbToWHInvNum.Visible = true;
						txToWHInvNum.Visible = true;
						break;
					}
					else
					{
						lbToWHInvNum.Visible = false;
						txToWHInvNum.Visible = false;
					}
				}
			}
		}
		void LsbEditPersonListSelectedIndexChanged(object sender, EventArgs e)
		{
			lbEditIDPerson.Text = aEditPersonList.Find(item => item.ItemIndex == lsbEditPersonList.SelectedIndex).ID.ToString();
			txEditPersonLastname.Text = aEditPersonList.Find(item => item.ItemIndex == lsbEditPersonList.SelectedIndex).LastName;
			txEditPersonFirstname.Text = aEditPersonList.Find(item => item.ItemIndex == lsbEditPersonList.SelectedIndex).FirstName;
			txEditPersonPatronymic.Text = aEditPersonList.Find(item => item.ItemIndex == lsbEditPersonList.SelectedIndex).Patronymic;
			if (aEditPersonList.Find(item => item.ItemIndex == lsbEditPersonList.SelectedIndex).Gender.Equals(true))
			{
				rbEditPersonGenderM.Checked = true;
			}
			else
			{
				rbEditPersonGenderF.Checked = true;
			}
			dtpEditPersonBirthdate.Value = aEditPersonList.Find(item => item.ItemIndex == lsbEditPersonList.SelectedIndex).Birthdate;
			if (aEditPersonList.Find(item => item.ItemIndex == lsbEditPersonList.SelectedIndex).Deathdate.ToString().Equals(string.Empty))
			{
				dtpEditPersonDeathdate.Value = dtpEditPersonDeathdate.MaxDate;
				dtpEditPersonDeathdate.Visible = false;
				chbEditPersonDeath.Checked = false;
			}
			else
			{
				dtpEditPersonDeathdate.Value = aEditPersonList.Find(item => item.ItemIndex == lsbEditPersonList.SelectedIndex).Deathdate;
				if (dtpEditPersonDeathdate.Value <= DateTime.Today)
				{
					dtpEditPersonDeathdate.Visible = true;
					chbEditPersonDeath.Checked = true;	
				}
				else
				{
					dtpEditPersonDeathdate.Visible = false;
					chbEditPersonDeath.Checked = false;	
				}
			}
			int nIDRank = aEditPersonList.Find(items => items.ItemIndex == lsbEditPersonList.SelectedIndex).IDRank;
			cbEditPersonRankName.SelectedIndex = aEditRankList.Find(item => item.ID.Equals(nIDRank)).ItemIndex;
			lbEditPIDRank.Text = nIDRank.ToString();
			dtpEditPersonRankDatefrom.Value = aEditPersonList.Find(items => items.ItemIndex == lsbEditPersonList.SelectedIndex).RankDateFrom;
		}
		void CbEditPersonRankNameSelectedIndexChanged(object sender, EventArgs e)
		{
			lbEditPIDRank.Text = aEditRankList.Find(item => item.RankName.Equals(cbEditPersonRankName.SelectedItem.ToString())).ID.ToString();
		}
		void DgvEditPersonListSelectionChanged(object sender, EventArgs e)
		{
			if (aEditPersonList.Count > 0)
			{
				//lbEditIDPerson.Text = aEditPersonList.Find(item => item.ItemIndex == lsbEditPersonList.SelectedIndex).ID.ToString();
				lbEditIDPerson.Text = aEditPersonList.Find(item => item.ID == Convert.ToInt32(dgvEditPersonList.CurrentRow.Cells["IDPerson"].Value)).ID.ToString();
				
				//txEditPersonLastname.Text = aEditPersonList.Find(item => item.ItemIndex == lsbEditPersonList.SelectedIndex).LastName;
				txEditPersonLastname.Text = aEditPersonList.Find(item => item.ID == Convert.ToInt32(dgvEditPersonList.CurrentRow.Cells["IDPerson"].Value)).LastName;
				
				//txEditPersonFirstname.Text = aEditPersonList.Find(item => item.ItemIndex == lsbEditPersonList.SelectedIndex).FirstName;
				txEditPersonFirstname.Text = aEditPersonList.Find(item => item.ID == Convert.ToInt32(dgvEditPersonList.CurrentRow.Cells["IDPerson"].Value)).FirstName;
				
				//txEditPersonPatronymic.Text = aEditPersonList.Find(item => item.ItemIndex == lsbEditPersonList.SelectedIndex).Patronymic;
				txEditPersonPatronymic.Text = aEditPersonList.Find(item => item.ID == Convert.ToInt32(dgvEditPersonList.CurrentRow.Cells["IDPerson"].Value)).Patronymic; //Convert.ToString(dgvEditPersonList.CurrentRow.Cells["Patronymic"].Value);
				
				/*if (aEditPersonList.Find(item => item.ItemIndex == lsbEditPersonList.SelectedIndex).Gender.Equals(true))
				{
					rbEditPersonGenderM.Checked = true;
				}
				else
				{
					rbEditPersonGenderF.Checked = true;
				}*/
				if (aEditPersonList.Find(item => item.ID == Convert.ToInt32(dgvEditPersonList.CurrentRow.Cells["IDPerson"].Value)).Gender.Equals(true))
					//(Convert.ToString(dgvEditPersonList.CurrentRow.Cells["Gender"].Value.Equals("М")))
				{
					rbEditPersonGenderM.Checked = true;
				}
				else
				{
					rbEditPersonGenderF.Checked = true;
				}
				
				//dtpEditPersonBirthdate.Value = aEditPersonList.Find(item => item.ItemIndex == lsbEditPersonList.SelectedIndex).Birthdate;
				dtpEditPersonBirthdate.Value = aEditPersonList.Find(item => item.ID == Convert.ToInt32(dgvEditPersonList.CurrentRow.Cells["IDPerson"].Value)).Birthdate;
				
				/*if (aEditPersonList.Find(item => item.ItemIndex == lsbEditPersonList.SelectedIndex).Deathdate.ToString().Equals(string.Empty))
				{
					dtpEditPersonDeathdate.Value = dtpEditPersonDeathdate.MaxDate;
					dtpEditPersonDeathdate.Visible = false;
					chbEditPersonDeath.Checked = false;
				}
				else
				{
					dtpEditPersonDeathdate.Value = aEditPersonList.Find(item => item.ItemIndex == lsbEditPersonList.SelectedIndex).Deathdate;
					if (dtpEditPersonDeathdate.Value <= DateTime.Today)
					{
						dtpEditPersonDeathdate.Visible = true;
						chbEditPersonDeath.Checked = true;	
					}
					else
					{
						dtpEditPersonDeathdate.Visible = false;
						chbEditPersonDeath.Checked = false;	
					}
				}*/
				if (aEditPersonList.Find(item => item.ID == Convert.ToInt32(dgvEditPersonList.CurrentRow.Cells["IDPerson"].Value)).Deathdate.ToString().Equals(string.Empty))
					//(Convert.ToDateTime(dgvEditPersonList.CurrentRow.Cells["Deathdate"].Value).Date > DateTime.Today)
				{
					dtpEditPersonDeathdate.Value = dtpEditPersonDeathdate.MaxDate.Date;
					dtpEditPersonDeathdate.Visible = false;
					chbEditPersonDeath.Checked = false;
				}
				else
				{
					dtpEditPersonDeathdate.Value = aEditPersonList.Find(item => item.ID == Convert.ToInt32(dgvEditPersonList.CurrentRow.Cells["IDPerson"].Value)).Deathdate;
					if (dtpEditPersonDeathdate.Value <= DateTime.Today)
					{
						dtpEditPersonDeathdate.Visible = true;
						chbEditPersonDeath.Checked = true;	
					}
					else
					{
						dtpEditPersonDeathdate.Visible = false;
						chbEditPersonDeath.Checked = false;	
					}
				}
				
				//int nIDRank = aEditPersonList.Find(items => items.ItemIndex == lsbEditPersonList.SelectedIndex).IDRank;
				int nIDRank = aEditPersonList.Find(items => items.ID == Convert.ToInt32(dgvEditPersonList.CurrentRow.Cells["IDPerson"].Value)).IDRank;
				
				cbEditPersonRankName.SelectedIndex = aEditRankList.Find(item => item.ID.Equals(nIDRank)).ItemIndex;
				lbEditPIDRank.Text = nIDRank.ToString();
				//dtpEditPersonRankDatefrom.Value = aEditPersonList.Find(items => items.ItemIndex == lsbEditPersonList.SelectedIndex).RankDateFrom;
				dtpEditPersonRankDatefrom.Value = aEditPersonList.Find(items => items.ID == Convert.ToInt32(dgvEditPersonList.CurrentRow.Cells["IDPerson"].Value)).RankDateFrom;
			}
		}
		void LsbEditDepListSelectedIndexChanged(object sender, EventArgs e)
		{
			Department department = new Department();
			department = aEditDepList.Find(item => item.ItemIndex == lsbEditDepList.SelectedIndex);
			lbEditIDDep.Text = department.ID.ToString();
			txEditDepName.Text = department.DepName;
			department = null;
		}
		void BtnEditProdtypeNewClick(object sender, EventArgs e)
		{
			txEditProdtypeName.Text = "";
			lbEditIDProdtype.Text = "";
			cbEditPTUsingtypeName.SelectedIndex = 0;
			lbEditPTIDUsingtype.Text = aEditUsingtypeList.Find(item => item.ItemIndex == cbEditPTUsingtypeName.SelectedIndex).ID.ToString();;
		}
		void BtnEditUsingtypesEditClick(object sender, EventArgs e)
		{
			tpUsingType.Show();
			tcEdit.SelectedTab = tpUsingType;
		}
		void BtnReportClick(object sender, EventArgs e)
		{
			tcUse.Visible = false;
			tcEdit.Visible = false;
			tcWH.Visible = false;
			tcDep.Visible = false;
			CloseDataReadsOfEdit();
			CloseDataReadsOfWH();
			CloseDataReadersOfDep();
		}
		void BtnWriteoffClick(object sender, EventArgs e)
		{
			tcUse.Visible = false;
			tcEdit.Visible = false;
			tcWH.Visible = false;
			tcDep.Visible = false;
			CloseDataReadsOfEdit();
			CloseDataReadsOfWH();
			CloseDataReadersOfDep();
		}
		void MakeReadyDepData(string sDataReader, string sTab)
		{
			MessageBox.Show("Эта фукнция пока не разработана");
		}
		void BtnEditDeptypeDelClick(object sender, EventArgs e)
		{
			if (lbEditIDDeptype.Text != "")
			{
				string sSQL = sSQLEditDeptype;
				OleDbDataAdapter adapter = new OleDbDataAdapter(sSQL, connectionDB);
				adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				adapter.UpdateCommand = new OleDbCommand(
					        "UPDATE tDepType SET IDStatus = 2 " +
					        "WHERE ID = "+lbEditIDDeptype.Text+"");
				adapter.UpdateCommand.Connection = connectionDB;
				adapter.UpdateCommand.ExecuteScalar();
				adapter = null;
				MakeDataReader("drEditDeptype", sSQLEditDeptype);
			}
		}
		void BtnEditProdtypeDelClick(object sender, EventArgs e)
		{
			if (lbEditIDProdtype.Text != "")
			{
				string sSQL = sSQLEditProdtype;
				OleDbDataAdapter adapter = new OleDbDataAdapter(sSQL, connectionDB);
				adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				adapter.UpdateCommand = new OleDbCommand(
					        "UPDATE tProdType SET IDStatus = 2 " +
					        "WHERE ID = "+lbEditIDProdtype.Text+"");
				adapter.UpdateCommand.Connection = connectionDB;
				adapter.UpdateCommand.ExecuteScalar();
				adapter = null;
				MakeDataReader("drEditProdtype", sSQLEditProdtype);
			}
		}
		void CbEditPTUsingtypeNameSelectedIndexChanged(object sender, EventArgs e)
		{
			if (aEditUsingtypeList.Count > 0)
			{
				lbEditPTIDUsingtype.Text = aEditUsingtypeList.Find(item => item.ItemIndex == cbEditPTUsingtypeName.SelectedIndex).ID.ToString();
			}
			else
			{
				lbEditPTIDUsingtype.Text = "";
			}
		}
		void CbFromWHCatSelectedIndexChanged(object sender, EventArgs e)
		{
			if (aFromWHCat.Count > 0)
			{
				lbFromWHIDCat.Text = aFromWHCat.Find(item => item.ItemIndex == cbFromWHCat.SelectedIndex).ID.ToString();
			}
			else
			{
				lbFromWHIDCat.Text = "";
			}
		}
		void CbToWHCatSelectedIndexChanged(object sender, EventArgs e)
		{
			if (aToWHCat.Count > 0)
			{
				lbToWHIDCat.Text = aToWHCat.Find(item => item.ItemIndex == cbToWHCat.SelectedIndex).ID.ToString();
			}
			else
			{
				lbToWHIDCat.Text = "";
			}
		}
		void CbFromWHToDepSelectedIndexChanged(object sender, EventArgs e)
		{
			lbFromWHToIDDep.Text = aFromWHToList.Find(item => item.DepName == cbFromWHToDep.SelectedItem.ToString()).ID.ToString();
		}
		void BtnFromWHChoiceProdClick(object sender, EventArgs e)
		{
			//if (aFromWHProdTypesList.Count > 0) //we can use one array for prodList
			if (aToWHProdTypesList.Count > 0)
			{
				//dgvFromWHChoicedProds.Rows.Clear();
				if (dgvFromWHChoicedProds.ColumnCount <= 10)
				{
					//dgvFromWHChoicedProds.Columns.Clear();
					int nCol = dgvFromWHChoicedProds.ColumnCount;
					while (dgvFromWHChoicedProds.ColumnCount < 10)
					{
						switch (nCol)
						{
							case 0:
								dgvFromWHChoicedProds.Columns.Add("IDProdType", "ID");
								break;
							case 1:
								dgvFromWHChoicedProds.Columns.Add("ProdTypeName", "Вид ценности");
								break;
							case 2:
								dgvFromWHChoicedProds.Columns.Add("ProdCount", "Количество");
								break;
							case 3:
								dgvFromWHChoicedProds.Columns.Add("ProdPrice", "Цена");
								break;
							case 4:
								dgvFromWHChoicedProds.Columns.Add("InvNum", "Инв номер");
								break;
							case 5:
								dgvFromWHChoicedProds.Columns.Add("CatName", "Категория");
								break;
							case 6:
								dgvFromWHChoicedProds.Columns.Add("FromDepName", "Отправитель");
								break;
							case 7:
								dgvFromWHChoicedProds.Columns.Add("ToDepName", "Получатель");
								break;
							case 8:
								dgvFromWHChoicedProds.Columns.Add("ActNum", "Номер акта");
								break;
							case 9:
								dgvFromWHChoicedProds.Columns.Add("ActDate", "Дата акта");
								break;
							default:
								dgvFromWHChoicedProds.Columns.Add("Column"+nCol.ToString(), "Столбец"+nCol.ToString());
								break;
						}
						nCol++;
					}
				}
				foreach (string item in lsbFromWHProdTypes.SelectedItems)
				{
					GivingProd prod = new GivingProd();
					prod.ProdType = aToWHProdTypesList.Find(element => element.TypeName == item);
					if (double.TryParse(mtxFromWHPrice.Text, out prod.ProdPrice) == false)
					{
						MessageBox.Show("Неправильно указана цена <" + mtxFromWHPrice.Text + ">");
						prod.ProdPrice = 0;
					}
					prod.ActNum = txFromWHActNum.Text;
					prod.ActDate = dtpFromWHActDate.Value;
					prod.ToDep = aFromWHToList.Find(element => element.DepName == cbFromWHToDep.SelectedItem.ToString());
					
					//current part (department)
					//string sSQLCurrentPart = "select * from tDep d where d.id = " + sIDPartCurrent;
					string sSQLCurrentPart = "select d.*, dt.TypeName from tDep d left join tDepType dt on dt.ID = d.IDDepType where d.idParent = " + sIDPartCurrent;
					OleDbDataAdapter adapter = new OleDbDataAdapter(sSQLCurrentPart, connectionDB);
					DbDataReader datareaderObject = adapter.SelectCommand.ExecuteReader();
					if (datareaderObject.Read())
					{
						string sID = datareaderObject["ID"].ToString();
						string sName = datareaderObject["DepName"].ToString();
						Department curPart = new Department();
						curPart.ItemIndex = cbFromWHCat.Items.IndexOf(sName);
						curPart.ID = Int32.Parse(sID);
						curPart.DepName = sName;
						prod.FromDep = curPart;
						curPart = null;
					}
					if (!datareaderObject.IsClosed && datareaderObject != null)
					{
						datareaderObject.Close();
					}
					datareaderObject = null;
					adapter.Dispose();
					adapter = null;
					
					if (!int.TryParse(udFromWHProdCount.Text, out prod.ProdCount))
					{
						MessageBox.Show("Цена указана неправильно!");
						prod.ProdCount = 0;
					}
					prod.ProdCategory = aFromWHCat.Find(elem => elem.CatName == cbFromWHCat.SelectedItem.ToString());
					//prod.InvNum = txFromWHInvNum.Text;
					if (aToWHProdTypesList.Find(element => element.TypeName == item).IDUsingType == 1)
					{
						prod.InvNum = txFromWHInvNum.Text;
					}
					else
					{
						prod.InvNum = "";
					}
					aFromWHChoicedProdsList.Add(prod);
					dgvFromWHChoicedProds.Rows.Add(prod.ProdType.ID, prod.ProdType.TypeName, prod.ProdCount, prod.ProdPrice, prod.InvNum, prod.ProdCategory.CatName, prod.FromDep.DepName, prod.ToDep.DepTypeName + "(" + prod.ToDep.DepName + ")", prod.ActNum, prod.ActDate);
					prod = null;
				}
			}
		}
		void RbFromWHtoPartCheckedChanged(object sender, EventArgs e)
		{
			MakeReadyWHData("drFromWH", "cbFromWHToDep");
		}
		void BtnToWHChoiceSaveClick(object sender, EventArgs e)
		{
			/// <summary>
			/// steps:
			/// 1) insert into tAct, save newID
			/// 2) insert into tActProd vales(choiced prods)
			/// 4) insert into tDeptoDep --not need
			/// </summary>
			//insert new record
			string sSQL = "";
			string sIDAct = string.Empty;
			string sActNum = txToWHActNum.Text;
			string sActDate = dtpToWHActDate.Value.ToShortDateString();
			string sIDDepFrom = lbToWHFromIDDep.Text;
			
			sSQL = "select * from tAct a where a.ActNum = '" + sActNum + "' and a.actdate = CDate('"+sActDate+"') and a.IDDepFrom = "+sIDDepFrom;
			OleDbDataAdapter adapter = new OleDbDataAdapter(sSQL, connectionDB);
			DbDataReader datareaderObject;
			
			//try to find this act
			datareaderObject = adapter.SelectCommand.ExecuteReader();
			if (datareaderObject.Read())
			{
				sIDAct = datareaderObject["ID"].ToString();
				string sActN = datareaderObject["ActNum"].ToString();
			}
			if (!datareaderObject.IsClosed && datareaderObject != null)
			{
				datareaderObject.Close();
			}
			datareaderObject = null;
			
			//if act is new, then create new act
			if (sIDAct.Equals(string.Empty))
			{
				adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
				adapter.InsertCommand = new OleDbCommand(
					        "INSERT INTO tAct (ActNum, ActDate, IDTransferType, IDDepFrom, IDDepTo) " +
					        "VALUES ('"+sActNum+"', CDate('"+sActDate+"'), 1, "+sIDDepFrom+", "+sIDWHCurrent+")"
					       );
				adapter.InsertCommand.Connection = connectionDB;
				//TODO: this line is error, I must fix it
				//sIDAct = (string)adapter.InsertCommand.ExecuteScalar();
				adapter.InsertCommand.ExecuteScalar();
				
				datareaderObject = adapter.SelectCommand.ExecuteReader();
				if (datareaderObject.Read())
				{
					sIDAct = datareaderObject["ID"].ToString();
					string sActN = datareaderObject["ActNum"].ToString();
				}
				if (!datareaderObject.IsClosed && datareaderObject != null)
				{
					datareaderObject.Close();
				}
				datareaderObject = null;
			}
			adapter.Dispose();
			adapter = null;
			
			//add products for this act
			sSQL = "select * from tActProd ap where ap.idact = " + sIDAct;
			adapter = new OleDbDataAdapter(sSQL, connectionDB);
			adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
			foreach (GivingProd pr in aToWHChoicedProdsList)
			{
				adapter.InsertCommand = new OleDbCommand(
					        "INSERT INTO tActProd (IDAct, IDProdType, ProdPrice, ProdCount, InvNum, IDProdCat) " +
					        "VALUES ("+sIDAct+", "+pr.ProdType.ID.ToString()+", "+pr.ProdPrice.ToString()+", "+pr.ProdCount+", "+((pr.InvNum.Equals(string.Empty)) ? "null" : pr.InvNum)+", "+pr.ProdCategory.ID+")"
					       );
				adapter.InsertCommand.Connection = connectionDB;
				adapter.InsertCommand.ExecuteScalar();
				adapter.InsertCommand.Dispose();
				adapter.InsertCommand = null;
			}
			adapter.Dispose();
			adapter = null;
			
			//MessageBox.Show("Сохранил");
		}
		void BtnFromWHChoiceSaveClick(object sender, EventArgs e)
		{
			MessageBox.Show("Функционал сохранения пока не готов");
		}
		void LsbFromWHProdTypesSelectedIndexChanged(object sender, EventArgs e)
		{
			//if (aFromWHProdTypesList.Count > 0) //we dint need for many similar arrays
			if (aToWHProdTypesList.Count > 0)
			{
				foreach (string item in lsbFromWHProdTypes.SelectedItems)
				{
					//TODO: check the value of IDUsingType in this condition:
					//if (aFromWHProdTypesList.Find(element => element.TypeName == item).IDUsingType == 1)
					if (aToWHProdTypesList.Find(element => element.TypeName == item).IDUsingType == 1)
					{
						lbFromWHInvNum.Visible = true;
						txFromWHInvNum.Visible = true;
						break;
					}
					else
					{
						lbFromWHInvNum.Visible = false;
						txFromWHInvNum.Visible = false;
					}
				}
			}
		}
		void TxFromWHFindProdKeyUp(object sender, KeyEventArgs e)
		{
			string sFind = txFromWHFindProd.Text;
			if (aFromWHProdTypesList.Count > 0)
			{
				lsbFromWHProdTypes.Items.Clear();
				foreach (ProductType pt in aFromWHProdTypesList)
				{
					if (pt.TypeName.ToUpper().Contains(sFind.ToUpper()))
					{
						lsbFromWHProdTypes.Items.Add(pt.TypeName);
					}
				}
			}
		}
		void BtnToWHChoiceDelClick(object sender, EventArgs e)
		{
			foreach (DataGridViewRow rw in dgvToWHChoicedProds.SelectedRows)
			{
				if (rw.Selected)
				{
					foreach (GivingProd pr in aToWHChoicedProdsList)
					{
						string sActN = Convert.ToString(rw.Cells["ActNum"].Value);
						string sActD = Convert.ToDateTime(rw.Cells["ActDate"].Value).ToShortDateString();
						string sPTName = Convert.ToString(rw.Cells["ProdTypeName"].Value);
						int nPCnt = Convert.ToInt16(rw.Cells["ProdCount"].Value);
						string sInvN = Convert.ToString(rw.Cells["InvNum"].Value);
						
						string sPrActN = pr.ActNum;
						string sPrActD = pr.ActDate.ToShortDateString();
						string sPrPTName = pr.ProdType.TypeName;
						int nPrPCnt = pr.ProdCount;
						string sPrInvN = "";
						if (pr.InvNum == null)
						{
							sPrInvN = "";
						}
						else
						{
							sPrInvN = pr.InvNum;
						}
						if ((sActN == sPrActN) &&
						    (sActD == sPrActD) &&
						    (sPTName == sPrPTName) &&
						    (nPCnt == nPrPCnt) &&
						    (sInvN == sPrInvN)
						   )
						{
							aToWHChoicedProdsList.Remove(pr);
							dgvToWHChoicedProds.Rows.Remove(rw);
							break;
						}
					}
				}
			}
		}
		void BtnFromWHChoiceDelClick(object sender, EventArgs e)
		{
			foreach (DataGridViewRow rw in dgvFromWHChoicedProds.SelectedRows)
			{
				if (rw.Selected)
				{
					foreach (GivingProd pr in aToWHChoicedProdsList) //do we realy can use one array?
					{
						string sActN = Convert.ToString(rw.Cells["ActNum"].Value);
						string sActD = Convert.ToDateTime(rw.Cells["ActDate"].Value).ToShortDateString();
						string sPTName = Convert.ToString(rw.Cells["ProdTypeName"].Value);
						int nPCnt = Convert.ToInt16(rw.Cells["ProdCount"].Value);
						string sInvN = Convert.ToString(rw.Cells["InvNum"].Value);
						
						string sPrActN = pr.ActNum;
						string sPrActD = pr.ActDate.ToShortDateString();
						string sPrPTName = pr.ProdType.TypeName;
						int nPrPCnt = pr.ProdCount;
						string sPrInvN = "";
						if (pr.InvNum == null)
						{
							sPrInvN = "";
						}
						else
						{
							sPrInvN = pr.InvNum;
						}
						if ((sActN == sPrActN) &&
						    (sActD == sPrActD) &&
						    (sPTName == sPrPTName) &&
						    (nPCnt == nPrPCnt) &&
						    (sInvN == sPrInvN)
						   )
						{
							aToWHChoicedProdsList.Remove(pr);
							dgvFromWHChoicedProds.Rows.Remove(rw);
							break;
						}
					}
				}
			}
		}
		void TcEditSelectedIndexChanged(object sender, EventArgs e)
		{
			if ((tcEdit.SelectedTab != tpDepType) && (tcEdit.SelectedTab != tpUsingType) && (tcEdit.SelectedTab != tpCategory))
			{
				tpDepType.Hide();
				tpUsingType.Hide();
				tpCategory.Hide();
			}
		}
		void UdToWHProdCountKeyPress(object sender, KeyPressEventArgs e)
		{
			
		}
		void TcWHSelectedIndexChanged(object sender, EventArgs e)
		{
			/*if (tcWH.SelectedTab.Equals(tpToWH))
			{
				ShowDataOfWH("drToWH");
			}
			if (tcWH.SelectedTab.Equals(tpFromWH))
			{
				ShowDataOfWH("drFromWH");
			}*/
		}
		void ShowDataOfWH(string selectedTabName)
		{
			string sSQL;
			if (tcWH.SelectedTab.Equals(tpToWH) && (selectedTabName == "drToWH"))
			{
				if (dgvToWHChoicedProds.ColumnCount <= 10)
				{
					int nCol = dgvToWHChoicedProds.ColumnCount;
					while (dgvToWHChoicedProds.ColumnCount < 10)
					{
						switch (nCol)
						{
							case 0:
								dgvToWHChoicedProds.Columns.Add("IDProdType", "ID");
								break;
							case 1:
								dgvToWHChoicedProds.Columns.Add("ProdTypeName", "Вид ценности");
								break;
							case 2:
								dgvToWHChoicedProds.Columns.Add("ProdCount", "Количество");
								break;
							case 3:
								dgvToWHChoicedProds.Columns.Add("ProdPrice", "Цена");
								break;
							case 4:
								dgvToWHChoicedProds.Columns.Add("InvNum", "Инв номер");
								break;
							case 5:
								dgvToWHChoicedProds.Columns.Add("CatName", "Категория");
								break;
							case 6:
								dgvToWHChoicedProds.Columns.Add("FromDepName", "Отправитель");
								break;
							case 7:
								dgvToWHChoicedProds.Columns.Add("ToDepName", "Получатель");
								break;
							case 8:
								dgvToWHChoicedProds.Columns.Add("ActNum", "Номер акта");
								break;
							case 9:
								dgvToWHChoicedProds.Columns.Add("ActDate", "Дата акта");
								break;
							default:
								dgvToWHChoicedProds.Columns.Add("Column"+nCol.ToString(), "Столбец"+nCol.ToString());
								break;
						}
						nCol++;
					}
				}
				
				string sFindProd = "";
				if (rbToWHFindProd.Checked)
				{
					if (txToWHFindProds.Text != "")
					{
						const string sKav = "\"";
						sFindProd = " AND ((tProdType.TypeName) like "+sKav+"%"+txToWHFindProds.Text+"%"+sKav+") ";
					}
				}
				else if (rbToWHFindPrice.Checked)
				{
					if ((!mtxToWHPriceFrom.Text.Length.Equals(0)) && (mtxToWHPriceTo.Text.Length.Equals(0)))
					{
						sFindProd = " AND ((tActProd.ProdPrice) >= "+mtxToWHPriceFrom.Text+") ";
					}
					else if ((mtxToWHPriceFrom.Text.Length.Equals(0)) && (!mtxToWHPriceTo.Text.Length.Equals(0)))
					{
						sFindProd = " AND ((tActProd.ProdPrice) <= "+mtxToWHPriceTo.Text+") ";
					}
					else if ((!mtxToWHPriceFrom.Text.Length.Equals(0)) && (!mtxToWHPriceTo.Text.Length.Equals(0)))
					{
						sFindProd = " AND ((tActProd.ProdPrice) >= "+mtxToWHPriceFrom.Text+") " + " AND ((tActProd.ProdPrice) <= "+mtxToWHPriceTo.Text+") ";
					}
				}
				 
				sSQL = @"SELECT tActProd.ID AS IDProdType,
						       tProdType.TypeName AS ProdTypeName,
						       tActProd.ProdCount,
						       tActProd.ProdPrice,
						       tActProd.InvNum,
						       tCat.CatName,
						       tDep.DepName AS FromDepName,
						       tDep_1.DepName AS ToDepName,
						       tDepType.TypeName AS ToDepType,
						       tAct.ActNum,
						       tAct.ActDate
						FROM tProdType
						INNER JOIN (tDepType
						            INNER JOIN (tCat
						                        INNER JOIN (((tAct
						                                      INNER JOIN tDep ON tAct.IDDepFrom = tDep.ID)
						                                     INNER JOIN tDep AS tDep_1 ON tAct.IDDepTo = tDep_1.ID)
						                                    INNER JOIN tActProd ON tAct.ID = tActProd.IDAct) ON tCat.ID = tActProd.IDProdCat) ON (tDepType.ID = tDep.IDDepType)
						            AND (tDepType.ID = tDep.IDDepType)) ON tProdType.ID = tActProd.IDProdType
						WHERE ( ((tDepType.ID)=2) "+sFindProd+@");
						";
				OleDbDataAdapter adapter = new OleDbDataAdapter(sSQL, connectionDB);
				DbDataReader datareaderObject;
				
				dgvToWHChoicedProds.Rows.Clear();
				
				datareaderObject = adapter.SelectCommand.ExecuteReader();
				while (datareaderObject.Read())
				{
					string sIDProdType = datareaderObject["IDProdType"].ToString();
					string sProdTypeName = datareaderObject["ProdTypeName"].ToString();
					string sProdCount = datareaderObject["ProdCount"].ToString();
					string sProdPrice = datareaderObject["ProdPrice"].ToString();
					string sInvNum = datareaderObject["InvNum"].ToString();
					string sCatName = datareaderObject["CatName"].ToString();
					string sFromDepName = datareaderObject["FromDepName"].ToString();
					string sToDepType = datareaderObject["ToDepType"].ToString();
					string sToDepName = datareaderObject["ToDepName"].ToString();
					string sActNum = datareaderObject["ActNum"].ToString();
					string sActDate = datareaderObject["ActDate"].ToString();
					dgvToWHChoicedProds.Rows.Add(sIDProdType, sProdTypeName, sProdCount, sProdPrice, sInvNum,
					                             sCatName, sFromDepName,
					                             sToDepName, /*sToDepType + "(" + sToDepName + ")",*/
					                             sActNum, sActDate);
				}
				if (!datareaderObject.IsClosed && datareaderObject != null)
				{
					datareaderObject.Close();
				}
				datareaderObject = null;
				adapter.Dispose();
				adapter = null;
			}
			
			if (tcWH.SelectedTab.Equals(tpFromWH) && (selectedTabName == "drFromWH"))
			{
				if (dgvFromWHChoicedProds.ColumnCount <= 10)
				{
					int nCol = dgvFromWHChoicedProds.ColumnCount;
					while (dgvFromWHChoicedProds.ColumnCount < 10)
					{
						switch (nCol)
						{
							case 0:
								dgvFromWHChoicedProds.Columns.Add("IDProdType", "ID");
								break;
							case 1:
								dgvFromWHChoicedProds.Columns.Add("ProdTypeName", "Вид ценности");
								break;
							case 2:
								dgvFromWHChoicedProds.Columns.Add("ProdCount", "Количество");
								break;
							case 3:
								dgvFromWHChoicedProds.Columns.Add("ProdPrice", "Цена");
								break;
							case 4:
								dgvFromWHChoicedProds.Columns.Add("InvNum", "Инв номер");
								break;
							case 5:
								dgvFromWHChoicedProds.Columns.Add("CatName", "Категория");
								break;
							case 6:
								dgvFromWHChoicedProds.Columns.Add("FromDepName", "Отправитель");
								break;
							case 7:
								dgvFromWHChoicedProds.Columns.Add("ToDepName", "Получатель");
								break;
							case 8:
								dgvFromWHChoicedProds.Columns.Add("ActNum", "Номер акта");
								break;
							case 9:
								dgvFromWHChoicedProds.Columns.Add("ActDate", "Дата акта");
								break;
							default:
								dgvFromWHChoicedProds.Columns.Add("Column"+nCol.ToString(), "Столбец"+nCol.ToString());
								break;
						}
						nCol++;
					}
				}
				
				string sFindProd = "";
				if (rbFromWHFindProd.Checked)
				{
					if (txFromWHFindProds.Text != "")
					{
						const string sKav = "\"";
						sFindProd = " AND ((tProdType.TypeName) like "+sKav+"%"+txFromWHFindProds.Text+"%"+sKav+") ";
					}
				}
				else if (rbFromWHFindPrice.Checked)
				{
					if ((!mtxFromWHPriceFrom.Text.Length.Equals(0)) && (mtxFromWHPriceTo.Text.Length.Equals(0)))
					{
						sFindProd = " AND ((tActProd.ProdPrice) >= "+mtxFromWHPriceFrom.Text+") ";
					}
					else if ((mtxFromWHPriceFrom.Text.Length.Equals(0)) && (!mtxFromWHPriceTo.Text.Length.Equals(0)))
					{
						sFindProd = " AND ((tActProd.ProdPrice) <= "+mtxFromWHPriceTo.Text+") ";
					}
					else if ((!mtxFromWHPriceFrom.Text.Length.Equals(0)) && (!mtxFromWHPriceTo.Text.Length.Equals(0)))
					{
						sFindProd = " AND ((tActProd.ProdPrice) >= "+mtxFromWHPriceFrom.Text+") " + " AND ((tActProd.ProdPrice) <= "+mtxFromWHPriceTo.Text+") ";
					}
				}
				
				sSQL = @"SELECT tActProd.ID AS IDProdType,
						       tProdType.TypeName AS ProdTypeName,
						       tActProd.ProdCount,
						       tActProd.ProdPrice,
						       tActProd.InvNum,
						       tCat.CatName,
						       tDep.DepName AS FromDepName,
						       tDep_1.DepName AS ToDepName,
						       tDepType.TypeName AS ToDepType,
						       tAct.ActNum,
						       tAct.ActDate
						FROM tProdType
						INNER JOIN (tDepType
						            INNER JOIN (tCat
						                        INNER JOIN (((tAct
						                                      INNER JOIN tDep ON tAct.IDDepFrom = tDep.ID)
						                                     INNER JOIN tDep AS tDep_1 ON tAct.IDDepTo = tDep_1.ID)
						                                    INNER JOIN tActProd ON tAct.ID = tActProd.IDAct) ON tCat.ID = tActProd.IDProdCat) ON (tDepType.ID = tDep_1.IDDepType)
						            AND (tDepType.ID = tDep_1.IDDepType)) ON tProdType.ID = tActProd.IDProdType
						WHERE (((tDepType.ID)=2) "+sFindProd+@");
						";
				OleDbDataAdapter adapter = new OleDbDataAdapter(sSQL, connectionDB);
				DbDataReader datareaderObject;
				
				datareaderObject = adapter.SelectCommand.ExecuteReader();
				while (datareaderObject.Read())
				{
					string sIDProdType = datareaderObject["IDProdType"].ToString();
					string sProdTypeName = datareaderObject["ProdTypeName"].ToString();
					string sProdCount = datareaderObject["ProdCount"].ToString();
					string sProdPrice = datareaderObject["ProdPrice"].ToString();
					string sInvNum = datareaderObject["InvNum"].ToString();
					string sCatName = datareaderObject["CatName"].ToString();
					string sFromDepName = datareaderObject["FromDepName"].ToString();
					string sToDepType = datareaderObject["ToDepType"].ToString();
					string sToDepName = datareaderObject["ToDepName"].ToString();
					string sActNum = datareaderObject["ActNum"].ToString();
					string sActDate = datareaderObject["ActDate"].ToString();
					dgvFromWHChoicedProds.Rows.Add(sIDProdType, sProdTypeName, sProdCount, sProdPrice, sInvNum,
					                             sCatName, sFromDepName, sToDepType + "(" + sToDepName + ")", 
					                             sActNum, sActDate);
				}
				if (!datareaderObject.IsClosed && datareaderObject != null)
				{
					datareaderObject.Close();
				}
				datareaderObject = null;
				adapter.Dispose();
				adapter = null;
			}
		}
		void TxFindProdInToWHKeyUp(object sender, KeyEventArgs e)
		{
			ShowDataOfWH("drToWH");
		}
		void MtxToWHPriceFromKeyUp(object sender, KeyEventArgs e)
		{
			ShowDataOfWH("drToWH");
		}
		void MtxToWHPriceToKeyUp(object sender, KeyEventArgs e)
		{
			ShowDataOfWH("drToWH");
		}
		void TxFromWHFindProdsKeyUp(object sender, KeyEventArgs e)
		{
			ShowDataOfWH("drFromWH");
		}
		void RbToWHFindPriceCheckedChanged(object sender, EventArgs e)
		{
			ShowDataOfWH("drToWH");
		}
		void RbToWHFindProdCheckedChanged(object sender, EventArgs e)
		{
			ShowDataOfWH("drToWH");
		}
		void RbFromWHFindPriceCheckedChanged(object sender, EventArgs e)
		{
			ShowDataOfWH("drFromWH");
		}
		void RbFromWHFindProdCheckedChanged(object sender, EventArgs e)
		{
			ShowDataOfWH("drFromWH");
		}
		void BtnEditPersonRankEditClick(object sender, EventArgs e)
		{
			if (tcEdit.TabPages.Contains(tpRank))
			{
				tpRank.Show();
				tcEdit.SelectedTab = tpRank;
			}
		}
		void BtnEditDepDeptypeEditClick(object sender, EventArgs e)
		{
			if (tcEdit.TabPages.Contains(tpDepType))
			{
				tpDepType.Show();
				tcEdit.SelectedTab = tpDepType;
			}
		}
		
	}
}
