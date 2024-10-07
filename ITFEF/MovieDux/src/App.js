import React from "react";
import "./styles/styles.css";

function App() {
  return (
    <div className="App">
      <header className="header">
        <img className="logo" src='../public/images/logo.png' alt="moviedux"/>
        <h1 className="title">Moviedux</h1>
        <h2 className="app-subtitle">It's time for popcorn! Find your next movie here.</h2>
      </header>

      <footer className="footer">
        <p>© 2024 Moviedux. All rights reserved.</p>
      </footer>
    </div>
  );
}

export default App;