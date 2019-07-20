import React, { useState } from 'react';
import ReactDOM from 'react-dom'; // or import { render } from 'react-dom' 
//import HelloWorld from './helloWorld';

//const HelloWorld = React.lazy( () => import('.\helloWorld'));

function Clock({current}) {
    const [date, setDate] = useState(current);
    setInterval(() => {
        setDate(new Date());
    }, 1000);
    return (
        <div>{date.toLocaleTimeString()}</div>
    )
}


ReactDOM.render(
    //<HelloWorld age={999} name="Aegis"/>,
    <Clock current={new Date()} />,
    document.getElementById("root")
);