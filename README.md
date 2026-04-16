# 🏥 Clínica Doc+

Sistema simples e eficiente para gerenciamento de clínicas médicas, desenvolvido com o objetivo de organizar atendimentos, pacientes e profissionais de forma prática e intuitiva.

# 📋 Sobre o Projeto

O Clínica Doc+ é uma aplicação básica voltada para o controle de rotinas clínicas. Ele permite gerenciar pacientes, médicos e consultas de maneira centralizada, servindo como base para futuras expansões e melhorias.

# ⚙️ Funcionalidades

✔️ Cadastro de pacientes
✔️ Cadastro de médicos
✔️ Agendamento de consultas
✔️ Edição de informações
✔️ Exclusão de pacientes e médicos

# 🚀 Tecnologias Utilizadas
💻 C#
📝 Visual Studio Code

# Para executar o projeto, você precisará de:

* Visual Studio Code instalado

#▶️ Como Executar

* Clone o repositório Abra o projeto no VS Code Pressione F5 para iniciar a aplicação.

# 🔗 Documentação da API

📌 Criar Consulta

Endpoint:

POST /api/agendarconsulta

Descrição:
Cria uma nova consulta a partir dos dados enviados no corpo da requisição em formato JSON.

Exemplo de uso:

{
  "medico": "Nome do Médico",
  "paciente": "Nome do Paciente",
  "data": "2026-04-20",
  "horario": "14:00"
}

📌 Possíveis Melhorias Futuras
Autenticação de usuários
Interface gráfica (web ou desktop)
Integração com banco de dados
Histórico de atendimentos
Notificações de consultas

# 👨‍💻 Autor

* Leandro Alves de Abreu

📧 leandro@gmail.com

📱 (81) 98888-9999
