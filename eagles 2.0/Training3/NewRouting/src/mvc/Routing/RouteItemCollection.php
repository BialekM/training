<?php

	namespace Routing;

	class RouteItemCollection 
	{
		protected $routes = array();
		protected $prefix = "";
		protected $method = "GET";
		
		public function AddRoute($nameRoute, Route $route)
		{
			$this->routes[$nameRoute] = $route;
		}
		
		public function AddPrefix($prefix)
		{
			$this->prefix = $this->Filter($prefix);
		}
		
		public function AddMethod($method)
		{
			$this->method = strtoupper($method);
		}

		public function GetRoutes()
		{
			return $this->routes;
		}
		
		public function GetPrefix()
		{
			return $this->prefix;
		}
		
		public function GetMethod()
		{
			return $this->method;
		}
		
		protected  function Filter($string) // zmiana nazw i logiki 
		{
			if(strlen($string) > 0)
			{
				$string = ($string[0] != "/") ? "/" . $string : $string;
				$string = ($string[strlen($string - 1)] == "/") ? substr($string, 0 , -1) : $string;
			}
			
			return $string;
		}
	}