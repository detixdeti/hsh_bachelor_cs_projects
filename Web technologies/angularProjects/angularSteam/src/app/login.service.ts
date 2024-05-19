import { HttpClientModule } from '@angular/common/http';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { LogObj } from './login/LogObj';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  constructor(private http: HttpClient) { }

  public putRest(username: string, password: string) {
    let url = 'http://localhost:8080/steam/resources/users'
    let body = new LogObj(username, password)
    return fetch(url, {
      method: "PUT",
      headers: {
          "Content-Type": "application/json"
      },
      body: JSON.stringify(body)
      })
  }

}
