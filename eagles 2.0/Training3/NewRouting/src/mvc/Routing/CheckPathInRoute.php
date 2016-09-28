<?php

	namespace Routing;

	class CheckPathInRoute
	{
		public function StartCheckPathInRoute($prefix, $path, $redirectUrl)
		{
			return $this->ComparingPath($prefix, $path , $redirectUrl);
		}
		
		protected function ComparingPath($prefix, $path, $redirectUrl)
		{
			$ExplodeRedirectUrl = $this->ExplodePath($redirectUrl);
			$ExplodeItemRoute = $this->ExplodePath($prefix . $path);
			
			if(count($ExplodeItemRoute) == count($ExplodeRedirectUrl))
			{
				for($i = 0; $i < count($ExplodeItemRoute); $i++)
				{
					if(!$this->WhetherParameter($ExplodeItemRoute[$i]))
					{
						if(!($ExplodeItemRoute[$i] == $ExplodeRedirectUrl[$i]))
						{
							return false;
						}
					}
				}
			}
			else
			{
				return false;
			}
			
			return true;
		}
		
		protected function ExplodePath($path)
		{
			return $this->MultiExplode(array("/"), $path);
		}
		
		protected function MultiExplode($delimiters, $string)
		{
			$ready = str_replace($delimiters, $delimiters[0], $string);
				
			return  explode($delimiters[0], $ready);
		}
		
		protected function WhetherParameter($string)
		{
			if(strlen($string) > 2)
			{
				return ($string[0] == "{" && $string[strlen($string) - 1] == "}");
			}
			
			return false;
		}
		
		public function GetParametersWithUrl($redirectUrl, $path)
		{
			$result = array();
			$explodeRedirectUrl = $this->ExplodePath($redirectUrl);
			
			foreach($this->ExplodePath($path) as $key => $value)
			{
				if($this->WhetherParameter($value))
				{
					$result[str_replace(array("{", "}"), "", $value)] = $explodeRedirectUrl[$key];
				}
			}
			
			return $result;
		}
	}