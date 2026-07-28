import React, { useState } from 'react';

function CurrencyConvertor() {
  const [amount, setAmount] = useState('');
  const [currency, setCurrency] = useState('');

  const handleSubmit = (e) => {
    e.preventDefault(); // Prevent form reload
    if (currency.toLowerCase() === 'euro') {
      const converted = amount * 80; // Example conversion rate: 1 Euro = 80 INR
      alert(`Converting to Euro Amount is ${converted}`);
    } else {
      alert(`Entered currency: ${currency}`);
    }
  };

  return (
    <div style={{ marginTop: '30px' }}>
      <h1 style={{ color: 'green' }}>Currency Convertor!!!</h1>
      <form onSubmit={handleSubmit}>
        <div style={{ marginBottom: '10px' }}>
          <label>Amount: </label>
          <input
            type="text"
            value={amount}
            onChange={(e) => setAmount(e.target.value)}
          />
        </div>
        <div style={{ marginBottom: '10px' }}>
          <label>Currency: </label>
          <input
            type="text"
            value={currency}
            onChange={(e) => setCurrency(e.target.value)}
          />
        </div>
        <button type="submit">Submit</button>
      </form>
    </div>
  );
}

export default CurrencyConvertor;