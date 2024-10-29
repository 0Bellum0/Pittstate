import { useEffect } from "react"
import 
import
import

export default function MovieGrid(){
    

    useEffect{()=>

    }
    
    <div className="filter-bar">
        <div className="filter-slot">
            <label>Genre</label>
            <select className="filter-dropdown" value={genre} >
                <option>All</option>
                <option>Action</option>
                <option>Drama</option>
                <option>Fantasy</option>
                <option>Horror</option>
            </select>
        </div>

        <div className="filter-slot">
            <label>Rating</label>
            <select className="filter-dropdown">
            <option>All</option>
            <option>Good</option>
            <option>Ok</option>
            <option>Bad</option>
            </select>
        </div>
    </div>


}