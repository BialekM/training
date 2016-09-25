<?php

	//require_once '../';
	//phpinfo();
	
//	setcookie($name)
	session_start();
	
	if (isset($_POST['zatwierdz']))
	{
		// jezeli formularz w calosci zosta wypelniony poprawnie i zapisany
		//header('Location: index.php');
		//header('HTTP/1.0 403 Forbidden');
	}

	echo '<form method="POST" action="index.php?nazwisko=test">'; // $_SERVER['PHP_SELF']
	$imie = isset($_POST['imie']) ? $_POST['imie'] : ''; 
	echo '<input type="text" name="imie" value="'.$imie.'"/>';
	echo '<input type="submit" name="zatwierdz" value="pocisnij">';
	echo '</form>';
	
	
	//$_SESSION['time'] = date('Y-m-d h:i:s');
	

	//var_dump($_GET);
	
	//var_dump($_POST);
	
	//var_dump($_REQUEST);
	
	//var_dump($_COOKIE);
	
	//var_dump($_SESSION);
	
	//var_dump($_SERVER);
	