<?php

	require_once './Database/Interfaces/dbinterfaces.php';
	require_once './Database/DbModel.php';
	require_once './Database/UsersModel.php';
	require_once './Database/DbField.php';
	require_once './Database/DbQueries.php';
	require_once './Database/PostgreSqlInsert.php';
	require_once './Database/PostgreSqlSelect.php';
	require_once './Database/DbHandle.php';
	require_once './Database/PostgreSqlDbHandle.php';
	require_once './Database/MySqlDbHandle.php';
	
	require_once './Front/Controls.php';
	require_once './Front/CrudGenerator.php';
	
	$crudGenerator = new CrudGenerator();

	echo $crudGenerator->GenerateForm(new UsersModel());
	
	$model = new UsersModel();
	
	//--------------- use Where
	/*
	$test = new PostgreSqlSelect();
	
	$model->GetFild("id")->IsWhere(10);
	$model->GetFild("name")->IsWhere('erghtgh');
	
	echo "Where-> " . $test->GetWhereClause($model) . "<br>";
	*/
	//-----------
	
	$crudGenerator->SaveData();