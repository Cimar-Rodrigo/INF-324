<?php

namespace App\Controllers;

use App\Models\Persona_model;


class LoginController extends BaseController
{
    public function index()
    {
        return view('Login_view');
    }
    public function login()
    {
        $correo = $this->request->getPost('correo');

        $usuarioModel = new Persona_model();
        $usuarioValidado = $usuarioModel->where('correo', $correo)
        ->first();
        //mostrar usuarioValidado
        switch ($usuarioValidado['tipo']) {
            case "director_bancario":
                return redirect()->to('director')->with('success',$usuarioValidado);
                break;
            case "cliente":
                return redirect()->to('cliente')->with('success', $usuarioValidado);
                   break;
            default:
                return redirect()->to('login')->with('error', 'Credenciales incorrectas. Por favor, inténtalo de nuevo.');
                break;
        }
        //echo $usuarioValidado;

    }

}
