import React from "react";
import '../styles/styles.css';
export default function Header(){
    return(
            <div className='header'>
                <img className='logo' src='images/logo.png' alt='moviedux'/>
                <h2 className='app-subtitle'>It's time for popcorn!</h2>
            </div>
    )
}