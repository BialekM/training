<?php

require_once('StringOperators.php');
require_once('DateOperators.php');
require_once'../../GhostRider/Homework/PeselValidation.php';

class PerlaPeselValidation extends PeselValidation {
	
	protected $stringsHandler;// = new PerlaStringOperators();
	
	public function __construct()
	{
		$this->stringsHandler = new PerlaStringOperators();
	}

    public function CutOffDate($pesel) {

        //$this->stringsHandler->

        $year = $this->stringsHandler->PerlaSubStr($pesel, 0, 2);
        $month = $this->stringsHandler->PerlaSubStr($pesel, 2, 2);
        $day = $this->stringsHandler->PerlaSubStr($pesel, 4, 2);

        return $result = array('year' => $year, 'month' => $month, 'day' => $day);
    }

    public function DateValidation($year, $month, $day) {
        $dateHandler = new DateOperators;

        $isYearCorrect = $dateHandler->CheckYear($year);
        $isMonthCorrect = $this->DecreaseMonthByTwenty($month);
        $isDayCorrect = $dateHandler->CheckDay($year, $month, $day);
        $result = array($isYearCorrect, $isMonthCorrect, $isDayCorrect);

        return $result;
    }

    public function CheckSum($pesel) {
        $stringsHandler = new PerlaStringOperators;

        $lastNumber = $stringsHandler->PerlaSubStr($pesel, 10, 1);

        $peselChars = $stringsHandler->PerlaCharArray($pesel);
        $peselCharsSum = $peselChars[0] + 3 * $peselChars[1] + 7 * $peselChars[2] + 9 * $peselChars[3] + $peselChars[4] +
                3 * $peselChars[5] + 7 * $peselChars[6] + 9 * $peselChars [7] + $peselChars[8] + 3 * $peselChars[9];
        $peselCharsSum = strval($peselCharsSum);
        $peselCharsSumLength = $stringsHandler->PerlaStrLen($peselCharsSum);
        $peselCharsSumLastCharacter = $stringsHandler->PerlaSubStr($peselCharsSum, $peselCharsSumLength - 1, 1);


        $checkSum = $peselCharsSumLastCharacter % 10;
        if ($checkSum === $lastNumber AND $checkSum === 0) {
            return TRUE;
        } else if (10 - $checkSum === $lastNumber) {
            return TRUE;
        } else {
            return FALSE;
        }
    }

    public function ValidatePesel($pesel) {

        $stringsHandler = new PerlaStringOperators;
        if ($stringsHandler->PerlaStrLen($pesel) === 11) {
            $lengthConfirmation = TRUE;
        } else {
            $lengthConfirmation = FALSE;
        }
        if ($this->CheckSum($pesel)) {
            $date = $this->CutOffDate($pesel);

            $checkSumConfirmation = TRUE;
        } else {
            $checkSumConfirmation = FALSE;
        }
        if ($checkSumConfirmation) {
            $dateConfirmation = $this->DateValidation($date['year'], $date['month'], $date['day']);
        } else {
            $dateConfirmation = FALSE;
        }

        if ($lengthConfirmation && $dateConfirmation AND $checkSumConfirmation) {
            return TRUE;
        } else {
            return FALSE;
        }
    }

    public function DecreaseMonthByTwenty($month) {
        $dateHandler = new DateOperators;

        for ($i = $month; $i > 0; $i = $i - 20) {
            if ($dateHandler->CheckMonth($i) == TRUE) {
                return TRUE;
            }
        }
        return FALSE;
    }

}
$pesel_test = new PerlaPeselValidation();
