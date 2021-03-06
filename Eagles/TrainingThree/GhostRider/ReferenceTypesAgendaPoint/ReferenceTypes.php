<?php

	class ReferenceTypes
	{
		public $text;
	}
	
	
	class TextOperations
	{
		public function AnagramOperation(ReferenceTypes $textContainer)
		{
			$textContainer->text = "slowo na niedziele";
			
			$textContainer = new ReferenceTypes();
			$textContainer->text = "wpis";
		}
		
		public function PalindromOperation(ReferenceTypes $textContainer)
		{
			$textContainer->text = "slowo palindromowe";
		}
	}
	
	class DateOperations
	{
		public function ValidationOperation(ReferenceTypes $textContainer)
		{
			$textContainer->text = "slowo na date";
		}
		
		public function FinalOperation(ReferenceTypes $textContainer)
		{
			$textContainer->text = "slowo finalne";
		}
	}
	
	$refText = new ReferenceTypes();
	
	$textOp = new TextOperations();
	$dateOp = new DateOperations();
	
	$refText->text = "poczatek";
	
	$textOp->AnagramOperation($refText);
	
	echo $refText->text;
	
	$textOp->PalindromOperation($refText);
	
	$dateOp->ValidationOperation($refText);
	
	echo $refText->text;
	