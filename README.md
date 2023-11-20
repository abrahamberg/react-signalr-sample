# Aspnet SignalR and React

This project is a code for the blog post [Aspnet SignalR and React](https://www.abrahamberg.com/blog/aspnet-signalr-and-react/).

Please read the [post](https://www.abrahamberg.com/blog/aspnet-signalr-and-react/) to understand what code is supped to demonstrate.

You need dotnet 7.0 and Node.JS  20 (and npm) to run this sample

## Use as Template

If you want to start you repo base on this setup please click [here](https://github.com/Abrahamberg/react-signalr-sample/generate)

## Running the code

You need to run the front end and backend separately.  

---

### Fire up the Backend

Navigate to the backend folder

Option 1 : open the project file in visual studio and run the project.
Option 2 : open a shell command line (ex. gitbash) and run `dotnet run`

It runs the app in the development mode.\
Open [https://localhost:5001/swagger/index.html](https://localhost:5001/swagger/index.html) to view it in the browser.

We are not using the SayHello API but you can see that your app is up and running the signal hub is available on [https://localhost:5001/hub](https://localhost:5001/hub)
you get `Connection ID required` if you try to access it trough browser.

---

### Fire up the FrontEnd

Navigate to the frontend folder and run `npm ci` to get the dependencies, followed by `npm start`
It runs the app in the development mode.\
Open [http://localhost:3000](http://localhost:3000) to view it in the browser.

The page will reload if you make edits.\
You will also see any lint errors in the console.

---

## Learn More

You can learn more in the  [Aspnet SignalR and React](https://www.abrahamberg.com/blog/aspnet-signalr-and-react/)
