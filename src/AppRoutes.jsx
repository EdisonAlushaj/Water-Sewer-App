import React from "react";
import { Routes, Route, Navigate } from "react-router-dom";
import { MainLayout } from "./App.jsx";

const AppRoutes = () => (
  <Routes>
    <Route path="/" element={<Navigate to="/app" />} />
    <Route path="/app" element={<MainLayout />} />
  </Routes>
);

export default AppRoutes;