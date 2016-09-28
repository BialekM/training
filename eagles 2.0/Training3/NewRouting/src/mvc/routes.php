<?php

	use Routing\RouteCollections;
	use Routing\RouteItemCollection;
	use Routing\Route;
	
	$contentRoute = new RouteCollections();
	
		$itemCollection = new RouteItemCollection();
		
		$itemCollection->AddRoute("test", new Route("/test", "Home\controllers\HomeController", "Index"));
		
		$itemCollection->AddRoute("test2", new Route("/{parametr1}/{parametr2}", "Home\controllers\HomeController", "Test2"));
		
		//$itemCollection->AddPrefix("prefix"); prefix np. /prefix/przyklad
		
		//$itemCollection->AddMethod("post") 

	$contentRoute->AddCollection($itemCollection);
	
	return $contentRoute;