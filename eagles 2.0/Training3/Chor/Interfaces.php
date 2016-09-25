<?php

	interface IHandler
	{
		public function Handle(IRefTypeStrategy &$strategy);
	}
	
	interface IRefTypeStrategy
	{
		
	}
	
	interface IChorHandler
	{
		public function Run();
	}