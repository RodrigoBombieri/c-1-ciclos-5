// 1 --------------------------------
// 1. Hacer un programa para mostrar los números del 1 al 10. 
// No se debe realizar ningún pedido de datos.


// for (int x = 1; x <= 10; x++)
// {
//     Console.WriteLine(x); 
    
// }

// 2 ----------------------------------
// 2. Hacer un programa que solicite el ingreso de 10 números y que muestre 
// el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.

// int n, mayor = 0;

// for (int x = 0; x < 10; x++)
// {
//     Console.WriteLine("Ingrese un número: ");
//     n = int.Parse(Console.ReadLine());
    
//     // if (x == 0) : Para usar el primer elemento que carguemos como el mayor por el momento. (Sirve para utilizar números negativos y positivos al mismo tiempo)
//     // Porque si solamente inicializamos la variable mayor = 0, vamos a poder usar únicamente valores mayores a cero.
//     if (x == 0)
//         mayor = n;
//     else{
//         if (n > mayor)
//             mayor = n;    
//     }
// }

// Console.WriteLine("El mayor es: " + mayor);




// 3 -------------------------------------------
// 3. Hacer un programa que solicite 20 edades y 
// luego calcule el promedio de edad de aquellas personas mayores a 18 años.

// int edad, acu = 0, promedio, con = 0;

// for (int x = 0; x < 20; x++)
// {
//     Console.WriteLine("Ingrese una edad: ");
//     edad = int.Parse(Console.ReadLine());
//     if (edad > 18){
//         con++;
//         acu+= edad;
//     }
// }

// promedio = acu / con;
// Console.WriteLine("El promedio es: " + promedio);



// 4 ----------------------------------------
// 4. Hacer un programa que solicite UN número y luego calcule 
// y emita un cartel aclaratorio si el mismo es primo o no es primo.  
// Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.

// int n, con = 0;

// Console.WriteLine("Ingrese un número: ");
// n = int.Parse(Console.ReadLine());

// // el ciclo va a dar tantas vueltas como el número n que yo ingreso.
// for (int x = 1; x <= n; x++)
// {
//     // va a dividir tantas veces como vueltas del ciclo tenga.
//     if (n % x == 0)
//         con++;
// }

// // si cuenta 2 veces significa que el número se divide por 1 y por si mismo únicamente.
// if (con == 2)
//     Console.WriteLine("El número " + n + " es primo.");
// else
//     Console.WriteLine("El número " + n + " no es primo");




// 5 ----------------------------------------------
// 5. Hacer un programa que solicite 20 números y luego emitir por pantalla 
// el máximo de los números pares y el mínimo de los números impares.

// int n, maxpar = 0, minimpar = 1, conpar = 0, conimpar = 0;

// for (int x = 0; x < 20; x++)
// {
//     Console.WriteLine("Ingrese un número: ");
//     n = int.Parse(Console.ReadLine());

//     if (n % 2 == 0){
//         conpar++;
//         if (n > maxpar)
//             maxpar = n;
//     }else{
//         conimpar++;
//         if (n < minimpar)
//             minimpar = n;
//     }
// }

// Console.WriteLine("El máximo de los pares es: " + maxpar + " de " + conpar + " números ingresados");
// Console.WriteLine("El mínimo de los impares es: " + minimpar + " de " + conimpar + " números ingresados");



// EJERCICIOS ADICIONALES DE LA GUÍA ----------------------------------------------

// A ----------------------------------------
// 2. Hacer un programa que solicite 20 números y calcule y emita por pantalla
// cuántos son positivos (mayores a cero). Se debe mostrar un solo valor: el conteo final.

// int n, con = 0;

// for (int x = 0; x < 20; x++)
// {
//     Console.WriteLine("Ingrese un número: ");
//     n = int.Parse(Console.ReadLine());

//     if (n > 0)
//         con++;
// }

// Console.WriteLine("Hay " + con + " números mayores a cero.");


// B ------------------------------------------
// 5. Hacer un programa que muestre los números del 1 al 100 de 5 en 5. Ejemplo:
// 0, 5, 10, 15, 20…. 100.

// for (int x = 0; x <= 100; x+=5)
// {
//     Console.WriteLine(x);
    
// }



// C -----------------------------------
// 7. Hacer un programa que solicite 10 números y luego mostrar por pantalla el
// máximo de ellos y la posición en la que fue ingresado.

// int n, max = 0, posmax = 0;

// for (int x = 0; x < 10; x++)
// {
//     Console.WriteLine("Ingrese un número: ");
//     n = int.Parse(Console.ReadLine());

//     // cuando ingresan el primer número, le asignamos la posición 1 (de momento éste será nuestro máximo).
//     if (x == 0){
//         max = n;
//         posmax = 1;
//     // después del primer número ingresado, se comparan todos los demás para ver si son mayores, y se va actualizando la posición (x).  
//     }else if (n > max){
//         max = n;
//         posmax = x + 1;
//     }
// }

// Console.WriteLine("El número máximo es: " + max + " y se encontró en la " + posmax + " posición.");



