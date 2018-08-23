# Biblioteca Digital
Projeto de sistema feito para a matéria de C#

Sobre:
Biblioteca:

Descrição base:
- O usuário acessa/instala e seus dados ficam salvo 
- Deve receber o item emprestado, data que foi emprestado
- Quando algo for devolvido, deve ser marcado no sistema que irá salvar a data
- Opcionalmente pode haver a data de devolução combinada
- A tela inicial lista as coisas emprestada
- Após a data combinada o item deve ficar destacado na lista de coisas emprestadas

Funcionalidades:
- Login
- Cadastro/Edição/Exclusão de Livro
- Cadastro/Edição/Exclusão de Usuário
- Consulta de Livro
- Empréstimo de Livro (com data)
- Telas para Usuário e Admin diferentes
- Listagem de Empréstimos (mais antiga para mais recente)
- Consulta de Empréstimos por usuário
- Mostrar ao Admin se um empréstimo passou ou não da data de devolução

Tabelas:    

Usuário: user_tb    
id_user
login
pass
type_user(bool)
    
Livros: livros_tb   
id_livro
titulo
quantidade
disponivel(bool)
    
Emprestimos:  emprestimos_tb
id_emprestimo
user
livro
emprestado (data)
devolucao (data)

=-=-=-=-=-=-=-=-=-=-=-=-=-=         
Equipe:   
Leonan Müller Luiz    
Lucas Lopes de Aguiar
