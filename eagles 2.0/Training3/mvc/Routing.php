<?php

	class Routing
	{
		protected $modelMap = array(
			'home/index' => 'HomeModel',
		    
		);
		
		public function Route($controllerCandidate, $methodCandidate)
		{
			$controllerCandidate .= 'Controller';
			$isCalled = false;
			$content = '';
			
			if (class_exists($controllerCandidate))
			{
				$controller = new $controllerCandidate();
				
				if (method_exists($controller, $methodCandidate))
				{
					$isCalled = true;
					$content = $controller->$methodCandidate($this->GetModel($controllerCandidate, $methodCandidate));
				}
			}
			
			if (!$isCalled)
			{
				header('HTTP 1.0/ 404');
			}
			
			echo $content;
		}
		
		protected function GetModel($controllerCandidate, $methodCandidate)
		{
			// $_GET $_POST
			//check $modelMap and return new model
			
			return new HomeModel();
		}
	}