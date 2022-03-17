using System;

namespace CovarianceContravariance
{
    class Program
    {
        public delegate Automotor covarDelegate(Automovil a); //Se declara delegado para covarianza
        static void Main(string[] args)
        {
            Automotor newAuto1 = new Automovil();
            Automotor newauto2 = new Camioneta();
            // Automovil newAuto3 = new Automotor(); // No se puede hacer una asignacion desde una clase derivada a una clase base

            covarDelegate del = Arrancar;

            Automotor autm = del(new Automovil()); //La covarianza haciendo uso de un delegado permite la asignacion de un tipo derivado hacia un tipo mas base

            del = Encender;
            Automotor autm2 = del(new Automovil());

            del += Apagar; // La contravarianza me permite usar el mismo delegado que espera un parametro de la clase derivada Automovil pese a que el del metodo Apagar es base Automotor
        }

        public static Automovil Arrancar(Automovil au)
        {
            Console.WriteLine("El automovil arranca");
            return new Automovil() ;
        }

        public static Automotor Encender(Automovil au)
        {
            Console.WriteLine("El automotor enciende");

            return new Automotor();
        }

        public static Automotor Apagar(Automotor Au)
        {
            Console.WriteLine("El automotor esta apagado");
            return new Automotor();
        }


    }
}
