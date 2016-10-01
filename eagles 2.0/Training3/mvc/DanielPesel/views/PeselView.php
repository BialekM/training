<?php
class PeselFront
{

    public static function AddTextBox($label, $name, $value)
    {
        return '</label><input  type="textbox" name="'.$name.'" value="'.$value.'" />';
    }
    public static function AddSubmitButton($label, $name)
    {
        return '<input type="submit" name="'.$name.'" value="'.$label.'" />';
    }

}

class PeselView extends View
{
   
    
    public function Show(Model $model)
        {
             $result = '<form method="POST" action="'.$_SERVER['PHP_SELF'].'"><div>';
             $result .= '</div>';
             $result .= Peselfront::AddTextBox('pesel', 'pesel', 'pesel');
             $result .= Peselfront::AddSubmitButton('zatwierdz', 'confirm');
             $result .= '</form>';   
             
             return $result;
             
             
        }
        
    
}



