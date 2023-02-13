import {signalR } from "../microsoft/signalr/dist/browser/signalr"

$(() => {
    LoadProdData();
    var connection = new signalR.HubConnectionBuilder().withUrl("/firstHub").build();
    connection.start();
    connection.on("LoadProducts", function () {
        LoadProdData();
    })
    function LoadProdData() {
        $.ajax({
            url: 'api/years/GetYears',
            method: 'GET',
            success: (result) => {
                console.log(result)
            },
            error: (error) => {
                console.log(error)
            }
        })
    }
})