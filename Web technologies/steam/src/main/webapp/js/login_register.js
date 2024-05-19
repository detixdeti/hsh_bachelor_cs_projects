/* 
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSP_Servlet/JavaScript.js to edit this template
 */

function login() {
    let username = document.getElementById("username").value;
    let password = document.getElementById("password").value;
    let object = {username: username, password: password};
    let url = "http://localhost:8080/steam/resources/users";
    fetch(url, {
        method: "put",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(object)
    })
        .then(response => {
            if (!response.ok) 
                throw response;
            return response.text();
    })
        .then(data => {
            localStorage.setItem("username", username);
            alert(data);    
            window.location.href = "series.html";
        })
        .catch( err => {
            err.text().then(errMess => alert(errMess));
        });
}

function register() {
    let username = document.getElementById("username").value;
    let password = document.getElementById("password").value;
    let object = {"username": username, "password": password};
    let url = "http://localhost:8080/steam/resources/users";
    fetch(url, {
        method: "post",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(object)
    })
        .then(response => {
            if (!response.ok) 
                throw response;
            return response.text();
    })
        .then(data => {
            localStorage.setItem("username", username);
            alert(data);    
        })
        .catch( err => {
            err.text().then(errMess => alert(errMess));
        });

        document.getElementById("username").value = "";
        document.getElementById("password").value = "";
}

document.getElementById("login").onclick = login;
document.getElementById("register").onclick = register;
