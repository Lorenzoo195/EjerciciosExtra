# Respuestas Ejercicios

## Ejercicio 13. ¿Herencia o composición?

* **Caso A (Un Coche es un Vehiculo):** Herencia. Cumple la relación "es un", ya que un coche es un tipo de vehículo.
* **Caso B (Un Coche tiene un Motor):** Composición. Cumple "tiene un", el motor es una parte que compone el coche.
* **Caso C (Un Pedido tiene varios Producto):** Composición. El pedido contiene una lista de productos, no es un producto en sí.
* **Caso D (Una Pelicula es un Contenido):** Herencia. Una película es un tipo específico de contenido.
* **Caso E (Un Ordenador tiene un Procesador):** Composición. El procesador es un componente dentro del ordenador.
* **Caso F (Un Profesor es una Persona):** Herencia. Un profesor es una persona con un rol específico.
* **Caso G (Un EquipoFutbol tiene varios Jugador):** Composición. El equipo está formado por una colección de jugadores.
* **Caso H (Una Moto es un Vehiculo):** Herencia. La moto es un tipo de vehículo.

---

## Ejercicio 16. ¿Qué mostrará el programa?

1. **¿Qué mostrará por pantalla?**
   ```text
   Toby: Guau
   Luna: Miau
   ```
2. **Tipo de la variable `animal`:** Tipo `Animal` (la clase abstracta base).
3. **Tipo real del objeto en cada iteración:**
   * En la 1ª iteración: `Perro`.
   * En la 2ª iteración: `Gato`.
4. **¿Por qué se ejecutan implementaciones diferentes de `HacerSonido()`?**
   Por el polimorfismo. Como el método está marcado como `abstract` en la clase base y con `override` en las hijas, C# ejecuta en tiempo de ejecución la versión específica del objeto real.

---

## Ejercicio 17. ¿Compila o no compila?

* **Caso A (`Animal animal = new Animal();`):**
  * No compila.
  * Motivo: `Animal` es una clase abstracta y las clases abstractas no se pueden instanciar con `new`.

* **Caso B (`Animal animal = new Perro();`):**
  * Sí compila.
  * Tipo de la variable: `Animal`.
  * Tipo real del objeto: `Perro`.

* **Caso C (`Perro perro = new Perro(); Animal animal = perro;`):**
  * Sí compila.
  * Tipo de la variable: `animal` es de tipo `Animal` (y `perro` es `Perro`).
  * Tipo real del objeto: `Perro` (conversión implícita de hijo a padre).

* **Caso D (`Animal animal = new Perro(); Perro perro = animal;`):**
  * No compila.
  * Motivo: No se puede asignar una variable de tipo padre (`Animal`) a una variable hija (`Perro`) de forma directa, haría falta un casteo explícito `(Perro)animal`.

* **Caso E (`List<Animal> animales...`):**
  * Sí compila.
  * Tipo de la variable: `List<Animal>`.
  * Tipo real de los objetos: El primero es `Perro` y el segundo es `Gato`.

* **Caso F (`Animal animal = new Gato(); Console.WriteLine(animal.HacerSonido());`):**
  * Sí compila.
  * Tipo de la variable: `Animal`.
  * Tipo real del objeto: `Gato` (mostrará "Miau" por consola).
