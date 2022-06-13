"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/monitorHub").build();

connection.on("ReceiveMessage", function (data) {
    document.getElementById("sessionCount").textContent = data.sessionCount;
    document.getElementById("cpuUsage").textContent = data.cpuUsage;
});

connection.start().then(function () {
    setInterval(function () {
        connection.invoke("SendData").catch(function (err) {
            return console.error(err.toString());
        });
       
    }, 500);
}).catch(function (err) {
    return console.error(err.toString());
});