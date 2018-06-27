/*
 * Created by SharpDevelop.
 * User: KuanyshMadina
 * Date: 15.05.2018
 * Time: 22:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ArmyRep
{
	/// <summary>
	/// Description of Person.
	/// </summary>
	public class Person
	{
		public int ItemIndex;
		public Int32 ID;
		public string LastName;
		public string FirstName;
		public string Patronymic;
		public bool Gender; //true=male, false=female
		public DateTime Birthdate;
		public DateTime Deathdate;
		public Int32 IDRank;
		public string RankName;
		public DateTime RankDateFrom;
		
		public Person()
		{
		}
	}
}
