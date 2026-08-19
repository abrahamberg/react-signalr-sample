

# ASP.NET SignalR y React

Este proyecto contiene el código para la publicación del blog [ASP.NET SignalR y React](https://www.abrahamberg.com/blog/aspnet-signalr-and-react/).

Por favor, lee la [publicación](https://www.abrahamberg.com/blog/aspnet-signalr-and-react/) para entender qué demuestra este código.

Necesitas .NET 7.0 y Node.JS 20 (y npm) para ejecutar esta muestra.

## Usar como plantilla

Si deseas iniciar tu repositorio basado en esta configuración, haz clic [aquí](https://github.com/Abrahamberg/react-signalr-sample/generate).

## Ejecutar el código

Debes ejecutar el front end y el back end por separado.

### Iniciar el back end

1. Navega a la carpeta del back end.
2. **Opción 1:** Abre el archivo del proyecto en Visual Studio y ejecútalo.
   **Opción 2:** Abre una terminal (por ejemplo, Git Bash) y ejecuta `dotnet run`.

La aplicación se ejecuta en modo de desarrollo. Abre [https://localhost:5001/swagger/index.html](https://localhost:5001/swagger/index.html) para verla en el navegador.

No estamos utilizando la SayHello API, pero podrás comprobar que tu aplicación está en funcionamiento. El hub de SignalR está disponible en [https://localhost:5001/hub](https://localhost:5001/hub). Recibirás un mensaje de "Connection ID required" si intentas acceder a él a través del navegador.

### Iniciar el front end

1. Navega a la carpeta del front end.
2. Ejecuta `npm ci` para obtener las dependencias.
3. Ejecuta `npm start`.

La aplicación se ejecuta en modo de desarrollo. Abre [http://localhost:3000](http://localhost:3000) para verla en el navegador.

Abre varias ventanas del navegador en [http://localhost:3000](http://localhost:3000). Verás que, al presionar el botón (en cualquiera de las instancias), todas las páginas se actualizan.

## Más información

Puedes aprender más en la publicación del blog [ASP.NET SignalR y React](https://www.abrahamberg.com/blog/aspnet-signalr-and-react/).
---
