<?php

// controlador para cliente, debe enviar la información del cliente a la vista

namespace App\Controllers;

use App\Models\Persona_model;

class ClienteController extends BaseController
{
    public function index()
    {
        $usuario = session('success');
        $personaModel = new Persona_model();
        $persona = $personaModel->where('correo', $usuario['correo'])
                                ->first();
        return view('Cliente_view', ['cliente' => $persona]);
    }
}
?>