namespace Biblioteca.Models; //pacote biblioteca
// classe livro pode ser acessada de qualquer lugar 
public class Livro 
{
    //declaração de dados get pega o valor e set altera o valor
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty; // string.Empty inicia com texto vazio
    public string Autor { get; set; } = string.Empty;
    public string Categoria { get; set; } = string.Empty;
    public bool Ativo { get; set; } = true; // por defult verdadeiro
}