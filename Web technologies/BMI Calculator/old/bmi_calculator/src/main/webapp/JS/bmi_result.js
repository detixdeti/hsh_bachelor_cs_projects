/* 
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSP_Servlet/JavaScript.js to edit this template
 */

document.getElementById("currentBMI").innerHTML = Math.round(localStorage.getItem("bmi") * 100) / 100;

// Fallunterscheidung welches Ergebnis
if (document.getElementById("currentBMI").innerHTML < 18.5) {
    document.getElementById("ergebnis").innerHTML = "Sie sind untergewichtigt (< 18,5) !";
} else if (document.getElementById("currentBMI").innerHTML > 25) {
    document.getElementById("ergebnis").innerHTML = "Sie sind übergewichtigt (25 bis 29,9) !";
} else {
    document.getElementById("ergebnis").innerHTML = "Sie sind normalgewichtigt (18,5 bis 24,9) !";
}

// maxBMI bestimmen
if (document.getElementById("currentBMI").innerHTML > Math.round(localStorage.getItem("maxBMI") * 100) / 100) {
    localStorage.setItem("maxBMI", document.getElementById("currentBMI").innerHTML);
    document.getElementById("maxBMI").innerHTML = document.getElementById("currentBMI").innerHTML;
} else {
    document.getElementById("maxBMI").innerHTML = Math.round(localStorage.getItem("maxBMI") * 100) / 100;
}

function zurueck() {
    window.location.href = "bmi_start.html";
}

document.getElementById("zurueck").onclick = zurueck;