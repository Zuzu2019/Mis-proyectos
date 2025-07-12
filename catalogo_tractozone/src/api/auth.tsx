import { signInWithEmailAndPassword } from 'firebase/auth';
import defaultUser from '../utils/default-user';
import { auth } from './database';


export async function signIn(email: string, password: string) {

  try {
    // Send request
    const userCredential = await signInWithEmailAndPassword(auth, email, password);  
      const user = JSON.stringify(userCredential.user.email)
      defaultUser.email = user
  
    return {
      isOk: true,
      data: defaultUser
    };
  }
  catch {
    console.log("usuario incorrecto")
    return {
      isOk: false,
      message: "Authentication failed"
    };
  }
}

export async function getUser() {
  try {
    // Send request

    return {
      isOk: true,
      data: defaultUser
    };
  }
  catch {
    return {
      isOk: false
    };
  }
}

export async function createAccount(email: string, password: string) {
  try {
    // Send request
    console.log(email, password);

    return {
      isOk: true
    };
  }
  catch {
    return {
      isOk: false,
      message: "Failed to create account"
    };
  }
}

export async function changePassword(email: string, recoveryCode?: string) {
  try {
    // Send request
    console.log(email, recoveryCode);

    return {
      isOk: true
    };
  }
  catch {
    return {
      isOk: false,
      message: "Failed to change password"
    }
  }
}

export async function resetPassword(email: string) {
  try {
    // Send request
    console.log(email);

    return {
      isOk: true
    };
  }
  catch {
    return {
      isOk: false,
      message: "Failed to reset password"
    };
  }
}
