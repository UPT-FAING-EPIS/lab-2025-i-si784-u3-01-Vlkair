namespace Bank.Domain
{
    public class Cliente
    {
        public int IdCliente { get; }
        public string NombreCliente { get; private set; } = string.Empty;
        public static Cliente Registrar(string _nombre)
        {
            return new Cliente(){
                NombreCliente = _nombre
            };
        }   
    }
}