<?php

	abstract class DbInsert implements ISqlInsert
	{
		protected $insertCommand = 'insert into ';
		
		protected $surroundings = array(
			'string' => "'",
			'int' => '',
		);
		
		public abstract function Insert(IDbModel $model);
		
		protected function GetNames(IDbModel $model)
		{
			$fields = $model->GetFields();
			$names = array();
			
			foreach ($fields as $fieldKey => $fieldValue)
			{
				if ($fieldValue->HasValue())
				{
					$names[] = $fieldValue->GetFieldName();
				}				
			}
			
			return $names;
		}
		
		protected function GetValues(IDbModel $model)
		{
			$fields = $model->GetFields();
			$values = array();
			
			foreach ($fields as $fieldKey => $fieldValue)
			{
				if ($fieldValue->HasValue())
				{
					//var_dump($fieldValue->GetType());
					$values[] = $this->surroundings[$fieldValue->GetType()] . $fieldValue->GetValue() . $this->surroundings[$fieldValue->GetType()];
				}				
			}
			
			return $values;
		}
	}
	
	
	abstract class DbWhere
	{
		protected $surroundings = array(
				'string' => "'",
				'int' => '',
				'integer' => '',
		);
		
		public function GetWhereClause($model)
		{
			$result = array();
				
			foreach ($this->GetValue($model) as $key => $value)
			{
				$result[] = $value["fildName"] . " " . $value['operators'] . " " . $value["value"];
			}
				
			return (count($result) > 0) ? "WHERE " . implode(" AND ", $result) : null;
		}
		
		protected  function GetValue($model)
		{
			$result = array();
				
			foreach ($model->GetFields() as $key => $value)
			{
				if(isset($value->GetIsWhere()['value']))
				{
					$isWhere = $value->GetIsWhere();
					$surroundings = $this->surroundings[gettype($isWhere["value"])];
					$isWhere["value"] = $surroundings . $isWhere["value"] . $surroundings;
					$isWhere["fildName"] = $value->GetFieldName();
					$result[] = $isWhere;
				}
			}
				
			return $result;
		}
	}