import './polyfills';
import './polyfills';
import ReactDOM from 'react-dom/client';
import './index.css';
import App from './App';
import reportWebVitals from './reportWebVitals';
import { licenseKey } from './devextreme-license'; 
import config from 'devextreme/core/config';
config({ licenseKey }); 

const root = ReactDOM.createRoot(
  document.getElementById('root') as HTMLElement
);
root.render(
<App />);

reportWebVitals();
