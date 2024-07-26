import React, { Component, Suspense } from 'react';
import { HashRouter, Outlet } from 'react-router-dom';
import './App.css'
import Header from './Header/header.jsx'
import AppRoutes from './AppRoutes.jsx';

export const MainLayout = () => {
  return (
    <>
      <Header></Header>
      <Suspense fallback={<div>Loading...</div>}>
        <Outlet />
      </Suspense>
    </>
  )
}

class App extends Component {
  render() {
    return (
      <div className="app-wrapper">
        <HashRouter>
          <Suspense fallback={<div>Loading...</div>}>
            <AppRoutes />
          </Suspense>
        </HashRouter>
      </div>
    );
  }
}

export default App