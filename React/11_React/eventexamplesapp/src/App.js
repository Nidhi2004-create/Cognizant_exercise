import React, { useState } from 'react';
import CurrencyConvertor from './CurrencyConvertor';

function App() {
  const [counter, setCounter] = useState(5);

  // Requirement 1: Increment counter + Multiple method invocations
  const handleIncrement = () => {
    setCounter((prev) => prev + 1);
    sayHello();
  };

  const sayHello = () => {
    alert('Hello! Member1');
  };

  // Decrement counter
  const handleDecrement = () => {
    setCounter((prev) => prev - 1);
  };

  // Requirement 2: Function taking an argument
  const sayWelcome = (msg) => {
    alert(msg);
  };

  // Requirement 3: Synthetic Event Handler
  const handlePress = (e) => {
    alert('I was clicked');
  };

  return (
    <div style={{ padding: '20px' }}>
      <h2>{counter}</h2>

      <div style={{ display: 'flex', flexDirection: 'column', width: '120px', gap: '5px' }}>
        <button onClick={handleIncrement}>Increment</button>
        <button onClick={handleDecrement}>Decrement</button>
        <button onClick={() => sayWelcome('welcome')}>Say welcome</button>
        <button onClick={handlePress}>Click on me</button>
      </div>

      {/* Requirement 4: Currency Convertor Component */}
      <CurrencyConvertor />
    </div>
  );
}

export default App;