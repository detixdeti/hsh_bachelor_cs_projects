/* 
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/JSP_Servlet/JavaScript.js to edit this template
 */

/* global fetch */

document.getElementById("loggedUser").innerHTML = localStorage.getItem("username");

function logout() {
    window.location.href = "index.html";
}

function submit() {
    let title = document.getElementById("title").value;
    let numberOfSeasons = document.getElementById("numberOfSeasons").value;
    parseInt(numberOfSeasons);
    let genre = document.getElementById("genre").value;
    let provider = document.getElementById("provider").value;
    let remark = document.getElementById("remark").value;
    let score = document.getElementById("score").value;
        
    if (title === "" || numberOfSeasons <= 0 || genre === "" || provider === ""
            || score === "" || score === "") {
        alert("Bitte füllen Sie alle Felder aus!");
        throw "Bitte füllen Sie alle Felder aus!";
    }
        
    let object = {
                    ratedSeries: {
                      genre: genre,
                      numberOfSeasons: numberOfSeasons,
                      seenBy: [],
                      streamedBy: provider,
                      title: title
                    },
                    ratingUser: {
                      password: null,
                      username: localStorage.getItem("username")
                    },
                    remark: remark,
                    score: score
                };
    
    let url = "http://localhost:8080/steam/resources/users/"
                + localStorage.getItem("username") 
                + "/ratings";
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
            alert(data);    
        })
        .catch( err => {
            err.text().then(errMess => alert(errMess));
        });
}

function search() {
    let title = document.getElementById("title").value;
    let numberOfSeasons = document.getElementById("numberOfSeasons").value;
    parseInt(numberOfSeasons);
    let genre = document.getElementById("genre").value;
    let provider = document.getElementById("provider").value;
    let remark = document.getElementById("remark").value;
    let score = document.getElementById("score").value;
    
    // for parsing json to java some adjustments
    if (title === "") title = null;
    if (numberOfSeasons === "") numberOfSeasons = 0;
    if (genre === "") genre = null;
    if (provider === "") provider = null;
    if (remark === "") remark = null;
    if (score === "") score = null;
    
    let object = {
                    ratedSeries: {
                      genre: genre,
                      numberOfSeasons: numberOfSeasons,
                      seenBy: [],
                      streamedBy: provider,
                      title: title
                    },
                    ratingUser: {
                      password: null,
                      username: localStorage.getItem("username")
                    },
                    remark: remark,
                    score: score
                };
                
    let url = "http://localhost:8080/steam/resources/users/"
                + localStorage.getItem("username") 
                + "/ratings";
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
            return response.json();
    })
        .then(data => {
        document.getElementById("tableData").innerHTML = "";    
            
        // Problem: je nach dem wie viele Treffer es gibt, wird ein Array mit
        // Objekten oder nur ein Objekt geliefert. Geht in den catch-Block, wenn
        // data nicht iterable, weil nur ein Objekt
        try {
            for (const element of data) {
                createRow(element);
            }
        } catch (e) {
            createRow(data);
        } 
        })
        .catch( err => {
            err.text().then(errMess => alert(errMess));
        });
}

function createRow (element) {
    var tr = document.createElement('tr');   
    var td_title = document.createElement('td');
    var td_numberOfSeasons = document.createElement('td');
    var td_genre = document.createElement('td');
    var td_provider = document.createElement('td');
    var td_score = document.createElement('td');
    var td_remark = document.createElement('td');

    td_title.innerHTML = element.ratedSeries.title;
    td_numberOfSeasons.innerHTML = element.ratedSeries.numberOfSeasons;
    td_genre.innerHTML = element.ratedSeries.genre;
    td_provider.innerHTML = element.ratedSeries.streamedBy;
    td_score.innerHTML = element.score;
    td_remark.innerHTML = element.remark;

    tr.appendChild(td_title);
    tr.appendChild(td_numberOfSeasons);
    tr.appendChild(td_genre);
    tr.appendChild(td_provider);
    tr.appendChild(td_score);
    tr.appendChild(td_remark);

    document.getElementById("tableData").appendChild(tr);
}

document.getElementById("btnLogout").onclick = logout;
document.getElementById("submit").onclick = submit;
document.getElementById("search").onclick = search;