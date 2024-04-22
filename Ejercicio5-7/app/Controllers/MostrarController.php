<?php
namespace App\Controllers;


use App\Models\Cuenta_model;

class MostrarController extends BaseController
{
    public function index()
    {
        $model = new Cuenta_model();
        $data['cuenta'] = $model->findAll();

        //mostrar en consola los valores de data
        
        return view('Mostrar_view', $data);
    }

    //funcion para eliminar el dato
    public function eliminar()
    {
        $model = new Cuenta_model();
        $id_cuenta = $this->request->getPost('id_cuenta');
        $model->delete($id_cuenta);
        echo "Dato eliminado";
        return redirect()->to('inicio');
    }
}
// Path: code4/app/Controllers/MostrarController.php
// Compare this snippet from code4/app/Views/Mostrar_view.php:
// <!-- aqui mostraremos los datos de la tabla cuenta -->