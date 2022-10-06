import "./login.css";
import { Link, useNavigate } from "react-router-dom";
import { useDispatch } from "react-redux";
import { useFormik } from "formik";
import * as Yup from "yup";
import { loginUser } from "../../redux/apiRequest";

const Login = () => {

    const formik = useFormik({
        initialValues: {
          username: "",
          password: "",
        },
        validationSchema: Yup.object({
            username: Yup.string()
            .required("Required")
            .min(4, "Must be 4 characters or more"),
          password: Yup.string()
            .required("Required")
            .min(4, "Must be 4 characters or more"),
        }),
        onSubmit: (values) => {
          loginUser(values, dispatch, navigate);
        },
      });

    const dispatch = useDispatch();
    const navigate = useNavigate();

    return (
        <section className="login-container">
            <div className="login-title"> Welcome to Big Star</div>
            <form onSubmit={formik.handleSubmit}>
                <input type="text" placeholder="Username or Email" id="username" name="username" value={formik.values.username} onChange={formik.handleChange}/>
                {formik.errors.username && (
                    <p> {formik.errors.username} </p>
                )}
                <input type="password" placeholder="Password" id="password" name="password" value={formik.values.password} onChange={formik.handleChange}/>
                {formik.errors.password && (
                    <p> {formik.errors.password} </p>
                )}
                <button type="submit"> Submit </button>
            </form>
            <Link className="login-register-link" to="/register">Clike here to register an account </Link>
        </section>
     );
}
 
export default Login;