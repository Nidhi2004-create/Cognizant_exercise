import React, { useState } from 'react';

// Functional component for User Greeting
function UserGreeting() {
  return <h1>Welcome back</h1>;
}

// Functional component for Guest Greeting
function GuestGreeting() {
  return <h1>Please sign up.</h1>;
}

// Conditional Greeting component
function Greeting(props) {
  const isLoggedIn = props.isLoggedIn;
  if (isLoggedIn) {
    return <UserGreeting />;
  }
  return <GuestGreeting />;
}

// Login Button component
function LoginButton(props) {
  return <button onClick={props.onClick}>Login</button>;
}

// Logout Button component
function LogoutButton(props) {
  return <button onClick={props.onClick}>Logout</button>;
}

// Main App component controlling state and element variables
function App() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  const handleLoginClick = () => {
    setIsLoggedIn(true);
  };

  const handleLogoutClick = () => {
    setIsLoggedIn(false);
  };

  // Using an Element Variable to decide which button to show
  let button;
  if (isLoggedIn) {
    button = <LogoutButton onClick={handleLogoutClick} />;
  } else {
    button = <LoginButton onClick={handleLoginClick} />;
  }

  return (
    <div style={{ padding: '50px', textAlign: 'center' }}>
      <Greeting isLoggedIn={isLoggedIn} />
      {button}
    </div>
  );
}

export default App;