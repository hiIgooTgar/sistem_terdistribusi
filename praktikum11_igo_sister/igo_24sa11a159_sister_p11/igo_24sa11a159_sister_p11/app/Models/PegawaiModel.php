<?php

namespace App\Models;

use CodeIgniter\Model;

class PegawaiModel extends Model
{
    protected $table            = 'tb_pegawai';
    protected $primaryKey       = 'id_pegawai';
    protected $useAutoIncrement = true;
    protected $returnType       = 'array';
    protected $useSoftDeletes   = false;
    protected $protectFields    = true;
    protected $allowedFields    = ['nip', 'nama', 'alamat', 'id_jabatan'];

    protected bool $allowEmptyInserts = false;
    protected bool $updateOnlyChanged = true;

    protected array $casts = [];
    protected array $castHandlers = [];

    // Dates
    protected $useTimestamps = false;
    protected $dateFormat    = 'datetime';
    protected $createdField  = 'created_at';
    protected $updatedField  = 'updated_at';
    protected $deletedField  = 'deleted_at';

    // Validation
   protected $validationRules = [
        'nip'        => 'required|exact_length[5]|is_unique[tb_pegawai.nip,nip,{nip}]',
        'nama'       => 'required|min_length[3]|max_length[35]',
        'alamat'     => 'required|max_length[40]',
        'id_jabatan' => 'required|numeric|is_not_unique[tb_jabatan.id_jabatan]',
    ];

    protected $validationMessages = [
        'nip' => [
            'required'     => 'NIP wajib diisi.',
            'exact_length' => 'NIP harus tepat 5 karakter.',
            'is_unique'    => 'NIP sudah digunakan.',
        ],
        'id_jabatan' => [
            'is_not_unique' => 'ID Jabatan tidak valid atau tidak ditemukan di tabel jabatan.',
        ],
    ];

   
    protected $skipValidation       = false;
    protected $cleanValidationRules = true;

    // Callbacks
    protected $allowCallbacks = true;
    protected $beforeInsert   = [];
    protected $afterInsert    = [];
    protected $beforeUpdate   = [];
    protected $afterUpdate    = [];
    protected $beforeFind     = [];
    protected $afterFind      = [];
    protected $beforeDelete   = [];
    protected $afterDelete    = [];


     public function getPegawaiWithJabatan($id = null)
    {
        $builder = $this->db->table($this->table)
            ->select('tb_pegawai.*, tb_jabatan.nama_jabatan')
            ->join('tb_jabatan', 'tb_jabatan.id_jabatan = tb_pegawai.id_jabatan');

        if ($id !== null) {
            return $builder->where('tb_pegawai.nip', $id)->get()->getRowArray();
        }

        return $builder->get()->getResultArray();
    }
}
