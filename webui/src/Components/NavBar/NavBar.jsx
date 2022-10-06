import { useSelector } from "react-redux";
import "./navbar.css";
const NavBar = () => {
  const user = useSelector((state) => state.auth.login.currentUser);
  return (
    user && 
    <nav className="navbar-container">
      <p className="navbar-user">Welcome <span> {user.userName} </span> </p>
    </nav>
  );
};

export default NavBar;
