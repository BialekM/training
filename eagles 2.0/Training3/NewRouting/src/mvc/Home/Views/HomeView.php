<?php

	namespace Home\Views;
	
	use views\View;
	
	class HomeView extends View
	{
		public function Show($model)
		{
			// model == homemodel
			
			return '<span>Whatever</span>';
		}
	}