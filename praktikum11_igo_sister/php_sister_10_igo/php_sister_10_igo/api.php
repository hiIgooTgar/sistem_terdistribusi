<?php
header("Access-Control-Allow-Origin: *");
header("Content-Type: application/json; charset=UTF-8");
header("Access-Control-Allow-Methods: GET, POST, PUT, DELETE, OPTIONS");
header("Access-Control-Allow-Max-Age: 3600");
header("Access-Control-Allow-Headers: Content-Type, Access-Control-Allow-Headers, Authorization, X-Requested-With");

if ($_SERVER['REQUEST_METHOD'] === 'OPTIONS') {
    http_response_code(200);
    exit();
}

$host = "localhost";
$username = "root";
$password = "";
$database = "kepegawaian"; 

$conn = new mysqli($host, $username, $password, $database);

if ($conn->connect_error) {
    http_response_code(500);
    die(json_encode(["message" => "Koneksi database gagal: " . $conn->connect_error]));
}

$target = isset($_GET['target']) ? $_GET['target'] : 'jabatan';
$method = $_SERVER['REQUEST_METHOD'];

switch ($method) {

    case 'GET':
        if ($target === 'pegawai') {
            if (isset($_GET['id']) && $_GET['id'] !== '') {
                $id = $conn->real_escape_string($_GET['id']);
                $query = "SELECT p.*, j.nama_jabatan FROM tb_pegawai p 
                          LEFT JOIN tb_jabatan j ON p.id_jabatan = j.id_jabatan 
                          WHERE p.nip = '$id'";
                $result = $conn->query($query);
                $data = $result->fetch_assoc();
            } else {
                $query = "SELECT p.*, j.nama_jabatan FROM tb_pegawai p 
                          LEFT JOIN tb_jabatan j ON p.id_jabatan = j.id_jabatan";
                $result = $conn->query($query);
                $data = [];
                if ($result) {
                    while ($row = $result->fetch_assoc()) {
                        $data[] = $row;
                    }
                }
            }
        } else {
            if (isset($_GET['id']) && $_GET['id'] !== '') {
                $id = intval($_GET['id']);
                $query = "SELECT * FROM tb_jabatan WHERE id_jabatan = $id";
                $result = $conn->query($query);
                $data = $result->fetch_assoc();
            } else {
                $query = "SELECT * FROM tb_jabatan";
                $result = $conn->query($query);
                $data = [];
                if ($result) {
                    while ($row = $result->fetch_assoc()) {
                        $data[] = $row;
                    }
                }
            }
        }
        http_response_code(200);
        echo json_encode($data ? $data : []);
        break;

    case 'POST':
        $input = json_decode(file_get_contents('php://input'), true);
        
        if ($target === 'pegawai') {
            if (!empty($input['nip']) && !empty($input['nama']) && !empty($input['alamat']) && !empty($input['id_jabatan'])) {
                $nip = $conn->real_escape_string($input['nip']);
                $nama = $conn->real_escape_string($input['nama']);
                $alamat = $conn->real_escape_string($input['alamat']);
                $id_jabatan = intval($input['id_jabatan']);

                $query = "INSERT INTO tb_pegawai (nip, nama, alamat, id_jabatan) VALUES ('$nip', '$nama', '$alamat', $id_jabatan)";
                if ($conn->query($query)) {
                    http_response_code(201);
                    echo json_encode(["message" => "Pegawai berhasil ditambahkan."]);
                } else {
                    http_response_code(500);
                    echo json_encode(["message" => "Gagal menyimpan ke database."]);
                }
            } else {
                http_response_code(400);
                echo json_encode(["message" => "Data pegawai tidak lengkap."]);
            }
        } else {
            if (!empty($input['id_jabatan']) && !empty($input['nama_jabatan'])) {
                $id = intval($input['id_jabatan']);
                $nama = $conn->real_escape_string($input['nama_jabatan']);
                
                $query = "INSERT INTO tb_jabatan (id_jabatan, nama_jabatan) VALUES ($id, '$nama')";
                if ($conn->query($query)) {
                    http_response_code(201);
                    echo json_encode(["message" => "Jabatan berhasil ditambahkan."]);
                } else {
                    http_response_code(500);
                    echo json_encode(["message" => "Gagal menyimpan ke database."]);
                }
            } else {
                http_response_code(400);
                echo json_encode(["message" => "Data jabatan tidak lengkap."]);
            }
        }
        break;

    case 'PUT':
        if (!isset($_GET['id'])) {
            http_response_code(400);
            echo json_encode(["message" => "ID/NIP tidak ditemukan pada URL."]);
            break;
        }

        $input = json_decode(file_get_contents('php://input'), true);

        if ($target === 'pegawai') {
            $nip = $conn->real_escape_string($_GET['id']);
            $nama = $conn->real_escape_string($input['nama']);
            $alamat = $conn->real_escape_string($input['alamat']);
            $id_jabatan = intval($input['id_jabatan']);

            $query = "UPDATE tb_pegawai SET nama='$nama', alamat='$alamat', id_jabatan=$id_jabatan WHERE nip='$nip'";
            if ($conn->query($query)) {
                echo json_encode(["message" => "Data pegawai berhasil diperbarui."]);
            } else {
                http_response_code(500);
                echo json_encode(["message" => "Gagal memperbarui data pegawai."]);
            }
        } else {
            $id = intval($_GET['id']);
            $nama = $conn->real_escape_string($input['nama_jabatan']);

            $query = "UPDATE tb_jabatan SET nama_jabatan='$nama' WHERE id_jabatan=$id";
            if ($conn->query($query)) {
                echo json_encode(["message" => "Data jabatan berhasil diperbarui."]);
            } else {
                http_response_code(500);
                echo json_encode(["message" => "Gagal memperbarui data jabatan."]);
            }
        }
        break;

    case 'DELETE':
        if (!isset($_GET['id'])) {
            http_response_code(400);
            echo json_encode(["message" => "ID/NIP tidak ditemukan pada URL."]);
            break;
        }

        if ($target === 'pegawai') {
            $nip = $conn->real_escape_string($_GET['id']);
            $query = "DELETE FROM tb_pegawai WHERE nip='$nip'";
            if ($conn->query($query)) {
                echo json_encode(["message" => "Pegawai berhasil dihapus."]);
            } else {
                http_response_code(500);
                echo json_encode(["message" => "Gagal menghapus data pegawai."]);
            }
        } else {
            $id = intval($_GET['id']);
            $query = "DELETE FROM tb_jabatan WHERE id_jabatan=$id";
            if ($conn->query($query)) {
                echo json_encode(["message" => "Jabatan berhasil dihapus."]);
            } else {
                http_response_code(500);
                echo json_encode(["message" => "Gagal menghapus jabatan. Data ini mungkin masih digunakan oleh pegawai."]);
            }
        }
        break;

    default:
        http_response_code(405);
        echo json_encode(["message" => "Metode HTTP tidak diizinkan."]);
        break;
}

$conn->close();
?>