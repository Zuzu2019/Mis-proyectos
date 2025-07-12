import React from 'react';
import { Navigate } from 'react-router-dom';
import { auth } from './api/database';

const ProtectedRoute = ({ element: Component, ...rest }) => {
  const [user, setUser] = React.useState(null);
  const [loading, setLoading] = React.useState(true);

  React.useEffect(() => {
    const unsubscribe = auth.onAuthStateChanged((user)=> {
      setUser(user);
      setLoading(false);
    });

    return () => unsubscribe();
  }, []);

  if (loading) {
    return <div>Loading...</div>;
  }

  return user ? <Component {...rest} /> : <Navigate to="/login" replace />;
};

export default ProtectedRoute;