// D ----------------------------------------
// 8. Hacer un programa que solicite 20 números y luego mostrar por pantalla el
// menor de ellos y la posición en la que fue encontrado.

// int n, posmin = 0, menor = 0;

// for (int x = 0; x < 20; x++)
// {
//     Console.WriteLine("Ingrese un número: ");
//     n = int.Parse(Console.ReadLine());

//     if (x == 0){
//         menor = n;
//         posmin = 1;
//     }else if (n < menor){
//         menor = n;
//         posmin = x + 1;
//     }

// }
// Console.WriteLine("El menor es: " + menor + " y se encuentra en " + posmin + " posición.");


// E ---------------------------------------------
// 11. Hacer un programa para ingresar 10 números y luego calcule y emita el mayor
// de los primos de la lista. En caso de no haber ningún número primo, deberá
// aclararlo con un cartel.

// NO ME SALIÓ - falta el cartel de "no hay primo", no se donde ponerlo.

// int n, maxprimo = 0, primo = 0;

// for (int x = 0; x < 10; x++)
// {
//     int con = 0;
    
//     Console.WriteLine("Ingrese un número: ");
//     n = int.Parse(Console.ReadLine());

//     for (int y = 1; y <= n; y++)
//     {
//         if (n % y == 0)
//             con++;
//     }

//     if (con == 2){
//         if (primo == 0){
//             maxprimo = n;
//             primo = 1;
//         }else if (n > maxprimo)
//             maxprimo = n;    
//     }

// }

// Console.WriteLine("EL primo más alto es: " + maxprimo);


// CICLO WHILE -------------

// A ------------------------------------
// 1. Hacer un programa para mostrar los números del 1 al 10. No se debe realizar
// ningún pedido de datos. USANDO WHILE.

// int n = 1;

// while (n <= 10)
// {
//     Console.WriteLine(n);
//     n++;
// }


// B ------------------------------------
// 3. Hacer un programa que solicite la edad de un grupo de personas. El programa
// deberá pedir edades hasta que se ingrese una edad menor a 18 años. Deberá
// mostrar por pantalla cuántas personas mayores se registraron.


// int n, con = 0;

// Console.WriteLine("Ingrese una edad: ");
// n = int.Parse(Console.ReadLine());

// while (n >= 18)
// {
//     con++;
//     Console.WriteLine("Ingrese otra edad: ");
//     n = int.Parse(Console.ReadLine());
// }

// Console.WriteLine("Se han ingresado " + con + " edades mayores a 18.");


// C -------------------------------------------
// 4. Hacer un programa que solicite dos números y luego muestre los números
// entre el menor y el mayor de ellos. Acordate, usando While.

// int a, b, max = 0, min = 0;

// Console.WriteLine("Ingrese un número: ");
// a = int.Parse(Console.ReadLine());
// Console.WriteLine("Ingrese otro: ");
// b = int.Parse(Console.ReadLine());

// if (a > b){
//     max = a;
//     min = b;
// }else{
//     max = b;
//     min = a;
// }

// while (min < max)
// {
//     Console.WriteLine(min);
//     min++;
// }



// D -------------------------------------------
// 5. Hacer un programa que muestre los números del 1 al 100 de 5 en 5. Ejemplo:
// 0, 5, 10, 15, 20…. 100. Usando While.

// int n = 0;

// while (n <= 100)
// {
//     Console.WriteLine(n);
//     n+=5;
// }



// E ------------------------------------------
// 6. Hacer un programa que solicite UN número y luego calcule y emita un cartel
// aclaratorio si el mismo es primo o no es primo.
// Nota: usando While. Ya lo hicimos con FOR, ahora con While.


// agregamos una nueva variable llamada div, para utilizarla como índice (la x en el ciclo for).
// int n, con = 0, div = 1;

// Console.WriteLine("Ingrese un número: ");
// n = int.Parse(Console.ReadLine());

// while (div <= n)
// {
//     if (n % div == 0)
//         con++;
//         div++;
// }

// if (con == 2)
//     Console.WriteLine("Es primo.");
// else
//     Console.WriteLine("No es primo.");


// F ------------------------------------
// 7. Hacer un programa que solicite una lista de números que corta cuando se
// ingresa un cero y luego mostrar por pantalla el máximo de ellos y la posición
// en la que fue ingresado.

// int n, pos = 0, max = 0;

// Console.WriteLine("Ingrese un número: ");
// n = int.Parse(Console.ReadLine());

// while (n != 0)
// {
//     if (pos == 0){
//         max = n;
//         pos = 1;
//     }else if (n > max){
//         max = n;
//         pos+=1;
//     }

// Console.WriteLine("Ingrese un número");
// n = int.Parse(Console.ReadLine());

// }

// Console.WriteLine("El nro máximo es: " + max + " encontrado en la posición " + pos);



// G --------------------------------------------
// 8. Hacer un programa que solicite una lista de números que corta cuando se
// ingresa un cero y luego mostrar por pantalla el menor y el segundo menor.

// variables para buscar el 2do mínimo y una bandera para las posiciones.
// int n, min2 = 0, ban = 0;

