<?php 

function PieknyT_strlen($text)
{
	$lenght = 0;

	for ($i = 0; isset($text[$i]); $i++)
	{
		$lenght+=1;
	}

	return  $lenght;
}


function PieknyT_substr($text, $count)
{ // pseudo substr -" $count ilo�c elementow jakie nale�y wycia� od pozycji 0";
	$result='';
	
	for ($i = 0; $i < $count; $i++)
	{
		$result.= $text[$i];
	}
	return $result;
}




