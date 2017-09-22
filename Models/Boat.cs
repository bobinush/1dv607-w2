using System;
using W2.Enums;

namespace W2.Models
{
	public class Boat
	{
		public Boat(double length, int type)
		{
			BoatType = (BoatTypes)type;
			Length = length;

		}
		public int Id { get; set; }
		public BoatTypes BoatType { get; set; }
		public double Length { get; set; }

		public override string ToString()
		{
			return $"Boat {Id} is a {Length}ft long {BoatType}";
		}
	}
}
