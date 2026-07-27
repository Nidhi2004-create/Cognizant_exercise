import React from 'react';
import officeImg from './office.jpg'; // Import your image file or use a web link

function App() {
  // Requirement 1 & 2: Heading & Image source attribute
  const element = "Office Space";
  const jsxatt = (
    <img 
      src={officeImg} 
      width="25%" 
      height="25%" 
      alt="Office Space" 
    />
  );

  // Requirement 3: Office object details
  const ItemName = {
    Name: "DBS",
    Rent: 50000,
    Address: "Chennai"
  };

  // Requirement 4: Dynamic styling logic based on Rent value
  const rentStyle = {
    color: ItemName.Rent <= 60000 ? 'red' : 'green',
    fontWeight: 'bold'
  };

  return (
    <div style={{ padding: '20px' }}>
      <h1>{element} , at Affordable Range</h1>
      {jsxatt}
      
      <h1>Name: {ItemName.Name}</h1>
      <h3 style={rentStyle}>Rent: Rs. {ItemName.Rent}</h3>
      <h3>Address: {ItemName.Address}</h3>
    </div>
  );
}

export default App;