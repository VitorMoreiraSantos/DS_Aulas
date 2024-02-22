function verificarRespostas() {
    const respostasCorretas = ['d', 'c', 'a']; // Defina as respostas corretas para cada pergunta
  
    const form = document.getElementById('quizForm');
    const respostas = form.elements;
  
    let acertos = 0;
  
    for (let i = 0; i < respostas.length; i++) {
      if (respostas[i].type === 'radio' && respostas[i].checked) {
        const pergunta = respostas[i].name.substring(8); // Obtém o número da pergunta
        const respostaSelecionada = respostas[i].value;
  
        if (respostaSelecionada === respostasCorretas[pergunta - 1]) {
          acertos++;
        }
      }
    }
  
    alert(`Você acertou ${acertos} de 3 perguntas.`);
    resetForm(form);
  }
  
  function resetForm(form) {
    form.reset();
  }
  