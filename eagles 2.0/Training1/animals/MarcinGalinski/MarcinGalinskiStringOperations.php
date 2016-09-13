<?php


	interface IStringOperations
	{
		
	}

	class MarcinGalinskiStringOperations implements IStringOperations
	{
		public function GetName()
		{
			echo "Marcin Galiñski\n";
		}
		
		//DOKONCZYC*************************************************
		public function Strlen($text)
		{
			//echo strlen($text);
			$i = 0;
			while( isset($text[$i]))
				$i++;
			return $i;
		}
		
		public function Substring($text, $start, $length)
		{
			$zm = "";
			for( $i = $start ; $i < ($start + $length) ; $i++ )
			{
				$zm .= $text[$i];
			}
			return $zm;
		}
		
		public function StrPos($text, $needle)
		{
			for( $i = 0 ; $i < (strlen($text)) ; $i++ )
			{
				//echo $text[$i] . " ";
				$subString = $this->SubString($text, $i , strlen($needle) );
				//echo $subString . "<br/>";
				if( $subString == $needle )
				{
					return $i;
				}
			}
			return (-1);
		}
		
		public function CountChars($text, $character)
		{
			$licznik = 0;
			for( $i = 0 ; $i < strlen($text) ; $i++ )
			{
				if( $text[$i] == $character )
				{
					$licznik++;
				}
			}
			return $licznik;
		}
		
		public function CountAllCharacters($text)
		{
			$tab = array();
			for( $i = 0 ; $i < strlen( $text ) ; $i++ )
			{
				@++$tab[($text[$i])];
			}
			
			return $tab;
		}
		
		public function StrReplace($text, $needle, $replace)
		{
			$poz = $this->StrPos($text, $needle);
			$temp = "";
			for( $i = $poz ; $i < strlen($text) ; $i++ )
			{
				//$temp .= $text[$i];
				$text[$i] = "";
			}
			$text .= $replace;
			$text .= $temp;
			return $text;
		}
	}
	/*
	
	$object1 = new MarcinGalinskiStringOperations();
	//1
	$object1->GetName();
	//2
	$dlugosc = $object1->Strlen("napis");
	echo $dlugosc . "\n";
	//3
	$sub = $object1->Substring("beatka", 2, 3);
	echo $sub . "\n";
	//4
	$pos = $object1->StrPos("beatka", "at");
	echo $pos . "\n";
	//5
	$ilosc = $object1->CountChars("beatka", 'a');
	echo $ilosc . "\n";
	//6
	$table = $object1->CountAllCharacters("beatka");
	echo $table['e'] . "\n";
	//7
	$replaced = $object1->StrReplace("bartek", "arte", "beatka");
	echo $replaced;*/
	

?>