<?php

	class DbField implements IDbField // kolumna tabelki w bazie danych
	{
		protected $fieldName;
		protected $fieldValue;
		protected $isAutomatic; // add
		protected $isWhere = array();
		
		public function __construct($fieldName, $isAutomatic = false) // add
		{
			$this->fieldName = $fieldName;
			$this->isAutomatic = $isAutomatic; // add
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
			return (!is_null($this->fieldValue) && strlen($this->fieldValue) > 0);  // add strlen
		}
		
		public function IsAutomatic()
		{
			return $this->isAutomatic; // add
		}
		
		public function IsWhere($value, $operators = "=", $andOr = true)
		{
			$this->isWhere['value'] = $value;
			$this->isWhere['operators'] = $operators;
			$this->isWhere['andOr'] = $andOr;
		
			return $this;
		}
		
		public function GetIsWhere()
		{
			return $this->isWhere;
		}
	}