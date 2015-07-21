﻿using System.Collections.Generic;

namespace Toci.Hornets.Bytom.Common.DrHouse.Types
{
	public abstract class Patient                        // przechowuje dane o pacjenie oraz to na co sie skarży
	{
		public int Age { get; set; }
		public string Name { get; set; }
		public Gender Gender { get; set; }
	    public string PartOfBody { get; set; }
        public List<Symptom> Symptoms { get; set; }
	}

	public enum Gender
	{
		Male, Female, Other
	}
}
