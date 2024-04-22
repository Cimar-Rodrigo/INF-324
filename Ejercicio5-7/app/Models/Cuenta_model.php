<?php
// haz el modelado de cuenta tiene los siguientes datos id_cuenta. carnet, monto, tipo,estado

namespace App\Models;

use CodeIgniter\Model;


class Cuenta_model extends Model
{
    protected $table      = 'cuenta';
    protected $primaryKey = 'id_cuenta';

    protected $returnType     = 'array';
    protected $useSoftDeletes = false;

    protected $allowedFields = ['id_cuenta','carnet', 'tipo', 'monto', 'estado'];

    protected $validationRules    = [];
    protected $validationMessages = [];
    protected $skipValidation     = false;
}


// Path: code4/app/Models/Cuenta_model.php
// Compare this snippet from code4/app/Views/Mostrar_view.php:
// <!-- aqui mostraremos los datos de la tabla cuenta -->












