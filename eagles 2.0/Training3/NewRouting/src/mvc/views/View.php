<?php

	namespace views;

	abstract class View
	{
		public abstract function Show($model); //renders html or xml or json
	}