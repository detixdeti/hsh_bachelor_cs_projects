/* 
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSP_Servlet/JavaScript.js to edit this template
 */

function berechnen() {
    let gewicht = document.getElementById("gewicht").value;
    let groeße = document.getElementById("groese").value;
    let queryParam = new URLSearchParams({"gewicht": gewicht, "groese": groeße})
    let url = "http://localhost:8080/BMIWebApplication/api/BMIResource?";
    fetch(url + queryParam)
        .then(response => response.json())
        .then(data => {
            localStorage.setItem("bmi", data.bmi);
            localStorage.setItem("ergebnis", data.ergebnis);
            alert(localStorage.getItem("bmi"));
        });
    window.location.href = "bmi_result.html";
}

document.getElementById("berechnen").onclick = berechnen;
