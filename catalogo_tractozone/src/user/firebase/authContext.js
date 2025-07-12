import { useEffect, useState, createContext, useContext } from "react";
import { auth } from "./database";
import { onAuthStateChanged } from "firebase/auth";
  
const AuthContext = createContext(null)

export const AuthProvider = ({ children }) => {
    const [currentUser, setCurrentUser] = useState(null);
 
  
    useEffect(() => {
      const unsubscribe = onAuthStateChanged(auth, (user) => {
        setCurrentUser(user);
      });
  
      return () => unsubscribe();
    }, []);
    console.log(currentUser)
  
    return (
      <AuthContext.Provider value={{ currentUser }}>{children}</AuthContext.Provider>
    );
  };
  
  export const useAuth = () => useContext(AuthContext);