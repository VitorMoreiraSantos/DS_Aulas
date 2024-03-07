<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $grade = $_POST['grade'];

    if ($grade < 0 || $grade > 10) {
        echo "Nota inválida. Por favor, digite uma nota entre 0 e 10.";
    } else {
        echo "Nota válida: $grade";
    }
}
?>
