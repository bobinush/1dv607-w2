using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;

namespace W2.Models
{
	class Database
	{
		public Database()
		{
		}
		private Database db;
		// public IEnumerable<Boat> Boats { get; set; }
		private List<Member> Members { get; set; }

		public void LoadDatabase()
		{
			db = JsonConvert.DeserializeObject<Database>(File.ReadAllText("db.json"));
			// Boats = db.Boats;
			Members = db.Members;
		}
		private void WriteToFile()
		{
			var text = JsonConvert.SerializeObject(this);
			File.WriteAllText("db.json", text);
		}
		public List<Member> GetAllMembers()
		{
			Members.ToList().ForEach(x => System.Console.WriteLine(x.ToString()));
			return Members;
		}


		public bool Save<T>(T model)
		{
			bool status = false;
			try
			{
				string type = model.GetType().Name;
				if (type == "Member")
				{
					var member = (Member)(object)model;
					member.Id = db.Members.Max(x => x.Id) + 1;
					Members.Add(member);
					WriteToFile();
				}
				status = true;
			}
			catch (Exception ex)
			{
				System.Console.WriteLine(ex.ToString());
			}
			return status;

		}
		public void GetById(string[] args)
		{

		}
		public void Create(string[] args)
		{

		}
		public void Update(string[] args)
		{

		}
		public void Delete(string[] args)
		{

		}
	}
}
