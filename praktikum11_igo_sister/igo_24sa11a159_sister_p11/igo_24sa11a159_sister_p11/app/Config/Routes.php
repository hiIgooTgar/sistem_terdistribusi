<?php

use CodeIgniter\Router\RouteCollection;

/** @var RouteCollection $routes */
$routes->get('/', 'Home::index');

$routes->resource('api/jabatan', ['controller' => '\App\Controllers\Api\JabatanController']);
$routes->resource('api/pegawai', ['controller' => '\App\Controllers\Api\PegawaiController']);