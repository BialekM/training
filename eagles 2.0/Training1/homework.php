<?php

	interface IStringOperations
	{
		public function GetName(); // podac swoje imie i nazwisko
		
		public function Strlen($text); // podac dlugosc stringu: beatka => 6
		
		public function Substring($text, $start, $length); //beatka 1, 4 => eatk
		
		public function StrPos($text, $needle); // beatka, eatk => 1; beatka, tk => 3 ; beatka, a => 2
		
		public function CountChars($text, $character); // beatka, a => 2; beatka, t => 1
		
		public function CountAllCharacters($text); //beatka => array('b' => 1, 'e' => 1, 'a' => 2 ....);
		
		public function StrReplace($text, $needle, $replace); // bartek, arte, beatka => bbeatkak
		
		public function function_test($param) {
		    
		}
	}