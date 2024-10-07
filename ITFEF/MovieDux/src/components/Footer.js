import React from "react";
import '../styles/styles.css';
export default function Footer(){

    const currentYear = new Date().getFullYear();

    return(
            <div className='footer'>
                <h2>{currentYear} Moviedux. All rights reserved.</h2>
            </div>
    )
}