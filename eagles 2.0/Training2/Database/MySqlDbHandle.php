<?php

	class MySqlDbHandle extends DbHandle
	{
		protected $connectionHandle;
		
		public function __construct()
		{
			parent::__construct('root', 'testy', '', 'localhost');
				
			$this->connectionString = 'mysql:hoost='. $this->host .';dbname='. $this->db .';charset=utf8';
		}
		
		public function Connect()
		{
			$this->connectionHandle =  new mysqli('localhost', 'root', '', 'testy');
		}
		
		public function RunQuery($query)
		{
			//$resource = $this->connectionHandle->prepare($query);
			$resource = mysqli_query($this->connectionHandle, $query);
			echo $query;
			return $resource; 
		}
	}