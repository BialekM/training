<?php

	interface IDbHandle
	{
		public function Connect();
		
		public function RunQuery($query);
	}
	
	interface IDbField
	{
		public function Set($fieldName, $fieldValue);
		
		public function GetType(); // string/text
		
		public function GetValue(); // beatka
		
		public function GetFieldName(); // name
		
		public function HasValue();
		
		public function IsAutomatic();
	}
	
	interface IDbModel
	{
		/**
		 * returns array of idbfield
		 */
		public function GetFields();

		public function GetTableName();
		
		public function Set($fieldName, $fieldValue);
		
		public function HasField($fieldName);
	}
	
	interface ISqlInsert
	{
		public function Insert(IDbModel $model);
	}