using System;

namespace SD1Knowledgecheck2
{
	public class Genre
	{
		public string nonfiction { get; set; } = "Biography";

		static void Main(string[] args)
		{
			Genre myobj = new Genre();
			Console.WriteLine(myobj.nonfiction);
		}

    }
}

