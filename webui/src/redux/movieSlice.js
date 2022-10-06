import { createSlice } from "@reduxjs/toolkit"

const movieSlice = createSlice({
    name: "movie",
    initialState: {
        movies: {
            allMovies: null,
            isFetching: false,
            error: false
        },
        changedLike: {
            isFetching: false,
            success: false,
            error: false
        }
    },
    reducers: {
        getMoviesStart: (state) => {
            state.movies.isFetching = true;
        },
        getMoviesSuccess: (state, action) => {
            state.movies.isFetching = false;
            state.movies.allMovies = action.payload;
            state.movies.error = false;
        },        
        getMoviesFailed: (state) => {
            state.movies.isFetching = false;
            state.movies.error = true;
        },
        changedLikeStart: (state) => {
            state.changedLike.isFetching = true;
        },
        changedLikeSuccess: (state) => {
            state.changedLike.isFetching = false;
            state.changedLike.success = true;
            state.changedLike.error = false;
        },
        changedLikeFailed: (state) => {
            state.changedLike.isFetching = false;
            state.changedLike.success = false;
            state.changedLike.error = true;
        },
    }
})

export const {
    getMoviesStart, getMoviesSuccess, getMoviesFailed,
    changedLikeStart, changedLikeSuccess, changedLikeFailed,
} = movieSlice.actions;

export default movieSlice.reducer;