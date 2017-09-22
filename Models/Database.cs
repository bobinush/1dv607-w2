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
		// private Database db;
		public IEnumerable<Boat> Boats { get; set; }
		public IEnumerable<Member> Members { get; set; }

		private void LoadDatabase()
		{
			var db = JsonConvert.DeserializeObject<Database>(File.ReadAllText("db.json"));
			Boats = db.Boats;
			Members = db.Members;
		}
		public void GetAll(string type = "Boats")
		{
			LoadDatabase();
			var t = this.GetType().GetProperty(type).GetValue(this, null);
			Boats.ToList().ForEach(x => System.Console.WriteLine(x.ToString()));
			System.Console.WriteLine(Boats);
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
