import { Component, OnInit } from '@angular/core';
import { LoginService } from '../login.service';
import { LogObj } from './LogObj';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  public username: string;
  public password: string;
  public error: string = '';
  

  constructor(private rest:LoginService) {
    this.username = '';
    this.password = '';
   }

  async login(): Promise<void> {
    const response = (await this.rest.putRest(this.username, this.password));
    alert(await response.text());
  }
  
  ngOnInit() {
  }

}