// Console.WriteLine("Ingrese un número: ");
// n = int.Parse(Console.ReadLine());

// // tomamos el primer número ingresado como el mínimo provisorio.
// int min1 = n;

// while (n != 0)
// {
//     if (n < min1){
//         // si el número ingresado es menor que el mínimo 1, quien antes era el min1 pasa a ser el min2; y este nuevo ingreso pasa a ser el min1.
//         min2 = min1;
//         min1 = n;
//     // si todavía no tenemos un segundo mínimo, se asigna el min2 al número ingresado, y aumentamos el valor de la ban +1.
//     }else if (ban == 0){
//         min2 = n;
//         ban = 1;
//     // y ahora si podemos preguntar si el número ingresado es menor al mínimo 2.
//     }else if (n < min2)
//         min2 = n;
    
//     Console.WriteLine("Ingrese un número: ");
//     n = int.Parse(Console.ReadLine());
// }

// Console.WriteLine("El mínimo 1 es: " + min1 + " y el segundo mínimo es " + min2);



// H --------------------------------------
// 9. Realizar el nuevamente el ejercicio 8 pero ahora debe devolver además la
// posición en la que fue encontrado cada uno de los mínimos.

// int n, min2 = 0, pos = 1, ban = 0;

// Console.WriteLine("Ingrese un número: ");
// n = int.Parse(Console.ReadLine());

// // el primero número ingresado lo tomo como el min1, y su posición será pos.
// int min1 = n, posmin1 = pos, posmin2 = 0;

// while (n != 0)
// {
//     if (n < min1){
//         min2 = min1;
//         min1 = n;
//         posmin2 = posmin1;
//         posmin1 = pos;
//     }else if (ban == 0){
//         min2 = n;
//         ban = 1;
//         posmin2 = pos;
//     }else if (n < min2){
//         min2 = n;
//         posmin2 = pos;
//     }
//     pos++;     
// Console.WriteLine("Ingrese un número: ");
// n = int.Parse(Console.ReadLine());
// }

// Console.WriteLine("EL menor es: " + min1 + " encontrado en la posición: " + posmin1);
// Console.WriteLine("El segundo menor es: " + min2 + " encontrado en la posición: " + posmin2);




// I -----------------------------------------------
// 10. Hacer un programa que solicite una lista de números que corta cuando se
// ingresa un cero y luego emitir por pantalla el máximo de los números
// negativos y el mínimo de los números positivos.

// int n, max_neg = 0, min_pos = 0, banpos = 0, banneg = 0;

// Console.WriteLine("Ingrese un número: ");
// n = int.Parse(Console.ReadLine());



// while (n != 0)
// {
    
//     if (n > 0){
//         // pregunto si el número ingresado es el primero de los positivos y lo asigno a la variable min_pos y aumento la bandera a 1.
//         if (banpos == 0){
//             min_pos = n;
//             banpos = 1;
//         // si ya hay números ingresados los voy comparando con lo que haya en min_pos y se irá reemplazando por el menor.
//         }else if (n < min_pos)
//             min_pos = n;
//     // lo mismo que para los positivos.
//     }else if (banneg == 0){
//         max_neg = n;
//         banneg = 1;
//     }else if (n > max_neg)
//         max_neg = n;

// Console.WriteLine("Ingrese un número: ");
// n = int.Parse(Console.ReadLine());

// }

// Console.WriteLine("El mínimo de los positivos es: " + min_pos + " y el máximo de los negativos es: " + max_neg);





// J --------------------------------------------
// 11. Hacer un programa para ingresar una lista de números que corta cuando se
// ingresa un cero y luego mostrar: la cantidad de números primos, la cantidad de
// números pares, la cantidad de positivos y la cantidad de negativos.


// int n, conprimo = 0, conpar = 0, conpos = 0, conneg = 0;

// Console.WriteLine("Ingrese un número: ");
// n = int.Parse(Console.ReadLine());


// while (n != 0)
// {
//     // para buscar números primos hay que tener un contador y una variable para los índices (posiciones).
//     int con = 0, j = 1;
//     // mientras el índice sea menor o igual al número ingresado..
//     while (j <= n)
//     {
//         // dividimos al número con el índice hasta que éstos sean iguales, y contamos cuantas veces la división dio por resto 0.
//         if (n % j == 0)
//             con ++;
//         j++;
//     }
//     // si da 2 veces resto 0, quiere decir que el número se divide únicamente por 1 y por si mismo (primo). 
//     if (con == 2)
//         conprimo++;
    

//     if (n > 0)
//         conpos++;
//     else
//         conneg++;


//     if (n % 2 == 0)
//         conpar++;

// Console.WriteLine("Ingrese un número: ");
// n = int.Parse(Console.ReadLine());

// }

// Console.WriteLine("Hay: " + conprimo + " primos.");
// Console.WriteLine("Hay: " + conpar + " pares.");
// Console.WriteLine("Hay: " + conpos + " positivos.");
// Console.WriteLine("Hay: " + conneg + " negativos.");