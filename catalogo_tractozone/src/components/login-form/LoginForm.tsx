import React, { useState, useRef, useCallback } from 'react';
import { Link, Navigate, useNavigate } from 'react-router-dom';
import Form, {
  Item,
  Label,
  ButtonItem,
  ButtonOptions,
  RequiredRule,
  EmailRule
} from 'devextreme-react/form';
import LoadIndicator from 'devextreme-react/load-indicator';
import notify from 'devextreme/ui/notify';
import { useAuth } from '../../contexts/auth';

import './LoginForm.scss';

export default function LoginForm() {
  const { signIn } = useAuth();
  const [loading, setLoading] = useState(false);
  const formData = useRef({ email: '', password: '' });

  const onSubmit = useCallback(async (e: any) => {
    e.preventDefault();
    const { email, password } = formData.current;
    setLoading(true);

    const result = await signIn(email, password);
    if (!result.isOk) {
      setLoading(false);
      notify('El usuario y/o contraseña no son correctos', 'error', 2000);
    }
  }, [signIn]);

  // const onCreateAccountClick = useCallback(() => {
  //   navigate('/create-account');
  // }, [navigate]);

  return (
    
    <form className={'login-form'} onSubmit={onSubmit}>
      <Form formData={formData.current} disabled={loading}>
        <Item
          dataField={'email'}
          editorType={'dxTextBox'}
          editorOptions={emailEditorOptions}
        >
          <RequiredRule message="Debe ingresar un usuario" />
          {/* <EmailRule message="Email is invalid" /> */}
          <Label visible={false} />
        </Item>
        <Item
          dataField={'password'}
          editorType={'dxTextBox'}
          editorOptions={passwordEditorOptions}
        >
          <RequiredRule message="Debe ingresar una contraseña" />
          <Label visible={false} />
        </Item>
        <ButtonItem>
          <ButtonOptions
            width={'100%'}
            type={'default'}
            useSubmitBehavior={true}
          >
            <span className="dx-button-text">
              {
                loading
                  ? <LoadIndicator width={'24px'} height={'24px'} visible={true} />
                  : 'Iniciar sesión'
              }
            </span>
          </ButtonOptions>
        </ButtonItem>
        <Item>
          <div className={'link'}>
            <Link to={'/reset-password'}>¿Olvidaste tu contraseña?</Link>
          </div>
        </Item>
      </Form>
    </form>
  );
}

const emailEditorOptions = { stylingMode: 'filled', placeholder: 'Email', mode: 'email' };
const passwordEditorOptions = { stylingMode: 'filled', placeholder: 'Password', mode: 'password' };
