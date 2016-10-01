<?php
    require_once 'controllers/Controller.php';
    require_once 'models/Model.php';
    require_once 'Home/Models/HomeModel.php';
    require_once 'DanielPesel/models/PeselModel.php';  
    require_once 'views/View.php';
    require_once 'ntier/dal/HomeDal.php';    
    require_once 'Home/Views/HomeView.php';
    require_once 'DanielPesel/views/PeselView.php';
    require_once 'ntier/bll/HomeBll.php';    
    require_once 'Home/controllers/HomeController.php';
    require_once 'DanielPesel/controllers/PeselControler.php';
	require_once 'Routing.php';
	

	
	$routing = new Routing();
	//index.php?cntl=Home&method=index
	$routing->Route($_GET['cntl'],  $_GET['method']);
	
	
	
	
	
