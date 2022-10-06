import axios from "axios";
import { useState } from "react";
import { useEffect } from "react";
import { useDispatch } from "react-redux";
import { useSelector } from "react-redux";
import { useNavigate } from "react-router-dom";
import { changedLike, getAllMovies } from "../../redux/apiRequest";
import { loginSuccess } from "../../redux/authSlice";
import "./home.css";
import MovieCard from "./MovieCard";

const HomePage = () => {
  const user = useSelector((state) => state.auth.login?.currentUser);
  const movieList = useSelector((state) => state.movie.movies?.allMovies);

  const axiosJWT = axios.create();

  axiosJWT.interceptors.request.use(async(config) => {
    dispatch(loginSuccess(user))
    config.headers["Authorization"] = `Bearer ${user.token}`;
    return config;
  }, (err) => {
    return Promise.reject(err);
  })

  const [nextMovies, setNextMovies] = useState(1);

  const dispatch = useDispatch();
  const navigate = useNavigate();

  useEffect(() => {
    if(!user) navigate("/login");
    if (user?.token) getAllMovies(axiosJWT, user?.token, dispatch, movieList, nextMovies);
  }, [nextMovies])

  const handleChangedLike = (movieId) => {
    changedLike(axiosJWT, user.token, dispatch, movieId);
  }

  useEffect(() => {
    const list = document.getElementById('list')
    window.addEventListener('scroll', () => {
      if (window.scrollY + window.innerHeight + 1 >= list.clientHeight + list.offsetTop ) {
        setNextMovies((prev) => prev + 1);
      }
    });
  }, []);

  return (
    <main className="home-container" id="list">
      <div className="home-title">Movie List</div>
      <div className="home-movielist">
        {movieList?.map((movie) => {
          return (
            <div className="movie-container">
              <MovieCard id={movie.id} title={movie.title} images={movie.images} likes={movie.likes} isLiked={movie.isLiked} handleChangedLike={handleChangedLike}/>
            </div>
          );
        })}
      </div>
    </main>
  );
};

export default HomePage;
