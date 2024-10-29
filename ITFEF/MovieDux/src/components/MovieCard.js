import React from "react";
import "../styles/styles.css"

export default function MovieCard({movie}){
    const handleError = (e) => {
        e.target.src = "";
    }

    const getRatingClass = (rating) => {
        if(rating >= 8){
            return "Rating good!";
        }
        else if(rating < 8 && rating >= 5){
            return "Rating ok!"
        }
        else{
            return "Rating bad!"
        }
    }

    return(
        <div key={movie.id} className="movie-card">
            <img
            src={'images/${movie.image}'}
            alt={movie.title}
            onError={handleError}
            />
            <div className="movie-card-info"></div>
            <h3 className="movie-card-title">{movie.title}</h3>
            <p className="movie-card-genre">{movie.genre}</p>
            <p className={'movie-card-rating ${getRatingClass(movie.rating)}'}>{movie.rating}</p>
        </div>
    )
}