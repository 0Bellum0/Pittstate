import logo from './logo.svg';
import './App.css';
import Profile from './Profile';
function App() {
const name = "Mary";
return (<>
<h1>{name}</h1>
<Profile/>
</>);
}
export default App;