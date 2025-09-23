using System;

namespace _3._Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            // CASTING

            //Ejemplos
            int myint = 5;
            float myFloat = 10.0f;

            myint = (int)3.0f;                //  myInt vale 3
            myint = (int)(10 + myFloat);      /*  10 se convierte en 10.0f (casting implícito) se
                                                  suma 10.0f y se convierte en 20.0f, luego se
                                                  hace el casting a int y se convierte en 20
                                              */

            int myInt = 5;
            float myFloat = 10.0f;

            myFloat = 15;                     /*  no necesita casting explícito, porque 15 es
                                                  representable como float  */
            myFloat = (float)10.0;            /*  10.0f es un float, 10.0 es un double. Por eso hay que
                                                  hacer el casting explícito   */



            // Uso de CONVERT para ciertos casos en los que el casting no sirve(como de string a int)
            string myString = “2”;
            Int myInt = Convert.ToInt32(myString);


            /* CASTING - Ejercicios
            1. Definir varias variables de diferentes tipos y castear entre
            ellas. Ver con cuales se puede castear directamente, cuáles
            necesitan un casting explícito y cuáles no se pueden castear.
            2. Sumar ints, con floats y con doubles, ¿de qué tipo es el
            resultado final?
            3. Añadir strings a la expresión...    */


            int b = 10;
            string thestring = 2;
            float thefloat = 3.0;
        }
    }
}
