import { Routes, Route, Navigate} from 'react-router-dom';
import { AuthProvider } from './contexts/auth';
import { SingleCard } from './layouts';
import { LoginForm, ResetPasswordForm } from './components';
import { NavigationProvider } from './contexts/navigation';


const RutasLogin : React.FC = ()  => {
  return (
    <>
        <AuthProvider>
          <NavigationProvider>
              <Routes>
                <Route
                  path="/login"
                  element={
                    <SingleCard title="Iniciar sesión">
                      <LoginForm />
                    </SingleCard>
                  }
                />
                <Route
                  path='/reset-password'
                  element={
                    <SingleCard
                      title="Reset Password"
                      description=""
                    >
                      <ResetPasswordForm />
                    </SingleCard>
                  }
                />
                {/* <Route path='*' element={<Navigate to={'/login'} />}></Route> */}
              </Routes>
          </NavigationProvider>
        </AuthProvider>
      
    </>
  );
}

export default RutasLogin

