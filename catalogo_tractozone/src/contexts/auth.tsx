import React, { useState, useEffect, createContext, useContext, useCallback } from 'react';
import { getUser, signIn as sendSignInRequest } from '../api/auth';
import type { User, AuthContextType } from '../types';
import { useNavigate } from 'react-router-dom';

function AuthProvider(props: React.PropsWithChildren<unknown>) {
  const navigate = useNavigate();
  const [user, setUser] = useState<User>();
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    (async function () {
      const result = await getUser();
      if (result.isOk) {
        setUser(result.data);
      }

      setLoading(false);
    })();
  }, []);

  const signIn = useCallback(async (email: string, password: string) => {
    const result = await sendSignInRequest(email, password);
    if (result.isOk) {
      setUser(result.data);
     
    }

    return result;
  }, []);

  const signOut = useCallback(async() => {
    setUser(undefined);
    try {
      await signOut();
      navigate('/login');
    } catch (error) {
      console.error('Error logging out: ', error);
    }
  }, []);

  console.log(user) 


  return (
    <AuthContext.Provider value={{ user, signIn, signOut, loading }} {...props} />
  );
}


const AuthContext = createContext<AuthContextType>({ loading: false } as AuthContextType);
const useAuth = () => useContext(AuthContext);

export { AuthProvider, useAuth }
