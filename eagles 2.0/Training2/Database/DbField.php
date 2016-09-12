<?php

	class DbField implements IDbField // kolumna tabelki w bazie danych
	{
		protected $fieldName;
		protected $fieldValue;
		
		public function __construct($fieldName)
		{
			$this->fieldName = $fieldName;
		}
		
		public function Set($fieldName, $fieldValue)
		{
			$this->fieldName = $fieldName;
			$this->fieldValue = $fieldValue;
		}
		
		public function GetType() // string/text
		{
			return gettype($this->fieldValue);
		}
		
		public function GetValue() // beatka
		{
			return $this->fieldValue;
		}
		
		public function GetFieldName()
		{
			return $this->fieldName;
		}
		
		public function HasValue()
		{
			return !is_null($this->fieldValue);
		}
		
		public function IsAutomatic()
		{
			return false;
		}
	}