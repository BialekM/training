<?php
	
	require_once './Database/Interfaces/dbinterfaces.php';
	require_once './Database/DbModel.php';
	require_once './Database/UsersModel.php';
	require_once './Database/DbField.php';
	require_once './Database/DbQueries.php';
	require_once './Database/PostgreSqlInsert.php';
	require_once './Database/DbHandle.php';
	require_once './Database/PostgreSqlDbHandle.php'; 
	
	$insert = new PostgreSqlInsert();
	
	$model = new UsersModel();
	
	$handle = new PostgreSqlDbHandle();
	
	$model->Set(UsersModel::LOGIN, 'bartek');
	$model->Set(UsersModel::PASSWORD, 'beatka');
	$model->Set(UsersModel::NAME, 'bartlomiej');
	
	$insertCommand = $insert->Insert($model);
	
	$handle->Connect();
	$handle->RunQuery($insertCommand);