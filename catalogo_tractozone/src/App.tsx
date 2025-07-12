import 'devextreme/dist/css/dx.common.css';
import './themes/generated/theme.base.css';
import './themes/generated/theme.additional.css';
import './dx-styles.scss';
import React from 'react';
import RutasAdmin from './rutas-admin';
import RutasLogin from './rutas-login';
import { LoadPanel, Switch } from 'devextreme-react';
import { useAuth } from './contexts/auth';
import RutasPublicas from './rutas_publicas';
import { BrowserRouter, Navigate, Route, Router, Routes, useLocation } from 'react-router-dom';
import Home from './pages/home/home';
import HomePublic from './user/pages/Home/Home';
import ProtectedRoute from './private-routes';
import { LoginForm } from './components';


// function App() {
//   return (
//     <>
//       <React.StrictMode>
//         <Rutas />
//         <RutasAdmin />
//         <RutasLogin />
//       </React.StrictMode>
//     </>
//   )
// }

function App() {
  const { user, loading } = useAuth();


  if (loading) {
    return <LoadPanel visible={true} />;
  }

  return(
  <BrowserRouter>
    <Routes>
        {/* <Route path="/login" element={<RutasLogin />} /> */}
        {/* <Route path="/home/*" element={<PrivateRoute><RutasAdmin /></PrivateRoute>} /> */}
        <Route path="/*" element={<RutasPublicas />} />  
    </Routes>
    <RutasLogin />
    <RutasAdmin />
  </BrowserRouter>
    
  )
    
}


export default function Root() {
  return (
      <>
      <App /> 
      </>
  );
}


const PrivateRoute: React.FC<{ children: React.ReactElement }> = ({ children }) => {
  const { user } = useAuth();
  const location = useLocation();

  if (!user) {
    return <Navigate to="/login" state={{ from: location }} replace />;
  }

  return children;
};


