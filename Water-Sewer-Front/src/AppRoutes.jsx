import React from "react";
import { Routes, Route, Navigate } from "react-router-dom";
import { MainLayout } from "./App.jsx";
import Home from './Home/home.jsx'
import About from './AboutUs/aboutUs.jsx'
import Contact from './Contact/contact.jsx'

const AppRoutes = () => (
    <Routes>
        <Route path="/" element={<Navigate to="/app/home" />} />
        <Route path="/app" element={<MainLayout />}>
            <Route path="home" element={<Home />} />
            <Route path="about" element={<About />} />
            <Route path="contact" element={<Contact />} />
        </Route>
    </Routes>
);

export default AppRoutes;