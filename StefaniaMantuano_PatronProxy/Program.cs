namespace StefaniaMantuano_PatronProxy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos el proxy a la página de descargas
            Servidor servidor = new ProxyServidor(20,  "https://hola123ecuador.com/");


            // Descargamos un archivo permitido
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(servidor.descargar("Descarga Permitida"));
            Console.ReadLine();


            // Vamos a probar ahora con una descarga restringida
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(servidor.descargar("Descarga Denegada"));
            Console.ReadLine();
        }
    }
}
