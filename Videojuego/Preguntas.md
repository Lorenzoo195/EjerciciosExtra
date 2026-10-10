¿Por qué Personaje puede ser una clase abstracta? 
Porque en el juego no tiene mucho sentido crear un "Personaje" a secas. Siempre vas a querer que sea algo concreto, como un Mago o un Arquero. Al hacer la clase abstracta, nos aseguramos de que nadie pueda hacer un new Personaje() por error.

¿Por qué un Mago puede almacenarse en una variable de tipo Personaje (por ejemplo en tu lista)? 
Esto pasa por la herencia. Como la clase Mago hereda de Personaje, en programación se dice que un Mago "es un" Personaje. Por eso, cualquier variable o lista que esté preparada para guardar Personajes, también aceptará sin problemas a sus clases hijas.

Al hacer el bucle, ¿Qué método ObtenerDescripcion() se ejecutará para cada objeto? 
Se ejecuta el método específico de la clase hija. Como en las clases hijas hemos puesto la palabra override, el programa sabe reconocer qué tipo de objeto es cada uno (aunque estén mezclados en la lista) y llama a la descripción exacta del Guerrero, del Mago o del Arquero en lugar de usar la del padre.