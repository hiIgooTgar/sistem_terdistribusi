<?php

namespace App\Controllers\Api;

use CodeIgniter\RESTful\ResourceController;

class PegawaiController extends ResourceController
{
    protected $modelName = 'App\Models\PegawaiModel';
    protected $format    = 'json';

    public function index()
    {
        $data = $this->model->getPegawaiWithJabatan();
        
        return $this->respond([
            'status'   => 200,
            'error'    => null,
            'messages' => 'Data semua pegawai berhasil diambil',
            'data'     => $data
        ], 200);
    }

    public function show($id = null)
    {
        $data = $this->model->getPegawaiWithJabatan($id);
        
        if (!$data) {
            return $this->failNotFound("Data pegawai dengan NIP $id tidak ditemukan.");
        }
        
        return $this->respond([
            'status'   => 200,
            'error'    => null,
            'messages' => 'Data detail pegawai berhasil diambil',
            'data'     => $data
        ], 200);
    }

    public function create()
    {
        $data = $this->request->getPost() ?? $this->request->getJSON(true);
        if (!$this->model->insert($data)) {
            return $this->failValidationErrors($this->model->errors());
        }

        return $this->respondCreated([
            'status'   => 201,
            'error'    => null,
            'messages' => 'Data pegawai berhasil ditambahkan',
            'data'     => $data
        ]);
    }

    public function update($id = null)
    {
        if (!$this->model->find($id)) {
            return $this->failNotFound("Data pegawai dengan NIP $id tidak ditemukan.");
        }

        $data = $this->request->getRawInput();
        if (!$this->model->update($id, $data)) {
            return $this->failValidationErrors($this->model->errors());
        }

        return $this->respond([
            'status'   => 200,
            'error'    => null,
            'messages' => "Data pegawai dengan NIP $id berhasil diperbarui",
            'data'     => $data
        ], 200);
    }

    public function delete($id = null)
    {
        if (!$this->model->find($id)) {
            return $this->failNotFound("Data pegawai dengan NIP $id tidak ditemukan.");
        }

        $this->model->delete($id);
        
        return $this->respondDeleted([
            'status'   => 200,
            'error'    => null,
            'messages' => "Data pegawai dengan NIP $id berhasil dihapus"
        ], 200);
    }
}