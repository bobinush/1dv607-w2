using System;
using W2.Enums;

namespace W2.Models
{
	public class Boat
	{
		public int Id { get; set; }
		public BoatTypes BoatType { get; set; }
		public int Length { get; set; }

		public override string ToString()
		{
			return $"Boat {Id} is a {Length}ft long {BoatType}";
		}
	}
}
