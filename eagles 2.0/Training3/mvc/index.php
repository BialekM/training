<?php

	require_once 'Routing.php';
	
	$routing = new Routing();
	//index.php?cntl=Home&method=index
	$routing->Route($_GET['cntl'], $_GET['method']);