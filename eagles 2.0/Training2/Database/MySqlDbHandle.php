<?php

	class MySqlDbHandle extends DbHandle
	{
		protected $connectionHandle;
		
		public function __construct()
		{
			parent::__construct('root', 'testy', '', 'localhost');
		}
		
		public function Connect()
		{
			$this->connectionHandle =  new mysqli($this->host, $this->user, $this->password, $this->db);
		}
		
		public function RunQuery($query)
		{
			//$resource = $this->connectionHandle->prepare($query);
			$resource = mysqli_query($this->connectionHandle, $query);

			return $resource; 
		}
	}