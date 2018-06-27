/*
 * Created by SharpDevelop.
 * User: KuanyshMadina
 * Date: 13.05.2018
 * Time: 11:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ArmyRep
{
	partial class frmLogin
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbPart;
		private System.Windows.Forms.ComboBox cbPart;
		private System.Windows.Forms.Button btnEnter;
		private System.Windows.Forms.Label lbIDPart;
		
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
			this.lbPart = new System.Windows.Forms.Label();
			this.cbPart = new System.Windows.Forms.ComboBox();
			this.btnEnter = new System.Windows.Forms.Button();
			this.lbIDPart = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbPart
			// 
			this.lbPart.Location = new System.Drawing.Point(18, 25);
			this.lbPart.Name = "lbPart";
			this.lbPart.Size = new System.Drawing.Size(93, 23);
			this.lbPart.TabIndex = 0;
			this.lbPart.Text = "Военная часть:";
			// 
			// cbPart
			// 
			this.cbPart.FormattingEnabled = true;
			this.cbPart.Location = new System.Drawing.Point(126, 25);
			this.cbPart.Name = "cbPart";
			this.cbPart.Size = new System.Drawing.Size(121, 21);
			this.cbPart.TabIndex = 1;
			// 
			// btnEnter
			// 
			this.btnEnter.Location = new System.Drawing.Point(84, 67);
			this.btnEnter.Name = "btnEnter";
			this.btnEnter.Size = new System.Drawing.Size(75, 23);
			this.btnEnter.TabIndex = 2;
			this.btnEnter.Text = "Войти";
			this.btnEnter.UseVisualStyleBackColor = true;
			this.btnEnter.Click += new System.EventHandler(this.BtnEnterClick);
			// 
			// lbIDPart
			// 
			this.lbIDPart.Location = new System.Drawing.Point(21, 44);
			this.lbIDPart.Name = "lbIDPart";
			this.lbIDPart.Size = new System.Drawing.Size(35, 23);
			this.lbIDPart.TabIndex = 3;
			this.lbIDPart.Text = "0";
			// 
			// frmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(265, 119);
			this.Controls.Add(this.lbIDPart);
			this.Controls.Add(this.btnEnter);
			this.Controls.Add(this.cbPart);
			this.Controls.Add(this.lbPart);
			this.Name = "frmLogin";
			this.Text = "Login";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLoginFormClosing);
			this.Load += new System.EventHandler(this.FrmLoginLoad);
			this.ResumeLayout(false);

		}
	}
}
