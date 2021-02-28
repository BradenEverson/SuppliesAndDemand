import { Fragment } from "react";
import "./App.css";
import Home from "./components/Home";
import Form from "./components/Form";
import SignUp from "./components/SignUp";
import UserDashboard from "./components/UserDashboard";

function App() {
  return (
    <Fragment>
       <Home />
      {/* <Form /> */}
      {/* <SignUp /> */}
      <UserDashboard />
    </Fragment>
  );
}

export default App;
