using System;

namespace W2.Models
{
	public class Member
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public override string ToString()
		{
			return $"Member {Id}: {Name}";
		}
	}
}
