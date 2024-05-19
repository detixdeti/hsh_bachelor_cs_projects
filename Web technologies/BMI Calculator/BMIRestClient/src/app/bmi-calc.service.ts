import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http';
import { Person } from './person';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BmiCalcService {
  constructor(private http: HttpClient) { }
  
  callBmiRest(weightValue: number , heightValue: number ): Observable<Person>{
    let body = new Person(weightValue, heightValue, 0, "");
    const headers = { 'Content-Type': 'application/json'};
  
    return this.http.put<Person>('http://localhost:8080/BMIServer/resources/bmi', body, {headers});
  }

}
