<?php

	class UserHandler implements IHandler
	{
		public function Handle(IRefTypeStrategy &$strategy)
		{
			//User
			$strategy->name = 'Bartek';
			$strategy->age = 32;
			$strategy->sex = 'male';
		}
	}
	
	class BanksHandler implements IHandler
	{
		public function Handle(IRefTypeStrategy &$strategy)
		{
			$strategy->banks[UserBanks::MBANK]->userName = 'bartek zapart';
			$strategy->banks[UserBanks::MBANK]->moneyAmount = 888;
			$strategy->banks[UserBanks::MBANK]->accountNumber = '101140473289562385285646';
			
			//$strategy = null;
		}
	}
	
	abstract class ChorHandler implements IChorHandler
	{
		protected $handlers = array();
		protected $strategy;
		
		public function __construct($handlersArray, $strategy)
		{
			$this->handlers = $handlersArray;
			$this->strategy = $strategy;
		}
		
		public function Run()
		{
			foreach ($this->handlers as $handler)
			{
				$handler->Handle($this->strategy);
			}
			
			return $this->strategy;
		}
	}
	
	class UserChorHandler extends ChorHandler
	{
		
		public function __construct()
		{
			$user = new User();
			$handlers = array(
				new UserHandler(),
				new BanksHandler(),
			);
			
			parent::__construct($handlers, $user);
		}
	}