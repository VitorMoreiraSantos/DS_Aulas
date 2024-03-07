<?php
for ($i = 1; $i <= 20; $i++) {
    echo "$i<br>";
}

echo "<hr>"; // Separador visual para os números ao lado do outro.

for ($i = 1; $i <= 20; $i++) {
    echo $i . ($i < 20 ? ' ' : "<br>");
}
?>
