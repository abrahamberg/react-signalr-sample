# ASP.NET SignalR and React

This project is code for the blog post [ASP.NET SignalR and React](https://www.abrahamberg.com/blog/aspnet-signalr-and-react/).

Please read the [post](https://www.abrahamberg.com/blog/aspnet-signalr-and-react/) to understand what the code is intended to demonstrate.

You need .NET 7.0 and Node.JS 20 (and npm) to run this sample.

## Use as Template

If you want to start your repo based on this setup, please click [here](https://github.com/Abrahamberg/react-signalr-sample/generate).

## Running the Code

You need to run the front end and backend separately.

### Fire up the Backend

1. Navigate to the backend folder.
2. **Option 1:** Open the project file in Visual Studio and run the project.
   **Option 2:** Open a command line (ex. Git Bash) and run `dotnet run`.

The app runs in development mode. Open [https://localhost:5001/swagger/index.html](https://localhost:5001/swagger/index.html) to view it in the browser.

We are not using the SayHello API, but you can see that your app is up and running. The SignalR hub is available on [https://localhost:5001/hub](https://localhost:5001/hub). You will receive a "Connection ID required" message if you try to access it through the browser.

### Fire up the Front End

1. Navigate to the frontend folder.
2. Run `npm ci` to get the dependencies.
3. Run `npm start`.

The app runs in development mode. Open [http://localhost:3000](http://localhost:3000) to view it in the browser.

The page will reload if you make edits. You will also see any lint errors in the console.

## Learn More

You can learn more in the [ASP.NET SignalR and React](https://www.abrahamberg.com/blog/aspnet-signalr-and-react/) blog post.
---
