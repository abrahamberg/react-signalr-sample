import React, { useEffect, useState } from 'react';
import './App.css';
import Connector from './signalr-connection'
function App() {
  const { newMessage, events } = Connector();
  const [message, setMessage] = useState("initial value");
  useEffect(() => {
    events((_, message) => setMessage(message));
  });
  return (
    <div className="App">
      <span>message from signalR: <span style={{ color: "green" }}>{message}</span> </span>
      <br />
      <button onClick={() => newMessage((new Date()).toISOString())}>send date </button>
    </div>
  );
}
export default App;