<?php

	interface IExampleDb
	{
		public function SaveInDb($arrayOfData);
	}
	
	interface IExampleInterface
	{
		
	}

	
	
	abstract class Db implements IExampleDb, IExampleInterface
	{
		public function SaveInDb($arrayOfData)
		{
			foreach ($arrayOfData as $key => $value)
			{
				$this->Save($value);
			}
			
			$this->FinishJob();
		}
		
		protected abstract function Save($record);
		
		protected abstract function FinishJob();
	}
	
	class MySql extends Db
	{
		// insert
	}
	
	class Xml extends Db
	{
		// stworzenie node i zapis pliku
	}
	
	class TextFile extends Db
	{
		private $handle;
		
		public function __construct()
		{
			$this->handle = fopen("", "rw");
		}
		
		// zapis kolejnego rekordu prawdopodobnie csv
		protected function Save($record)
		{
			$string = implode(';', $record);
			fputs($this->handle, $string, strlen($string));
		}
		
		protected function FinishJob()
		{
			fclose($this->handle);
		}
	}
	
	class Tst
	{
		public function TestHinting(Db $db)
		{
			//$db = new 
		}
	}
	
	$ob = new Tst();
	$ob->TestHinting(new TextFile());
	