<?php

namespace App\Controllers;

class Home extends BaseController
{
    public function index(): string
    {
        return view('hola');
    }

    public function hola(): string
    {
        echo "Hola mundo";
    }

}
