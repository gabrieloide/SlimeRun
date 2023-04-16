# Instrucciones de instalación y ejecución

Este proyecto requiere la instalación de Python 3, MongoDB y las dependencias especificadas en el archivo requirements.txt.

## Instalación de Python

Para instalar Python 3 en tu sistema operativo, sigue los siguientes pasos:

1. Visita la página de descarga de Python en [python.org](https://www.python.org/downloads/).
2. Descarga la última versión estable de Python 3 para tu sistema operativo.
3. Ejecuta el archivo de instalación descargado y sigue las instrucciones del instalador.

## Instalación de MongoDB

Para instalar MongoDB en tu sistema operativo, sigue los siguientes pasos:

1. Visita la página de descarga de MongoDB en [mongodb.com](https://www.mongodb.com/try/download/community).
2. Descarga la última versión estable de MongoDB para tu sistema operativo.
3. Ejecuta el archivo de instalación descargado y sigue las instrucciones del instalador.

## Creación y activación del entorno virtual

Para crear y activar un entorno virtual utilizando venv, sigue los siguientes pasos:

1. Abre una terminal en la carpeta raíz del proyecto.
2. Ejecuta el siguiente comando para crear el entorno virtual:

   ```bash
   python -m venv venv
   ```
   Este comando creará una carpeta llamada venv en la carpeta raíz del proyecto con el entorno virtual.
   
3. Luego, activa el entorno virtual ejecutando el siguiente comando:

   ```bash
   source venv/bin/activate
   ```
   Si estás en Windows, el comando para activar el entorno virtual es diferente:

   ```bash
   venv\Scripts\activate
   ```
   Al activar el entorno virtual, la terminal cambiará para indicar que estás trabajando dentro del entorno virtual.

## Instalación de las dependencias

Una vez que tienes el entorno virtual activado, puedes instalar las dependencias requeridas por el proyecto. Para hacerlo, sigue los siguientes pasos:

1. Abre una terminal en la carpeta raíz del proyecto.
2. Asegúrate de que el entorno virtual esté activado (ver paso anterior).
3. Ejecuta el siguiente comando para instalar las dependencias mediante pip:

   ```bash
   pip install -r requirements.txt
   ```
   Este comando instalará las dependencias dentro del entorno virtual.

## Ejecución del servidor Flask

Para ejecutar el servidor Flask dentro del entorno virtual, sigue los mismos pasos que se indicaron anteriormente:

1. Abre una terminal en la carpeta raíz del proyecto.
2. Asegúrate de que el entorno virtual esté activado (ver paso anterior).
3. Ejecuta el siguiente comando para iniciar el servidor:

   ```bash
   python src/app.py
   ```


Para descargar el juego, por favor visite la página de itch.io en el siguiente enlace:

[https://virterex.itch.io/slimerun](https://virterex.itch.io/slimerun)

Una vez en la página de itch.io, descargue el archivo .rar del juego y ábralo en su computadora. Para ejecutar el juego, busque el archivo de aplicación y haga doble clic en él.

¡Disfrute del juego!