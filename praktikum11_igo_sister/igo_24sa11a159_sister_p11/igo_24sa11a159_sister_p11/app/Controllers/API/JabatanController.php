<?php

namespace App\Controllers\Api;

use CodeIgniter\RESTful\ResourceController;

class JabatanController extends ResourceController
{
    protected $modelName = 'App\Models\JabatanModel';
    protected $format    = 'json';

    public function index()
    {
        $data = $this->model->findAll();
        
        return $this->respond([
            'status'  => 200,
            'error'   => null,
            'messages' => 'Data semua jabatan berhasil diambil',
            'data'    => $data
        ], 200);
    }

    public function show($id = null)
    {
        $data = $this->model->find($id);
        
        if (!$data) {
            return $this->failNotFound("Data jabatan dengan ID $id tidak ditemukan.");
        }
        
        return $this->respond([
            'status'  => 200,
            'error'   => null,
            'messages' => 'Data detail jabatan berhasil diambil',
            'data'    => $data
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
            'messages' => 'Data jabatan berhasil ditambahkan',
            'data'     => $data
        ]);
    }

    public function update($id = null)
    {
        if (!$this->model->find($id)) {
            return $this->failNotFound("Data jabatan dengan ID $id tidak ditemukan.");
        }

        $data = $this->request->getRawInput();

        if (!$this->model->update($id, $data)) {
            return $this->failValidationErrors($this->model->errors());
        }

        return $this->respond([
            'status'   => 200,
            'error'    => null,
            'messages' => "Data jabatan dengan ID $id berhasil diperbarui",
            'data'     => $data
        ], 200);
    }

    public function delete($id = null)
    {
        if (!$this->model->find($id)) {
            return $this->failNotFound("Data jabatan dengan ID $id tidak ditemukan.");
        }

        try {
            $this->model->delete($id);
            return $this->respondDeleted([
                'status'   => 200,
                'error'    => null,
                'messages' => "Data jabatan dengan ID $id berhasil dihapus"
            ], 200);
        } catch (\Exception $e) {
            return $this->fail("Gagal menghapus data. ID Jabatan ini masih digunakan oleh data pegawai.", 400);
        }
    }
}