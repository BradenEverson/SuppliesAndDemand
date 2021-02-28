import React from "react";
import "../index.css";
import CardImage from "./cardbg-1.jpg";
import CardImage2 from "./cardbg-2.jpg";
import Logo from "./Earth.png";
import UserIcon from "./user.png";

const UserDashboard = ({ fixed }) => {
  const [navbarOpen, setNavbarOpen] = React.useState(false);
  return (
    <>
      <nav className="relative flex flex-wrap items-center justify-between px-2 py-3 navbar-expand-lg bg-white-500 mb-3">
        <div className="container px-4 mx-auto flex flex-wrap items-center justify-between">
          <div className="w-full relative flex justify-between lg:w-auto lg:static lg:block lg:justify-start uppercase">
            <button
              className="bg-gray-500 hover:bg-gray-700 text-white font-bold px-8 py-3 rounded-full content-right inline-flex"
              href="#"
            >
              <img src={Logo} width={25} />
              &nbsp;&nbsp;
              <span className="uppercase">Sad</span>
            </button>
            <button
              className="text-white cursor-pointer text-xl leading-none px-3 py-1 border border-solid border-transparent rounded bg-transparent block lg:hidden outline-none focus:outline-none"
              type="button"
              onClick={() => setNavbarOpen(!navbarOpen)}
            >
              <i className="fas fa-bars"></i>
            </button>
          </div>
          <div
            className={
              "lg:flex flex-grow items-center" +
              (navbarOpen ? " flex" : " hidden")
            }
            id="example-navbar-danger"
          >
            <ul className="flex flex-col lg:flex-row list-none lg:ml-auto">
              <li className="nav-item">
                <button
                  className="bg-gray-500 hover:bg-gray-700 text-white font-bold px-8 py-3 rounded-full content-right inline-flex"
                  href="#"
                >
                  <img src={UserIcon} width={25} />
                  &nbsp;&nbsp;
                  <span className="uppercase">John D.</span>
                </button>
              </li>
            </ul>
          </div>
        </div>
      </nav>
      <div
        style={{ marginLeft: "16em", marginTop: "8em", marginBottom: "5em" }}
        className="flex flex-row content-center"
      >
        <div className="h-48 flex flex-wrap content-center p-10">
          <div
            class="max-w-sm rounded overflow-hidden shadow-lg"
            style={{ background: "#2B6CB0", color: "#fff" }}
          >
            <img class="w-full" src={CardImage} alt="Receiving hands" />
            <div class="px-6 py-4">
              <div class="font-bold text-xl mb-2">I need supplies</div>
            </div>
          </div>
        </div>
        <div className="h-48 flex flex-wrap content-center p-10">
          <div
            class="max-w-sm rounded overflow-hidden shadow-lg"
            style={{ background: "#2B6CB0", color: "#fff" }}
          >
            <img class="w-full" src={CardImage2} alt="Giving hands" />
            <div class="px-6 py-4">
              <div class="font-bold text-xl mb-2">I can give supplies</div>
            </div>
          </div>
        </div>
      </div>
      <div style={{ textAlign: "center", padding: "5em" }}>
        <button class="bg-blue-500 hover:bg-blue-700 text-white font-bold px-8 py-3 rounded-full content-center">
          Check Status
        </button>
      </div>
    </>
  );
};

export default UserDashboard;
