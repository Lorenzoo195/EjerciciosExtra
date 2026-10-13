# Ejercicios adicionales de C#

Estos ejercicios sirven para practicar los contenidos trabajados en clase utilizando problemas diferentes al proyecto Restaurante.

No es necesario realizarlos en orden.

Algunos ejercicios están pensados para practicar un concepto concreto y otros requieren combinar varios contenidos.

Contenidos:

- Clases y objetos.
- Herencia.
- Clases abstractas.
- `override`.
- Polimorfismo.
- `List<T>`.
- Operador `is`.
- Métodos y parámetros.
- `Console.ReadLine()`.
- `TryParse()`.
- `while`.
- `switch`.

---

# 1. Videojuego

Crear una clase abstracta:

```csharp
Personaje
```

con las propiedades:

- Nombre.
- Vida.

Definir el método:

```csharp
public abstract string ObtenerDescripcion();
```

Crear las siguientes clases:

```text
Personaje
 |
 +-- Guerrero
 |
 +-- Mago
 |
 +-- Arquero
```

Cada clase tendrá una propiedad específica:

- `Guerrero`: Fuerza.
- `Mago`: Mana.
- `Arquero`: NumeroFlechas.

Crear varios personajes y almacenarlos en:

```csharp
List<Personaje>
```

Recorrer la colección y mostrar la descripción de cada personaje.

Responder:

1. ¿Por qué `Personaje` puede ser una clase abstracta?
2. ¿Por qué un `Mago` puede almacenarse en una variable de tipo `Personaje`?
3. ¿Qué método `ObtenerDescripcion()` se ejecutará para cada objeto?

---

# 2. Plataforma de streaming

Una plataforma dispone de diferentes tipos de contenido.

Crear una clase abstracta:

```csharp
Contenido
```

con las propiedades:

- Título.
- Duración.

Crear:

```text
Contenido
 |
 +-- Pelicula
 |
 +-- Serie
 |
 +-- Documental
```

Cada clase tendrá además información específica.

## Pelicula

- Director.

## Serie

- Número de temporadas.

## Documental

- Temática.

La clase `Contenido` definirá:

```csharp
public abstract string ObtenerDescripcion();
```

Cada clase hija deberá implementar el método.

Crear:

- 2 películas.
- 2 series.
- 1 documental.

Almacenar todos los objetos en:

```csharp
List<Contenido>
```

Recorrer la colección y mostrar la descripción de cada contenido.

---

# 3. Buscar contenido

Continuar con el ejercicio anterior.

Solicitar al usuario:

```text
Título a buscar:
```

Buscar el contenido recorriendo la colección.

La búsqueda no deberá depender de mayúsculas y minúsculas.

Si existe:

```text
Contenido encontrado:

Interstellar - 169 minutos
```

Si no existe:

```text
No se ha encontrado el contenido.
```

Resolver sin utilizar LINQ.

---

# 4. Filtrar películas

Utilizando la colección del ejercicio de streaming, mostrar solamente los objetos que sean de tipo `Pelicula`.

Utilizar el operador:

```csharp
is
```

Después, modificar el programa para mostrar únicamente las series.

Responder:

1. ¿De qué tipo es la colección?
2. ¿De qué tipo es la variable utilizada en el `foreach`?
3. ¿Cómo puede el programa saber si un determinado `Contenido` es realmente una `Pelicula`?

---

# 5. Biblioteca

Crear una clase abstracta:

```csharp
Publicacion
```

con:

- Título.
- Año de publicación.

Crear:

```text
Publicacion
 |
 +-- Libro
 |
 +-- Revista
 |
 +-- Comic
```

Añadir una propiedad específica a cada clase.

Por ejemplo:

- `Libro`: Autor.
- `Revista`: Número.
- `Comic`: Dibujante.

Todas las publicaciones deberán implementar:

```csharp
ObtenerDescripcion()
```

Crear diferentes objetos y almacenarlos en:

```csharp
List<Publicacion>
```

Mostrar posteriormente todas las publicaciones.

---

# 6. Publicaciones por año

Continuar con el ejercicio de la biblioteca.

Solicitar:

```text
Mostrar publicaciones posteriores al año:
```

Validar el dato mediante:

```csharp
int.TryParse()
```

Mostrar solamente las publicaciones cuyo año sea superior al indicado.

Si el usuario introduce un valor que no sea un número, mostrar un mensaje de error.

Resolver sin utilizar LINQ.

---

# 7. Parking

Crear una clase abstracta:

```csharp
Vehiculo
```

con:

- Matrícula.
- Marca.

Crear las clases:

```text
Vehiculo
 |
 +-- Coche
 |
 +-- Moto
 |
 +-- Furgoneta
```

