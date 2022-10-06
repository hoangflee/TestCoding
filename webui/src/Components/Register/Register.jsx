import { useDispatch } from "react-redux";
import { useNavigate } from "react-router-dom";
import { Link } from "react-router-dom";
import { useFormik } from "formik";
import * as Yup from "yup";
import { registerUser } from "../../redux/apiRequest";
import "./register.css";
const Register = () => {

    const formik = useFormik({
        initialValues: {
          username: "",
          email: "",
          password: "",
        },
        validationSchema: Yup.object({
            username: Yup.string()
                .required("Required")
                .min(4, "Must be 4 characters or more"),
            email: Yup.string()
                .required("Required")
                .matches(
                    /^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$/,
                    "Please enter a valid email address"),
            password: Yup.string()
                .required("Required")
                .min(4, "Must be 4 characters or more"),
        }),
        onSubmit: (values) => {
            registerUser(values, dispatch, navigate);
        },
      });

    const dispatch = useDispatch();
    const navigate = useNavigate();

    return ( 
        <section className="register-container">
              <div className="register-title"> Welcome to Big Star </div>
            <form onSubmit={formik.handleSubmit}>
                <input type="text" placeholder="Username" id="username" name="username" value={formik.values.username} onChange={formik.handleChange}/>
                {formik.errors.username && (
                    <p> {formik.errors.username} </p>
                )}
                <input type="text" placeholder="Email" id="email" name="email" value={formik.values.email} onChange={formik.handleChange} />
                {formik.errors.email && (
                    <p> {formik.errors.email} </p>
                )}
                <input type="password" placeholder="Password" id="password" name="password" value={formik.values.password} onChange={formik.handleChange}/>
                {formik.errors.password && (
                    <p> {formik.errors.password} </p>
                )}
                <div className="register-button">
                    <Link className="login-link" to="/login"> SignIn </Link>
                    <button type="submit"> Register </button>
                </div>
            </form>
        </section>
        
     );
}
 
export default Register;