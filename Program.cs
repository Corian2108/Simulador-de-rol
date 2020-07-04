using System;
using Simulador_de_rol.Clases;

namespace Simulador_de_rol
{
    public class Program
    {
        public Controlador Controlador { get; set; }
        static void Main(string[] args)
        {
            var elPrograma = new Program();
            var Controlador = new Controlador();   
            string iniciar = Console.ReadLine();
            Controlador.Comando(iniciar);
        }
        public string LeerLinea()
        {
            string comando = Console.ReadLine();
            return Controlador.Comando(comando);
        }
    }
}
