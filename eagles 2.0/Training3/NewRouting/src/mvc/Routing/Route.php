<?php

	namespace Routing;

	class Route 
	{
		protected $path;
		protected $namespace;
		protected $nameMethod;
		
		public function __construct($path, $namespace, $nameMethod)
		{
			$this->path = $this->CheckPath($path);
			$this->namespace = $namespace;
			$this->nameMethod = $nameMethod;
		}
		
		protected function CheckPath($path)
		{
			if(strlen($path) > 0)
			{
				return ($path[0] != "/") ? "/" . $path : $path;
			}
			else
			{
				return "/";
			}
		}
		
		public function GetPath()
		{
			return $this->path;
		}
		
		public function GetNamespace()
		{
			return $this->namespace;
		}
		
		public function GetNameMethod()
		{
			return $this->nameMethod;
		}
	}