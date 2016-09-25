<?php

	class UsersModel extends DbModel
	{
		const ID = 'id';
		const CREATIONDATE = 'creationDate';
		const NAME = 'name';
		const LOGIN = 'login';
		const PASSWORD = 'password';
		
		public function __construct()
		{	// typowanie string/int
			$this->fields = array(
				self::ID => new DbField(self::ID), // add
				self::CREATIONDATE => new DbField(self::CREATIONDATE, true), // add
				self::NAME => new DbField(self::NAME),
				self::LOGIN => new DbField(self::LOGIN),
				self::PASSWORD => new DbField(self::PASSWORD),
			);
			
			$this->tableName = 'users';
		}
	}