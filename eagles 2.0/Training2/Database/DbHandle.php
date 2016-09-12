<?php

	abstract class DbHandle implements IDbHandle
	{
		protected $connectionString;
		
		protected $user;
		
		protected $db;
		
		protected $password;
		
		protected $host;
		
		protected function __construct($user, $db, $password, $host)
		{
			//uzupelniamy te pola
			$this->user = $user;
			$this->db = $db;
			$this->password = $password;
			$this->host = $host;
		}
	}