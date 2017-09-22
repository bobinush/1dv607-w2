using System;
using System.Collections.Generic;
using System.Linq;

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
		public int numberOfBoats { get { return Boats.Count; } }

		public string ToCompact()
		{
			return $"Member {Id}: {Name} 'Number of boats: ' ({numberOfBoats})";

		}
		public string ToVerbose()
		{
			return $"Member {Id}: {Name} 'Number of boats: ' ({numberOfBoats})";
		}
		/// <summary>
		/// Adds a boat to the member.
		/// </summary>
		/// <param name="boat"></param>
		public void AddBoat(Boat boat)
		{
			boat.Id = Boats.Max(x => x.Id) + 1;
			Boats.Add(boat);
		}
	}
}
