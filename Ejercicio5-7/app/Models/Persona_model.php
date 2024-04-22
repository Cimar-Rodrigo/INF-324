<?php
namespace App\Models;

use CodeIgniter\Model;

class Persona_model extends Model
{
    protected $table = 'persona';
    protected $primaryKey = 'carnet'; 
    protected $allowedFields = ['carnet', 'nombre', 'apellido','departamento','correo','tipo'];

}