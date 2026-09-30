# XR Interaction Challenge

**Estudiante:** Quiroz Fernandez Jhon Aldred
**Código:**  2231893143
**Curso:** Laboratorio de Realidad Extendida (XR) para Videojuegos
**Docente:** Victor Alejandro Arroyo Castro

## Descripción breve
Sala de entrenamiento XR hecha en Unity. El usuario puede agarrar y lanzar objetos sobre una mesa,
encender o apagar una luz con un botón de interfaz espacial usando el rayo, y teletransportarse por el piso.

## Funcionalidades implementadas
- Proyecto configurado con URP, OpenXR y XR Interaction Toolkit (2.6.5), con Project Validation sin errores.
- Escena `EC_XR_ApellidoNombre` con piso, iluminación, 4 paredes como límites visuales y 5 objetos 3D.
- 5 objetos manipulables con `Rigidbody` + `XR Grab Interactable` (Velocity Tracking, se pueden lanzar).
- Interacción a distancia: botón en un Canvas World Space que enciende/apaga una luz con el `XR Ray Interactor`.
- Reto libre: teletransporte con `Teleportation Area` en el piso y `Teleportation Provider` en el XR Origin.

## Controles / instrucciones
Con visor Meta Quest (OpenXR):
- Apunta con el rayo a un objeto y presiona **Grip** para agarrarlo; suéltalo para lanzarlo.
- Apunta al botón "Luz ON / OFF" y presiona **Trigger**.
- Apunta al piso y presiona **Grip** para teletransportarte.

Sin visor (XR Device Simulator): pulsa Play y usa las teclas indicadas en el panel del simulador
(WASD para moverte, mouse para apuntar, teclas Grip/Trigger según el panel).

## Video demostrativo (máx. 1 minuto)
(https://drive.google.com/drive/folders/1j4UE8IgViB7ED0nil4-X_Cfc42R6upQI?usp=drive_link)

## Tecnologías y paquetes utilizados
- Unity 2022.3 LTS (Universal Render Pipeline)
- XR Plugin Management + OpenXR Plugin
- XR Interaction Toolkit 2.6.5 (Starter Assets y XR Device Simulator)
- Input System
- Lenguaje C#
