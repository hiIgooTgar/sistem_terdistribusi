<!DOCTYPE html>
<html lang="id">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>UNIVERSITAS AMIKOM PURWOKERTO - Manajemen Data</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet">
    <style>
        .header-purple { background-color: #ba68c8; color: white; }
        .footer-purple { background-color: #ea80fc; color: black; font-size: 0.9rem; }
        .nav-tabs .nav-link.active { background-color: #ba68c8; color: white; border-color: #ba68c8; }
        .nav-tabs .nav-link { color: #ba68c8; font-weight: bold; }
        #alert-container {
            position: fixed;
            top: 20px;
            right: 20px;
            z-index: 1055;
            width: 350px;
        }
    </style>
</head>
<body class="bg-light">

<div id="alert-container"></div>

<div class="container my-5">
    <div class="card text-center shadow-sm mb-4">
        <div class="card-header header-purple py-3">
            <h3 class="m-0 fw-bold">UNIVERSITAS AMIKOM PURWOKERTO</h3>
        </div>
        <div class="card-body bg-white py-2">
            <h5 class="text-secondary m-0">SISTEM INFORMASI KEPEGAWAIAN</h5>
        </div>
    </div>

    <ul class="nav nav-tabs justify-content-center mb-4" id="mainTabs" role="tablist">
        <li class="nav-item" role="presentation">
            <button class="nav-link active px-4" id="jabatan-tab" data-bs-toggle="tab" data-bs-target="#panel-jabatan" type="button" role="tab" onclick="muatJabatan()">Data Jabatan</button>
        </li>
        <li class="nav-item" role="presentation">
            <button class="nav-link px-4" id="pegawai-tab" data-bs-toggle="tab" data-bs-target="#panel-pegawai" type="button" role="tab" onclick="muatPegawai()">Data Pegawai</button>
        </li>
    </ul>

    <div class="tab-content" id="mainTabsContent">
        
        <div class="tab-pane fade show active" id="panel-jabatan" role="tabpanel">
            <div class="mb-3 text-center">
                <button class="btn btn-sm btn-success px-4 shadow-sm" onclick="showTambahJabatan()">+ Tambah Jabatan</button>
            </div>
            <div class="row justify-content-center">
                <div class="col-md-8">
                    <div class="table-responsive shadow-sm rounded">
                        <table class="table table-bordered table-striped table-hover m-0 bg-white text-center">
                            <thead class="table-secondary">
                                <tr>
                                    <th>ID JABATAN</th>
                                    <th>NAMA JABATAN</th>
                                    <th>AKSI</th>
                                </tr>
                            </thead>
                            <tbody id="tabel-jabatan"></tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>

        <div class="tab-pane fade" id="panel-pegawai" role="tabpanel">
            <div class="mb-3 text-center">
                <button class="btn btn-sm btn-success px-4 shadow-sm" onclick="showTambahPegawai()">+ Tambah Pegawai</button>
            </div>
            <div class="row justify-content-center">
                <div class="col-md-10">
                    <div class="table-responsive shadow-sm rounded">
                        <table class="table table-bordered table-striped table-hover m-0 bg-white text-center">
                            <thead class="table-secondary">
                                <tr>
                                    <th>NIP</th>
                                    <th>NAMA PEGAWAI</th>
                                    <th>ALAMAT</th>
                                    <th>JABATAN</th>
                                    <th>AKSI</th>
                                </tr>
                            </thead>
                            <tbody id="tabel-pegawai"></tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>

    </div>

    <div class="card text-center shadow-sm mt-4">
        <div class="card-footer footer-purple py-2 text-muted">
            <strong>Igo Tegar Prambudhy - 24SA11A159</strong>
        </div>
    </div>
</div>

<div class="modal fade" id="modalJabatan" tabindex="-1" aria-hidden="true">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="titleJabatan">Tambah Jabatan</h5>
                <button type="button" class="btn-close" data-bs-dismiss="modal"></button>
            </div>
            <div class="modal-body">
                <form id="formJabatan">
                    <div class="mb-3">
                        <label class="form-label">ID Jabatan</label>
                        <input type="number" class="form-control" id="jabatan-id" required>
                    </div>
                    <div class="mb-3">
                        <label class="form-label">Nama Jabatan</label>
                        <input type="text" class="form-control" id="jabatan-nama" required>
                    </div>
                    <button type="submit" class="btn btn-primary w-100">Simpan Data</button>
                </form>
            </div>
        </div>
    </div>
</div>

<div class="modal fade" id="modalPegawai" tabindex="-1" aria-hidden="true">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <h5 class="modal-title" id="titlePegawai">Tambah Pegawai</h5>
                <button type="button" class="btn-close" data-bs-dismiss="modal"></button>
            </div>
            <div class="modal-body">
                <form id="formPegawai">
                    <div class="mb-3">
                        <label class="form-label">NIP</label>
                        <input type="text" class="form-control" id="pegawai-nip" maxlength="5" required>
                    </div>
                    <div class="mb-3">
                        <label class="form-label">Nama Lengkap</label>
                        <input type="text" class="form-control" id="pegawai-nama" required>
                    </div>
                    <div class="mb-3">
                        <label class="form-label">Alamat</label>
                        <input type="text" class="form-control" id="pegawai-alamat" required>
                    </div>
                    <div class="mb-3">
                        <label class="form-label">Jabatan</label>
                        <select class="form-select" id="pegawai-jabatan" required></select>
                    </div>
                    <button type="submit" class="btn btn-primary w-100">Simpan Data</button>
                </form>
            </div>
        </div>
    </div>
</div>

<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js"></script>

<script>
    const API_JABATAN = 'api.php?target=jabatan'; 
    const API_PEGAWAI = 'api.php?target=pegawai'; 

    let modalJabatan = new bootstrap.Modal(document.getElementById('modalJabatan'));
    let modalPegawai = new bootstrap.Modal(document.getElementById('modalPegawai'));
    
    let editJabatanMode = false;
    let editPegawaiMode = false;

    document.addEventListener("DOMContentLoaded", () => {
        muatJabatan();
    });

    function tampilkanNotif(pesan, tipe = 'success') {
        const alertContainer = document.getElementById('alert-container');
        const idAlert = 'alert-' + Date.now();
        
        const htmlAlert = `
            <div id="${idAlert}" class="alert alert-${tipe} alert-dismissible fade show shadow" role="alert">
                <strong>${tipe === 'success' ? 'Berhasil!' : 'Gagal!'}</strong> ${pesan}
                <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
            </div>
        `;
        
        alertContainer.insertAdjacentHTML('beforeend', htmlAlert);
        setTimeout(() => {
            const alertElement = document.getElementById(idAlert);
            if (alertElement) {
                let bsAlert = bootstrap.Alert.getOrCreateInstance(alertElement);
                bsAlert.close();
            }
        }, 4000);
    }

    function muatJabatan() {
        fetch(API_JABATAN)
            .then(res => res.json())
            .then(data => {
                let list = Array.isArray(data) ? data : data.data; 
                let html = '';
                let opsiJabatan = '<option value="">-- Pilih Jabatan --</option>';

                if(list && list.length > 0) {
                    list.forEach(row => {
                        html += `<tr>
                            <td>${row.id_jabatan}</td>
                            <td>${row.nama_jabatan}</td>
                            <td>
                                <button class="btn btn-primary btn-sm me-1" onclick="editJabatan(${row.id_jabatan}, '${row.nama_jabatan}')">Edit</button>
                                <button class="btn btn-danger btn-sm" onclick="hapusJabatan(${row.id_jabatan})">Delete</button>
                            </td>
                        </tr>`;
                        opsiJabatan += `<option value="${row.id_jabatan}">${row.nama_jabatan}</option>`;
                    });
                }
                document.getElementById('tabel-jabatan').innerHTML = html || '<tr><td colspan="3">Tidak ada data.</td></tr>';
                document.getElementById('pegawai-jabatan').innerHTML = opsiJabatan;
            })
            .catch(err => {
                console.error("Gagal memuat data jabatan:", err);
                tampilkanNotif("Gagal mengambil data jabatan dari server.", "danger");
            });
    }

    function showTambahJabatan() {
        editJabatanMode = false;
        document.getElementById('titleJabatan').innerText = "Tambah Jabatan";
        document.getElementById('jabatan-id').disabled = false;
        document.getElementById('formJabatan').reset();
        modalJabatan.show();
    }

    function editJabatan(id, nama) {
        editJabatanMode = true;
        document.getElementById('titleJabatan').innerText = "Edit Jabatan";
        document.getElementById('jabatan-id').value = id;
        document.getElementById('jabatan-id').disabled = true; 
        document.getElementById('jabatan-nama').value = nama;
        modalJabatan.show();
    }

    document.getElementById('formJabatan').addEventListener('submit', function(e) {
        e.preventDefault();
        let id = document.getElementById('jabatan-id').value;
        let nama = document.getElementById('jabatan-nama').value;
        let url = editJabatanMode ? `${API_JABATAN}&id=${id}` : API_JABATAN;
        let method = editJabatanMode ? 'PUT' : 'POST';

        fetch(url, {
            method: method,
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify({ id_jabatan: id, nama_jabatan: nama })
        })
        .then(res => res.json())
        .then(response => {
            modalJabatan.hide();
            muatJabatan();
            tampilkanNotif(response.message || "Data jabatan berhasil disimpan.", "success");
        })
        .catch(err => {
            console.error("Gagal menyimpan jabatan:", err);
            tampilkanNotif("Gagal memproses data jabatan.", "danger");
        });
    });

    function hapusJabatan(id) {
        if(confirm("Hapus data jabatan ini?")) {
            fetch(`${API_JABATAN}&id=${id}`, { method: 'DELETE' })
            .then(res => res.json())
            .then(response => {
                muatJabatan();
                tampilkanNotif(response.message || "Data jabatan berhasil dihapus.", "success");
            })
            .catch(err => {
                console.error("Gagal menghapus jabatan:", err);
                tampilkanNotif("Gagal menghapus data. Kemungkinan data relasi masih terikat pegawai.", "danger");
            });
        }
    }

    function muatPegawai() {
        fetch(API_PEGAWAI)
            .then(res => res.json())
            .then(data => {
                let list = Array.isArray(data) ? data : data.data;
                let html = '';
                if(list && list.length > 0) {
                    list.forEach(row => {
                        html += `<tr>
                            <td>${row.nip}</td>
                            <td>${row.nama}</td>
                            <td>${row.alamat}</td>
                            <td>${row.nama_jabatan ? row.nama_jabatan : row.id_jabatan}</td>
                            <td>
                                <button class="btn btn-primary btn-sm me-1" onclick="editPegawai('${row.nip}', '${row.nama}', '${row.alamat}', ${row.id_jabatan})">Edit</button>
                                <button class="btn btn-danger btn-sm" onclick="hapusPegawai('${row.nip}')">Delete</button>
                            </td>
                        </tr>`;
                    });
                }
                document.getElementById('tabel-pegawai').innerHTML = html || '<tr><td colspan="5">Tidak ada data.</td></tr>';
            })
            .catch(err => {
                console.error("Gagal memuat data pegawai:", err);
                tampilkanNotif("Gagal mengambil data pegawai dari server.", "danger");
            });
    }

    function showTambahPegawai() {
        editPegawaiMode = false;
        document.getElementById('titlePegawai').innerText = "Tambah Pegawai";
        document.getElementById('pegawai-nip').disabled = false;
        document.getElementById('formPegawai').reset();
        modalPegawai.show();
    }

    function editPegawai(nip, nama, alamat, id_jabatan) {
        editPegawaiMode = true;
        document.getElementById('titlePegawai').innerText = "Edit Pegawai";
        document.getElementById('pegawai-nip').value = nip;
        document.getElementById('pegawai-nip').disabled = true; 
        document.getElementById('pegawai-nama').value = nama;
        document.getElementById('pegawai-alamat').value = alamat;
        document.getElementById('pegawai-jabatan').value = id_jabatan;
        modalPegawai.show();
    }

    document.getElementById('formPegawai').addEventListener('submit', function(e) {
        e.preventDefault();
        let nip = document.getElementById('pegawai-nip').value;
        let nama = document.getElementById('pegawai-nama').value;
        let alamat = document.getElementById('pegawai-alamat').value;
        let id_jabatan = document.getElementById('pegawai-jabatan').value;

        let url = editPegawaiMode ? `${API_PEGAWAI}&id=${nip}` : API_PEGAWAI;
        let method = editPegawaiMode ? 'PUT' : 'POST';

        fetch(url, {
            method: method,
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify({ nip: nip, nama: nama, alamat: alamat, id_jabatan: id_jabatan })
        })
        .then(res => res.json())
        .then(response => {
            modalPegawai.hide();
            muatPegawai();
            tampilkanNotif(response.message || "Data pegawai berhasil disimpan.", "success");
        })
        .catch(err => {
            console.error("Gagal menyimpan pegawai:", err);
            tampilkanNotif("Gagal memproses data pegawai.", "danger");
        });
    });

    function hapusPegawai(nip) {
        if(confirm("Hapus data pegawai ini?")) {
            fetch(`${API_PEGAWAI}&id=${nip}`, { method: 'DELETE' })
            .then(res => res.json())
            .then(response => {
                muatPegawai();
                tampilkanNotif(response.message || "Data pegawai berhasil dihapus.", "success");
            })
            .catch(err => {
                console.error("Gagal menghapus pegawai:", err);
                tampilkanNotif("Gagal menghapus data pegawai.", "danger");
            });
        }
    }
</script>
</body>
</html>