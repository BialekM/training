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
		public function GetWhereClause(IDbModel $model)
		{
			
		}
	}