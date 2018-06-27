/*
 * Created by SharpDevelop.
 * User: ktuktubaev
 * Date: 29.05.2018
 * Time: 8:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ArmyRep
{
	/// <summary>
	/// Description of GivingProd.
	/// </summary>
	public class GivingProd
	{
		public int ItemIndex;
		public ProductType ProdType;
		public int ProdCount;
		public string InvNum;
		public double ProdPrice;
		public Department FromDep;
		public Department ToDep;
		public Person FromPerson;
		public Person ToPerson;
		public Category ProdCategory;
		public string ActNum;
		public DateTime ActDate;
		
		
		public GivingProd()
		{
		}
	}
}
