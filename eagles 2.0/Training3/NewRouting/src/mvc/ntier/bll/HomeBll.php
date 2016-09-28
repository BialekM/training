<?php

	namespace ntier\bll;
	
	use ntier\dal\HomeDal;

	class HomeBll extends Bll // business logic layer
	{
		public function GetDataForHome($homeModel)
		{
			$dal = new HomeDal();
			//kilk dali i zlaczenie danych
			//CHOR
			//$homeModel = new HomeModel();
			$data = $dal->GetDataForHome();
			
			//fill home model with data
			
			return $homeModel;
		}
	}