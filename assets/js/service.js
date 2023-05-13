const form = document.getElementById("form-dados");
const tabela = document.querySelector('#tabela tbody');

// Função para carregar os dados na tabela
function carregarDados() {

    fetch("https://localhost:7018/api/user/")
    .then(response => response.json())
    .then(data => {
    // Limpa a tabela antes de preenchê-la novamente
        tabela.innerHTML = "";

        // Percorre os dados recebidos e cria as linhas e células da tabela dinamicamente
        // Preenche a tabela com os dados recebidos da API
        data.forEach(dado => {
            const tr = document.createElement("tr");
            const tdLogin = document.createElement("td");
            const tdPassword = document.createElement("td");
            const tdEmail = document.createElement("td");

            tdLogin.textContent = dado.login;
            tdPassword.textContent = dado.password;
            tdEmail.textContent = dado.email;

            tr.appendChild(tdLogin);
            tr.appendChild(tdPassword);
            tr.appendChild(tdEmail);

            tabela.appendChild(tr);
        });
    })
    .catch(error => {
    // Exibe uma mensagem de erro caso ocorra algum problema na requisição
    console.error(error.message);
    });
}

// Função para cadastrar os dados
function cadastrarDados(event) {
    event.preventDefault();

    const login = document.getElementById("login").value;
    const email = document.getElementById("email").value;
    const password = document.getElementById("password").value;

    fetch("https://localhost:7018/api/user/", {
        method: "POST",
        body: JSON.stringify({ login, email, password }),
        headers: {
            "Content-Type": "application/json"
        }
    })
    .then(response => response.json())
    .then(data => {
        // Limpa o formulário após cadastrar os dados
        form.reset();

        // Recarrega os dados na tabela
        carregarDados();
    });
}

// Carrega os dados na tabela quando a página é carregada
document.addEventListener("DOMContentLoaded", carregarDados);

// Adiciona o evento de submit ao formulário
form.addEventListener("submit", cadastrarDados);