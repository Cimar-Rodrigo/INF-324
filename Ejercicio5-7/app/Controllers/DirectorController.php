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

        $datos = $usuarioModel->where('correo', $usuario['correo'])
                             ->first();

        $data = ['datos' => $datos];

        $tablita = $usuarioModel->query("
        SELECT 
      sum(CASE when departamento= 'Potosi' then monto else 0 end)as Potosi,
      sum(CASE when departamento= 'La Paz' then monto else 0 end)as La_Paz,
      sum(CASE when departamento= 'Cochabamba' then monto else 0 end)as Cochabamba,
      sum(CASE when departamento= 'Oruro' then monto else 0 end)as Oruro,
      sum(CASE when departamento= 'Beni' then monto else 0 end)as Beni,
      sum(CASE when departamento= 'Tarija' then monto else 0 end)as Tarija,
      sum(CASE when departamento= 'Chuquisaca' then monto else 0 end)as Chuquisaca,
      sum(CASE when departamento= 'Santa Cruz' then monto else 0 end)as Santa_Cruz,
      sum(CASE when departamento= 'Pando' then monto else 0 end)as Pando
          
      FROM persona JOIN cuenta on persona.carnet = cuenta.carnet
        ") ->getResultArray();

        $data['tabla'] = $tablita[0];

        return view('Director_view', $data);
    }
}
?>
