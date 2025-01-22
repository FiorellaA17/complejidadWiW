# **Who is Who (WiW)**  
Juego de adivinanza desarrollado con un Bot basado en **Árboles de Decisión**.

## **Descripción del Proyecto**  
Who is Who (WiW) es un juego interactivo donde un jugador humano compite contra un **Bot** para identificar un personaje secreto a través de preguntas. El Bot utiliza **árboles de decisión** para deducir el personaje elegido por el usuario de manera eficiente.

---

## **Funcionamiento del Sistema**

### **1. Inicio del Juego**  
Al iniciar el sistema, se muestra una pantalla que solicita al usuario seleccionar el directorio donde se encuentra el dataset.

**Instrucciones:**  
1. Busca la carpeta que contiene el dataset.  
2. Selecciona el archivo y presiona el botón **"Iniciar"**.

![Pantalla Inicial](https://github.com/FiorellaA17/complejidadWiW/blob/e5c1fd29a5e591ba92a6c90ea1a687e2b5903213/img-%20inicio.png)  
*Figura 1: Pantalla para seleccionar el directorio del dataset.*

---

### **2. Selección de Personaje**  
Luego, se despliega una lista con los personajes disponibles. El jugador debe seleccionar un personaje y confirmar su elección antes de comenzar el juego.

![Pantalla Selección](https://github.com/FiorellaA17/complejidadWiW/blob/e5c1fd29a5e591ba92a6c90ea1a687e2b5903213/img-%20seleccionar%20personaje.png)  
*Figura 2: Pantalla para elegir el personaje.*

---

### **3. Desarrollo del Juego**  
El juego transcurre por turnos, en los cuales:  
1. El jugador humano responde preguntas hechas por el Bot sobre el personaje seleccionado.  
2. El jugador humano puede realizar preguntas similares al Bot para deducir el personaje que seleccionó.  
3. **Interacción adicional:** Cuando el Bot responde a una pregunta del jugador, este debe marcar (tachar o eliminar visualmente) los personajes que no coinciden con la respuesta dada.  
   - **Ejemplo:** Si se pregunta "¿Tiene sombrero?" y el Bot responde "No", el jugador debe hacer clic en los personajes que tienen sombrero para eliminarlos de la lista.  

**Ejemplos de preguntas:**  
- "¿Es rubio?"  
- "¿Tiene gafas?"  
- "¿Es mujer?"  

El Bot actualiza su estrategia basándose en las respuestas y utiliza un árbol de decisión para optimizar la deducción.

![Pantalla Juego](https://github.com/FiorellaA17/complejidadWiW/blob/e5c1fd29a5e591ba92a6c90ea1a687e2b5903213/img-juego%20en%20progreso1.png)  
*Figura 3: Interfaz inicial del juego una vez seleccionados el personaje y el dataset.*

![Pantalla Juego2](https://github.com/FiorellaA17/complejidadWiW/blob/e5c1fd29a5e591ba92a6c90ea1a687e2b5903213/img-juego%20en%20progreso2.png)  
*Figura 4: Vista del juego en progreso.*


---

### **4. Fin del Juego**  
El primer jugador en identificar correctamente el personaje del oponente gana la partida.

---

## **Ideas para Mejoras Futuras**  
- Implementar niveles de dificultad ajustables para el Bot.  
- Ampliar el dataset con más personajes y atributos.  
- Adaptar el juego para permitir partidas en línea entre usuarios.  

---

## **Conclusión**  
Desarrollar este proyecto me permitió aplicar conceptos de **aprendizaje automatizado** y **árboles de decisión**, además de afianzar mis habilidades habilidades. Es una excelente base para futuras mejoras y proyectos más complejos.
