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
		private string dbFile = "db.json";
		public Database()
		{
			Members = new List<Member>();
		}
		// public IEnumerable<Boat> Boats { get; set; }
		public List<Member> Members { get; set; }

		public void LoadDatabase()
		{
			if (!File.Exists(dbFile))
			{
				SeedDatabase();
			}
			Database db = JsonConvert.DeserializeObject<Database>(File.ReadAllText(dbFile));
			Members = db.Members;
		}
		private void SeedDatabase()
		{
			var Members = new List<Member>();
			var arr = new {Members};
			for (int i = 1; i < 3; i++)
			{
				Member member = new Member("test "+ i.ToString(), "123456-7890");
				member.Id = i;
				member.AddBoat(new Boat(i, 12d));
				Members.Add(member);
			}
			using (StreamWriter sw = File.CreateText(dbFile))
			{
				sw.WriteLine(JsonConvert.SerializeObject(arr));
			}
		}
		private bool WriteChangesToFile()
		{
			try
			{
				var text = JsonConvert.SerializeObject(this);
				File.WriteAllText(dbFile, text);
				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
				return false;
			}
		}
		public void Delete(int id)
		{
			Members.Remove(GetMemberById(id));
			WriteChangesToFile();
		}

		public List<Member> GetAllMembers()
		{
			return Members;
		}
		public bool Save<T>(T model)
		{
			bool status = false;
			try
			{
				string type = model.GetType().Name;
				if (type == nameof(Member))
				{
					var member = (Member)(object)model;
					if (member.Id == 0)
					{
						// Spara ny medlem
						member.Id = Members.Select(x => x.Id).DefaultIfEmpty(0).Max() + 1;
						Members.Add(member);
					}
					else
					{
						// Uppdatera en medlem
						var originalMember = GetMemberById(member.Id);
						originalMember.Name = member.Name;
						originalMember.PersonalNumber = member.PersonalNumber;
						originalMember.Boats = member.Boats;
					}
				}
				else if (type == nameof(Boat))
				{
					// Not necessary since we can update boats through member
					throw new NotImplementedException();
				}
				status = WriteChangesToFile();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return status;
		}
		public Member GetMemberById(int id)
		{
			return Members.Find(x => x.Id == id);
		}
	}
}
