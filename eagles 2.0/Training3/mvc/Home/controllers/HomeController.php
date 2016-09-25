<?php

	class HomeController extends Controller
	{
		public function Run(Model $model)
		{
			
		}
		
		public function Index(Model $model)
		{
			$view = new HomeView();
			
			//logika
			// zle $query = 'select * from costam';
			try
			{
				$bll = new HomeBll();
				$result = $bll->GetDataForHome($model);
				
				return $view->Show($result);
			}
			catch(Exception $e)
			{
				
			}
			
			
		}
	}