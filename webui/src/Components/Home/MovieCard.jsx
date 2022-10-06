import { useState } from "react";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faThumbsUp, faXmark } from '@fortawesome/free-solid-svg-icons';
import "./home.css";
const MovieCard = (props) => {
    const { id, title, images, likes, isLiked, handleChangedLike } = props;

    const [numberLikes, setNumberLikes] = useState(likes);
    const [like, setLike] = useState(isLiked);

    const handleClick = (movieId) => {
        handleChangedLike(movieId);
        setLike((prev) => !prev);
        if(like) {
            setNumberLikes((prev) => prev = prev - 1)
        } else {
            setNumberLikes((prev) => prev = prev + 1)
        }
    }
    
    return (
        <>
            <p className="movie-title">{title}</p>
            <div className="movie-img-container">
                <img className="movie-img" src={images} alt={`Piture of ${title}`} />
            </div>
            <div className="home-like">
                <span className="number-like">{numberLikes} likes</span>
                <div style={{cursor: "pointer"}} onClick={() => handleClick(id)}> 
                    {like ? (<FontAwesomeIcon icon={faXmark} size="2x"/>) : (<FontAwesomeIcon icon={faThumbsUp} size="2x"/>)} 
                </div>
            </div>
        </>
    )
}

export default MovieCard;