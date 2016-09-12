<?php
/**
 * Created by PhpStorm.
 * User: ICE
 * Date: 2016-09-10
 * Time: 13:21
 */
interface IStringOperations
{
    public function GetName(); // podać swoje imie i nazwisko
    public function Strlen($text); //podać długość stringu: beatka => 6
    public function Substring($start, $lenght); // beatka 1,4 => eatk

    public function StrPos($niddle); //beatka, eatk => 1; beatka, tk => 3, beatka, a => 2
    public function CountCharacters ($text, $character); // beatka, a =>2, beatka, t => 1
    public function CountAllCharacters ($text); //ma zwrócić tablicę asocjacyjną //beatka => array('b'=> 1, 'e' => 1 , 'a' => 2 ...);
    public function StrReplace ($text, $needle, $replace); //bartek, arte, beatka => bbeatkak
}