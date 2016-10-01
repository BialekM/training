<?php
abstract class Bll
{
    public abstract  function GetDataForHome(Model $homeModel);
}

	class HomeBll extends Bll // business logic layer
	{
		public function GetDataForHome(Model $homeModel)
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