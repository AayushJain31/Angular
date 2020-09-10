import {browser, protractor} from 'protractor';
import {LoginPage} from './login.po';

describe('Login page', () => {
 let page: LoginPage;
 const EC = protractor.ExpectedConditions;

 beforeEach(() => {
   page = new LoginPage();
   browser.get('http://localhost:4200/');
 });

 it('should have correct titles and button text', () => {
   expect(page.usernameLabel.getText()).toEqual('UserName');
   expect(page.passwordLabel.getText()).toEqual('Password');
   expect(page.signIn.getText()).toEqual('');
 });

 it ('should redirect the user to the Patient Add page if they provided correct credentials', () => {
   page.trySignIn('correct', 'correct');
   
 });

});