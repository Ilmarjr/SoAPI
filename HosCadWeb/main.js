const API_URL = "https://localhost:44314/api/Data";

//TODO - CONSERTAR FRONT
let responseData = [];
let resultJson;
const table = document.querySelector("#dataTable");

//função para buscar os dados na api
function fetchData() {

    fetch(API_URL)
    .then(function(response) {
        if(!response.ok) throw new Error ("Request error.")
        console.log(response.ok);
        return response.json();
    })
    .then(function(data) {
        resultJson = JSON.stringify(data);
        console.log(resultJson)

        resultJson = JSON.parse(resultJson);

        console.log(resultJson)

        for(let i = 0; i < resultJson.length; i++) {
            responseData.push({
                'nome': resultJson[i].nome, 
                'cpf' : resultJson[i].cpf,
                'telefone': resultJson[i].telefone,
                'email': resultJson[i].email
            });
        }

        //construindo a tabela com os dados recebidos
        for(let i = 0; i < responseData.length; i++) {
            let tableBody = document.createElement("tbody");
            tableBody.setAttribute("class", "tb_results");

            let tableData = document.createElement("td");
            tableData.setAttribute("class", "tb_results_td");
            tableData.innerHTML = responseData[i].nome;

            let tableData2 = document.createElement("td");
            tableData2.setAttribute("class", "tb_results_td");
            tableData2.innerHTML = responseData[i].cpf;

            let tableData3 = document.createElement("td");
            tableData3.setAttribute("class", "tb_results_td");
            tableData3.innerHTML = responseData[i].telefone;

            let tableData4 = document.createElement("td");
            tableData4.setAttribute("class", "tb_results_td");
            tableData4.innerHTML = responseData[i].email;

            tableBody.appendChild(tableData);
            tableBody.appendChild(tableData2);
            tableBody.appendChild(tableData3);
            tableBody.appendChild(tableData4);


            table.appendChild(tableBody);
            console.log(table);
        }
    })


    return responseData;
}
console.log(fetchData());

//reiniciar página a cada 10 segundos
setInterval(function() {
    window.location.reload();
}, 7000);