Añadir al menos una propiedad específica a cada clase.

Crear varios vehículos y almacenarlos en:

```csharp
List<Vehiculo>
```

Crear un menú:

```text
=== PARKING ===

1. Ver vehículos
2. Buscar por matrícula
3. Mostrar coches
0. Salir
```

El programa deberá continuar funcionando hasta seleccionar la opción `0`.

Separar cada operación en un método.

---

# 8. Validar el menú

Continuar con el ejercicio anterior.

El programa deberá controlar entradas como:

```text
Pepe
-1
25
2.5
```

Utilizar `TryParse()`.

Una entrada incorrecta no deberá finalizar la aplicación.

---

# 9. Producto más barato

Crear una clase:

```csharp
Articulo
```

con:

- Nombre.
- Precio.

Crear varios artículos y almacenarlos en:

```csharp
List<Articulo>
```

Recorrer la colección y localizar el artículo con el precio más bajo.

Ejemplo:

```text
El artículo más barato es:

Cable USB - 4,50 €
```

Resolver sin utilizar LINQ.

---

# 10. Precio medio

Utilizando la colección del ejercicio anterior, calcular el precio medio de todos los artículos.

El resultado deberá calcularse a partir de los objetos almacenados en la colección.

No se indicará manualmente el número de artículos.

Ejemplo:

```text
Precio medio: 23,45 €
```

---

# 11. Buscar por precio máximo

Continuar con la colección de artículos.

Solicitar:

```text
Precio máximo:
```

Validar el valor utilizando:

```csharp
decimal.TryParse()
```

Mostrar todos los artículos cuyo precio sea igual o inferior al indicado.

Si no existe ninguno, mostrar un mensaje.

---

# 12. Extraer código a métodos

Partiendo de cualquiera de los ejercicios anteriores, comprobar si existen operaciones escritas directamente dentro de `Program.cs`.

Separarlas en métodos.

Por ejemplo:

```csharp
MostrarArticulos(...)
BuscarArticulo(...)
MostrarArticulosPorPrecio(...)
CalcularPrecioMedio(...)
```

Los datos necesarios deberán recibirse mediante parámetros.

Evitar crear una segunda colección dentro de los métodos si ya existe una colección creada en el programa principal.

---

# 13. ¿Herencia o composición?

Para cada una de las siguientes relaciones, indicar si utilizarías principalmente herencia o composición.

Justificar brevemente la respuesta.

### Caso A

Un `Coche` es un `Vehiculo`.

### Caso B

Un `Coche` tiene un `Motor`.

### Caso C

Un `Pedido` tiene varios `Producto`.

### Caso D

Una `Pelicula` es un `Contenido`.

### Caso E

Un `Ordenador` tiene un `Procesador`.

### Caso F

Un `Profesor` es una `Persona`.

### Caso G

Un `EquipoFutbol` tiene varios `Jugador`.

### Caso H

Una `Moto` es un `Vehiculo`.

---

# 14. Diseñar una jerarquía

Una empresa quiere desarrollar una aplicación para gestionar empleados.

Existen:

- Programadores.
- Diseñadores.
- Responsables de proyecto.

Todos tienen:

- Nombre.
- Salario.

Cada tipo de empleado tiene además información específica.

Diseñar las clases necesarias.

El ejercicio deberá incluir:

- Una clase base.
- Al menos tres clases hijas.
- Al menos un método abstracto.
- Uso de `override`.
- Una `List` capaz de almacenar todos los empleados.
- Un recorrido que muestre la información de todos ellos.

No se proporciona la estructura de las clases. Deberá decidirse durante el desarrollo.

---

# 15. Corregir el diseño

Un programador ha creado las siguientes clases:

```csharp
public class Perro
{
    public string Nombre { get; set; }
}

public class Gato
{
    public string Nombre { get; set; }
}

public class Pajaro
{
    public string Nombre { get; set; }
}
```

Posteriormente necesita almacenar todos los animales juntos.

Actualmente utiliza:

```csharp
List<Perro> perros;
List<Gato> gatos;
List<Pajaro> pajaros;
```

Modificar el diseño para poder utilizar una única colección:

```csharp
List<Animal>
```

Todos los animales deberán disponer además de:

```csharp
HacerSonido()
```

Cada tipo de animal tendrá un comportamiento diferente.

---

# 16. ¿Qué mostrará el programa?

Analizar el siguiente código:

```csharp
public abstract class Animal
{
    public string Nombre { get; set; }

    public abstract string HacerSonido();
}

public class Perro : Animal
{
    public override string HacerSonido()
    {
        return "Guau";
    }
}

public class Gato : Animal
{
    public override string HacerSonido()
    {
        return "Miau";
    }
}
```

