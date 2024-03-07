<?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $name = $_POST['name'];
    $age = $_POST['age'];

    if (!is_numeric($age)) {
        echo "Por favor, insira uma idade válida.";
    } else {
        echo $age >= 18 ? "$name é maior de 18 e tem $age anos" : "$name não é maior de 18 e tem $age anos";
    }
}
?>
