import { Routes, Route, BrowserRouter } from 'react-router-dom';
import { AuthProvider } from './contexts/auth';
import { Footer} from './components';
import { SideNavOuterToolbar as SideNavBarLayout } from './layouts';
import appInfo from './app-info';
import routes from './app-routes';
import { NavigationProvider } from './contexts/navigation';
import { ReactNode } from 'react';
import { useScreenSizeClass } from './utils/media-query';


const RutasAdmin: React.FC = () => {
  const screenSizeClass = useScreenSizeClass();

  interface ViewAdminProps {
    children: ReactNode;
  }
  const ViewAdmin: React.FC<ViewAdminProps> = ({ children }) => {
    return (
      <div className={`app ${screenSizeClass}`}>
        <SideNavBarLayout title={appInfo.title}>
          {children}
          <Footer>
            Copyright © 2011-{new Date().getFullYear()} {appInfo.title} Inc.
            <br />
            All trademarks or registered trademarks are property of their
            respective owners.
          </Footer>
        </SideNavBarLayout>
      </div>
    );
  };
  
  return (
    <>
        <AuthProvider>
          <NavigationProvider> 
              <Routes>     
                {routes.map(({ path, element }) => (
                  <Route
                    key={path}
                    path={path}
                    element={<ViewAdmin>{element}</ViewAdmin>}
                  />
                ))}
              </Routes>
          </NavigationProvider>
        </AuthProvider>
    </>
  );
}

export default RutasAdmin

