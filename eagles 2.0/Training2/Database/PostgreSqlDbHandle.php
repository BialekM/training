<?php

	class PostgreSqlDbHandle extends DbHandle
	{
		protected $connectionHandle;
		
		public function __construct()
		{
			parent::__construct('postgres', 'toci', 'beatka', 'localhost');
			
			$this->connectionString = 'host='.$this->host.' port=5432 dbname='.
				$this->db.' user='.$this->user.' password='.$this->password;
		}
		
		public function Connect()
		{
			$this->connectionHandle = pg_connect($this->connectionString);
		}
		
		public function RunQuery($query)
		{
			$resource = pg_query($this->connectionHandle, $query);
			
			$result = pg_fetch_array($resource);
			
			return $result;
		}
	}