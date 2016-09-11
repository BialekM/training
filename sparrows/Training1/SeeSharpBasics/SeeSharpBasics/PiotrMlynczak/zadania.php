<?php

	/*

	1. trzeba napisać foreach i dla tablicy która wygląda np. tak ,że ma
	
	'a' => 'dowolna wartosc'
	'b' => 'wartosc'
	'c' => 'wartosc dla c'     
	 
	 i jeżeli w $table jest taka tablica j.w. a w $element jest 3 czyli chcemy trzeci element wyciągnąć to wynikiem ma być 'wartosc dla c'
	 
	 i napisać takiego foreach z $i gdzie $i bedzie się zaczynało od 1
	 
	 inkrementacja $i oraz sprawdzenie, wyciągnięcie po prostu trzeciego elementu dla $i równego 3 czyli takiego prostego ifa 
	 
	 więc trzeba puścić foreach i trzeba $i ustawić na 1 oraz w foreachu trzeba napisać ifa który w tym momencie dla $i = $element zwróci wartość z tablicy
	 
	 i w foreach będzie to co tam oznaczymy */
	 
	
	 
	 $tablicaAsocjacyjna = array(
		'a' => 'wartosc dla a',
		'b' => 'bartek',
		'c' => 'wartosc dowolna dla c'		
	);
	 
	 	function FindElementInTable($table, $element)
			{
				return $table[$element];	
			}
	
	/*function FindElementInTableForeach($table, $element)
	{
		 foreach ($table as $value)
		 {
		  $table[$value]==;
		 }
	}*/  
	
	
	echo FindElementInTable($tablicaAsocjacyjna, 'a');
	
	
			/* 
	2. funkcja która dla tekstu text, dla startu 1 i długości 2 wytnie => 'ex'; dla stringu beatka , 2 , 2 => ma się zwrócić at */
	
	function OwnSubstring($text, $start, $length)
	{
	//funkcje zabezpieczajace
	if ($start<0 || $start>strlen($text))
	{
		echo "PODANO ZLE PARAMETRY";
		return -1; // gwarantuje wyjście z funkcji
	}
	
	if ($length<0 || $length+$start>strlen($text))
	{
		echo "PODANO ZLE PARAMETRY";
		return -1; // gwarantuje wyjście z funkcji
	}
	
	
		$res='';
		//"BEATKA", 2,3 => ATK 
		for ($i = $start; $i < $start+$length ;$i++)//
			{
			$res .=  $text[$i]; //. znacznik konkatenacji stringow // to samo co $res = $res . $text[$i];
			}
		return $res;
	}
	
	echo OwnSubstring("Beatka", 2, 2);
	
	
	/* 
	3. zwrócić indeks pierwszej znalezionej litery w tekście, czyli dla stringu beatka i e => należy zwrócić indeks 1, dla beatka i a => 2 bo pierwszy 
	znaleziony jest drugi nie liczy się drugi znaleziony   */
	
	function LetterPosition ($text, $letter) 
	{
		for ($i=0; $i<strlen($text); $i++)
		{
			if ($text[$i]==$letter)
			return $i;
		}
		return -1;
	}
	
	echo LetterPosition ('beatka', 'e'); 
	
	 
	/* 4. funkcja policz literki, należy zwrócić tablice asocjacyjną jako wynik i dla stringu  beatka => ma wrócić tablica asocjacyjna dokładnie taka: 
	
	function CounterLetters($string)
	{
	beatka => array ('b' => 1, 'e' => 1, 'a' => 2, 't' => 1, 'k' => 1 ) // b jeden bo b występuje raz, e jednen bo występuje raz, 
																		// a dwa bo występuje dwa razy, t jeden bo występuje raz, 
	
	text => array ('t' => 2, 'e' => 1, 'x' => 1) // k jeden bo występuje jeden raz 
	}z*/
	 
	function CounterLetters($text)
	{
	
	$text= str_split($text); // funkcja, robi z $text tablice 

		foreach ($text as $value)
			{
				$count=0;
				foreach ($text as $value2)
				{
					if ($value2==$value)
						$count++;
				}		
					$wynik[$value]=$count;
			}
		return $wynik;		
	}


	 var_dump(CounterLetters("Beatka"));
	 
	 

?>
