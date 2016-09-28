<?php

	namespace Routing;

	class RouteCollections
	{
		protected $routesCollections = array();
		
		public function AddCollection(RouteItemCollection $routes)
		{
			$this->routesCollections[] = $routes;
		}
		
		public function GetCollections()
		{
			return $this->routesCollections;
		}
	}