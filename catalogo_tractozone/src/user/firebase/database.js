
import { initializeApp } from "firebase/app";
import {getFirestore } from "firebase/firestore";
import {getAuth} from "firebase/auth"

const firebaseConfig = {
  apiKey: "AIzaSyBpTSVjJ5EFjVPo2nUkEb5-_k8_T-FHRJA",
  authDomain: "catalogo-63d84.firebaseapp.com",
  projectId: "catalogo-63d84",
  storageBucket: "catalogo-63d84.appspot.com",
  messagingSenderId: "224880915803",
  appId: "1:224880915803:web:41188755c4e93ef6f8167e",
  measurementId: "G-XQ3701PGW0"
};


const app = initializeApp(firebaseConfig);
export const db = getFirestore(app);
export const auth = getAuth(app)
