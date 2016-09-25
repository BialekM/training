<?php

	class User implements IRefTypeStrategy
	{
		public $name;
		public $age;
		public $sex;
		
		public $banks;

		public function __construct()
		{
			$this->banks = array(
				UserBanks::MBANK => new UserBanks(),
				UserBanks::ING => new UserBanks()
			);
		}
	}
	
	class UserBanks implements IRefTypeStrategy
	{
		const MBANK = 'MBank';
		const ING = 'ING';
		
		public $userName;
		public $moneyAmount;
		public $accountNumber;
	}