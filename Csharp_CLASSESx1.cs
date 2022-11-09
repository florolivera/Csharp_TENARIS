using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaramos una variable para la clase que creamos 
            autos Ford = new autos();
            //llamamos al constuctor
            Ford.maximaVelocidad();
            //el valor de este constructor podria ser emitido en pantalla 
            Console.WriteLine(Ford.maximaVelocidad());
            //o podriamos guardarlo en una variable nueva
            int veloc = Ford.maximaVelocidad();

            Ford.precio(500000.33);

            Ford.bienvenida();

            //MODIFICADORES DE ACCESO 
            /*PUBLIC: podremos acceder al objeto dentro y fuera de la clase donde la creamos
             PRIVATE: solo podremos acceder a él dentro de la clase (por defecto todos los fields y 
            constructores son private)
            PROTECTED: podremos acceder a él dentro de la clase en la que lo creamos y las que lo 
            HEREDEN */

            //POLIMORFISMO 
            /*significa "muchas formas" y ocurre cuando tenemos muchas clases que estan heredadas
             con otras y podemos utilizar los mismos metodos pero en cada clase modificarlo a su 
            conveniencia*/

            //ABSTRACCIÓN
            /*es el proceso donde ocultamos detalles y mostramos la informacion escencial 
             al usuario, podriamos aplicarlo con un metodo o una clase completa y accederiamos
            a estod mediante clases heredadas y no mediante el MAIN*/

            //SINTAXIS DE HERENCIA 
            /*imaginando que la clase auto heredara de la clase vehiculos, la sintaxis
             seria
            class autos:vehiculos*/

            //INTERFACE
            /*es un contrato que deben cumplir las clases que posean esta interfaz,
             por ejemplo si la interfaz fuera consecionaria, la clase debe cumplir con los metodos 
            que posea esta interface, por ejemplo que se emita por pantalla el nombre
            de la consecionaria"consecionaria automotores"
            dentro de la clase debemos incluir este metodo, y podremos modificarlo, en vez
            de que aparezca "consecionaria automotores" aparezca "bienvenido a su auto" 
            */

            //ENUMS 
            /*es una clase especial donde representamos un grupo de constantes*/
            tipoVelocidad ford = tipoVelocidad.high;
            Console.WriteLine(ford); //aparece high en pantalla

            //METODOS PARA FILES
            /*una file es una clase que viene de syste.io namespace
             
             file.metodo()
            */

            //metodos                    
            /*appendText()
              copy()
              create()
              delete()
              exists()
              ReadAllText()
              replace()
              WriteAllText()*/



        }

    }
    enum tipoVelocidad
    {
        low,
        medium, 
        high
    }
    interface consecionaria
    {
        public void msj()
        {
            Console.WriteLine("consecionaria");
        }
    }
    class autos : consecionaria //(asi le declaramos la interfaz)
    {
        private string marca; //declaramos un FIELD, Private indica que solamente podremos
                                           //acceder a él dentro de esta clase
        private int Maximavelocidad;
        public int maximaVelocidad()      //public indica que podremos acceder a él dentro y fuera
        {                                  //de esta clase. De esta manera estamos declarando un CONSTRUCTOR
            return Maximavelocidad = 200;           
        }

        //crear una propiedad
        public float precio { get; set; }  //de esta manera podremos escribir su valor desde afuera

        public void bienvenida()
        {
            Console.WriteLine("Bienvenido a su nuevo auto");
        }

        public void msj()
        {
            Console.WriteLine("Gracias por comprar en consecionaria automotores");
        }
    }

}
