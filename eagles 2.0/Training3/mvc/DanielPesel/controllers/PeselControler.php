<?php


class DanielPeselController extends Controller
{
    protected  $PeselVar = array(1, 3, 7, 9, 1, 3, 7, 9, 1, 3, 1);
         
    public function Run(Model $model)
    {
        
    }
    
    Public function DanielPesel()
    {        
        $NewPeselModel = new PeselModel();
        $view = new PeselView();        
        echo $view->Show($NewPeselModel);          
                      
    }   
    
    protected function PeselPregCheck($value)
    {
    	if (!preg_match('/^[0-9]{11}$/',$value))
    	{
    		echo "niepoprawna watosc";
    		exit();
    	}    	
    }
    
    protected function PeselCheckSum($value)
    {
    	if (!(substr($value%10,-1,1)==0))
    	{
    		echo  "niepoprawna watosc";
    		exit();
    	}
    }
    
    public function PeselValidation($value)
        {
    		$this->PeselPregCheck($value);    		
            $checksum=0;               
            foreach (str_split($value)as $key => $number)
            {
               $checksum+=$number*$this->PeselVar[$key];
            }         			
            $this->PeselCheckSum($checksum);			
        }   
    
}

if (isset($_POST['pesel']))
{
	$validation = new DanielPeselController();
	$validation->PeselValidation($_POST['pesel']);
	exit();
}

