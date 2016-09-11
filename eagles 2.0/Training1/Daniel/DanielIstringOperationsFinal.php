<?php

interface IStringOperations
 {
		public function GetName();
		
 		public function Strlen($text);

 		public function Substring($text,$start,$lenght);

 		public function StrPos($text,$needle);

 		public function CountChars($text,$character);

		public function CountAllCharacters($text);
		
		public function StrReplace($text, $needle, $replace);

 }
 
 
class DanielStringOperations implements IStringOperations
{
	public $stringlenght;
	public $cuttext;
	public $count;
	public $stringpos;
	public $replaceString;
	public $find;
	
	
function GetName()
{
	echo "Daniel Bednarczuk";
}

function Strlen($text)
	{
		$i=0;
		while(@($text[$i]))
		{
			$i++;
		}
	
		$this->stringlenght=$i;
	}
	
function Substring($text,$start,$lenght)
	{
		$i=0;
		$j=0;
	
		while(@($text[$i]))
		{
			if(($i>=$start)&&($i<=$start+$lenght))
			{
				$cut[$j]=$text[$i];
				$j++;
			}
			$i++;
		}
	
		$cut=implode('', $cut);
		$this->cuttext=$cut;
	}	
	
function CountChars($text,$character)
	{
		$i=0;
		while(@($text[$i]))
		{
			if($text[$i]==$character)
			{
				$this->count++;
			}
			$i++;
		}
	}
	
function CountAllCharacters($text)
	{
		$i=0;
	
		while(@($text[$i]))
		{
			$this->CountChars($text, $text[$i]);
			$tab[$text[$i]]= $this->count;
			$this->count=0;
			$i++;
			
		}
		var_dump($tab);
	}		
	
function StrPos($text,$needle)
	{
		$i=0;
		$j=0;
		$k=0;
		$this->find=false;
	
		$this->Strlen($needle);
		$needlelenght = $this->stringlenght;
	
		$this->Strlen($text);
		$textlenght=$this->stringlenght;
	
		while($j<$needlelenght)
		{
			while($i<$textlenght)
			{
				if($text[$i]==$needle[$j])
				{
					while($k<=$needlelenght)
					{
						if (@($text[$i+$k]==$needle[$j+$k]))
						{
							$k++;
						}
						else break;
	
	
						if($k==$needlelenght)
						{
							$this->find=true;
							$pos=$i;
							$this->stringpos=$i;
	
						}
					}
					$k=0;
				}
				$i++;
			}
			$j++;
		}
		
	
		if(($this->find==false))
		{
			echo "nie znaleziono wyrazenia  ";			
			
		}	
	}	
	
function StrReplace($text,$needle,$replace)
	{
		$i=0;
		
		$this->StrPos($text, $needle);		
			
		if($this->find==false) exit();
		
	
		$this->Strlen($text);
		$textlenght=$this->stringlenght-1;
		
		$this->Strlen($needle);
		$needlelenght=$this->stringlenght;				
			
		$pos=$this->stringpos;	
					
		while($i<$pos)
		{
			$this->replaceString.=$text[$i];
			$i++;
		}
		
		$this->replaceString.=$replace;			
		$i=$i+$needlelenght;	
		
		while($i<=$textlenght)
		{
			$this->replaceString.=$text[$i];
			$i++;
			
		}
			
	
}	
	
}

$a = new DanielStringOperations();

$a->GetName();
echo '<br>';

$a->Strlen('beatka');
echo 'dlugosc slowa to '; 
echo $a->stringlenght;
echo '<br>';
	
$a->Substring('testeststsetsetsetsets', 3, 4);
echo 'wyciety text: ';
echo $a->cuttext;
echo '<br>';

$a->CountChars('beatkabeatkabeatka','a');
echo 'ilosc liter ';
echo $a->count;
echo '<br>';

$a->CountAllCharacters('beatkabeatka');
echo '<br>';

$a->StrPos('beatka', 'eat');
echo "pozycja poczatku wyrazenia to ";
echo $a->stringpos;
echo '<br>';

$a->StrReplace('bartek','ate','betka');
echo $a->replaceString;


	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
