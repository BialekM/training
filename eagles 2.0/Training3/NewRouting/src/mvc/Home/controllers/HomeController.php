<?php

	namespace Home\controllers;
	
	use Home\Views\HomeView;
	use ntier\bll\HomeBll;

	class HomeController
	{
		public function Run(Model $model)
		{
			
		}
		
		public function Index($model) // array OR model ??
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
		
		public function Test2($par)
		{
			var_dump($par);
			//echo "dupa";
		}
	}