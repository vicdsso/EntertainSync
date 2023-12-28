function addEntertainment() {
    const title = document.getElementById('title').value;
    const category = document.querySelector('#category-buttons button.active').innerText;

    // Lógica para atribuir a categoria correta ao adicionar um novo item
    let novaCategoria;
    switch (category) {
        case "Filmes":
            novaCategoria = 0;
            break;
        case "Séries":
            novaCategoria = 1;
            break;
        case "Livros":
            novaCategoria = 2;
            break;
        default:
            novaCategoria = -1; // Se não for uma categoria conhecida, atribuir a categoria "todos"
            break;
    }

    // Limpar campo de título
    document.getElementById('title').value = '';

    // Atualizar a exibição dos itens com base na nova categoria (removendo a lógica da variável categoriaSelecionada)
    atualizarExibicaoItens();

    // Você pode optar por manter a seguinte linha se precisar exibir um alerta
    alert(`Título: ${title}, Categoria: ${category}`);
}


// Função para filtrar por letra
function filtrarPorLetra(letra) {
    alert(`Filtrar por letra: ${letra}`);
    atualizarExibicaoItens(letra);
}

document.addEventListener('DOMContentLoaded', function () {
    const alphabetNav = document.getElementById('alphabet-nav');

    for (let i = 65; i <= 90; i++) {
        const letter = String.fromCharCode(i);
        const letterElement = document.createElement('div');
        letterElement.className = 'alphabet-letter';
        letterElement.textContent = letter;

        letterElement.addEventListener('click', function () {
            filtrarPorLetra(letter);
        });

        alphabetNav.appendChild(letterElement);
    }
});

// Função para alternar entre as categorias
let categoriaSelecionada = 0; // Defina 0 como padrão ao carregar a página

function changeCategory(index) {
    const buttons = document.querySelectorAll('.botoes button');

    if (index === categoriaSelecionada) {
        // Se clicar na categoria já selecionada, desmarque-a
        categoriaSelecionada = -1;
    } else {
        // Atualizar a categoria selecionada
        categoriaSelecionada = index;
    }

    // Atualizar a classe 'active' nos botões
    buttons.forEach(button => button.classList.remove('active'));
    if (categoriaSelecionada !== -1) {
        document.getElementById(`${buttons[categoriaSelecionada].id}`).classList.add('active');
    }

    // Atualizar a exibição dos itens com base na nova categoria
    atualizarExibicaoItens();
}

// Função para exibir todos os itens
function verTodos() {
    // Remover a classe 'active' de todos os botões
    const buttons = document.querySelectorAll('.botoes button');
    buttons.forEach(button => button.classList.remove('active'));

    // Atualizar a categoria selecionada para "todos"
    categoriaSelecionada = -1;

    // Atualizar a exibição dos itens com base na nova categoria
    atualizarExibicaoItens();
}

// Modifique a função atualizarExibicaoItens para exibir apenas os itens da categoria e letra selecionadas
function atualizarExibicaoItens(letraFiltrada) {
    const items = document.querySelectorAll('section');
    items.forEach((item, index) => {
        const letraItem = item.querySelector('.titulo').textContent.trim().charAt(0).toUpperCase();

        if ((categoriaSelecionada === -1 || index === categoriaSelecionada) && (!letraFiltrada || letraFiltrada === letraItem)) {
            item.style.display = 'block';
        } else {
            item.style.display = 'none';
        }
    });
}
