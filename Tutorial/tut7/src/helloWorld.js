import React, {useState} from 'react';

const HelloWorld = ({age, name}) => {
    const [hobby, setHobby] = useState("Piano");
    return (
        <div>
            Hello {age} {name}, {hobby}
            <input onClick = {() => setHobby("PC Games")} value = "update hobby" />
        </div>
    );
}

export default HelloWorld;