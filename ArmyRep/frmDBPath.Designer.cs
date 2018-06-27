/*
 * Created by SharpDevelop.
 * User: ktuktubaev
 * Date: 12.06.2018
 * Time: 13:43
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ArmyRep
{
	partial class frmDBPath
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TreeView tvFolderPath;
		private System.Windows.Forms.TextBox txFilePath;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button button3;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.tvFolderPath = new System.Windows.Forms.TreeView();
			this.txFilePath = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(14, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Путь к файлу БД";
			// 
			// tvFolderPath
			// 
			this.tvFolderPath.Location = new System.Drawing.Point(14, 82);
			this.tvFolderPath.Name = "tvFolderPath";
			this.tvFolderPath.Size = new System.Drawing.Size(258, 97);
			this.tvFolderPath.TabIndex = 1;
			// 
			// txFilePath
			// 
			this.txFilePath.Location = new System.Drawing.Point(14, 42);
			this.txFilePath.Name = "txFilePath";
			this.txFilePath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.txFilePath.Size = new System.Drawing.Size(258, 20);
			this.txFilePath.TabIndex = 2;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(39, 203);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 3;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.BtnOKClick);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(149, 203);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 4;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancelClick);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(268, 40);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(25, 22);
			this.button3.TabIndex = 5;
			this.button3.Text = "...";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// frmDBPath
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(305, 261);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.txFilePath);
			this.Controls.Add(this.tvFolderPath);
			this.Controls.Add(this.label1);
			this.Name = "frmDBPath";
			this.Text = "frmDBPath";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
