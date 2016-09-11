<?php


interface IStringOperations
{
	
}


class patrycjamecinastringoperations implements IStringOperations
{
	
	public function GetName()
	{
		echo "Patrycja Mecina\n";
	}
	
	public function Strlen($text)
	{
		for($i=0; isset($text[$i])==1; $i++)
		$i++;
		echo $i."\n";
	}
	
	public function Substring($text, $start, $length)//beatka 1, 4 => eatk
	{
		$result="";
		for($i=$start; $i<$start+$length; $i++)
		{
			$result.=$text[$i];
		}
		echo $result ."\n";
		return $result;
		
	}
	
	public function StrPos($text, $needle) // beatka, eatk => 1; beatka, tk => 3 ; beatka, a => 2
	{
		for($i=0; $i<strlen($text);$i++)
		{
			$result="";
			for($j=$i; $j<$i+strlen($needle); $j++)
			{
				$result.=$text[$j];
			}
			if( $result == $needle )
				return $i;
					
		}
		return (-1);
	}
	
	public function CountChars($text, $character) // beatka, a => 2; beatka, t => 1
	{
		$j=0;
		
		
		for($i=0; $i<strlen($text); $i++)
		{
			if($character==$text[$i])
			$j++;
			//echo $j;
		}
		echo $j. "\n";
	}
	
	public function CountAllCharacters($text) //beatka => array('b' => 1, 'e' => 1, 'a' => 2 ....);
	{
		//nie umiem
	}
	
	public function StrReplace($text, $needle, $replace) // bartek, arte, beatka => bbeatkak
	{
		$wynik = $this->StrPos($text,$needle);
		//echo $wynik . "\n";
		//echo strlen($text);
		
		for( $i = $wynik ; $i < strlen($text) ; $i++ )
		{
			$text[$i] = "";
		}
		//echo $text;
		
		$text.=$replace;
		
		echo $text;
		
	}
}


$zmienna=new patrycjamecinastringoperations();
$zmienna->GetName();
$zmienna->Strlen("beatka");
$zmienna->Substring("beatka", '2', '3');
$a = $zmienna->StrPos("beatka", "ea");
echo $a . "\n";
$zmienna->CountChars("beatka", "a");
$zmienna->CountAllCharacters("beatka");
$zmienna->StrReplace("beata", "ta", "tka");



