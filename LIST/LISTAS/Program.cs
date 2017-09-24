using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTAS
{
    
       class Program
        {
            static void Menu()
            {
                Console.WriteLine(".-------------------------------------------------------.");
                Console.WriteLine("|                          Menu                         |");
                Console.WriteLine("·-------------------------------------------------------.");
                Console.WriteLine("1º Relación de ejercicios        2º Relación de ejercios");
                Console.WriteLine("_________________________________________________________");
                Console.WriteLine("1.- LeeLista                     11.- OrdenaListaPalabras");
                Console.WriteLine("2.- LeeListaN                    12.- OrdenaListaPalabras2");
                Console.WriteLine("3.- EscribeLista”                13.- InvierteListaConPila");
                Console.WriteLine("4.- PruebaFuncionesListas” NO    14.- InsertaArrayEnArrayPro");
                Console.WriteLine("5.- InsertaEnMedio”        NO    15.- SorteoBonoloto”");
                Console.WriteLine("6.- EliminaNegativos”            16.- EliminaRepetidos");
                Console.WriteLine("7.- ClasificaNúmeros”            17.- UnionListas");
                Console.WriteLine("8.- EliminaRepetidos”            18.- IntersecciónListas");
                Console.WriteLine("9.- TrimLista”                   19.- DesordenaLista");
                Console.WriteLine("10.- OrdenaListaSeleccion”       20.- ModaLista");
                Console.WriteLine("                                 21.- PuntuacionesTrampolin");
                Console.WriteLine("                                 22.- OrdenaciónMezcla");
                Console.WriteLine();
            }

            /// <summary>
            /// funcion que lee valores por teclado
            /// </summary>
            /// <param name="lista"></param>
            /// <returns>lista con los valores introducidos</returns>
            static List<int> LeeLista(List<int> lista)
            {
                int numero;
                do
                {
                    Console.WriteLine("teclea un numero: ");
                    numero = int.Parse(Console.ReadLine());
                    if(numero != -1)
                    {
                    lista.Add(numero);
                    }
                }
                while (numero != -1);

                return lista;

            }

            /// <summary>
            /// funcion que lee un numero determinado de valores
            /// </summary>
            /// <param name="lista"></param>
            /// <param name="numero"></param>
            /// <returns>devuelve la lista con los valores introducidos</returns>
            static List<int> LeeListaN(List<int> lista, int numero)
            {
                for (int i = 0; i < numero; i++)
                {
                    Console.WriteLine("teclea un numero: ");
                    numero = int.Parse(Console.ReadLine());
                    lista.Add(numero);
                }
                return lista;
            }

            /// <summary>
            /// funcion que escribe una lista
            /// </summary>
            /// <param name="lista"></param>
            static void EscribeLista(List<int> lista)
            {
                int i;
                Console.Write("[" + lista[0] + ",");
                for (i = 1; i < lista.Count-1; i++)
                {
                    Console.Write(lista[i]+",");
                }
                Console.Write(lista[i]+"]");

            }

            static void EscribeListaString(List<string> lista)
            {
                int i;
                Console.Write("[" + lista[0] + ",");
                   for (i = 1; i < lista.Count - 1; i++)
                {
                    Console.Write(lista[i] + ",");
                }
                Console.Write(lista[i] + "]");
            }

            static void EscribeListaChar(List<char> lista)
            {
                int i;
                Console.Write("[" + lista[0] + ",");
                for (i = 1; i < lista.Count - 1; i++)
                {
                    Console.Write(lista[i] + ",");
                }
                Console.Write(lista[i] + "]");
            }

            static void EscribeArray(int[] a)
            {
                int i;
                Console.Write("[" + a[0] + ",");

                for (i = 1; i < (a.Length - 1); i++)
                {
                    Console.Write(a[i] + ",");
                }
                Console.Write(a[i] + "]  ");
            }



            /// <summary>
            /// elimina los numeros negativos
            /// </summary>
            /// <param name="lista">lista definida</param>
            /// <returns>devuelve la lista sin numeros negativos</returns>
            static List<int> EliminaNegativos(List<int> lista)
                    {
                        lista.RemoveAll(numeros => numeros < 0);
                        return lista;
                    }


            /// <summary>
            /// funcion que clasifica los numeros en dos listas
            /// </summary>
            /// <param name="lista1">la lista ya definida</param>
            /// <param name="positivos">lista vacia donde van los numeros positivos</param>
            /// <param name="negativos">lista vacia donde van los numeros negativos</param>
            static void ClasificaNumeros(List<int> lista1, List<int> positivos, List<int> negativos)
            {
                for (int i = 0; i < lista1.Count; i++)
                {
                    if (lista1[i] < 0)
                    {
                        negativos.Add(lista1[i]); //en la lista negativos(vacia) añade los numeros negativos de lista1
                    }

                    else
                    {
                        positivos.Add(lista1[i]);
                    }
                }
                positivos.Sort();
                negativos.Sort();

            }

            /// <summary>
            /// funcion que elimina numeros repetidos. 
            /// </summary>
            /// <param name="lista"></param>
            static void EliminaRepetidos(List<int> lista)
            {
                IEnumerable<int> numerosdistintos = lista.Distinct(); // Distinct<>(IEnumerable<>) devuelve distintos elementos de una secuencia de enteros.

            foreach (int numeros in numerosdistintos)
                {
                    Console.WriteLine(numeros);
                }
            }

            /// <summary>
            /// funcion que quita los espacios del principio y el final
            /// </summary>
            /// <param name="lista">lista definida</param>
            /// <returns>lista sin espacios</returns>
            static List<char> TrimLista(List<char> lista)
            {
                while(lista[0]==' ') //espacio en posicion cero
                {
                lista.RemoveAt(0);  //remover en posicion cero
                }
                while(lista[lista.Count-1]==' ') //espacio en ultima posicion
                {
                lista.RemoveAt(lista.Count - 1); //remover
                }
            return lista;
         
            }

            /// <summary>
            /// funcion a la que le pasas una lista de enteros desordenada y te la ordena
            /// </summary>
            /// <param name="lista"></param>
            /// <returns>lista ordenada</returns>
            static List<int> OrdenaListaSeleccion(List<int> lista)
                {
                    List<int> lista2 = new List<int>();
                    while (lista.Count > 0)
                    {
                        lista2.Add(lista.Min());
                        lista.Remove(lista.Min());
                    }
                    return lista2;
                }

            /// <summary>
            /// función a la que le pasas una lista de cadena que contiene palabras y te las ordena alfabéticamente
            /// </summary>
            /// <param name="lista"></param>
            /// <returns>lista ordenada</returns>
            static List<string> OrdenaListaPalabras(List<string> lista)
            {
                List<string> lista2 = new List<string>();
                while (lista.Count > 0)
                {
                    lista2.Add(lista.Min());
                    lista.Remove(lista.Min());
            }
                return lista2;
            }

        static List<string> OrdenaListaPalabras2(List<string> lista)
        {
            int min;
            int posicion;
            List<string> lista2 = new List<string>();
            while (lista.Count > 0)
            {
                min = lista[0].Length;
                posicion = 0;
                for (int i = 0; i < lista.Count; i++)
                {
                    if (lista[i].Length < min)
                    {
                        min = lista[i].Length;

                        posicion = i;
                    }
                }
                lista2.Add(lista[posicion]);
                lista.Remove(lista[posicion]);
            }
            return lista2; 
        }


        /// <summary>
        /// funcion que invierte la lista que le pasas por parametro
        /// </summary>
        /// <param name="lista"></param>
        /// <returns></returns>
        static List<int> InvierteListaConPila(List<int>lista)
        {
            Stack<int> pila = new Stack<int>(lista);
            List<int> lista1 = new List<int>(pila);
            return lista1;
        }

        /// <summary>
        /// Funcion que inserta un array en otro en la posicion elegida por listas
        /// </summary>
        /// <param name="array">array definido</param>
        /// <param name="posicion">donde se introduce el array</param>
        /// <param name="array2">array definido que se introduce en el otro array</param>
        /// <returns></returns>
        static int[] InsertaArrayEnArrayPro(int[]array, int posicion, int[] array2)
                {
                List<int> lista = new List<int>();
                lista.AddRange(array);  //se copia el array en la lista
                lista.InsertRange(posicion, array2); //se inserta el array en la lista
                array=lista.ToArray(); //convierte la lista en un array
                return array;
                }

        static List<int> ListaNumeros(List<int> lista)
        {
            int n = 1;
            
            for(int i=0; i<49;i++)
            {
                lista.Add(n);   //meter los 49 numeros en una lista
                n++;
            }
            return lista;
        }

        /// <summary>
        /// funcion que nos da los 6 numeros que van a tocar en el proximo sorteo.
        /// </summary>
        /// <param name="lista"></param>
        /// <returns>lista con los 6 numeros</returns>
        static List<int> SorteoBonoloto(List<int> lista)
        {
            Random r = new Random();
            List<int> lista2 = new List<int>();

            while (lista2.Count <6)
            {
                int n = r.Next(0, lista.Count); //se elige la posicion al azar
                lista2.Add(lista[n]); //se guarda en la segunda lista el numero
                lista.Remove(lista[n]); //se elimina de la primera para que no vuelva a salir
            }
            return lista2;


        }

        /// <summary>
        /// funcion que devuelve un array sin numeros repetidos
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static int[] EliminaRepetidos(int[] array)
        {
            List<int> lista = new List<int>();
            
            for (int i = 0; i < array.Length; i++)
            {
                if (!(lista.Contains(array[i])))
                {
                    lista.Add(array[i]);
                }
            }
            array = lista.ToArray();
            return array;
        }

        /// <summary>
        /// funcion que le pasas dos listas y te devuelve otra lista que es la union de ambas
        /// </summary>
        /// <param name="lista1"></param>
        /// <param name="lista2"></param>
        /// <returns>union de ambas listas</returns>
        static List<int> UnionListas(List<int> lista1, List<int> lista2)
        {
            List<int> lista3 = new List<int>();
            lista3.AddRange(lista1);
            lista3.AddRange(lista2);
            return lista3;
        }

        /// <summary>
        /// funcion que le pasas dos listas y te devuelve otra q es la interseccion de ambas
        /// </summary>
        /// <param name="lista1"></param>
        /// <param name="lista2"></param>
        /// <returns></returns>
        static List<int> InterseccionListas(List<int>lista1, List<int> lista2)
        {
            List<int> lista3 = new List<int>();
            for(int i=0; i<lista2.Count;i++)
            if(lista1.Contains(lista2[i]))
                {
                    lista3.Add(lista2[i]);
                }
            for(int j=0; j<lista1.Count; j++)
            if(lista2.Contains(lista1[j]))
                {
                    lista3.Add(lista1[j]);
                }           
            return lista3;   
        }

        /// <summary>
        /// funcion a la que pasas una lista y te la desordena
        /// </summary>
        /// <param name="lista1"></param>
        /// <returns></returns>
        static List<int> DesordenaLista(List<int>lista1)
        {
            Random r = new Random();
            List<int> lista2 = new List<int>();

            while(lista1.Count>0)
            {
                int n = r.Next(0, lista1.Count);
                lista2.Add(lista1[n]);
                lista1.Remove(lista1[n]);
            }
            return lista2;
        }

        /// <summary>
        /// funcion que nos devuelve la moda de una lista de enteros
        /// </summary>
        /// <param name="lista"></param>
        /// <returns>valor mas repetido</returns>
        static int ModaLista(List<int> lista)
        {
            int moda = 0;           
            int valor = 0;
            int auxiliar = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                for(int j=0; j<lista.Count; j++)
                {
                    if (lista[i] == lista[j])
                    {
                        auxiliar++;
                    }
                    if(auxiliar>moda)
                    {
                        auxiliar = moda;
                        valor = lista[i];
                    }                        
                }
                auxiliar = 0;
            }
            return valor;
        }

        /// <summary>
        /// función que recibe una lista con 7 números reales y elimina los dos valores más altos y más bajos, y suma los que quedan para devolver un numero
        /// </summary>
        /// <param name="lista"></param>
        /// <returns>un número que es la suma de los tres valores que quedan</returns>
        static int PuntuacionesTrampolin(List<int> lista)
        {       
            lista.Remove(lista.Max());
            lista.Remove(lista.Max());
            lista.Remove(lista.Min());
            lista.Remove(lista.Min());

            int puntuacion = lista.Sum();

            return puntuacion;
        }
          
        static List<int> OrdenacionMezcla(List<int>lista1, List<int>lista2)
        {
            Queue<int> cola1 = new Queue<int>(lista1);
            Queue<int> cola2 = new Queue<int>(lista2);

            List<int> listadevuelta = new List<int>();

            while(cola1.Count>0 && cola2.Count>0)
            {
                if(cola2.Peek()==cola1.Peek())
                {
                    listadevuelta.Add(cola1.Peek());
                    listadevuelta.Add(cola2.Peek());

                    cola1.Dequeue();
                    cola2.Dequeue();                      
                }
                else
                {
                    if (cola2.Peek()>cola1.Peek())
                    {
                        listadevuelta.Add(cola1.Peek());
                        cola1.Dequeue();
                    }
                    else
                    {
                        listadevuelta.Add(cola2.Peek());
                        cola2.Dequeue();
                    }
                }
              
            }
            return listadevuelta;

        } 


            static void Main(string[] args)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();

                Menu();
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        {
                            List<int> lista = new List<int>();
                            LeeLista(lista);
                            EscribeLista(lista);
                        }
                        break;

                    case 2:
                        {
                            List<int> lista = new List<int>();
                            LeeListaN(lista, 5);
                        }
                        break;

                    case 3:
                        {
                            int[] aa = { 1, 2, 3, 4, 5 };
                            List<int> lista = new List<int>(aa);
                            EscribeLista(lista);
                        }
                        break;

                    case 5:
                        {

                        }
                        break;

                    case 6:
                        {
                            List<int> lista6 = new List<int>() { -9, 1, 2, 3, 4, 5, -6, -7, -6 }; ;
                            EliminaNegativos(lista6);
                            EscribeLista(lista6);

                        }
                        break;

                    case 7:
                        {
                            List<int> lista1 = new List<int>() { 1, -1, 2, -2, -3, 3, -4, 4, 5, -5, 6, -6, -7, 7, -8, 8, -9, 9, -10, 10 };
                            List<int> positivos = new List<int>();
                            List<int> negativos = new List<int>();
                            ClasificaNumeros(lista1, positivos, negativos);
                            Console.WriteLine("números positivos: ");
                            EscribeLista(positivos);
                            Console.WriteLine("números negativos: ");
                            EscribeLista(negativos);
                        }
                        break;

                    case 8:
                        {
                            int[] aa = { 7, 7, 5, 6, 4, 6, 6, 6 };
                            List<int> lista = new List<int>(aa);
                            EliminaRepetidos(lista);
                        }
                        break;

                    case 9:
                        {
                        List<char> lista = new List<char>() {' ', 'm', 'a','n','u',' '};
                        TrimLista(lista);
                        EscribeListaChar(lista);
                        }
                        break;

                    case 10:
                        {
                            int[] aa = { 4, 6, 1, 9, 2, 6, 4, 5, 3 };
                            List<int> lista = new List<int>(aa);
                            lista = OrdenaListaSeleccion(lista);
                            Console.Write("lista ordenada: ");
                            EscribeLista(lista);
                        }
                        break;

                    case 11:
                        {
                        string[] aa = { "huelva", "cadiz", "jaen", "malaga", "sevilla", "cordoba", "almeria", "granada" };
                        List<string> lista = new List<string>(aa);
                        lista = OrdenaListaPalabras(lista);
                        Console.Write("lista de palabras ordenada alfabeticamente: ");
                        EscribeListaString(lista);
                    }
                        break;

                case 12:
                    {
                        string[] aa = { "huelva", "cadiz", "jaen", "malaga", "sevilla", "cordoba", "almeria", "granada" };
                        List<string> lista = new List<string>(aa);
                        lista = OrdenaListaPalabras2(lista);
                        Console.Write("lista de palabras ordenada por tamanno: ");
                        EscribeListaString(lista);
                    }
                    break;

                case 13:
                    {
                        List<int> lista = new List<int> { 1, 2, 3, 4, 5 };
                        List<int> lista2 = new List<int> ();
                        EscribeLista(lista);
                        lista2=InvierteListaConPila(lista);
                        EscribeLista(lista2);
                    }
                    break;

                case 14:
                        {
                        int[] array = { 1, 2, 4, 5 };
                        int[] array2 = {3};
                        Console.WriteLine("introduce la posicion: ");
                        int posicion = int.Parse(Console.ReadLine());
                        array=InsertaArrayEnArrayPro(array, posicion, array2);
                        EscribeArray(array);
                        }
                    break;

                    case 15:
                        {
                        List<int> lista = new List<int>();
                        lista=ListaNumeros(lista);
                        lista=SorteoBonoloto(lista);
                        EscribeLista(lista);

                        }
                        break;

                    case 16:
                        {
                        int[] array = { 1, 1, 2, 2, 3, 3 };
                        array = EliminaRepetidos(array);
                        EscribeArray(array);
                        }
                        break;

                case 17:
                    {
                        List<int> lista1 = new List<int> { 1, 2, 3, 4 };
                        List<int> lista2 = new List<int> { 5, 6, 7, 8 };
                        List<int> lista3 = new List<int>();
                        lista3 =UnionListas(lista1, lista2);
                        EscribeLista(lista3);
                    }
                    break;

                case 18:
                    {
                        List<int> lista1 = new List<int> { 1, 2, 3, 4 };
                        List<int> lista2 = new List<int> { 4, 6, 7, 8 };
                        List<int> lista3 = new List<int>();
                        lista3 = InterseccionListas(lista1, lista2);
                        EscribeLista(lista3);
                    }
                    break;

                case 19:
                    {
                        List<int> lista1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
                        List<int> lista2 = new List<int> ();
                        lista2 = DesordenaLista(lista1);
                        EscribeLista(lista2);
                    }
                    break;

                case 20:
                    {
                        List<int> lista = new List<int>();

                        LeeLista(lista);
                        
                        int asux = ModaLista(lista);
                        Console.WriteLine(asux);
                    }
                    break;

                case 21:
                    {
                        List<int> puntuacion = new List<int>() {9,8,7,9,8,7,9};

                        int resultado = PuntuacionesTrampolin(puntuacion);
                        Console.WriteLine("puntuacion final: " + resultado);
                    }
                    break;

                case 22:
                    {
                        List<int> lista1 = new List<int>();
                        LeeLista(lista1);
                        List<int> lista2 = new List<int>();
                        LeeLista(lista2);
                        List<int> lista4 = OrdenacionMezcla(lista1, lista2);
                        EscribeLista(lista4);
                         
                    }
                    break;

            }
                Console.ReadKey();
            }
        }
    }

