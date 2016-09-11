<?php
	
	require_once '/../../homework.php';
	
	class PatrykStringOperations implements IStringOperations
	{
		public function GetName()
		{
			return "Patryk Drapik";
		}
		
		public function Strlen($text)
		{
			for($i = 0; isset($text[$i]); $i++);
			
			return $i;
		}
		
		public function Substring($text, $start, $length)
		{
			$result = "";
			
			for($i = $start; $i < $start + $length && isset($text[$i]); $i++)
			{
				$result .= $text[$i];
			}
			
			return $result;
		} //beatka 1, 4 => eatk
		
		public function StrPos($text, $needle)
		{
			for($i = 0; $i < $this->Strlen($text); $i++)
			{
				if($this->Substring($text, $i, $this->Strlen($needle)) == $needle)
				{
					return $i;
				}
			}
			
			return -1;
		} // beatka, eatk => 1; beatka, tk => 3 ; beatka, a => 2
		
		public function CountChars($text, $character)
		{
			$result = 0;
			
			for($i = 0; $i < $this->Strlen($text); $i++)
			{
				if($text[$i] == $character)
				{
					$result++;
				}
			}
			
			return $result;
		} // beatka, a => 2; beatka, t => 1
		
		public function CountAllCharacters($text)
		{
			$result = array();
			
			for($i = 0; $i < $this->Strlen($text); $i++)
			{
				$result[$text[$i]] = $this->CountChars($text, $text[$i]);
			}
			
			return $result;
		} //beatka => array('b' => 1, 'e' => 1, 'a' => 2 ....);
		
		public function StrReplace($text, $needle, $replace)
		{
			$result = "";
			
			for($i = 0; $i < $this->Strlen($text); $i++)
			{
				if($this->Substring($text, $i, $this->Strlen($replace)) == $needle)
				{
					$result .= $replace;
					$i += $this->Strlen($needle) - 1;
				}
				else 
				{
					$result .= $text[$i];
				}
			}
			
			return $result;
		} // bartek, arte, beatka => bbeatkak
	}
	
	/*
	
	$test = new PatrykStringOperations();
	
	
	echo $test->Strlen("beatka")." - ".strlen("beatka")."\n";
	echo $test->Substring("beatka", 1, 4)."\n";
	echo $test->StrPos("beatka", "a")."\n";
	echo $test->CountChars("beatka", "t")."\n";
	echo var_dump($test->CountAllCharacters("beatka"))."\n";
	echo $test->StrReplace("blablabla", "bla", "ble");
	
	*/