<?php

	require_once 'vendor/autoload.php';

	use Routing\UrlMatcher;
	
	//$routing = new Routing();
	//index.php?cntl=Home&method=index
	//$routing->Route($_GET['cntl'], $_GET['method']);
	
	echo "<pre>";
	
	//var_dump($_SERVER);
	
	$UrlMatcher = new UrlMatcher(include 'src/mvc/routes.php');
	
	//var_dump($UrlMatcher);
