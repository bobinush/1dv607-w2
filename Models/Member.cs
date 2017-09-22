using System;
using System.Collections.Generic;

namespace W2.Models
{
	public class Member
	{
		public Member(string name, string personalNumber)
		{
			Name = name;
			PersonalNumber = personalNumber;
			Boats = new List<Boat>();
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public string PersonalNumber { get; set; }
		public List<Boat> Boats { get; set; }

		public override string ToString()
		{
			return $"Member {Id}: {Name} ({PersonalNumber})";
		}
	}
}
