/*
 * Created by SharpDevelop.
 * User: KuanyshMadina
 * Date: 21.04.2018
 * Time: 10:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ArmyRep
{
	partial class frmMain
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Panel pnMenu;
		private System.Windows.Forms.Button btnReport;
		private System.Windows.Forms.Button btnUse;
		private System.Windows.Forms.Button btnDep;
		private System.Windows.Forms.Button btnWH;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.TabControl tcEdit;
		private System.Windows.Forms.TabPage tpDep;
		private System.Windows.Forms.Label lbEditDepName;
		private System.Windows.Forms.TabPage tpRank;
		private System.Windows.Forms.TabPage tpCategory;
		private System.Windows.Forms.TabPage tpPerson;
		private System.Windows.Forms.TabPage tpDepType;
		private System.Windows.Forms.TabPage tpProductType;
		private System.Windows.Forms.TabPage tpUsingType;
		private System.Windows.Forms.TabControl tcUse;
		private System.Windows.Forms.TabPage tpUseToUse;
		private System.Windows.Forms.TabPage tpUseToWH;
		private System.Windows.Forms.TabControl tcDep;
		private System.Windows.Forms.TabPage tpUseToDep;
		private System.Windows.Forms.TabPage tpDepFromDep;
		private System.Windows.Forms.TextBox txEditDepName;
		private System.Windows.Forms.TabPage tpPart;
		private System.Windows.Forms.Button btnEditPartDelete;
		private System.Windows.Forms.Button btnEditPartSave;
		private System.Windows.Forms.ListBox lsbEditPartList;
		private System.Windows.Forms.TextBox txEditPartName;
		private System.Windows.Forms.Label lbEditPartName;
		private System.Windows.Forms.ListBox lsbEditDepList;
		private System.Windows.Forms.Label lbEditIDDep;
		private System.Windows.Forms.Button btnEditDepNew;
		private System.Windows.Forms.Button btnEditDepDelete;
		private System.Windows.Forms.Button btnEditDepSave;
		private System.Windows.Forms.Label lbEditRankName;
		private System.Windows.Forms.Button btnEditRankNew;
		private System.Windows.Forms.Button btnEditRankDelete;
		private System.Windows.Forms.Button btnEditRankSave;
		private System.Windows.Forms.ListBox lsbEditRankList;
		private System.Windows.Forms.TextBox txEditRankName;
		private System.Windows.Forms.Label lbEditIDRank;
		private System.Windows.Forms.Label lbEditIDCat;
		private System.Windows.Forms.Button btnEditCatNew;
		private System.Windows.Forms.Button btnEditCatDelete;
		private System.Windows.Forms.Button btnEditCatSave;
		private System.Windows.Forms.ListBox lsbEditCatList;
		private System.Windows.Forms.TextBox txEditCatName;
		private System.Windows.Forms.Label lbEditCatName;
		private System.Windows.Forms.ListBox lsbEditDeptypeList;
		private System.Windows.Forms.Button btnEditDeptypeNew;
		private System.Windows.Forms.Button btnEditDeptypeDel;
		private System.Windows.Forms.Button btnEditDeptypeSave;
		private System.Windows.Forms.Label lbEditIDDeptype;
		private System.Windows.Forms.TextBox txEditDeptypeName;
		private System.Windows.Forms.Label lbEditDeptypeName;
		private System.Windows.Forms.Label lbEditIDPart;
		private System.Windows.Forms.Button btnEditPartNew;
		private System.Windows.Forms.TextBox txEditPersonPatronymic;
		private System.Windows.Forms.Label lbEditPersonPatronymic;
		private System.Windows.Forms.TextBox txEditPersonFirstname;
		private System.Windows.Forms.Label lbEditPersonFirstname;
		private System.Windows.Forms.TextBox txEditPersonLastname;
		private System.Windows.Forms.Label lbEditPersonLastname;
		private System.Windows.Forms.DateTimePicker dtpEditPersonBirthdate;
		private System.Windows.Forms.Label lbEditPersonBirthdate;
		private System.Windows.Forms.CheckBox chbEditPersonDeath;
		private System.Windows.Forms.DateTimePicker dtpEditPersonDeathdate;
		private System.Windows.Forms.Label lbEditPersonDeathdate;
		private System.Windows.Forms.Button btnEditPersonNew;
		private System.Windows.Forms.Button btnEditPersonDelete;
		private System.Windows.Forms.Button btnEditPersonSave;
		private System.Windows.Forms.ListBox lsbEditPersonList;
		private System.Windows.Forms.ListBox lsbEditProdtypeList;
		private System.Windows.Forms.Button btnEditProdtypeNew;
		private System.Windows.Forms.Button btnEditProdtypeDel;
		private System.Windows.Forms.Button btnEditProdtypeSave;
		private System.Windows.Forms.Label lbEditIDProdtype;
		private System.Windows.Forms.TextBox txEditProdtypeName;
		private System.Windows.Forms.Label lbEditProdtypeName;
		private System.Windows.Forms.Button btnEditUsingtypesEdit;
		private System.Windows.Forms.Label lbEditPTIDUsingtype;
		private System.Windows.Forms.ComboBox cbEditPTUsingtypeName;
		private System.Windows.Forms.Label lbEditPTUsingtypeName;
		private System.Windows.Forms.Button btnWriteoff;
		private System.Windows.Forms.TabControl tcWH;
		private System.Windows.Forms.TabPage tpToWH;
		private System.Windows.Forms.TabPage tpFromWH;
		private System.Windows.Forms.ListBox lsbEditUsingtypeList;
		private System.Windows.Forms.Button btnEditUsingtypeNew;
		private System.Windows.Forms.Button btnEditUsingtypeDel;
		private System.Windows.Forms.Button btnEditUsingtypeSave;
		private System.Windows.Forms.TextBox txEditUsingtypeName;
		private System.Windows.Forms.Label lbEditIDUsingtype;
		private System.Windows.Forms.Label lbEditUsingtypeName;
		private System.Windows.Forms.Label lbEditIDPerson;
		private System.Windows.Forms.GroupBox gbEditPersonRank;
		private System.Windows.Forms.DateTimePicker dtpEditPersonRankDatefrom;
		private System.Windows.Forms.Label lbEditPersonRankDatefrom;
		private System.Windows.Forms.Label lbEditPersonRankName;
		private System.Windows.Forms.Button btnEditPersonFind;
		private System.Windows.Forms.ComboBox cbEditPersonRankName;
		private System.Windows.Forms.Label lbEditPIDRank;
		private System.Windows.Forms.RadioButton rbEditPersonGenderF;
		private System.Windows.Forms.RadioButton rbEditPersonGenderM;
		private System.Windows.Forms.RadioButton rbToWHFromDep;
		private System.Windows.Forms.RadioButton rbToWHFromPart;
		private System.Windows.Forms.TabPage tpWHWriteoff;
		private System.Windows.Forms.ComboBox cbToWHFromName;
		private System.Windows.Forms.Label lbToWHFromName;
		private System.Windows.Forms.Button btnToWHChoiceProd;
		private System.Windows.Forms.TextBox txToWHInvNum;
		private System.Windows.Forms.Label lbToWHInvNum;
		private System.Windows.Forms.Label lbToWHProdCount;
		private System.Windows.Forms.Label lbToWHProdtypes;
		private System.Windows.Forms.TextBox txToWHFindProd;
		private System.Windows.Forms.ListBox lsbToWHProdtypes;
		private System.Windows.Forms.ComboBox cbToWHCat;
		private System.Windows.Forms.Label lbToWHCat;
		private System.Windows.Forms.Label lbToWHPrice;
		private System.Windows.Forms.Label lbToWHFromIDDep;
		private System.Windows.Forms.Label lbToWHIDCat;
		private System.Windows.Forms.Button btnFromWHChoiceProd;
		private System.Windows.Forms.Label lbFromWHPrice;
		private System.Windows.Forms.TextBox txFromWHInvNum;
		private System.Windows.Forms.Label lbFromWHInvNum;
		private System.Windows.Forms.Label lbFromWHProdTypes;
		private System.Windows.Forms.TextBox txFromWHFindProd;
		private System.Windows.Forms.ListBox lsbFromWHProdTypes;
		private System.Windows.Forms.Label lbFromWHProdCount;
		private System.Windows.Forms.Label lbFromWHToIDDep;
		private System.Windows.Forms.Label lbFromWHToDep;
		private System.Windows.Forms.RadioButton rbFromWHtoDep;
		private System.Windows.Forms.RadioButton rbFromWHtoPart;
		private System.Windows.Forms.Label lbFromWHIDCat;
		private System.Windows.Forms.ComboBox cbFromWHCat;
		private System.Windows.Forms.Label lbFromWHCat;
		private System.Windows.Forms.Button btnToWHChoiceSave;
		private System.Windows.Forms.DateTimePicker dtpToWHActDate;
		private System.Windows.Forms.Label lbToWHActDate;
		private System.Windows.Forms.Label lbToWHActNum;
		private System.Windows.Forms.TextBox txToWHActNum;
		private System.Windows.Forms.Button btnFromWHChoiceSave;
		private System.Windows.Forms.DateTimePicker dtpFromWHActDate;
		private System.Windows.Forms.TextBox txFromWHActNum;
		private System.Windows.Forms.Label lbFromWHActDate;
		private System.Windows.Forms.Label lbFromWHActNum;
		private System.Windows.Forms.DataGridView dgvEditPersonList;
		private System.Windows.Forms.DataGridViewButtonColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
		private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
		private System.Windows.Forms.DataGridViewTextBoxColumn patronymic;
		private System.Windows.Forms.DataGridViewTextBoxColumn birthdate;
		private System.Windows.Forms.DataGridViewComboBoxColumn gender;
		private System.Windows.Forms.DataGridViewTextBoxColumn deathdate;
		private System.Windows.Forms.DataGridViewTextBoxColumn rankname;
		private System.Windows.Forms.DataGridViewTextBoxColumn rankdate;
		private System.Windows.Forms.TabPage tpDepToDep;
		private System.Windows.Forms.ComboBox cbUseToDepCat;
		private System.Windows.Forms.Label lbUseToDepCat;
		private System.Windows.Forms.ComboBox cbDepToDep_Cat;
		private System.Windows.Forms.Label lbDepToDep_Cat;
		private System.Windows.Forms.RadioButton rbDepToDep_FromDep;
		private System.Windows.Forms.RadioButton rbDepToDep_FromPart;
		private System.Windows.Forms.ComboBox cbDepToDep_FromName;
		private System.Windows.Forms.Label lbDepToDep_FromName;
		private System.Windows.Forms.ListBox lsbDepToDepProdTypes;
		private System.Windows.Forms.Label lbDepToDepProdTypes;
		private System.Windows.Forms.TextBox txDepToDepFind;
		private System.Windows.Forms.Label lbDepToDepFind;
		private System.Windows.Forms.Button btnDepToDepChoice;
		private System.Windows.Forms.TextBox txDepToDepPrice;
		private System.Windows.Forms.Label lbDepToDepPrice;
		private System.Windows.Forms.TextBox txDepToDepInvNum;
		private System.Windows.Forms.Label lbDepToDepInvNum;
		private System.Windows.Forms.TextBox txDepToDepProdCount;
		private System.Windows.Forms.Label lbDepToDepProdCount;
		private System.Windows.Forms.DataGridView dgvDepToDepChoicedProds;
		private System.Windows.Forms.Button btnDepToDepSave;
		private System.Windows.Forms.ComboBox cbFromWHToDep;
		private System.Windows.Forms.DataGridView dgvToWHChoicedProds;
		private System.Windows.Forms.MaskedTextBox mtxToWHPrice;
		private System.Windows.Forms.DomainUpDown udToWHProdCount;
		private System.Windows.Forms.DataGridView dgvFromWHChoicedProds;
		private System.Windows.Forms.MaskedTextBox mtxFromWHPrice;
		private System.Windows.Forms.DomainUpDown udFromWHProdCount;
		private System.Windows.Forms.SplitContainer scToWH;
		private System.Windows.Forms.SplitContainer scToWHChoicedList;
		private System.Windows.Forms.Button BtnToWHChoiceDel;
		private System.Windows.Forms.SplitContainer scFromWH;
		private System.Windows.Forms.SplitContainer scFromWHChoicedList;
		private System.Windows.Forms.Button btnFromWHChoiceDel;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox cbEditDepDeptype;
		private System.Windows.Forms.Label lbEditDepDeptype;
		private System.Windows.Forms.Label lbEditDepDeptypeID;
		private System.Windows.Forms.RadioButton rbToWHFindPrice;
		private System.Windows.Forms.RadioButton rbToWHFindProd;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label lbToWHFindInDB;
		private System.Windows.Forms.RadioButton rbFromWHFindPrice;
		private System.Windows.Forms.RadioButton rbFromWHFindProd;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label lbFromWHFindInDB;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MaskedTextBox maskedTextBox2;
		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MaskedTextBox maskedTextBox3;
		private System.Windows.Forms.MaskedTextBox maskedTextBox4;
		
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.pnMenu = new System.Windows.Forms.Panel();
			this.btnWriteoff = new System.Windows.Forms.Button();
			this.btnReport = new System.Windows.Forms.Button();
			this.btnUse = new System.Windows.Forms.Button();
			this.btnDep = new System.Windows.Forms.Button();
			this.btnWH = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.tcEdit = new System.Windows.Forms.TabControl();
			this.tpPerson = new System.Windows.Forms.TabPage();
			this.dgvEditPersonList = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewButtonColumn();
			this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gender = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.deathdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rankname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rankdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.rbEditPersonGenderF = new System.Windows.Forms.RadioButton();
			this.rbEditPersonGenderM = new System.Windows.Forms.RadioButton();
			this.gbEditPersonRank = new System.Windows.Forms.GroupBox();
			this.lbEditPIDRank = new System.Windows.Forms.Label();
			this.cbEditPersonRankName = new System.Windows.Forms.ComboBox();
			this.dtpEditPersonRankDatefrom = new System.Windows.Forms.DateTimePicker();
			this.lbEditPersonRankDatefrom = new System.Windows.Forms.Label();
			this.lbEditPersonRankName = new System.Windows.Forms.Label();
			this.btnEditPersonFind = new System.Windows.Forms.Button();
			this.lbEditIDPerson = new System.Windows.Forms.Label();
			this.lsbEditPersonList = new System.Windows.Forms.ListBox();
			this.btnEditPersonNew = new System.Windows.Forms.Button();
			this.btnEditPersonDelete = new System.Windows.Forms.Button();
			this.btnEditPersonSave = new System.Windows.Forms.Button();
			this.chbEditPersonDeath = new System.Windows.Forms.CheckBox();
			this.dtpEditPersonDeathdate = new System.Windows.Forms.DateTimePicker();
			this.lbEditPersonDeathdate = new System.Windows.Forms.Label();
			this.dtpEditPersonBirthdate = new System.Windows.Forms.DateTimePicker();
			this.lbEditPersonBirthdate = new System.Windows.Forms.Label();
			this.txEditPersonPatronymic = new System.Windows.Forms.TextBox();
			this.lbEditPersonPatronymic = new System.Windows.Forms.Label();
			this.txEditPersonFirstname = new System.Windows.Forms.TextBox();
			this.lbEditPersonFirstname = new System.Windows.Forms.Label();
			this.txEditPersonLastname = new System.Windows.Forms.TextBox();
			this.lbEditPersonLastname = new System.Windows.Forms.Label();
			this.tpDep = new System.Windows.Forms.TabPage();
			this.lbEditDepDeptypeID = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.cbEditDepDeptype = new System.Windows.Forms.ComboBox();
			this.lbEditDepDeptype = new System.Windows.Forms.Label();
			this.btnEditDepNew = new System.Windows.Forms.Button();
			this.btnEditDepDelete = new System.Windows.Forms.Button();
			this.btnEditDepSave = new System.Windows.Forms.Button();
			this.lbEditIDDep = new System.Windows.Forms.Label();
			this.lsbEditDepList = new System.Windows.Forms.ListBox();
			this.txEditDepName = new System.Windows.Forms.TextBox();
			this.lbEditDepName = new System.Windows.Forms.Label();
			this.tpCategory = new System.Windows.Forms.TabPage();
			this.lbEditIDCat = new System.Windows.Forms.Label();
			this.btnEditCatNew = new System.Windows.Forms.Button();
			this.btnEditCatDelete = new System.Windows.Forms.Button();
			this.btnEditCatSave = new System.Windows.Forms.Button();
			this.lsbEditCatList = new System.Windows.Forms.ListBox();
			this.txEditCatName = new System.Windows.Forms.TextBox();
			this.lbEditCatName = new System.Windows.Forms.Label();
			this.tpProductType = new System.Windows.Forms.TabPage();
			this.btnEditUsingtypesEdit = new System.Windows.Forms.Button();
			this.lbEditPTIDUsingtype = new System.Windows.Forms.Label();
			this.cbEditPTUsingtypeName = new System.Windows.Forms.ComboBox();
			this.lbEditPTUsingtypeName = new System.Windows.Forms.Label();
			this.lsbEditProdtypeList = new System.Windows.Forms.ListBox();
			this.btnEditProdtypeNew = new System.Windows.Forms.Button();
			this.btnEditProdtypeDel = new System.Windows.Forms.Button();
			this.btnEditProdtypeSave = new System.Windows.Forms.Button();
			this.lbEditIDProdtype = new System.Windows.Forms.Label();
			this.txEditProdtypeName = new System.Windows.Forms.TextBox();
			this.lbEditProdtypeName = new System.Windows.Forms.Label();
			this.tpUsingType = new System.Windows.Forms.TabPage();
			this.lsbEditUsingtypeList = new System.Windows.Forms.ListBox();
			this.btnEditUsingtypeNew = new System.Windows.Forms.Button();
			this.btnEditUsingtypeDel = new System.Windows.Forms.Button();
			this.btnEditUsingtypeSave = new System.Windows.Forms.Button();
			this.txEditUsingtypeName = new System.Windows.Forms.TextBox();
			this.lbEditIDUsingtype = new System.Windows.Forms.Label();
			this.lbEditUsingtypeName = new System.Windows.Forms.Label();
			this.tpRank = new System.Windows.Forms.TabPage();
			this.lbEditIDRank = new System.Windows.Forms.Label();
			this.btnEditRankNew = new System.Windows.Forms.Button();
			this.btnEditRankDelete = new System.Windows.Forms.Button();
			this.btnEditRankSave = new System.Windows.Forms.Button();
			this.lsbEditRankList = new System.Windows.Forms.ListBox();
			this.txEditRankName = new System.Windows.Forms.TextBox();
			this.lbEditRankName = new System.Windows.Forms.Label();
			this.tpDepType = new System.Windows.Forms.TabPage();
			this.lsbEditDeptypeList = new System.Windows.Forms.ListBox();
			this.btnEditDeptypeNew = new System.Windows.Forms.Button();
			this.btnEditDeptypeDel = new System.Windows.Forms.Button();
			this.btnEditDeptypeSave = new System.Windows.Forms.Button();
			this.lbEditIDDeptype = new System.Windows.Forms.Label();
			this.txEditDeptypeName = new System.Windows.Forms.TextBox();
			this.lbEditDeptypeName = new System.Windows.Forms.Label();
			this.tpPart = new System.Windows.Forms.TabPage();
			this.lbEditIDPart = new System.Windows.Forms.Label();
			this.btnEditPartNew = new System.Windows.Forms.Button();
			this.btnEditPartDelete = new System.Windows.Forms.Button();
			this.btnEditPartSave = new System.Windows.Forms.Button();
			this.lsbEditPartList = new System.Windows.Forms.ListBox();
			this.txEditPartName = new System.Windows.Forms.TextBox();
			this.lbEditPartName = new System.Windows.Forms.Label();
			this.tcDep = new System.Windows.Forms.TabControl();
			this.tpDepToDep = new System.Windows.Forms.TabPage();
			this.dgvDepToDepChoicedProds = new System.Windows.Forms.DataGridView();
			this.btnDepToDepSave = new System.Windows.Forms.Button();
			this.btnDepToDepChoice = new System.Windows.Forms.Button();
			this.txDepToDepPrice = new System.Windows.Forms.TextBox();
			this.lbDepToDepPrice = new System.Windows.Forms.Label();
			this.txDepToDepInvNum = new System.Windows.Forms.TextBox();
			this.lbDepToDepInvNum = new System.Windows.Forms.Label();
			this.txDepToDepProdCount = new System.Windows.Forms.TextBox();
			this.lbDepToDepProdCount = new System.Windows.Forms.Label();
			this.lsbDepToDepProdTypes = new System.Windows.Forms.ListBox();
			this.lbDepToDepProdTypes = new System.Windows.Forms.Label();
			this.txDepToDepFind = new System.Windows.Forms.TextBox();
			this.lbDepToDepFind = new System.Windows.Forms.Label();
			this.cbDepToDep_FromName = new System.Windows.Forms.ComboBox();
			this.lbDepToDep_FromName = new System.Windows.Forms.Label();
			this.rbDepToDep_FromDep = new System.Windows.Forms.RadioButton();
			this.rbDepToDep_FromPart = new System.Windows.Forms.RadioButton();
			this.cbDepToDep_Cat = new System.Windows.Forms.ComboBox();
			this.lbDepToDep_Cat = new System.Windows.Forms.Label();
			this.tpDepFromDep = new System.Windows.Forms.TabPage();
			this.tpUseToDep = new System.Windows.Forms.TabPage();
			this.cbUseToDepCat = new System.Windows.Forms.ComboBox();
			this.lbUseToDepCat = new System.Windows.Forms.Label();
			this.tcUse = new System.Windows.Forms.TabControl();
			this.tpUseToUse = new System.Windows.Forms.TabPage();
			this.tpUseToWH = new System.Windows.Forms.TabPage();
			this.tcWH = new System.Windows.Forms.TabControl();
			this.tpToWH = new System.Windows.Forms.TabPage();
			this.scToWH = new System.Windows.Forms.SplitContainer();
			this.lbToWHCat = new System.Windows.Forms.Label();
			this.udToWHProdCount = new System.Windows.Forms.DomainUpDown();
			this.rbToWHFromPart = new System.Windows.Forms.RadioButton();
			this.mtxToWHPrice = new System.Windows.Forms.MaskedTextBox();
			this.rbToWHFromDep = new System.Windows.Forms.RadioButton();
			this.dtpToWHActDate = new System.Windows.Forms.DateTimePicker();
			this.lbToWHFromName = new System.Windows.Forms.Label();
			this.lbToWHActDate = new System.Windows.Forms.Label();
			this.lsbToWHProdtypes = new System.Windows.Forms.ListBox();
			this.lbToWHActNum = new System.Windows.Forms.Label();
			this.txToWHFindProd = new System.Windows.Forms.TextBox();
			this.txToWHActNum = new System.Windows.Forms.TextBox();
			this.lbToWHFromIDDep = new System.Windows.Forms.Label();
			this.lbToWHProdtypes = new System.Windows.Forms.Label();
			this.lbToWHIDCat = new System.Windows.Forms.Label();
			this.lbToWHProdCount = new System.Windows.Forms.Label();
			this.cbToWHCat = new System.Windows.Forms.ComboBox();
			this.lbToWHInvNum = new System.Windows.Forms.Label();
			this.cbToWHFromName = new System.Windows.Forms.ComboBox();
			this.txToWHInvNum = new System.Windows.Forms.TextBox();
			this.btnToWHChoiceProd = new System.Windows.Forms.Button();
			this.lbToWHPrice = new System.Windows.Forms.Label();
			this.scToWHChoicedList = new System.Windows.Forms.SplitContainer();
			this.label1 = new System.Windows.Forms.Label();
			this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.rbToWHFindPrice = new System.Windows.Forms.RadioButton();
			this.rbToWHFindProd = new System.Windows.Forms.RadioButton();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.lbToWHFindInDB = new System.Windows.Forms.Label();
			this.BtnToWHChoiceDel = new System.Windows.Forms.Button();
			this.btnToWHChoiceSave = new System.Windows.Forms.Button();
			this.dgvToWHChoicedProds = new System.Windows.Forms.DataGridView();
			this.tpFromWH = new System.Windows.Forms.TabPage();
			this.scFromWH = new System.Windows.Forms.SplitContainer();
			this.lbFromWHCat = new System.Windows.Forms.Label();
			this.udFromWHProdCount = new System.Windows.Forms.DomainUpDown();
			this.cbFromWHCat = new System.Windows.Forms.ComboBox();
			this.mtxFromWHPrice = new System.Windows.Forms.MaskedTextBox();
			this.lbFromWHIDCat = new System.Windows.Forms.Label();
			this.rbFromWHtoPart = new System.Windows.Forms.RadioButton();
			this.rbFromWHtoDep = new System.Windows.Forms.RadioButton();
			this.dtpFromWHActDate = new System.Windows.Forms.DateTimePicker();
			this.cbFromWHToDep = new System.Windows.Forms.ComboBox();
			this.txFromWHActNum = new System.Windows.Forms.TextBox();
			this.lbFromWHToDep = new System.Windows.Forms.Label();
			this.lbFromWHActDate = new System.Windows.Forms.Label();
			this.lbFromWHToIDDep = new System.Windows.Forms.Label();
			this.lbFromWHActNum = new System.Windows.Forms.Label();
			this.btnFromWHChoiceProd = new System.Windows.Forms.Button();
			this.lbFromWHProdCount = new System.Windows.Forms.Label();
			this.lsbFromWHProdTypes = new System.Windows.Forms.ListBox();
			this.lbFromWHPrice = new System.Windows.Forms.Label();
			this.txFromWHFindProd = new System.Windows.Forms.TextBox();
			this.txFromWHInvNum = new System.Windows.Forms.TextBox();
			this.lbFromWHProdTypes = new System.Windows.Forms.Label();
			this.lbFromWHInvNum = new System.Windows.Forms.Label();
			this.scFromWHChoicedList = new System.Windows.Forms.SplitContainer();
			this.label2 = new System.Windows.Forms.Label();
			this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
			this.maskedTextBox4 = new System.Windows.Forms.MaskedTextBox();
			this.rbFromWHFindPrice = new System.Windows.Forms.RadioButton();
			this.rbFromWHFindProd = new System.Windows.Forms.RadioButton();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.lbFromWHFindInDB = new System.Windows.Forms.Label();
			this.btnFromWHChoiceDel = new System.Windows.Forms.Button();
			this.btnFromWHChoiceSave = new System.Windows.Forms.Button();
			this.dgvFromWHChoicedProds = new System.Windows.Forms.DataGridView();
			this.tpWHWriteoff = new System.Windows.Forms.TabPage();
			this.pnMenu.SuspendLayout();
			this.tcEdit.SuspendLayout();
			this.tpPerson.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvEditPersonList)).BeginInit();
			this.gbEditPersonRank.SuspendLayout();
			this.tpDep.SuspendLayout();
			this.tpCategory.SuspendLayout();
			this.tpProductType.SuspendLayout();
			this.tpUsingType.SuspendLayout();
			this.tpRank.SuspendLayout();
			this.tpDepType.SuspendLayout();
			this.tpPart.SuspendLayout();
			this.tcDep.SuspendLayout();
			this.tpDepToDep.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDepToDepChoicedProds)).BeginInit();
			this.tpUseToDep.SuspendLayout();
			this.tcUse.SuspendLayout();
			this.tcWH.SuspendLayout();
			this.tpToWH.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scToWH)).BeginInit();
			this.scToWH.Panel1.SuspendLayout();
			this.scToWH.Panel2.SuspendLayout();
			this.scToWH.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scToWHChoicedList)).BeginInit();
			this.scToWHChoicedList.Panel1.SuspendLayout();
			this.scToWHChoicedList.Panel2.SuspendLayout();
			this.scToWHChoicedList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvToWHChoicedProds)).BeginInit();
			this.tpFromWH.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scFromWH)).BeginInit();
			this.scFromWH.Panel1.SuspendLayout();
			this.scFromWH.Panel2.SuspendLayout();
			this.scFromWH.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.scFromWHChoicedList)).BeginInit();
			this.scFromWHChoicedList.Panel1.SuspendLayout();
			this.scFromWHChoicedList.Panel2.SuspendLayout();
			this.scFromWHChoicedList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvFromWHChoicedProds)).BeginInit();
			this.SuspendLayout();
			// 
			// pnMenu
			// 
			this.pnMenu.BackColor = System.Drawing.SystemColors.MenuBar;
			this.pnMenu.Controls.Add(this.btnWriteoff);
			this.pnMenu.Controls.Add(this.btnReport);
			this.pnMenu.Controls.Add(this.btnUse);
			this.pnMenu.Controls.Add(this.btnDep);
			this.pnMenu.Controls.Add(this.btnWH);
			this.pnMenu.Controls.Add(this.btnEdit);
			this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.pnMenu.Location = new System.Drawing.Point(0, 0);
			this.pnMenu.Name = "pnMenu";
			this.pnMenu.Size = new System.Drawing.Size(157, 562);
			this.pnMenu.TabIndex = 0;
			this.pnMenu.Click += new System.EventHandler(this.PnMenuClick);
			// 
			// btnWriteoff
			// 
			this.btnWriteoff.BackColor = System.Drawing.Color.DarkSalmon;
			this.btnWriteoff.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnWriteoff.Location = new System.Drawing.Point(0, 200);
			this.btnWriteoff.Name = "btnWriteoff";
			this.btnWriteoff.Size = new System.Drawing.Size(157, 40);
			this.btnWriteoff.TabIndex = 0;
			this.btnWriteoff.Text = "Списание";
			this.btnWriteoff.UseVisualStyleBackColor = false;
			this.btnWriteoff.Click += new System.EventHandler(this.BtnWriteoffClick);
			// 
			// btnReport
			// 
			this.btnReport.BackColor = System.Drawing.Color.DarkSalmon;
			this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnReport.Location = new System.Drawing.Point(0, 160);
			this.btnReport.Name = "btnReport";
			this.btnReport.Size = new System.Drawing.Size(157, 40);
			this.btnReport.TabIndex = 4;
			this.btnReport.Text = "Отчеты";
			this.btnReport.UseVisualStyleBackColor = false;
			this.btnReport.Click += new System.EventHandler(this.BtnReportClick);
			// 
			// btnUse
			// 
			this.btnUse.BackColor = System.Drawing.Color.DarkSalmon;
			this.btnUse.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnUse.Location = new System.Drawing.Point(0, 120);
			this.btnUse.Name = "btnUse";
			this.btnUse.Size = new System.Drawing.Size(157, 40);
			this.btnUse.TabIndex = 3;
			this.btnUse.Text = "Эксплуатация";
			this.btnUse.UseVisualStyleBackColor = false;
			this.btnUse.Click += new System.EventHandler(this.BtnUseClick);
			// 
			// btnDep
			// 
			this.btnDep.BackColor = System.Drawing.Color.DarkSalmon;
			this.btnDep.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnDep.Location = new System.Drawing.Point(0, 80);
			this.btnDep.Name = "btnDep";
			this.btnDep.Size = new System.Drawing.Size(157, 40);
			this.btnDep.TabIndex = 2;
			this.btnDep.Text = "Подразделение";
			this.btnDep.UseVisualStyleBackColor = false;
			this.btnDep.Click += new System.EventHandler(this.BtnDepClick);
			// 
			// btnWH
			// 
			this.btnWH.BackColor = System.Drawing.Color.DarkSalmon;
			this.btnWH.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnWH.Location = new System.Drawing.Point(0, 40);
			this.btnWH.Name = "btnWH";
			this.btnWH.Size = new System.Drawing.Size(157, 40);
			this.btnWH.TabIndex = 1;
			this.btnWH.Text = "Склад";
			this.btnWH.UseVisualStyleBackColor = false;
			this.btnWH.Click += new System.EventHandler(this.BtnWHClick);
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.Color.DarkSalmon;
			this.btnEdit.Dock = System.Windows.Forms.DockStyle.Top;
			this.btnEdit.Location = new System.Drawing.Point(0, 0);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(157, 40);
			this.btnEdit.TabIndex = 0;
			this.btnEdit.Text = "Ввод-редактирование";
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.BtnEditClick);
			// 
			// tcEdit
			// 
			this.tcEdit.Controls.Add(this.tpPerson);
			this.tcEdit.Controls.Add(this.tpDep);
			this.tcEdit.Controls.Add(this.tpCategory);
			this.tcEdit.Controls.Add(this.tpProductType);
			this.tcEdit.Controls.Add(this.tpUsingType);
			this.tcEdit.Controls.Add(this.tpRank);
			this.tcEdit.Controls.Add(this.tpDepType);
			this.tcEdit.Controls.Add(this.tpPart);
			this.tcEdit.Location = new System.Drawing.Point(250, 10);
			this.tcEdit.Name = "tcEdit";
			this.tcEdit.SelectedIndex = 0;
			this.tcEdit.Size = new System.Drawing.Size(300, 200);
			this.tcEdit.TabIndex = 1;
			this.tcEdit.SelectedIndexChanged += new System.EventHandler(this.TcEditSelectedIndexChanged);
			// 
			// tpPerson
			// 
			this.tpPerson.BackColor = System.Drawing.Color.YellowGreen;
			this.tpPerson.Controls.Add(this.dgvEditPersonList);
			this.tpPerson.Controls.Add(this.rbEditPersonGenderF);
			this.tpPerson.Controls.Add(this.rbEditPersonGenderM);
			this.tpPerson.Controls.Add(this.gbEditPersonRank);
			this.tpPerson.Controls.Add(this.btnEditPersonFind);
			this.tpPerson.Controls.Add(this.lbEditIDPerson);
			this.tpPerson.Controls.Add(this.lsbEditPersonList);
			this.tpPerson.Controls.Add(this.btnEditPersonNew);
			this.tpPerson.Controls.Add(this.btnEditPersonDelete);
			this.tpPerson.Controls.Add(this.btnEditPersonSave);
			this.tpPerson.Controls.Add(this.chbEditPersonDeath);
			this.tpPerson.Controls.Add(this.dtpEditPersonDeathdate);
			this.tpPerson.Controls.Add(this.lbEditPersonDeathdate);
			this.tpPerson.Controls.Add(this.dtpEditPersonBirthdate);
			this.tpPerson.Controls.Add(this.lbEditPersonBirthdate);
			this.tpPerson.Controls.Add(this.txEditPersonPatronymic);
			this.tpPerson.Controls.Add(this.lbEditPersonPatronymic);
			this.tpPerson.Controls.Add(this.txEditPersonFirstname);
			this.tpPerson.Controls.Add(this.lbEditPersonFirstname);
			this.tpPerson.Controls.Add(this.txEditPersonLastname);
			this.tpPerson.Controls.Add(this.lbEditPersonLastname);
			this.tpPerson.Location = new System.Drawing.Point(4, 22);
			this.tpPerson.Name = "tpPerson";
			this.tpPerson.Size = new System.Drawing.Size(292, 174);
			this.tpPerson.TabIndex = 3;
			this.tpPerson.Text = "Человек";
			// 
			// dgvEditPersonList
			// 
			this.dgvEditPersonList.AllowUserToAddRows = false;
			this.dgvEditPersonList.AllowUserToDeleteRows = false;
			this.dgvEditPersonList.AllowUserToOrderColumns = true;
			this.dgvEditPersonList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEditPersonList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.id,
			this.lastname,
			this.firstname,
			this.patronymic,
			this.gender,
			this.birthdate,
			this.deathdate,
			this.rankname,
			this.rankdate});
			this.dgvEditPersonList.Location = new System.Drawing.Point(10, 345);
			this.dgvEditPersonList.Name = "dgvEditPersonList";
			this.dgvEditPersonList.ReadOnly = true;
			this.dgvEditPersonList.RowTemplate.ReadOnly = true;
			this.dgvEditPersonList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvEditPersonList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvEditPersonList.Size = new System.Drawing.Size(568, 112);
			this.dgvEditPersonList.TabIndex = 20;
			this.dgvEditPersonList.SelectionChanged += new System.EventHandler(this.DgvEditPersonListSelectionChanged);
			// 
			// id
			// 
			this.id.HeaderText = "id";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			this.id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// lastname
			// 
			this.lastname.HeaderText = "Фамилия";
			this.lastname.Name = "lastname";
			this.lastname.ReadOnly = true;
			// 
			// firstname
			// 
			this.firstname.HeaderText = "Имя";
			this.firstname.Name = "firstname";
			this.firstname.ReadOnly = true;
			// 
			// patronymic
			// 
			this.patronymic.HeaderText = "отчество";
			this.patronymic.Name = "patronymic";
			this.patronymic.ReadOnly = true;
			// 
			// gender
			// 
			this.gender.HeaderText = "Пол";
			this.gender.Items.AddRange(new object[] {
			"М",
			"Ж"});
			this.gender.Name = "gender";
			this.gender.ReadOnly = true;
			// 
			// birthdate
			// 
			this.birthdate.HeaderText = "дата рожд";
			this.birthdate.Name = "birthdate";
			this.birthdate.ReadOnly = true;
			// 
			// deathdate
			// 
			this.deathdate.HeaderText = "дата смерти";
			this.deathdate.Name = "deathdate";
			this.deathdate.ReadOnly = true;
			// 
			// rankname
			// 
			this.rankname.HeaderText = "Звание";
			this.rankname.Name = "rankname";
			this.rankname.ReadOnly = true;
			// 
			// rankdate
			// 
			this.rankdate.HeaderText = "Дата звания";
			this.rankdate.Name = "rankdate";
			this.rankdate.ReadOnly = true;
			// 
			// rbEditPersonGenderF
			// 
			this.rbEditPersonGenderF.Location = new System.Drawing.Point(181, 89);
			this.rbEditPersonGenderF.Name = "rbEditPersonGenderF";
			this.rbEditPersonGenderF.Size = new System.Drawing.Size(75, 24);
			this.rbEditPersonGenderF.TabIndex = 19;
			this.rbEditPersonGenderF.TabStop = true;
			this.rbEditPersonGenderF.Text = "жен";
			this.rbEditPersonGenderF.UseVisualStyleBackColor = true;
			// 
			// rbEditPersonGenderM
			// 
			this.rbEditPersonGenderM.Checked = true;
			this.rbEditPersonGenderM.Location = new System.Drawing.Point(114, 90);
			this.rbEditPersonGenderM.Name = "rbEditPersonGenderM";
			this.rbEditPersonGenderM.Size = new System.Drawing.Size(61, 24);
			this.rbEditPersonGenderM.TabIndex = 18;
			this.rbEditPersonGenderM.TabStop = true;
			this.rbEditPersonGenderM.Text = "муж";
			this.rbEditPersonGenderM.UseVisualStyleBackColor = true;
			// 
			// gbEditPersonRank
			// 
			this.gbEditPersonRank.Controls.Add(this.lbEditPIDRank);
			this.gbEditPersonRank.Controls.Add(this.cbEditPersonRankName);
			this.gbEditPersonRank.Controls.Add(this.dtpEditPersonRankDatefrom);
			this.gbEditPersonRank.Controls.Add(this.lbEditPersonRankDatefrom);
			this.gbEditPersonRank.Controls.Add(this.lbEditPersonRankName);
			this.gbEditPersonRank.Location = new System.Drawing.Point(280, 14);
			this.gbEditPersonRank.Name = "gbEditPersonRank";
			this.gbEditPersonRank.Size = new System.Drawing.Size(298, 108);
			this.gbEditPersonRank.TabIndex = 17;
			this.gbEditPersonRank.TabStop = false;
			this.gbEditPersonRank.Text = "Звание сейчас";
			// 
			// lbEditPIDRank
			// 
			this.lbEditPIDRank.Location = new System.Drawing.Point(10, 44);
			this.lbEditPIDRank.Name = "lbEditPIDRank";
			this.lbEditPIDRank.Size = new System.Drawing.Size(56, 21);
			this.lbEditPIDRank.TabIndex = 5;
			this.lbEditPIDRank.Text = "0";
			// 
			// cbEditPersonRankName
			// 
			this.cbEditPersonRankName.FormattingEnabled = true;
			this.cbEditPersonRankName.Location = new System.Drawing.Point(116, 23);
			this.cbEditPersonRankName.Name = "cbEditPersonRankName";
			this.cbEditPersonRankName.Size = new System.Drawing.Size(162, 21);
			this.cbEditPersonRankName.TabIndex = 4;
			this.cbEditPersonRankName.SelectedIndexChanged += new System.EventHandler(this.CbEditPersonRankNameSelectedIndexChanged);
			// 
			// dtpEditPersonRankDatefrom
			// 
			this.dtpEditPersonRankDatefrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpEditPersonRankDatefrom.Location = new System.Drawing.Point(166, 62);
			this.dtpEditPersonRankDatefrom.Name = "dtpEditPersonRankDatefrom";
			this.dtpEditPersonRankDatefrom.Size = new System.Drawing.Size(112, 20);
			this.dtpEditPersonRankDatefrom.TabIndex = 3;
			// 
			// lbEditPersonRankDatefrom
			// 
			this.lbEditPersonRankDatefrom.Location = new System.Drawing.Point(6, 65);
			this.lbEditPersonRankDatefrom.Name = "lbEditPersonRankDatefrom";
			this.lbEditPersonRankDatefrom.Size = new System.Drawing.Size(144, 23);
			this.lbEditPersonRankDatefrom.TabIndex = 2;
			this.lbEditPersonRankDatefrom.Text = "Дата получения звания";
			// 
			// lbEditPersonRankName
			// 
			this.lbEditPersonRankName.Location = new System.Drawing.Point(6, 26);
			this.lbEditPersonRankName.Name = "lbEditPersonRankName";
			this.lbEditPersonRankName.Size = new System.Drawing.Size(104, 23);
			this.lbEditPersonRankName.TabIndex = 0;
			this.lbEditPersonRankName.Text = "Воинское Звание";
			// 
			// btnEditPersonFind
			// 
			this.btnEditPersonFind.Location = new System.Drawing.Point(19, 243);
			this.btnEditPersonFind.Name = "btnEditPersonFind";
			this.btnEditPersonFind.Size = new System.Drawing.Size(75, 23);
			this.btnEditPersonFind.TabIndex = 16;
			this.btnEditPersonFind.Text = "Найти";
			this.btnEditPersonFind.UseVisualStyleBackColor = true;
			this.btnEditPersonFind.Click += new System.EventHandler(this.BtnEditPersonFindClick);
			// 
			// lbEditIDPerson
			// 
			this.lbEditIDPerson.Location = new System.Drawing.Point(10, 199);
			this.lbEditIDPerson.Name = "lbEditIDPerson";
			this.lbEditIDPerson.Size = new System.Drawing.Size(43, 23);
			this.lbEditIDPerson.TabIndex = 15;
			this.lbEditIDPerson.Text = "0";
			// 
			// lsbEditPersonList
			// 
			this.lsbEditPersonList.FormattingEnabled = true;
			this.lsbEditPersonList.Location = new System.Drawing.Point(280, 214);
			this.lsbEditPersonList.Name = "lsbEditPersonList";
			this.lsbEditPersonList.Size = new System.Drawing.Size(298, 121);
			this.lsbEditPersonList.TabIndex = 14;
			this.lsbEditPersonList.Visible = false;
			this.lsbEditPersonList.SelectedIndexChanged += new System.EventHandler(this.LsbEditPersonListSelectedIndexChanged);
			// 
			// btnEditPersonNew
			// 
			this.btnEditPersonNew.Location = new System.Drawing.Point(19, 214);
			this.btnEditPersonNew.Name = "btnEditPersonNew";
			this.btnEditPersonNew.Size = new System.Drawing.Size(75, 23);
			this.btnEditPersonNew.TabIndex = 13;
			this.btnEditPersonNew.Text = "Новый";
			this.btnEditPersonNew.UseVisualStyleBackColor = true;
			this.btnEditPersonNew.Click += new System.EventHandler(this.BtnEditPersonNewClick);
			// 
			// btnEditPersonDelete
			// 
			this.btnEditPersonDelete.Location = new System.Drawing.Point(100, 214);
			this.btnEditPersonDelete.Name = "btnEditPersonDelete";
			this.btnEditPersonDelete.Size = new System.Drawing.Size(75, 23);
			this.btnEditPersonDelete.TabIndex = 12;
			this.btnEditPersonDelete.Text = "Удалить";
			this.btnEditPersonDelete.UseVisualStyleBackColor = true;
			this.btnEditPersonDelete.Click += new System.EventHandler(this.BtnEditPersonDeleteClick);
			// 
			// btnEditPersonSave
			// 
			this.btnEditPersonSave.Location = new System.Drawing.Point(181, 214);
			this.btnEditPersonSave.Name = "btnEditPersonSave";
			this.btnEditPersonSave.Size = new System.Drawing.Size(75, 23);
			this.btnEditPersonSave.TabIndex = 11;
			this.btnEditPersonSave.Text = "Сохранить";
			this.btnEditPersonSave.UseVisualStyleBackColor = true;
			this.btnEditPersonSave.Click += new System.EventHandler(this.BtnEditPersonSaveClick);
			// 
			// chbEditPersonDeath
			// 
			this.chbEditPersonDeath.Location = new System.Drawing.Point(10, 147);
			this.chbEditPersonDeath.Name = "chbEditPersonDeath";
			this.chbEditPersonDeath.Size = new System.Drawing.Size(104, 24);
			this.chbEditPersonDeath.TabIndex = 10;
			this.chbEditPersonDeath.Text = "Исключить";
			this.chbEditPersonDeath.UseVisualStyleBackColor = true;
			this.chbEditPersonDeath.CheckedChanged += new System.EventHandler(this.ChbEditPersonDeathCheckedChanged);
			// 
			// dtpEditPersonDeathdate
			// 
			this.dtpEditPersonDeathdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpEditPersonDeathdate.Location = new System.Drawing.Point(114, 177);
			this.dtpEditPersonDeathdate.Name = "dtpEditPersonDeathdate";
			this.dtpEditPersonDeathdate.Size = new System.Drawing.Size(142, 20);
			this.dtpEditPersonDeathdate.TabIndex = 9;
			this.dtpEditPersonDeathdate.Value = new System.DateTime(2018, 5, 10, 14, 34, 33, 0);
			this.dtpEditPersonDeathdate.Visible = false;
			// 
			// lbEditPersonDeathdate
			// 
			this.lbEditPersonDeathdate.Location = new System.Drawing.Point(10, 176);
			this.lbEditPersonDeathdate.Name = "lbEditPersonDeathdate";
			this.lbEditPersonDeathdate.Size = new System.Drawing.Size(100, 23);
			this.lbEditPersonDeathdate.TabIndex = 8;
			this.lbEditPersonDeathdate.Text = "Дата смерти";
			this.lbEditPersonDeathdate.Visible = false;
			// 
			// dtpEditPersonBirthdate
			// 
			this.dtpEditPersonBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpEditPersonBirthdate.Location = new System.Drawing.Point(114, 123);
			this.dtpEditPersonBirthdate.Name = "dtpEditPersonBirthdate";
			this.dtpEditPersonBirthdate.Size = new System.Drawing.Size(142, 20);
			this.dtpEditPersonBirthdate.TabIndex = 7;
			// 
			// lbEditPersonBirthdate
			// 
			this.lbEditPersonBirthdate.Location = new System.Drawing.Point(10, 123);
			this.lbEditPersonBirthdate.Name = "lbEditPersonBirthdate";
			this.lbEditPersonBirthdate.Size = new System.Drawing.Size(86, 23);
			this.lbEditPersonBirthdate.TabIndex = 6;
			this.lbEditPersonBirthdate.Text = "Дата рождения";
			// 
			// txEditPersonPatronymic
			// 
			this.txEditPersonPatronymic.Location = new System.Drawing.Point(114, 63);
			this.txEditPersonPatronymic.Name = "txEditPersonPatronymic";
			this.txEditPersonPatronymic.Size = new System.Drawing.Size(142, 20);
			this.txEditPersonPatronymic.TabIndex = 5;
			// 
			// lbEditPersonPatronymic
			// 
			this.lbEditPersonPatronymic.Location = new System.Drawing.Point(10, 63);
			this.lbEditPersonPatronymic.Name = "lbEditPersonPatronymic";
			this.lbEditPersonPatronymic.Size = new System.Drawing.Size(70, 23);
			this.lbEditPersonPatronymic.TabIndex = 4;
			this.lbEditPersonPatronymic.Text = "Отчество";
			// 
			// txEditPersonFirstname
			// 
			this.txEditPersonFirstname.Location = new System.Drawing.Point(114, 40);
			this.txEditPersonFirstname.Name = "txEditPersonFirstname";
			this.txEditPersonFirstname.Size = new System.Drawing.Size(142, 20);
			this.txEditPersonFirstname.TabIndex = 3;
			// 
			// lbEditPersonFirstname
			// 
			this.lbEditPersonFirstname.Location = new System.Drawing.Point(10, 40);
			this.lbEditPersonFirstname.Name = "lbEditPersonFirstname";
			this.lbEditPersonFirstname.Size = new System.Drawing.Size(70, 23);
			this.lbEditPersonFirstname.TabIndex = 2;
			this.lbEditPersonFirstname.Text = "Имя";
			// 
			// txEditPersonLastname
			// 
			this.txEditPersonLastname.Location = new System.Drawing.Point(114, 14);
			this.txEditPersonLastname.Name = "txEditPersonLastname";
			this.txEditPersonLastname.Size = new System.Drawing.Size(142, 20);
			this.txEditPersonLastname.TabIndex = 1;
			// 
			// lbEditPersonLastname
			// 
			this.lbEditPersonLastname.Location = new System.Drawing.Point(10, 17);
			this.lbEditPersonLastname.Name = "lbEditPersonLastname";
			this.lbEditPersonLastname.Size = new System.Drawing.Size(70, 23);
			this.lbEditPersonLastname.TabIndex = 0;
			this.lbEditPersonLastname.Text = "Фамилия";
			// 
			// tpDep
			// 
			this.tpDep.BackColor = System.Drawing.Color.YellowGreen;
			this.tpDep.Controls.Add(this.lbEditDepDeptypeID);
			this.tpDep.Controls.Add(this.button1);
			this.tpDep.Controls.Add(this.cbEditDepDeptype);
			this.tpDep.Controls.Add(this.lbEditDepDeptype);
			this.tpDep.Controls.Add(this.btnEditDepNew);
			this.tpDep.Controls.Add(this.btnEditDepDelete);
			this.tpDep.Controls.Add(this.btnEditDepSave);
			this.tpDep.Controls.Add(this.lbEditIDDep);
			this.tpDep.Controls.Add(this.lsbEditDepList);
			this.tpDep.Controls.Add(this.txEditDepName);
			this.tpDep.Controls.Add(this.lbEditDepName);
			this.tpDep.Location = new System.Drawing.Point(4, 22);
			this.tpDep.Name = "tpDep";
			this.tpDep.Padding = new System.Windows.Forms.Padding(3);
			this.tpDep.Size = new System.Drawing.Size(292, 174);
			this.tpDep.TabIndex = 0;
			this.tpDep.Text = "Подразделение";
			// 
			// lbEditDepDeptypeID
			// 
			this.lbEditDepDeptypeID.Location = new System.Drawing.Point(6, 81);
			this.lbEditDepDeptypeID.Name = "lbEditDepDeptypeID";
			this.lbEditDepDeptypeID.Size = new System.Drawing.Size(19, 23);
			this.lbEditDepDeptypeID.TabIndex = 10;
			this.lbEditDepDeptypeID.Text = "0";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(297, 55);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(25, 23);
			this.button1.TabIndex = 9;
			this.button1.Text = "...";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// cbEditDepDeptype
			// 
			this.cbEditDepDeptype.FormattingEnabled = true;
			this.cbEditDepDeptype.Location = new System.Drawing.Point(158, 58);
			this.cbEditDepDeptype.Name = "cbEditDepDeptype";
			this.cbEditDepDeptype.Size = new System.Drawing.Size(140, 21);
			this.cbEditDepDeptype.TabIndex = 8;
			// 
			// lbEditDepDeptype
			// 
			this.lbEditDepDeptype.Location = new System.Drawing.Point(6, 58);
			this.lbEditDepDeptype.Name = "lbEditDepDeptype";
			this.lbEditDepDeptype.Size = new System.Drawing.Size(146, 23);
			this.lbEditDepDeptype.TabIndex = 7;
			this.lbEditDepDeptype.Text = "Тип подразделения";
			// 
			// btnEditDepNew
			// 
			this.btnEditDepNew.Location = new System.Drawing.Point(60, 93);
			this.btnEditDepNew.Name = "btnEditDepNew";
			this.btnEditDepNew.Size = new System.Drawing.Size(75, 23);
			this.btnEditDepNew.TabIndex = 6;
			this.btnEditDepNew.Text = "Новый";
			this.btnEditDepNew.UseVisualStyleBackColor = true;
			this.btnEditDepNew.Click += new System.EventHandler(this.BtnEditDepNewClick);
			// 
			// btnEditDepDelete
			// 
			this.btnEditDepDelete.Location = new System.Drawing.Point(142, 93);
			this.btnEditDepDelete.Name = "btnEditDepDelete";
			this.btnEditDepDelete.Size = new System.Drawing.Size(75, 23);
			this.btnEditDepDelete.TabIndex = 5;
			this.btnEditDepDelete.Text = "Удалить";
			this.btnEditDepDelete.UseVisualStyleBackColor = true;
			this.btnEditDepDelete.Click += new System.EventHandler(this.BtnEditDepDeleteClick);
			// 
			// btnEditDepSave
			// 
			this.btnEditDepSave.Location = new System.Drawing.Point(223, 93);
			this.btnEditDepSave.Name = "btnEditDepSave";
			this.btnEditDepSave.Size = new System.Drawing.Size(75, 23);
			this.btnEditDepSave.TabIndex = 4;
			this.btnEditDepSave.Text = "Сохранить";
			this.btnEditDepSave.UseVisualStyleBackColor = true;
			this.btnEditDepSave.Click += new System.EventHandler(this.BtnEditDepSaveClick);
			// 
			// lbEditIDDep
			// 
			this.lbEditIDDep.Location = new System.Drawing.Point(6, 32);
			this.lbEditIDDep.Name = "lbEditIDDep";
			this.lbEditIDDep.Size = new System.Drawing.Size(31, 23);
			this.lbEditIDDep.TabIndex = 3;
			this.lbEditIDDep.Text = "0";
			// 
			// lsbEditDepList
			// 
			this.lsbEditDepList.FormattingEnabled = true;
			this.lsbEditDepList.HorizontalScrollbar = true;
			this.lsbEditDepList.Location = new System.Drawing.Point(6, 138);
			this.lsbEditDepList.Name = "lsbEditDepList";
			this.lsbEditDepList.ScrollAlwaysVisible = true;
			this.lsbEditDepList.Size = new System.Drawing.Size(292, 199);
			this.lsbEditDepList.TabIndex = 2;
			this.lsbEditDepList.SelectedIndexChanged += new System.EventHandler(this.LsbEditDepListSelectedIndexChanged);
			// 
			// txEditDepName
			// 
			this.txEditDepName.Location = new System.Drawing.Point(158, 18);
			this.txEditDepName.Name = "txEditDepName";
			this.txEditDepName.Size = new System.Drawing.Size(140, 20);
			this.txEditDepName.TabIndex = 1;
			// 
			// lbEditDepName
			// 
			this.lbEditDepName.Location = new System.Drawing.Point(6, 18);
			this.lbEditDepName.Name = "lbEditDepName";
			this.lbEditDepName.Size = new System.Drawing.Size(146, 23);
			this.lbEditDepName.TabIndex = 0;
			this.lbEditDepName.Text = "Название подразделения";
			// 
			// tpCategory
			// 
			this.tpCategory.BackColor = System.Drawing.Color.YellowGreen;
			this.tpCategory.Controls.Add(this.lbEditIDCat);
			this.tpCategory.Controls.Add(this.btnEditCatNew);
			this.tpCategory.Controls.Add(this.btnEditCatDelete);
			this.tpCategory.Controls.Add(this.btnEditCatSave);
			this.tpCategory.Controls.Add(this.lsbEditCatList);
			this.tpCategory.Controls.Add(this.txEditCatName);
			this.tpCategory.Controls.Add(this.lbEditCatName);
			this.tpCategory.Location = new System.Drawing.Point(4, 22);
			this.tpCategory.Name = "tpCategory";
			this.tpCategory.Size = new System.Drawing.Size(292, 174);
			this.tpCategory.TabIndex = 2;
			this.tpCategory.Text = "Категории";
			// 
			// lbEditIDCat
			// 
			this.lbEditIDCat.Location = new System.Drawing.Point(14, 40);
			this.lbEditIDCat.Name = "lbEditIDCat";
			this.lbEditIDCat.Size = new System.Drawing.Size(19, 23);
			this.lbEditIDCat.TabIndex = 6;
			this.lbEditIDCat.Text = "0";
			// 
			// btnEditCatNew
			// 
			this.btnEditCatNew.Location = new System.Drawing.Point(39, 43);
			this.btnEditCatNew.Name = "btnEditCatNew";
			this.btnEditCatNew.Size = new System.Drawing.Size(75, 23);
			this.btnEditCatNew.TabIndex = 5;
			this.btnEditCatNew.Text = "Новая";
			this.btnEditCatNew.UseVisualStyleBackColor = true;
			this.btnEditCatNew.Click += new System.EventHandler(this.BtnEditCatNewClick);
			// 
			// btnEditCatDelete
			// 
			this.btnEditCatDelete.Location = new System.Drawing.Point(120, 43);
			this.btnEditCatDelete.Name = "btnEditCatDelete";
			this.btnEditCatDelete.Size = new System.Drawing.Size(75, 23);
			this.btnEditCatDelete.TabIndex = 4;
			this.btnEditCatDelete.Text = "Удалить";
			this.btnEditCatDelete.UseVisualStyleBackColor = true;
			this.btnEditCatDelete.Click += new System.EventHandler(this.BtnEditCatDeleteClick);
			// 
			// btnEditCatSave
			// 
			this.btnEditCatSave.Location = new System.Drawing.Point(201, 43);
			this.btnEditCatSave.Name = "btnEditCatSave";
			this.btnEditCatSave.Size = new System.Drawing.Size(75, 23);
			this.btnEditCatSave.TabIndex = 3;
			this.btnEditCatSave.Text = "Сохранить";
			this.btnEditCatSave.UseVisualStyleBackColor = true;
			this.btnEditCatSave.Click += new System.EventHandler(this.BtnEditCatSaveClick);
			// 
			// lsbEditCatList
			// 
			this.lsbEditCatList.FormattingEnabled = true;
			this.lsbEditCatList.Location = new System.Drawing.Point(11, 84);
			this.lsbEditCatList.Name = "lsbEditCatList";
			this.lsbEditCatList.Size = new System.Drawing.Size(265, 160);
			this.lsbEditCatList.TabIndex = 2;
			this.lsbEditCatList.SelectedIndexChanged += new System.EventHandler(this.LsbEditCatListSelectedIndexChanged);
			// 
			// txEditCatName
			// 
			this.txEditCatName.Location = new System.Drawing.Point(117, 17);
			this.txEditCatName.Name = "txEditCatName";
			this.txEditCatName.Size = new System.Drawing.Size(159, 20);
			this.txEditCatName.TabIndex = 1;
			// 
			// lbEditCatName
			// 
			this.lbEditCatName.Location = new System.Drawing.Point(11, 17);
			this.lbEditCatName.Name = "lbEditCatName";
			this.lbEditCatName.Size = new System.Drawing.Size(100, 23);
			this.lbEditCatName.TabIndex = 0;
			this.lbEditCatName.Text = "Категория";
			// 
			// tpProductType
			// 
			this.tpProductType.BackColor = System.Drawing.Color.YellowGreen;
			this.tpProductType.Controls.Add(this.btnEditUsingtypesEdit);
			this.tpProductType.Controls.Add(this.lbEditPTIDUsingtype);
			this.tpProductType.Controls.Add(this.cbEditPTUsingtypeName);
			this.tpProductType.Controls.Add(this.lbEditPTUsingtypeName);
			this.tpProductType.Controls.Add(this.lsbEditProdtypeList);
			this.tpProductType.Controls.Add(this.btnEditProdtypeNew);
			this.tpProductType.Controls.Add(this.btnEditProdtypeDel);
			this.tpProductType.Controls.Add(this.btnEditProdtypeSave);
			this.tpProductType.Controls.Add(this.lbEditIDProdtype);
			this.tpProductType.Controls.Add(this.txEditProdtypeName);
			this.tpProductType.Controls.Add(this.lbEditProdtypeName);
			this.tpProductType.Location = new System.Drawing.Point(4, 22);
			this.tpProductType.Name = "tpProductType";
			this.tpProductType.Size = new System.Drawing.Size(292, 174);
			this.tpProductType.TabIndex = 5;
			this.tpProductType.Text = "Виды предметов";
			// 
			// btnEditUsingtypesEdit
			// 
			this.btnEditUsingtypesEdit.Location = new System.Drawing.Point(340, 53);
			this.btnEditUsingtypesEdit.Name = "btnEditUsingtypesEdit";
			this.btnEditUsingtypesEdit.Size = new System.Drawing.Size(24, 23);
			this.btnEditUsingtypesEdit.TabIndex = 10;
			this.btnEditUsingtypesEdit.Text = "...";
			this.btnEditUsingtypesEdit.UseVisualStyleBackColor = true;
			this.btnEditUsingtypesEdit.Click += new System.EventHandler(this.BtnEditUsingtypesEditClick);
			// 
			// lbEditPTIDUsingtype
			// 
			this.lbEditPTIDUsingtype.Location = new System.Drawing.Point(14, 72);
			this.lbEditPTIDUsingtype.Name = "lbEditPTIDUsingtype";
			this.lbEditPTIDUsingtype.Size = new System.Drawing.Size(43, 23);
			this.lbEditPTIDUsingtype.TabIndex = 9;
			this.lbEditPTIDUsingtype.Text = "0";
			// 
			// cbEditPTUsingtypeName
			// 
			this.cbEditPTUsingtypeName.FormattingEnabled = true;
			this.cbEditPTUsingtypeName.Location = new System.Drawing.Point(145, 55);
			this.cbEditPTUsingtypeName.Name = "cbEditPTUsingtypeName";
			this.cbEditPTUsingtypeName.Size = new System.Drawing.Size(199, 21);
			this.cbEditPTUsingtypeName.TabIndex = 8;
			this.cbEditPTUsingtypeName.SelectedIndexChanged += new System.EventHandler(this.CbEditPTUsingtypeNameSelectedIndexChanged);
			// 
			// lbEditPTUsingtypeName
			// 
			this.lbEditPTUsingtypeName.Location = new System.Drawing.Point(14, 58);
			this.lbEditPTUsingtypeName.Name = "lbEditPTUsingtypeName";
			this.lbEditPTUsingtypeName.Size = new System.Drawing.Size(100, 23);
			this.lbEditPTUsingtypeName.TabIndex = 7;
			this.lbEditPTUsingtypeName.Text = "Вид пользования";
			// 
			// lsbEditProdtypeList
			// 
			this.lsbEditProdtypeList.FormattingEnabled = true;
			this.lsbEditProdtypeList.Location = new System.Drawing.Point(14, 126);
			this.lsbEditProdtypeList.Name = "lsbEditProdtypeList";
			this.lsbEditProdtypeList.Size = new System.Drawing.Size(330, 173);
			this.lsbEditProdtypeList.TabIndex = 6;
			this.lsbEditProdtypeList.SelectedIndexChanged += new System.EventHandler(this.LsbEditProdtypeListSelectedIndexChanged);
			// 
			// btnEditProdtypeNew
			// 
			this.btnEditProdtypeNew.Location = new System.Drawing.Point(107, 88);
			this.btnEditProdtypeNew.Name = "btnEditProdtypeNew";
			this.btnEditProdtypeNew.Size = new System.Drawing.Size(75, 23);
			this.btnEditProdtypeNew.TabIndex = 5;
			this.btnEditProdtypeNew.Text = "Новый";
			this.btnEditProdtypeNew.UseVisualStyleBackColor = true;
			this.btnEditProdtypeNew.Click += new System.EventHandler(this.BtnEditProdtypeNewClick);
			// 
			// btnEditProdtypeDel
			// 
			this.btnEditProdtypeDel.Location = new System.Drawing.Point(188, 88);
			this.btnEditProdtypeDel.Name = "btnEditProdtypeDel";
			this.btnEditProdtypeDel.Size = new System.Drawing.Size(75, 23);
			this.btnEditProdtypeDel.TabIndex = 4;
			this.btnEditProdtypeDel.Text = "Удалить";
			this.btnEditProdtypeDel.UseVisualStyleBackColor = true;
			this.btnEditProdtypeDel.Click += new System.EventHandler(this.BtnEditProdtypeDelClick);
			// 
			// btnEditProdtypeSave
			// 
			this.btnEditProdtypeSave.Location = new System.Drawing.Point(269, 88);
			this.btnEditProdtypeSave.Name = "btnEditProdtypeSave";
			this.btnEditProdtypeSave.Size = new System.Drawing.Size(75, 23);
			this.btnEditProdtypeSave.TabIndex = 3;
			this.btnEditProdtypeSave.Text = "Сохранить";
			this.btnEditProdtypeSave.UseVisualStyleBackColor = true;
			this.btnEditProdtypeSave.Click += new System.EventHandler(this.BtnEditProdtypeSaveClick);
			// 
			// lbEditIDProdtype
			// 
			this.lbEditIDProdtype.Location = new System.Drawing.Point(14, 41);
			this.lbEditIDProdtype.Name = "lbEditIDProdtype";
			this.lbEditIDProdtype.Size = new System.Drawing.Size(43, 23);
			this.lbEditIDProdtype.TabIndex = 2;
			this.lbEditIDProdtype.Text = "0";
			// 
			// txEditProdtypeName
			// 
			this.txEditProdtypeName.Location = new System.Drawing.Point(145, 15);
			this.txEditProdtypeName.Name = "txEditProdtypeName";
			this.txEditProdtypeName.Size = new System.Drawing.Size(199, 20);
			this.txEditProdtypeName.TabIndex = 1;
			// 
			// lbEditProdtypeName
			// 
			this.lbEditProdtypeName.Location = new System.Drawing.Point(14, 18);
			this.lbEditProdtypeName.Name = "lbEditProdtypeName";
			this.lbEditProdtypeName.Size = new System.Drawing.Size(125, 23);
			this.lbEditProdtypeName.TabIndex = 0;
			this.lbEditProdtypeName.Text = "Название ценности";
			// 
			// tpUsingType
			// 
			this.tpUsingType.BackColor = System.Drawing.Color.YellowGreen;
			this.tpUsingType.Controls.Add(this.lsbEditUsingtypeList);
			this.tpUsingType.Controls.Add(this.btnEditUsingtypeNew);
			this.tpUsingType.Controls.Add(this.btnEditUsingtypeDel);
			this.tpUsingType.Controls.Add(this.btnEditUsingtypeSave);
			this.tpUsingType.Controls.Add(this.txEditUsingtypeName);
			this.tpUsingType.Controls.Add(this.lbEditIDUsingtype);
			this.tpUsingType.Controls.Add(this.lbEditUsingtypeName);
			this.tpUsingType.Location = new System.Drawing.Point(4, 22);
			this.tpUsingType.Name = "tpUsingType";
			this.tpUsingType.Size = new System.Drawing.Size(292, 174);
			this.tpUsingType.TabIndex = 6;
			this.tpUsingType.Text = "Виды пользования";
			// 
			// lsbEditUsingtypeList
			// 
			this.lsbEditUsingtypeList.FormattingEnabled = true;
			this.lsbEditUsingtypeList.Location = new System.Drawing.Point(11, 92);
			this.lsbEditUsingtypeList.Name = "lsbEditUsingtypeList";
			this.lsbEditUsingtypeList.Size = new System.Drawing.Size(269, 95);
			this.lsbEditUsingtypeList.TabIndex = 6;
			this.lsbEditUsingtypeList.SelectedIndexChanged += new System.EventHandler(this.LsbEditUsingtypeListSelectedIndexChanged);
			// 
			// btnEditUsingtypeNew
			// 
			this.btnEditUsingtypeNew.Location = new System.Drawing.Point(43, 49);
			this.btnEditUsingtypeNew.Name = "btnEditUsingtypeNew";
			this.btnEditUsingtypeNew.Size = new System.Drawing.Size(75, 23);
			this.btnEditUsingtypeNew.TabIndex = 5;
			this.btnEditUsingtypeNew.Text = "Новый";
			this.btnEditUsingtypeNew.UseVisualStyleBackColor = true;
			this.btnEditUsingtypeNew.Click += new System.EventHandler(this.BtnEditUsingtypeNewClick);
			// 
			// btnEditUsingtypeDel
			// 
			this.btnEditUsingtypeDel.Location = new System.Drawing.Point(124, 49);
			this.btnEditUsingtypeDel.Name = "btnEditUsingtypeDel";
			this.btnEditUsingtypeDel.Size = new System.Drawing.Size(75, 23);
			this.btnEditUsingtypeDel.TabIndex = 4;
			this.btnEditUsingtypeDel.Text = "Удалить";
			this.btnEditUsingtypeDel.UseVisualStyleBackColor = true;
			this.btnEditUsingtypeDel.Click += new System.EventHandler(this.BtnEditUsingtypeDelClick);
			// 
			// btnEditUsingtypeSave
			// 
			this.btnEditUsingtypeSave.Location = new System.Drawing.Point(205, 49);
			this.btnEditUsingtypeSave.Name = "btnEditUsingtypeSave";
			this.btnEditUsingtypeSave.Size = new System.Drawing.Size(75, 23);
			this.btnEditUsingtypeSave.TabIndex = 3;
			this.btnEditUsingtypeSave.Text = "Сохранить";
			this.btnEditUsingtypeSave.UseVisualStyleBackColor = true;
			this.btnEditUsingtypeSave.Click += new System.EventHandler(this.BtnEditUsingtypeSaveClick);
			// 
			// txEditUsingtypeName
			// 
			this.txEditUsingtypeName.Location = new System.Drawing.Point(128, 11);
			this.txEditUsingtypeName.Name = "txEditUsingtypeName";
			this.txEditUsingtypeName.Size = new System.Drawing.Size(152, 20);
			this.txEditUsingtypeName.TabIndex = 2;
			// 
			// lbEditIDUsingtype
			// 
			this.lbEditIDUsingtype.Location = new System.Drawing.Point(11, 35);
			this.lbEditIDUsingtype.Name = "lbEditIDUsingtype";
			this.lbEditIDUsingtype.Size = new System.Drawing.Size(100, 23);
			this.lbEditIDUsingtype.TabIndex = 1;
			this.lbEditIDUsingtype.Text = "0";
			// 
			// lbEditUsingtypeName
			// 
			this.lbEditUsingtypeName.Location = new System.Drawing.Point(11, 11);
			this.lbEditUsingtypeName.Name = "lbEditUsingtypeName";
			this.lbEditUsingtypeName.Size = new System.Drawing.Size(100, 23);
			this.lbEditUsingtypeName.TabIndex = 0;
			this.lbEditUsingtypeName.Text = "Вид пользования";
			// 
			// tpRank
			// 
			this.tpRank.BackColor = System.Drawing.Color.YellowGreen;
			this.tpRank.Controls.Add(this.lbEditIDRank);
			this.tpRank.Controls.Add(this.btnEditRankNew);
			this.tpRank.Controls.Add(this.btnEditRankDelete);
			this.tpRank.Controls.Add(this.btnEditRankSave);
			this.tpRank.Controls.Add(this.lsbEditRankList);
			this.tpRank.Controls.Add(this.txEditRankName);
			this.tpRank.Controls.Add(this.lbEditRankName);
			this.tpRank.Location = new System.Drawing.Point(4, 22);
			this.tpRank.Name = "tpRank";
			this.tpRank.Padding = new System.Windows.Forms.Padding(3);
			this.tpRank.Size = new System.Drawing.Size(292, 174);
			this.tpRank.TabIndex = 1;
			this.tpRank.Text = "Звания";
			// 
			// lbEditIDRank
			// 
			this.lbEditIDRank.Location = new System.Drawing.Point(6, 40);
			this.lbEditIDRank.Name = "lbEditIDRank";
			this.lbEditIDRank.Size = new System.Drawing.Size(27, 23);
			this.lbEditIDRank.TabIndex = 6;
			this.lbEditIDRank.Text = "0";
			// 
			// btnEditRankNew
			// 
			this.btnEditRankNew.Location = new System.Drawing.Point(35, 40);
			this.btnEditRankNew.Name = "btnEditRankNew";
			this.btnEditRankNew.Size = new System.Drawing.Size(75, 23);
			this.btnEditRankNew.TabIndex = 5;
			this.btnEditRankNew.Text = "Новое";
			this.btnEditRankNew.UseVisualStyleBackColor = true;
			this.btnEditRankNew.Click += new System.EventHandler(this.BtnEditRankNewClick);
			// 
			// btnEditRankDelete
			// 
			this.btnEditRankDelete.Location = new System.Drawing.Point(116, 40);
			this.btnEditRankDelete.Name = "btnEditRankDelete";
			this.btnEditRankDelete.Size = new System.Drawing.Size(75, 23);
			this.btnEditRankDelete.TabIndex = 4;
			this.btnEditRankDelete.Text = "Удалить";
			this.btnEditRankDelete.UseVisualStyleBackColor = true;
			this.btnEditRankDelete.Click += new System.EventHandler(this.BtnEditRankDeleteClick);
			// 
			// btnEditRankSave
			// 
			this.btnEditRankSave.Location = new System.Drawing.Point(201, 40);
			this.btnEditRankSave.Name = "btnEditRankSave";
			this.btnEditRankSave.Size = new System.Drawing.Size(75, 23);
			this.btnEditRankSave.TabIndex = 3;
			this.btnEditRankSave.Text = "Сохранить";
			this.btnEditRankSave.UseVisualStyleBackColor = true;
			this.btnEditRankSave.Click += new System.EventHandler(this.BtnEditRankSaveClick);
			// 
			// lsbEditRankList
			// 
			this.lsbEditRankList.FormattingEnabled = true;
			this.lsbEditRankList.HorizontalScrollbar = true;
			this.lsbEditRankList.Location = new System.Drawing.Point(10, 98);
			this.lsbEditRankList.Name = "lsbEditRankList";
			this.lsbEditRankList.ScrollAlwaysVisible = true;
			this.lsbEditRankList.Size = new System.Drawing.Size(266, 160);
			this.lsbEditRankList.TabIndex = 2;
			this.lsbEditRankList.SelectedIndexChanged += new System.EventHandler(this.LsbEditRankListSelectedIndexChanged);
			// 
			// txEditRankName
			// 
			this.txEditRankName.Location = new System.Drawing.Point(116, 14);
			this.txEditRankName.Name = "txEditRankName";
			this.txEditRankName.Size = new System.Drawing.Size(160, 20);
			this.txEditRankName.TabIndex = 1;
			// 
			// lbEditRankName
			// 
			this.lbEditRankName.Location = new System.Drawing.Point(10, 14);
			this.lbEditRankName.Name = "lbEditRankName";
			this.lbEditRankName.Size = new System.Drawing.Size(100, 23);
			this.lbEditRankName.TabIndex = 0;
			this.lbEditRankName.Text = "Воинское Звание";
			// 
			// tpDepType
			// 
			this.tpDepType.BackColor = System.Drawing.Color.YellowGreen;
			this.tpDepType.Controls.Add(this.lsbEditDeptypeList);
			this.tpDepType.Controls.Add(this.btnEditDeptypeNew);
			this.tpDepType.Controls.Add(this.btnEditDeptypeDel);
			this.tpDepType.Controls.Add(this.btnEditDeptypeSave);
			this.tpDepType.Controls.Add(this.lbEditIDDeptype);
			this.tpDepType.Controls.Add(this.txEditDeptypeName);
			this.tpDepType.Controls.Add(this.lbEditDeptypeName);
			this.tpDepType.Location = new System.Drawing.Point(4, 22);
			this.tpDepType.Name = "tpDepType";
			this.tpDepType.Size = new System.Drawing.Size(292, 174);
			this.tpDepType.TabIndex = 4;
			this.tpDepType.Text = "Типы подразделений";
			// 
			// lsbEditDeptypeList
			// 
			this.lsbEditDeptypeList.FormattingEnabled = true;
			this.lsbEditDeptypeList.Location = new System.Drawing.Point(12, 84);
			this.lsbEditDeptypeList.Name = "lsbEditDeptypeList";
			this.lsbEditDeptypeList.Size = new System.Drawing.Size(264, 121);
			this.lsbEditDeptypeList.TabIndex = 6;
			this.lsbEditDeptypeList.SelectedIndexChanged += new System.EventHandler(this.LsbEditDeptypeListSelectedIndexChanged);
			// 
			// btnEditDeptypeNew
			// 
			this.btnEditDeptypeNew.Location = new System.Drawing.Point(39, 40);
			this.btnEditDeptypeNew.Name = "btnEditDeptypeNew";
			this.btnEditDeptypeNew.Size = new System.Drawing.Size(75, 23);
			this.btnEditDeptypeNew.TabIndex = 5;
			this.btnEditDeptypeNew.Text = "Новый";
			this.btnEditDeptypeNew.UseVisualStyleBackColor = true;
			this.btnEditDeptypeNew.Click += new System.EventHandler(this.BtnEditDeptypeNewClick);
			// 
			// btnEditDeptypeDel
			// 
			this.btnEditDeptypeDel.Location = new System.Drawing.Point(120, 40);
			this.btnEditDeptypeDel.Name = "btnEditDeptypeDel";
			this.btnEditDeptypeDel.Size = new System.Drawing.Size(75, 23);
			this.btnEditDeptypeDel.TabIndex = 4;
			this.btnEditDeptypeDel.Text = "Удалить";
			this.btnEditDeptypeDel.UseVisualStyleBackColor = true;
			this.btnEditDeptypeDel.Click += new System.EventHandler(this.BtnEditDeptypeDelClick);
			// 
			// btnEditDeptypeSave
			// 
			this.btnEditDeptypeSave.Location = new System.Drawing.Point(201, 40);
			this.btnEditDeptypeSave.Name = "btnEditDeptypeSave";
			this.btnEditDeptypeSave.Size = new System.Drawing.Size(75, 23);
			this.btnEditDeptypeSave.TabIndex = 3;
			this.btnEditDeptypeSave.Text = "Сохранить";
			this.btnEditDeptypeSave.UseVisualStyleBackColor = true;
			this.btnEditDeptypeSave.Click += new System.EventHandler(this.BtnEditDeptypeSaveClick);
			// 
			// lbEditIDDeptype
			// 
			this.lbEditIDDeptype.Location = new System.Drawing.Point(12, 35);
			this.lbEditIDDeptype.Name = "lbEditIDDeptype";
			this.lbEditIDDeptype.Size = new System.Drawing.Size(29, 23);
			this.lbEditIDDeptype.TabIndex = 2;
			this.lbEditIDDeptype.Text = "0";
			// 
			// txEditDeptypeName
			// 
			this.txEditDeptypeName.Location = new System.Drawing.Point(145, 14);
			this.txEditDeptypeName.Name = "txEditDeptypeName";
			this.txEditDeptypeName.Size = new System.Drawing.Size(131, 20);
			this.txEditDeptypeName.TabIndex = 1;
			// 
			// lbEditDeptypeName
			// 
			this.lbEditDeptypeName.Location = new System.Drawing.Point(12, 14);
			this.lbEditDeptypeName.Name = "lbEditDeptypeName";
			this.lbEditDeptypeName.Size = new System.Drawing.Size(127, 23);
			this.lbEditDeptypeName.TabIndex = 0;
			this.lbEditDeptypeName.Text = "Тип подразделения";
			// 
			// tpPart
			// 
			this.tpPart.BackColor = System.Drawing.Color.YellowGreen;
			this.tpPart.Controls.Add(this.lbEditIDPart);
			this.tpPart.Controls.Add(this.btnEditPartNew);
			this.tpPart.Controls.Add(this.btnEditPartDelete);
			this.tpPart.Controls.Add(this.btnEditPartSave);
			this.tpPart.Controls.Add(this.lsbEditPartList);
			this.tpPart.Controls.Add(this.txEditPartName);
			this.tpPart.Controls.Add(this.lbEditPartName);
			this.tpPart.Location = new System.Drawing.Point(4, 22);
			this.tpPart.Name = "tpPart";
			this.tpPart.Size = new System.Drawing.Size(292, 174);
			this.tpPart.TabIndex = 7;
			this.tpPart.Text = "Военчасть";
			// 
			// lbEditIDPart
			// 
			this.lbEditIDPart.Location = new System.Drawing.Point(19, 47);
			this.lbEditIDPart.Name = "lbEditIDPart";
			this.lbEditIDPart.Size = new System.Drawing.Size(14, 23);
			this.lbEditIDPart.TabIndex = 6;
			this.lbEditIDPart.Text = "0";
			// 
			// btnEditPartNew
			// 
			this.btnEditPartNew.Location = new System.Drawing.Point(39, 46);
			this.btnEditPartNew.Name = "btnEditPartNew";
			this.btnEditPartNew.Size = new System.Drawing.Size(75, 23);
			this.btnEditPartNew.TabIndex = 5;
			this.btnEditPartNew.Text = "Новая";
			this.btnEditPartNew.UseVisualStyleBackColor = true;
			this.btnEditPartNew.Click += new System.EventHandler(this.BtnEditPartNewClick);
			// 
			// btnEditPartDelete
			// 
			this.btnEditPartDelete.Location = new System.Drawing.Point(120, 46);
			this.btnEditPartDelete.Name = "btnEditPartDelete";
			this.btnEditPartDelete.Size = new System.Drawing.Size(75, 23);
			this.btnEditPartDelete.TabIndex = 4;
			this.btnEditPartDelete.Text = "Удалить";
			this.btnEditPartDelete.UseVisualStyleBackColor = true;
			this.btnEditPartDelete.Click += new System.EventHandler(this.BtnEditPartDeleteClick);
			// 
			// btnEditPartSave
			// 
			this.btnEditPartSave.Location = new System.Drawing.Point(201, 46);
			this.btnEditPartSave.Name = "btnEditPartSave";
			this.btnEditPartSave.Size = new System.Drawing.Size(75, 23);
			this.btnEditPartSave.TabIndex = 3;
			this.btnEditPartSave.Text = "Сохранить";
			this.btnEditPartSave.UseVisualStyleBackColor = true;
			this.btnEditPartSave.Click += new System.EventHandler(this.BtnEditPartSaveClick);
			// 
			// lsbEditPartList
			// 
			this.lsbEditPartList.FormattingEnabled = true;
			this.lsbEditPartList.Location = new System.Drawing.Point(16, 98);
			this.lsbEditPartList.Name = "lsbEditPartList";
			this.lsbEditPartList.Size = new System.Drawing.Size(260, 95);
			this.lsbEditPartList.TabIndex = 2;
			this.lsbEditPartList.SelectedIndexChanged += new System.EventHandler(this.LsbEditPartListSelectedIndexChanged);
			// 
			// txEditPartName
			// 
			this.txEditPartName.Location = new System.Drawing.Point(176, 20);
			this.txEditPartName.Name = "txEditPartName";
			this.txEditPartName.Size = new System.Drawing.Size(100, 20);
			this.txEditPartName.TabIndex = 1;
			// 
			// lbEditPartName
			// 
			this.lbEditPartName.Location = new System.Drawing.Point(16, 20);
			this.lbEditPartName.Name = "lbEditPartName";
			this.lbEditPartName.Size = new System.Drawing.Size(148, 23);
			this.lbEditPartName.TabIndex = 0;
			this.lbEditPartName.Text = "Название воинской части";
			// 
			// tcDep
			// 
			this.tcDep.Controls.Add(this.tpDepToDep);
			this.tcDep.Controls.Add(this.tpDepFromDep);
			this.tcDep.Location = new System.Drawing.Point(600, 10);
			this.tcDep.Name = "tcDep";
			this.tcDep.SelectedIndex = 0;
			this.tcDep.Size = new System.Drawing.Size(300, 200);
			this.tcDep.TabIndex = 3;
			// 
			// tpDepToDep
			// 
			this.tpDepToDep.BackColor = System.Drawing.Color.SkyBlue;
			this.tpDepToDep.Controls.Add(this.dgvDepToDepChoicedProds);
			this.tpDepToDep.Controls.Add(this.btnDepToDepSave);
			this.tpDepToDep.Controls.Add(this.btnDepToDepChoice);
			this.tpDepToDep.Controls.Add(this.txDepToDepPrice);
			this.tpDepToDep.Controls.Add(this.lbDepToDepPrice);
			this.tpDepToDep.Controls.Add(this.txDepToDepInvNum);
			this.tpDepToDep.Controls.Add(this.lbDepToDepInvNum);
			this.tpDepToDep.Controls.Add(this.txDepToDepProdCount);
			this.tpDepToDep.Controls.Add(this.lbDepToDepProdCount);
			this.tpDepToDep.Controls.Add(this.lsbDepToDepProdTypes);
			this.tpDepToDep.Controls.Add(this.lbDepToDepProdTypes);
			this.tpDepToDep.Controls.Add(this.txDepToDepFind);
			this.tpDepToDep.Controls.Add(this.lbDepToDepFind);
			this.tpDepToDep.Controls.Add(this.cbDepToDep_FromName);
			this.tpDepToDep.Controls.Add(this.lbDepToDep_FromName);
			this.tpDepToDep.Controls.Add(this.rbDepToDep_FromDep);
			this.tpDepToDep.Controls.Add(this.rbDepToDep_FromPart);
			this.tpDepToDep.Controls.Add(this.cbDepToDep_Cat);
			this.tpDepToDep.Controls.Add(this.lbDepToDep_Cat);
			this.tpDepToDep.Location = new System.Drawing.Point(4, 22);
			this.tpDepToDep.Name = "tpDepToDep";
			this.tpDepToDep.Padding = new System.Windows.Forms.Padding(3);
			this.tpDepToDep.Size = new System.Drawing.Size(292, 174);
			this.tpDepToDep.TabIndex = 2;
			this.tpDepToDep.Text = "Приход в подразделение";
			// 
			// dgvDepToDepChoicedProds
			// 
			this.dgvDepToDepChoicedProds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDepToDepChoicedProds.Location = new System.Drawing.Point(14, 376);
			this.dgvDepToDepChoicedProds.Name = "dgvDepToDepChoicedProds";
			this.dgvDepToDepChoicedProds.Size = new System.Drawing.Size(276, 150);
			this.dgvDepToDepChoicedProds.TabIndex = 19;
			// 
			// btnDepToDepSave
			// 
			this.btnDepToDepSave.Location = new System.Drawing.Point(215, 347);
			this.btnDepToDepSave.Name = "btnDepToDepSave";
			this.btnDepToDepSave.Size = new System.Drawing.Size(75, 23);
			this.btnDepToDepSave.TabIndex = 18;
			this.btnDepToDepSave.Text = "Сохранить";
			this.btnDepToDepSave.UseVisualStyleBackColor = true;
			// 
			// btnDepToDepChoice
			// 
			this.btnDepToDepChoice.Location = new System.Drawing.Point(170, 301);
			this.btnDepToDepChoice.Name = "btnDepToDepChoice";
			this.btnDepToDepChoice.Size = new System.Drawing.Size(75, 23);
			this.btnDepToDepChoice.TabIndex = 16;
			this.btnDepToDepChoice.Text = "Выбрать";
			this.btnDepToDepChoice.UseVisualStyleBackColor = true;
			// 
			// txDepToDepPrice
			// 
			this.txDepToDepPrice.Location = new System.Drawing.Point(154, 261);
			this.txDepToDepPrice.Name = "txDepToDepPrice";
			this.txDepToDepPrice.Size = new System.Drawing.Size(100, 20);
			this.txDepToDepPrice.TabIndex = 15;
			// 
			// lbDepToDepPrice
			// 
			this.lbDepToDepPrice.Location = new System.Drawing.Point(154, 238);
			this.lbDepToDepPrice.Name = "lbDepToDepPrice";
			this.lbDepToDepPrice.Size = new System.Drawing.Size(100, 23);
			this.lbDepToDepPrice.TabIndex = 14;
			this.lbDepToDepPrice.Text = "Цена";
			// 
			// txDepToDepInvNum
			// 
			this.txDepToDepInvNum.Location = new System.Drawing.Point(154, 206);
			this.txDepToDepInvNum.Name = "txDepToDepInvNum";
			this.txDepToDepInvNum.Size = new System.Drawing.Size(100, 20);
			this.txDepToDepInvNum.TabIndex = 13;
			// 
			// lbDepToDepInvNum
			// 
			this.lbDepToDepInvNum.Location = new System.Drawing.Point(154, 186);
			this.lbDepToDepInvNum.Name = "lbDepToDepInvNum";
			this.lbDepToDepInvNum.Size = new System.Drawing.Size(100, 23);
			this.lbDepToDepInvNum.TabIndex = 12;
			this.lbDepToDepInvNum.Text = "Инв номер";
			// 
			// txDepToDepProdCount
			// 
			this.txDepToDepProdCount.Location = new System.Drawing.Point(154, 157);
			this.txDepToDepProdCount.Name = "txDepToDepProdCount";
			this.txDepToDepProdCount.Size = new System.Drawing.Size(100, 20);
			this.txDepToDepProdCount.TabIndex = 11;
			// 
			// lbDepToDepProdCount
			// 
			this.lbDepToDepProdCount.Location = new System.Drawing.Point(154, 133);
			this.lbDepToDepProdCount.Name = "lbDepToDepProdCount";
			this.lbDepToDepProdCount.Size = new System.Drawing.Size(100, 20);
			this.lbDepToDepProdCount.TabIndex = 10;
			this.lbDepToDepProdCount.Text = "Количество";
			// 
			// lsbDepToDepProdTypes
			// 
			this.lsbDepToDepProdTypes.FormattingEnabled = true;
			this.lsbDepToDepProdTypes.Location = new System.Drawing.Point(14, 219);
			this.lsbDepToDepProdTypes.Name = "lsbDepToDepProdTypes";
			this.lsbDepToDepProdTypes.Size = new System.Drawing.Size(120, 108);
			this.lsbDepToDepProdTypes.TabIndex = 9;
			// 
			// lbDepToDepProdTypes
			// 
			this.lbDepToDepProdTypes.Location = new System.Drawing.Point(16, 193);
			this.lbDepToDepProdTypes.Name = "lbDepToDepProdTypes";
			this.lbDepToDepProdTypes.Size = new System.Drawing.Size(100, 23);
			this.lbDepToDepProdTypes.TabIndex = 8;
			this.lbDepToDepProdTypes.Text = "Виды ценностей";
			// 
			// txDepToDepFind
			// 
			this.txDepToDepFind.Location = new System.Drawing.Point(16, 158);
			this.txDepToDepFind.Name = "txDepToDepFind";
			this.txDepToDepFind.Size = new System.Drawing.Size(118, 20);
			this.txDepToDepFind.TabIndex = 7;
			// 
			// lbDepToDepFind
			// 
			this.lbDepToDepFind.Location = new System.Drawing.Point(14, 133);
			this.lbDepToDepFind.Name = "lbDepToDepFind";
			this.lbDepToDepFind.Size = new System.Drawing.Size(100, 23);
			this.lbDepToDepFind.TabIndex = 6;
			this.lbDepToDepFind.Text = "Найти";
			// 
			// cbDepToDep_FromName
			// 
			this.cbDepToDep_FromName.FormattingEnabled = true;
			this.cbDepToDep_FromName.Location = new System.Drawing.Point(133, 94);
			this.cbDepToDep_FromName.Name = "cbDepToDep_FromName";
			this.cbDepToDep_FromName.Size = new System.Drawing.Size(121, 21);
			this.cbDepToDep_FromName.TabIndex = 5;
			// 
			// lbDepToDep_FromName
			// 
			this.lbDepToDep_FromName.Location = new System.Drawing.Point(16, 97);
			this.lbDepToDep_FromName.Name = "lbDepToDep_FromName";
			this.lbDepToDep_FromName.Size = new System.Drawing.Size(100, 23);
			this.lbDepToDep_FromName.TabIndex = 4;
			this.lbDepToDep_FromName.Text = "Откуда";
			// 
			// rbDepToDep_FromDep
			// 
			this.rbDepToDep_FromDep.Location = new System.Drawing.Point(150, 52);
			this.rbDepToDep_FromDep.Name = "rbDepToDep_FromDep";
			this.rbDepToDep_FromDep.Size = new System.Drawing.Size(104, 24);
			this.rbDepToDep_FromDep.TabIndex = 3;
			this.rbDepToDep_FromDep.TabStop = true;
			this.rbDepToDep_FromDep.Text = "Внутреннее";
			this.rbDepToDep_FromDep.UseVisualStyleBackColor = true;
			// 
			// rbDepToDep_FromPart
			// 
			this.rbDepToDep_FromPart.Location = new System.Drawing.Point(14, 55);
			this.rbDepToDep_FromPart.Name = "rbDepToDep_FromPart";
			this.rbDepToDep_FromPart.Size = new System.Drawing.Size(104, 24);
			this.rbDepToDep_FromPart.TabIndex = 2;
			this.rbDepToDep_FromPart.TabStop = true;
			this.rbDepToDep_FromPart.Text = "С др частей";
			this.rbDepToDep_FromPart.UseVisualStyleBackColor = true;
			// 
			// cbDepToDep_Cat
			// 
			this.cbDepToDep_Cat.FormattingEnabled = true;
			this.cbDepToDep_Cat.Location = new System.Drawing.Point(133, 19);
			this.cbDepToDep_Cat.Name = "cbDepToDep_Cat";
			this.cbDepToDep_Cat.Size = new System.Drawing.Size(121, 21);
			this.cbDepToDep_Cat.TabIndex = 1;
			// 
			// lbDepToDep_Cat
			// 
			this.lbDepToDep_Cat.Location = new System.Drawing.Point(14, 17);
			this.lbDepToDep_Cat.Name = "lbDepToDep_Cat";
			this.lbDepToDep_Cat.Size = new System.Drawing.Size(100, 23);
			this.lbDepToDep_Cat.TabIndex = 0;
			this.lbDepToDep_Cat.Text = "Категория";
			// 
			// tpDepFromDep
			// 
			this.tpDepFromDep.BackColor = System.Drawing.Color.SkyBlue;
			this.tpDepFromDep.Location = new System.Drawing.Point(4, 22);
			this.tpDepFromDep.Name = "tpDepFromDep";
			this.tpDepFromDep.Padding = new System.Windows.Forms.Padding(3);
			this.tpDepFromDep.Size = new System.Drawing.Size(292, 174);
			this.tpDepFromDep.TabIndex = 1;
			this.tpDepFromDep.Text = "Выдача с подразделенрия";
			// 
			// tpUseToDep
			// 
			this.tpUseToDep.BackColor = System.Drawing.Color.AntiqueWhite;
			this.tpUseToDep.Controls.Add(this.cbUseToDepCat);
			this.tpUseToDep.Controls.Add(this.lbUseToDepCat);
			this.tpUseToDep.Location = new System.Drawing.Point(4, 22);
			this.tpUseToDep.Name = "tpUseToDep";
			this.tpUseToDep.Padding = new System.Windows.Forms.Padding(3);
			this.tpUseToDep.Size = new System.Drawing.Size(292, 174);
			this.tpUseToDep.TabIndex = 0;
			this.tpUseToDep.Text = "Возврат в подразделение";
			// 
			// cbUseToDepCat
			// 
			this.cbUseToDepCat.FormattingEnabled = true;
			this.cbUseToDepCat.Location = new System.Drawing.Point(112, 14);
			this.cbUseToDepCat.Name = "cbUseToDepCat";
			this.cbUseToDepCat.Size = new System.Drawing.Size(121, 21);
			this.cbUseToDepCat.TabIndex = 1;
			// 
			// lbUseToDepCat
			// 
			this.lbUseToDepCat.Location = new System.Drawing.Point(6, 17);
			this.lbUseToDepCat.Name = "lbUseToDepCat";
			this.lbUseToDepCat.Size = new System.Drawing.Size(100, 23);
			this.lbUseToDepCat.TabIndex = 0;
			this.lbUseToDepCat.Text = "Категория";
			// 
			// tcUse
			// 
			this.tcUse.Controls.Add(this.tpUseToDep);
			this.tcUse.Controls.Add(this.tpUseToUse);
			this.tcUse.Controls.Add(this.tpUseToWH);
			this.tcUse.Location = new System.Drawing.Point(600, 250);
			this.tcUse.Name = "tcUse";
			this.tcUse.SelectedIndex = 0;
			this.tcUse.Size = new System.Drawing.Size(300, 200);
			this.tcUse.TabIndex = 2;
			// 
			// tpUseToUse
			// 
			this.tpUseToUse.BackColor = System.Drawing.Color.AntiqueWhite;
			this.tpUseToUse.Location = new System.Drawing.Point(4, 22);
			this.tpUseToUse.Name = "tpUseToUse";
			this.tpUseToUse.Padding = new System.Windows.Forms.Padding(3);
			this.tpUseToUse.Size = new System.Drawing.Size(292, 174);
			this.tpUseToUse.TabIndex = 0;
			this.tpUseToUse.Text = "На личное пользование";
			// 
			// tpUseToWH
			// 
			this.tpUseToWH.BackColor = System.Drawing.Color.AntiqueWhite;
			this.tpUseToWH.Location = new System.Drawing.Point(4, 22);
			this.tpUseToWH.Name = "tpUseToWH";
			this.tpUseToWH.Padding = new System.Windows.Forms.Padding(3);
			this.tpUseToWH.Size = new System.Drawing.Size(292, 174);
			this.tpUseToWH.TabIndex = 1;
			this.tpUseToWH.Text = "Возврат на склад";
			// 
			// tcWH
			// 
			this.tcWH.Controls.Add(this.tpToWH);
			this.tcWH.Controls.Add(this.tpFromWH);
			this.tcWH.Controls.Add(this.tpWHWriteoff);
			this.tcWH.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcWH.Location = new System.Drawing.Point(157, 0);
			this.tcWH.Name = "tcWH";
			this.tcWH.SelectedIndex = 0;
			this.tcWH.Size = new System.Drawing.Size(966, 562);
			this.tcWH.TabIndex = 4;
			// 
			// tpToWH
			// 
			this.tpToWH.AutoScroll = true;
			this.tpToWH.BackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.tpToWH.Controls.Add(this.scToWH);
			this.tpToWH.Location = new System.Drawing.Point(4, 22);
			this.tpToWH.Name = "tpToWH";
			this.tpToWH.Padding = new System.Windows.Forms.Padding(3);
			this.tpToWH.Size = new System.Drawing.Size(958, 536);
			this.tpToWH.TabIndex = 1;
			this.tpToWH.Text = "Приход на склад";
			// 
			// scToWH
			// 
			this.scToWH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.scToWH.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scToWH.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.scToWH.Location = new System.Drawing.Point(3, 3);
			this.scToWH.Name = "scToWH";
			this.scToWH.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// scToWH.Panel1
			// 
			this.scToWH.Panel1.AutoScroll = true;
			this.scToWH.Panel1.Controls.Add(this.lbToWHCat);
			this.scToWH.Panel1.Controls.Add(this.udToWHProdCount);
			this.scToWH.Panel1.Controls.Add(this.rbToWHFromPart);
			this.scToWH.Panel1.Controls.Add(this.mtxToWHPrice);
			this.scToWH.Panel1.Controls.Add(this.rbToWHFromDep);
			this.scToWH.Panel1.Controls.Add(this.dtpToWHActDate);
			this.scToWH.Panel1.Controls.Add(this.lbToWHFromName);
			this.scToWH.Panel1.Controls.Add(this.lbToWHActDate);
			this.scToWH.Panel1.Controls.Add(this.lsbToWHProdtypes);
			this.scToWH.Panel1.Controls.Add(this.lbToWHActNum);
			this.scToWH.Panel1.Controls.Add(this.txToWHFindProd);
			this.scToWH.Panel1.Controls.Add(this.txToWHActNum);
			this.scToWH.Panel1.Controls.Add(this.lbToWHFromIDDep);
			this.scToWH.Panel1.Controls.Add(this.lbToWHProdtypes);
			this.scToWH.Panel1.Controls.Add(this.lbToWHIDCat);
			this.scToWH.Panel1.Controls.Add(this.lbToWHProdCount);
			this.scToWH.Panel1.Controls.Add(this.cbToWHCat);
			this.scToWH.Panel1.Controls.Add(this.lbToWHInvNum);
			this.scToWH.Panel1.Controls.Add(this.cbToWHFromName);
			this.scToWH.Panel1.Controls.Add(this.txToWHInvNum);
			this.scToWH.Panel1.Controls.Add(this.btnToWHChoiceProd);
			this.scToWH.Panel1.Controls.Add(this.lbToWHPrice);
			// 
			// scToWH.Panel2
			// 
			this.scToWH.Panel2.AutoScroll = true;
			this.scToWH.Panel2.Controls.Add(this.scToWHChoicedList);
			this.scToWH.Size = new System.Drawing.Size(952, 530);
			this.scToWH.SplitterDistance = 306;
			this.scToWH.TabIndex = 46;
			// 
			// lbToWHCat
			// 
			this.lbToWHCat.Location = new System.Drawing.Point(10, 10);
			this.lbToWHCat.Name = "lbToWHCat";
			this.lbToWHCat.Size = new System.Drawing.Size(120, 23);
			this.lbToWHCat.TabIndex = 33;
			this.lbToWHCat.Text = "Категория";
			// 
			// udToWHProdCount
			// 
			this.udToWHProdCount.AllowDrop = true;
			this.udToWHProdCount.Items.Add("0");
			this.udToWHProdCount.Location = new System.Drawing.Point(262, 130);
			this.udToWHProdCount.Name = "udToWHProdCount";
			this.udToWHProdCount.Size = new System.Drawing.Size(120, 20);
			this.udToWHProdCount.TabIndex = 45;
			this.udToWHProdCount.Text = "0";
			this.udToWHProdCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UdToWHProdCountKeyPress);
			// 
			// rbToWHFromPart
			// 
			this.rbToWHFromPart.AccessibleName = "";
			this.rbToWHFromPart.Location = new System.Drawing.Point(341, 10);
			this.rbToWHFromPart.Name = "rbToWHFromPart";
			this.rbToWHFromPart.Size = new System.Drawing.Size(122, 24);
			this.rbToWHFromPart.TabIndex = 17;
			this.rbToWHFromPart.Tag = "";
			this.rbToWHFromPart.Text = "С других частей";
			this.rbToWHFromPart.UseVisualStyleBackColor = true;
			this.rbToWHFromPart.CheckedChanged += new System.EventHandler(this.RbToWHFromPartCheckedChanged);
			// 
			// mtxToWHPrice
			// 
			this.mtxToWHPrice.Location = new System.Drawing.Point(262, 175);
			this.mtxToWHPrice.Mask = "000000000";
			this.mtxToWHPrice.Name = "mtxToWHPrice";
			this.mtxToWHPrice.PromptChar = ' ';
			this.mtxToWHPrice.Size = new System.Drawing.Size(100, 20);
			this.mtxToWHPrice.TabIndex = 44;
			this.mtxToWHPrice.Text = "0";
			this.mtxToWHPrice.ValidatingType = typeof(int);
			// 
			// rbToWHFromDep
			// 
			this.rbToWHFromDep.AccessibleName = "";
			this.rbToWHFromDep.Checked = true;
			this.rbToWHFromDep.Location = new System.Drawing.Point(481, 10);
			this.rbToWHFromDep.Name = "rbToWHFromDep";
			this.rbToWHFromDep.Size = new System.Drawing.Size(185, 24);
			this.rbToWHFromDep.TabIndex = 18;
			this.rbToWHFromDep.TabStop = true;
			this.rbToWHFromDep.Tag = "";
			this.rbToWHFromDep.Text = "Внутренние перемещения";
			this.rbToWHFromDep.UseVisualStyleBackColor = true;
			this.rbToWHFromDep.CheckedChanged += new System.EventHandler(this.RbToWHFromPartCheckedChanged);
			// 
			// dtpToWHActDate
			// 
			this.dtpToWHActDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpToWHActDate.Location = new System.Drawing.Point(136, 75);
			this.dtpToWHActDate.Name = "dtpToWHActDate";
			this.dtpToWHActDate.Size = new System.Drawing.Size(120, 20);
			this.dtpToWHActDate.TabIndex = 42;
			// 
			// lbToWHFromName
			// 
			this.lbToWHFromName.Location = new System.Drawing.Point(341, 45);
			this.lbToWHFromName.Name = "lbToWHFromName";
			this.lbToWHFromName.Size = new System.Drawing.Size(75, 23);
			this.lbToWHFromName.TabIndex = 19;
			this.lbToWHFromName.Text = "Откуда";
			// 
			// lbToWHActDate
			// 
			this.lbToWHActDate.Location = new System.Drawing.Point(10, 75);
			this.lbToWHActDate.Name = "lbToWHActDate";
			this.lbToWHActDate.Size = new System.Drawing.Size(120, 23);
			this.lbToWHActDate.TabIndex = 41;
			this.lbToWHActDate.Text = "Дата документа";
			// 
			// lsbToWHProdtypes
			// 
			this.lsbToWHProdtypes.FormattingEnabled = true;
			this.lsbToWHProdtypes.HorizontalScrollbar = true;
			this.lsbToWHProdtypes.Location = new System.Drawing.Point(10, 155);
			this.lsbToWHProdtypes.Name = "lsbToWHProdtypes";
			this.lsbToWHProdtypes.ScrollAlwaysVisible = true;
			this.lsbToWHProdtypes.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.lsbToWHProdtypes.Size = new System.Drawing.Size(246, 134);
			this.lsbToWHProdtypes.TabIndex = 20;
			this.lsbToWHProdtypes.SelectedIndexChanged += new System.EventHandler(this.LsbToWHProdtypesSelectedIndexChanged);
			// 
			// lbToWHActNum
			// 
			this.lbToWHActNum.Location = new System.Drawing.Point(10, 45);
			this.lbToWHActNum.Name = "lbToWHActNum";
			this.lbToWHActNum.Size = new System.Drawing.Size(120, 23);
			this.lbToWHActNum.TabIndex = 40;
			this.lbToWHActNum.Text = "Номер документа";
			// 
			// txToWHFindProd
			// 
			this.txToWHFindProd.Location = new System.Drawing.Point(10, 130);
			this.txToWHFindProd.Name = "txToWHFindProd";
			this.txToWHFindProd.Size = new System.Drawing.Size(246, 20);
			this.txToWHFindProd.TabIndex = 21;
			this.txToWHFindProd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxToWHFindProdKeyUp);
			// 
			// txToWHActNum
			// 
			this.txToWHActNum.Location = new System.Drawing.Point(136, 45);
			this.txToWHActNum.Name = "txToWHActNum";
			this.txToWHActNum.Size = new System.Drawing.Size(120, 20);
			this.txToWHActNum.TabIndex = 39;
			// 
			// lbToWHFromIDDep
			// 
			this.lbToWHFromIDDep.Location = new System.Drawing.Point(709, 45);
			this.lbToWHFromIDDep.Name = "lbToWHFromIDDep";
			this.lbToWHFromIDDep.Size = new System.Drawing.Size(32, 23);
			this.lbToWHFromIDDep.TabIndex = 37;
			this.lbToWHFromIDDep.Text = "0";
			// 
			// lbToWHProdtypes
			// 
			this.lbToWHProdtypes.Location = new System.Drawing.Point(10, 110);
			this.lbToWHProdtypes.Name = "lbToWHProdtypes";
			this.lbToWHProdtypes.Size = new System.Drawing.Size(120, 23);
			this.lbToWHProdtypes.TabIndex = 23;
			this.lbToWHProdtypes.Text = "Виды предметов";
			// 
			// lbToWHIDCat
			// 
			this.lbToWHIDCat.Location = new System.Drawing.Point(308, 10);
			this.lbToWHIDCat.Name = "lbToWHIDCat";
			this.lbToWHIDCat.Size = new System.Drawing.Size(32, 23);
			this.lbToWHIDCat.TabIndex = 36;
			this.lbToWHIDCat.Text = "0";
			// 
			// lbToWHProdCount
			// 
			this.lbToWHProdCount.Location = new System.Drawing.Point(262, 110);
			this.lbToWHProdCount.Name = "lbToWHProdCount";
			this.lbToWHProdCount.Size = new System.Drawing.Size(100, 23);
			this.lbToWHProdCount.TabIndex = 25;
			this.lbToWHProdCount.Text = "Количество";
			// 
			// cbToWHCat
			// 
			this.cbToWHCat.FormattingEnabled = true;
			this.cbToWHCat.Location = new System.Drawing.Point(136, 10);
			this.cbToWHCat.Name = "cbToWHCat";
			this.cbToWHCat.Size = new System.Drawing.Size(170, 21);
			this.cbToWHCat.TabIndex = 35;
			this.cbToWHCat.SelectedIndexChanged += new System.EventHandler(this.CbToWHCatSelectedIndexChanged);
			// 
			// lbToWHInvNum
			// 
			this.lbToWHInvNum.Location = new System.Drawing.Point(389, 110);
			this.lbToWHInvNum.Name = "lbToWHInvNum";
			this.lbToWHInvNum.Size = new System.Drawing.Size(100, 23);
			this.lbToWHInvNum.TabIndex = 26;
			this.lbToWHInvNum.Text = "Инв. номер:";
			// 
			// cbToWHFromName
			// 
			this.cbToWHFromName.FormattingEnabled = true;
			this.cbToWHFromName.Location = new System.Drawing.Point(422, 45);
			this.cbToWHFromName.Name = "cbToWHFromName";
			this.cbToWHFromName.Size = new System.Drawing.Size(282, 21);
			this.cbToWHFromName.TabIndex = 34;
			this.cbToWHFromName.SelectedIndexChanged += new System.EventHandler(this.CbToWHFromNameSelectedIndexChanged);
			// 
			// txToWHInvNum
			// 
			this.txToWHInvNum.Location = new System.Drawing.Point(389, 130);
			this.txToWHInvNum.Name = "txToWHInvNum";
			this.txToWHInvNum.Size = new System.Drawing.Size(100, 20);
			this.txToWHInvNum.TabIndex = 27;
			// 
			// btnToWHChoiceProd
			// 
			this.btnToWHChoiceProd.Location = new System.Drawing.Point(262, 209);
			this.btnToWHChoiceProd.Name = "btnToWHChoiceProd";
			this.btnToWHChoiceProd.Size = new System.Drawing.Size(100, 23);
			this.btnToWHChoiceProd.TabIndex = 28;
			this.btnToWHChoiceProd.Text = "Выбрать ->";
			this.btnToWHChoiceProd.UseVisualStyleBackColor = true;
			this.btnToWHChoiceProd.Click += new System.EventHandler(this.BtnToWHChoiceProdClick);
			// 
			// lbToWHPrice
			// 
			this.lbToWHPrice.Location = new System.Drawing.Point(262, 155);
			this.lbToWHPrice.Name = "lbToWHPrice";
			this.lbToWHPrice.Size = new System.Drawing.Size(100, 23);
			this.lbToWHPrice.TabIndex = 31;
			this.lbToWHPrice.Text = "Цена";
			// 
			// scToWHChoicedList
			// 
			this.scToWHChoicedList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.scToWHChoicedList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scToWHChoicedList.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.scToWHChoicedList.Location = new System.Drawing.Point(0, 0);
			this.scToWHChoicedList.Name = "scToWHChoicedList";
			this.scToWHChoicedList.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// scToWHChoicedList.Panel1
			// 
			this.scToWHChoicedList.Panel1.AutoScroll = true;
			this.scToWHChoicedList.Panel1.BackColor = System.Drawing.Color.Beige;
			this.scToWHChoicedList.Panel1.Controls.Add(this.label1);
			this.scToWHChoicedList.Panel1.Controls.Add(this.maskedTextBox2);
			this.scToWHChoicedList.Panel1.Controls.Add(this.maskedTextBox1);
			this.scToWHChoicedList.Panel1.Controls.Add(this.rbToWHFindPrice);
			this.scToWHChoicedList.Panel1.Controls.Add(this.rbToWHFindProd);
			this.scToWHChoicedList.Panel1.Controls.Add(this.textBox1);
			this.scToWHChoicedList.Panel1.Controls.Add(this.lbToWHFindInDB);
			this.scToWHChoicedList.Panel1.Controls.Add(this.BtnToWHChoiceDel);
			this.scToWHChoicedList.Panel1.Controls.Add(this.btnToWHChoiceSave);
			// 
			// scToWHChoicedList.Panel2
			// 
			this.scToWHChoicedList.Panel2.AutoScroll = true;
			this.scToWHChoicedList.Panel2.Controls.Add(this.dgvToWHChoicedProds);
			this.scToWHChoicedList.Size = new System.Drawing.Size(952, 220);
			this.scToWHChoicedList.SplitterDistance = 128;
			this.scToWHChoicedList.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(154, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(15, 21);
			this.label1.TabIndex = 46;
			this.label1.Text = "...";
			// 
			// maskedTextBox2
			// 
			this.maskedTextBox2.Location = new System.Drawing.Point(171, 35);
			this.maskedTextBox2.Name = "maskedTextBox2";
			this.maskedTextBox2.Size = new System.Drawing.Size(85, 20);
			this.maskedTextBox2.TabIndex = 45;
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(68, 35);
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(85, 20);
			this.maskedTextBox1.TabIndex = 44;
			// 
			// rbToWHFindPrice
			// 
			this.rbToWHFindPrice.Location = new System.Drawing.Point(262, 35);
			this.rbToWHFindPrice.Name = "rbToWHFindPrice";
			this.rbToWHFindPrice.Size = new System.Drawing.Size(104, 24);
			this.rbToWHFindPrice.TabIndex = 43;
			this.rbToWHFindPrice.TabStop = true;
			this.rbToWHFindPrice.Text = "по цене";
			this.rbToWHFindPrice.UseVisualStyleBackColor = true;
			// 
			// rbToWHFindProd
			// 
			this.rbToWHFindProd.Location = new System.Drawing.Point(262, 10);
			this.rbToWHFindProd.Name = "rbToWHFindProd";
			this.rbToWHFindProd.Size = new System.Drawing.Size(104, 24);
			this.rbToWHFindProd.TabIndex = 42;
			this.rbToWHFindProd.TabStop = true;
			this.rbToWHFindProd.Text = "по предмету";
			this.rbToWHFindProd.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(68, 10);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(188, 20);
			this.textBox1.TabIndex = 41;
			// 
			// lbToWHFindInDB
			// 
			this.lbToWHFindInDB.Location = new System.Drawing.Point(10, 10);
			this.lbToWHFindInDB.Name = "lbToWHFindInDB";
			this.lbToWHFindInDB.Size = new System.Drawing.Size(52, 23);
			this.lbToWHFindInDB.TabIndex = 40;
			this.lbToWHFindInDB.Text = "Найти";
			// 
			// BtnToWHChoiceDel
			// 
			this.BtnToWHChoiceDel.Location = new System.Drawing.Point(115, 91);
			this.BtnToWHChoiceDel.Name = "BtnToWHChoiceDel";
			this.BtnToWHChoiceDel.Size = new System.Drawing.Size(141, 23);
			this.BtnToWHChoiceDel.TabIndex = 39;
			this.BtnToWHChoiceDel.Text = "Убрать выделенные";
			this.BtnToWHChoiceDel.UseVisualStyleBackColor = true;
			this.BtnToWHChoiceDel.Click += new System.EventHandler(this.BtnToWHChoiceDelClick);
			// 
			// btnToWHChoiceSave
			// 
			this.btnToWHChoiceSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnToWHChoiceSave.Location = new System.Drawing.Point(10, 91);
			this.btnToWHChoiceSave.Name = "btnToWHChoiceSave";
			this.btnToWHChoiceSave.Size = new System.Drawing.Size(100, 23);
			this.btnToWHChoiceSave.TabIndex = 38;
			this.btnToWHChoiceSave.Text = "Сохранить";
			this.btnToWHChoiceSave.UseVisualStyleBackColor = true;
			this.btnToWHChoiceSave.Click += new System.EventHandler(this.BtnToWHChoiceSaveClick);
			// 
			// dgvToWHChoicedProds
			// 
			this.dgvToWHChoicedProds.BackgroundColor = System.Drawing.Color.White;
			this.dgvToWHChoicedProds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvToWHChoicedProds.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvToWHChoicedProds.Location = new System.Drawing.Point(0, 0);
			this.dgvToWHChoicedProds.Name = "dgvToWHChoicedProds";
			this.dgvToWHChoicedProds.Size = new System.Drawing.Size(950, 86);
			this.dgvToWHChoicedProds.TabIndex = 43;
			// 
			// tpFromWH
			// 
			this.tpFromWH.BackColor = System.Drawing.Color.LightGoldenrodYellow;
			this.tpFromWH.Controls.Add(this.scFromWH);
			this.tpFromWH.Location = new System.Drawing.Point(4, 22);
			this.tpFromWH.Name = "tpFromWH";
			this.tpFromWH.Padding = new System.Windows.Forms.Padding(3);
			this.tpFromWH.Size = new System.Drawing.Size(292, 174);
			this.tpFromWH.TabIndex = 0;
			this.tpFromWH.Text = "Выдача со склада";
			// 
			// scFromWH
			// 
			this.scFromWH.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scFromWH.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.scFromWH.Location = new System.Drawing.Point(3, 3);
			this.scFromWH.Name = "scFromWH";
			this.scFromWH.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// scFromWH.Panel1
			// 
			this.scFromWH.Panel1.Controls.Add(this.lbFromWHCat);
			this.scFromWH.Panel1.Controls.Add(this.udFromWHProdCount);
			this.scFromWH.Panel1.Controls.Add(this.cbFromWHCat);
			this.scFromWH.Panel1.Controls.Add(this.mtxFromWHPrice);
			this.scFromWH.Panel1.Controls.Add(this.lbFromWHIDCat);
			this.scFromWH.Panel1.Controls.Add(this.rbFromWHtoPart);
			this.scFromWH.Panel1.Controls.Add(this.rbFromWHtoDep);
			this.scFromWH.Panel1.Controls.Add(this.dtpFromWHActDate);
			this.scFromWH.Panel1.Controls.Add(this.cbFromWHToDep);
			this.scFromWH.Panel1.Controls.Add(this.txFromWHActNum);
			this.scFromWH.Panel1.Controls.Add(this.lbFromWHToDep);
			this.scFromWH.Panel1.Controls.Add(this.lbFromWHActDate);
			this.scFromWH.Panel1.Controls.Add(this.lbFromWHToIDDep);
			this.scFromWH.Panel1.Controls.Add(this.lbFromWHActNum);
			this.scFromWH.Panel1.Controls.Add(this.btnFromWHChoiceProd);
			this.scFromWH.Panel1.Controls.Add(this.lbFromWHProdCount);
			this.scFromWH.Panel1.Controls.Add(this.lsbFromWHProdTypes);
			this.scFromWH.Panel1.Controls.Add(this.lbFromWHPrice);
			this.scFromWH.Panel1.Controls.Add(this.txFromWHFindProd);
			this.scFromWH.Panel1.Controls.Add(this.txFromWHInvNum);
			this.scFromWH.Panel1.Controls.Add(this.lbFromWHProdTypes);
			this.scFromWH.Panel1.Controls.Add(this.lbFromWHInvNum);
			// 
			// scFromWH.Panel2
			// 
			this.scFromWH.Panel2.Controls.Add(this.scFromWHChoicedList);
			this.scFromWH.Size = new System.Drawing.Size(286, 168);
			this.scFromWH.SplitterDistance = 301;
			this.scFromWH.TabIndex = 29;
			// 
			// lbFromWHCat
			// 
			this.lbFromWHCat.Location = new System.Drawing.Point(10, 10);
			this.lbFromWHCat.Name = "lbFromWHCat";
			this.lbFromWHCat.Size = new System.Drawing.Size(85, 23);
			this.lbFromWHCat.TabIndex = 0;
			this.lbFromWHCat.Text = "Категория";
			// 
			// udFromWHProdCount
			// 
			this.udFromWHProdCount.Items.Add("0");
			this.udFromWHProdCount.Items.Add("1");
			this.udFromWHProdCount.Items.Add("2");
			this.udFromWHProdCount.Items.Add("3");
			this.udFromWHProdCount.Items.Add("4");
			this.udFromWHProdCount.Items.Add("5");
			this.udFromWHProdCount.Items.Add("6");
			this.udFromWHProdCount.Items.Add("7");
			this.udFromWHProdCount.Items.Add("8");
			this.udFromWHProdCount.Items.Add("9");
			this.udFromWHProdCount.Items.Add("10");
			this.udFromWHProdCount.Items.Add("11");
			this.udFromWHProdCount.Location = new System.Drawing.Point(262, 130);
			this.udFromWHProdCount.Name = "udFromWHProdCount";
			this.udFromWHProdCount.Size = new System.Drawing.Size(120, 20);
			this.udFromWHProdCount.TabIndex = 28;
			this.udFromWHProdCount.Text = "0";
			// 
			// cbFromWHCat
			// 
			this.cbFromWHCat.FormattingEnabled = true;
			this.cbFromWHCat.Location = new System.Drawing.Point(136, 10);
			this.cbFromWHCat.Name = "cbFromWHCat";
			this.cbFromWHCat.Size = new System.Drawing.Size(170, 21);
			this.cbFromWHCat.TabIndex = 1;
			this.cbFromWHCat.SelectedIndexChanged += new System.EventHandler(this.CbFromWHCatSelectedIndexChanged);
			// 
			// mtxFromWHPrice
			// 
			this.mtxFromWHPrice.Location = new System.Drawing.Point(262, 175);
			this.mtxFromWHPrice.Mask = "000000000";
			this.mtxFromWHPrice.Name = "mtxFromWHPrice";
			this.mtxFromWHPrice.Size = new System.Drawing.Size(100, 20);
			this.mtxFromWHPrice.TabIndex = 27;
			// 
			// lbFromWHIDCat
			// 
			this.lbFromWHIDCat.Location = new System.Drawing.Point(308, 10);
			this.lbFromWHIDCat.Name = "lbFromWHIDCat";
			this.lbFromWHIDCat.Size = new System.Drawing.Size(32, 23);
			this.lbFromWHIDCat.TabIndex = 2;
			this.lbFromWHIDCat.Text = "0";
			// 
			// rbFromWHtoPart
			// 
			this.rbFromWHtoPart.Location = new System.Drawing.Point(341, 10);
			this.rbFromWHtoPart.Name = "rbFromWHtoPart";
			this.rbFromWHtoPart.Size = new System.Drawing.Size(121, 24);
			this.rbFromWHtoPart.TabIndex = 3;
			this.rbFromWHtoPart.TabStop = true;
			this.rbFromWHtoPart.Text = "На другие части";
			this.rbFromWHtoPart.UseVisualStyleBackColor = true;
			this.rbFromWHtoPart.CheckedChanged += new System.EventHandler(this.RbFromWHtoPartCheckedChanged);
			// 
			// rbFromWHtoDep
			// 
			this.rbFromWHtoDep.Checked = true;
			this.rbFromWHtoDep.Location = new System.Drawing.Point(481, 10);
			this.rbFromWHtoDep.Name = "rbFromWHtoDep";
			this.rbFromWHtoDep.Size = new System.Drawing.Size(162, 24);
			this.rbFromWHtoDep.TabIndex = 4;
			this.rbFromWHtoDep.TabStop = true;
			this.rbFromWHtoDep.Text = "Внутренние перемещения";
			this.rbFromWHtoDep.UseVisualStyleBackColor = true;
			this.rbFromWHtoDep.CheckedChanged += new System.EventHandler(this.RbFromWHtoPartCheckedChanged);
			// 
			// dtpFromWHActDate
			// 
			this.dtpFromWHActDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpFromWHActDate.Location = new System.Drawing.Point(136, 75);
			this.dtpFromWHActDate.Name = "dtpFromWHActDate";
			this.dtpFromWHActDate.Size = new System.Drawing.Size(120, 20);
			this.dtpFromWHActDate.TabIndex = 24;
			// 
			// cbFromWHToDep
			// 
			this.cbFromWHToDep.FormattingEnabled = true;
			this.cbFromWHToDep.Location = new System.Drawing.Point(422, 45);
			this.cbFromWHToDep.Name = "cbFromWHToDep";
			this.cbFromWHToDep.Size = new System.Drawing.Size(282, 21);
			this.cbFromWHToDep.TabIndex = 5;
			this.cbFromWHToDep.SelectedIndexChanged += new System.EventHandler(this.CbFromWHToDepSelectedIndexChanged);
			// 
			// txFromWHActNum
			// 
			this.txFromWHActNum.Location = new System.Drawing.Point(136, 45);
			this.txFromWHActNum.Name = "txFromWHActNum";
			this.txFromWHActNum.Size = new System.Drawing.Size(120, 20);
			this.txFromWHActNum.TabIndex = 23;
			// 
			// lbFromWHToDep
			// 
			this.lbFromWHToDep.Location = new System.Drawing.Point(341, 43);
			this.lbFromWHToDep.Name = "lbFromWHToDep";
			this.lbFromWHToDep.Size = new System.Drawing.Size(75, 23);
			this.lbFromWHToDep.TabIndex = 6;
			this.lbFromWHToDep.Text = "Куда";
			// 
			// lbFromWHActDate
			// 
			this.lbFromWHActDate.Location = new System.Drawing.Point(11, 76);
			this.lbFromWHActDate.Name = "lbFromWHActDate";
			this.lbFromWHActDate.Size = new System.Drawing.Size(120, 23);
			this.lbFromWHActDate.TabIndex = 22;
			this.lbFromWHActDate.Text = "Дата документа";
			// 
			// lbFromWHToIDDep
			// 
			this.lbFromWHToIDDep.Location = new System.Drawing.Point(709, 45);
			this.lbFromWHToIDDep.Name = "lbFromWHToIDDep";
			this.lbFromWHToIDDep.Size = new System.Drawing.Size(32, 23);
			this.lbFromWHToIDDep.TabIndex = 7;
			this.lbFromWHToIDDep.Text = "0";
			// 
			// lbFromWHActNum
			// 
			this.lbFromWHActNum.Location = new System.Drawing.Point(10, 45);
			this.lbFromWHActNum.Name = "lbFromWHActNum";
			this.lbFromWHActNum.Size = new System.Drawing.Size(120, 23);
			this.lbFromWHActNum.TabIndex = 21;
			this.lbFromWHActNum.Text = "Номер документа";
			// 
			// btnFromWHChoiceProd
			// 
			this.btnFromWHChoiceProd.Location = new System.Drawing.Point(262, 209);
			this.btnFromWHChoiceProd.Name = "btnFromWHChoiceProd";
			this.btnFromWHChoiceProd.Size = new System.Drawing.Size(100, 23);
			this.btnFromWHChoiceProd.TabIndex = 20;
			this.btnFromWHChoiceProd.Text = "Выбрать ->";
			this.btnFromWHChoiceProd.UseVisualStyleBackColor = true;
			this.btnFromWHChoiceProd.Click += new System.EventHandler(this.BtnFromWHChoiceProdClick);
			// 
			// lbFromWHProdCount
			// 
			this.lbFromWHProdCount.Location = new System.Drawing.Point(262, 110);
			this.lbFromWHProdCount.Name = "lbFromWHProdCount";
			this.lbFromWHProdCount.Size = new System.Drawing.Size(100, 23);
			this.lbFromWHProdCount.TabIndex = 9;
			this.lbFromWHProdCount.Text = "Количество";
			// 
			// lsbFromWHProdTypes
			// 
			this.lsbFromWHProdTypes.FormattingEnabled = true;
			this.lsbFromWHProdTypes.HorizontalScrollbar = true;
			this.lsbFromWHProdTypes.Location = new System.Drawing.Point(10, 155);
			this.lsbFromWHProdTypes.Name = "lsbFromWHProdTypes";
			this.lsbFromWHProdTypes.ScrollAlwaysVisible = true;
			this.lsbFromWHProdTypes.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.lsbFromWHProdTypes.Size = new System.Drawing.Size(246, 134);
			this.lsbFromWHProdTypes.TabIndex = 10;
			this.lsbFromWHProdTypes.SelectedIndexChanged += new System.EventHandler(this.LsbFromWHProdTypesSelectedIndexChanged);
			// 
			// lbFromWHPrice
			// 
			this.lbFromWHPrice.Location = new System.Drawing.Point(262, 155);
			this.lbFromWHPrice.Name = "lbFromWHPrice";
			this.lbFromWHPrice.Size = new System.Drawing.Size(100, 23);
			this.lbFromWHPrice.TabIndex = 16;
			this.lbFromWHPrice.Text = "Цена";
			// 
			// txFromWHFindProd
			// 
			this.txFromWHFindProd.Location = new System.Drawing.Point(10, 130);
			this.txFromWHFindProd.Name = "txFromWHFindProd";
			this.txFromWHFindProd.Size = new System.Drawing.Size(246, 20);
			this.txFromWHFindProd.TabIndex = 11;
			this.txFromWHFindProd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxFromWHFindProdKeyUp);
			// 
			// txFromWHInvNum
			// 
			this.txFromWHInvNum.Location = new System.Drawing.Point(389, 130);
			this.txFromWHInvNum.Name = "txFromWHInvNum";
			this.txFromWHInvNum.Size = new System.Drawing.Size(100, 20);
			this.txFromWHInvNum.TabIndex = 15;
			// 
			// lbFromWHProdTypes
			// 
			this.lbFromWHProdTypes.Location = new System.Drawing.Point(10, 110);
			this.lbFromWHProdTypes.Name = "lbFromWHProdTypes";
			this.lbFromWHProdTypes.Size = new System.Drawing.Size(121, 23);
			this.lbFromWHProdTypes.TabIndex = 13;
			this.lbFromWHProdTypes.Text = "Виды предметов";
			// 
			// lbFromWHInvNum
			// 
			this.lbFromWHInvNum.Location = new System.Drawing.Point(389, 110);
			this.lbFromWHInvNum.Name = "lbFromWHInvNum";
			this.lbFromWHInvNum.Size = new System.Drawing.Size(100, 23);
			this.lbFromWHInvNum.TabIndex = 14;
			this.lbFromWHInvNum.Text = "Инв. номер";
			// 
			// scFromWHChoicedList
			// 
			this.scFromWHChoicedList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scFromWHChoicedList.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.scFromWHChoicedList.Location = new System.Drawing.Point(0, 0);
			this.scFromWHChoicedList.Name = "scFromWHChoicedList";
			this.scFromWHChoicedList.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// scFromWHChoicedList.Panel1
			// 
			this.scFromWHChoicedList.Panel1.BackColor = System.Drawing.Color.Beige;
			this.scFromWHChoicedList.Panel1.Controls.Add(this.label2);
			this.scFromWHChoicedList.Panel1.Controls.Add(this.maskedTextBox3);
			this.scFromWHChoicedList.Panel1.Controls.Add(this.maskedTextBox4);
			this.scFromWHChoicedList.Panel1.Controls.Add(this.rbFromWHFindPrice);
			this.scFromWHChoicedList.Panel1.Controls.Add(this.rbFromWHFindProd);
			this.scFromWHChoicedList.Panel1.Controls.Add(this.textBox2);
			this.scFromWHChoicedList.Panel1.Controls.Add(this.lbFromWHFindInDB);
			this.scFromWHChoicedList.Panel1.Controls.Add(this.btnFromWHChoiceDel);
			this.scFromWHChoicedList.Panel1.Controls.Add(this.btnFromWHChoiceSave);
			// 
			// scFromWHChoicedList.Panel2
			// 
			this.scFromWHChoicedList.Panel2.Controls.Add(this.dgvFromWHChoicedProds);
			this.scFromWHChoicedList.Size = new System.Drawing.Size(286, 25);
			this.scFromWHChoicedList.SplitterDistance = 130;
			this.scFromWHChoicedList.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(154, 36);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(15, 21);
			this.label2.TabIndex = 49;
			this.label2.Text = "...";
			// 
			// maskedTextBox3
			// 
			this.maskedTextBox3.Location = new System.Drawing.Point(171, 36);
			this.maskedTextBox3.Name = "maskedTextBox3";
			this.maskedTextBox3.Size = new System.Drawing.Size(85, 20);
			this.maskedTextBox3.TabIndex = 48;
			// 
			// maskedTextBox4
			// 
			this.maskedTextBox4.Location = new System.Drawing.Point(68, 36);
			this.maskedTextBox4.Name = "maskedTextBox4";
			this.maskedTextBox4.Size = new System.Drawing.Size(85, 20);
			this.maskedTextBox4.TabIndex = 47;
			// 
			// rbFromWHFindPrice
			// 
			this.rbFromWHFindPrice.Location = new System.Drawing.Point(262, 35);
			this.rbFromWHFindPrice.Name = "rbFromWHFindPrice";
			this.rbFromWHFindPrice.Size = new System.Drawing.Size(104, 24);
			this.rbFromWHFindPrice.TabIndex = 30;
			this.rbFromWHFindPrice.TabStop = true;
			this.rbFromWHFindPrice.Text = "по цене";
			this.rbFromWHFindPrice.UseVisualStyleBackColor = true;
			// 
			// rbFromWHFindProd
			// 
			this.rbFromWHFindProd.Location = new System.Drawing.Point(262, 10);
			this.rbFromWHFindProd.Name = "rbFromWHFindProd";
			this.rbFromWHFindProd.Size = new System.Drawing.Size(104, 24);
			this.rbFromWHFindProd.TabIndex = 29;
			this.rbFromWHFindProd.TabStop = true;
			this.rbFromWHFindProd.Text = "по предмету";
			this.rbFromWHFindProd.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(68, 10);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(188, 20);
			this.textBox2.TabIndex = 28;
			// 
			// lbFromWHFindInDB
			// 
			this.lbFromWHFindInDB.Location = new System.Drawing.Point(10, 14);
			this.lbFromWHFindInDB.Name = "lbFromWHFindInDB";
			this.lbFromWHFindInDB.Size = new System.Drawing.Size(52, 23);
			this.lbFromWHFindInDB.TabIndex = 27;
			this.lbFromWHFindInDB.Text = "Найти";
			// 
			// btnFromWHChoiceDel
			// 
			this.btnFromWHChoiceDel.Location = new System.Drawing.Point(136, 93);
			this.btnFromWHChoiceDel.Name = "btnFromWHChoiceDel";
			this.btnFromWHChoiceDel.Size = new System.Drawing.Size(153, 23);
			this.btnFromWHChoiceDel.TabIndex = 26;
			this.btnFromWHChoiceDel.Text = "Удалить выделенные";
			this.btnFromWHChoiceDel.UseVisualStyleBackColor = true;
			this.btnFromWHChoiceDel.Click += new System.EventHandler(this.BtnFromWHChoiceDelClick);
			// 
			// btnFromWHChoiceSave
			// 
			this.btnFromWHChoiceSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnFromWHChoiceSave.Location = new System.Drawing.Point(15, 90);
			this.btnFromWHChoiceSave.Name = "btnFromWHChoiceSave";
			this.btnFromWHChoiceSave.Size = new System.Drawing.Size(80, 28);
			this.btnFromWHChoiceSave.TabIndex = 25;
			this.btnFromWHChoiceSave.Text = "Сохранить";
			this.btnFromWHChoiceSave.UseVisualStyleBackColor = true;
			this.btnFromWHChoiceSave.Click += new System.EventHandler(this.BtnFromWHChoiceSaveClick);
			// 
			// dgvFromWHChoicedProds
			// 
			this.dgvFromWHChoicedProds.BackgroundColor = System.Drawing.Color.White;
			this.dgvFromWHChoicedProds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFromWHChoicedProds.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvFromWHChoicedProds.Location = new System.Drawing.Point(0, 0);
			this.dgvFromWHChoicedProds.Name = "dgvFromWHChoicedProds";
			this.dgvFromWHChoicedProds.Size = new System.Drawing.Size(952, 91);
			this.dgvFromWHChoicedProds.TabIndex = 26;
			// 
			// tpWHWriteoff
			// 
			this.tpWHWriteoff.BackColor = System.Drawing.Color.Transparent;
			this.tpWHWriteoff.Location = new System.Drawing.Point(4, 22);
			this.tpWHWriteoff.Name = "tpWHWriteoff";
			this.tpWHWriteoff.Size = new System.Drawing.Size(292, 174);
			this.tpWHWriteoff.TabIndex = 2;
			this.tpWHWriteoff.Text = "Списание";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1123, 562);
			this.Controls.Add(this.tcWH);
			this.Controls.Add(this.tcEdit);
			this.Controls.Add(this.tcUse);
			this.Controls.Add(this.tcDep);
			this.Controls.Add(this.pnMenu);
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ArmyRep";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.pnMenu.ResumeLayout(false);
			this.tcEdit.ResumeLayout(false);
			this.tpPerson.ResumeLayout(false);
			this.tpPerson.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvEditPersonList)).EndInit();
			this.gbEditPersonRank.ResumeLayout(false);
			this.tpDep.ResumeLayout(false);
			this.tpDep.PerformLayout();
			this.tpCategory.ResumeLayout(false);
			this.tpCategory.PerformLayout();
			this.tpProductType.ResumeLayout(false);
			this.tpProductType.PerformLayout();
			this.tpUsingType.ResumeLayout(false);
			this.tpUsingType.PerformLayout();
			this.tpRank.ResumeLayout(false);
			this.tpRank.PerformLayout();
			this.tpDepType.ResumeLayout(false);
			this.tpDepType.PerformLayout();
			this.tpPart.ResumeLayout(false);
			this.tpPart.PerformLayout();
			this.tcDep.ResumeLayout(false);
			this.tpDepToDep.ResumeLayout(false);
			this.tpDepToDep.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDepToDepChoicedProds)).EndInit();
			this.tpUseToDep.ResumeLayout(false);
			this.tcUse.ResumeLayout(false);
			this.tcWH.ResumeLayout(false);
			this.tpToWH.ResumeLayout(false);
			this.scToWH.Panel1.ResumeLayout(false);
			this.scToWH.Panel1.PerformLayout();
			this.scToWH.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scToWH)).EndInit();
			this.scToWH.ResumeLayout(false);
			this.scToWHChoicedList.Panel1.ResumeLayout(false);
			this.scToWHChoicedList.Panel1.PerformLayout();
			this.scToWHChoicedList.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scToWHChoicedList)).EndInit();
			this.scToWHChoicedList.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvToWHChoicedProds)).EndInit();
			this.tpFromWH.ResumeLayout(false);
			this.scFromWH.Panel1.ResumeLayout(false);
			this.scFromWH.Panel1.PerformLayout();
			this.scFromWH.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scFromWH)).EndInit();
			this.scFromWH.ResumeLayout(false);
			this.scFromWHChoicedList.Panel1.ResumeLayout(false);
			this.scFromWHChoicedList.Panel1.PerformLayout();
			this.scFromWHChoicedList.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scFromWHChoicedList)).EndInit();
			this.scFromWHChoicedList.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvFromWHChoicedProds)).EndInit();
			this.ResumeLayout(false);

		}
	}
}