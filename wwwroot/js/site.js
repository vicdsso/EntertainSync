


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


//botoes categorias
function verTodos() {
    // Lógica para mostrar todos os entretenimentos
    showCategory('all');
}

function adicionarEntretenimento() {
    // Obter valores do formulário
    const titulo = document.getElementById('Titulo').value;
    const linkImagem = document.getElementById('LinkImagem').value;
    const link = document.getElementById('Link').value;
    const categoria = document.getElementById('opcoes').value;

    // Adicionar lógica para adicionar ao botão específico
    if (categoria === 'Filme') {
        showCategory(0);
    } else if (categoria === 'Livro') {
        showCategory(1);
    } else if (categoria === 'Serie') {
        showCategory(2);
    }

    // Adicionar lógica para adicionar o novo entretenimento ao botão "Ver todos"
    showCategory('all');

    // Limpar o formulário após adicionar
    document.getElementById('Titulo').value = '';
    document.getElementById('LinkImagem').value = '';
    document.getElementById('Link').value = '';
}

function showCategory(category) {
    const categories = document.getElementsByClassName('category-item');
    for (let i = 0; i < categories.length; i++) {
        categories[i].style.display = 'none';
    }

    if (category === 'all') {
        // Lógica para mostrar todos os entretenimentos
        for (let i = 0; i < categories.length; i++) {
            categories[i].style.display = 'block';
        }
    } else {
        // Lógica para mostrar a categoria específica
        const selectedCategory = document.getElementById(category);
        if (selectedCategory) {
            selectedCategory.style.display = 'block';
        } else {
            console.error('Categoria não encontrada:', category);
        }
    }
}







// Função para exibir todos os itens
//function verTodos() {
//    // Remover a classe 'active' de todos os botões
//    const buttons = document.querySelectorAll('.botoes button');
//    buttons.forEach(button => button.classList.remove('active'));

//    // Atualizar a categoria selecionada para "todos"
//    categoriaSelecionada = -1;

//    // Atualizar a exibição dos itens com base na nova categoria
//    atualizarExibicaoItens();
//}
