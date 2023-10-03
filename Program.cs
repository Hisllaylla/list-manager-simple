var listaClientes = new List<Cliente>(); // INSTÂNCIA DA LISTA

var cliente1 = new Cliente // INSTÂNCIA DO CLIENTE
{
    Id = 1,
    Nome = "Yvan Giron Matos",
    Documento = "477.544.121-36",
    EstadoCivil = "Solteiro",
    Profissao = "Construtor Civil"
};

listaClientes.Add(cliente1);

var cliente2 = new Cliente
{
    Id = 2,
    Nome = "Alan Freitas Aguiar",
    Documento = "567.963.821-53",
    EstadoCivil = "Casado",
    Profissao = "Fotográfo"
};

listaClientes.Add(cliente2);

var cliente3 = new Cliente
{
    Id = 3,
    Nome = "Nilza Nobrega Moura",
    Documento = "226.165.138-46",
    EstadoCivil = "Viúva",
    Profissao = "Dona de Casa"
};

listaClientes.Add(cliente3);

var cliente4 = new Cliente
{
    Id = 4,
    Nome = "Berenice Montilla Estellet",
    Documento = "857.726.361-46",
    EstadoCivil = "Solteira",
    Profissao = "Dançarina"
};

listaClientes.Add(cliente4);

var cliente5 = new Cliente
{
    Id = 5,
    Nome = "Rone Muniz Fontes",
    Documento = "696.878.054-20",
    EstadoCivil = "Solteiro",
    Profissao = "Atleta"
};

listaClientes.Add(cliente5);


// ADICIONANDO VALORES DE OUTROS OBJETOS NO NOVO CLIENTE
var cliente6 = new Cliente
{
    Id = cliente3.Id,
    Nome = cliente3.Nome,
    Documento = cliente3.Documento,
    EstadoCivil = cliente3.EstadoCivil,
    Profissao = cliente3.Profissao
};


// ATUALIZANDO LISTA
var cliente7 = listaClientes.FirstOrDefault(x => x.Id == cliente6.Id);
Console.WriteLine(cliente7);

cliente7.Nome = "Eldimar da Silva Lima";
cliente7.Documento = "321.926.382-80";


// RECEBENDO VALORES DE OUTROS OBJETOS
var cliente8 = listaClientes.FirstOrDefault(x => x.Id == cliente7.Id);
Console.WriteLine(cliente8);


// ENUMERAR LISTA
Console.WriteLine($"{listaClientes.Count()}");


// REMOVER CLIENTE DE ACORDO COM A CONDIÇÃO
var cliente9 = listaClientes.FirstOrDefault(x => x.Id == cliente1.Id);
listaClientes.Remove(cliente9);


// ENUMERAR LISTA
Console.WriteLine($"{listaClientes.Count()}");


var cliente10 = new Cliente // INSTÂNCIA
{
    Id = 10,
    Nome = "Vivian Barrada Yabuta",
    Documento = "223.752.668-03",
    EstadoCivil = "Solteira",
    Profissao = "Médica"
};

listaClientes.Add(cliente10);

var cliente11 = new Cliente // INSTÂNCIA

{
    Id = 11,
    Nome = "Maria Alice Pinho Norte",
    Documento = "649.536.742-27",
    EstadoCivil = "Separada",
    Profissao = "Enfermeira"
};

listaClientes.Add(cliente11);


// ENUMERAR OBJETOS DENTRO DA LISTA
Console.WriteLine($"{listaClientes.Count()}");

// LIMPAR LISTA
listaClientes.Clear();
Console.WriteLine($"{listaClientes.Count()}");

