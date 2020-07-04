namespace Simulador_de_rol.Clases
{
    public class Controlador
    {
        Program elPrograma;
        public Program MiPrograma
        {
            get
            {
                return elPrograma;
            }

            set
            {
                elPrograma = value;
                elPrograma.Controlador = this;
            }
        }
        public string Comando(string elComando)
        {
            //buscará el comando en un diccionario que le dirá qué hacer
            if (elComando == "go")
            {
                return $"Funciona" + elPrograma.LeerLinea();
            }
            else
            {
                return "Escriba 'go', pero igual funciona!" + elPrograma.LeerLinea();;
            }
        }
            
    }
}