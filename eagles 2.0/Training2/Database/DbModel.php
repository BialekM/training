<?php

	class DbModel implements IDbModel // tabelka w bazie danych
	{
		protected $tableName;
		
		protected $fields = array();
		
		protected $isLike = "";
		
		protected $isLimit = "";
		
		protected $isGroup = "";
		
		protected $isOrder = "";
		
		protected $operator;
		
		public function GetFields()
		{
			return $this->fields;
		}
		
		public function GetTableName()
		{
			return $this->tableName;
		}
		
		public function Set($fieldName, $fieldValue)
		{
			$this->fields[$fieldName]->Set($fieldName, $fieldValue);
		}
		
		public function HasField($fieldName)
		{
			return isset($this->fields[$fieldName]);
		}
		
		public function GetFild($name)
		{
			return $this->fields[$name];
		}
		
		
		/////////////////SELECT///////////////////////////
		public function IsLike($pattern)
		{
			$this->isLike = "like '" . $pattern . "'";
			return $this;
		}
		public function GetLike()
		{
			return $this->isLike;
		}
		public function IsLimit($limits = array())
		{
			$this->isLimit = "limit ";
			foreach ($limits as $limitsKey => $limitsValue )
			{
				$this->isLimit .= $limitsValue;
				$this->isLimit .= ",";
			}
			$this->isLimit = rtrim($this->isLimit, ',');
		}
		public function GetLimit()
		{
			return $this->isLimit;
		}
		public function IsGroup($category)
		{
			$this->isGroup = "group by " . $category;
		}
		public function GetGroup()
		{
			return $this->isGroup;
		}
		public function IsOrder($args = array())
		{
			$this->isOrder = "order by ";
			foreach($args as $argsKey => $argsValue)
			{
				$this->isOrder .= $argsValue;
				$this->isOrder .= ",";
			}
			$this->isOrder = rtrim($this->isOrder,',');
		}
		public function GetOrder()
		{
			return $this->isOrder;
		}
		public function SetOperator($operator)
		{
			$this->operator = $operator;
		}
		public function GetOperator()
		{
			return $this->operator;
		}
	}