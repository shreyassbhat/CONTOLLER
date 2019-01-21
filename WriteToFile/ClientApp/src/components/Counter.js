import React, { Component } from 'react';

export class Counter extends Component {
  displayName = Counter.name

  constructor(props) {
    super(props);
    this.state = { currentCount: 0 };
    this.incrementCounter = this.incrementCounter.bind(this);
  }

  incrementCounter() {
      fetch('api/Write', {
          method: 'POST'
      })
  }

  render() {
    return (
      <div>
        <h1>Counter</h1>

        <p>This is a simple example of a React component.</p>

        <p>Current count: <strong>{this.state.currentCount}</strong></p>

        <button onClick={this.incrementCounter}>Increment</button>
      </div>
    );
  }
}
