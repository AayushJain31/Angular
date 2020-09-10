import { browser , element , by} from "protractor";

export class LoginPage {
    get usernameLabel() {
      return element(by.id('userLabel'));
    }
   
    get username() {
      return element(by.id('username'));
    }
   
    get passwordLabel() {
      return element(by.id('passwordLabel'));
    }
   
    get password() {
      return element(by.id('password'));
    }
   
    // get errorMessage() {
    //   return element(by.className('login-error'));
    // }
   
    get signIn() {
      return element(by.id('loginButton'));
    }
   
    trySignIn(username: string, password: string) {
      this.username.sendKeys(username);
      this.password.sendKeys(password);
      this.signIn.click();
    //   return browser.driver.wait(function() {
    //     return browser.driver.getCurrentUrl().then(function(url) {
    //         return /localhost:4200/.test('/Patient/Add');
    //     });
    //     }, 2000);
    }
   }