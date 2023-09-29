namespace ListManagerSimple;

public class Cliente
{
    public int? Id { get; set; }
    public string? Nome { get; set; }
    public string? Documento { get; set; }
    public string? EstadoCivil { get; set; }
    public string? Profissao { get; set; }
    public List<Cliente>? Clientes { get; set; }

    public override string ToString()
    {
        return $"ID: {Id}, Nome: {Nome}, Documento: {Documento}, Estado Civil: {EstadoCivil}, Profissão: {Profissao}";
    }
}