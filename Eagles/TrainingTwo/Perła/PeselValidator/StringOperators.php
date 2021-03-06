<?php

class PerlaStringOperators {

    public function PerlaStrLen($string) {
        
        $num_of_chars = 0;
        for ($i = 0; isset($string[$i]); $i++) {
            $num_of_chars++;
        }
        //var_dump($num_of_chars);
        return $num_of_chars;
    }

    public function PerlaSubStr($string, $start = 0, $end) {
        
        $new_string = '';
        $end = $start + $end;
        for ($i = $start; $i < $end; $i++) {
            $new_string .= $string[$i];
        }
        return $new_string;
    }

    public function PerlaCharArray($string) {
        
        $stringLength = $this->PerlaStrLen($string);
        $result = array();
        for($i = 0 ; $i < $stringLength-1 ; $i++)
        {
            $result[] = $this->PerlaSubStr($string,$i,1);
        }
        return $result;
    }

}
