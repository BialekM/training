<?php

class PostgreSqlDelete extends DbWhere
{
	protected $deleteCommand = "delete from ";

	public function Delete(IDbModel $model)
	{
		$delete = $this->deleteCommand . $model->GetTableName() . $this->GetWhereClause($model);
		return $delete;
	}
}