Y:

```csharp
List<Animal> animales = new List<Animal>();

animales.Add(new Perro { Nombre = "Toby" });
animales.Add(new Gato { Nombre = "Luna" });

foreach (Animal animal in animales)
{
    Console.WriteLine(
        animal.Nombre + ": " + animal.HacerSonido()
    );
}
```

Sin ejecutar el programa:

1. Indicar qué mostrará por pantalla.
2. Indicar el tipo de la variable `animal`.
3. Indicar el tipo real del objeto en cada iteración.
4. Explicar por qué se ejecutan implementaciones diferentes de `HacerSonido()`.

Después, ejecutar el código y comprobar la respuesta.

---

# 17. ¿Compila o no compila?

Utilizando las clases `Animal`, `Perro` y `Gato`, analizar los siguientes casos.

### A

```csharp
Animal animal = new Animal();
```

### B

```csharp
Animal animal = new Perro();
```

### C

```csharp
Perro perro = new Perro();
Animal animal = perro;
```

### D

```csharp
Animal animal = new Perro();
Perro perro = animal;
```

### E

```csharp
List<Animal> animales = new List<Animal>();

animales.Add(new Perro());
animales.Add(new Gato());
```

### F

```csharp
Animal animal = new Gato();

Console.WriteLine(animal.HacerSonido());
```

Para cada caso indicar:

1. Si compila.
2. Si no compila, explicar el motivo.
3. Si compila, indicar el tipo de la variable y el tipo real del objeto.

---

# 18. Cajero automático

Crear una aplicación de consola que simule algunas operaciones básicas de un cajero.

El programa comenzará con un saldo inicial, por ejemplo:

```csharp
decimal saldo = 1000;
```

Mostrar un menú:

```text
=== CAJERO ===

1. Consultar saldo
2. Ingresar dinero
3. Retirar dinero
0. Salir
```

Requisitos:

- El menú deberá repetirse hasta seleccionar `0`.
- Utilizar `switch`.
- Validar las cantidades mediante `decimal.TryParse()`.
- No permitir ingresos negativos.
- No permitir retiradas negativas.
- No permitir retirar una cantidad superior al saldo.
- Separar las operaciones en métodos.

No es necesario utilizar clases para este ejercicio.

---

# 19. Adivina el número

Crear un programa que genere un número aleatorio entre 1 y 100.

El usuario deberá intentar adivinarlo.

Después de cada intento, el programa indicará:

```text
El número es mayor.
```

o:

```text
El número es menor.
```

Cuando el usuario acierte:

```text
Correcto. Has necesitado 7 intentos.
```

Validar mediante `TryParse()` que el usuario introduce un número.

El programa no deberá finalizar si se introduce texto.

---

# 20. Proyecto final: gimnasio

Desarrollar una pequeña aplicación para gestionar las actividades de un gimnasio.

Crear una clase abstracta:

```csharp
Actividad
```

Todas las actividades tendrán:

- Nombre.
- Duración.
- Número máximo de participantes.

Crear al menos:

```text
Actividad
 |
 +-- Spinning
 |
 +-- Yoga
 |
 +-- CrossTraining
```

Cada clase deberá tener alguna propiedad específica.

Definir en `Actividad` al menos un método abstracto que deba ser implementado por las clases hijas.

Crear varias actividades y almacenarlas en:

```csharp
List<Actividad>
```

La aplicación tendrá un menú similar a:

```text
=== GIMNASIO ===

1. Ver actividades
2. Buscar actividad
3. Ver actividades por duración máxima
4. Ver actividades por tipo
0. Salir
```

Requisitos:

- Utilizar herencia.
- Utilizar una clase abstracta.
- Utilizar `override`.
- Utilizar polimorfismo.
- Utilizar `List<Actividad>`.
- Utilizar `is` en alguna operación.
- Utilizar métodos.
- Pasar las colecciones mediante parámetros.
- Utilizar `while` y `switch`.
- Utilizar `TryParse()` cuando sea necesario.
- Controlar las entradas incorrectas.

No utilizar LINQ.

---

# Propuestas de ampliación

Cuando un ejercicio esté terminado, se puede ampliar sin modificar el objetivo principal.

Algunas posibles ampliaciones:

- Añadir nuevos tipos a una jerarquía existente.
- Incorporar nuevas opciones a un menú.
- Permitir añadir objetos desde la consola.
- Permitir eliminar objetos de una colección.
- Añadir nuevas búsquedas o filtros.
- Mostrar estadísticas sencillas a partir de una colección.
- Dividir código adicional en métodos.

No es necesario realizar estas ampliaciones salvo que se indique en clase.