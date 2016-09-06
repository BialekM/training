<?php


	abstract class Animal
	{
		protected $chronione;
		
		protected abstract function GetWeight();
		
		public static function IAmStatic()
		{
			echo "Statyczna metoda \n";
			//$this->chronione = 6;
		}
	}

	class Pig extends Animal
	{
		public function GetWeight()
		{
			
		}
	}
	
	class Dog extends Animal
	{
		private $prywatne;
		
		protected  function GetWeight()
		{
			echo "GetWeight w klasie dog\n";
		}
		
		private function InClassDog()
		{
			
		}
		
		public function PublicInClassDog()
		{
			$this->InClassDog();
			echo "\n pole prywatne: \n";
			var_dump($this->prywatne);
		}
	}
	
	class Rotweiler extends Dog
	{
		public $publiczne;
		
		public  function GetWeight()
		{
			echo "GetWeight w klasie Rotweiler\n";
			parent::GetWeight();
		}
		
		public function Test()
		{
			//$this->prywatne = 3;
			$this->ProtectedInClassDog();
			//$this->InClassDog();
		}
	}
	
	$rotek = new Rotweiler();
	
	$rotek->prywatne = 8;
	
	$rotek->PublicInClassDog();
	
	$rotek->GetWeight();
	
	var_dump($rotek);