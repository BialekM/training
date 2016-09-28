<?php

	namespace Routing;

	use Routing\Exception\ResourceNotFoundException;
	
	class UrlMatcher
	{
		protected $checkPathInRoute;
		protected $routeCollections;
		protected $redirectUrl;
		protected $requestMethod;
		protected $prefix;
		protected $itemRouteMethod;
		protected $isCalled = true;
		
		public function __construct(RouteCollections $routeCollections)
		{
			$this->checkPathInRoute = new CheckPathInRoute();
			$this->routeCollections = $routeCollections;
			$this->redirectUrl = $_SERVER["REDIRECT_URL"];
			$this->requestMethod = $_SERVER["REQUEST_METHOD"];
			$this->SearchPathInRoute();
		}
		
		protected function SearchPathInRoute()
		{
			try 
			{
				$this->IterationAfterCollections();
				
				if($this->isCalled)
				{
					throw new ResourceNotFoundException("Not Found");
				}
			}
			catch (ResourceNotFoundException $e)
			{
				echo $e->getMessage();
				header('HTTP/1.0 404');
			}
			catch (\Exception $e)
			{
				echo $e->getMessage();
			}
		}
		
		protected function IterationAfterCollections()
		{
			foreach ($this->routeCollections->GetCollections() as $key => $value)
			{
				if($this->isCalled)
				{
					$this->itemRouteMethod = $value->GetMethod();
					$this->prefix = $value->GetPrefix();
					$this->IterationAfterItemCollection($value->GetRoutes());
				}
			}
		}
		
		protected function IterationAfterItemCollection($itemCollection)
		{
			foreach ($itemCollection as $key => $value)
			{
				if($this->isCalled)
				{
					$this->CheckMethodInRoute($value);
				}				
			}
		}
		
		protected function CheckMethodInRoute(Route $route)
		{
			if($this->itemRouteMethod == $this->requestMethod)
			{
				$this->CheckPathInRoute($route);
			}
		}
		
		protected function CheckPathInRoute(Route $route)
		{
			if($this->checkPathInRoute->StartCheckPathInRoute($this->prefix, $route->GetPath(), $this->redirectUrl))
			{
				$this->isCalled = false;
				$parameters = $this->checkPathInRoute->GetParametersWithUrl($this->redirectUrl, $route->GetPath());
				$this->LoadController($route, $parameters);
			}
		}
		
		protected function LoadController(Route $route, $parameters)
		{
			$controller =  $route->GetNamespace();
			$nameMethod = $route->GetNameMethod();
			
			if(class_exists($controller))
			{
				$objectController = new $controller();
				
				if(method_exists($objectController, $nameMethod))
				{
					echo $objectController->$nameMethod($parameters);
				}
				else 
				{
					throw new \Exception(sprintf('Nie znaleziono metody: "%s" w: "%s"', $nameMethod, $controller));
				}
			}
			else 
			{
				throw new \Exception(sprintf('Nie znaleziono: "%s"', $controller));
			}
		}
	}
	