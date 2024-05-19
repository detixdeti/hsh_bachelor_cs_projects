/* 
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSP_Servlet/JavaScript.js to edit this template
 */

function berechnen() {
    let bmi = document.getElementById("gewicht").value / Math.pow((document.getElementById("groeße").value / 100), 2);
    localStorage.setItem("bmi", bmi);
    window.location.href = "bmi_result.html";
}

document.getElementById("berechnen").onclick = berechnen;