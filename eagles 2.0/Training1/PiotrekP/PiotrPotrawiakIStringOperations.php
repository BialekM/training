<?php
/**
 * Created by PhpStorm.
 * User: ICE
 * Date: 2016-09-09
 * Time: 22:25
 */

function drk ($x)
{
    echo '<pre>';print_r($x);echo '</pre>';
}



//normalnie przydałoby się pewnie zdefiniować PATH globalną projektu (str startową), PATH zasobów
require_once '../IStringOperations.interface.php';

        class PiotrPotrawiakIStringOperations implements IStringOperations
        {
            protected $myName = "smk: Piotr Potrawiak";
            protected $workingString='';
            protected $stringLenght = 0;
            protected $stringProcess = '';


            protected $theText = array(); //uzycie tego nie wyszło w Strlen, zostawiam do przeanalizowania, używam później jako substringa



            public function GetName()
            {
                return $this->myName;
            }

            public function Strlen($text) //$text => 'dupa'
            {
                //$length = count(str_split($string)); dziobie od razu w wyniku długośc stringa, zostawiam, żeby "pamiętac" że jest coś takieo

                $i=0; //może być niepotrzebne, jak sprawdzić czy jest niepotrzebne #pyt 2.
               //$this->theText = (array)strlen($text); //element 0 => , tylko ilosc znaków, typ array
               //$this->theText = (array)$text; //element 0 => tresc przekazanej zmiennej , typ array,  size 1, lenght 4
                $this->theText =$text; //pod typ zm array theText => wciska string i zamienia typ na string, i żeby uniknąc wywalenie NOTICE trzeba zamałpic zmienną w pętli
              //  var_dump($this->theText);
                while (isset($this->theText[$i]) != '') {
                    $i++;
                }
                return $this->stringLenght=$i;
            }


            public function Substring($start, $lenght)
            {
                $this->stringProcess='';

                if ($start <= $this-> stringLenght){
                    for ($x=$start; $x<=$lenght+$start; $x++)
                    {
                        echo $this->workingString[$x];
                        $this->stringProcess.=$this->workingString[$x];
                    }
                    echo " || od znaku $start, przez $lenght znaków dla pętli for, co jest kłopotliwe,".'<br>';

                }else {
                    echo '<br>parametr: $start='."$start, i jest większy od długości stringu, popraw parametry dla metody ".__CLASS__ .' ' . __FUNCTION__ ."<br>\n" ;
                }

                return $this->stringProcess;
            }


            public function StrPos($niddle) //beatka, eatk => 1; beatka, tk => 3, beatka, a => 2
            {
                $localFullLenght=$this->stringLenght; //przed podmienieniem długości stringa, na potrzeby metody, zachowuję wcześniej obliczoną wartość do zmiennej lokalnej
                $needleLenght=$this->Strlen($niddle)-1; //ile znaków mam jednocześnie szukac, np 2 = 0 , 1, 2 => #pyt 1.

                echo "<br> \n aktualna szerokośc niddle: ".$needleLenght ."\n <br> poszukiwany string: " . $this->theText. "<br> \n pełna długość stringa ".$localFullLenght."<br><br>\n\n";

                    for ($x=0 ; $x <= $localFullLenght ; $x++) //maksymalna iość przejść pętli wynikająca z długości stringa, i obcinanie stringa
                    {
                        $localText = $this->Substring($x,$needleLenght);
                        //debug
                        //echo $x.' # '. $localText . '<br>';
                        if ($localText == $niddle)
                        {
                            echo "<br><br>\n\nmamy TO!: ".$x; break;
                        }
                    }

            }


            public function CountCharacters($text, $character)
            {
                // TODO:    public function CountCharacters ($text, $character); // beatka, a =>2, beatka, t => 1
            }


            public function CountAllCharacters($text)
            {
                // TODO:    public function CountAllCharacters ($text); //ma zwrócić tablicę asocjacyjną //beatka => array('b'=> 1, 'e' => 1 , 'a' => 2 ...);
            }

            public function StrReplace($text, $needle, $replace)
            {
                // TODO:    public function StrReplace ($text, $needle, $replace); //bartek, arte, beatka => bbeatkak
            }


        }






        class doJob extends PiotrPotrawiakIStringOperations
        {
            public function __construct($text)
            {
                $this-> workingString = $text;
                $this ->stringLenght = $this->Strlen($this->workingString);
                echo $this->GetName();
                echo "<br> Utworzony string: $this->workingString <br>Ilość znaków: $this->stringLenght<br>";

//                echo "<br>Object created => CLASS:".__CLASS__.' FUNCTION: '.__FUNCTION__ .'<br>';
                echo 'Substring: ';
                echo $this->Substring(6,7);

                //metoda nie działa dla stringów krótszych niż 3 znaki i słowach po spacji
                $this->Strpos('atk');

            }


        }



$ob = new doJob('beatka pitupitu');
drk ($ob);

echo '<br>::koniec i bomba, a kto to czytał ten trąba..<br>EOF<br>';




