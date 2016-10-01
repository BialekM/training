<?php
    
    abstract class Dal
    {
        public abstract  function GetDataForHome();
    }

	class HomeDal extends Dal // data access layer
	{
		public function GetDataForHome()
		{
			
		}
	}