import axios from "axios";
import { loginFailed, loginStart, loginSuccess, registerFailed, registerStart, registerSuccess } from "./authSlice";
import { changedLikeFailed, changedLikeStart, changedLikeSuccess, getMoviesFailed, getMoviesStart, getMoviesSuccess } from "./movieSlice";

export const loginUser = async(user, dispatch, navigate) => {
    dispatch(loginStart());
    try {
        const res = await axios.post("/api/User/login", user);
        dispatch(loginSuccess(res.data));
        navigate("/");
    } catch (err) {
        dispatch(loginFailed());
        alert(err.response.data.message)
    }
}

export const registerUser = async(user, dispatch, navigate) => {
    dispatch(registerStart());
    try {
        await axios.post("/api/User/register", user);
        dispatch(registerSuccess());
        alert("Registration successful!");
        navigate("/login");
    } catch (err) {
        dispatch(registerFailed());
        alert(err.response.data.message)
    }
}

export const getAllMovies = async(axiosJWT, token, dispatch, movieList, page) => {
    dispatch(getMoviesStart());
    try {
        const res = await axiosJWT.get("/api/Movie", {
            headers: { Authorization: `Bearer ${token}` },
            params: {
                pageIndex: page,
                pageSize: 20
            }
        });
        if(res.data === '') dispatch(getMoviesSuccess(movieList));
        else dispatch(getMoviesSuccess(movieList == null ? res.data : [...movieList, ...res.data]));
    } catch (err) {
        dispatch(getMoviesFailed());
    }
}

export const changedLike = async(axiosJWT, token, dispatch, id) => {
    dispatch(changedLikeStart());
    try {
        const res = await axiosJWT.put("/api/Movie/changed-like/" + id, {
            headers: { Authorization: `Bearer ${token}` }
        });
        //alert(res.data.message)
        dispatch(changedLikeSuccess());
    } catch (err) {
        alert(err.response.data)
        dispatch(changedLikeFailed());
    }
}