


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

