# 🚀 Pong Space

## 🎮 Descripción

**Pong Space** es un juego arcade local de 2 jugadores basado en el Pong clásico, ambientado en un escenario espacial. Cada jugador controla una paleta y debe evitar que la pelota cruce su arco, mientras intenta anotarle al rival.

La pelota gana velocidad con cada rebote, y si nadie convierte un gol dentro del tiempo límite, se le anota automáticamente el punto al jugador que tenía la pelota de su lado — así que ningún punto se puede evitar por siempre.

Gana la partida el primer jugador en alcanzar la cantidad de rondas configurada (por defecto, al mejor de 5).

## 🕹️ Cómo jugar

Este juego se juega con **un solo teclado**, ideal para desafiar a alguien sentado a tu lado.

### Player 1
 
| Acción | Tecla |
|---|---|
| Mover arriba | `W` |
| Mover abajo | `S` |
| Mover izquierda | `A` |
| Mover derecha | `D` |
 
### Player 2
 
| Acción | Tecla |
|---|---|
| Mover arriba | `↑` (flecha arriba) |
| Mover abajo | `↓` (flecha abajo) |
| Mover izquierda | `←` (flecha izquierda) |
| Mover derecha | `→` (flecha derecha) |

### Controles generales

| Acción | Tecla |
|---|---|
| Pausar / Reanudar | `Esc` o `P` |

### Reglas rápidas

- Cada jugador defiende su lado de la cancha y ataca el arco contrario.
- La pelota acelera con cada impacto contra una paleta.
- Si pasan 20 segundos sin que se convierta un gol, se le anota el punto automáticamente al jugador que tenía la pelota de su lado.
- Gana la partida quien primero llegue a la cantidad de rondas necesaria (configurable desde el menú de Opciones).
- Desde Opciones también podés ajustar, para cada jugador, la velocidad, el tamaño de la paleta y el color.

## 🛠️ Stack utilizado

- **Motor**: Unity 6 (LTS)
- **Lenguaje**: C#
- **UI**: Unity UI (uGUI) + TextMeshPro
- **Física**: Unity Physics 2D (Rigidbody2D, Collider2D)
- **Arquitectura de datos**: ScriptableObjects para la configuración del juego y de cada jugador (velocidad, color, altura de paleta, teclas, rondas para ganar, tiempo límite por gol), permitiendo ajustar valores desde el editor y en tiempo real sin tocar código.
- **Control de versiones**: Git

## 📦 Sobre esta build

Este juego fue desarrollado como proyecto académico (Image Campus), explorando mecánicas clásicas de arcade con una capa de personalización (velocidad, color y controles configurables por jugador) y un sistema de reglas propio (límite de tiempo por gol, velocidad progresiva de la pelota).

¡Gracias por jugar! Cualquier comentario o feedback es bienvenido en la sección de comentarios de itch.io.

Desarrollado por : Brian Amarillo 
Link de itchio: https://brianamarillo99.itch.io/pongspace

# 🚀 Pong Space

## 🎮 Description

**Pong Space** is a local 2-player arcade game based on classic Pong, set in a space-themed scenario. Each player controls a paddle and must keep the ball from crossing their own goal line, while trying to score on the opponent.

The ball gains speed with every bounce, and if neither player scores within the time limit, the point is automatically awarded to the player who had the ball on their side — so no point can be avoided forever.

The first player to reach the configured number of rounds wins the match (default: best of 5).

## 🕹️ How to play

This game is played on a **single keyboard**, perfect for challenging someone sitting right next to you.

### Player 1

| Action | Key |
|---|---|
| Move up | `W` |
| Move down | `S` |
| Move left | `A` |
| Move right | `D` |

### Player 2

| Action | Key |
|---|---|
| Move up | `↑` (up arrow) |
| Move down | `↓` (down arrow) |
| Move left | `←` (left arrow) |
| Move right | `→` (right arrow) |

### General controls

| Action | Key |
|---|---|
| Pause / Resume | `Esc` or `P` |

### Quick rules

- Each player defends their side of the court and attacks the opponent's goal.
- The ball speeds up with every hit against a paddle.
- If 20 seconds pass without a goal being scored, the point is automatically awarded to the player who had the ball on their side.
- The first player to reach the required number of rounds wins the match (configurable from the Options menu).
- From Options, you can also adjust, for each player, speed, paddle size, and color.

## 🛠️ Tech stack

- **Engine**: Unity 6 (LTS)
- **Language**: C#
- **UI**: Unity UI (uGUI) + TextMeshPro
- **Physics**: Unity Physics 2D (Rigidbody2D, Collider2D)
- **Data architecture**: ScriptableObjects for game and per-player configuration (speed, color, paddle height, keybindings, rounds to win, goal time limit), allowing values to be tuned from the editor and in real time without touching code.
- **Version control**: Git

## 📦 About this build

This game was developed as an academic project (Image Campus), exploring classic arcade mechanics with a layer of customization (speed, color, and per-player controls) and a custom rule set (goal time limit, progressive ball speed).

Thanks for playing! Any comments or feedback are welcome in the itch.io comments section.

Developed by: Brian Amarillo
Itchio link: Link de itchio: https://brianamarillo99.itch.io/pongspace
