<?php
// controlador para director
namespace App\Controllers;

use App\Models\Persona_model;

class DirectorController extends BaseController
{
    public function index()
    {
        $usuario = session('success');
        $usuarioModel = new Persona_model();
        echo $usuario['tipo'];
        //$clientes = $usuarioModel->where('departamento', $usuario['departamento'])
        //                         ->findAll();
        //$suma_total = 0;
        //foreach ($clientes as $cliente) {
        //    $suma_total += $cliente['cuenta'];
        //}
        //return view('Director_view', ['director' => $usuario, 'suma_total' => $suma_total]);
    }
}
?>