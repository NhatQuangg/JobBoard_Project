import React from "react";
import logo from "./logo.svg";
import "./App.css";
import Navbar from "./Components/Navbar/Navbar";
import Sidebar from "./Components/Sidebar/Sidebar";

function App() {
    return (
        <div className="min-h-screen bg-background">
            <Navbar />
            <Sidebar />
        </div>
    );
}

export default App;
