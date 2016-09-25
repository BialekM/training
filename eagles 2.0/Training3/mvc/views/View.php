<?php

	abstract class View
	{
		public abstract function Show(Model $model); //renders html or xml or json
	}