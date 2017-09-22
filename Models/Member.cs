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
		}

		public int Id { get; set; }
		public string Name { get; set; }
		public string PersonalNumber { get; set; }
		public List<Boat> Boats { get; set; }
		public int numberOfBoats { get { return Boats.Count; } }

		public string ToCompact()
		{
			return $"Member {Id}: {Name} ({numberOfBoats})";

		}
		public string ToVerbose()
		{
			return $"Member {Id}: {Name} ({numberOfBoats})";
		}

	}
}
