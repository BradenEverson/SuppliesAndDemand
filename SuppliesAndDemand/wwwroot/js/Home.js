import React from "react";
import "../index.css";
import backgroundImg from "./bg.jpg";

const Home = () => {
  return (
    <div class="bg-gray-50 flex flex-row ...">
      <div
        style={{
          backgroundImage: "url(" + backgroundImg + ")",
          backgroundPosition: "center",
          backgroundSize: "cover",
          backgroundRepeat: "no-repeat",
        }}
        className="background-image"
      >
      </div>
      <div className="left" >
        <h1 style={{ color: "black" }}>Welcome to Supplies and Demand!</h1>
        <div style={{ textAlign: "center", padding: "10em" }}>
          <button class="bg-blue-500 hover:bg-blue-700 text-white font-bold px-8 py-3 rounded-full content-center">
            &nbsp; Log in &nbsp;
          </button>
          <br />
          <p>Or</p>
          <button class="bg-blue-500 hover:bg-blue-700 text-white font-bold px-8 py-3 rounded-full content-center">
            Sign Up 
          </button>
        </div>
      </div>
    </div>
  );
};

export default Home;
