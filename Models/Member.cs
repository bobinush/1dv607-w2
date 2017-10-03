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

		/// <summary>
		/// Displays a compact list of the member with not too much information.
		/// </summary>
		/// <returns></returns>
		public string ToCompact()
		{
			return $"Member {Id}: {Name}. Number of boats: {numberOfBoats}";
		}

		/// <summary>
		/// Displays detailed information about the member and lists the boats
		/// associated with the member.
		/// </summary>
		/// <returns></returns>
		public string ToVerbose()
		{
			string output = $"Member {Id}: {Name} ({PersonalNumber}). Number of boats: {numberOfBoats}";
			foreach (Boat boat in Boats)
			{
				output += "\n" + boat.ToString();
			}
			return output;
		}

		public void AddBoat(Boat boat)
		{
			var exists = Boats.Any(x => x.Id == boat.Id);
			if (!exists)
			{
				// Nya båten får senaste båtens id + 1.
				boat.Id = Boats.Select(x => x.Id).DefaultIfEmpty(0).Max() + 1;
				Boats.Add(boat);
			}
			// TODO : Kasta felmeddelande?
		}

		/// <summary>
		/// Updates a members boat
		/// </summary>
		/// <param name="oldBoat">The boat to be updated</param>
		/// <param name="newBoat">The boat with the new information</param>
		public void UpdateBoat(Boat oldBoat, Boat newBoat)
		{
			oldBoat.BoatType = newBoat.BoatType;
			oldBoat.Length = newBoat.Length;
		}
		public Boat GetBoat(int id)
		{
			return Boats.Find(x => x.Id == id);
		}
		public void DeleteBoat(int id)
		{
			Boat boat = Boats.Find(x => x.Id == id);
			Boats.Remove(boat);
		}
	}
}
