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
			Members = new List<Member>();
		}
		// public IEnumerable<Boat> Boats { get; set; }
		public List<Member> Members { get; set; }

		public void LoadDatabase()
		{
			Database db = JsonConvert.DeserializeObject<Database>(File.ReadAllText("db.json"));
			Members = db.Members;
		}
		private bool WriteToFile()
		{
			try
			{
				var text = JsonConvert.SerializeObject(this);
				File.WriteAllText("db.json", text);
				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
				return false;
			}
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
				status = WriteToFile();
			}
			catch (Exception ex)
			{
				System.Console.WriteLine(ex.ToString());
			}
			return status;
		}
		public Member GetMemberById(int id)
		{
			return Members.Find(x => x.Id == id);
		}
	}
}
