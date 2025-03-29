import React from "react";
import logo from './logo.svg'; // Import logo image

function App() {
  return (
    <>
      <nav className="navbar navbar-light bg-light justify-content-between">
        <a className="navbar-brand">Pokemon Search</a>
        <form className="form-inline">
          <input
            className="form-control mr-sm-2"
            type="search"
            placeholder="Search"
            aria-label="Search"
          />
          <button className="btn btn-outline-success my-2 my-sm-0" type="submit">
            Search
          </button>
        </form>
      </nav>

      <div className="App">
        <header className="App-header">
          <img src={logo} className="App-logo" alt="logo" />
        </header>
      </div>
    </>
  );
}

export default App;
