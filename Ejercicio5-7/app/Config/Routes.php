<?php

use CodeIgniter\Router\RouteCollection;

/**
 * @var RouteCollection $routes
 */
$routes->get('/', 'Home::index');
$routes->get('inicio', 'MostrarController::index');
$routes->post('eliminar', 'MostrarController::eliminar');
$routes->post('login', 'LoginController::index');

$routes->post('sesion', 'LoginController::login');
$routes->get('director', 'DirectorController::index');
$routes->get('cliente', 'ClienteController::index');