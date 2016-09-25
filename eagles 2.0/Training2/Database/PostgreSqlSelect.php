<?php

	class PostgreSqlSelect extends DbWhere
	{
		protected $selectCommand = "select ";
		protected $fromCommand = " from ";
		
		public function Select(IDbModel $model)
		{
			$resLike = $model->GetLike();
			$resLimit = $model->GetLimit();
			$resGroup = $model->GetGroup();
			$resOrder = $model->GetOrder();
				
			$select = $this->selectCommand . $model->GetOperator() . $this->fromCommand . $model->GetTableName() . " "
					//. $this->GetWhereClause($model);
			. ($this->GetWhereClause($model) ? $this->GetWhereClause($model) : '')
			. ( isset($resLike) ? $resLike : '') . " " . ( isset($resLimit) ? $resLimit : '')
			. " " . ( isset($resGroup) ? $resGroup : '') . " " . ( isset($resOrder) ? $resOrder : ''). " ";
			return $select;
		}
	}