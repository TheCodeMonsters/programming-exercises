namespace ExampleBanco
{
    class Cliente
    {
        private string name;
        private int monto;

        public Cliente(String nom)
        {
            name = nom;
            monto = 0;
        }

        public void Depositar(int m)
        {
            monto = monto + m;
        }

        public void Extraer(int m)
        {
            monto = monto - m;
        }

        public int RetornarMonto()
        {
            return monto;
        }

        public void Imprimir()
        {
            Console.WriteLine(name + " tiene depositado la suma de " + monto);
        }

    }

    class Banco
    {
        private Cliente cliente1, cliente2, cliente3;

        public Banco()
        {
            cliente1 = new Cliente("Carlos");
            cliente2 = new Cliente("Manuel");
            cliente3 = new Cliente("Juan");
        }

        public void Operar()
        {
            cliente1.Depositar(100);
            cliente2.Depositar(150);
            cliente3.Depositar(200);
            cliente3.Extraer(150);
        }

        public void DepositoTotales()
        {
            int t = cliente1.RetornarMonto() +
                    cliente2.RetornarMonto() +
                    cliente3.RetornarMonto();

            Console.WriteLine("El total de dinero en el banco es " + t);
            cliente1.Imprimir();
            cliente2.Imprimir();
            cliente3.Imprimir();

        }

        static void Main(string[] args)
        {
            Banco banco1 = new Banco();
            banco1.Operar();
            banco1.DepositoTotales();
            Console.ReadKey();  
        }

    }

}